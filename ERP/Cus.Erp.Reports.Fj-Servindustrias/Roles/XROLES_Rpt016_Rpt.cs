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
    public partial class XROLES_Rpt016_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XROLES_Rpt016_Rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private void XROLES_Rpt13_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                int idnomina_ = 0;
                int idnominatipo_;
                int idperiodo_;
                DateTime fecjai_;
                DateTime fechaf_;


                XROLES_Rpt016_Bus oReporteBus = new XROLES_Rpt016_Bus();
                List<XROLES_Rpt016_Info> oListado = new List<XROLES_Rpt016_Info>();
                idnomina_ = Convert.ToInt32(Parameters["idnomina"].Value);
                idnominatipo_ = Convert.ToInt32(Parameters["idnominatipo"].Value);

                idperiodo_ = Convert.ToInt32(Parameters["idperiodo"].Value);
                fecjai_ = Convert.ToDateTime(Parameters["fechai"].Value);
                fechaf_ = Convert.ToDateTime(Parameters["fechaf"].Value);

                oListado = oReporteBus.Get_List(param.IdEmpresa,idnomina_,idnominatipo_,idperiodo_,fecjai_,fechaf_);
               this.DataSource = oListado;

            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
            lb_nombrecomercial.Text = param.InfoEmpresa.em_nombre;

           
            }
            catch (Exception)
            {
                
              
            }
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int idNominaTipo = Convert.ToInt32(this.idnomina.Value);
            int idNominaTipoLiqui = Convert.ToInt32(this.idnominatipo.Value);
            int idPeriodo = Convert.ToInt32(this.idperiodo.Value);
            DateTime fechai_ = Convert.ToDateTime(this.fechai.Value);
            DateTime fechaf_ = Convert.ToDateTime(this.fechaf.Value);

            ((XRSubreport)sender).ReportSource.Parameters["idnomina"].Value = idNominaTipo;
            ((XRSubreport)sender).ReportSource.Parameters["idnominatipo"].Value = idNominaTipoLiqui;
            ((XRSubreport)sender).ReportSource.Parameters["idperiodo"].Value = idPeriodo;
            ((XRSubreport)sender).ReportSource.Parameters["fechai"].Value = fechai_;
            ((XRSubreport)sender).ReportSource.Parameters["fechaf"].Value = fechaf_;

            ((XRSubreport)sender).ReportSource.RequestParameters = false;
        }

    }
}
