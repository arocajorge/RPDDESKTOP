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
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_parametro : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        imp_parametro_Info info_imp_parametro;
        imp_parametro_Bus bus_imp_parametro;
        cl_parametrosGenerales_Bus param;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        List<imp_gasto_x_ct_plancta_Info> lst_gastos;
        imp_gasto_x_ct_plancta_Bus bus_gastos;
        #endregion

        public frmImp_parametro()
        {
            InitializeComponent();
            info_imp_parametro = new imp_parametro_Info();
            bus_imp_parametro = new imp_parametro_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            lst_gastos = new List<imp_gasto_x_ct_plancta_Info>();
            bus_gastos = new imp_gasto_x_ct_plancta_Bus();
        }

        private void set_info_in_controls()
        {
            try
            {
                info_imp_parametro = bus_imp_parametro.get_info(param.IdEmpresa);
                if (info_imp_parametro != null)
                {
                    cmb_tipoCbte_liquidacion.set_TipoCbteCble(info_imp_parametro.IdTipoCbte_liquidacion == null ? 0 : Convert.ToInt32(info_imp_parametro.IdTipoCbte_liquidacion));
                    cmb_tipoCbte_liquidacion_anu.set_TipoCbteCble(info_imp_parametro.IdTipoCbte_liquidacion_anu == null ? 0 : Convert.ToInt32(info_imp_parametro.IdTipoCbte_liquidacion_anu));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_info()
        {
            try
            {
                info_imp_parametro.IdEmpresa = param.IdEmpresa;
                info_imp_parametro.IdTipoCbte_liquidacion = cmb_tipoCbte_liquidacion.get_TipoCbteCble().IdTipoCbte;
                info_imp_parametro.IdTipoCbte_liquidacion_anu = cmb_tipoCbte_liquidacion_anu.get_TipoCbteCble().IdTipoCbte;
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
                if (cmb_tipoCbte_liquidacion.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Seleccione el tipo de comprobante para diario de liquidacion",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_tipoCbte_liquidacion_anu.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Seleccione el tipo de comprobante para diario de anulación de liquidacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void load_data()
        {
            try
            {
                lst_gastos = bus_gastos.get_list(param.IdEmpresa);
                gridControl_gastos.DataSource = lst_gastos;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImp_parametro_Load(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
                load_data();
                set_info_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool guardarDB()
        {
            try
            {
                bool res = false;
                if (!validar())
                    return false;

                get_info();

                if (bus_imp_parametro.guardarDB(info_imp_parametro))
                {
                    MessageBox.Show("Registro guardado exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    res = true;
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDB();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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

        private void gridView_gastos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                imp_gasto_x_ct_plancta_Info row = (imp_gasto_x_ct_plancta_Info)gridView_gastos.GetRow(e.RowHandle);
                if (row == null) return;
                if (!row.info_gasto.estado)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamar_formulario_gasto(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                imp_gasto_x_ct_plancta_Info row = (imp_gasto_x_ct_plancta_Info)gridView_gastos.GetFocusedRow();
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (row == null)
                    {
                        MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (!row.info_gasto.estado && Accion != Cl_Enumeradores.eTipo_action.consultar)
                    {
                        MessageBox.Show("El registro se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                frmImp_gasto_x_ct_plancta_mant frm = new frmImp_gasto_x_ct_plancta_mant();
                frm.set_accion(Accion);
                if (Accion!= Cl_Enumeradores.eTipo_action.grabar)
                    frm.set_info(row);
                frm.ShowDialog();
                load_data();
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
                llamar_formulario_gasto(Cl_Enumeradores.eTipo_action.grabar);
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
                llamar_formulario_gasto(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
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
    }
}