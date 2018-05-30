using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt002_Info> Lst_Rpt = new List<XFAC_FJ_Rpt002_Info>();
        XFAC_FJ_Rpt002_Bus bus_Rpt = new XFAC_FJ_Rpt002_Bus();

        public XFAC_FJ_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                decimal IdPrefacturacion = 0;
                IdPrefacturacion = Convert.ToDecimal(P_IdPrefacturacion.Value);
                Lst_Rpt = bus_Rpt.Get_List(param.IdEmpresa, IdPrefacturacion);
                this.DataSource = Lst_Rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
