using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROLES_Rpt020_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XROLES_Rpt020_Rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private void XROLES_Rpt13_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

              


                XROLES_Rpt020_Bus oReporteBus = new XROLES_Rpt020_Bus();
                List<XROLES_Rpt020_Info> oListado = new List<XROLES_Rpt020_Info>();





                oListado = oReporteBus.Get_List(param.IdEmpresa,Convert.ToInt32( IdSucursal.Value),Convert.ToInt32( IdTipoMov.Value),Convert.ToInt32( IdNumMovi.Value));
                this.DataSource = oListado;

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
