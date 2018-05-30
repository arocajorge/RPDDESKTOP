using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_liquidacion_x_punto_cargo_Data
    {
        public List<fa_liquidacion_x_punto_cargo_Info> get_list(int IdEmpresa, int IdSucursal, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                List<fa_liquidacion_x_punto_cargo_Info> Lista = new List<fa_liquidacion_x_punto_cargo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_liquidacion_x_punto_cargo
                              where q.IdEmpresa == IdEmpresa
                              && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                              && Fecha_ini <= q.li_fecha && q.li_fecha <= Fecha_fin
                              select q;

                    foreach (var item in lst)
                    {
                        fa_liquidacion_x_punto_cargo_Info info = new fa_liquidacion_x_punto_cargo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.Su_Descripcion = item.Su_Descripcion;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.li_fecha = item.li_fecha;
                        info.IdTerminoPago = item.IdTerminoPago;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info.li_num_orden = item.li_num_orden;
                        info.li_num_horas = item.li_num_horas;
                        info.li_atencion_a = item.li_atencion_a;
                        info.IdBodega = item.IdBodega;
                        info.li_tipo_pedido = item.li_tipo_pedido;
                        info.estado = item.estado;
                        info.lo_IdProducto = item.lo_IdProducto;
                        info.eg_IdProducto = item.eg_IdProducto;
                        info.in_IdProducto = item.in_IdProducto;
                        info.li_reporte_mantenimiento = item.li_reporte_mantenimiento;
                        info.li_subtotal = item.li_subtotal;
                        info.li_por_iva = item.li_por_iva;
                        info.li_valor_iva = item.li_valor_iva;
                        info.li_total = item.li_total;
                        info.IdCod_Impuesto = item.IdCod_Impuesto;
                        info.li_observacion = item.li_observacion;
                        info.numero_lineas = item.numero_lineas;
                        info.IdCliente = item.IdCliente_cli;
                        info.cod_liquidacion = item.cod_liquidacion;
                        info.li_fecha_orden_mantenimiento = item.li_fecha_orden_mantenimiento;
                        info.li_fecha_reporte_mantenimiento = item.li_fecha_reporte_mantenimiento;
                        info.li_referencia_facturas = item.li_referencia_facturas;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_liquidacion_x_punto_cargo
                              where q.IdEmpresa == info.IdEmpresa
                              && q.IdSucursal == info.IdSucursal
                              && q.IdCentroCosto == info.IdCentroCosto
                              && q.IdLiquidacion == info.IdLiquidacion
                              select q;

                    if (lst.Count() == 0)
                    {
                        fa_liquidacion_x_punto_cargo Entity = new fa_liquidacion_x_punto_cargo();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.IdSucursal = info.IdSucursal;
                        Entity.IdCentroCosto = info.IdCentroCosto;
                        Entity.IdLiquidacion = info.IdLiquidacion = get_id(info.IdEmpresa,info.IdSucursal,info.IdCentroCosto);
                        Entity.IdPunto_cargo = info.IdPunto_cargo;
                        Entity.li_fecha = info.li_fecha = info.li_fecha.Date;
                        Entity.IdTerminoPago = info.IdTerminoPago;
                        Entity.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        Entity.li_num_orden = info.li_num_orden;
                        Entity.li_num_horas = info.li_num_horas;
                        Entity.li_atencion_a = info.li_atencion_a;
                        Entity.IdBodega = info.IdBodega;
                        Entity.li_tipo_pedido = info.li_tipo_pedido;
                        Entity.estado = info.estado = true;
                        Entity.lo_IdProducto = info.lo_IdProducto;
                        Entity.eg_IdProducto = info.eg_IdProducto;
                        Entity.in_IdProducto = info.in_IdProducto;
                        Entity.li_reporte_mantenimiento = info.li_reporte_mantenimiento;
                        Entity.li_subtotal = info.li_subtotal;
                        Entity.li_por_iva = info.li_por_iva;
                        Entity.li_valor_iva = info.li_valor_iva;
                        Entity.li_total = info.li_total;
                        Entity.IdCod_Impuesto = info.IdCod_Impuesto;
                        Entity.li_observacion = info.li_observacion;
                        Entity.li_fecha_orden_mantenimiento = info.li_fecha_orden_mantenimiento;
                        Entity.li_fecha_reporte_mantenimiento = info.li_fecha_reporte_mantenimiento;
                        Context.fa_liquidacion_x_punto_cargo.Add(Entity);
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal get_id(int IdEmpresa, int IdSucursal, string IdCentroCosto)
        {
            try
            {
                decimal ID = 1;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_liquidacion_x_punto_cargo
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              select q;

                    if (lst.Count() != 0)
                        ID = lst.Max(q => q.IdLiquidacion) + 1;
                }
                return ID;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {

                    fa_liquidacion_x_punto_cargo Entity = Context.fa_liquidacion_x_punto_cargo.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa
                          && q.IdSucursal == info.IdSucursal
                          && q.IdCentroCosto == info.IdCentroCosto
                          && q.IdLiquidacion == info.IdLiquidacion);

                    if (Entity != null)
                    {
                        Entity.IdPunto_cargo = info.IdPunto_cargo;
                        Entity.li_fecha = info.li_fecha = info.li_fecha.Date;
                        Entity.IdTerminoPago = info.IdTerminoPago;
                        Entity.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        Entity.li_num_orden = info.li_num_orden;
                        Entity.li_num_horas = info.li_num_horas;
                        Entity.li_atencion_a = info.li_atencion_a;
                        Entity.IdBodega = info.IdBodega;
                        Entity.li_tipo_pedido = info.li_tipo_pedido;
                        Entity.estado = info.estado;
                        Entity.lo_IdProducto = info.lo_IdProducto;
                        Entity.eg_IdProducto = info.eg_IdProducto;
                        Entity.in_IdProducto = info.in_IdProducto;
                        Entity.li_reporte_mantenimiento = info.li_reporte_mantenimiento;
                        Entity.li_subtotal = info.li_subtotal;
                        Entity.li_por_iva = info.li_por_iva;
                        Entity.li_valor_iva = info.li_valor_iva;
                        Entity.li_total = info.li_total;
                        Entity.IdCod_Impuesto = info.IdCod_Impuesto;
                        Entity.li_observacion = info.li_observacion;
                        Entity.li_fecha_orden_mantenimiento = info.li_fecha_orden_mantenimiento;
                        Entity.li_fecha_reporte_mantenimiento = info.li_fecha_reporte_mantenimiento;
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB_referencia_facturas(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {

                    fa_liquidacion_x_punto_cargo Entity = Context.fa_liquidacion_x_punto_cargo.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa
                          && q.IdSucursal == info.IdSucursal
                          && q.IdCentroCosto == info.IdCentroCosto
                          && q.IdLiquidacion == info.IdLiquidacion);

                    if (Entity != null)
                    {
                        Entity.li_referencia_facturas = info.li_referencia_facturas;
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {

                    fa_liquidacion_x_punto_cargo Entity = Context.fa_liquidacion_x_punto_cargo.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa
                          && q.IdSucursal == info.IdSucursal
                          && q.IdCentroCosto == info.IdCentroCosto
                          && q.IdLiquidacion == info.IdLiquidacion);

                    if (Entity != null)
                    {
                        Entity.estado = false;
                        Entity.li_observacion = "**ANULADO** " + info.li_observacion;
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
