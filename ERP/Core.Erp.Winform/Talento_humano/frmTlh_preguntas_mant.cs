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
    public partial class frmTlh_preguntas_mant : DevExpress.XtraEditors.XtraForm
    { 
        #region variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tlh_evaluacion_opciones_preguntas_info info_preguntas = new tlh_evaluacion_opciones_preguntas_info();
        tlh_evaluacion_opciones_preguntas_bus bus_preguntas = new tlh_evaluacion_opciones_preguntas_bus();
        BindingList<tlh_evaluacion_opciones_preguntas_det_info> lista_preguntas = new BindingList<tlh_evaluacion_opciones_preguntas_det_info>();
        tlh_evaluacion_opciones_preguntas_det_bus bus_detalle = new tlh_evaluacion_opciones_preguntas_det_bus();
        Cl_Enumeradores.eTipo_action Accion;
        int numero_op=0;
        #endregion        

        #region delegados
        #endregion

        public frmTlh_preguntas_mant()
        {
            InitializeComponent();
        }

       
        private void set_accion_in_controls()
        {
            try
            {
                cargar_combos();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_info_in_controls();
                      
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        set_info_in_controls();
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        set_info_in_controls();
                       
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_info(tlh_evaluacion_opciones_preguntas_info _info)
        {
            try
            {
                info_preguntas = _info;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
               txtid.EditValue = info_preguntas.IdPregunta;
               cmb_num_preguntas.EditValue = info_preguntas.IdOpciones;
               txtpregunta.EditValue = info_preguntas.Descripcion;
               txtpregunta.EditValue = info_preguntas.Descripcion;
               lbl_anulado.Visible = !info_preguntas.estado;
               lista_preguntas =new BindingList<tlh_evaluacion_opciones_preguntas_det_info>( bus_detalle.get_list(info_preguntas.IdEmpresa,info_preguntas.IdPregunta));
               gridControl_opciones.DataSource = lista_preguntas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_info()
        {
            try
            {
                info_preguntas.IdEmpresa = param.IdEmpresa;
                info_preguntas.IdOpciones =Convert.ToInt32( cmb_num_preguntas.EditValue);
                info_preguntas.IdPregunta =Convert.ToInt32( txtid.EditValue);
                info_preguntas.Descripcion = txtpregunta.EditValue.ToString().Trim();
                info_preguntas.Numero_opciones = Convert.ToInt32(cmb_num_preguntas.EditValue);
                info_preguntas.detalle = lista_preguntas.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            try
            {
                txtid.EditValue = null;
                txtpregunta.EditValue = null;
                cmb_num_preguntas.EditValue = null;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion_in_controls();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {


                if (lista_preguntas.Count()==0)
                {
                    MessageBox.Show("No existe detalle, las preguntas dben tener minimo dos opciones", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                if (txtpregunta.EditValue == null)
                {
                    MessageBox.Show("Ingrese una pregunta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_num_preguntas.EditValue==null)
                {
                    MessageBox.Show("Seleccione una numero de opciones para la pregunta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool accion_grabar()
        {
            try
            {
                bool res = false;
                if (!validar()) return false;

                get_info();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = guardarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = modificarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        res = anularDB();
                        break;
                }

                return res;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool guardarDB()
        {
            try
            {
                string mensaje = "";
                if (bus_preguntas.Guardar_DB(info_preguntas))
                {
                   
                        MessageBox.Show("Registro guardado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;

                }
                else
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool modificarDB()
        {
            try
            {
                if (bus_preguntas.Modificar_DB(info_preguntas))
                {
                   
                        MessageBox.Show("Registro modificado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;
                   
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool anularDB()
        {
            try
            {
                if (bus_preguntas.Anular_DB(info_preguntas))
                {
                   
                    MessageBox.Show("Registro anulado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    
        private void cargar_combos()
        {
            try
            {
                Dictionary<int, string> impuesto = Enum.GetValues(typeof(Cl_Enumeradores.eOpcionesPreguntas))
                 .Cast<Cl_Enumeradores.eOpcionesPreguntas>().ToDictionary(x => (int)x, x => x.ToString());

                cmb_num_preguntas.Properties.ValueMember = "Key";
                cmb_num_preguntas.Properties.DisplayMember = " Value";
                cmb_num_preguntas.Properties.DataSource = impuesto.ToList();
             
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void  frmTlh_preguntas_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frmTlh_preguntas_mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_accion_in_controls();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmb_num_preguntas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista_preguntas = new BindingList<tlh_evaluacion_opciones_preguntas_det_info>();
                numero_op = Convert.ToInt32(cmb_num_preguntas.EditValue);
                int secuencia = 0;
                while (secuencia<numero_op)
                {
                    secuencia++;
                    tlh_evaluacion_opciones_preguntas_det_info info = new tlh_evaluacion_opciones_preguntas_det_info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.secuencia = secuencia;
                    lista_preguntas.Add(info);
                }

                gridControl_opciones.DataSource = lista_preguntas;

            }
            catch (Exception)
            {
            MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}