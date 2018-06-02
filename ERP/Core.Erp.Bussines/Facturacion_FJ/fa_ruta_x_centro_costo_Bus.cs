using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_ruta_x_centro_costo_Bus
    {
        fa_ruta_x_centro_costo_Data oData = new fa_ruta_x_centro_costo_Data();

        public List<fa_ruta_x_centro_costo_Info> get_list(int IdEmpresa, string IdCentroCosto, bool Mostrar_anulados)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdCentroCosto,Mostrar_anulados);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public List<fa_ruta_x_centro_costo_Info> get_no_list(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                return oData.get_no_list(IdEmpresa, IdCentroCosto);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool guardarDB(List<fa_ruta_x_centro_costo_Info> Lista)
        {
            try
            {
                return oData.guardarDB(Lista);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool eliminarDB(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                return oData.eliminarDB(IdEmpresa, IdCentroCosto);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
