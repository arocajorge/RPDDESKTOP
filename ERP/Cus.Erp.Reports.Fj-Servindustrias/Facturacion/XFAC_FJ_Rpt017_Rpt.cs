using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt017_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt017_Info> lst_rpt = new List<XFAC_FJ_Rpt017_Info>();
        XFAC_FJ_Rpt017_Bus bus_rpt = new XFAC_FJ_Rpt017_Bus();

        public XFAC_FJ_Rpt017_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt017_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lbl_empresa.Text = param.NombreEmpresa;
                lbl_fecha.Text = DateTime.Now.ToString();
                lbl_usuario.Text = param.IdUsuario;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                decimal IdCliente = Convert.ToDecimal(p_IdCliente.Value);
                DateTime Fecha_ini = Convert.ToDateTime(p_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(p_Fecha_fin.Value);
                bool no_mostrar_saldo_0 = Convert.ToBoolean(p_no_mostrar_saldo_0.Value);
                 lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdCliente, Fecha_ini, Fecha_fin,no_mostrar_saldo_0);
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
