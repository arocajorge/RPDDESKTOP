using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
namespace Core.Erp.Data.Roles_Fj
{
   public class ro_empleado_x_cargo_fuerza_grupo_Data
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       string mensaje = "";
       public Boolean GrabarBD(ro_empleado_x_cargo_fuerza_grupo_Info info, ref string msg)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   var contact = (from a in db.ro_empleado_x_cargo_fuerza_grupo
                                  where a.IdEmpresa == info.IdEmpresa
                                  && a.IdNomina==info.IdNomina
                                  && a.IdEmpleado==info.IdEmpleado
                                  && a.IdPeriodo==info.IdPeriodo
                                  select a).FirstOrDefault();
                   if (contact != null)
                   {
                       contact.IdFuerza = info.IdFuerza;
                       contact.IdGrupo = info.IdGrupo;
                       contact.IdCargo = info.IdCargo;
                       contact.Observacion = info.Observacion;
                       db.SaveChanges();
                   }

                   else
                   {
                       ro_empleado_x_cargo_fuerza_grupo add = new ro_empleado_x_cargo_fuerza_grupo();
                      

                       add.IdEmpresa = info.IdEmpresa;
                       add.IdNomina = info.IdNomina;
                       add.IdEmpleado = info.IdEmpleado;
                       add.IdPeriodo = info.IdPeriodo;
                       add.IdFuerza = info.IdFuerza;
                       add.IdGrupo = info.IdGrupo;
                       add.IdCargo = info.IdCargo;
                       add.Observacion = info.Observacion;
                       db.ro_empleado_x_cargo_fuerza_grupo.Add(add);
                       db.SaveChanges();

                   }


                   // actualizando empleado

                   /*
                   var empleado = (from a in db.ro_empleado_x_cargo_fuerza_grupo
                                  where a.IdEmpresa == info.IdEmpresa
                                  && a.IdEmpleado == info.IdEmpleado                                 
                                  select a).FirstOrDefault();
                   if (empleado != null)
                   {
                       empleado.IdGrupo = info.IdGrupo;
                       empleado.IdCargo = info.IdCargo;
                      
                       db.SaveChanges();
                   }
                   */


               }
               return true;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public List<ro_empleado_x_cargo_fuerza_grupo_Info> get_lista_planificacion(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
       {
           try
           {
               List<ro_empleado_x_cargo_fuerza_grupo_Info> lista = new List<ro_empleado_x_cargo_fuerza_grupo_Info>();

               int idperio = 0;

               using (EntityRoles_FJ Context = new EntityRoles_FJ())
               {
                   var sel = (from s in Context.ro_planificacion_x_ruta_x_empleado
                              where s.IdEmpresa == IdEmpresa
                                 && s.IdNomina_Tipo == idnomina_tipo
                              select s.IdPeriodo);
                   if (sel.Count() > 0)
                       idperio = sel.Max();
               }


               using (EntityRoles_FJ Context = new EntityRoles_FJ())
               {
                   IQueryable<ro_empleado_x_cargo_fuerza_grupo> contact;

                   if (idperio > 0)
                   {
                       contact = from q in Context.ro_empleado_x_cargo_fuerza_grupo
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdNomina == idnomina_tipo
                                 && q.IdPeriodo == idperio
                                 select q;
                   }

                   else
                   {
                       contact = from q in Context.ro_empleado_x_cargo_fuerza_grupo
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdNomina == idnomina_tipo
                                 select q;
                   }


                   foreach (var item in contact)
                   {
                       ro_empleado_x_cargo_fuerza_grupo_Info Info = new ro_empleado_x_cargo_fuerza_grupo_Info();
                       Info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                       Info.IdNomina = Convert.ToInt32(item.IdNomina);
                       Info.IdEmpleado = Convert.ToInt32(item.IdEmpleado);
                       Info.IdPeriodo = item.IdPeriodo;
                       Info.IdFuerza = item.IdFuerza;
                       Info.IdGrupo = item.IdGrupo;
                       Info.IdCargo = item.IdCargo;
                       Info.Observacion = item.Observacion;
                      
                       lista.Add(Info);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
   


    }
}
