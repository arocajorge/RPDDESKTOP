using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt006_Rpt_resumen : DevExpress.XtraReports.UI.XtraReport
    {
        List<XFAC_FJ_Rpt006_Info> lista = new List<XFAC_FJ_Rpt006_Info>();
        XFAC_FJ_Rpt006_Bus bus = new XFAC_FJ_Rpt006_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XFAC_FJ_Rpt006_Rpt_resumen()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt006_Rpt_resumen_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lbl_empresa.Text = param.NombreEmpresa;
                lbl_fecha.Text = DateTime.Now.ToString();
                lbl_usuario.Text = param.IdUsuario;

                DateTime Fecha_ini = Convert.ToDateTime(p_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(p_Fecha_fin.Value);
                int IdSucursal = Convert.ToInt32(p_IdSucursal.Value);
                lista = bus.get_list(param.IdEmpresa, IdSucursal, Fecha_ini, Fecha_fin);
                this.DataSource = lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
