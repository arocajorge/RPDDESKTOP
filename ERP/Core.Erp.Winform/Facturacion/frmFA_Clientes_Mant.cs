using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Clientes_Mant : Form
    {

        #region declaraciones
        Boolean IdCliente_Registrado = false;
        decimal id_persona = 0;
        decimal id_cliente = 0;

        public List<fa_Cliente_Tabla_Info> ListClientes { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
        fa_Cliente_Info info = new fa_Cliente_Info();
        fa_Cliente_Info info_tmp = new fa_Cliente_Info();        
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
        tb_persona_Info info_persona = new tb_persona_Info();
        fa_catalogo_Info info_catalogo = new fa_catalogo_Info();
        fa_catalogo_Info info_actividad = new fa_catalogo_Info();
        Cl_TipoDoc_Personales_Info info_doc_personal = new Cl_TipoDoc_Personales_Info();
        tb_persona_bus bus_persona = new tb_persona_bus();
        List<ct_Plancta_Info> listaPLan = new List<ct_Plancta_Info>();
        List<ct_Plancta_Info> ListaPlanAntList = new List<ct_Plancta_Info>();
        List<fa_catalogo_Info> ListaTipoCliente = new List<fa_catalogo_Info>();
        List<Cl_Categoria_Financiera_Info> ListaCategoria = new List<Cl_Categoria_Financiera_Info>();
        List<tb_Sucursal_Info> lista_sucursal = new List<tb_Sucursal_Info>();
        List<fa_Vendedor_Info> lista_vendedor = new List<fa_Vendedor_Info>();
        List<fa_catalogo_Info> lista_actividad_economica = new List<fa_catalogo_Info>();
        ct_Centro_costo_Bus BusCostos = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> ListCostos = new List<ct_Centro_costo_Info>();
        List<tb_persona_direccion_Info> lista_direccion = new List<tb_persona_direccion_Info>();
        List<tb_persona_direccion_Info> Direccion_Lista = new List<tb_persona_direccion_Info>();
        tb_persona_direccion_Bus bus_direccion = new tb_persona_direccion_Bus();
        List<fa_Cliente_Info> listaCliente = new List<fa_Cliente_Info>();
        fa_cliente_tipo_Info InfoTipoCli = new fa_cliente_tipo_Info();
        List<fa_formaPago_Info> listaformapago = new List<fa_formaPago_Info>();
        fa_formaPago_Bus busFormapago = new fa_formaPago_Bus();
        List<fa_TerminoPago_Info> listaterminoPago = new List<fa_TerminoPago_Info>();
        fa_TerminoPago_Bus busterminoPago = new fa_TerminoPago_Bus();
        BindingList<fa_cliente_contactos_Info> listaContacto = new BindingList<fa_cliente_contactos_Info>();
        fa_cliente_contactos_Bus bus_contactos = new fa_cliente_contactos_Bus();
        tb_parroquia_Bus bus_parroquia;
        public delegate void Delegate_frmFA_Clientes_Mant_FormClosing();
        public event Delegate_frmFA_Clientes_Mant_FormClosing event_frmFA_Clientes_Mant_FormClosing;
        List<tb_parroquia_Info> lst_parroquia;

        #endregion
        
        public frmFa_Clientes_Mant()
        {
            try
            {
               InitializeComponent();
               ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
               ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
               ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
               ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
               ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                
                event_frmFA_Clientes_Mant_FormClosing += frmFA_Clientes_Mant_event_frmFA_Clientes_Mant_FormClosing;
                UC_Doc_per.event_cmb_Docum_perso_SelectedValueChanged += UC_Doc_per_event_cmb_Docum_perso_SelectedValueChanged;
                cmbTipo.event_cmbClienteTipo_EditValueChanged += cmbTipo_event_cmbClienteTipo_EditValueChanged;

                bus_parroquia = new tb_parroquia_Bus();
                lst_parroquia = new List<tb_parroquia_Info>();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmbTipo_event_cmbClienteTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoTipoCli = cmbTipo.get_ClienteTipoInfo();
                if (InfoTipoCli != null)
                {
                    cmb_plancta.set_PlanCtarInfo(InfoTipoCli.IdCtaCble_CXC_Con);
                    cmb_PlanCta_Credito.set_PlanCtarInfo(InfoTipoCli.IdCtaCble_CXC_Cred);
                    cmb_PlanCtaAnti.set_PlanCtarInfo(InfoTipoCli.IdCtaCble_CXC_Anticipo);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";

                if (validaciones() == true)
                {
                    if (guardar(ref msg))
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";

                if (validaciones() == true)
                {
                    guardar(ref msg);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {     
                Anular();
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void frmFA_Clientes_Mant_event_frmFA_Clientes_Mant_FormClosing(){}

        void UC_Doc_per_event_cmb_Docum_perso_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
              txt_cedula_Enter(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void iniciar()
        {
            try
            {
               _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
              _Accion = iAccion; 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region metodo set y get del Cliente

        public void set_Cliente(fa_Cliente_Info obj)
        {
            try
            {
                info = new fa_Cliente_Info();
                info = obj;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Cliente_in_controls()
        {
            try
            {
                this.lbl_id_cliente.Text = info.IdCliente.ToString();
                this.txtCodigo.Text= info.Codigo;
                this.lbl_id_persona.Text = info.IdPersona.ToString();
                this.txt_nombres.Text = info.Persona_Info.pe_nombre.Trim();
                this.txt_apellidos.Text = info.Persona_Info.pe_apellido.Trim();
                UC_Doc_per.set_TipoDoc_Personales(info.Persona_Info.IdTipoDocumento);
                this.txt_cedula.Text = info.Persona_Info.pe_cedulaRuc.Trim();
                this.chk_Estado.Checked = (info.Estado == "A") ? true : false;
                lblEstado.Visible = (info.Estado == "I") ? true : false;
                this.txt_razon_social.Text = info.Persona_Info.pe_razonSocial.Trim();
                this.chk_Estado.Enabled = true;
                this.chk_Estado.Checked = (info.Estado == "A") ? true : false;
                ucGe_Natu_clie.set_Naturaleza(info.Persona_Info.pe_Naturaleza);
                

                this.lbl_id_persona.Text = info.IdPersona.ToString();
                this.lbl_id_cliente.Text = info.IdCliente.ToString();
                cmbTipo.set_ClienteTipoInfo(info.Idtipo_cliente);
                id_persona = Convert.ToDecimal(info.IdPersona);
                this.txt_plazo.Text = info.cl_plazo.ToString();
               
                this.cmb_plancta.set_PlanCtarInfo(info.IdCtaCble_cxc);
                cmb_PlanCtaAnti.set_PlanCtarInfo(info.IdCtaCble_Anti);

                cmb_PlanCta_Credito.set_PlanCtarInfo(info.IdCtaCble_cxc_Credito);

                 this.txt_cupo_asignado.Text = info.cl_Cupo.ToString();
                this.txt_razon_social.Text = info.Persona_Info.pe_razonSocial;
                
                cmbformapago.EditValue = info.FormaPago;
                this.chk_Estado.Checked = (info.Estado == "A") ? true : false;


                chk_empresa_relacionada.Checked = info.es_empresa_relacionada == null ? false : Convert.ToBoolean(info.es_empresa_relacionada);
                cmbterminopago.EditValue = info.IdTipoCredito;
                cmb_nivel_precio.EditValue = info.NivelPrecio == null ? 1 : Convert.ToInt32(info.NivelPrecio);
                listaContacto = new BindingList<fa_cliente_contactos_Info>(bus_contactos.get_list(info.IdEmpresa, info.IdCliente));
                gridControl_contatos.DataSource = listaContacto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public fa_Cliente_Info get_Cliente()
        {
            try
            {
                info = new fa_Cliente_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdCliente = (this.lbl_id_cliente.Text != "") ? Convert.ToInt32(this.lbl_id_cliente.Text) : 0;
                info.IdPersona = (this.lbl_id_persona.Text != "") ? Convert.ToDecimal(this.lbl_id_persona.Text) : 0;
                info.Codigo = this.txtCodigo.Text;
                id_persona = Convert.ToDecimal(info.IdPersona);
                info.Idtipo_cliente = this.cmbTipo.get_ClienteTipoInfo().Idtipo_cliente;
                info.cl_plazo = (this.txt_plazo.Text != "") ? Convert.ToInt32(this.txt_plazo.Text) : 0;
                if (this.cmb_plancta.get_PlanCtaInfo() != null)
                    info.IdCtaCble_cxc = cmb_plancta.get_PlanCtaInfo().IdCtaCble;
                info.IdCtaCble_Anti = cmb_PlanCtaAnti.get_PlanCtaInfo().IdCtaCble;
                
                info.cl_Cupo = (this.txt_cupo_asignado.Text != "") ? Convert.ToDouble(this.txt_cupo_asignado.Text) : 0;
                info.Persona_Info.pe_razonSocial = (this.txt_razon_social.Text != "") ? this.txt_razon_social.Text : " ";
                 
                info.IdCtaCble_cxc_Credito = cmb_PlanCta_Credito.get_PlanCtaInfo().IdCtaCble;
                info.NivelPrecio = cmb_nivel_precio.EditValue == null ? 0 : Convert.ToInt32(cmb_nivel_precio.EditValue);

                info.es_empresa_relacionada = chk_empresa_relacionada.Checked;

                info_persona = new tb_persona_Info();
                info_doc_personal = UC_Doc_per.get_TipoDoc_Personales();
                info_persona.IdPersona = id_persona;
                info_persona.pe_Naturaleza = ucGe_Natu_clie.get_Id_Naturaleza();
                info_persona.CodPersona = (id_persona != 0) ? id_persona.ToString() : "";
                info_persona.pe_apellido = (this.txt_apellidos.Text != "") ? this.txt_apellidos.Text : " ";
                info_persona.pe_nombre = (this.txt_nombres.Text != "") ? this.txt_nombres.Text : " ";
                info_persona.pe_nombreCompleto = this.txt_apellidos.Text + " " + this.txt_nombres.Text;
                info_persona.pe_razonSocial = (this.txt_razon_social.Text != "") ? this.txt_razon_social.Text : this.txt_nombres.Text + "  " + this.txt_apellidos.Text;
                info_persona.pe_fechaNacimiento = DateTime.Now;                
                 info_persona.IdTipoDocumento = info_doc_personal.codigo;
                
                info_persona.IdTipoPersona = 1;
                info_persona.pe_cedulaRuc = (this.txt_cedula.Text != "") ? this.txt_cedula.Text : " ";
                info.FormaPago = (cmbformapago.EditValue==null)?"":cmbformapago.EditValue.ToString();
                
               
                
                info_persona.pe_estado = (this.chk_Estado.Checked == true) ? "A" : "I";
                info_persona.pe_UltUsuarioModi = param.IdUsuario;
                info_persona.pe_fechaCreacion = DateTime.Now;
                info_persona.pe_fechaModificacion = DateTime.Now;

                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info.Estado = (this.chk_Estado.Checked==true )?"A":"I";
                info_persona.list_direcciones_x_persona = lista_direccion;
                info.IdTipoCredito = cmbterminopago.EditValue==null?"CON":cmbterminopago.EditValue.ToString();
                info.listaContactos = listaContacto.ToList();
                tb_Catalogo_Bus busCat = new tb_Catalogo_Bus();
                List<tb_Catalogo_Info> catalogo = new List<tb_Catalogo_Info>();


                catalogo = busCat.Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo.SEXO);
                if (catalogo.Count > 0)
                { info_persona.pe_sexo = catalogo[0].CodCatalogo; }
                else
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros del Catalogo, Falta ingresar sexo de la persona.. " +
                            "\nIngréselos desde la pantalla de Catálogo,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new fa_Cliente_Info();
                };


                catalogo = busCat.Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo.ESTCIVIL);
                if (catalogo.Count > 0)
                { info_persona.IdEstadoCivil = catalogo[0].CodCatalogo; }
                else
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros del Catalogo, Falta ingresar estado civil de la persona.. " +
                            "\nIngréselos desde la pantalla de Catálogo,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new fa_Cliente_Info();
                };


                info.Persona_Info = info_persona;




                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return info;
            }
            
        }
        
        #endregion
        public void load_combos()
        {
            try
            {
                cmb_PlanCta_Credito.cargar_PlanCta();
                cmb_PlanCtaAnti.cargar_PlanCta();
                cmb_plancta.cargar_PlanCta();
                ucGe_Sucursal_combo1.set_SucursalInfo(param.IdSucursal);
                tb_Ciudad_Bus bus_ciudad = new tb_Ciudad_Bus();
                List<tb_ciudad_Info> lst_ciudad = bus_ciudad.Get_List_Ciudad();
                cmb_ciudad.DataSource = lst_ciudad;
                tb_parroquia_Bus bus_parroquia = new tb_parroquia_Bus();
               lst_parroquia = bus_parroquia.Get_List_Parroquia();
               cmb_parroquia.DataSource = lst_parroquia;
                tb_persona_bus bus_persona = new tb_persona_bus();
                listaCliente = new List<fa_Cliente_Info>();
                listaCliente = bus_cliente.Get_List_Cliente(param.IdEmpresa);
                listaCliente = listaCliente.Where(q => q.IdCliente != 0).ToList();
                listaformapago = busFormapago.Get_List_fa_formaPago();
                cmbformapago.Properties.DataSource = listaformapago;
                listaterminoPago = busterminoPago.Get_List_TerminoPago();
                cmbterminopago.Properties.DataSource = listaterminoPago;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                        
                        this.ucGe_Sucursal_combo1.get_SucursalInfo();
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                     
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }
                this.cmb_cliente_principal.Properties.DataSource = listaCliente;
                this.cmb_cliente_principal.Properties.DisplayMember = "Nombre_Cliente";
                this.cmb_cliente_principal.Properties.ValueMember = "IdCliente";
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void enable_objetos(Boolean estado)
        {
            try
            {
              
                this.cmbTipo.Enabled = estado;
                this.UC_Doc_per.Enabled = estado;
                this.txt_cedula.ReadOnly = !estado;
                this.txt_nombres.Enabled = estado;
                this.txt_apellidos.Enabled = estado;
                this.txt_razon_social.Enabled = estado;
                this.ucGe_Sucursal_combo1.Enabled = estado;
                this.chk_Estado.Enabled = estado;
                this.cmb_plancta.Enabled = estado;
                 this.txt_plazo.Enabled = estado;
                this.txt_cupo_asignado.Enabled = estado;
                this.cmb_cliente_principal.Enabled = estado;
                cmb_PlanCtaAnti.Enabled = estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmFA_Clientes_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl_contatos.DataSource = listaContacto;
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
                load_combos();
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        this.chk_Estado.Checked = true;                        
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_Cliente_in_controls();
                        ucGe_Menu.Visible_bntAnular = false;
                        enable_objetos(true);
                        txt_cedula.ReadOnly = true;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        set_Cliente_in_controls();
                        txt_cedula.ReadOnly = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        set_Cliente_in_controls();
                        txt_cedula.ReadOnly = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        lblEstado.Visible = (info.Estado == "I") ? true : false;
                        
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean guardar(ref string MensajeError)
        {
            try
            {

                Boolean Res = false;

                if (get_Cliente() != null)
                {
                   
                   
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                           
                            if (IdCliente_Registrado == true)
                            {
                                Res = bus_cliente.ModificarDB(info, ref MensajeError);


                                listaCliente.Remove(info_tmp);
                                listaCliente.Add(info);
                            }
                            else
                            {                                
                                Res = bus_cliente.GrabarDB(info, ref id_persona, ref id_cliente, ref MensajeError);
                               
                            }

                            this.lbl_id_cliente.Text = id_cliente.ToString();
                            this.lbl_id_persona.Text = id_persona.ToString();

                            if (!Res)
                                MessageBox.Show("Error: " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Cliente", info.IdCliente);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                txt_cedula.ReadOnly = true;
                                LimpiarDatos();
                            }
                           
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:

                            Res = bus_cliente.ModificarDB(info, ref MensajeError);

                          
                            if (!Res)
                                MessageBox.Show("Error: " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Cliente", info.IdCliente);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                LimpiarDatos();
                            }
                            break;         
                    }
                }

                return Res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MensajeError = ex.Message;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
        }

        private Boolean Anular()
        {
            try
            {
                Boolean resultB = false;
                string mensaje = "";
                if (lblEstado.Visible == true)
                {
                    MessageBox.Show("No se puede Anular Debido a que ya se encuentra Anulado");
                }
                else
                {

                    if (MessageBox.Show("¿Está seguro que desea anular el Cliente: " + "[" + info.IdCliente + "] -" + info.Persona_Info.pe_nombre + " " + info.Persona_Info.pe_apellido + " ?", "Anulación de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (info.Estado == "A")
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();


                            get_Cliente();
                            info.IdUsuarioUltAnu = param.IdUsuario;
                            info.Fecha_UltAnu = DateTime.Now;
                            info.MotivoAnulacion = ofrm.motivoAnulacion;

                            if (bus_cliente.EliminarDB(info, ref mensaje))
                            {                                
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Cliente", info.IdCliente);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                ucGe_Menu.Visible_bntAnular = false;
                                lblEstado.Visible = true;
                                resultB = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo anular el Cliente: " + info.Nombre_Cliente + " Se encuentra Anulado", "Anulación de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultB = false;
                        }
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean validaciones()
        {
            try
            {

                if (cmbformapago.EditValue == null)
                {
                    MessageBox.Show("Seleccione la forma de pago", "Fixed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (!ValidarCedula())
                    {
                        return false;
                    }
                }
                info_doc_personal = UC_Doc_per.get_TipoDoc_Personales();
                if (info_doc_personal.codigo == "RUC")
                {
                    if (txt_razon_social.Text == "" || txt_razon_social.Text == null)
                    {
                        MessageBox.Show("Digite la Razon Social del Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_razon_social.Focus();
                        return false;
                    }
                }
                else 
                {
                    if (txt_nombres.EditValue == "" || txt_nombres.EditValue == null)
                    {
                        MessageBox.Show("Digite el Nombre del Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_nombres.Focus();
                        return false;
                    }

                    if (txt_apellidos.EditValue == "" || txt_apellidos.EditValue == null)
                    {
                        MessageBox.Show("Digite el Apellido del Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_apellidos.Focus();
                        return false;
                    }                    
                }

                if (ucGe_Sucursal_combo1.get_SucursalInfo() == null )
                {
                    MessageBox.Show("Seleccione la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_Sucursal_combo1.cmbsucursal.Focus();
                    return false;
                }
                
                if (cmbTipo.get_ClienteTipoInfo() == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipo.cmbClienteTipo.Focus();
                    return false;
                }

                if (cmb_plancta.get_PlanCtaInfo() == null || cmb_plancta.get_PlanCtaInfo().IdCtaCble == "")
                {
                    MessageBox.Show("Seleccione la Cuenta Contable CXC", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_plancta.cmbPlanCta.Focus();
                    return false;
                }

                if (cmb_PlanCtaAnti.get_PlanCtaInfo() == null || cmb_PlanCtaAnti.get_PlanCtaInfo().IdCtaCble == "")
                {
                    MessageBox.Show("Seleccione la Cuenta Contable de Anticipos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_PlanCtaAnti.cmbPlanCta.Focus();
                    return false;
                }

                if (cmb_PlanCta_Credito.get_PlanCtaInfo() == null || cmb_PlanCta_Credito.get_PlanCtaInfo().IdCtaCble == "")
                {
                    MessageBox.Show("Seleccione la Cuenta Contable de Credito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_PlanCtaAnti.cmbPlanCta.Focus();
                    return false;
                }

                if (listaContacto.Count  == 0)
                {
                    MessageBox.Show("Ingrese los datos del cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                foreach (var item in listaContacto)
                {                    
                    if (string.IsNullOrEmpty(item.IdCiudad))
                    {
                        MessageBox.Show("Ingrese la ciudad del cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;    
                    }
                    if (string.IsNullOrEmpty(item.IdParroquia))
                    {
                        MessageBox.Show("Ingrese la parroquia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;    
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
        }

        Boolean ValidarCedula() 
        {
            try
            {
                info_doc_personal = UC_Doc_per.get_TipoDoc_Personales();
                tb_persona_bus tbPersona = new tb_persona_bus();
                string msj = "";

                if (info_doc_personal.codigo == "CED")
                {
                    if (txt_cedula.Text != "")
                    {
                        if (txt_cedula.Text.TrimStart().TrimEnd().Count() != 10)
                        {
                            MessageBox.Show("Cedula Incorrecta");
                            return false;
                        }

                        if (!tbPersona.Verifica_Ruc(txt_cedula.Text, ref msj))
                        {
                            MessageBox.Show(msj);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite la Cedula");
                        return false;
                    }

                }
                else if (info_doc_personal.codigo == "RUC")
                {

                    if (txt_cedula.Text != "")
                    {
                        if (txt_cedula.Text.Substring(10, 3) != "001")
                        {
                            MessageBox.Show("RUC Incorrecto");
                            return false;
                        }
                        if (txt_cedula.Text.TrimStart().TrimEnd().Count() != 13)
                        {


                            MessageBox.Show("RUC Incorrecto");
                            return false;
                        }
                        if (!tbPersona.Verifica_Ruc(txt_cedula.Text, ref msj))
                        {
                            MessageBox.Show(msj);
                        }
                    }
                    else {
                        MessageBox.Show("Digite el Cedula");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }      

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_plazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txt_plazo.Text).Length > 5)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        private void txt_cupo_asignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar, this.txt_cupo_asignado.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cupo_asignado_Leave(object sender, EventArgs e)
        {
            try
            {
                Funciones f = new Funciones();
                txt_cupo_asignado.Text = f.Format_text_2_decimales(txt_cupo_asignado.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
               
        private void txt_cedula_Enter(object sender, EventArgs e)
        {
            try
            {                
                    if (UC_Doc_per.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                    {
                        txt_cedula.MaxLength = 10;
                        if (txt_cedula.Text != "")
                            txt_cedula.Text = txt_cedula.Text.Length > 10 ? txt_cedula.Text.Substring(0, 10) : txt_cedula.Text;
                    }
                    if (UC_Doc_per.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                    {
                        txt_cedula.MaxLength = 13;
                        if (txt_cedula.Text != "")
                        {
                            if (txt_cedula.Text.Length > 13)
                            txt_cedula.Text = txt_cedula.Text.Substring(0, 13) ;
                            else
                            {
                                if (txt_cedula.Text.Length == 10)
                                {
                                    txt_cedula.Text = txt_cedula.Text.ToString().PadRight(12, '0')+"1";

                                }
                            }
                           
                        }
                    }
                    if (UC_Doc_per.cmb_Docum_perso.SelectedValue.ToString() == "PAS")
                    {
                        txt_cedula.MaxLength = 20;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmFA_Clientes_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                   event_frmFA_Clientes_Mant_FormClosing();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void txt_cedula_Leave(object sender, EventArgs e)
        {
            try
            {                
               
                tb_persona_Info select = bus_persona.Get_Info_Persona(txt_cedula.Text.TrimStart().TrimEnd());
                if (select != null && select.IdPersona != 0)
                {
                    id_persona = select.IdPersona;

                    fa_Cliente_Info select_id = bus_cliente.Get_info_Cliente_x_IdPersona(param.IdEmpresa, id_persona);

                    if (select_id != null && select_id.IdCliente != 0)
                    {

                        IdCliente_Registrado = true;
                        MessageBox.Show("Cliente ya existe en la Base de Datos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        fa_Cliente_Info tmp = new fa_Cliente_Info();
                        tmp = select_id;
                        info_tmp = new fa_Cliente_Info();
                        info_tmp = select_id;
                        set_Cliente(bus_cliente.Get_Info_Cliente(tmp.IdEmpresa, tmp.IdCliente));
                        set_Cliente_in_controls();

                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            {
                                ucGe_Menu.Visible_btnGuardar = true;;
                                txt_cedula.ReadOnly = true;
                            }
                        }
                    }
                    else
                    {
                        IdCliente_Registrado = false;
                    }

                    
                        this.lbl_id_persona.Text = Convert.ToString(select.IdPersona);
                        id_persona = select.IdPersona;
                        this.txt_nombres.Text = Convert.ToString(select.pe_nombre);
                        this.txt_apellidos.Text = Convert.ToString(select.pe_apellido);
                        this.chk_Estado.Checked = (select.pe_estado == "A") ? true : false;
                        this.txt_razon_social.Text = Convert.ToString(select.pe_razonSocial);                   
                }
                else
                {
                    id_persona = 0;
                    this.txt_nombres.Focus();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmb_actividad_economica_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {

                    if (txt_nombres.Text.Length >100)
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {

                    if (txt_apellidos.Text.Length > 100)
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_telefono_ofic_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_casilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cupo_asignado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_plazo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_celular_rep_legal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_celular_gerente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_celular_garante_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarDatos()
        {
            try
            {
                info = new fa_Cliente_Info();
                info.Persona_Info = new tb_persona_Info();
                info_persona = new tb_persona_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                this.lbl_id_cliente.Text = "";
                this.lbl_id_persona.Text = "";
                id_persona = 0;                
                this.txt_plazo.Text = "";
                this.txt_cupo_asignado.Text = "";
                this.txt_razon_social.Text = "";     
               
                this.txt_apellidos.Text = "";
                this.txt_nombres.Text = "";
                this.txt_razon_social.Text = "";

                cmb_nivel_precio.EditValue = "1";
                 this.txt_cedula.Text = "";
                this.chk_Estado.Checked = true;
                
           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txt_cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucFa_VendedorCmb1_Load(object sender, EventArgs e)
        {

        }

        private void tabPageInfoGeneral_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_actividad_economica_Load(object sender, EventArgs e)
        {

        }

        private void gridView_contactos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_cliente_contactos_Info row = (fa_cliente_contactos_Info)gridView_contactos.GetRow(e.RowHandle);
                if (row == null)
                    return;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_contactos_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            if (view.FocusedColumn.FieldName == "IdParroquia" && view.ActiveEditor is LookUpEdit)
            {
                LookUpEdit edit = (LookUpEdit)view.ActiveEditor;
                string IdCiudad = (string)view.GetFocusedRowCellValue("IdCiudad");                
                edit.Properties.DataSource = lst_parroquia.Where(q=>q.IdCiudad_Canton == IdCiudad).ToList();
                edit.Properties.ValueMember = "IdParroquia";
                edit.Properties.DisplayMember = "nom_parroquia";
                edit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo
                {
                    FieldName = "nom_parroquia",
                    Caption = "Parroquia"
                });
            }
        }

        private void btn_agregar_contacto_Click(object sender, EventArgs e)
        {
            int IdContacto = listaContacto.Count == 0 ? 1 : listaContacto.Max(q => q.IdContacto) + 1;

            listaContacto.Add(
                new fa_cliente_contactos_Info
                {
                    IdContacto = IdContacto,
                    IdCiudad = "09",
                    IdParroquia = "09",
                    Nombres = txt_razon_social.Text
                });
            gridControl_contatos.RefreshDataSource();
        }
    }
}
