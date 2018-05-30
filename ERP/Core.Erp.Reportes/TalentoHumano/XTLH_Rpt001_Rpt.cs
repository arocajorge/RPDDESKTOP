using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
namespace Core.Erp.Reportes.TalentoHumano
{
    public partial class XTLH_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XTLH_Rpt001_Rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<XTLH_Rpt001_Info> lista = new List<XTLH_Rpt001_Info>();
        XTLH_Rpt001_Bus bus = new XTLH_Rpt001_Bus();
        private void XTLH_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lista = bus.getList(Convert.ToInt32( IdEmpresa.Value),Convert.ToInt32( IdCalendario.Value));
                this.DataSource = lista;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lblEmpresa.Text = param.InfoEmpresa.RazonSocial;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
