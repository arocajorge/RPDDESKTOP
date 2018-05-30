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
    public class fa_pre_facturacion_Bus
    {
        fa_pre_facturacion_Data oData = new fa_pre_facturacion_Data();
        fa_pre_facturacion_det_Bus bus_det = new fa_pre_facturacion_det_Bus();
        fa_pre_facturacion_activos_Bus bus_det_act = new fa_pre_facturacion_activos_Bus();
        fa_pre_facturacion_det_otros_Bus bus_det_otros = new fa_pre_facturacion_det_otros_Bus();

        public List<fa_pre_facturacion_Info> Get_List(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_List(IdEmpresa, FechaIni, FechaFin);
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

        public fa_pre_facturacion_Info Get_Info(int IdEmpresa, decimal IdPreFacturacion)
        {
            try
            {
                return oData.Get_Info(IdEmpresa, IdPreFacturacion);
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

        public fa_pre_facturacion_Info Get_Info_x_periodo(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                return oData.Get_Info_x_periodo(IdEmpresa, IdPeriodo);
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

        public Boolean GuardarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                if( oData.GuardarDB(info))
                {
                    foreach (var item in info.lst_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPreFacturacion = info.IdPreFacturacion;
                    }
                    bus_det.guardarDB(info.lst_det);

                    foreach (var item in info.lst_det_act)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPreFacturacion = info.IdPreFacturacion;
                    }
                    bus_det_act.guardarDB(info.lst_det_act);

                    foreach (var item in info.lst_det_otros)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPreFacturacion = info.IdPreFacturacion;
                        item.IdCentroCosto = info.IdCentroCosto;
                    }
                    bus_det_otros.guardarDB(info.lst_det_otros);
                }
                return true;
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

        public Boolean ModificarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                if (oData.ModificarDB(info))
                {
                    foreach (var item in info.lst_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPreFacturacion = info.IdPreFacturacion;
                    }

                    bus_det.eliminarDB(info.IdEmpresa, info.IdPreFacturacion);
                    bus_det.guardarDB(info.lst_det);

                    foreach (var item in info.lst_det_act)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPreFacturacion = info.IdPreFacturacion;
                    }
                    bus_det_act.eliminarDB(info.IdEmpresa, info.IdPreFacturacion);
                    bus_det_act.guardarDB(info.lst_det_act);

                    foreach (var item in info.lst_det_otros)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPreFacturacion = info.IdPreFacturacion;
                        item.IdCentroCosto = info.IdCentroCosto;
                    }
                    bus_det_otros.eliminarDB(info.IdEmpresa, info.IdPreFacturacion);
                    bus_det_otros.guardarDB(info.lst_det_otros);
                }
                 return true;
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

        public Boolean AnularDB(fa_pre_facturacion_Info info)
        {
            try
            {
                return oData.AnularDB(info);
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
