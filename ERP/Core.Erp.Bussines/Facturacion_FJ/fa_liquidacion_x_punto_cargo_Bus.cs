using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_liquidacion_x_punto_cargo_Bus
    {
        fa_liquidacion_x_punto_cargo_Data oData = new fa_liquidacion_x_punto_cargo_Data();
        fa_liquidacion_x_punto_cargo_det_mano_obra_Bus bus_liquidacion_mano_obra = new fa_liquidacion_x_punto_cargo_det_mano_obra_Bus();
        fa_liquidacion_x_punto_cargo_det_mano_obra_det_Bus bus_liquidacion_mano_obra_det = new fa_liquidacion_x_punto_cargo_det_mano_obra_det_Bus();
        fa_liquidacion_x_punto_cargo_det_logistica_Bus bus_liquidacion_logistica = new fa_liquidacion_x_punto_cargo_det_logistica_Bus();
        fa_liquidacion_x_punto_cargo_det_egresos_inventario_Bus bus_liquidacion_egresos = new fa_liquidacion_x_punto_cargo_det_egresos_inventario_Bus();
        fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Bus bus_liquidacion_ingresos = new fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public List<fa_liquidacion_x_punto_cargo_Info> get_list(int IdEmpresa, int IdSucursal, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool GuardarDB(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                if (oData.GuardarDB(info))
                {
                    int sec = 1;

                    foreach (var item in info.lst_det_mano_obra)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdLiquidacion = info.IdLiquidacion;
                        item.mo_secuencia = sec;
                        bus_liquidacion_mano_obra.guardarDB(item);

                        foreach (var item_2 in item.lst_mano_obra_det)
                        {
                            item_2.IdEmpresa = info.IdEmpresa;
                            item_2.IdSucursal = info.IdSucursal;
                            item_2.IdCentroCosto = info.IdCentroCosto;
                            item_2.IdLiquidacion = info.IdLiquidacion;
                            item_2.mo_secuencia = sec;
                        }
                        bus_liquidacion_mano_obra_det.guardarDB(item.lst_mano_obra_det);
                        sec++;
                    }

                    foreach (var item in info.lst_det_logistica)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdLiquidacion = info.IdLiquidacion;
                    }

                    bus_liquidacion_logistica.guardarDB(info.lst_det_logistica);

                    foreach (var item in info.lst_det_egresos)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdLiquidacion = info.IdLiquidacion;
                    }

                    bus_liquidacion_egresos.guardarDB(info.lst_det_egresos);

                    foreach (var item in info.lst_det_ingresos)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdLiquidacion = info.IdLiquidacion;
                    }

                    bus_liquidacion_ingresos.guardarDB(info.lst_det_ingresos);

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool ModificarDB_referencia_facturas(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                return oData.ModificarDB_referencia_facturas(info);
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
        public bool ModificarDB(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                if (oData.ModificarDB(info))
                {
                    bus_liquidacion_mano_obra_det.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion);
                    bus_liquidacion_mano_obra.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion);
                    int sec = 1;
                    foreach (var item in info.lst_det_mano_obra)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdLiquidacion = info.IdLiquidacion;
                        item.mo_secuencia = sec;
                        bus_liquidacion_mano_obra.guardarDB(item);

                        foreach (var item_2 in item.lst_mano_obra_det)
                        {
                            item_2.IdEmpresa = info.IdEmpresa;
                            item_2.IdSucursal = info.IdSucursal;
                            item_2.IdCentroCosto = info.IdCentroCosto;
                            item_2.IdLiquidacion = info.IdLiquidacion;
                            item_2.mo_secuencia = sec;
                        }
                        bus_liquidacion_mano_obra_det.guardarDB(item.lst_mano_obra_det);
                        sec++;
                    }

                    foreach (var item in info.lst_det_logistica)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdLiquidacion = info.IdLiquidacion;
                    }

                    bus_liquidacion_logistica.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion);
                    bus_liquidacion_logistica.guardarDB(info.lst_det_logistica);

                    foreach (var item in info.lst_det_egresos)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdLiquidacion = info.IdLiquidacion;
                    }

                    bus_liquidacion_egresos.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion);
                    bus_liquidacion_egresos.guardarDB(info.lst_det_egresos);

                    foreach (var item in info.lst_det_ingresos)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdLiquidacion = info.IdLiquidacion;
                    }

                    bus_liquidacion_ingresos.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion);
                    bus_liquidacion_ingresos.guardarDB(info.lst_det_ingresos);

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }        

        public bool AnularDB(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                if (oData.AnularDB(info))
                {
                    bus_liquidacion_ingresos.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion);
                    bus_liquidacion_egresos.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public fa_factura_Info get_info_factura_x_liquidacion(List<fa_liquidacion_x_punto_cargo_Info> lst_info)
        {
            try
            {
                fa_factura_Info info = new fa_factura_Info();
                int cont = 0;
                foreach (var item in lst_info)
                {
                    if (cont == 0)
                        info = get_info_factura_x_liquidacion(item.IdSucursal, Convert.ToInt32(item.IdBodega), item.IdCliente,item.IdTerminoPago);
                    cont++;
                    info.DetFactura_List.AddRange(get_info_factura_det_x_liquidacion(item));
                }

                return info;
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        private fa_factura_Info get_info_factura_x_liquidacion(int IdSucursal, int IdBodega, decimal IdCliente, string IdTipoCredito)
        {
            try
            {
                fa_factura_Info info_factura = new fa_factura_Info();
                info_factura.IdCbteVta = 0;
                info_factura.CodCbteVta = "";
                info_factura.Estado = "A";
                info_factura.Fecha_Transaccion = DateTime.Now;
                info_factura.Fecha_UltAnu = DateTime.Now;
                info_factura.Fecha_UltMod = DateTime.Now;
                info_factura.IdBodega = IdBodega;
                info_factura.IdSucursal = IdSucursal;
                info_factura.IdCliente = IdCliente;
                info_factura.IdEmpresa = param.IdEmpresa;
                info_factura.IdPeriodo = (DateTime.Now.Year * 100) + DateTime.Now.Month;
                info_factura.IdUsuario = param.IdUsuario;
                info_factura.IdUsuarioUltAnu = param.IdUsuario;
                info_factura.IdUsuarioUltModi = param.IdUsuario;
                info_factura.ip = param.ip;
                info_factura.nom_pc = param.nom_pc;
                info_factura.vt_fecha = DateTime.Now.Date;
                info_factura.vt_flete = 0;
                info_factura.vt_interes = 0;
                info_factura.vt_OtroValor1 = 0;
                info_factura.vt_OtroValor2 = 0;
                info_factura.vt_tipo_venta = IdTipoCredito;
                info_factura.vt_seguro = 0;
                info_factura.vt_anio = info_factura.vt_fecha.Year;
                info_factura.vt_mes = info_factura.vt_fecha.Month;

                info_factura.DetFactura_List = new List<fa_factura_det_info>();

                return info_factura;
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        private List<fa_factura_det_info> get_info_factura_det_x_liquidacion(fa_liquidacion_x_punto_cargo_Info info_liquidacion)
        {
            try
            {
                List<fa_factura_det_info> lst_factura = new List<fa_factura_det_info>();

                ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
                ct_punto_cargo_Info info_punto_cargo = bus_punto_cargo.Get_Info_Punto_cargo(info_liquidacion.IdEmpresa, info_liquidacion.IdPunto_cargo);

                info_liquidacion.lst_det_mano_obra = bus_liquidacion_mano_obra.get_list(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion);

                var lst_mo_agrupada = (from q in info_liquidacion.lst_det_mano_obra
                                       group q by new { q.IdEmpresa, q.IdProducto }
                                           into agrup
                                           select new { 
                                               agrup.Key,
                                               precio = agrup.Sum(q=>q.mo_precio_uni+q.mo_valor_ganancia),
                                               cantidad = agrup.Sum(q=>q.mo_horas),                                                    
                                           });

                foreach (var item in lst_mo_agrupada)
                {
                    fa_factura_det_info det_mo = new fa_factura_det_info();
                    det_mo.IdEmpresa = info_liquidacion.IdEmpresa;
                    det_mo.IdSucursal = info_liquidacion.IdSucursal;
                    det_mo.IdBodega = info_liquidacion.IdBodega == null ? 0 : Convert.ToInt32(info_liquidacion.IdBodega);
                    det_mo.IdCbteVta = 0;
                    det_mo.vt_cantidad = item.cantidad;
                    det_mo.vt_Precio = item.precio;
                    det_mo.vt_PorDescUnitario = 0;
                    det_mo.vt_DescUnitario = 0;
                    det_mo.vt_PrecioFinal = det_mo.vt_Precio;
                    det_mo.IdProducto = item.Key.IdProducto;
                    det_mo.vt_Subtotal = item.cantidad*item.precio;
                    det_mo.vt_iva = det_mo.vt_Subtotal * (info_liquidacion.li_por_iva / 100);
                    det_mo.vt_total = det_mo.vt_Subtotal + det_mo.vt_iva;
                    det_mo.vt_estado = "A";
                    det_mo.vt_por_iva = info_liquidacion.li_por_iva;
                    det_mo.IdPunto_cargo = info_punto_cargo.IdPunto_cargo;
                    det_mo.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                    det_mo.IdCentroCosto = info_liquidacion.IdCentroCosto;
                    det_mo.IdCentroCosto_sub_centro_costo = info_liquidacion.IdCentroCosto_sub_centro_costo;
                    det_mo.IdCod_Impuesto_Iva = info_liquidacion.IdCod_Impuesto;
                    det_mo.vt_detallexItems = info_liquidacion.cod_liquidacion;
                    lst_factura.Add(det_mo);
                }

                info_liquidacion.lst_det_logistica = bus_liquidacion_logistica.get_list(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion);

                if (info_liquidacion.lst_det_logistica.Count != 0)
                {
                    fa_factura_det_info det_lo = new fa_factura_det_info();
                    det_lo.IdEmpresa = info_liquidacion.IdEmpresa;
                    det_lo.IdSucursal = info_liquidacion.IdSucursal;
                    det_lo.IdBodega = info_liquidacion.IdBodega == null ? 0 : Convert.ToInt32(info_liquidacion.IdBodega);
                    det_lo.IdCbteVta = 0;
                    det_lo.vt_cantidad = 1;
                    det_lo.vt_Precio = info_liquidacion.lst_det_logistica.Sum(q => q.lo_precio_total);
                    det_lo.vt_PorDescUnitario = 0;
                    det_lo.IdProducto = info_liquidacion.lo_IdProducto == null ? 0 : Convert.ToDecimal(info_liquidacion.lo_IdProducto);
                    det_lo.vt_DescUnitario = 0;
                    det_lo.vt_PrecioFinal = det_lo.vt_Precio;
                    det_lo.vt_Subtotal = det_lo.vt_Precio;
                    det_lo.vt_iva = det_lo.vt_Subtotal * (info_liquidacion.li_por_iva / 100);
                    det_lo.vt_total = det_lo.vt_Subtotal + det_lo.vt_iva;
                    det_lo.vt_estado = "A";
                    det_lo.vt_por_iva = info_liquidacion.li_por_iva;
                    det_lo.IdPunto_cargo = info_punto_cargo.IdPunto_cargo;
                    det_lo.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                    det_lo.IdCentroCosto = info_liquidacion.IdCentroCosto;
                    det_lo.IdCentroCosto_sub_centro_costo = info_liquidacion.IdCentroCosto_sub_centro_costo;
                    det_lo.IdCod_Impuesto_Iva = info_liquidacion.IdCod_Impuesto;
                    det_lo.vt_detallexItems = info_liquidacion.cod_liquidacion;
                    lst_factura.Add(det_lo);
                }

                info_liquidacion.lst_det_ingresos = bus_liquidacion_ingresos.get_list(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion);

                if (info_liquidacion.lst_det_ingresos.Count != 0)
                {
                    fa_factura_det_info det_in = new fa_factura_det_info();
                    det_in.IdEmpresa = info_liquidacion.IdEmpresa;
                    det_in.IdSucursal = info_liquidacion.IdSucursal;
                    det_in.IdBodega = info_liquidacion.IdBodega == null ? 0 : Convert.ToInt32(info_liquidacion.IdBodega);
                    det_in.IdCbteVta = 0;
                    det_in.vt_cantidad = 1;
                    det_in.vt_Precio = info_liquidacion.lst_det_ingresos.Sum(q => q.in_precio_total);
                    det_in.vt_PorDescUnitario = 0;
                    det_in.IdProducto = info_liquidacion.in_IdProducto == null ? 0 : Convert.ToDecimal(info_liquidacion.in_IdProducto);
                    det_in.vt_DescUnitario = 0;
                    det_in.vt_PrecioFinal = det_in.vt_Precio;
                    det_in.vt_Subtotal = det_in.vt_Precio;
                    det_in.vt_iva = det_in.vt_Subtotal * (info_liquidacion.li_por_iva / 100);
                    det_in.vt_total = det_in.vt_Subtotal + det_in.vt_iva;
                    det_in.vt_estado = "A";
                    det_in.vt_por_iva = info_liquidacion.li_por_iva;
                    det_in.IdPunto_cargo = info_punto_cargo.IdPunto_cargo;
                    det_in.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                    det_in.IdCentroCosto = info_liquidacion.IdCentroCosto;
                    det_in.IdCentroCosto_sub_centro_costo = info_liquidacion.IdCentroCosto_sub_centro_costo;
                    det_in.IdCod_Impuesto_Iva = info_liquidacion.IdCod_Impuesto;
                    det_in.vt_detallexItems = info_liquidacion.cod_liquidacion;
                    lst_factura.Add(det_in);
                }

                info_liquidacion.lst_det_egresos = bus_liquidacion_egresos.get_list(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion);

                if (info_liquidacion.lst_det_egresos.Count != 0)
                {
                    fa_factura_det_info det_eg = new fa_factura_det_info();
                    det_eg.IdEmpresa = info_liquidacion.IdEmpresa;
                    det_eg.IdSucursal = info_liquidacion.IdSucursal;
                    det_eg.IdBodega = info_liquidacion.IdBodega == null ? 0 : Convert.ToInt32(info_liquidacion.IdBodega);
                    det_eg.IdCbteVta = 0;
                    det_eg.vt_cantidad = 1;
                    det_eg.vt_Precio = info_liquidacion.lst_det_egresos.Sum(q => q.eg_precio_total);
                    det_eg.vt_PorDescUnitario = 0;
                    det_eg.IdProducto = info_liquidacion.eg_IdProducto == null ? 0 : Convert.ToDecimal(info_liquidacion.eg_IdProducto);
                    det_eg.vt_DescUnitario = 0;
                    det_eg.vt_PrecioFinal = det_eg.vt_Precio;
                    det_eg.vt_Subtotal = det_eg.vt_Precio;
                    det_eg.vt_iva = det_eg.vt_Subtotal * (info_liquidacion.li_por_iva / 100);
                    det_eg.vt_total = det_eg.vt_Subtotal + det_eg.vt_iva;
                    det_eg.vt_estado = "A";
                    det_eg.vt_por_iva = info_liquidacion.li_por_iva;
                    det_eg.IdPunto_cargo = info_punto_cargo.IdPunto_cargo;
                    det_eg.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                    det_eg.IdCentroCosto = info_liquidacion.IdCentroCosto;
                    det_eg.IdCentroCosto_sub_centro_costo = info_liquidacion.IdCentroCosto_sub_centro_costo;
                    det_eg.IdCod_Impuesto_Iva = info_liquidacion.IdCod_Impuesto;
                    det_eg.vt_detallexItems = info_liquidacion.cod_liquidacion;
                    lst_factura.Add(det_eg);
                }

                return lst_factura;
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
