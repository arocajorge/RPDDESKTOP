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

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt009_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_Rpt009_frm()
        {
            InitializeComponent();
        }

        private void ucCom_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucCom_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCOMP_Rpt009_Rpt rpt = new XCOMP_Rpt009_Rpt();

                rpt.p_IdSucursal.Value = ucCom_Menu_Reportes1.bei_sucursal.EditValue == null ? 0 : Convert.ToInt32(ucCom_Menu_Reportes1.bei_sucursal.EditValue);
                rpt.p_IdSolicitante.Value = ucCom_Menu_Reportes1.bei_solicitante.EditValue == null ? 0 : Convert.ToDecimal(ucCom_Menu_Reportes1.bei_solicitante.EditValue);
                rpt.p_Fecha_ini.Value = ucCom_Menu_Reportes1.dtp_fechaIni.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(ucCom_Menu_Reportes1.dtp_fechaIni.EditValue);
                rpt.p_Fecha_fin.Value = ucCom_Menu_Reportes1.dtp_fechaFin.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(ucCom_Menu_Reportes1.dtp_fechaFin.EditValue);
                rpt.p_IdProducto.Value = ucCom_Menu_Reportes1.bei_producto.EditValue == null ? 0 : Convert.ToDecimal(ucCom_Menu_Reportes1.bei_producto.EditValue);
                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCOMP_Rpt009_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucCom_Menu_Reportes1.Cargar_combos();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
