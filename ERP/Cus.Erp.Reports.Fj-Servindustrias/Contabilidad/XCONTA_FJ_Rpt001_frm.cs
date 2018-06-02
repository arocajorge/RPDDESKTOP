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

namespace Cus.Erp.Reports.FJ.Contabilidad
{
    public partial class XCONTA_FJ_Rpt001_frm : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XCONTA_FJ_Rpt001_Info> lst_rpt = new List<XCONTA_FJ_Rpt001_Info>();
        XCONTA_FJ_Rpt001_Bus bus_rpt = new XCONTA_FJ_Rpt001_Bus();
        #endregion

        public XCONTA_FJ_Rpt001_frm()
        {
            InitializeComponent();
        }

        private void uCct_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pivot_balance.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCct_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void XCONTA_FJ_Rpt001_frm_Load(object sender, EventArgs e)
        {
            try
            {
                uCct_Menu_Reportes1.Cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCct_Menu_Reportes1_event_btn_Mostrar_en_tabla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                DateTime fecha_ini = uCct_Menu_Reportes1.bei_Desde.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Desde.EditValue);
                DateTime fecha_fin = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Hasta.EditValue);
                bool mostrar_saldo_0 = uCct_Menu_Reportes1.bei_Check.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check.EditValue);
                int nivel = uCct_Menu_Reportes1.bei_Nivel.EditValue == null ? 0 : Convert.ToInt32(uCct_Menu_Reportes1.bei_Nivel.EditValue);
                int IdPunto_cargo = uCct_Menu_Reportes1.bei_punto_cargo.EditValue == null ? 0 : Convert.ToInt32(uCct_Menu_Reportes1.bei_punto_cargo.EditValue);
                lst_rpt = bus_rpt.get_list(param.IdEmpresa, fecha_ini, fecha_fin, IdPunto_cargo, mostrar_saldo_0, nivel);
                
                pivot_balance.DataSource = lst_rpt;
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                if(splashScreenManager1.IsSplashFormVisible)
                    splashScreenManager1.CloseWaitForm();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pivot_balance_CustomAppearance(object sender, DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs e)
        {
            try
            {
                if (e.DataField == col_bg_saldo_mes || e.DataField == col_bg_debitos_mes || e.DataField == col_bg_creditos_mes)
                {
                    if (e.Value != null && Convert.ToDouble(e.Value) > 0)
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }else
                        e.Appearance.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
