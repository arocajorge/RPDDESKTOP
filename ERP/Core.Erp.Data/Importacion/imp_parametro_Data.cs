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
    public class imp_parametro_Data
    {
        public imp_parametro_Info get_info(int IdEmpresa)
        {
            try
            {
                imp_parametro_Info info = new imp_parametro_Info();

                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_parametro Entity = Context.imp_parametro.FirstOrDefault(q => q.IdEmpresa == IdEmpresa);
                    if (Entity != null)
                    {
                        info.IdEmpresa = Entity.IdEmpresa;
                        info.IdTipoCbte_liquidacion = Entity.IdTipoCbte_liquidacion;
                        info.IdTipoCbte_liquidacion_anu = Entity.IdTipoCbte_liquidacion_anu;
                    }
                }

                return info;
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

        public bool guardarDB(imp_parametro_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_parametro Entity = Context.imp_parametro.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa);
                    if (Entity == null)
                    {
                        Entity = new imp_parametro();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.IdTipoCbte_liquidacion = info.IdTipoCbte_liquidacion;
                        Entity.IdTipoCbte_liquidacion_anu = info.IdTipoCbte_liquidacion_anu;
                        Context.imp_parametro.Add(Entity);
                    }
                    else
                    {
                        Entity.IdTipoCbte_liquidacion = info.IdTipoCbte_liquidacion;
                        Entity.IdTipoCbte_liquidacion_anu = info.IdTipoCbte_liquidacion_anu;                        
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
