using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
namespace Core.Erp.Business.Roles_Fj
{
   public class ro_ManoObra_Bus
   {
       ro_ManoObra_Data data = new ro_ManoObra_Data();

       public List<ro_ManoObra_Info> Get_Mano_Obra(ro_periodo_x_ro_Nomina_TipoLiqui_Info info)
       {
           try
           {
               return data.Get_Mano_Obra(info);
           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }

       }
        
    }
}
