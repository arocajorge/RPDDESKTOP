using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_pre_facturacion_det_Fact_x_Gastos_Data
    {
        public List<fa_pre_facturacion_det_Fact_x_Gastos_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<fa_pre_facturacion_det_Fact_x_Gastos_Info> Lista = new List<fa_pre_facturacion_det_Fact_x_Gastos_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    
                    var lst = from q in Context.vwfa_pre_facturacion_det_Fact_x_Gastos
                              where IdEmpresa == q.IdEmpresa && IdPrefacturacion == q.IdPreFacturacion
                              select q;

                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_det_Fact_x_Gastos_Info info = new fa_pre_facturacion_det_Fact_x_Gastos_Info();
                        info.Checked = true;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPreFacturacion = item.IdPreFacturacion;
                        info.secuencia = item.secuencia;
                        info.IdCentro_Costo = item.IdCentro_Costo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        info.IdCbteCble_ct = item.IdCbteCble_ct;
                        info.Cantidad = item.Cantidad;
                        info.Costo_Uni = item.Costo_Uni;
                        info.Subtotal = item.Subtotal;
                        info.Por_Iva = item.Por_Iva;
                        info.Valor_Iva = item.Valor_Iva;
                        info.Total = item.Total;
                        info.Valor_a_cobrar = item.Valor_a_cobrar;
                        info.Facturar = item.Facturar;
                        info.IdTarifario = item.IdTarifario;
                        info.Porc_ganancia = item.Porc_ganancia;
                        info.num_documento = item.num_documento;
                        info.nom_proveedor = item.nom_proveedor;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.Fecha_documento = item.Fecha_documento;
                        info.Observacion = item.Observacion;
                        info.IdTipoMovi_grupo = item.IdTipoMovi_grupo;
                        info.tg_descripcion = item.tg_descripcion;
                        info.secuencia_ct = item.secuencia_ct;
                        info.IdCuota = item.IdCuota;
                        info.secuencia_cuota = item.secuencia_cuota;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_pre_facturacion_det_Fact_x_Gastos_Info> Get_List(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, string IdCentroCosto)
        {
            try
            {
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                List<fa_pre_facturacion_det_Fact_x_Gastos_Info> Lista = new List<fa_pre_facturacion_det_Fact_x_Gastos_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_Fact_x_Gastos_data
                              where IdEmpresa == q.IdEmpresa 
                              && Fecha_ini <= q.co_FechaFactura 
                              && q.co_FechaFactura <= Fecha_fin
                              && q.IdCentroCosto == IdCentroCosto
                              select q;

                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_det_Fact_x_Gastos_Info info = new fa_pre_facturacion_det_Fact_x_Gastos_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCentro_Costo = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdEmpresa_ct = item.IdEmpresa;
                        info.IdTipoCbte_ct = item.IdTipoCbte;
                        info.IdCbteCble_ct = item.IdCbteCble;
                        info.Cantidad = item.Cantidad;
                        info.Costo_Uni = item.co_total;
                        info.Subtotal = item.subtotal_sin_iva == null ? 0 : Convert.ToDouble(item.subtotal_sin_iva);
                        info.Por_Iva = item.co_Por_iva;
                        info.Valor_Iva = Convert.ToDouble(item.valor_iva);
                        info.Total = Convert.ToDouble(item.Total);
                        info.Valor_a_cobrar = Convert.ToDouble(item.subtotal_sin_iva) + Convert.ToDouble(item.valor_iva);
                        info.Facturar = false;
                        info.num_documento = item.co_factura;
                        info.nom_proveedor = item.pe_nombreCompleto;
                        info.Fecha_documento = item.co_FechaFactura;
                        info.Observacion = item.co_observacion;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info.IdTipoMovi_grupo = item.IdTipoMovi_grupo;
                        info.tg_descripcion = item.tg_descripcion;

                        info.secuencia_ct = item.secuencia;
                        info.IdCuota = item.IdCuota;
                        info.secuencia_cuota = item.secuencia_cuota;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_Fact_x_Gastos where IdEmpresa = "+info.IdEmpresa+" and IdPrefacturacion = "+info.IdPreFacturacion);
                }

                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<fa_pre_facturacion_det_Fact_x_Gastos_Info> Lista)
        {
            try
            {
                try
                {
                    int secuencia = 1;
                    foreach (var item in Lista)
                    {
                        using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                        {
                            fa_pre_facturacion_det_Fact_x_Gastos Entity = new fa_pre_facturacion_det_Fact_x_Gastos();
                            Entity.IdEmpresa = item.IdEmpresa;
                            Entity.IdPreFacturacion = item.IdPreFacturacion;
                            Entity.secuencia = item.secuencia = secuencia;
                            Entity.IdCentro_Costo = item.IdCentro_Costo;
                            Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            Entity.IdPunto_cargo = item.IdPunto_cargo;
                            Entity.IdEmpresa_ct = item.IdEmpresa_ct;
                            Entity.IdTipoCbte_ct = item.IdTipoCbte_ct;
                            Entity.IdCbteCble_ct = item.IdCbteCble_ct;
                            Entity.Cantidad = item.Cantidad;
                            Entity.Costo_Uni = item.Costo_Uni;
                            Entity.Subtotal = item.Subtotal;
                            Entity.Por_Iva = item.Por_Iva;
                            Entity.Valor_Iva = item.Valor_Iva;
                            Entity.Total = item.Total;
                            Entity.Valor_a_cobrar = item.Valor_a_cobrar;
                            Entity.Facturar = item.Facturar;
                            Entity.IdTarifario = item.IdTarifario;
                            Entity.Porc_ganancia = item.Porc_ganancia;
                            Entity.num_documento = item.num_documento;
                            Entity.nom_proveedor = item.nom_proveedor;
                            Entity.Fecha_documento = item.Fecha_documento;
                            Entity.Observacion = item.Observacion;
                            Entity.IdTipoMovi_grupo = item.IdTipoMovi_grupo;
                            Entity.secuencia_ct = item.secuencia_ct;
                            Entity.IdCuota = item.IdCuota;
                            Entity.secuencia_cuota = item.secuencia_cuota;
                            Context.fa_pre_facturacion_det_Fact_x_Gastos.Add(Entity);
                            Context.SaveChanges();
                            secuencia++;
                        }
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string mensaje = "";
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
