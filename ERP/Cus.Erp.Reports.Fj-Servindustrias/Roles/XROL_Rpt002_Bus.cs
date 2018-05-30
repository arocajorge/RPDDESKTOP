
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROL_Rpt002_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private XROL_Rpt002_Data oData = new XROL_Rpt002_Data();
        

        public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, decimal idEmpleado, int idNominaTipo, int anio, int mes, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa,idEmpleado, idNominaTipo, anio, mes, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt002_Info>();
            }    
        }

        public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int IdDepartamento, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa,IdDepartamento, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt002_Info>();
            }
        }


    }
}
