using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Descuento_Mant : Form
    {

        #region Variables
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_descuento_Info descuento_Info = new fa_descuento_Info();
        fa_descuento_Bus descuento_Bus = new fa_descuento_Bus();

        public delegate void delegate_frmFa_Descuento_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFa_Descuento_Mant_FormClosing event_frmFa_Descuento_Mant_FormClosing;
        #endregion

        public frmFa_Descuento_Mant()
        {
            InitializeComponent();
            event_frmFa_Descuento_Mant_FormClosing += frmFa_Descuento_Mant_event_frmFa_Descuento_Mant_FormClosing;
        }

        void frmFa_Descuento_Mant_event_frmFa_Descuento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #region "Set"
        public void set_accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Info(fa_descuento_Info _Info)
        {
            try
            {
                descuento_Info = _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Accion_in_Controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;                      
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set_Info_in_Controls();
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        txtDescuento.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set_Info_in_Controls();
                       ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar  = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                         txt_PorecentajeDsc.Properties.ReadOnly = true;
                        txt_PorecentajeDsc.Properties.ReadOnly = true;
                        txt_Nombre.Properties.ReadOnly = true;
                        ucCon_PlanCtaCmb1.Enabled = false;
                        txtDescuento.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set_Info_in_Controls();
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar  = false;
                        txt_PorecentajeDsc.Properties.ReadOnly = true;
                        txt_PorecentajeDsc.Properties.ReadOnly = true;
                        txt_Nombre.Properties.ReadOnly = true;
                        ucCon_PlanCtaCmb1.Enabled = false;
                        txtDescuento.Properties.ReadOnly = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Info_in_Controls()
        {
            try 
	        {	        
		        if (descuento_Info != null)
                {
                    txtDescuento.EditValue = descuento_Info.IdDescuento;
                    txt_Nombre.Text = descuento_Info.de_nombre;
                    ucCon_PlanCtaCmb1.set_PlanCtarInfo(descuento_Info.de_IdCtaCble);
                    txt_PorecentajeDsc.EditValue = descuento_Info.de_porcentaje;
                    Txt_ObservacionDsc.Text = descuento_Info.de_observacion;                 
                }
	        }
	        catch (Exception ex)
	        {
		      string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
	        }
        }
        #endregion

        #region "Get"
        private void Get_Info()
        {
            try
            {
                descuento_Info = new fa_descuento_Info();
                descuento_Info.IdDescuento = Convert.ToDecimal(txtDescuento.EditValue);
                descuento_Info.IdEmpresa = param.IdEmpresa;
                descuento_Info.de_nombre = txt_Nombre.Text;
                descuento_Info.de_IdCtaCble = ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble;
                descuento_Info.de_porcentaje = Convert.ToDouble(txt_PorecentajeDsc.EditValue);
                descuento_Info.de_observacion = Txt_ObservacionDsc.Text;
                descuento_Info.Estado = true;
                descuento_Info.ip = param.ip;
                descuento_Info.nom_pc = param.nom_pc;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }
        #endregion      

        #region "Funciones"
        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;
                if (Validar())
                {
                     Get_Info();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            respuesta = GuardarBD();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            respuesta = modificarDB();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            respuesta = anularDB();
                            break;
                    }
                }
                return respuesta;
            }

            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean GuardarBD()
        {
            try
            {
                string mensaje = string.Empty; 
                bool resultado = false;
                descuento_Info.FechaCreacion  = DateTime.Now;
                descuento_Info.IdUsuarioCreacion = param.IdUsuario;               
                resultado = descuento_Bus.GrabarBD(descuento_Info, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();                   
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool modificarDB()
        {
            try
            {
                string mensaje = string.Empty; 
                bool resultado = false;
                descuento_Info.FechaUltMod  = DateTime.Now;
                descuento_Info.IdUsuarioUltMod = param.IdUsuario;
                resultado = descuento_Bus.ModificarBD(descuento_Info, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();                   
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool anularDB()
        {
            try
            {
                string mensaje = string.Empty; 
                bool resultado = false;
                if (descuento_Info.Estado != false)
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) + " Descuento : " + txt_Nombre.Text + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        descuento_Info.IdUsuarioUltAnu = param.IdUsuario;
                        descuento_Info.Fecha_UltAnu = DateTime.Now;
                        descuento_Info.MotiAnula = fr.motivoAnulacion;
                         resultado = descuento_Bus.AnularBD(descuento_Info, ref mensaje);
                            if (resultado)
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                            }
                            else
                            {
                                Log_Error_bus.Log_Error(mensaje.ToString());
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                            }                
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }


        private bool Validar()
        {
            try
            {
                bool resultado = true;
                if (string.IsNullOrEmpty(txt_Nombre.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " nombre", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Nombre.Focus();
                    resultado = false;
                }
                if (string.IsNullOrEmpty(Txt_ObservacionDsc.Text))
                {

                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txt_ObservacionDsc.Focus();
                    resultado = false;
                }
                if (string.IsNullOrEmpty(txt_PorecentajeDsc.Text))
                {

                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " porcentaje", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_PorecentajeDsc.Focus();
                    resultado = false;
                }

                if (ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble == null)
                {

                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " cuenta contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCon_PlanCtaCmb1.Focus();
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        void Limpiar()
        {
            try 
	        {	
                descuento_Info = new fa_descuento_Info();
                txtDescuento.Text = string.Empty;
		        txt_Nombre.Text = string.Empty;
                Txt_ObservacionDsc.Text = string.Empty;
                txt_PorecentajeDsc.EditValue = null;
                ucCon_PlanCtaCmb1.Inicializar_cmbPlanCta();
	        }
	        catch (Exception ex)
	        {
		
		         string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
	        }
           
        }
        #endregion

        #region "Eventos"
        private void frmFa_Descuento_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Set_Accion_in_Controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Accion_Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmFa_Descuento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmFa_Descuento_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion
    }
}
