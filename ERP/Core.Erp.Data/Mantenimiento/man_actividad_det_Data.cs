using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Mantenimiento
{
    public class man_actividad_det_Data
    {
        public List<man_actividad_det_Info> get_list(int IdEmpresa, decimal IdActividad)
        {
            try
            {
                List<man_actividad_det_Info> Lista = new List<man_actividad_det_Info>();

                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    var lst = from q in Context.man_actividad_det
                              where q.IdEmpresa == IdEmpresa
                              && q.IdActividad == IdActividad
                              select q;

                    foreach (var item in lst)
                    {
                        man_actividad_det_Info info = new man_actividad_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdActividad = item.IdActividad;
                        info.ac_secuencia = item.ac_secuencia;
                        info.IdActividad_hijo = item.IdActividad_hijo;
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

        public bool guardarDB(List<man_actividad_det_Info> lst)
        {
            try
            {
                int sec = 1;
                foreach (var item in lst)
                {
                    using (EntitiesMantenimiento Context= new EntitiesMantenimiento())
                    {
                        man_actividad_det Entity = new man_actividad_det();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdActividad = item.IdActividad;
                        Entity.ac_secuencia = item.ac_secuencia = sec;
                        Entity.IdActividad_hijo = item.IdActividad_hijo;
                        Context.man_actividad_det.Add(Entity);
                        Context.SaveChanges();
                        sec++;
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

        public bool eliminarDB(int IdEmpresa, decimal IdActividad)
        {
            try
            {
                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    Context.Database.ExecuteSqlCommand("DELETE man_actividad_det WHERE IdEmpresa = "+IdEmpresa+" and IdActividad = "+IdActividad);
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
