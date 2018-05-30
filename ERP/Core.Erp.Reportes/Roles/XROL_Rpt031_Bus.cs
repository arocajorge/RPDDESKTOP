
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;


namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt031_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt031_Data oData = new XROL_Rpt031_Data();

        public List<XROL_Rpt031_Info> GetListPorNominaPeriodo(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui,int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetListPorNominaPeriodo(idEmpresa, idNominaTipo, idNominaTipoLiqui,idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt031_Info>();
            }
        }




    }
}
