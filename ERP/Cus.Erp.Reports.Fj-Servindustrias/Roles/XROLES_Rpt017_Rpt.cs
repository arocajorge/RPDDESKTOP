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
    public partial class XROLES_Rpt017_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XROLES_Rpt017_Rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private void XROLES_Rpt13_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                int idnomina_ = 0;
                int iddivision;
                DateTime fecjai_;
                DateTime fechaf_;


                XROLES_Rpt017_Bus oReporteBus = new XROLES_Rpt017_Bus();
                List<XROLES_Rpt017_Info> oListado = new List<XROLES_Rpt017_Info>();




                idnomina_ = Convert.ToInt32(Parameters["idnomina"].Value);
                iddivision = Convert.ToInt32(Parameters["iddivision"].Value);

                fecjai_ = Convert.ToDateTime(Parameters["fechai"].Value);
                fechaf_ = Convert.ToDateTime(Parameters["fechaf"].Value);

                oListado = oReporteBus.Get_List(param.IdEmpresa,idnomina_,iddivision,fecjai_,fechaf_);
               this.DataSource = oListado;

             xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
            lb_nombrecomercial.Text = param.InfoEmpresa.em_nombre;

           
            }
            catch (Exception)
            {
                
               
            }
        }

    }
}
