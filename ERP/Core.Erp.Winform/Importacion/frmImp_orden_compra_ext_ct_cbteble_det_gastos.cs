using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using System.Linq;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_orden_compra_ext_ct_cbteble_det_gastos : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        BindingList<imp_orden_compra_ext_ct_cbteble_det_gastos_Info> blst_det;
        imp_orden_compra_ext_ct_cbteble_det_gastos_Bus bus_det;
        List<imp_orden_compra_ext_Info> lst_oc_ext;
        imp_orden_compra_ext_Bus bus_oc_ext;
        cl_parametrosGenerales_Bus param;
        List<imp_gasto_x_ct_plancta_Info> lst_gasto_tipo;
        imp_gasto_x_ct_plancta_Bus bus_gasto_tipo;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        List<ct_Plancta_Info> lst_plancta;
        ct_Plancta_Bus bus_plancta;
        List<ct_Cbtecble_tipo_Info> lst_tipo_cbte;
        ct_Cbtecble_tipo_Bus bus_tipo_cbte;
        #endregion

        public frmImp_orden_compra_ext_ct_cbteble_det_gastos()
        {
            InitializeComponent();
            blst_det = new BindingList<imp_orden_compra_ext_ct_cbteble_det_gastos_Info>();
            bus_det = new imp_orden_compra_ext_ct_cbteble_det_gastos_Bus();
            lst_oc_ext = new List<imp_orden_compra_ext_Info>();
            bus_oc_ext = new imp_orden_compra_ext_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            lst_gasto_tipo = new List<imp_gasto_x_ct_plancta_Info>();
            bus_gasto_tipo = new imp_gasto_x_ct_plancta_Bus();
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            lst_plancta = new List<ct_Plancta_Info>();
            bus_plancta = new ct_Plancta_Bus();
            lst_tipo_cbte = new List<ct_Cbtecble_tipo_Info>();
            bus_tipo_cbte = new ct_Cbtecble_tipo_Bus();
        }

        private void cargar_combos()
        {
            try
            {
                string mensaje = "";
                lst_gasto_tipo = bus_gasto_tipo.get_list(param.IdEmpresa);
                cmb_gasto_tipo.DataSource = lst_gasto_tipo;

                lst_oc_ext = bus_oc_ext.get_list(param.IdEmpresa);
                cmb_orden_compra_externa.Properties.DataSource = lst_oc_ext;

                lst_plancta = bus_plancta.Get_List_Plancta(param.IdEmpresa, ref mensaje);
                cmb_plancta.Properties.DataSource = lst_plancta;

                lst_tipo_cbte = bus_tipo_cbte.Get_list_Cbtecble_tipo(param.IdEmpresa, ref mensaje);
                cmb_tipo_cbte.DataSource = lst_tipo_cbte;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_det_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_det.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImp_orden_compra_ext_ct_cbteble_det_gastos_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_orden_compra_externa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_orden_compra_externa.EditValue == null)
                {
                    blst_det = new BindingList<imp_orden_compra_ext_ct_cbteble_det_gastos_Info>();
                    cmb_plancta.EditValue = null;
                }
                else
                {
                    blst_det = new BindingList<imp_orden_compra_ext_ct_cbteble_det_gastos_Info>(bus_det.get_list(param.IdEmpresa, Convert.ToDecimal(cmb_orden_compra_externa.EditValue)));
                    imp_orden_compra_ext_Info info_oc_ext = lst_oc_ext.FirstOrDefault(q => q.IdOrdenCompra_ext == Convert.ToDecimal(cmb_orden_compra_externa.EditValue));
                    if (info_oc_ext != null)
                        cmb_plancta.EditValue = info_oc_ext.IdCtaCble_importacion;
                    else
                        cmb_plancta.EditValue = null;

                }
                gridControl_det.DataSource = blst_det;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            try
            {
                cmb_orden_compra_externa.EditValue = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {
                cmb_orden_compra_externa.Focus();

                if (cmb_orden_compra_externa.EditValue == null)
                {
                    MessageBox.Show("Seleccione la orden de compra ext. a la que se asignarán los gastos",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_det.Count == 0)
                {
                    MessageBox.Show("No existen gastos para la orden de compra ext. seleccionada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_det.Where(q=>q.seleccionado == true).Count() == 0)
                {
                    if(MessageBox.Show("No ha asignado gastos a la orden de compra ext. seleccionada, desea continuar?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.No)
                        return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool guardarDB()
        {
            try
            {
                if (!validar())
                    return false;

                bus_det.eliminarDB(param.IdEmpresa, Convert.ToDecimal(cmb_orden_compra_externa.EditValue));
                if (bus_det.guardarDB(blst_det.Where(q=>q.seleccionado == true).ToList()))
                {
                    MessageBox.Show("Registro actualizado correctamente",param.nom_pc,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return true;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDB())
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDB())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_det.RowCount; i++)
                {
                    gridView_det.SetRowCellValue(i, col_seleccionado, chk_seleccionar_visibles.Checked);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}