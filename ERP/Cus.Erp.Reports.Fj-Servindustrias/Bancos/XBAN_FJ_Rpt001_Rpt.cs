using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
namespace Cus.Erp.Reports.FJ.Bancos
{
    public partial class XBAN_FJ_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XBAN_FJ_Rpt001_Bus bus = new XBAN_FJ_Rpt001_Bus();
        List<XBAN_FJ_Rpt001_Info> lista = new List<XBAN_FJ_Rpt001_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XBAN_FJ_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        private void XBAN_FJ_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                string fecha = "";
                lbl_fecha.Text = DateTime.Now.ToString();
                lbl_usuario.Text = param.IdUsuario;
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox2.Image = param.InfoEmpresa.em_logo_Image;

                DateTime fi = Convert.ToDateTime(this.Fecha_inicio.Value);
                DateTime ff = Convert.ToDateTime(this.Fecha_fin.Value);
                int idempresa = Convert.ToInt32(this.IdEmpresa.Value);
                int IdBanco = Convert.ToInt32(p_IdBanco.Value);
                decimal IdPersona = Convert.ToDecimal(p_IdPersona.Value);
                
                    lista = bus.Get_List_Conciliacion(idempresa, IdBanco, IdPersona, fi, ff, p_estado.Value.ToString());

                this.DataSource = lista;
                fecha = "Desde: " + fi.Date.ToString("dd 'de' MMMM 'de' yyyy") + " hasta: " + ff.Date.ToString("dd 'de' MMMM 'de' yyyy");
                lb_fecha.Text = fecha;
            }
            catch (Exception)
            {
                
            }
        }

    }
}
