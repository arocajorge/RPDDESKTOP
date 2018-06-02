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
    public partial class XROLES_Rpt015_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XROLES_Rpt015_Rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private void XROLES_Rpt13_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                int idEmpresa = 0;
                decimal idempleado;
                int idremplazo;



                XROLES_Rpt015_Bus oReporteBus = new XROLES_Rpt015_Bus();
                List<XROLES_Rpt015_Info> oListado = new List<XROLES_Rpt015_Info>();




                idEmpresa = Convert.ToInt32(Parameters["idempresa"].Value);
                idempleado = Convert.ToDecimal(Parameters["idempleado"].Value);
                idremplazo = Convert.ToInt32(Parameters["idremplazo"].Value);

                oListado = oReporteBus.Get_List(idEmpresa, idempleado, idremplazo);
               this.DataSource = oListado;

             xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
            lb_nombrecomercial.Text = param.InfoEmpresa.em_nombre;

           
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
