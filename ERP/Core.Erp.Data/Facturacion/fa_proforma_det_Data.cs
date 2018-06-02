using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_proforma_det_Data
    {
        public List<fa_proforma_det_Info> get_list(int IdEmpresa, int IdSucursal, decimal IdProforma)
        {
            try
            {
                List<fa_proforma_det_Info> Lista;

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    Lista = (from q in Context.fa_proforma_det
                             where q.IdEmpresa == IdEmpresa
                             && q.IdSucursal == IdSucursal
                             && q.IdProforma == IdProforma
                             select new fa_proforma_det_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdProforma = q.IdProforma,
                                 Secuencia = q.Secuencia,
                                 IdProducto = q.IdProducto,
                                 pd_cantidad = q.pd_cantidad,
                                 pd_precio = q.pd_precio,
                                 pd_por_descuento_uni = q.pd_por_descuento_uni,
                                 pd_descuento_uni = q.pd_descuento_uni,
                                 pd_precio_final = q.pd_precio_final,
                                 pd_subtotal = q.pd_subtotal,
                                 IdCod_Impuesto = q.IdCod_Impuesto,
                                 pd_por_iva = q.pd_por_iva,
                                 pd_iva = q.pd_iva,
                                 pd_total = q.pd_total,
                                 anulado = q.anulado
                             }).ToList();
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

        public bool guardarDB(List<fa_proforma_det_Info> lista)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    int sec = 1;
                    foreach (var item in lista)
                    {
                        fa_proforma_det Entity = new fa_proforma_det{
                         IdEmpresa = item.IdEmpresa,
                         IdSucursal = item.IdSucursal,
                         IdProforma = item.IdProforma,
                         Secuencia = item.Secuencia = sec++,
                         IdProducto = item.IdProducto,
                         pd_cantidad = item.pd_cantidad,
                         pd_precio = item.pd_precio,
                         pd_por_descuento_uni = item.pd_por_descuento_uni,
                         pd_descuento_uni = item.pd_descuento_uni,
                         pd_precio_final = item.pd_precio_final,
                         pd_subtotal = item.pd_subtotal,
                         IdCod_Impuesto = item.IdCod_Impuesto,
                         pd_por_iva = item.pd_por_iva,
                         pd_iva = item.pd_iva,
                         pd_total = item.pd_total,
                         anulado = item.anulado
                    };
                        Context.fa_proforma_det.Add(Entity);
                    }
                    Context.SaveChanges();
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

        public bool eliminarDB(int IdEmpresa, int IdSucursal, decimal IdProforma)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    Context.Database.ExecuteSqlCommand("DELETE fa_proforma_det WHERE IdEmpresa = "+IdEmpresa+" AND IdSucursal = "+IdSucursal+" AND IdProforma = "+IdProforma);
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

        public List<fa_proforma_det_Info> get_list_para_facturar(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCliente)
        {
            try
            {
                List<fa_proforma_det_Info> Lista;

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    Lista = (from q in Context.vwfa_proforma_det_por_facturar
                             where q.IdEmpresa == IdEmpresa
                             && q.IdSucursal == IdSucursal
                             && q.IdBodega == IdBodega
                             && q.IdCliente == IdCliente
                             && q.anulado == false
                             select new fa_proforma_det_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdProforma = q.IdProforma,
                                 Secuencia = q.Secuencia,
                                 IdProducto = q.IdProducto,
                                 pd_cantidad = q.pd_cantidad,
                                 pd_precio = q.pd_precio,
                                 pd_por_descuento_uni = q.pd_por_descuento_uni,
                                 pd_descuento_uni = q.pd_descuento_uni,
                                 pd_precio_final = q.pd_precio_final,
                                 pd_subtotal = 0,
                                 IdCod_Impuesto = q.IdCod_Impuesto,
                                 pd_por_iva = q.pd_por_iva,
                                 pd_iva = 0,
                                 pd_total = 0,
                                 pd_cantidad_pendiente = q.pd_cantidad_pendiente,
                                 anulado = q.anulado
                             }).ToList();
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

        public bool anular_detalle(List<fa_proforma_det_Info> lista)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    foreach (var item in lista)
                    {
                        fa_proforma_det Entity = Context.fa_proforma_det.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdProforma == item.IdProforma && q.Secuencia == item.Secuencia).FirstOrDefault();
                        if (Entity != null)
                        {
                            Entity.anulado = true;
                            Context.SaveChanges();
                        }
                    }                    
                }

                return false;
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
