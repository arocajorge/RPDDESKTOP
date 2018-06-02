using Core.Erp.Data.General;
using Core.Erp.Data.Mantenimiento;
using Core.Erp.Info.General;
using Core.Erp.Info.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Mantenimiento
{
    public class man_tecnico_Bus
    {
        man_tecnico_Data oData = new man_tecnico_Data();

        public List<man_tecnico_Info> get_list(int IdEmpresa, bool mostrar_anulados)
        {
            try
            {
                return oData.get_list(IdEmpresa, mostrar_anulados);
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool guardarDB(man_tecnico_Info info)
        {
            try
            {
                return oData.guardarDB(info);
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool modificarDB(man_tecnico_Info info)
        {
            try
            {
                return oData.modificarDB(info);
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool anularDB(man_tecnico_Info info)
        {
            try
            {
                return oData.anularDB(info);
            }
            catch (Exception ex)
            {
                string mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
