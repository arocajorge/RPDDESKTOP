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

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt006_frm : Form
    {
        public XFAC_FJ_Rpt006_frm()
        {
            InitializeComponent();
        }

        private void ucFa_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool mostrar_resumido = ucFa_Menu_Reportes1.bei_check_1.EditValue == null ? false : Convert.ToBoolean(ucFa_Menu_Reportes1.bei_check_1.EditValue);
                if (mostrar_resumido)
                {
                    XFAC_FJ_Rpt006_Rpt_resumen rpt_resumen = new XFAC_FJ_Rpt006_Rpt_resumen();
                    rpt_resumen.p_Fecha_ini.Value = ucFa_Menu_Reportes1.dtpDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucFa_Menu_Reportes1.dtpDesde.EditValue);
                    rpt_resumen.p_Fecha_fin.Value = ucFa_Menu_Reportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucFa_Menu_Reportes1.dtpHasta.EditValue);
                    rpt_resumen.p_IdSucursal.Value = ucFa_Menu_Reportes1.cmbSucursal.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.cmbSucursal.EditValue);
                    ReportPrintTool pt_resumen = new ReportPrintTool(rpt_resumen);
                    printControl1.PrintingSystem = pt_resumen.PrintingSystem;
                    rpt_resumen.CreateDocument();
                }
                else
                {
                    XFAC_FJ_Rpt006_Rpt rpt = new XFAC_FJ_Rpt006_Rpt();
                    rpt.p_Fecha_ini.Value = ucFa_Menu_Reportes1.dtpDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucFa_Menu_Reportes1.dtpDesde.EditValue);
                    rpt.p_Fecha_fin.Value = ucFa_Menu_Reportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucFa_Menu_Reportes1.dtpHasta.EditValue);
                    rpt.p_IdSucursal.Value = ucFa_Menu_Reportes1.cmbSucursal.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.cmbSucursal.EditValue);
                    ReportPrintTool pt = new ReportPrintTool(rpt);
                    printControl1.PrintingSystem = pt.PrintingSystem;
                    rpt.CreateDocument();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucFa_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
