using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.Roles_Fj
{
   public class ro_empleado_x_cargo_fuerza_grupo_Bus
   {
       string mensaje = "";
       ro_empleado_x_cargo_fuerza_grupo_Data data = new ro_empleado_x_cargo_fuerza_grupo_Data();
       public Boolean GrabarBD(ro_empleado_x_cargo_fuerza_grupo_Info info, ref string msg)
       {
           try
           {
             return  data.GrabarBD(info, ref msg);
           }
           catch (Exception ex)
           {
               
               mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
           }
       }


       public List<ro_empleado_x_cargo_fuerza_grupo_Info> get_lista_planificacion(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
       {
           try
           {
               return data.get_lista_planificacion(IdEmpresa, idnomina_tipo, IdPeriodo);
           }
           catch (Exception ex)
           {

               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
    }
}
