
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt028_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt028_Data oData = new XROL_Rpt028_Data();

        public List<XROL_Rpt028_Info> GetLista(int IdEmpresa, int idnomina, DateTime fechai, DateTime fechaf)
        {
          
            try
            {
                return oData.GetLista(IdEmpresa, idnomina, fechai, fechaf);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt028_Info>();
            }


        }

        public List<XROL_Rpt028_Info> GetLista(int IdEmpresa, int idnomina,int iddivision, DateTime fechai, DateTime fechaf)
        {

            try
            {
                return oData.GetLista(IdEmpresa, idnomina,iddivision, fechai, fechaf);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt028_Info>();
            }


        }

    }
}
