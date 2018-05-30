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
    public partial class XFAC_FJ_Rpt018_frm : Form
    {
        public XFAC_FJ_Rpt018_frm()
        {
            InitializeComponent();
        }

        private void ucFa_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XFAC_FJ_Rpt018_Rpt rpt = new XFAC_FJ_Rpt018_Rpt();
                rpt.p_fecha_ini.Value = ucFa_Menu_Reportes1.dtpDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucFa_Menu_Reportes1.dtpDesde.EditValue);
                rpt.p_fecha_fin.Value = ucFa_Menu_Reportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucFa_Menu_Reportes1.dtpHasta.EditValue);
                rpt.p_IdCliente.Value = ucFa_Menu_Reportes1.cmbCliente.EditValue == null ? 0 : Convert.ToDecimal(ucFa_Menu_Reportes1.cmbCliente.EditValue);                
                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = pt.PrintingSystem;
                rpt.CreateDocument();
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
