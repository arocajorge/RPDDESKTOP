using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_tarifario_horometro_Bus
    {
        fa_tarifario_horometro_Data oData = new fa_tarifario_horometro_Data();
        fa_tarifario_horometro_det_Bus bus_det = new fa_tarifario_horometro_det_Bus();

        public List<fa_tarifario_horometro_Info> get_list(int IdEmpresa)
        {
            try
            {
                return oData.get_list(IdEmpresa);
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

        public bool guardarDB(fa_tarifario_horometro_Info info)
        {
            try
            {
                if (oData.guardarDB(info))
                {
                    foreach (var item in info.lst_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdTarifario = info.IdTarifario;
                    }
                    if (bus_det.guardarDB(info.lst_det))
                    {
                        return true;
                    }
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

        public bool modificarDB(fa_tarifario_horometro_Info info)
        {
            try
            {
                if (oData.modificarDB(info))
                {
                    foreach (var item in info.lst_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdTarifario = info.IdTarifario;
                    }
                    bus_det.eliminarDB(info.IdEmpresa, info.IdTarifario);
                    if (bus_det.guardarDB(info.lst_det))
                    {
                        return true;
                    }
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

        public bool anularDB(fa_tarifario_horometro_Info info)
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
