using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Bancos
{
    public partial class XBAN_FJ_Rpt004_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<int> _lst_tipo_flujo = new List<int>();

        XBAN_FJ_Rpt004_Bus rptBus = new XBAN_FJ_Rpt004_Bus();
        List<XBAN_FJ_Rpt004_Info> lstInfo = new List<XBAN_FJ_Rpt004_Info>();
        List<XBAN_FJ_Rpt004_saldos_Info> lstInfo_saldos = new List<XBAN_FJ_Rpt004_saldos_Info>();
        XBAN_FJ_Rpt004_saldos_Bus bus_saldos = new XBAN_FJ_Rpt004_saldos_Bus();
        bool Mostrar_detallado = false;

        public XBAN_FJ_Rpt004_rpt()
        {
            InitializeComponent();            
        }

        public void set_parametros(List<int> lst_tipo_flujo)
        {
            try
            {
                _lst_tipo_flujo = lst_tipo_flujo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XBAN_FJ_Rpt004_rpt) };
            }
        }

        private void XBAN_FJ_Rpt004_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox2.Image = param.InfoEmpresa.em_logo_Image;
                Mostrar_detallado = Convert.ToBoolean(P_Mostrar_detallado.Value);
                if (Mostrar_detallado) xrLabel1.Text = "FLUJO DE CAJA CONCILIADO DETALLADO"; else xrLabel1.Text = "FLUJO DE CAJA CONCILIADO RESUMIDO";
                lblEmpresa.Text = param.NombreEmpresa;
                lstInfo_saldos = bus_saldos.Get_List(param.IdEmpresa, Convert.ToInt32(P_IdPeriodo_ini.Value),Convert.ToInt32(P_IdPeriodo_fin.Value),param.IdUsuario);
                bool Mostrar_solo_conciliado = Convert.ToBoolean(P_Mostrar_solo_conciliado.Value);
                int IdBanco = Convert.ToInt32(P_IdBanco.Value);
                bool Mostrar_beneficiario = Convert.ToBoolean(P_Mostrar_beneficiario.Value);
                lstInfo = rptBus.Get_list_reporte(param.IdEmpresa, _lst_tipo_flujo, Convert.ToInt32(P_IdPeriodo_ini.Value), Convert.ToInt32(P_IdPeriodo_fin.Value), Mostrar_detallado, IdBanco,Mostrar_solo_conciliado, Mostrar_beneficiario);
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_FJ_Rpt004_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_FJ_Rpt004_rpt) };   
            }
        }

        private void SubReport_SaldoInicial_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XRSubreport xrSubReport = (XRSubreport)sender;
                XBAN_FJ_Rpt004_saldos_rpt subRep = xrSubReport.ReportSource as XBAN_FJ_Rpt004_saldos_rpt;
                subRep.set_parametros("INICIAL", lstInfo_saldos);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SubReport_SaldoInicial_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_FJ_Rpt004_rpt) };
            }
        }

        private void SubReport_SaldoFinal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XRSubreport xrSubReport = (XRSubreport)sender;
                XBAN_FJ_Rpt004_saldos_rpt subRep = xrSubReport.ReportSource as XBAN_FJ_Rpt004_saldos_rpt;
                subRep.set_parametros("FINAL",lstInfo_saldos);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SubReport_SaldoFinal_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_FJ_Rpt004_rpt) };
            }
        }

        private void GroupFooter_TipoFlujo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                e.Cancel = !Mostrar_detallado;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GroupFooter_TipoFlujo_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_FJ_Rpt004_rpt) };
            }
        }

        private void GroupHeader_TipoFlujo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                e.Cancel = !Mostrar_detallado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GroupFooter_TipoFlujo_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_FJ_Rpt004_rpt) };
            }
        }

    }
}
