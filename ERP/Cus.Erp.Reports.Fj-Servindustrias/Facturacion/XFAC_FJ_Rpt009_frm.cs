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

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt009_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public XFAC_FJ_Rpt009_frm()
        {
            InitializeComponent();
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

        private void ucFa_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XFAC_FJ_Rpt009_Rpt rpt = new XFAC_FJ_Rpt009_Rpt();
                rpt.p_Fecha_ini.Value = ucFa_Menu_Reportes1.dtpDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucFa_Menu_Reportes1.dtpDesde.EditValue);
                rpt.p_Fecha_fin.Value = ucFa_Menu_Reportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucFa_Menu_Reportes1.dtpHasta.EditValue);
                rpt.p_IdCliente.Value = ucFa_Menu_Reportes1.cmbCliente.EditValue == null ? 0 : Convert.ToDecimal(ucFa_Menu_Reportes1.cmbCliente.EditValue);
                rpt.p_IdVendedor.Value = ucFa_Menu_Reportes1.cmbVendedor.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.cmbVendedor.EditValue);
                rpt.p_IdPunto_cargo_grupo.Value = ucFa_Menu_Reportes1.bei_grupo.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.bei_grupo.EditValue);
                rpt.p_IdPunto_cargo.Value = ucFa_Menu_Reportes1.bei_punto_cargo.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.bei_punto_cargo.EditValue);
                rpt.p_Mostrar_agrupado.Value = ucFa_Menu_Reportes1.bei_check_1.EditValue == null ? false : Convert.ToBoolean(ucFa_Menu_Reportes1.bei_check_1.EditValue);
                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = pt.PrintingSystem;
                rpt.CreateDocument();
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void XFAC_FJ_Rpt009_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucFa_Menu_Reportes1.bei_check_1.EditValue = true;
                if (param.IdEmpresa == 2)
                {
                    ucFa_Menu_Reportes1.bei_grupo.EditValue = 1;
                    ucFa_Menu_Reportes1.bei_grupo.Enabled = false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
