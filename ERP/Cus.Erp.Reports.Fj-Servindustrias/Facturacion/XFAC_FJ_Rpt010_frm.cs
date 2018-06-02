using Core.Erp.Business.General;
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
    public partial class XFAC_FJ_Rpt010_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt010_Info> lst_rpt = new List<XFAC_FJ_Rpt010_Info>();
        XFAC_FJ_Rpt010_Bus bus_rpt = new XFAC_FJ_Rpt010_Bus();

        public XFAC_FJ_Rpt010_frm()
        {
            InitializeComponent();
        }

        private void ucFa_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string IdCentroCosto = ucFa_Menu_Reportes1.bei_CentroCosto.EditValue == null ? "" : ucFa_Menu_Reportes1.bei_CentroCosto.EditValue.ToString();
                string IdSubcentro = ucFa_Menu_Reportes1.bei_subcentro.EditValue == null ? "" : ucFa_Menu_Reportes1.bei_subcentro.EditValue.ToString();
                int IdPuntoCargo = ucFa_Menu_Reportes1.bei_punto_cargo.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.bei_punto_cargo.EditValue);
                int IdPeriodo_ini = ucFa_Menu_Reportes1.bei_periodo_ini.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.bei_periodo_ini.EditValue);
                int IdPeriodo_fin = ucFa_Menu_Reportes1.bei_periodo_fin.EditValue == null ? 999999 : Convert.ToInt32(ucFa_Menu_Reportes1.bei_periodo_fin.EditValue);
                lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdCentroCosto, IdSubcentro, IdPeriodo_ini, IdPeriodo_fin, IdPuntoCargo);
                gridControl_reporte.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFa_Menu_Reportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XFAC_FJ_Rpt010_Rpt reporte = new XFAC_FJ_Rpt010_Rpt();
                reporte. IdCentroCosto.Value = ucFa_Menu_Reportes1.bei_CentroCosto.EditValue == null ? "" : ucFa_Menu_Reportes1.bei_CentroCosto.EditValue.ToString();
                reporte.IdCentroCosto_sub_centro_costo.Value = ucFa_Menu_Reportes1.bei_subcentro.EditValue == null ? "" : ucFa_Menu_Reportes1.bei_subcentro.EditValue.ToString();
                reporte.IdPunto_cargo.Value = ucFa_Menu_Reportes1.bei_punto_cargo.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.bei_punto_cargo.EditValue);
                reporte.IdPeriodo_ini.Value = ucFa_Menu_Reportes1.bei_periodo_ini.EditValue == null ? 0 : Convert.ToInt32(ucFa_Menu_Reportes1.bei_periodo_ini.EditValue);
                reporte.IdPeriodo_fin.Value = ucFa_Menu_Reportes1.bei_periodo_fin.EditValue == null ? 999999 : Convert.ToInt32(ucFa_Menu_Reportes1.bei_periodo_fin.EditValue);
              
                reporte.CreateDocument();
                reporte.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFa_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
