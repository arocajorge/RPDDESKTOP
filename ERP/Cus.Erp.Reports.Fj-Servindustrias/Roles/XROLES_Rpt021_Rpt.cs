using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROLES_Rpt021_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        XROLES_Rpt021_Bus bus_rpt = new XROLES_Rpt021_Bus();
        List<XROLES_Rpt021_Info> lst_rpt = new List<XROLES_Rpt021_Info>();

        public XROLES_Rpt021_Rpt()
        {
            InitializeComponent();
        }

        private void XROLES_Rpt021_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                int IdNomina_tipo = Convert.ToInt32(p_IdNomina_tipo.Value);
                int IdDescuento = Convert.ToInt32(p_IdDescuento.Value);
                decimal IdEmpleado = Convert.ToDecimal(p_IdEmpleado.Value);
                lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdNomina_tipo, IdEmpleado, IdDescuento);

                if (lst_rpt.Count > 0)
                    lbl_texto.Text = lbl_texto.Text.Replace("[NOMBRE_EMPLEADO]", lst_rpt[0].pe_nombreCompleto).Replace("[VALOR]",lst_rpt[0].Valor.ToString()).Replace("[CEDULA]",lst_rpt[0].pe_cedulaRuc);

                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
