using Core.Erp.Business.General;
using Core.Erp.Business.Mantenimiento;
using Core.Erp.Info.Mantenimiento;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Mantenimiento
{
    public partial class FrmMan_actividad_mant : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<man_actividad_det_Info> blst_actividad = new BindingList<man_actividad_det_Info>();
        man_actividad_Bus bus_actividad = new man_actividad_Bus();
        man_actividad_Info info_actividad = new man_actividad_Info();
        Cl_Enumeradores.eTipo_action Accion;
        man_actividad_det_Bus bus_actividad_det = new man_actividad_det_Bus();
        List<man_actividad_Info> lst_actividad = new List<man_actividad_Info>();
        #endregion

        #region delegados
        public delegate void delegate_FrmMan_actividad_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FrmMan_actividad_mant_FormClosed event_delegate_FrmMan_actividad_mant_FormClosed;
        #endregion

        public FrmMan_actividad_mant()
        {
            InitializeComponent();
            event_delegate_FrmMan_actividad_mant_FormClosed += FrmMan_actividad_mant_event_delegate_FrmMan_actividad_mant_FormClosed;
        }

        void FrmMan_actividad_mant_event_delegate_FrmMan_actividad_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public void set_info(man_actividad_Info info)
        {
            try
            {
                info_actividad = info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmMan_actividad_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_FrmMan_actividad_mant_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargar_combos()
        {
            try
            {
                blst_actividad = new BindingList<man_actividad_det_Info>();
                gridControl_actividades.DataSource = blst_actividad;

                lst_actividad = bus_actividad.get_list(param.IdEmpresa, false);
                cmb_actividades.DataSource = lst_actividad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                cargar_combos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        menu.Visible_bntGuardar_y_Salir = true;
                        menu.Visible_btnGuardar = true;
                        menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        menu.Visible_bntGuardar_y_Salir = true;
                        menu.Visible_btnGuardar = true;
                        menu.Visible_bntAnular = false;                        
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        menu.Visible_bntGuardar_y_Salir = false;
                        menu.Visible_btnGuardar = false;
                        menu.Visible_bntAnular = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        menu.Visible_bntGuardar_y_Salir = false;
                        menu.Visible_btnGuardar = false;
                        menu.Visible_bntAnular = false;
                        set_info_in_controls();
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                txt_ac_codigo.Text = info_actividad.ac_codigo;
                txt_ac_descripcion.Text = info_actividad.ac_descripcion;
                txt_ac_observacion.Text = info_actividad.ac_observacion;
                txt_IdActividad.Text = info_actividad.IdActividad.ToString();
                txt_cant_horas_min.EditValue = info_actividad.ac_cant_horas_min;
                blst_actividad = new BindingList<man_actividad_det_Info>(bus_actividad_det.get_list(info_actividad.IdEmpresa,info_actividad.IdActividad));
                gridControl_actividades.DataSource = blst_actividad;

                lbl_anulado.Visible = !info_actividad.estado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void get_info()
        {
            try
            {
                info_actividad.IdEmpresa = param.IdEmpresa;
                info_actividad.ac_codigo = txt_ac_codigo.Text;
                info_actividad.ac_descripcion = txt_ac_descripcion.Text;
                info_actividad.ac_observacion = txt_ac_observacion.Text;
                info_actividad.IdActividad = txt_IdActividad.Text == "" ? 0 : Convert.ToDecimal(txt_IdActividad.Text);
                info_actividad.ac_cant_horas_min = Convert.ToDouble(txt_cant_horas_min.EditValue);
                info_actividad.lst_actividad_det = new List<man_actividad_det_Info>(blst_actividad);                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void limpiar()
        {
            try
            {
                info_actividad = new man_actividad_Info();

                txt_ac_codigo.Text = "";
                txt_ac_descripcion.Text = "";
                txt_ac_observacion.Text = "";
                txt_IdActividad.Text = "";
                txt_cant_horas_min.EditValue = 0.00;

                blst_actividad = new BindingList<man_actividad_det_Info>();
                gridControl_actividades.DataSource = blst_actividad;

                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion_in_controls();

                lbl_anulado.Visible = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private bool Validar()
        {
            try
            {
                if (txt_ac_codigo.Text == "")
                {
                    MessageBox.Show("Ingrese el código",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txt_ac_descripcion.Text == "")
                {
                    MessageBox.Show("Ingrese la descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }               

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool accion_guardar()
        {
            try
            {
                bool res = false;
                if (!Validar()) return false;
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool guardarDB()
        {
            try
            {
                if (bus_actividad.guardarDB(info_actividad))
                {
                    MessageBox.Show("Registro guardado exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool modificarDB()
        {
            try
            {
                if (bus_actividad.modificarDB(info_actividad))
                {
                    MessageBox.Show("Registro modificado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool anularDB()
        {
            try
            {
                if (bus_actividad.anularDB(info_actividad))
                {
                    MessageBox.Show("Registro anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_guardar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_guardar())
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_guardar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_actividades_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_actividades.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmMan_actividad_mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        
    }
}
