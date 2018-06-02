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

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_orden_compra_ext_recepcion_cons : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        List<imp_orden_compra_ext_recepcion_Info> lst_recepcion;
        imp_orden_compra_ext_recepcion_Bus bus_recepcion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        #endregion

        public frmImp_orden_compra_ext_recepcion_cons()
        {
            InitializeComponent();
            param = cl_parametrosGenerales_Bus.Instance;
            lst_recepcion = new List<imp_orden_compra_ext_recepcion_Info>();
            bus_recepcion = new imp_orden_compra_ext_recepcion_Bus();
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        }

        private void load_data()
        {
            try
            {
                lst_recepcion = bus_recepcion.get_list(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
                gridControl_recepcion.DataSource = lst_recepcion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamar_formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                imp_orden_compra_ext_recepcion_Info row = (imp_orden_compra_ext_recepcion_Info)gridView_recepcion.GetFocusedRow();
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (row == null)
                    {
                        MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                frmImp_orden_compra_ext_recepcion_mant frm = new frmImp_orden_compra_ext_recepcion_mant();
                frm.MdiParent = this.MdiParent;
                frm.set_accion(Accion);
                if(Accion!= Cl_Enumeradores.eTipo_action.grabar)
                    frm.set_info(row);
                frm.Show();
                frm.event_delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed += frm_event_delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frmImp_orden_compra_ext_recepcion_cons_Load(object sender, EventArgs e)
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
                llamar_formulario(Cl_Enumeradores.eTipo_action.grabar);
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
                gridControl_recepcion.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}