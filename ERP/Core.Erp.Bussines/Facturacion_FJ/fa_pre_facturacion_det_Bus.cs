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
    public class fa_pre_facturacion_det_Bus
    {
        fa_pre_facturacion_det_Data oData = new fa_pre_facturacion_det_Data();

        public List<fa_pre_facturacion_det_Info> get_list(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdPrefacturacion);
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

        public bool guardarDB(List<fa_pre_facturacion_det_Info> lst)
        {
            try
            {
                return oData.guardarDB(lst);
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

        public bool eliminarDB(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                return oData.eliminarDB(IdEmpresa, IdPrefacturacion);
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

        public List<fa_pre_facturacion_det_Info> get_list_gastos(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_gastos(info_prefacturacion, IdProceso_prefacturacion,aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_depreciacion(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_depreciacion(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_poliza_x_cuota(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_poliza_x_cuota(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_diferencia_mano_obra(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_diferencia_mano_obra(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_compensacion(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_compensacion(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_mano_obra(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_mano_obra(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_depreciacion_x_subcentro(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_depreciacion_x_subcentro(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_movilizacion(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_movilizacion(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_otros(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_otros(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_inventario(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                return oData.get_list_inventario(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia);
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

        public List<fa_pre_facturacion_det_Info> get_list_disponibilidad(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia, double valor_x_disponibilidad, int cantidad_activos)
        {
            try
            {
                return oData.get_list_disponibilidad(info_prefacturacion, IdProceso_prefacturacion, aplica_porc_ganancia,valor_x_disponibilidad,cantidad_activos);
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

        public bool modificarDB(List<fa_pre_facturacion_det_Info> lst)
        {
            try
            {
                return oData.modificarDB(lst);
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
