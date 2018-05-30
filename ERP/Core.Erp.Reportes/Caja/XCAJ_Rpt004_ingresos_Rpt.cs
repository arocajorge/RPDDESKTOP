using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt004_ingresos_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XCAJ_Rpt004_ingresos_Rpt()
        {
            InitializeComponent();
        }

        private void XCAJ_Rpt004_ingresos_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                decimal IdConciliacion = p_IdConciliacion.Value == null ? 0 : Convert.ToDecimal(p_IdConciliacion.Value);
                List<XCAJ_Rpt004_ingresos_Info> lst_rpt = new List<XCAJ_Rpt004_ingresos_Info>();
                XCAJ_Rpt004_ingresos_Bus bus_rpt = new XCAJ_Rpt004_ingresos_Bus();
                lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdConciliacion);
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
