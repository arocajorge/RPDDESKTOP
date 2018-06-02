using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt018_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt018_Info> lst_rpt = new List<XFAC_FJ_Rpt018_Info>();
        XFAC_FJ_Rpt018_Bus bus_rpt = new XFAC_FJ_Rpt018_Bus();

        public XFAC_FJ_Rpt018_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt018_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lbl_empresa.Text = param.NombreEmpresa;
                lbl_fecha.Text = DateTime.Now.ToString();
                lbl_usuario.Text = param.IdUsuario;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                decimal IdCliente = Convert.ToDecimal(p_IdCliente.Value);                
                DateTime Fecha_fin = Convert.ToDateTime(p_fecha_fin.Value);
                DateTime Fecha_ini = Convert.ToDateTime(p_fecha_ini.Value);
                 lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdCliente,Fecha_ini, Fecha_fin);
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
