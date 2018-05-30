using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Bancos
{
   public class XBAN_FJ_Rpt004_saldos_Bus
    {

       XBAN_FJ_Rpt004_saldos_Data Objt = new XBAN_FJ_Rpt004_saldos_Data();

       public List<XBAN_FJ_Rpt004_saldos_Info> Get_List(int IdEmpresa, int IdPeriodo_ini, int IdPeriodo_fin, String IdUsuario)
       {
            try
            {
                return Objt.Get_List(IdEmpresa, IdPeriodo_ini, IdPeriodo_fin, IdUsuario);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }
    }
}
