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
    public class man_actividad_Bus
    {
        man_actividad_Data oData = new man_actividad_Data();
        man_actividad_det_Bus bus_det = new man_actividad_det_Bus();

        public List<man_actividad_Info> get_list(int IdEmpresa, bool mostrar_anulados)
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

        public bool guardarDB(man_actividad_Info info)
        {
            try
            {
                if (oData.guardarDB(info))
                {
                    foreach (var item in info.lst_actividad_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdActividad = info.IdActividad;
                    }
                    bus_det.guardarDB(info.lst_actividad_det);
                    
                    return true;
                }
                    return false;
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

        public bool modificarDB(man_actividad_Info info)
        {
            try
            {
                if (oData.modificarDB(info))
                {
                    foreach (var item in info.lst_actividad_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdActividad = info.IdActividad;
                    }
                    bus_det.eliminarDB(info.IdEmpresa, info.IdActividad);
                    bus_det.guardarDB(info.lst_actividad_det);

                    return true;
                }
                return false;
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

        public bool anularDB(man_actividad_Info info)
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
