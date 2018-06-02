using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt018_frm : Form
    {
        public XCXC_Rpt018_frm()
        {
            InitializeComponent();
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 

        private void uccxC_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uccxC_MenuReportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXC_Rpt018_Rpt rpt = new XCXC_Rpt018_Rpt();
                rpt.p_fecha_corte.Value = uccxC_MenuReportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uccxC_MenuReportes1.dtpHasta.EditValue);
                rpt.p_IdCliente.Value = uccxC_MenuReportes1.beiCliente.EditValue == null ? 0 : Convert.ToDecimal(uccxC_MenuReportes1.beiCliente.EditValue);
                rpt.p_no_mostrar_saldo_0.Value = uccxC_MenuReportes1.bei_check2.EditValue == null ? false : Convert.ToBoolean(uccxC_MenuReportes1.bei_check2.EditValue);
                rpt.p_mostrar_anuladas.Value = uccxC_MenuReportes1.barEditItemChk.EditValue == null ? false : Convert.ToBoolean(uccxC_MenuReportes1.barEditItemChk.EditValue);
                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = pt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXC_Rpt018_frm_Load(object sender, EventArgs e)
        {
            try
            {
                uccxC_MenuReportes1.barEditItemChk.EditValue = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
