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
using System.Linq;

namespace Core.Erp.Winform.Talento_humano
{
    public partial class frmTlh_evaluacion_cons : DevExpress.XtraEditors.XtraForm
    {  
        #region variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tlh_evaluacion_opciones_preguntas_respuesta_info> lista_preguntas = new List<tlh_evaluacion_opciones_preguntas_respuesta_info>();
        tlh_evaluacion_opciones_preguntas_respuesta_bus bus_preguntas = new tlh_evaluacion_opciones_preguntas_respuesta_bus();
        tlh_evaluacion_opciones_preguntas_respuesta_info info_pregunta = new tlh_evaluacion_opciones_preguntas_respuesta_info();
        #endregion
        public frmTlh_evaluacion_cons()
        {
            InitializeComponent();
           
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
                lista_preguntas = bus_preguntas.get_list(param.IdEmpresa);
                gridControl_Grupo.DataSource = lista_preguntas;
             
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
                frmTlh_evaluacion_mant frm = new frmTlh_evaluacion_mant();
                frm.set_accion(Accion);
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                    frm.set_info(info_pregunta);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.Event_frmTlh_evaluacion_mant_FormClosing += frm_Event_frmTlh_evaluacion_mant_FormClosing;
                 
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_Event_frmTlh_evaluacion_mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            buscar();
        }

        void frm_event_delegate_frminv_bodega_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscar();
        }

        void frm_event_delegate_frminv_categoria_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscar();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_respuesta_info)gridView_Grupo.GetFocusedRow();

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

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_respuesta_info)gridView_Grupo.GetFocusedRow();

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

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_pregunta = (tlh_evaluacion_opciones_preguntas_respuesta_info)gridView_Grupo.GetFocusedRow();

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

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


    }
}