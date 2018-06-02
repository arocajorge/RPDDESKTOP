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
   public class XROLES_Rpt017_Bus
   {
       XROLES_Rpt017_Data data = new XROLES_Rpt017_Data();

       public List<XROLES_Rpt017_Info> Get_List(int IdEmpresa, int idnomina, int IdDivision, DateTime fechaI, DateTime FechaF)
       {
           try
           {
               return data.Get_List(IdEmpresa, idnomina, IdDivision, fechaI, FechaF);
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
