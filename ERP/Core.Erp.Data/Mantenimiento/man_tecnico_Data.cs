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
    public class man_tecnico_Data
    {
        public List<man_tecnico_Info> get_list(int IdEmpresa, bool mostrar_anulados)
        {
            try
            {
                List<man_tecnico_Info> Lista = new List<man_tecnico_Info>();

                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    IQueryable<vwman_tecnico> lst;

                    if (mostrar_anulados)
                        lst = from q in Context.vwman_tecnico
                              where q.IdEmpresa == IdEmpresa
                              select q;
                    else
                        lst = from q in Context.vwman_tecnico
                              where q.IdEmpresa == IdEmpresa
                              && q.estado == true
                              select q;

                    foreach (var item in lst)
                    {
                        man_tecnico_Info info = new man_tecnico_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTecnico = item.IdTecnico;
                        info.IdEmpleado = item.IdEmpleado;
                        info.te_codigo = item.te_codigo;
                        info.te_observacion = item.te_observacion;
                        info.estado = item.estado;

                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
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
                    var lst = from q in Context.man_tecnico
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() != 0) ID = lst.Max(q => q.IdTecnico) + 1;
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

        public bool guardarDB(man_tecnico_Info info)
        {
            try
            {
                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    man_tecnico Entity = new man_tecnico();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdTecnico = info.IdTecnico = get_id(info.IdEmpresa);
                    Entity.IdEmpleado = info.IdEmpleado;
                    Entity.te_codigo = info.te_codigo;
                    Entity.te_observacion = info.te_observacion;
                    Entity.estado = true;
                    Context.man_tecnico.Add(Entity);
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

        public bool modificarDB(man_tecnico_Info info)
        {
            try
            {
                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    man_tecnico Entity = Context.man_tecnico.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdTecnico == info.IdTecnico);
                    if (Entity != null)
                    {
                        Entity.te_codigo = info.te_codigo;
                        Entity.te_observacion = info.te_observacion;
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

        public bool anularDB(man_tecnico_Info info)
        {
            try
            {
                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    man_tecnico Entity = Context.man_tecnico.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdTecnico == info.IdTecnico);
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
