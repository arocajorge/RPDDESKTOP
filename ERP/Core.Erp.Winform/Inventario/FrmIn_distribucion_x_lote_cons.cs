using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_distribucion_x_lote_cons : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
        List<in_movi_inven_tipo_Info> lst_tipo_movi = new List<in_movi_inven_tipo_Info>();
        in_movi_inven_tipo_Bus bus_tipo_movi = new in_movi_inven_tipo_Bus();
        List<in_Ing_Egr_Inven_distribucion_Info> lst_distribucion = new List<in_Ing_Egr_Inven_distribucion_Info>();
        in_Ing_Egr_Inven_distribucion_Bus bus_distribucion = new in_Ing_Egr_Inven_distribucion_Bus();
        #endregion

        public FrmIn_distribucion_x_lote_cons()
        {
            InitializeComponent();
        }

        private void FrmIn_distribucion_x_lote_cons_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btn_distribuir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControl_distribucion.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.Properties.DataSource = lst_sucursal;
                cmb_sucursal.EditValue = param.InfoSucursal.IdSucursal;

                lst_tipo_movi = bus_tipo_movi.Get_List_movi_inven_tipo(param.IdEmpresa);
                cmb_tipo_movimiento.Properties.DataSource = lst_tipo_movi;

                de_fecha_ini.DateTime = DateTime.Now.Date.AddMonths(-1);
                de_fecha_fin.DateTime = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_data()
        {
            try
            {
                int IdSucursal = cmb_sucursal.EditValue == null ? 0 : Convert.ToInt32(cmb_sucursal.EditValue);
                int IdMovi_inven_tipo = cmb_tipo_movimiento.EditValue == null ? 0 : Convert.ToInt32(cmb_tipo_movimiento.EditValue);
                lst_distribucion = bus_distribucion.get_list(param.IdEmpresa, IdSucursal, IdMovi_inven_tipo);
                gridControl_distribucion.DataSource = lst_distribucion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamar_formulario()
        {
            try
            {
                in_Ing_Egr_Inven_distribucion_Info row = (in_Ing_Egr_Inven_distribucion_Info)gridView_distribucion.GetFocusedRow();
                
                if (row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                if (row.can_x_distribuir == 0)
                {
                    MessageBox.Show("El registro ya se encuentra totalmente distribuido", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                FrmIn_distribucion_x_lote_man frm = new FrmIn_distribucion_x_lote_man();
                frm.set_info(row);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_distribucion_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                in_Ing_Egr_Inven_distribucion_Info row = (in_Ing_Egr_Inven_distribucion_Info)gridView_distribucion.GetRow(e.RowHandle);
                if (row == null) return;
                if (row.can_x_distribuir == 0)
                    e.Appearance.ForeColor = Color.Blue;
                if (row.can_distribuida > 0 && row.can_x_distribuir != 0)
                    e.Appearance.ForeColor = Color.Orange;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
