using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt009_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XFAC_FJ_Rpt009_Info> lista = new List<XFAC_FJ_Rpt009_Info>();
        XFAC_FJ_Rpt009_Bus bus = new XFAC_FJ_Rpt009_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XFAC_FJ_Rpt009_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt009_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lbl_empresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lbl_fecha.Text = DateTime.Now.ToString();
                lbl_usuario.Text = param.IdUsuario;

                decimal IdCliente = Convert.ToDecimal(p_IdCliente.Value);
                int IdVendedor = Convert.ToInt32(p_IdVendedor.Value);
                int IdPunto_cargo_grupo = Convert.ToInt32(p_IdPunto_cargo_grupo.Value);
                int IdPunto_cargo = Convert.ToInt32(p_IdPunto_cargo.Value);
                DateTime Fecha_ini = Convert.ToDateTime(p_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(p_Fecha_fin.Value);

                lista = bus.get_list(param.IdEmpresa, IdCliente, IdVendedor,IdPunto_cargo_grupo, IdPunto_cargo, Fecha_ini, Fecha_fin);
                this.DataSource = lista;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        private void GroupHeader_punto_cargo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(p_Mostrar_agrupado.Value) == false)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GroupFooter_punto_cargo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(p_Mostrar_agrupado.Value) == false)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
