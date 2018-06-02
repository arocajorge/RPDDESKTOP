using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Inventario_CG;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Inventario_CG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario_CG
{
    public partial class FrmIn_Categoria_CG_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        in_categorias_Info info_Cat = new in_categorias_Info();
        in_categorias_Info infoCatPadre = new in_categorias_Info();
        in_categorias_bus Bus_Cat = new in_categorias_bus();
        in_Parametro_Bus bus = new in_Parametro_Bus();
        in_categoria_CG_Bus Bus_CategoriaCG = new in_categoria_CG_Bus();

        public delegate void DelegadoRefrescar();
        public event DelegadoRefrescar ReloadGrid;
        string idCategoria = string.Empty;
        string mensaje = string.Empty;
        #endregion

        public FrmIn_Categoria_CG_Mant()
        {
            InitializeComponent();
            ReloadGrid += FrmIn_Categoria_CG_Mant_ReloadGrid;
        }

        void FrmIn_Categoria_CG_Mant_ReloadGrid()
        {
           
        }
        
        

        #region Set
        public void set_Accion(Cl_Enumeradores.eTipo_action _iAccion)
        {
            try
            {
                Accion = _iAccion;
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

        private void Set_Accion_in_Controls()
        {
            try
            {
                 switch (Accion)
                {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Visible_bntAnular = false;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Visible_bntAnular = false;
                    Set_Info_in_Controls();
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                         Set_Info_in_Controls();
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;

                    ucGe_Menu.Visible_bntAnular = false;
                    txt_nombre.Enabled = false;
                    txt_nombre.BackColor = System.Drawing.Color.White;
                    txt_nombre.ForeColor = System.Drawing.Color.Black;

                    txt_posicion.Enabled = false;
                    txt_posicion.BackColor = System.Drawing.Color.White;
                    txt_posicion.ForeColor = System.Drawing.Color.Black;
                    

                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                         Set_Info_in_Controls();
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;

                    txt_nombre.Enabled = false;
                    txt_nombre.BackColor = System.Drawing.Color.White;
                    txt_nombre.ForeColor = System.Drawing.Color.Black;

                    txt_posicion.Enabled = false;
                    txt_posicion.BackColor = System.Drawing.Color.White;
                    txt_posicion.ForeColor = System.Drawing.Color.Black;

                    //chk_estado.Enabled = false;
                    //chk_estado.BackColor = System.Drawing.Color.White;
                    //chk_estado.ForeColor = System.Drawing.Color.Black;

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


        public void set_categoriaPadre(in_categorias_Info _Info)
        {
            try
            {
                infoCatPadre = _Info;
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


        public void set_categoria(in_categorias_Info _categoriaInfo)
        {
            try
            {
                info_Cat = _categoriaInfo;

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
                idCategoria = info_Cat.IdCategoria;
                txt_nombre.Text = info_Cat.ca_Categoria;
                txt_posicion.Value = info_Cat.ca_Posicion;
                info_Cat.categoria_CG_Info = Bus_CategoriaCG.Get_Info(param.IdEmpresa, info_Cat.IdCategoria);
                if (info_Cat.categoria_CG_Info.IdCategoria != null)
                {
                    chkes_formulacion.Checked = (bool)info_Cat.categoria_CG_Info.sw_formulacion;
                    chkes_insumo.Checked = (bool)info_Cat.categoria_CG_Info.sw_insumos;
                    chkse_vende.Checked = (bool)info_Cat.categoria_CG_Info.sw_vende;
                    chkes_medicamento.Checked = (bool)info_Cat.categoria_CG_Info.sw_medicamento;
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

        #region Get
        private void Get_Info(ref string msj)
        {
            try
            {
                info_Cat = new in_categorias_Info();
                info_Cat.IdEmpresa = param.IdEmpresa;
                info_Cat.IdCategoria = (info_Cat.IdCategoria == null ) ? idCategoria : info_Cat.IdCategoria;
                if (infoCatPadre != null)
                {
                    info_Cat.IdCategoriaPadre = infoCatPadre.IdCategoria;
                    info_Cat.ca_nivel = infoCatPadre.ca_nivel + 1;
                }
                else
                {
                    info_Cat.ca_nivel = 1;
                }
                if (info_Cat.ca_nivel == 1)
                {
                    info_Cat.RutaPadre = "";
                }
                else
                {
                    info_Cat.RutaPadre = infoCatPadre.RutaPadre + @"\" + infoCatPadre.ca_Categoria;
                }
                info_Cat.ca_indexIcono = info_Cat.ca_nivel;
                info_Cat.ca_Categoria = txt_nombre.Text.Trim();
                info_Cat.ca_Posicion = Convert.ToInt32(txt_posicion.Value);
                info_Cat.ip = param.ip;
                info_Cat.nom_pc = param.nom_pc;

                info_Cat.categoria_CG_Info.IdEmpresa = param.IdEmpresa;
                info_Cat.categoria_CG_Info.IdCategoria = info_Cat.IdCategoria;
                info_Cat.categoria_CG_Info.sw_formulacion = chkes_formulacion.Checked;
                info_Cat.categoria_CG_Info.sw_insumos = chkes_insumo.Checked;
                info_Cat.categoria_CG_Info.sw_medicamento = chkes_medicamento.Checked;
                info_Cat.categoria_CG_Info.sw_vende = chkse_vende.Checked;
                info_Cat.categoria_CG_Info.ip = param.ip;
                info_Cat.categoria_CG_Info.nom_pc = param.nom_pc;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = mensaje= NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region funciones
        private void Limpiar()
        {
            try
            {
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                txt_nombre.Text = "";
                txt_posicion.ResetText();
                chkes_formulacion.Checked = false;
                chkes_insumo.Checked = false;
                chkes_medicamento.Checked = false;
                chkse_vende.Checked = false;
                idCategoria = string.Empty;
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


        private Boolean validaciones()
        {
            try
            {
                Boolean res = true;

                if (txt_nombre.Text == string.Empty)
                {
                    MessageBox.Show("Debe Ingresar el nombre de la categoría", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_nombre.Focus();
                    res = false;
                }
                return res;
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

        
        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;
                if (validaciones())
                {
                    Get_Info(ref mensaje);
                    if (mensaje != "")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; 
                    }
                    else
                    {
                        switch (Accion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:
                                respuesta = GuardarBD();
                                break;

                            case Cl_Enumeradores.eTipo_action.actualizar:
                                respuesta = ModificarDB();
                                break;
                            case Cl_Enumeradores.eTipo_action.Anular:
                                respuesta = AnularDB();
                                break;
                        }
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

        private bool AnularDB()
        {
            try
            {
                bool res = false;
                info_Cat.IdUsuarioUltAnu = param.IdUsuario;
                Core.Erp.Winform.General.FrmGe_MotivoAnulacion ofrm = new General.FrmGe_MotivoAnulacion();
                ofrm.ShowDialog();
                info_Cat.MotiAnula = ofrm.motivoAnulacion;

                if (Bus_Cat.AnularDB(info_Cat, ref mensaje))
                {
                    info_Cat.categoria_CG_Info.IdUsuarioUltAnu = param.IdUsuario;
                    info_Cat.categoria_CG_Info.MotiAnula = ofrm.motivoAnulacion;
                   
                    res = Bus_CategoriaCG.AnularDB(info_Cat.categoria_CG_Info, ref mensaje);
                    if(res)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " la categoría "+ info_Cat.IdCategoria, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + " " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + " " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return res;
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
        private bool GuardarBD()
        {
            try
            {
                string msg = string.Empty;
                    bool res = false;
                    info_Cat.IdUsuario = param.IdUsuario;
                            if (Bus_Cat.GrabarDB(param.IdEmpresa, info_Cat, ref msg))
                            {
                                info_Cat.categoria_CG_Info.IdCategoria = info_Cat.IdCategoria; ;
                                info_Cat.categoria_CG_Info.IdUsuario = param.IdUsuario;
                                res = Bus_CategoriaCG.GrabarDB(info_Cat.categoria_CG_Info, ref mensaje);
                                if (res)
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la categoría " + info_Cat.IdCategoria, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                                else
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + " " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);  
                            }
                            else
                            {
                               MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + " " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                         return res;
                            
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

        private bool ModificarDB()
        {
            try
            {
                string msg = "";
                bool res = false;
                info_Cat.IdUsuarioUltMod = param.IdUsuario;
                if (Bus_Cat.ModificarDB(param.IdEmpresa, info_Cat, ref msg))
                {
                    info_Cat.categoria_CG_Info.IdUsuarioUltMod = param.IdUsuario;
                    res = Bus_CategoriaCG.ActualizarDB(info_Cat.categoria_CG_Info, ref mensaje);
                    if (res)
                    {
                      MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la categoría " + info_Cat.IdCategoria, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                      Limpiar();
                    }
                    else
                     MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + " " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + " " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return res;
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
        #endregion

        #region Eventos
        private void FrmIn_Categoria_CG_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                var info = bus.Get_Info_Parametro(param.IdEmpresa);
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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                    Close();
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                    Close();
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

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
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

    

        private void FrmIn_Categoria_CG_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ReloadGrid();
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
