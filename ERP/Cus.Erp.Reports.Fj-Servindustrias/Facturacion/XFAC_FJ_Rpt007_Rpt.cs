using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt007_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt007_Info> lst_rpt = new List<XFAC_FJ_Rpt007_Info>();
        XFAC_FJ_Rpt007_Bus bus_rpt = new XFAC_FJ_Rpt007_Bus();

        public XFAC_FJ_Rpt007_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt007_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

               if(Convert.ToDecimal( IdCliente.Value)==0)
                lst_rpt = bus_rpt.get_list(param.IdEmpresa,Convert.ToInt32( IdPeriodo.Value));
                else
                   lst_rpt = bus_rpt.get_list(param.IdEmpresa, Convert.ToInt32(IdPeriodo.Value), Convert.ToDecimal(IdCliente.Value));
                lb_empresa.Text = param.InfoEmpresa.NombreComercial;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
