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
    public class man_actividad_Data
    {
        public List<man_actividad_Info> get_list(int IdEmpresa, bool mostrar_anulados)
        {
            try
            {
                List<man_actividad_Info> Lista = new List<man_actividad_Info>();

                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    IQueryable<man_actividad> lst;
                    if (mostrar_anulados)
                    {
                        lst = from q in Context.man_actividad
                              where q.IdEmpresa == IdEmpresa
                              select q;
                    }
                    else
                        lst = from q in Context.man_actividad
                              where q.IdEmpresa == IdEmpresa
                              && q.estado == true
                              select q;

                    foreach (var item in lst)
                    {
                        man_actividad_Info info = new man_actividad_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdActividad = item.IdActividad;
                        info.ac_codigo = item.ac_codigo;
                        info.ac_descripcion = item.ac_descripcion;
                        info.ac_observacion = item.ac_observacion;
                        info.ac_cant_horas_min = item.ac_cant_horas_min;
                        info.estado = item.estado;

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
        
        public decimal get_id(int IdEmpresa)
        {
            try
            {
                decimal ID = 1;

                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    var lst = from q in Context.man_actividad
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() != 0) ID = lst.Max(q => q.IdActividad) + 1;
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

        public bool guardarDB(man_actividad_Info info)
        {
            try
            {
                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    man_actividad Entity = new man_actividad();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdActividad = info.IdActividad = get_id(info.IdEmpresa);
                    Entity.ac_codigo = info.ac_codigo;
                    Entity.ac_descripcion = info.ac_descripcion;
                    Entity.ac_observacion = info.ac_observacion;
                    Entity.ac_cant_horas_min = info.ac_cant_horas_min;
                    Entity.estado = true;
                    Context.man_actividad.Add(Entity);
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

        public bool modificarDB(man_actividad_Info info)
        {
            try
            {
                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    man_actividad Entity = Context.man_actividad.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdActividad == info.IdActividad);
                    if (Entity!= null)
                    {
                        Entity.ac_codigo = info.ac_codigo;
                        Entity.ac_descripcion = info.ac_descripcion;
                        Entity.ac_observacion = info.ac_observacion;
                        Entity.ac_cant_horas_min = info.ac_cant_horas_min;                     
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

        public bool anularDB(man_actividad_Info info)
        {
            try
            {
                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    man_actividad Entity = Context.man_actividad.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdActividad == info.IdActividad);
                    if (Entity != null)
                    {
                        Entity.estado = false;
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
