﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt008_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public string IdUsuario { get; set; }

        public XACTF_Rpt008_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XACTF_Rpt008_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XACTF_Rpt008_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XACTF_Rpt008_Bus busRpt = new XACTF_Rpt008_Bus();
                List<XACTF_Rpt008_Info> lstRpt = new List<XACTF_Rpt008_Info>();

                this.lblIdUsuario.Text = IdUsuario;

                int IdEmpresa = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                FechaIni = Convert.ToDateTime(this.FechaIni.Value);
                FechaFin = Convert.ToDateTime(this.FechaFin.Value);
                lb_empresa.Text = param.InfoEmpresa.em_nombre;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lstRpt = busRpt.get_RptRetiro_AF(IdEmpresa, FechaIni, FechaFin);
                this.DataSource = lstRpt.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACTF_Rpt008_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt008_rpt) };
            }
        }

    }
}
