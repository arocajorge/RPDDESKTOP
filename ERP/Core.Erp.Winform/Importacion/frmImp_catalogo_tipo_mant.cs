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

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_catalogo_tipo_mant : DevExpress.XtraEditors.XtraForm
    {
        #region variables
        imp_catalogo_tipo_Bus bus_catalogo_tipo;
        imp_catalogo_tipo_Info info_catalogo_tipo;
        Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        #endregion

        public frmImp_catalogo_tipo_mant()
        {
            InitializeComponent();
            info_catalogo_tipo = new imp_catalogo_tipo_Info();
            bus_catalogo_tipo = new imp_catalogo_tipo_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _accion)
        {
            try
            {
                Accion = _accion;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void set_info(imp_catalogo_tipo_Info _info)
        {
            try
            {
                info_catalogo_tipo = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        uc_menu.Visible_btnGuardar = true;
                        uc_menu.Visible_bntGuardar_y_Salir = true;
                        uc_menu.Visible_bntAnular = false;
                        uc_menu.Visible_bntLimpiar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        uc_menu.Visible_btnGuardar = true;
                        uc_menu.Visible_bntGuardar_y_Salir = true;
                        uc_menu.Visible_bntAnular = false;
                        uc_menu.Visible_bntLimpiar = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        uc_menu.Visible_btnGuardar = false;
                        uc_menu.Visible_bntGuardar_y_Salir = false;
                        uc_menu.Visible_bntAnular = true;
                        uc_menu.Visible_bntLimpiar = false;
                        set_info_in_controls();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                txt_IdCatalogo_tipo.Text = info_catalogo_tipo.IdCatalogo_tipo.ToString();
                txt_descripcion.Text = info_catalogo_tipo.ct_descripcion;
                lbl_anulado.Visible = !info_catalogo_tipo.estado;
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
                txt_IdCatalogo_tipo.Text = "";
                txt_descripcion.Text = "";
                lbl_anulado.Visible = false;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImp_catalogo_tipo_mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_accion_in_controls();
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
                if (txt_descripcion.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la descripción",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

        private bool accion_grabar()
        {
            try
            {
                bool res = false;

                if (!validar())
                    return false;

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
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void get_info()
        {
            try
            {
                info_catalogo_tipo.IdCatalogo_tipo = txt_IdCatalogo_tipo.Text == "" ? 0 : Convert.ToInt32(txt_IdCatalogo_tipo.Text);
                info_catalogo_tipo.ct_descripcion = txt_descripcion.Text.Trim();
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

                if (bus_catalogo_tipo.guardarDB(info_catalogo_tipo))
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

        private bool modificarDB()
        {
            try
            {
                bool res = false;

                if (bus_catalogo_tipo.modificarDB(info_catalogo_tipo))
                {
                    MessageBox.Show("Registro modificado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private bool anularDB()
        {
            try
            {
                bool res = false;

                if (bus_catalogo_tipo.anularDB(info_catalogo_tipo))
                {
                    MessageBox.Show("Registro anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void uc_menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void uc_menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
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

        private void uc_menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
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

        private void uc_menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
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

        private void uc_menu_event_btnlimpiar_Click(object sender, EventArgs e)
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
    }
}