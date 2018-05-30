
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
   public  class XROL_Rpt027_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();


        public List<XROL_Rpt027_Info> GetListConsultaPorPrestamo(int idEmpresa, decimal IdEmpleado, ref string msg)
        { 
            
            List<XROL_Rpt027_Info> listado = new List<XROL_Rpt027_Info>();
            try
            {

                return listado;
             }
               
            
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = mensaje;
                return new List<XROL_Rpt027_Info>();
            }

        }





    }
}
