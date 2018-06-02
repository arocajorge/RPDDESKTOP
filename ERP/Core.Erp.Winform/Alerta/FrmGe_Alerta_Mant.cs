using Core.Erp.Business.Alerta;
using Core.Erp.Business.General;
using Core.Erp.Info.Alerta;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Alerta
{
    public partial class FrmGe_Alerta_Mant : Form
    {
        #region Variables
        tb_sis_alerta_Info info_alerta = new tb_sis_alerta_Info();
        tb_sis_alerta_Bus bus_alerta = new tb_sis_alerta_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        List<tb_modulo_Info> lst_modulo = new List<tb_modulo_Info>();
        tb_modulo_Bus bus_modulo = new tb_modulo_Bus();
        private Assembly Ensamblado;
        #endregion

        #region Delegados
        public delegate void delegate_FrmGe_Alerta_Mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FrmGe_Alerta_Mant_FormClosed event_delegate_FrmGe_Alerta_Mant_FormClosed;

        void FrmGe_Alerta_Mant_event_delegate_FrmGe_Alerta_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmGe_Alerta_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            event_delegate_FrmGe_Alerta_Mant_FormClosed(sender, e);
        }
        #endregion

        private void cargar_combos()
        {
            try
            {
                lst_modulo = bus_modulo.Get_list_Modulo();
                cmb_modulo.Properties.DataSource = lst_modulo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmGe_Alerta_Mant()
        {
            InitializeComponent();
            event_delegate_FrmGe_Alerta_Mant_FormClosed += FrmGe_Alerta_Mant_event_delegate_FrmGe_Alerta_Mant_FormClosed;
        }

        public void set_info(tb_sis_alerta_Info _info)
        {
            try
            {
                info_alerta = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _accion)
        {
            try
            {
                Accion = _accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                txt_class_info.Text = info_alerta.Class_NomReporte;
                txt_Id.Text = info_alerta.CodAlerta;
                txt_frm.Text = info_alerta.Formulario;
                cmb_modulo.EditValue = info_alerta.CodModulo;
                txt_nombre.Text = info_alerta.Nombre;
                
                txt_obser.Text = info_alerta.observacion;
                txt_tabla.Text = info_alerta.VistaRpt;

                txt_class_rpt.Text = info_alerta.Class_NomReporte;
                txt_class_bus.Text = info_alerta.Class_Bus;
                txt_class_data.Text = info_alerta.Class_Data;
                txt_class_info.Text = info_alerta.Class_Info;
                chkEstado.Checked = info_alerta.Estado;

                txt_asembly.Text = info_alerta.nom_Asembly;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Alerta_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmb_modulo.Properties.ReadOnly = true;
                        txt_Id.ReadOnly = true;
                        txt_Id.ReadOnly = true;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        cmb_modulo.Properties.ReadOnly = true;
                        set_info_in_controls();
                        txt_Id.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        cmb_modulo.Properties.ReadOnly = true;
                        ucGe_Menu.Visible_bntDiseñoReporte = false;
                        txt_Id.ReadOnly = true;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        set_info_in_controls();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_modulo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_modulo.EditValue != null)
                {
                    tb_modulo_Info items = lst_modulo.FirstOrDefault(q => q.CodModulo == cmb_modulo.EditValue.ToString());

                    if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (items != null)
                        {
                            string carpeta = items.Nom_Carpeta;
                            string codModulo = cmb_modulo.EditValue.ToString();
                            string num = bus_alerta.Get_Numero(codModulo);
                            txt_Id.Text = cmb_modulo.EditValue.ToString() + "_" + num;
                            txt_tabla.Text = "vw" + codModulo + "_Alerta_" + num;
                            txt_class_info.Text = carpeta + ".X" + codModulo + "_" + num + "_Info";
                            txt_class_bus.Text = carpeta + ".X" + codModulo + "_" + num + "_Bus";
                            txt_class_data.Text = carpeta + ".X" + codModulo + "_" + num + "_Data";
                            txt_class_rpt.Text = carpeta + ".X" + codModulo + "_" + num + "_Rpt";
                            txt_asembly.Text = "Core.Erp.Alertas";
                            txt_frm.Text = carpeta + ".X" + codModulo + "_" + num + "_frm";
                            //Nom_SP = "sp" + codModulo + "_Rpt" + num;
                        }
                    }    
                }                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImpFrm_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre_dll = "";
                string Nom_asambly = "";
                string NombreFormulario = "";
                string RutaPantalla = "";

                Nom_asambly = txt_asembly.Text.Trim();
                NombreFormulario = txt_frm.Text.Trim();

                nombre_dll = Nom_asambly + ".dll";

                //cargando la dll
                Ensamblado = Assembly.LoadFrom(nombre_dll);

                // Load the object
                string nAsambly2 = txt_asembly.Text;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(Nom_asambly + "." + NombreFormulario);

                AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;
                //

                RutaPantalla = Nom_asambly + "." + NombreFormulario;


                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario Emsamblado:" + Nom_asambly + "  Formulario:" + NombreFormulario, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjFrm = Activator.CreateInstance(tipo);
                    Form Formulario = (Form)ObjFrm;
                    Formulario.WindowState = FormWindowState.Maximized;
                    Formulario.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void limpiar()
        {
            try
            {
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                cmb_modulo.EditValue = null;
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;
                txt_class_info.ReadOnly = false;
                txt_Id.ReadOnly = false;
                txt_frm.ReadOnly = false;
                cmb_modulo.Properties.ReadOnly = false;
                txt_nombre.ReadOnly = false;
                txt_obser.ReadOnly = false;
                txt_tabla.ReadOnly = false;

                txt_asembly.ReadOnly = false;

                txt_class_info.Text = "";
                txt_class_bus.Text = "";
                txt_class_data.Text = "";
                txt_class_rpt.Text = "";
                txt_Id.Text = "";
                txt_frm.Text = "";
                txt_nombre.Text = "";
                txt_obser.Text = "";

                txt_tabla.Text = "";

                txt_asembly.Text = "";

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }   

        private void ucGe_Menu_event_btnImpRep_Click(object sender, EventArgs e)
        {

            try
            {

                string nombre_dll = "";
                string Nom_asambly = "";
                string NombreReporte = "";
                string RutaPantalla = "";

                Nom_asambly = txt_asembly.Text.Trim();
                NombreReporte = txt_class_rpt.Text.Trim();

                nombre_dll = Nom_asambly + ".dll";

                //cargando la dll
                Ensamblado = Assembly.LoadFrom(nombre_dll);

                // Load the object
                string nAsambly2 = txt_asembly.Text;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(Nom_asambly + "." + NombreReporte);

                AssemblyName assemName = Ensamblado.GetName();
                Version ver = assemName.Version;
                //
                RutaPantalla = Nom_asambly + "." + NombreReporte;

                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el Reporte Emsamblado:" + Nom_asambly + "  Reporte:" + NombreReporte, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjFrm = Activator.CreateInstance(tipo);
                    DevExpress.XtraReports.UI.XtraReport reporte1 = (DevExpress.XtraReports.UI.XtraReport)ObjFrm;
                    reporte1.ShowPreviewDialog();

                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool valida()
        {
            try
            {
                if (txt_nombre.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Nombre del Reporte ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
               if (txt_tabla.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Nombre de la Tabla", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

               if (cmb_modulo.EditValue == null || cmb_modulo.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Modulo al que pertenece el Reporte", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void get_Info()
        {
            try
            {
                info_alerta.Class_NomReporte = txt_class_rpt.Text.Trim();
                info_alerta.Class_Info = txt_class_info.Text.Trim();
                info_alerta.Class_Bus = txt_class_bus.Text.Trim();
                info_alerta.Class_Data = txt_class_data.Text.Trim();
                info_alerta.CodAlerta = txt_Id.Text.Trim();
                info_alerta.Formulario = txt_frm.Text.Trim();
                info_alerta.CodModulo = cmb_modulo.EditValue.ToString();
                info_alerta.Nombre = txt_nombre.Text.Trim();
                info_alerta.VistaRpt = txt_tabla.Text.Trim();
                info_alerta.nom_Asembly = txt_asembly.Text.Trim();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Grabar()
        {
            try
            {
                bool resultado = false;
                if (valida())
                {
                    get_Info();

                    if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (bus_alerta.guardarDB(info_alerta))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la alerta " + this.txt_nombre.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            resultado = true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos) + " la alerta " + this.txt_nombre.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultado = false;
                        }
                    }
                    if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (bus_alerta.modificarDB(info_alerta))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la alerta " + this.txt_nombre.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resultado = true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_modificaron_los_datos) + " la alerta " + this.txt_nombre.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultado = false;
                        }
                    }
                    return resultado;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
