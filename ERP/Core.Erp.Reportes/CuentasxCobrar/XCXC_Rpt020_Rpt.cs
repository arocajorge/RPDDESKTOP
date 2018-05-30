using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Linq;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt020_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        XCXC_Rpt020_Bus bus_rpt = new XCXC_Rpt020_Bus();
        List<XCXC_Rpt020_Info> lst_rpt = new List<XCXC_Rpt020_Info>();

        public XCXC_Rpt020_Rpt()
        {
            InitializeComponent();
        }

        private void XCXC_Rpt020_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lbl_fecha.Text = DateTime.Now.ToString();
                lbl_usuario.Text = param.IdUsuario;
                lblEmpresa.Text = param.NombreEmpresa;
                DateTime Fecha_corte = Convert.ToDateTime(p_Fecha_corte.Value);
                decimal IdCliente = Convert.ToDecimal(p_IdCliente.Value);
                bool no_mostrar_saldo_0 = Convert.ToBoolean(p_no_mostrar_saldo_0.Value);
                bool mostrar_anuladas = Convert.ToBoolean(p_mostrar_anuladas.Value);

                lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdCliente, Fecha_corte, no_mostrar_saldo_0, mostrar_anuladas);
                this.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt018_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt018_Rpt) };
            }
        }

    }
}
