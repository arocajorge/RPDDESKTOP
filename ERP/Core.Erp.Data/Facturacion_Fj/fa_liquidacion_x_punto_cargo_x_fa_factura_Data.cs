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
    public class fa_liquidacion_x_punto_cargo_x_fa_factura_Data
    {
        public List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info> Lista;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.fa_liquidacion_x_punto_cargo_x_fa_factura
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                             && q.IdCentroCosto == IdCentroCosto && q.IdLiquidacion == IdLiquidacion
                             select new fa_liquidacion_x_punto_cargo_x_fa_factura_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdLiquidacion = q.IdLiquidacion,
                                 IdEmpresa_vta = q.IdEmpresa_vta,
                                 IdSucursal_vta = q.IdSucursal_vta,
                                 IdBodega_vta = q.IdBodega_vta,
                                 IdCbteVta = q.IdCbteVta,
                                 vta_subtotal = q.vta_subtotal,
                                 vta_iva = q.vta_iva,
                                 vta_total = q.vta_total,
                             }).ToList();

                    foreach (var item in Lista)
                    {
                        item.ID = item.IdEmpresa.ToString() + "-" + item.IdSucursal.ToString() + "-" + item.IdBodega_vta + "-" + item.IdCbteVta.ToString();
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

        public List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto)
        {
            try
            {
                List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info> Lista;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.vwfa_liquidacion_x_punto_cargo_x_fa_factura_x_aplicar
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                             && q.IdCentroCosto_cc == IdCentroCosto 
                             select new fa_liquidacion_x_punto_cargo_x_fa_factura_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,                                 
                                 IdEmpresa_vta = q.IdEmpresa,
                                 IdSucursal_vta = q.IdSucursal,
                                 IdBodega_vta = q.IdBodega,
                                 IdCbteVta = q.IdCbteVta,
                                 vta_subtotal = q.vt_Subtotal,
                                 vta_iva = q.vt_iva,
                                 vta_total = q.vt_total,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 num_oc = q.num_oc,
                                 vt_NumFactura = q.vt_NumFactura,
                                 vt_serie1 = q.vt_serie1,
                                 vt_serie2 = q.vt_serie2
                             }).ToList();

                    foreach (var item in Lista)
                    {
                        item.ID = item.IdEmpresa.ToString() + "-" + item.IdSucursal.ToString() + "-" + item.IdBodega_vta + "-" + item.IdCbteVta.ToString();
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

        public bool guardarDB(List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info> Lista)
        {
            try
            {
                foreach (var item in Lista)
                {
                    guardarDB(item);
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

        public bool guardarDB(fa_liquidacion_x_punto_cargo_x_fa_factura_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_liquidacion_x_punto_cargo_x_fa_factura
                              where q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal
                              && q.IdCentroCosto == info.IdCentroCosto && q.IdLiquidacion == info.IdLiquidacion
                              && q.IdEmpresa_vta == info.IdEmpresa_vta && q.IdSucursal_vta == info.IdSucursal_vta
                              && q.IdBodega_vta == info.IdBodega_vta && q.IdCbteVta == info.IdCbteVta
                              select q;
                    if (lst.Count() == 0)
                    {
                        fa_liquidacion_x_punto_cargo_x_fa_factura Entity = new fa_liquidacion_x_punto_cargo_x_fa_factura();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.IdSucursal = info.IdSucursal;
                        Entity.IdCentroCosto = info.IdCentroCosto;
                        Entity.IdLiquidacion = info.IdLiquidacion;
                        Entity.IdEmpresa_vta = info.IdEmpresa_vta;
                        Entity.IdSucursal_vta = info.IdSucursal_vta;
                        Entity.IdBodega_vta = info.IdBodega_vta;
                        Entity.IdCbteVta = info.IdCbteVta;
                        Entity.vta_subtotal = info.vta_subtotal;
                        Entity.vta_iva = info.vta_iva;
                        Entity.vta_total = info.vta_total;
                        Context.fa_liquidacion_x_punto_cargo_x_fa_factura.Add(Entity);
                        Context.SaveChanges();
                    }                    
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

        public bool eliminarDB(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_liquidacion_x_punto_cargo_x_fa_factura where IdEmpresa = "+IdEmpresa+" and IdSucursal = "+IdSucursal+" and IdCentroCosto = '"+IdCentroCosto+"' and IdLiquidacion = "+IdLiquidacion);
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
    }
}
