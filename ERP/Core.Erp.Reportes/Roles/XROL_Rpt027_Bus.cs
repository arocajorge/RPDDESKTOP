
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
    public class XROL_Rpt027_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt027_Data oData = new XROL_Rpt027_Data();

        public List<XROL_Rpt027_Info> GetListConsultaPorPrestamo(int idEmpresa, decimal IdEmpleado, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorPrestamo(idEmpresa, IdEmpleado, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt027_Info>();
            }


        }


    }
}
