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

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt036_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt036_frm()
        {
            InitializeComponent();
        }

        private void ucCp_Menu_Reportes_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_Rpt036_Rpt Reporte = new XCXP_Rpt036_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.p_IdProveedor.Value = ucCp_Menu_Reportes.get_cmbProveedor();
                Reporte.p_no_mostrar_saldo_0.Value = ucCp_Menu_Reportes.beiCheck1.EditValue == null ? false : Convert.ToBoolean(ucCp_Menu_Reportes.beiCheck1.EditValue);
                Reporte.p_Fecha_ini.Value = ucCp_Menu_Reportes.get_FchIni();
                Reporte.p_Fecha_fin.Value = ucCp_Menu_Reportes.get_FchFin();
                Reporte.p_mostrar_origen_bodega.Value = ucCp_Menu_Reportes.beiCheck2.EditValue == null ? false : Convert.ToBoolean(ucCp_Menu_Reportes.beiCheck2.EditValue);
                Reporte.p_mostrar_origen_caja.Value = ucCp_Menu_Reportes.beiCheck3.EditValue == null ? false : Convert.ToBoolean(ucCp_Menu_Reportes.beiCheck3.EditValue);
                
                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCp_Menu_Reportes_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void XCXP_Rpt036_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucCp_Menu_Reportes.beiCheck2.EditValue = true;
                ucCp_Menu_Reportes.beiCheck3.EditValue = true;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
