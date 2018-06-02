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
    public class imp_orden_compra_ext_recepcion_Data
    {
        public List<imp_orden_compra_ext_recepcion_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                List<imp_orden_compra_ext_recepcion_Info> Lista;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    Lista = (from q in Context.imp_orden_compra_ext_recepcion
                             where Fecha_ini <= q.or_fecha && q.or_fecha <= Fecha_fin
                             select new imp_orden_compra_ext_recepcion_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                 or_fecha = q.or_fecha,
                                 or_observacion = q.or_observacion
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

        public bool guardarDB(imp_orden_compra_ext_recepcion_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_orden_compra_ext_recepcion Entity = Context.imp_orden_compra_ext_recepcion.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenCompra_ext == info.IdOrdenCompra_ext);
                    if (Entity != null)
                    {
                        Entity.or_fecha = info.or_fecha;
                        Entity.or_observacion = info.or_observacion;
                    }
                    else
                    {
                        Entity = new imp_orden_compra_ext_recepcion();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.IdOrdenCompra_ext = info.IdOrdenCompra_ext;
                        Entity.or_fecha = info.or_fecha;
                        Entity.or_observacion = info.or_observacion;
                        Context.imp_orden_compra_ext_recepcion.Add(Entity);                        
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
