using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
namespace Cus.Erp.Reports.FJ.Roles
{
   public class XROLES_Rpt020_Bus
   {
       XROLES_Rpt020_Data data = new XROLES_Rpt020_Data();

       public List<XROLES_Rpt020_Info> Get_List(int IdEmpresa, int IdSucursal, int IdTipoMovi, int IdNumMovi)
       {
           try
           {
               return data.Get_List(IdEmpresa, IdSucursal, IdTipoMovi, IdNumMovi);
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
