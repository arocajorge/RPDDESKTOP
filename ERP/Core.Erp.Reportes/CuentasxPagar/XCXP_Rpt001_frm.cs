using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Core.Erp.Reportes.CuentasxPagar;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt001_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXP_Rpt001_frm()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt001_frm_Load(object sender, EventArgs e)
        {
            ucCp_Menu_Reportes1.beiCheck2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucCp_Menu_Reportes1.beiCheck3.EditValue = true;
        }

        private void ucCp_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_Rpt001_Rpt rpt = new XCXP_Rpt001_Rpt();
                rpt.p_fecha_corte.Value = ucCp_Menu_Reportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucCp_Menu_Reportes1.dtpHasta.EditValue);
                rpt.p_IdProveedor.Value = ucCp_Menu_Reportes1.get_cmbProveedor();
                rpt.p_no_mostrar_saldo_0.Value = ucCp_Menu_Reportes1.beiCheck1.EditValue == null ? false : Convert.ToBoolean(ucCp_Menu_Reportes1.beiCheck1.EditValue);
                rpt.p_no_mostrar_en_conciliacion.Value = ucCp_Menu_Reportes1.beiCheck3.EditValue == null ? false : Convert.ToBoolean(ucCp_Menu_Reportes1.beiCheck3.EditValue);
                rpt.p_IdClase_proveedor.Value = ucCp_Menu_Reportes1.Get_info_clase_proveedor() == null ? 0 : ucCp_Menu_Reportes1.Get_info_clase_proveedor().IdClaseProveedor;
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

        private void ucCp_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

    }
}
