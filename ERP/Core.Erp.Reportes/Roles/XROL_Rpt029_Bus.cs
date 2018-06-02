
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
    public class XROL_Rpt029_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt029_Data oData = new XROL_Rpt029_Data();

        public List<XROL_Rpt029_Info> GetListConsultaGeneral(int idEmpresa, int idnomina, int IdDivision, DateTime fi, DateTime ff, string estado, bool considerar_fecha_ingreso)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa,idnomina, IdDivision,fi,ff,estado,considerar_fecha_ingreso);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt029_Info>();
            }
        }

        public List<XROL_Rpt029_Info> GetListConsultaGeneral(int idEmpresa, int idnomina, DateTime fi, DateTime ff, string estado, bool considerar_fecha_ingreso)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idnomina, fi, ff, estado, considerar_fecha_ingreso);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt029_Info>();
            }
        }

     

    }
}
