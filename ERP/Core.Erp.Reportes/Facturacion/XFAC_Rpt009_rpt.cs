﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt009_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<XFAC_Rpt009_Info> lstRpt { get; set; }

        public XFAC_Rpt009_rpt()
        {
            InitializeComponent();
        }

        public XFAC_Rpt009_rpt(string IdUsuario, string TipoCreDeb)
        {            
            InitializeComponent();
           

        }

        private void XFAC_Rpt009_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_Rpt009_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_Rpt009_rpt) };
            }
        }

    }
}
