using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.Importacion;
using System.Linq;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_catalogo_cons : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        List<imp_catalogo_tipo_Info> lst_catalogo_tipo;
        imp_catalogo_tipo_Bus bus_catalogo_tipo;
        List<imp_catalogo_Info> lst_catalogo;
        imp_catalogo_Bus bus_catalogo;
        cl_parametrosGenerales_Bus param;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        #endregion

        public frmImp_catalogo_cons()
        {
            InitializeComponent();
            lst_catalogo_tipo = new List<imp_catalogo_tipo_Info>();
            bus_catalogo_tipo = new imp_catalogo_tipo_Bus();
            lst_catalogo = new List<imp_catalogo_Info>();
            bus_catalogo = new imp_catalogo_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        }

        private void frmImp_catalogo_cons_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_catalogo_tipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_data_catalogo_tipo()
        {
            try
            {
                lst_catalogo_tipo = bus_catalogo_tipo.get_list();
                listBoxControl_catalogo_tipo.DataSource = lst_catalogo_tipo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_data_catalogo()
        {
            try
            {
                lst_catalogo = bus_catalogo.get_list(listBoxControl_catalogo_tipo.SelectedValue == null ? 0 : Convert.ToInt32(listBoxControl_catalogo_tipo.SelectedValue));
                gridControl_catalogo.DataSource = lst_catalogo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxControl_catalogo_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_catalogo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_formulario_catalogo_tipo(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_formulario_catalogo_tipo(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_formulario_catalogo_tipo(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamar_formulario_catalogo_tipo(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                imp_catalogo_tipo_Info row = new imp_catalogo_tipo_Info();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (listBoxControl_catalogo_tipo.SelectedValue == null)
                    {
                        MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }

                    row = lst_catalogo_tipo.FirstOrDefault(q => q.IdCatalogo_tipo == Convert.ToInt32(listBoxControl_catalogo_tipo.SelectedValue));
                    
                    if (!row.estado)
                    {
                        MessageBox.Show("El registro seleccionado se encuentra anulado",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                frmImp_catalogo_tipo_mant frm = new frmImp_catalogo_tipo_mant();
                frm.set_accion(Accion);
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.set_info(row);
                }
                frm.ShowDialog();
                load_data_catalogo_tipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamar_formulario_catalogo(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                imp_catalogo_Info row = new imp_catalogo_Info();
                row.IdCatalogo_tipo = listBoxControl_catalogo_tipo.SelectedValue == null ? 0 : Convert.ToInt32(listBoxControl_catalogo_tipo.SelectedValue);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    row = (imp_catalogo_Info)gridView_catalogo.GetFocusedRow();
                    if (row == null)
                    {
                        MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (!row.estado)
                    {
                        MessageBox.Show("El registro seleccionado se encuentra anulado",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                frmImp_catalogo_mant frm = new frmImp_catalogo_mant();
                frm.set_accion(Accion);
                frm.set_info(row);
                frm.ShowDialog();
                load_data_catalogo();
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario_catalogo(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario_catalogo(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario_catalogo(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario_catalogo(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_catalogo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                imp_catalogo_Info row = (imp_catalogo_Info)gridView_catalogo.GetRow(e.RowHandle);
                if (row == null) return;
                if (!row.estado)
                    e.Appearance.ForeColor = Color.Red;
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
                gridView_catalogo.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}