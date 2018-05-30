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
    public partial class XROLES_Rpt019_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XROLES_Rpt019_Rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private void XROLES_Rpt13_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                int idEmpresa = 0;
                int idnomina = 0;
                int idnominaTipo = 0;
                int idperiodo = 0;
                DateTime fechai;
                DateTime fechaf;



                XROLES_Rpt019_Bus oReporteBus = new XROLES_Rpt019_Bus();
                List<XROLES_Rpt019_Info> oListado = new List<XROLES_Rpt019_Info>();

                idnomina = Convert.ToInt32(Parameters["idnomina"].Value);
                idnominaTipo = Convert.ToInt32(Parameters["idnominatipo"].Value);


                idperiodo = Convert.ToInt32(Parameters["idperiodo"].Value);
                fechai = Convert.ToDateTime(Parameters["fechai"].Value);
                fechaf = Convert.ToDateTime(Parameters["fechaf"].Value);

                oListado = oReporteBus.Get_List(param.IdEmpresa, idnomina, idnominaTipo, idperiodo, fechai, fechaf);
               this.DataSource = oListado;

           
            }
            catch (Exception)
            {
                
               
            }
        }

    }
}
