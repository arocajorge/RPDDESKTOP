using Core.Erp.Business.General;
using Core.Erp.Business.Mantenimiento;
using Core.Erp.Info.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion_FJ;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_liquidacion_x_punto_cargo_mano_obra_det : Form
    {
        #region
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<man_actividad_Info> lst_actividad = new List<man_actividad_Info>();
        man_actividad_Bus bus_actividad = new man_actividad_Bus();
        string MensajeError = "";
        public DialogResult Dialog_result = DialogResult.Cancel;
        fa_liquidacion_x_punto_cargo_det_mano_obra_Info info_det = new fa_liquidacion_x_punto_cargo_det_mano_obra_Info();
        BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info> blst_det = new BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info>();
        #endregion

        public frmFa_liquidacion_x_punto_cargo_mano_obra_det()
        {
            InitializeComponent();
        }

        private void frmFa_liquidacion_x_punto_cargo_mano_obra_det_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                set_info_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                lst_actividad = bus_actividad.get_list(param.IdEmpresa, false);
                cmb_actividad_grid.DataSource = lst_actividad;
                cmb_actividad.Properties.DataSource = lst_actividad;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_info(fa_liquidacion_x_punto_cargo_det_mano_obra_Info info)
        {
            try
            {
                info_det = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                cmb_actividad.EditValue = info_det.IdActividad;
                blst_det = new BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info>(info_det.lst_mano_obra_det);
                gridControl_mano_obra_det.DataSource = blst_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_actividad.Focus();
                Dialog_result = DialogResult.OK;
                info_det.lst_mano_obra_det = new List<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info>(blst_det);
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                blst_det = new BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info>();                                
                Dialog_result = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public fa_liquidacion_x_punto_cargo_det_mano_obra_Info get_info()
        {
            try
            {
                return info_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void gridView_mano_obra_det_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_mano_obra_det.DeleteSelectedRows();
                    }
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
