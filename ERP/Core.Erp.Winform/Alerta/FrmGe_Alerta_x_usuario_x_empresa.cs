using Core.Erp.Business.Alerta;
using Core.Erp.Business.General;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.Alerta;
using Core.Erp.Info.General;
using Core.Erp.Info.SeguridadAcceso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Alerta
{
    public partial class FrmGe_Alerta_x_usuario_x_empresa : Form
    {
        #region
        List<tb_sis_alerta_Info> lst_alerta = new List<tb_sis_alerta_Info>();
        tb_sis_alerta_Bus bus_alerta = new tb_sis_alerta_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<tb_sis_alerta_x_usuario_x_empresa_Info> blst_alerta_x_usuario = new BindingList<tb_sis_alerta_x_usuario_x_empresa_Info>();
        tb_sis_alerta_x_usuario_x_empresa_Bus bus_alerta_x_usuario = new tb_sis_alerta_x_usuario_x_empresa_Bus();

        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();

        List<seg_Usuario_x_Empresa_info> lst_usuario = new List<seg_Usuario_x_Empresa_info>();
        seg_Usuario_x_Empresa_Bus bus_usuario_x_empresa = new seg_Usuario_x_Empresa_Bus();
        #endregion

        public FrmGe_Alerta_x_usuario_x_empresa()
        {
            InitializeComponent();
        }

        private void cmb_usuario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_usuario.EditValue != null)
                {
                    blst_alerta_x_usuario = new BindingList<tb_sis_alerta_x_usuario_x_empresa_Info>(bus_alerta_x_usuario.get_list(param.IdEmpresa, cmb_usuario.EditValue.ToString()));

                }
                else
                    blst_alerta_x_usuario = new BindingList<tb_sis_alerta_x_usuario_x_empresa_Info>();

                gridControl_alerta_x_usuario.DataSource = blst_alerta_x_usuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_usuario.Focus();

                if (bus_alerta_x_usuario.guardarDB(get_info(), param.IdEmpresa, cmb_usuario.EditValue.ToString()))
                {
                    MessageBox.Show("Registros actualizados exitosamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    cmb_usuario.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_usuario.Focus();

                if (bus_alerta_x_usuario.guardarDB(get_info(),param.IdEmpresa,cmb_usuario.EditValue.ToString()))
                {
                    MessageBox.Show("Registros actualizados exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_img_Click(object sender, EventArgs e)
        {
            try
            {
                tb_sis_alerta_x_usuario_x_empresa_Info row = (tb_sis_alerta_x_usuario_x_empresa_Info)gridView_alerta_x_usuario.GetFocusedRow();
                if (row == null)
                    return;
                FrmGe_Alerta_x_usuario_x_empresa_eventos frm = new FrmGe_Alerta_x_usuario_x_empresa_eventos();
                frm.set_info(row);
                frm.ShowDialog();
                row = frm.get_info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                blst_alerta_x_usuario = new BindingList<tb_sis_alerta_x_usuario_x_empresa_Info>();
                gridControl_alerta_x_usuario.DataSource = blst_alerta_x_usuario;

                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.DataSource = lst_sucursal;

                lst_usuario = bus_usuario_x_empresa.Get_List_seg_Usuario_x_Empresa(param.IdEmpresa);
                cmb_usuario.Properties.DataSource = lst_usuario;

                lst_alerta = bus_alerta.get_list();
                cmb_alerta.DataSource = lst_alerta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Alerta_x_usuario_x_empresa_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<tb_sis_alerta_x_usuario_x_empresa_Info> get_info()
        {
            try
            {
                foreach (var item in blst_alerta_x_usuario)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdUsuario = cmb_usuario.EditValue.ToString();
                    
                    foreach (var item2 in item.lst_eventos.Where(q=>q.seleccionado == true))
                    {
                        item2.IdEmpresa = param.IdEmpresa;
                        item2.IdUsuario = cmb_usuario.EditValue.ToString();
                        item2.CodAlerta = item.CodAlerta;                        
                    }
                }

                return blst_alerta_x_usuario.ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<tb_sis_alerta_x_usuario_x_empresa_Info>();
            }
        }

        private void gridView_alerta_x_usuario_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_alerta)
                {
                    if (blst_alerta_x_usuario.Where(q=>q.CodAlerta == (e.Value == null ? "" : e.Value.ToString())).Count() != 0)
                    {
                        MessageBox.Show("El usuario ya tiene parametrizada la alerta");
                        gridView_alerta_x_usuario.DeleteRow(e.RowHandle);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_alerta_x_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    gridView_alerta_x_usuario.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
