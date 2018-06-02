using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;

using Core.Erp.Info.class_sri;

using System.Xml.Serialization;
using System.IO;



namespace Core.Erp.Business.Facturacion
{
    public class fa_factura_Bus
    {
        string mensaje="";

      
        string msg = "";

        string campoAdicional = null;
        string format = "dd/MM/yyyy";

        fa_Factura_Data data = new fa_Factura_Data();
        fa_factura_det_Data dataDetFact = new fa_factura_det_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_factura_x_ct_cbtecble_Data Data_facturas_x_cbtecble = new fa_factura_x_ct_cbtecble_Data();
        

        public Boolean GuardarDB(fa_factura_Info Factura_info, ref decimal IdCbt_vta, ref string numDocFactura, ref string msg, ref string mensajeDocumentoDupli) 
        {
            try
            {
                Boolean resContabilizaFact=false;

                if (Validar_y_corregir_objeto(ref Factura_info, ref msg))
                {
                   
                        /*------------ guardando la factura tanto cabecera como detalle -*/
                        if (data.GuardarDB(Factura_info, ref IdCbt_vta, ref numDocFactura, ref msg) == true)
                        {
                            #region 'guardando la forma de pago '
                            // guardando la forma de pago 
                            fa_factura_x_formaPago_Bus FormPago2_bus = new fa_factura_x_formaPago_Bus();
                            Factura_info.lista_formaPago_x_Factura.ForEach(q => { q.IdEmpresa = Factura_info.IdEmpresa; q.IdSucursal = Factura_info.IdSucursal; q.IdBodega = Factura_info.IdBodega; q.IdCbteVta = Factura_info.IdCbteVta; });
                            FormPago2_bus.GuardarDB(Factura_info.lista_formaPago_x_Factura, ref msg);
                            //----------------------------------------------------------------------
                            #endregion                            

                            #region Cuotas
                            fa_cuotas_x_doc_Bus bus_cuotas = new fa_cuotas_x_doc_Bus();
                            Factura_info.lst_cuotas.ForEach(q => { q.IdEmpresa = Factura_info.IdEmpresa; q.IdSucursal = Factura_info.IdSucursal; q.IdBodega = Factura_info.IdBodega; q.IdCbteVta = Factura_info.IdCbteVta; });
                            bus_cuotas.guardarDB(Factura_info.lst_cuotas);
                            #endregion

                            ///contabilizo la factura 
                            resContabilizaFact = ContabilizarFactura(Factura_info.IdEmpresa, Factura_info.IdSucursal, Factura_info.IdBodega, IdCbt_vta);

                            //Genera inventario
                            Generar_movi_inven(Factura_info);
                        }
                        else
                        {
                            return false;
                        }
                        return true;
                    

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        private void Generar_movi_inven(fa_factura_Info Factura_info)
        {
            try
            {
                fa_parametro_Bus FaPaBus = new fa_parametro_Bus();
                fa_parametro_info Paran_x_fac_inf = new fa_parametro_info();
                Paran_x_fac_inf = FaPaBus.Get_Info_parametro(Factura_info.IdEmpresa);
                fa_factura_x_in_Ing_Egr_Inven_Info info_mov_x_fact = new fa_factura_x_in_Ing_Egr_Inven_Info();
                fa_factura_x_in_Ing_Egr_Inven_Bus bus_mov_x_fact = new fa_factura_x_in_Ing_Egr_Inven_Bus();
                //Compruebo si la factura ya tiene movimiento de inventario
                info_mov_x_fact = bus_mov_x_fact.Get_Info_fa_factura_x_in_Ing_Egr_Inven_Relacion(Factura_info.IdEmpresa, Factura_info.IdSucursal, Factura_info.IdBodega, Factura_info.IdCbteVta);
                
                in_producto_Bus bus_producto = new in_producto_Bus();
                in_Producto_Info info_producto = new in_Producto_Info();                               
                 
                in_movi_inven_tipo_Bus BusTipoInven = new in_movi_inven_tipo_Bus();
                in_movi_inven_tipo_Info InfoTipoInven = new in_movi_inven_tipo_Info();
                InfoTipoInven = BusTipoInven.Get_Info_movi_inven_tipo(Factura_info.IdEmpresa, Paran_x_fac_inf.IdMovi_inven_tipo_Factura);

                if (InfoTipoInven.Genera_Movi_Inven == true)
                {
                    in_producto_x_tb_bodega_Costo_Historico_Bus BusCostoHis = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                    in_Producto_Composicion_Bus bus_composicion_producto = new in_Producto_Composicion_Bus();
                    List<in_Producto_Composicion_Info> lst_composicion = new List<in_Producto_Composicion_Info>();
                    #region Formando in_Ing_Egr_Inven

                    in_Ing_Egr_Inven_Bus Busin_Ing_Egr_Inven = new in_Ing_Egr_Inven_Bus();
                    #region cabecera
                    in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info
                    {
                        IdEmpresa = Factura_info.IdEmpresa,
                        IdNumMovi = info_mov_x_fact.IdNumMovi_in_eg_x_inv,
                        IdSucursal = Factura_info.IdSucursal,
                        IdBodega = Factura_info.IdBodega,
                        CodMoviInven = Factura_info.CodCbteVta,
                        cm_observacion = Factura_info.vt_Observacion,
                        IdMovi_inven_tipo = Paran_x_fac_inf.IdMovi_inven_tipo_Factura,
                        cm_fecha = Factura_info.vt_fecha,
                        IdUsuario = param.IdUsuario,
                        nom_pc = param.nom_pc,
                        ip = param.ip,
                        Fecha_Transac = param.Fecha_Transac,
                        signo = "-",
                        IdMotivo_Inv = 1,
                    };
                    #endregion

                    List<in_Ing_Egr_Inven_det_Info> list_IngEgrDet = new List<in_Ing_Egr_Inven_det_Info>();

                    foreach (var item in Factura_info.DetFactura_List)
                    {
                        in_Producto_Info i_producto = bus_producto.Producto_maneja_inventario(Factura_info.IdEmpresa,item.IdProducto);
                        if (i_producto.maneja_inventario)
                        {
                            lst_composicion = bus_composicion_producto.ObtenerListProductoComposicion(item.IdEmpresa, item.IdProducto);
                            if (lst_composicion.Count > 0)
                            {
                                foreach (var item_comp in lst_composicion)
                                {
                                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info{
                                     IdEstadoAproba = Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString(),
                                     IdEmpresa = Factura_info.IdEmpresa,
                                     IdSucursal = Factura_info.IdSucursal,
                                     IdNumMovi = 0,
                                     Secuencia = item.Secuencia,
                                     IdBodega = Factura_info.IdBodega,
                                     dm_observacion = item.vt_detallexItems,
                                     IdCentroCosto = item.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo,
                                     pr_descripcion = item.pr_descripcion,
                                     IdPunto_cargo = item.IdPunto_cargo,
                                     IdPunto_cargo_grupo = item.IdPunto_cargo_grupo,
                                     IdUnidadMedida_sinConversion = item_comp.IdUnidadMedida,
                                     IdUnidadMedida = item_comp.IdUnidadMedida,
                                     mv_costo_sinConversion = 0,
                                     mv_costo = 0,
                                     IdProducto = item_comp.IdProductoHijo,
                                     dm_cantidad_sinConversion = item.vt_cantidad * item_comp.Cantidad,
                                     dm_cantidad = item.vt_cantidad * item_comp.Cantidad,
                                };
                                    list_IngEgrDet.Add(info);                                    
                                }
                            }
                            else
                            {
                                in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info{
                                 IdEstadoAproba = Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString(),
                                 IdEmpresa = Factura_info.IdEmpresa,
                                 IdSucursal = Factura_info.IdSucursal,
                                 IdNumMovi = 0,
                                 Secuencia = item.Secuencia,
                                 IdBodega = Factura_info.IdBodega,
                                 dm_observacion = item.vt_detallexItems,
                                 IdCentroCosto = item.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo,
                                 pr_descripcion = item.pr_descripcion,
                                 IdPunto_cargo = item.IdPunto_cargo,
                                 IdPunto_cargo_grupo = item.IdPunto_cargo_grupo,
                                 IdUnidadMedida_sinConversion = i_producto.IdUnidadMedida_Consumo,
                                 IdUnidadMedida = i_producto.IdUnidadMedida_Consumo,
                                 mv_costo_sinConversion = 0,
                                 mv_costo = 0,
                                 IdProducto = item.IdProducto,
                                 dm_cantidad_sinConversion = item.vt_cantidad,
                                 dm_cantidad = item.vt_cantidad,
                            };
                                list_IngEgrDet.Add(info);                                
                            }
                        }
                    }
                    if (list_IngEgrDet.Count != 0)
                    {
                        info_IngEgr.listIng_Egr = list_IngEgrDet;
                        if (info_IngEgr.IdNumMovi == 0)
                        {
                            Busin_Ing_Egr_Inven.GuardarDB_aprobar_contabilizar(info_IngEgr);

                            fa_factura_x_in_Ing_Egr_Inven_Bus Bus_Fact_Ing_Egre = new fa_factura_x_in_Ing_Egr_Inven_Bus();
                            fa_factura_x_in_Ing_Egr_Inven_Info Info_Fact_Ing_Egre = new fa_factura_x_in_Ing_Egr_Inven_Info
                            {
                                IdEmpresa_fa = Factura_info.IdEmpresa,
                                IdSucursal_fa = Factura_info.IdSucursal,
                                IdBodega_fa = Factura_info.IdBodega,
                                IdCbteVta_fa = Factura_info.IdCbteVta,
                                IdEmpresa_in_eg_x_inv = info_IngEgr.IdEmpresa,
                                IdSucursal_in_eg_x_inv = info_IngEgr.IdSucursal,
                                IdMovi_inven_tipo_in_eg_x_inv = info_IngEgr.IdMovi_inven_tipo,
                                IdNumMovi_in_eg_x_inv = info_IngEgr.IdNumMovi,
                                observacion = "",
                            };

                            Bus_Fact_Ing_Egre.GuardarDB(Info_Fact_Ing_Egre, ref msg);    
                        }else
                            Busin_Ing_Egr_Inven.ModificarDB_aprobar_contabilizar(info_IngEgr);                        
                    }                    
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }
       
        public Boolean ValidarNumFact(fa_factura_Info info)
        {
            try
            {
                return data.ValidarNumFact(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarNumFact", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
                  

            }
        }

        public Boolean AnularDB(fa_factura_Info info,DateTime fecha_Anulacion ,ref string msg)
        {
            try
            {
                Boolean res;

                fa_Factura_Data data = new fa_Factura_Data();
                string mensaje_cbte_cble = "";
                in_Parametro_Bus busParamIn = new in_Parametro_Bus();
                in_Parametro_Info InfoParamIn = new in_Parametro_Info();
                InfoParamIn = busParamIn.Get_Info_Parametro(info.IdEmpresa);

                ///actualizando la cabecera de factura 
                res = data.AnularDB(info);

                #region Contabilizar reverso
                if (res)
                {
                    res = ContabilizarFacturaREVERSO(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta);
                }
                #endregion

                #region "Eliminando la relacion con las guias de esta factura"
                fa_factura_x_fa_guia_remision_info infoFaxGui = new fa_factura_x_fa_guia_remision_info();
                fa_factura_x_fa_guia_remision_Data data_fac_x_guia = new fa_factura_x_fa_guia_remision_Data();
                infoFaxGui = data_fac_x_guia.Get_Info_fa_factura_x_fa_guia_remision(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta);
                data_fac_x_guia.EliminarFacxGuir(infoFaxGui);
                #endregion

                #region "Anulando movimiento de inventario"

                fa_factura_x_in_Ing_Egr_Inven_Info info_mov_x_fact = new fa_factura_x_in_Ing_Egr_Inven_Info();
                fa_factura_x_in_Ing_Egr_Inven_Bus bus_mov_x_fact = new fa_factura_x_in_Ing_Egr_Inven_Bus();
                //Compruebo si la factura ya tiene movimiento de inventario
                info_mov_x_fact = bus_mov_x_fact.Get_Info_fa_factura_x_in_Ing_Egr_Inven_Relacion(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta);
                if (info_mov_x_fact.IdEmpresa_fa != 0)
                {
                    in_Ing_Egr_Inven_Bus bus_ing_egr = new in_Ing_Egr_Inven_Bus();
                    in_Ing_Egr_Inven_Info info_ing_egr = bus_ing_egr.Get_Info_Ing_Egr_Inven(info_mov_x_fact.IdEmpresa_in_eg_x_inv, info_mov_x_fact.IdSucursal_in_eg_x_inv, info_mov_x_fact.IdMovi_inven_tipo_in_eg_x_inv, info_mov_x_fact.IdNumMovi_in_eg_x_inv);
                    bus_ing_egr.AnularDB(info_ing_egr, ref mensaje);
                }
                #endregion

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };

            }
        }

        public Boolean ModificarDB(fa_factura_Info info, ref string msg)
        {
            try
            {
                fa_Factura_Data Fact_Data = new fa_Factura_Data();
                fa_factura_det_Data Fact_det_Data = new fa_factura_det_Data();
                fa_factura_det_x_fa_descuento_Bus bus_des = new fa_factura_det_x_fa_descuento_Bus();

                Fact_Data.ModificarDB(info, ref msg);
                bus_des.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta);
                decimal id = info.IdCbteVta;
                Fact_det_Data.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta);
                foreach (var item in info.DetFactura_List)
                {
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdSucursal = info.IdSucursal;
                    item.IdBodega = info.IdBodega;
                }
                Fact_det_Data.GuardarDB(info.DetFactura_List, ref id, ref msg);
                
                #region 'guardando la forma de pago '
                // guardando la forma de pago 
                fa_factura_x_formaPago_Bus FormPago2_bus = new fa_factura_x_formaPago_Bus();

                foreach (var item in info.lista_formaPago_x_Factura)
                {
                    item.IdCbteVta = info.IdCbteVta;
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdSucursal = info.IdSucursal;
                    item.IdBodega = info.IdBodega;
                }
                FormPago2_bus.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta, ref mensaje);
                FormPago2_bus.GuardarDB(info.lista_formaPago_x_Factura, ref msg);
                //----------------------------------------------------------------------
                #endregion                            

                #region Cuotas
                fa_cuotas_x_doc_Bus bus_cuotas = new fa_cuotas_x_doc_Bus();
                info.lst_cuotas.ForEach(q => { q.IdEmpresa = info.IdEmpresa; q.IdSucursal = info.IdSucursal; q.IdBodega = info.IdBodega; q.IdCbteVta = info.IdCbteVta; });
                bus_cuotas.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta);
                bus_cuotas.guardarDB(info.lst_cuotas);
                #endregion

                ContabilizarFactura(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta);
                Generar_movi_inven(info);

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public Boolean ModificarDB_proceso_cerrado(fa_factura_Info info, ref string msg)
        {
            try
            {
                fa_Factura_Data Fact_Data = new fa_Factura_Data();
                fa_factura_det_Data Fact_det_Data = new fa_factura_det_Data();
                fa_factura_det_x_fa_descuento_Bus bus_des = new fa_factura_det_x_fa_descuento_Bus();

                Fact_Data.ModificarDB_proceso_cerrado(info, ref msg);               

                #region 'guardando la forma de pago '
                // guardando la forma de pago 
                fa_factura_x_formaPago_Bus FormPago2_bus = new fa_factura_x_formaPago_Bus();

                foreach (var item in info.lista_formaPago_x_Factura)
                {
                    item.IdCbteVta = info.IdCbteVta;
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdSucursal = info.IdSucursal;
                    item.IdBodega = info.IdBodega;
                }
                FormPago2_bus.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta, ref mensaje);
                FormPago2_bus.GuardarDB(info.lista_formaPago_x_Factura, ref msg);
                //----------------------------------------------------------------------
                #endregion

                ContabilizarFactura(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdCbteVta);
                Generar_movi_inven(info);
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public fa_factura_Info Get_Info_factura(int idEmpresa, int idSucursal, int idBodega, decimal IdCbteVta) 
        {
            try
            {
                return data.Get_Info_factura(idEmpresa,  idSucursal,  idBodega,  IdCbteVta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabecera", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           

            }
        }

        public fa_factura_Info Get_Info_factura_x_Numero_Factura(int idEmpresa, int idSucursal, int idBodega, String NumFac)
        {
            try
            {
                return data.Get_Info_factura_x_Numero_Factura(idEmpresa, idSucursal, idBodega, NumFac);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabeceraNumDoc", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           

            }
        }

        public List<fa_factura_Info> Get_List_factura(int IdEmpresa, int IdSucursal,int IdBodega,  DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_List_factura(IdEmpresa, IdSucursal, IdBodega, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_factura", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           

            }
        }

        public List<fa_factura_Info> Get_Lits_FacturaDEV(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_Lits_FacturaDEV(IdEmpresa, IdSucursal, IdBodega, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaFacturaDEV", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           

            }
        }

        public fa_factura_Info Get_Info_FactuXGuia(fa_guia_remision_Info info)
        {
            try
            {
                return data.Get_Info_FactuXGuia(info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsFactuXGuia", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           

            }
        
        }
        
        public Boolean ContabilizarFactura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                fa_factura_Info info = new fa_factura_Info();
                info = data.Get_Info_factura(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
                Generar_Cbte_Ctbl_x_Factura(info);
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ContabilizarFactura", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }
        
        Boolean Generar_Cbte_Ctbl_x_Factura(fa_factura_Info Info)
        {
            try
            {
                Boolean respuesta = false;


                ct_Cbtecble_Bus Bus_CbteCble = new ct_Cbtecble_Bus();
                ct_Cbtecble_Info _CbteCbleInfo = new ct_Cbtecble_Info();
                decimal idctctb = 0;


                if (Data_facturas_x_cbtecble.Get_info_fa_factura_x_ct_cbtecble(param.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdCbteVta,Cl_Enumeradores.eMotivo_Diario_x_Vta.X_FACT ).vt_IdCbteVta != 0)
                { return respuesta; }
                else
                {
                    //contabilizo la factura x venta
                    if (Info.DetFactura_List.Count() == 0)
                    {
                        Info.DetFactura_List = new List<fa_factura_det_info>();
                        fa_factura_det_Bus BusDet = new fa_factura_det_Bus();
                        Info.DetFactura_List =BusDet.Get_List_factura_det(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdCbteVta, ref mensaje);
                   }

                    _CbteCbleInfo =Get_CbteCbleInfo(Info);
                    respuesta =Bus_CbteCble.GrabarDB(_CbteCbleInfo, ref idctctb, ref msg);
                    if (respuesta)
                    {
                        set_factura_x_ct_cbtecble(Info, _CbteCbleInfo,Cl_Enumeradores.eMotivo_Diario_x_Vta.X_FACT);
                    }
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraCbteCtbl", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        void set_factura_x_ct_cbtecble(fa_factura_Info Info, ct_Cbtecble_Info Info_Cbte_Cble, Cl_Enumeradores.eMotivo_Diario_x_Vta motivo)
        {
            try
            {
                fa_factura_x_ct_cbtecble_Info InfoFAxCT = new fa_factura_x_ct_cbtecble_Info();
                InfoFAxCT.ct_IdEmpresa = Info_Cbte_Cble.IdEmpresa;
                InfoFAxCT.ct_IdTipoCbte = Info_Cbte_Cble.IdTipoCbte;
                InfoFAxCT.ct_IdCbteCble = Info_Cbte_Cble.IdCbteCble;
                InfoFAxCT.vt_IdEmpresa = Info.IdEmpresa;
                InfoFAxCT.vt_IdBodega = Info.IdBodega;
                InfoFAxCT.vt_IdSucursal = Info.IdSucursal;
                InfoFAxCT.vt_IdCbteVta = Info.IdCbteVta;
                InfoFAxCT.Motivo = motivo.ToString();

                Data_facturas_x_cbtecble.GuardarDB(InfoFAxCT);   
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_factura_x_ct_cbtecble", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        }

        public ct_Cbtecble_Info Get_CbteCble_x_Costo_Info(fa_factura_Info Info)
        {
            try
            {
                int c;
                ct_Cbtecble_Bus _Cbtebus = new ct_Cbtecble_Bus();
                ct_Cbtecble_tipo_Bus cbtipobus = new ct_Cbtecble_tipo_Bus();
                ct_Periodo_Bus _PeriodoBus = new ct_Periodo_Bus();
                ct_Periodo_Info _PeriodoInfo = new ct_Periodo_Info();
                fa_parametro_Data faParam = new fa_parametro_Data();
                ct_Cbtecble_Info _CbteCbleInfo = new ct_Cbtecble_Info();
                double valorTotal =0;
                string MensajeError = "";
                _PeriodoInfo = _PeriodoBus.Get_Info_Periodo(Info.IdEmpresa, Info.vt_fecha,ref MensajeError);

                if (_PeriodoInfo != null && _PeriodoInfo.pe_cerrado != "S")
                {
                    _CbteCbleInfo.IdEmpresa = Info.IdEmpresa;
                    _CbteCbleInfo.IdUsuario = param.IdUsuario;
                    _CbteCbleInfo.IdPeriodo = _PeriodoInfo.IdPeriodo;
                    _CbteCbleInfo.Anio = _PeriodoInfo.IdanioFiscal;
                    _CbteCbleInfo.Mes = _PeriodoInfo.pe_mes;
                    _CbteCbleInfo.IdTipoCbte = faParam.Get_Info_parametro(param.IdEmpresa).IdTipoCbteCble_Factura_Costo_VTA;
                    _CbteCbleInfo.CodCbteCble = Info.vt_tipoDoc + Info.IdCbteVta;
                    _CbteCbleInfo.cb_Fecha = Info.vt_fecha;
                    _CbteCbleInfo.cb_FechaTransac = param.Fecha_Transac;
                    _CbteCbleInfo.cb_Observacion = "Sucu: " + (Info.Sucursal.Trim()).Substring(0, 3) + " Bodega: " + Info.Bodega.Trim().Substring(0, 3) + " CONT. COSTO DE VTA. # FACT # " + Info.vt_serie1 + "-" + Info.vt_serie2 + "-" + Info.vt_NumFactura + "/" + Info.IdCbteVta.ToString() + " al Cliente " + Convert.ToString((Info.Cliente.Trim()));
                    _CbteCbleInfo.cb_Valor = 0;
                    _CbteCbleInfo.Estado = "A";
                    _CbteCbleInfo.IdUsuario = param.IdUsuario;
                  
                    fa_notaCredDeb_Bus bus = new fa_notaCredDeb_Bus();

                    _CbteCbleInfo._cbteCble_det_lista_info.Clear();
                    _CbteCbleInfo._cbteCble_det_lista_info = get_CbteCble_det_Costo_x_Venta(Info); 
              
                    c = 1;
                    foreach (var item in _CbteCbleInfo._cbteCble_det_lista_info)
                    {
                        item.secuencia = c;
                        c++;
                        item.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                        item.IdEmpresa = _CbteCbleInfo.IdEmpresa;
                        item.dc_Observacion = _CbteCbleInfo.cb_Observacion;
                        item.dc_Valor = Math.Round(item.dc_Valor, 2);
                        if (Math.Round(item.dc_Valor, 2) > 0)
                            valorTotal = valorTotal +Math.Round(item.dc_Valor, 2);
                    }
                    _CbteCbleInfo.cb_Valor = valorTotal;
                    return _CbteCbleInfo;
                }
                else
                {
                    return new ct_Cbtecble_Info();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        }

        public ct_Cbtecble_Info Get_CbteCbleInfo(fa_factura_Info Info)
        {
            try
            {
                int c;
                string MensajeError = "";

                ct_Cbtecble_Bus _Cbtebus = new ct_Cbtecble_Bus();
                ct_Cbtecble_tipo_Bus cbtipobus = new ct_Cbtecble_tipo_Bus();
                ct_Periodo_Bus _PeriodoBus = new ct_Periodo_Bus();
                ct_Periodo_Info _PeriodoInfo = new ct_Periodo_Info();
                fa_parametro_Data faParam = new fa_parametro_Data();
                fa_parametro_info Info_Param_Fact = new fa_parametro_info();
                ct_Cbtecble_Info _CbteCbleInfo = new ct_Cbtecble_Info();

                
                _PeriodoInfo = _PeriodoBus.Get_Info_Periodo(Info.IdEmpresa, Info.vt_fecha,ref MensajeError);
                
                if (_PeriodoInfo != null && _PeriodoInfo.pe_cerrado != "S")
                {
                    Info_Param_Fact = faParam.Get_Info_parametro(Info.IdEmpresa);

                    _CbteCbleInfo.IdEmpresa = Info.IdEmpresa;
                    _CbteCbleInfo.IdUsuario = param.IdUsuario;
                    _CbteCbleInfo.IdPeriodo = _PeriodoInfo.IdPeriodo;
                    _CbteCbleInfo.Anio = _PeriodoInfo.IdanioFiscal;
                    _CbteCbleInfo.Mes = _PeriodoInfo.pe_mes;
                    _CbteCbleInfo.IdTipoCbte = Info_Param_Fact.IdTipoCbteCble_Factura;
                    _CbteCbleInfo.CodCbteCble = Info.vt_tipoDoc + Info.IdCbteVta;
                    _CbteCbleInfo.cb_Fecha = Info.vt_fecha;
                    _CbteCbleInfo.cb_FechaTransac = param.Fecha_Transac;
                    _CbteCbleInfo.cb_Observacion = Info.vt_Observacion + " - Sucu: " + (Info.Sucursal.Trim()).Substring(0, 3) + " Bodega: " + Info.Bodega.Trim().Substring(0, 3) + " FACT # " +  Info.vt_NumFactura + "/" + Info.IdCbteVta.ToString() ;
                    _CbteCbleInfo.cb_Valor = Info.Total;
                    _CbteCbleInfo.Estado = "A";
                    _CbteCbleInfo.IdUsuario = param.IdUsuario;
             
                  
                    fa_notaCredDeb_Bus bus = new fa_notaCredDeb_Bus();

                    _CbteCbleInfo._cbteCble_det_lista_info = get_CbteCble_det_x_Item(Info);

                    c = 1;
                    foreach (var item in _CbteCbleInfo._cbteCble_det_lista_info)
                    {
                        item.secuencia = c;
                        c++;
                        item.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                        item.IdEmpresa = _CbteCbleInfo.IdEmpresa;
                        item.dc_Observacion = (item.dc_Observacion == null || item.dc_Observacion == "") ? _CbteCbleInfo.cb_Observacion : item.dc_Observacion;
                        item.dc_Valor = Math.Round( item.dc_Valor,2);
                    }
                  
                    return _CbteCbleInfo;
                }
                else
                {
                    return new ct_Cbtecble_Info();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det_Costo_x_Venta(fa_factura_Info Info)
        {
            try
            {
                ///--- varialiesl listsas
                List<vwfa_ContabilizacionFactura_x_Costo_Info> DetallEFactura = new List<vwfa_ContabilizacionFactura_x_Costo_Info>();
                List<ct_Cbtecble_det_Info> detallecomprobante = new List<ct_Cbtecble_det_Info>();
                ////////////

                DetallEFactura = data.Get_List_Contabilizacion_x_Costo_x_Venta(Info.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdCbteVta);
                detallecomprobante.Clear();

                ct_Cbtecble_det_Info dte = new ct_Cbtecble_det_Info();
                foreach (var DetalleFAc in DetallEFactura)
                {
                    dte = new ct_Cbtecble_det_Info();

                    dte.IdCtaCble = DetalleFAc.IdCtaCble_Costo;
                    dte.dc_Valor = DetalleFAc.vt_costo;
                    dte.IdCentroCosto = DetalleFAc.IdCentro_Costo_Costo;
                    dte.dc_Observacion = "Ctb x Costo Producto " + DetalleFAc.IdProducto + " cliente:" + Info.Cliente + "/" + Info.IdCliente
                       + " " + Info.vt_tipoDoc + Info.vt_NumFactura + "Sucu:" + Info.IdSucursal;
                    detallecomprobante.Add(dte);

                    dte = new ct_Cbtecble_det_Info();

                    dte.IdCtaCble = DetalleFAc.IdCtaCble_Inven;
                    dte.dc_Valor = -1 * DetalleFAc.vt_costo;
                    dte.IdCentroCosto = DetalleFAc.IdCentro_Costo_Inventario;
                    dte.dc_Observacion = "Ctb x Costo Producto " + DetalleFAc.IdProducto + " cliente:" + Info.Cliente + "/" + Info.IdCliente
                       + " " + Info.vt_tipoDoc + Info.vt_NumFactura + "Sucu:" + Info.IdSucursal;
                    detallecomprobante.Add(dte);

                }
                detallecomprobante.RemoveAll(v => v.dc_Valor == 0);
                return detallecomprobante;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det_x_Item(fa_factura_Info Factura_Info)
        {
            try
            {
                fa_parametro_Data faParam = new fa_parametro_Data();
                fa_parametro_info faInfoParam = new fa_parametro_info();
                List<vwfa_ContabilizacionFactura_x_Item_Info> Factura_detalle_datos = new List<vwfa_ContabilizacionFactura_x_Item_Info>();
                List<ct_Cbtecble_det_Info> detallecomprobante = new List<ct_Cbtecble_det_Info>();
                fa_Cliente_Data CliD = new fa_Cliente_Data();
                fa_Cliente_Info ClienInfo = new fa_Cliente_Info();

                List<vwfa_ContabilizacionFactura_x_descuento_x_item_Info> lst_descuento = new List<vwfa_ContabilizacionFactura_x_descuento_x_item_Info>();
                vwfa_ContabilizacionFactura_x_descuento_x_item_Bus bus_descuento = new vwfa_ContabilizacionFactura_x_descuento_x_item_Bus();

                faInfoParam = faParam.Get_Info_parametro(Factura_Info.IdEmpresa);

                ClienInfo = CliD.Get_Info_Cliente(Factura_Info.IdEmpresa, Factura_Info.IdCliente);

                Factura_detalle_datos = data.Get_List_Contabilizacion_x_Item(Factura_Info.IdEmpresa, Factura_Info.IdSucursal, Factura_Info.IdBodega, Factura_Info.IdCbteVta);
                detallecomprobante.Clear();



                string TipoProceso = "";
                TipoProceso = Factura_Info.vt_tipoDoc.Trim();

                string TipPar_CXC = TipoProceso + "_CXC";
                string TipPar_IVA = TipoProceso + "_IVA";
                string TipPar_DESC = TipoProceso + "_DESC";
                string TipPar_SUBTOTAL_0 = TipoProceso + "_SUBTOTAL_0";
                string TipPar_SUBTOTAL_IVA = TipoProceso + "_SUBTOTAL_IVA";


                string IdCtaCble_cxc = "";
                string IdCtaCble_IVA = "";

                if (Factura_detalle_datos.First().vt_plazo == 0)
                {
                    IdCtaCble_cxc = ClienInfo.IdCtaCble_cxc;
                }
                else
                {
                    IdCtaCble_cxc = ClienInfo.IdCtaCble_cxc_Credito;
                }

                ct_Cbtecble_det_Info dte = new ct_Cbtecble_det_Info();
                IdCtaCble_IVA = faInfoParam.IdCtaCble_IVA;

                #region Cta Cliente
                var cta_cxc = from ing_ in Factura_detalle_datos
                              //where ing_.iva > 0
                              group ing_ by new
                              {
                                  ing_.IdEmpresa,
                                  ing_.IdSucursal,
                                  ing_.IdBodega,
                                  ing_.IdCbteVta
                              }
                                  into grouping
                                  select new { grouping.Key, Total = grouping.Sum(q => q.Total) };

                foreach (var item in cta_cxc)
                {

                    dte.IdCtaCble = IdCtaCble_cxc;
                    dte.dc_Observacion = TipPar_CXC + " cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                        + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;
                    dte.dc_Valor = Math.Round(Convert.ToDouble(item.Total), 2, MidpointRounding.AwayFromZero);
                    detallecomprobante.Add(dte);
                }
                #endregion

                #region Impuestos
                tb_sis_impuesto_Bus BusImpuestos = new tb_sis_impuesto_Bus();
                List<tb_sis_impuesto_Info> ListImpuestos = new List<tb_sis_impuesto_Info>();

                ListImpuestos = BusImpuestos.Get_List_impuesto_x_CtaCble(Factura_Info.IdEmpresa, "IVA");
                if (ListImpuestos.Count() == 0)
                {
                    dte = new ct_Cbtecble_det_Info();
                    dte.IdCtaCble = IdCtaCble_IVA;
                    dte.dc_Valor = Math.Round(Convert.ToDouble(-1 * Factura_detalle_datos.Sum(v => v.iva)), 2, MidpointRounding.AwayFromZero);
                    dte.dc_Observacion = TipPar_IVA + " cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                       + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;
                    detallecomprobante.Add(dte);
                }
                else
                {

                    var TIva_Agr_x_Impuesto = from Cb in Factura_detalle_datos
                                              group Cb by new { Cb.IdEmpresa, Cb.IdCod_Impuesto_Iva, Cb.IdCentroCosto }
                                                  into grouping
                                                  select new { grouping.Key, total_Iva_x_TipoImpuesto = grouping.Sum(p => p.iva) };

                    foreach (var item in TIva_Agr_x_Impuesto)
                    {

                        tb_sis_impuesto_Info Info_Impuest_x_Fact = ListImpuestos.FirstOrDefault(v => v.IdCod_Impuesto == item.Key.IdCod_Impuesto_Iva);

                        if (Info_Impuest_x_Fact != null) // 
                        {
                            if (string.IsNullOrEmpty(Info_Impuest_x_Fact.Info_sis_Impuesto_x_ctacble.IdCtaCble))
                            {
                                dte = new ct_Cbtecble_det_Info();
                                dte.IdCtaCble = IdCtaCble_IVA;
                                dte.dc_Valor = Math.Round(Convert.ToDouble(-1 * item.total_Iva_x_TipoImpuesto), 2, MidpointRounding.AwayFromZero);
                                dte.dc_Observacion = TipPar_IVA + " cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                                   + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;
                                detallecomprobante.Add(dte);
                            }
                            else
                            {

                                dte = new ct_Cbtecble_det_Info();
                                dte.IdCtaCble = Info_Impuest_x_Fact.Info_sis_Impuesto_x_ctacble.IdCtaCble;
                                dte.dc_Valor = Math.Round(Convert.ToDouble(-1 * item.total_Iva_x_TipoImpuesto), 2, MidpointRounding.AwayFromZero);
                                dte.dc_Observacion = TipPar_IVA + " cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                                   + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;
                                detallecomprobante.Add(dte);
                            }
                        }
                        else
                        {
                            dte = new ct_Cbtecble_det_Info();
                            dte.IdCtaCble = IdCtaCble_IVA;
                            dte.dc_Valor = Math.Round(Convert.ToDouble(-1 * item.total_Iva_x_TipoImpuesto), 2, MidpointRounding.AwayFromZero);
                            dte.dc_Observacion = TipPar_IVA + " cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                               + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;
                            detallecomprobante.Add(dte);
                        }

                    }
                }
                #endregion

                #region Subtotal 12
                //obtengo el valor tarifa iva
                var cta_Subtotal_12 = from ing_ in Factura_detalle_datos
                                      where ing_.iva > 0
                                      group ing_ by new
                                      {
                                          ing_.IdEmpresa,
                                          ing_.IdSucursal,
                                          ing_.IdBodega,
                                          ing_.IdCbteVta,
                                          ing_.IdCtaCble_VenIva,
                                          ing_.IdCtaCble_DesIva,
                                          ing_.IdCentroCosto,
                                          ing_.IdCentroCosto_sub_centro_costo,
                                          ing_.IdPunto_cargo_grupo,
                                          ing_.IdPunto_Cargo,
                                          ing_.IdCtaCble_venta_categoria,
                                          ing_.IdCtaCble_Vta_x_impuesto,
                                      }
                                          into grouping
                                          select new { grouping.Key, Subtotal = grouping.Sum(q => q.Subtotal), Desc_vta = grouping.Sum(q => q.Descuento) };

                foreach (var item in cta_Subtotal_12)
                {
                    /*
                    if (item.Desc_vta > 0 && (faInfoParam.pa_Contabiliza_descuento == null ? false : Convert.ToBoolean(faInfoParam.pa_Contabiliza_descuento)))
                    {
                        // descuento en venta
                        dte = new ct_Cbtecble_det_Info();
                        dte.IdCtaCble = (item.Key.IdCtaCble_DesIva == null) ? faInfoParam.pa_IdCtaCble_descuento : item.Key.IdCtaCble_DesIva;
                        dte.dc_Valor = Math.Round(Convert.ToDouble(item.Desc_vta), 2, MidpointRounding.AwayFromZero);

                        dte.IdCentroCosto = item.Key.IdCentroCosto;
                        dte.IdCentroCosto_sub_centro_costo = item.Key.IdCentroCosto_sub_centro_costo;
                        dte.IdPunto_cargo_grupo = item.Key.IdPunto_cargo_grupo;
                        dte.IdPunto_cargo = item.Key.IdPunto_Cargo;

                        dte.dc_Observacion = "Desc/Vta : cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                            + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;
                        detallecomprobante.Add(dte);
                    }
                     */
                    dte = new ct_Cbtecble_det_Info();

                    dte.IdCtaCble = string.IsNullOrEmpty(item.Key.IdCtaCble_VenIva) == true ? (string.IsNullOrEmpty(item.Key.IdCtaCble_venta_categoria) == true ? item.Key.IdCtaCble_Vta_x_impuesto : item.Key.IdCtaCble_venta_categoria) : item.Key.IdCtaCble_VenIva;
                    if (faInfoParam.pa_Contabiliza_descuento == null ? false : Convert.ToBoolean(faInfoParam.pa_Contabiliza_descuento))
                    {
                        dte.dc_Valor = Math.Round(Convert.ToDouble(-1 * item.Subtotal) - Convert.ToDouble(item.Desc_vta), 2, MidpointRounding.AwayFromZero);
                    }
                    else
                        dte.dc_Valor = Math.Round(Convert.ToDouble(item.Subtotal), 2, MidpointRounding.AwayFromZero) * -1; 

                    dte.IdCentroCosto = item.Key.IdCentroCosto;
                    dte.IdCentroCosto_sub_centro_costo = item.Key.IdCentroCosto_sub_centro_costo;
                    dte.IdPunto_cargo_grupo = item.Key.IdPunto_cargo_grupo;
                    dte.IdPunto_cargo = item.Key.IdPunto_Cargo;


                    dte.dc_Observacion = TipPar_SUBTOTAL_0 + " cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                                    + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;
                    detallecomprobante.Add(dte);

                }
                #endregion

                #region Subtotal 0
                //obtengo el valor tarifa 0%
                var cta_Subtotal_0 = from ing_ in Factura_detalle_datos
                                     where ing_.iva <= 0
                                     group ing_ by new
                                     {
                                         ing_.IdEmpresa,
                                         ing_.IdSucursal,
                                         ing_.IdBodega,
                                         ing_.IdCbteVta,
                                         ing_.IdCtaCble_Ven0,
                                         ing_.IdCtaCble_Des0,
                                         ing_.IdCentroCosto,
                                         ing_.IdCentroCosto_sub_centro_costo,
                                         ing_.IdPunto_cargo_grupo,
                                         ing_.IdPunto_Cargo,
                                         ing_.IdCtaCble_venta_categoria,
                                         ing_.IdCtaCble_Vta_x_impuesto
                                     }
                                         into grouping
                                         select new { grouping.Key, Subtotal = grouping.Sum(q => q.Subtotal), Desc_vta = grouping.Sum(q => q.Descuento) };


                foreach (var item in cta_Subtotal_0)
                {
                    /*
                    if (item.Desc_vta > 0 && (faInfoParam.pa_Contabiliza_descuento == null ? false : Convert.ToBoolean(faInfoParam.pa_Contabiliza_descuento)))
                    {
                        // descuento en venta
                        dte = new ct_Cbtecble_det_Info();
                        dte.IdCtaCble = (item.Key.IdCtaCble_Des0 == null) ? faInfoParam.pa_IdCtaCble_descuento : item.Key.IdCtaCble_Des0;
                        dte.dc_Valor = Math.Round(Convert.ToDouble(item.Desc_vta), 2, MidpointRounding.AwayFromZero);
                        dte.dc_Observacion = "Desc/Vta : cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                            + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;

                        dte.IdCentroCosto = item.Key.IdCentroCosto;
                        dte.IdCentroCosto_sub_centro_costo = item.Key.IdCentroCosto_sub_centro_costo;
                        dte.IdPunto_cargo_grupo = item.Key.IdPunto_cargo_grupo;
                        dte.IdPunto_cargo = item.Key.IdPunto_Cargo;

                        detallecomprobante.Add(dte);
                    }
                    */


                    dte = new ct_Cbtecble_det_Info();

                    dte.IdCtaCble = string.IsNullOrEmpty(item.Key.IdCtaCble_Ven0) == true ? (string.IsNullOrEmpty(item.Key.IdCtaCble_venta_categoria) == true ? item.Key.IdCtaCble_Vta_x_impuesto : item.Key.IdCtaCble_venta_categoria) : item.Key.IdCtaCble_Ven0;
                    if (faInfoParam.pa_Contabiliza_descuento == null ? false : Convert.ToBoolean(faInfoParam.pa_Contabiliza_descuento))
                    {
                        dte.dc_Valor = Math.Round(Convert.ToDouble(-1 * item.Subtotal) - Convert.ToDouble(item.Desc_vta), 2, MidpointRounding.AwayFromZero); 
                    }
                    else
                        dte.dc_Valor = Math.Round(Convert.ToDouble(item.Subtotal), 2, MidpointRounding.AwayFromZero) * -1;    
                    
                    dte.dc_Observacion = TipPar_SUBTOTAL_IVA + " cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                                    + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;

                    dte.IdCentroCosto = item.Key.IdCentroCosto;
                    dte.IdCentroCosto_sub_centro_costo = item.Key.IdCentroCosto_sub_centro_costo;
                    dte.IdPunto_cargo_grupo = item.Key.IdPunto_cargo_grupo;
                    dte.IdPunto_cargo = item.Key.IdPunto_Cargo;

                    detallecomprobante.Add(dte);
                }
                #endregion

                if ((faInfoParam.pa_Contabiliza_descuento == null ? false : Convert.ToBoolean(faInfoParam.pa_Contabiliza_descuento)))
                {
                    #region Descuento

                    lst_descuento = bus_descuento.get_list(Factura_Info.IdEmpresa, Factura_Info.IdSucursal, Factura_Info.IdBodega, Factura_Info.IdCbteVta);

                    if (lst_descuento.Count != 0)
                    {
                        var lst_des = from des in lst_descuento
                                      group des by new
                                      {
                                          des.IdEmpresa,
                                          des.IdSucursal,
                                          des.IdBodega,
                                          des.IdCbteVta,
                                          des.de_IdCtaCble,
                                          des.IdCentroCosto,
                                          des.IdCentroCosto_sub_centro_costo,
                                          des.IdPunto_cargo_grupo,
                                          des.IdPunto_Cargo
                                      }
                                          into grouping
                                          select new { grouping.Key, Valor_descuento = grouping.Sum(q => q.vt_DescUnitario) };

                        foreach (var item in lst_des)
                        {
                            dte = new ct_Cbtecble_det_Info();
                            dte.IdCtaCble = (item.Key.de_IdCtaCble == null) ? faInfoParam.pa_IdCtaCble_descuento : item.Key.de_IdCtaCble;
                            dte.dc_Valor = Math.Round(Convert.ToDouble(item.Valor_descuento), 2, MidpointRounding.AwayFromZero);
                            dte.dc_Observacion = "Desc/Vta : cliente:" + Factura_Info.Cliente + "/" + Factura_Info.IdCliente
                                + " " + Factura_Info.vt_tipoDoc + Factura_Info.vt_NumFactura + "Sucu:" + Factura_Info.IdSucursal;

                            dte.IdCentroCosto = item.Key.IdCentroCosto;
                            dte.IdCentroCosto_sub_centro_costo = item.Key.IdCentroCosto_sub_centro_costo;
                            dte.IdPunto_cargo_grupo = item.Key.IdPunto_cargo_grupo;
                            dte.IdPunto_cargo = item.Key.IdPunto_Cargo;

                            detallecomprobante.Add(dte);
                        }    
                    }                    
                    #endregion
                }
                detallecomprobante.RemoveAll(v => v.dc_Valor == 0);
                return detallecomprobante;
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };

            }

        }

       public Boolean ContabilizarFacturaREVERSO(int idEmpresa, int idSucursal, int idBodega, decimal IdCbteVta)
        {
            try
            {
                fa_factura_Info info = new fa_factura_Info();
                info = data.Get_Info_factura(idEmpresa, idSucursal, idBodega, IdCbteVta);
                GeneraCbteCtblREVERSO(info);
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        }

        void GeneraCbteCtblREVERSO(fa_factura_Info Info)
        {
            try
            {
                fa_parametro_Data faParam = new fa_parametro_Data();
                fa_parametro_info faParamInfo = new fa_parametro_info();
                faParamInfo = faParam.Get_Info_parametro(Info.IdEmpresa);
                fa_factura_x_ct_cbtecble_Info InfoFAxCT = new fa_factura_x_ct_cbtecble_Info();
                fa_factura_x_ct_cbtecble_Data DataFAxCT = new fa_factura_x_ct_cbtecble_Data();
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                decimal idctctb = 0;
                //X FACTURA O VENTA
                InfoFAxCT = DataFAxCT.Get_info_fa_factura_x_ct_cbtecble(param.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdCbteVta,Cl_Enumeradores.eMotivo_Diario_x_Vta.X_FACT );
                bus.ReversoCbteCble(param.IdEmpresa, InfoFAxCT.ct_IdCbteCble, InfoFAxCT.ct_IdTipoCbte, faParamInfo.IdTipoCbteCble_Factura_Reverso, ref idctctb, ref msg, param.IdUsuario);
                //X COSTO O INVENTARIO
                InfoFAxCT = DataFAxCT.Get_info_fa_factura_x_ct_cbtecble(param.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdCbteVta,Cl_Enumeradores.eMotivo_Diario_x_Vta.X_INV );
                bus.ReversoCbteCble(param.IdEmpresa, InfoFAxCT.ct_IdCbteCble, InfoFAxCT.ct_IdTipoCbte, faParamInfo.IdTipoCbteCble_Factura_Reverso, ref idctctb, ref msg, param.IdUsuario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
                
            }
        }

        public List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.detalleVentas> Get_List_VentasParaATS(int IdEmpresa, int anio, int mes)
        {
            try
            {
               return data.Get_List_VentasParaATS(IdEmpresa, anio, mes);
            }
            catch(Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        }

        public List<Core.Erp.Info.CuentasxPagar.xmlATS_V_1_1_4.ventaEst> Get_List_VentasXEstablecimientoParaATS(int IdEmpresa, int anio, int mes)
        {
            try
            {
                return data.Get_List_VentasXEstablecimientoParaATS(IdEmpresa, anio, mes);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        }

        Boolean Validar_y_corregir_objeto(ref fa_factura_Info Factura_info ,ref string  msg) 
        {
            try
            {
                 #region 'Validaciones'
                /*--- validaciones */


                if (Factura_info.IdEmpresa <= 0 && Factura_info.IdSucursal <= 0 && Factura_info.IdBodega <= 0)
                {
                    msg = "Error en la cabecera de fact uno de los PK es <=0";
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(fa_factura_Bus) };
                }


                if (Factura_info.IdCliente <= 0 && Factura_info.IdVendedor <= 0)
                {
                    msg = "Erro en la cabecera de fact idcliente o idvendedor es <=0";
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(fa_factura_Bus) };
                }


                if (Factura_info.IdCaja <= 0)
                {
                    msg = "Erro en la cabecera de id caja es <=0";
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(fa_factura_Bus) };
                }


                if (Factura_info.DetFactura_List.Count == 0)
                {
                    msg = "la factura no tiene detalle ";
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validaciones", msg)) { EntityType = typeof(fa_factura_Bus) };
                }

                foreach (var item in Factura_info.DetFactura_List)
                {
                    if (item.vt_cantidad == 0)
                    {
                        msg = "la cantidad es cero:" + item.IdProducto + " tiene cantidad cero ";
                    }

                    if (item.IdProducto == 0)
                    {
                        msg = "el idproducto es cero:" + item.IdProducto ;
                    }

                    if (item.vt_Subtotal == 0)
                    {
                        msg = "el producto id:" + item.IdProducto + " tiene subtotal cero ";
                    }

                    
                }

                /*--- Fin validaciones */


                /*--- corrigiendo data */

                Factura_info.Estado = (string.IsNullOrEmpty(Factura_info.Estado) == true) ? "A" : Factura_info.Estado;
                Factura_info.vt_fecha = Convert.ToDateTime(Factura_info.vt_fecha.ToShortDateString());
                Factura_info.vt_fech_venc = Convert.ToDateTime(Factura_info.vt_fech_venc.ToShortDateString());
                Factura_info.vt_Observacion = (string.IsNullOrEmpty(Factura_info.vt_Observacion) == true) ? "" : Factura_info.vt_Observacion;
                Factura_info.vt_tipo_venta = (string.IsNullOrEmpty(Factura_info.vt_tipo_venta) == true) ? "CON" : Factura_info.vt_tipo_venta;         
                Factura_info.IdUsuario = (string.IsNullOrEmpty(Factura_info.IdUsuario) == true) ? param.IdUsuario : Factura_info.IdUsuario;
                Factura_info.Fecha_Transaccion = (Factura_info.Fecha_Transaccion == null) ? param.Fecha_Transac : Factura_info.Fecha_Transaccion;
                Factura_info.IdPeriodo = (Factura_info.vt_fecha.Year * 100) + Factura_info.vt_fecha.Month;
                Factura_info.vt_anio = Factura_info.vt_fecha.Year;
                Factura_info.vt_mes = Factura_info.vt_fecha.Month;

                foreach (var item in Factura_info.DetFactura_List)
                {
                    item.IdEmpresa = Factura_info.IdEmpresa;
                    item.IdSucursal = Factura_info.IdSucursal;
                    item.IdBodega = Factura_info.IdBodega;
                }
                foreach (var item in Factura_info.DetformaPago_list)
                {
                    item.Fecha =Convert.ToDateTime(item.Fecha.ToShortDateString());
                    item.Fecha_vct =Convert.ToDateTime(item.Fecha_vct.ToShortDateString());
                    
                }

                tb_sis_Documento_Tipo_Talonario_Bus busTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                tb_sis_Documento_Tipo_Talonario_Info infoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();
                tb_Sucursal_Bus Bus_Sucu = new tb_Sucursal_Bus();
                tb_Bodega_Bus Bus_bodega = new tb_Bodega_Bus();

                string mensajeDocumentoDupli = "";
                string cod_estable = "";
                string cod_pto_emision = "";

                /*
                // el objeto viene sin serie o sin # factura tomo el ultimo num de factura del talonario
                if (Factura_info.vt_serie1 == "" || Factura_info.vt_serie1 == null || Factura_info.vt_serie2 == "" || Factura_info.vt_serie2 == null
                    || Factura_info.vt_NumFactura == "" || Factura_info.vt_NumFactura == null)
                {

               

                    cod_estable = Bus_Sucu.Get_Cod_Establecimiento_x_Sucursal(Factura_info.IdEmpresa, Factura_info.IdSucursal);
                    if (Factura_info.IdPuntoVta == null)
                    {
                        cod_pto_emision = Bus_bodega.Get_cod_pto_emision_x_Bodega(Factura_info.IdEmpresa, Factura_info.IdSucursal, Factura_info.IdBodega);
                    }
                    else
                    {
                        int iIdSucursal = 0;
                        int iIdPtoVta = 0;
                        fa_PuntoVta_Bus BusPtoVta = new fa_PuntoVta_Bus();
                        List<fa_PuntoVta_Info> listPuntoVta = new List<fa_PuntoVta_Info>();
                        fa_PuntoVta_Info Info_PuntoVta = new fa_PuntoVta_Info();

                        iIdSucursal = Factura_info.IdSucursal;
                        iIdPtoVta = Convert.ToInt32(Factura_info.IdPuntoVta); 

                        listPuntoVta = BusPtoVta.Get_List_PuntoVta(Factura_info.IdEmpresa);
                        Info_PuntoVta = (fa_PuntoVta_Info)(listPuntoVta.FirstOrDefault(v => v.IdSucursal == iIdSucursal && v.IdPuntoVta == iIdPtoVta));
                       //cod_pto_emision =
                    }
                    infoTalonario = busTalonario.Get_Info_Primer_Documento_no_usado(Factura_info.IdEmpresa, cod_pto_emision, cod_estable, Factura_info.vt_tipoDoc, Factura_info.EsDocumentoElectronico);
                    
                    if (infoTalonario.NumDocumento == null)
                    {
                        msg = "No hay talonarios para Establecimiento=" + cod_estable + " y punto de emision=" + cod_pto_emision;
                        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "no hay talonario activos", msg)) { EntityType = typeof(fa_factura_Bus) };
                    }

                    Factura_info.vt_serie1 = infoTalonario.Establecimiento;
                    Factura_info.vt_serie2 = infoTalonario.PuntoEmision;
                    Factura_info.vt_NumFactura = infoTalonario.NumDocumento;

                }
                else
                {

                    // se puede dar si mas de un usario estan haciendo la factura y tienen en memoria o en la pantalla el mismo talonario
                    //verifico el numero de factura si esta usado
                    infoTalonario.Establecimiento = Factura_info.vt_serie1;
                    infoTalonario.PuntoEmision = Factura_info.vt_serie2;
                    infoTalonario.NumDocumento = Factura_info.vt_NumFactura;
                    infoTalonario.IdEmpresa = Factura_info.IdEmpresa;
                    infoTalonario.CodDocumentoTipo = Factura_info.vt_tipoDoc;
                    infoTalonario.es_Documento_electronico = Factura_info.EsDocumentoElectronico;


                    if (busTalonario.Documento_talonario_esta_Usado(infoTalonario, ref msg, ref mensajeDocumentoDupli))
                    {
                        //si esta en usado busco el siguiente
                        cod_estable = Bus_Sucu.Get_Cod_Establecimiento_x_Sucursal(Factura_info.IdEmpresa, Factura_info.IdSucursal);
                        cod_pto_emision = Bus_bodega.Get_cod_pto_emision_x_Bodega(Factura_info.IdEmpresa, Factura_info.IdSucursal, Factura_info.IdBodega);

                        infoTalonario = busTalonario.Get_Info_Primer_Documento_no_usado(Factura_info.IdEmpresa, cod_pto_emision, cod_estable, Factura_info.vt_tipoDoc, Factura_info.EsDocumentoElectronico);

                        if (infoTalonario.NumDocumento == null)
                        {
                            throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "no hay talonario activos", msg)) { EntityType = typeof(fa_factura_Bus) };
                        }

                        Factura_info.vt_serie1 = infoTalonario.Establecimiento;
                        Factura_info.vt_serie2 = infoTalonario.PuntoEmision;
                        Factura_info.vt_NumFactura = infoTalonario.NumDocumento;
                    }
                }
                

                /*--- corrigiendo data */

                #endregion

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
                
            }
        }

      
        public Boolean get_Keys_CteCble_x_Costo(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref int ct_IdEmpresa, ref int ct_IdTipoCbte, ref decimal ct_IdCbteCble)
        {
            try
            {
                return data.Get_Keys_CteCble_x_Costo(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref  ct_IdEmpresa, ref  ct_IdTipoCbte, ref  ct_IdCbteCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        }

        public Boolean GenerarXml_Factura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta,string RutaDescarga, ref string msg)
        {
            try
            {
              
                string sIdCbteFact = "";

                List<vwfa_factura_sri_Info> lista_Factura_sri = new List<vwfa_factura_sri_Info>();
                vwfa_factura_sri_Bus Bus_Factura = new vwfa_factura_sri_Bus();

                lista_Factura_sri = Bus_Factura.Get_list_Factura_Sri(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref msg);

                if (lista_Factura_sri.Count !=0)
                {
                    //validar objeto
                    if (!ValidarObjeto_XML_Factura(lista_Factura_sri, ref  msg))
                        return false;

                    List<factura> lista = new List<factura>();
                    lista = Get_List_Xml_Factura(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref msg);

                    if (lista.Count != 0)
                    {
                        foreach (var item in lista)
                        {

                            sIdCbteFact = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.FAC + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(factura));
                            StreamWriter myWriter = new StreamWriter(RutaDescarga + sIdCbteFact + ".xml");
                            mySerializer.Serialize(myWriter, item, NamespaceObject);
                            myWriter.Close();

                        }
                    }
                
                }
                            
                return true;
               
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
           
            }
        
        
        }

        public List<factura> Get_List_Xml_Factura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref string msg)
        {
            try
            {
                string secuencia_aux = "";
                string secuencia = "";
                decimal Total_factura = 0;

                List<factura> lista = new List<factura>();

                List<vwfa_factura_sri_Info> consulta = new List<vwfa_factura_sri_Info>();
                vwfa_factura_sri_Bus Bus_Fact_SRI = new vwfa_factura_sri_Bus();

                consulta = Bus_Fact_SRI.Get_list_Factura_Sri(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref msg);

                vwfa_factura_sri_Info info_facturaSRI = new vwfa_factura_sri_Info();

                if (consulta.ToList().Count != 0)
                {
                    //consultar factura det
                    fa_factura_det_Data odetFact = new fa_factura_det_Data();
                    List<fa_factura_det_info> infoDetFact = new List<fa_factura_det_info>();

                    infoDetFact = odetFact.Get_List_factura_det(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref msg);

                    if (infoDetFact.Count != 0)
                    {
                        info_facturaSRI.lista_FacturaDet = infoDetFact;

                        foreach (var item in consulta)
                        {
                            factura myObject = new factura();
                            myObject.version = "1.1.0";
                            myObject.id = facturaID.comprobante;
                            myObject.idSpecified = true;
                            infoTributaria info = new infoTributaria();
                            myObject.infoFactura = new facturaInfoFactura();
                            myObject.infoFactura.totalConImpuestos = new List<facturaInfoFacturaTotalImpuesto>();
                            myObject.infoTributaria = info;
                            myObject.detalles = new List<facturaDetalle>();

                            facturaInfoFacturaTotalImpuesto impuesto = null;
                            info.ambiente = "1";
                            myObject.infoTributaria.tipoEmision = "1";
                            myObject.infoTributaria.razonSocial = item.RazonSocial;
                            myObject.infoTributaria.nombreComercial = item.NombreComercial;
                            myObject.infoTributaria.ruc = item.em_ruc;
                            myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                            //*********************************************************************************
                            myObject.infoTributaria.codDoc = "01";
                            myObject.infoTributaria.estab = item.vt_serie1;
                            myObject.infoTributaria.ptoEmi = item.vt_serie2;


                           


                            //validar secuencial factura
                            secuencia_aux = "";
                            secuencia = "";

                            if (!String.IsNullOrEmpty(item.vt_NumFactura))
                            {
                                if (item.vt_NumFactura.Length < 9)
                                {
                                    int conta = item.vt_NumFactura.Length;
                                    int diferencia = 9 - conta;

                                    secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                                    secuencia = secuencia_aux + item.vt_NumFactura;

                                    item.vt_NumFactura = secuencia;

                                }

                            }

                            myObject.infoTributaria.secuencial = item.vt_NumFactura;
                            myObject.infoTributaria.dirMatriz = item.em_direccion;
                            myObject.infoFactura.fechaEmision = item.vt_fecha.ToString(format);

                            myObject.infoFactura.dirEstablecimiento = item.Su_Direccion;
                            myObject.infoFactura.contribuyenteEspecial = item.ContribuyenteEspecial;

                            if (item.ObligadoAllevarConta == "SI" || item.ObligadoAllevarConta=="S")
                            {
                                myObject.infoFactura.obligadoContabilidad = obligadoContabilidad.SI;
                            }
                            else
                            {
                                myObject.infoFactura.obligadoContabilidad = obligadoContabilidad.NO;
                            }


                            myObject.infoFactura.obligadoContabilidadSpecified = true;


                            switch (item.IdTipoDocumento)
                            {
                                case "CED":
                                    myObject.infoFactura.tipoIdentificacionComprador = "05";
                                    break;
                                case "PAS":
                                    myObject.infoFactura.tipoIdentificacionComprador = "06";
                                    break;

                                case "RUC":
                                    myObject.infoFactura.tipoIdentificacionComprador = "04";
                                    break;
                                default:
                                    break;
                            }

                            myObject.infoFactura.razonSocialComprador = item.cl_RazonSocial;
                            myObject.infoFactura.identificacionComprador = item.pe_cedulaRuc;

                            // calculo impuestos detalle factura

                            double sum_Simpuesto = 0;
                            double sum_totDescto = 0;
                            double sum_Total = 0;

                            List<facturaInfoFacturaTotalImpuesto> lista_Impuesto = new List<facturaInfoFacturaTotalImpuesto>();

                            foreach (var item2 in info_facturaSRI.lista_FacturaDet)
                            {
                                double subtotal = 0;
                                
                                impuesto = new facturaInfoFacturaTotalImpuesto();
                                impuesto.codigo = "2";

                                impuesto imp = new impuesto();
                                facturaDetalle fDetalle = new facturaDetalle();


                                subtotal = item2.vt_cantidad* item2.vt_Precio - item2.vt_DescUnitario;
                                subtotal = Math.Round(subtotal,2);
                                sum_totDescto = sum_totDescto + item2.vt_DescUnitario;

                                sum_Total = sum_Total + item2.vt_total;
                                sum_Simpuesto = sum_Simpuesto + subtotal;

                                Total_factura = Total_factura + Convert.ToDecimal(item2.vt_total);

                                fDetalle.codigoPrincipal = Convert.ToString(item2.IdProducto);
                                fDetalle.codigoAuxiliar = item2.pr_codigo;
                                fDetalle.descripcion = item2.pr_descripcion;

                                fDetalle.cantidad = Math.Round(Convert.ToDecimal(item2.vt_cantidad), 6, MidpointRounding.AwayFromZero);
                                fDetalle.precioUnitario = Math.Round(Convert.ToDecimal(item2.vt_Precio), 6, MidpointRounding.AwayFromZero);
                                fDetalle.descuento = Math.Round(Convert.ToDecimal(item2.vt_DescUnitario), 2, MidpointRounding.AwayFromZero);
                                fDetalle.precioTotalSinImpuesto = Math.Round(Convert.ToDecimal(subtotal), 6, MidpointRounding.AwayFromZero);
                                
                                //Detalle adicional x item
                                if (string.IsNullOrEmpty(item2.vt_detallexItems)==false)
                                {
                                    fDetalle.detallesAdicionales = new List<facturaDetalleDetAdicional>();
                                    facturaDetalleDetAdicional det_adicional = new facturaDetalleDetAdicional();
                                    det_adicional.nombre = "Detalle";
                                    det_adicional.valor = item2.vt_detallexItems.Trim();
                                    fDetalle.detallesAdicionales.Add(det_adicional);
                                }




                                if (item2.vt_iva >0)
                                {
                                    imp.codigo = "2";//iva 
                                    if (item2.vt_por_iva == 12)
                                    {
                                        impuesto.codigoPorcentaje = "2";
                                        impuesto.baseImponible = Math.Round(Convert.ToDecimal(subtotal),2);
                                        impuesto.valor = Math.Round(Convert.ToDecimal(item2.vt_iva), 2);

                                        lista_Impuesto.Add(impuesto);

                                        imp.codigoPorcentaje = "2";
                                        imp.tarifa = 12;
                                    }
                                    else
                                        if (item2.vt_por_iva == 14)
                                        {
                                            impuesto.codigoPorcentaje = "3";

                                            impuesto.baseImponible = Math.Round(Convert.ToDecimal(subtotal),2);
                                            impuesto.valor = Math.Round(Convert.ToDecimal(item2.vt_iva), 2);

                                            lista_Impuesto.Add(impuesto);

                                            imp.codigoPorcentaje = "3";
                                            imp.tarifa = 14;
                                        }
                                    imp.baseImponible = Convert.ToDecimal(subtotal);
                                    imp.valor = Math.Round(Convert.ToDecimal(item2.vt_iva), 2);
                                }
                                else
                                {
                                    impuesto.codigoPorcentaje = "0";
                                    impuesto.baseImponible = Convert.ToDecimal(subtotal);
                                    impuesto.valor = Convert.ToDecimal(item2.vt_iva);

                                    lista_Impuesto.Add(impuesto);

                                    imp.codigo = "2";
                                    imp.codigoPorcentaje = "0";
                                    imp.tarifa = 0;
                                    imp.baseImponible = Convert.ToDecimal(subtotal);
                                    imp.valor = Convert.ToDecimal(item2.vt_iva);


                                }



                                fDetalle.impuestos = new List<impuesto>();
                                fDetalle.impuestos.Add(imp);
                                myObject.detalles.Add(fDetalle);

                            }

                            myObject.infoFactura.totalSinImpuestos = Math.Round(Convert.ToDecimal(sum_Simpuesto),2);
                            myObject.infoFactura.totalDescuento = Math.Round(Convert.ToDecimal(sum_totDescto),2);
                            myObject.infoFactura.propina = Convert.ToDecimal("0");
                            myObject.infoFactura.importeTotal = Math.Round(Convert.ToDecimal(sum_Total), 2);
                            myObject.infoFactura.moneda = "DOLAR";




                            //--====================== FORMA DE PAGO X FACTURA ================
                             fa_factura_x_formaPago_Bus BusFormaPago = new fa_factura_x_formaPago_Bus();
                            List<fa_factura_x_formaPago_Info> listFormaPago = new List<fa_factura_x_formaPago_Info>();
                            listFormaPago = BusFormaPago.Get_List_fa_factura_x_formaPago(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
                            List<pagosPago> listFP = new List<pagosPago>();

                            if (listFormaPago.Count() > 0)
                            {
                                double Couta_Pago = sum_Total / listFormaPago.Count();

                                foreach (var itemFP in listFormaPago)
                                {
                                    pagosPago InfoFP = new pagosPago();
                                    InfoFP.formaPago = itemFP.IdFormaPago;
                                    InfoFP.plazo = item.vt_plazo;
                                    InfoFP.total = Math.Round( Convert.ToDecimal( Couta_Pago), 2);
                                    InfoFP.unidadTiempo = "DIAS";

                                    listFP.Add(InfoFP);

                                }

                                    myObject.infoFactura.pagos = listFP;
                            }



                            var resul_Impuesto = from s in lista_Impuesto
                                                 group s by new { s.codigoPorcentaje, s.codigo } into g
                                                 select new {/*taxGroup= */g.Key.codigoPorcentaje, g.Key.codigo, baseImponible = g.Sum(s => s.baseImponible), Valor = g.Sum(x => x.valor) };

                            foreach (var item3 in resul_Impuesto)
                            {
                                impuesto = new facturaInfoFacturaTotalImpuesto();
                                impuesto.codigo = item3.codigo;
                                impuesto.codigoPorcentaje = item3.codigoPorcentaje;
                                impuesto.baseImponible = item3.baseImponible;
                                impuesto.valor = item3.Valor;

                                myObject.infoFactura.totalConImpuestos.Add(impuesto);

                            }

                            //campos adicionales 
                            myObject.infoAdicional = new List<facturaCampoAdicional>();

                            if (!String.IsNullOrEmpty(item.pe_correo)) //poniendo el correo como campo adicional
                            {
                                campoAdicional = item.pe_correo;
                                
                                Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();

                                if (datosAdc.email_bien_escrito(campoAdicional) == true)
                                {
                                    facturaCampoAdicional compoadicional = new facturaCampoAdicional();
                                    compoadicional.nombre = "MAIL";
                                    compoadicional.Value = campoAdicional;

                                    
                                    myObject.infoAdicional.Add(compoadicional);
                                }
                            }

                       

                            if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.NATURISA)
                            {
                                facturaCampoAdicional compoadicional_observacion_x_fact = new facturaCampoAdicional();
                                compoadicional_observacion_x_fact.nombre = "DETALLE";
                                compoadicional_observacion_x_fact.Value = item.vt_Observacion;
                                myObject.infoAdicional.Add(compoadicional_observacion_x_fact);
                            }

                            lista.Add(myObject);
                        }
                    }
                }
                msg = "Archivo XML de Factura Generado con Exito.";
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }
        
        public Boolean ValidarObjeto_XML_Factura(List<vwfa_factura_sri_Info> lista, ref string MensajeError)
        {
            try
            {
                Boolean res = true;
          
                foreach (var item in lista)
                {
                    //Empresa
                    if (String.IsNullOrEmpty(item.RazonSocial))
                    {
                        MensajeError = "Falta Razón Social Empresa. Por Favor verifique";
                        res = false;
                    }
                    if (String.IsNullOrEmpty(item.NombreComercial))
                    {
                        MensajeError = "Falta Nombre Comercial Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.em_direccion))
                    {
                        MensajeError = "Falta Dirección Matriz Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.em_ruc))
                    {
                        MensajeError = "Falta Tipo de Identificación Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.ContribuyenteEspecial))
                    {
                        MensajeError = "Falta Número de Contribuyente Especial Empresa. Por Favor verifique";
                        res = false;
                    }

                    //Factura
                    if (String.IsNullOrEmpty(item.vt_serie1))
                    {
                        MensajeError = "Falta serie del Documento. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.vt_serie2))
                    {
                        MensajeError = "Falta serie del Documento. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.vt_NumFactura))
                    {
                        MensajeError = "Falta Secuencial del Documento. Por Favor verifique";
                        res = false;
                    }

                    //Cliente
                    if (String.IsNullOrEmpty(item.Su_Direccion))
                    {
                        MensajeError = "Falta Dirección Establecimiento. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.cl_RazonSocial))
                    {
                        MensajeError = "Falta Razón Social Comprador. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.pe_cedulaRuc))
                    {
                        MensajeError = "Falta Identificación del Comprador. Por Favor verifique";
                        res = false;
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public fa_notaCreDeb_Info GetInfo_NotaCredito_X_Anulacion_Factura(fa_factura_Info infoFactura)
        {
            try
            {
                in_producto_x_tb_bodega_Costo_Historico_Bus busCostoHis = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                fa_notaCreDeb_Info _Info = new fa_notaCreDeb_Info();
                fa_parametro_Bus busParam = new fa_parametro_Bus();
                fa_parametro_info infoParam = new fa_parametro_info();
                fa_TipoNota_Bus BusTipoNota = new fa_TipoNota_Bus();
                fa_TipoNota_Info InfoTipoNC = new fa_TipoNota_Info();
                infoParam = busParam.Get_Info_parametro(param.IdEmpresa);
                InfoTipoNC = BusTipoNota.Get_List_TipoNota(infoFactura.IdEmpresa, infoFactura.IdSucursal, infoParam.pa_IdTipoNota_NC_x_Anulacion);

                _Info.IdEmpresa = infoFactura.IdEmpresa;
                _Info.IdNota = 0;
                _Info.CodNota = "";
                _Info.IdSucursal = infoFactura.IdSucursal;
                _Info.IdBodega = infoFactura.IdBodega;
                _Info.no_fecha = infoFactura.vt_fecha;
                _Info.no_fecha_venc = infoFactura.vt_fecha;
                _Info.IdCliente = infoFactura.IdCliente;
                _Info.IdVendedor = infoFactura.IdVendedor;
                _Info.Serie1 = null;
                _Info.Serie2 = null;
                _Info.NumAutorizacion = null;
                _Info.NumNota_Impresa = null;
                _Info.NaturalezaNota = "INT";
                _Info.IdEmpresa_fac_doc_mod = infoFactura.IdEmpresa;
                _Info.IdSucursal_fac_doc_mod = infoFactura.IdSucursal;
                _Info.IdBodega_fac_doc_mod = infoFactura.IdBodega;
                _Info.IdCbteVta_fac_doc_mod = infoFactura.IdCbteVta;
                _Info.no_dev_venta = null;
                //_Info.sc_factura = infoFactura.IdCbteVta;
                _Info.sc_observacion = "*** N/C x Anulación de la factura # : " + infoFactura.IdCbteVta + " del cliente : " + infoFactura.IdCliente;
                _Info.CreDeb = "C";
                _Info.IdTipoNota = infoParam.pa_IdTipoNota_NC_x_Anulacion;
                _Info.IdTipoDoc = "NTCR";

                _Info.Estado = "A";
                _Info.IdDevolucion = 0;
                _Info.IdUsuarioUltMod = null;
                _Info.sc_usuario = infoFactura.IdUsuario;
                _Info.MotiAnula = null;
                _Info.flete = infoFactura.vt_flete;
                _Info.interes = infoFactura.vt_interes;
                _Info.valor1 = infoFactura.vt_OtroValor1;
                _Info.valor2 = infoFactura.vt_OtroValor2;
                _Info.NaturalezaNota = null;
                _Info.seguro = infoFactura.vt_seguro;
                _Info.IdCaja = Convert.ToInt32(infoFactura.IdCaja);

                _Info.nom_pc = infoFactura.nom_pc;
                _Info.ip = infoFactura.ip;
                _Info.IdCtaCble_TipoNota = InfoTipoNC.IdCtaCble;


                List<fa_notaCreDeb_det_Info> listaNCDet = new List<fa_notaCreDeb_det_Info>();
                foreach (var item in infoFactura.DetFactura_List)
                {
                    if (item.vt_cantidad > 0)
                    {
                        fa_notaCreDeb_det_Info info = new fa_notaCreDeb_det_Info();
                        in_producto_x_tb_bodega_Costo_Historico_Info InfoCostoHis = new in_producto_x_tb_bodega_Costo_Historico_Info();
                        InfoCostoHis = busCostoHis.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdProducto, infoFactura.vt_fecha);
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdBodega = item.IdBodega;
                        info.IdSucursal = item.IdSucursal;
                        info.sc_cantidad = Convert.ToSingle(item.vt_cantidad);
                        info.sc_Precio = Convert.ToSingle(item.vt_Precio);
                        info.sc_descUni = Convert.ToSingle(item.vt_DescUnitario);
                        info.sc_PordescUni = Convert.ToSingle(item.vt_PorDescUnitario);
                        info.sc_precioFinal = Convert.ToSingle(item.vt_PrecioFinal);
                        info.sc_subtotal = Convert.ToSingle(item.vt_Subtotal);
                        info.sc_iva = Convert.ToSingle(item.vt_iva);
                        info.sc_total = Convert.ToSingle(item.vt_total);
                        info.sc_costo = Convert.ToDouble(InfoCostoHis.costo);
                        info.IdProducto = item.IdProducto;
                        info.Secuencia = item.Secuencia;
                        info.sc_observacion = "*** N/C x Anulación";
                       // info.sc_pagaIva = (item.vt_tieneIVA == true) ? "S" : "N";
                        info.IdNota = 0;
                        info.sc_estado = Convert.ToString("A");

                        listaNCDet.Add(info);
                    }
                }
                _Info.ListaDetalles.Clear();
                _Info.ListaDetalles = listaNCDet;

                return _Info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfo_NotaCredito", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

        public cxc_cobro_Info Get_Info_Cobro(fa_notaCreDeb_Info _Info, fa_factura_Info InfoFactura)
        {
            try
            {
                cxc_cobro_Info info = new cxc_cobro_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdSucursal = _Info.IdSucursal;
                info.IdCliente = _Info.IdCliente;

                info.cr_fecha = _Info.dv_fecha;
                info.cr_fechaDocu = _Info.dv_fecha;
                info.cr_fechaCobro = _Info.dv_fecha;

                info.IdCobro_a_aplicar = null;
                info.cr_Banco = null;
                info.cr_cuenta = null;
                info.cr_NumDocumento = null;
                info.cr_Tarjeta = null;
                info.cr_propietarioCta = null;
                info.cr_estado = "A";
                info.cr_recibo = 0;
                info.IdBanco = null;
                info.MotiAnula = null;
                info.cr_Codigo = "";

                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                info.IdUsuario = param.IdUsuario;

                // campos vista
                info.IdCobro_tipo = _Info.IdTipoDoc;
                info.IdTipoNotaCredito = _Info.IdTipoNota;
                info.IdCaja = _Info.IdCaja;
                info.cr_TotalCobro = Convert.ToDouble(_Info.ListaDetalles.Sum(q => q.sc_total));
                // campos vista      
                info.cr_observacion = "Cobro por " + _Info.IdTipoDoc + " del cliente id# " + _Info.IdCliente + _Info.sc_observacion;

                //Detalle conciliacion
                List<cxc_cobro_Det_Info> lstCobroDet = new List<cxc_cobro_Det_Info>();
                //foreach (var item in DataFact_Apli)
                //{

                cxc_cobro_Det_Info info_det = new cxc_cobro_Det_Info();

                info_det.IdEmpresa = InfoFactura.IdEmpresa;
                info_det.IdSucursal = InfoFactura.IdSucursal;
                info_det.IdCobro = 0;
                info_det.secuencial = 0;
                info_det.dc_TipoDocumento = InfoFactura.vt_tipoDoc;
                info_det.IdBodega_Cbte = _Info.IdBodega;
                info_det.IdCbte_vta_nota = Convert.ToDecimal(InfoFactura.IdCbteVta);
                info_det.dc_ValorPago = InfoFactura.Total;
                info_det.IdUsuario = InfoFactura.IdUsuario;

                info_det.Fecha_Transac = InfoFactura.vt_fecha;
                info_det.nom_pc = InfoFactura.nom_pc;
                info_det.ip = InfoFactura.ip;

                lstCobroDet.Add(info_det);
                //}

                info.ListaCobro = new List<cxc_cobro_Det_Info>();
                info.ListaCobro = lstCobroDet;

                return info;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Cobro", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };

            }
        }
        public List<fa_factura_Info> Get_List_factura_sin_guia(int IdEmpresa, int IdSucursal, int IdBodega, int idcliente,DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_List_factura_sin_guia(IdEmpresa, IdSucursal, IdBodega, idcliente, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_factura", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };


            }
        }
        public bool Actualizar_campo_facturado(fa_factura_Info info)
        {
            try
            {
                return data.Actualizar_campo_facturado(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }

    }
}
