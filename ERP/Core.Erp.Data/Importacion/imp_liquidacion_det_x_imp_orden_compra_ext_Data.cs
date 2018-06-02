using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Importacion
{
    public class imp_liquidacion_det_x_imp_orden_compra_ext_Data
    {
        public List<imp_liquidacion_det_x_imp_orden_compra_ext_Info> get_list(int IdEmpresa, decimal IdLiquidacion)
        {
            try
            {
                List<imp_liquidacion_det_x_imp_orden_compra_ext_Info> Lista;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    if (IdLiquidacion != 0)
                        Lista = (from q in Context.imp_liquidacion_det_x_imp_orden_compra_ext
                                 join o in Context.imp_orden_compra_ext
                                 on new { q.IdEmpresa, q.IdOrdenCompra_ext } equals new { o.IdEmpresa,o.IdOrdenCompra_ext}
                                 where q.IdEmpresa == IdEmpresa &&
                                 q.IdLiquidacion == IdLiquidacion
                                 && o.IdEmpresa == IdEmpresa 
                                 select new imp_liquidacion_det_x_imp_orden_compra_ext_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdLiquidacion = q.IdLiquidacion,
                                     IdEmpresa_oe = q.IdEmpresa_oe,
                                     IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                     observacion = q.observacion,
                                     oe_fecha = o.oe_fecha,
                                     seleccionado = true,
                                 }).ToList();
                    else
                        Lista = (from q in Context.imp_orden_compra_ext
                                 where !(from f in Context.imp_liquidacion_det_x_imp_orden_compra_ext
                                         where f.IdEmpresa == IdEmpresa
                                         select f.IdOrdenCompra_ext).Contains(q.IdOrdenCompra_ext)
                                 select new imp_liquidacion_det_x_imp_orden_compra_ext_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdLiquidacion = 0,
                                     IdEmpresa_oe = q.IdEmpresa,
                                     IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                     oe_fecha = q.oe_fecha,
                                     observacion = null,
                                     seleccionado = false,
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(List<imp_liquidacion_det_x_imp_orden_compra_ext_Info> Lista)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    foreach (var item in Lista)
                    {
                        imp_liquidacion_det_x_imp_orden_compra_ext Entity = new imp_liquidacion_det_x_imp_orden_compra_ext
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdLiquidacion = item.IdLiquidacion,
                            IdEmpresa_oe = item.IdEmpresa_oe,
                            IdOrdenCompra_ext = item.IdOrdenCompra_ext,
                            observacion = item.observacion
                        };
                        Context.imp_liquidacion_det_x_imp_orden_compra_ext.Add(Entity);
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdLiquidacion)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    Context.Database.ExecuteSqlCommand("DELETE imp_liquidacion_det_x_imp_orden_compra_ext WHERE IdEmpresa = "+IdEmpresa+" and IdLiquidacion = "+IdLiquidacion);
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
