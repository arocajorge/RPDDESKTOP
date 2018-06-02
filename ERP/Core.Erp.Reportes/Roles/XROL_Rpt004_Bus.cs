
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
    public class XROL_Rpt004_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt004_Data oData = new XROL_Rpt004_Data();

        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal,string idrubro,int idempleado,int iddepartamento,string estado, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal,idrubro,idempleado,iddepartamento, estado, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }    
        
        
        }


        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, string idrubro, int iddepartamento, string estado, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, idrubro, iddepartamento, estado, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }


        }


        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, int iddepartamento, string estado, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, iddepartamento, estado, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }


        }

        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, string estado, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal,  estado,ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }


        }


        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, string idrubro, string estado, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal,idrubro, estado, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }


        }

        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, decimal idempleado, DateTime fechaInicial, DateTime fechaFinal, string idrubro, string estado, ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa,idempleado, fechaInicial, fechaFinal, idrubro, estado, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }

        }
        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, int idempleado, string estado)
        {
            try
            {
                return oData.GetListConsultaPorFecha(idEmpresa,  fechaInicial, fechaFinal, idempleado, estado);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return new List<XROL_Rpt004_Info>();
            }

        }
    }
}
