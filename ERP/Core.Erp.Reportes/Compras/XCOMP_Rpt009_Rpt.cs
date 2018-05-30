using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt009_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XCOMP_Rpt009_Info> Lst_rpt = new List<XCOMP_Rpt009_Info>();
        XCOMP_Rpt009_Bus bus_rpt = new XCOMP_Rpt009_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_Rpt009_Rpt()
        {
            InitializeComponent();
        }

        private void XCOMP_Rpt009_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lbl_fecha.Text = DateTime.Now.ToString();
                lbl_usuario.Text = param.IdUsuario;
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                int IdSucursal = Convert.ToInt32(p_IdSucursal.Value);
                decimal IdSolicitante = Convert.ToDecimal(p_IdSolicitante.Value);
                DateTime Fecha_ini = Convert.ToDateTime(p_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(p_Fecha_fin.Value);
                decimal IdProducto = Convert.ToDecimal(p_IdProducto.Value);

                Lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdSucursal, IdSolicitante, Fecha_ini, Fecha_fin,IdProducto);
                this.DataSource = Lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
