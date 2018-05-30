using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Info.Talento_humano;
using Core.Erp.Business.General;
using Core.Erp.Business.Talento_humano;
using Core.Erp.Info.General;
using System.Linq;

namespace Core.Erp.Winform.Talento_humano
{
    public partial class frmTlh_preguntas_cons : DevExpress.XtraEditors.XtraForm
    {  
        #region variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tlh_evaluacion_opciones_preguntas_info> lista_preguntas = new List<tlh_evaluacion_opciones_preguntas_info>();
        tlh_evaluacion_opciones_preguntas_bus bus_preguntas = new tlh_evaluacion_opciones_preguntas_bus();
        tlh_evaluacion_opciones_preguntas_info info_pregunta = new tlh_evaluacion_opciones_preguntas_info();
        #endregion
        public frmTlh_preguntas_cons()
        {
            InitializeComponent();
        }

        private void ucge_menu_event_delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucge_menu_event_delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_info)gridView_Preguntas.GetFocusedRow();

                if (info_pregunta == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!info_pregunta.estado)
                {
                    MessageBox.Show("El registro seleccionado se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_event_delegate_btn_consultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_info)gridView_Preguntas.GetFocusedRow();

                if (info_pregunta == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_event_delegate_btn_modificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_info)gridView_Preguntas.GetFocusedRow();

                if (info_pregunta == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!info_pregunta.estado)
                {
                    MessageBox.Show("El registro seleccionado se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucge_menu_event_delegate_btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frminv_categoria_cons_Load(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buscar()
        {
            try
            {

                lista_preguntas = bus_preguntas.get_list (param.IdEmpresa);
                gridControl_Preguntas.DataSource = lista_preguntas;
             
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamar_formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                frmTlh_preguntas_mant frm = new frmTlh_preguntas_mant();
                frm.set_accion(Accion);
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                    frm.set_info(info_pregunta);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                 
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_delegate_frminv_bodega_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscar();
        }

        void frm_event_delegate_frminv_categoria_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
                llamar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_info)gridView_Preguntas.GetFocusedRow();

                if (info_pregunta == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_info)gridView_Preguntas.GetFocusedRow();

                if (info_pregunta == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_info)gridView_Preguntas.GetFocusedRow();

                if (info_pregunta == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Preguntas_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Preguntas.GetRow(e.RowHandle) as tlh_evaluacion_opciones_preguntas_info;
                if (data == null)
                    return;
                if (data.estado ==false)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}