using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad_Fj;
using Core.Erp.Business.Contabilidad_Fj;

namespace Core.Erp.Winform.Contabilidad_FJ
{
    public partial class frmCon_distribucion_gastos_x_punto_cargo_mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();

        
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        BindingList<ct_distribucion_gastos_x_periodo_det_Info> blst_gastos = new BindingList<ct_distribucion_gastos_x_periodo_det_Info>();
        BindingList<ct_distribucion_gastos_x_periodo_det_Info> blst_det = new BindingList<ct_distribucion_gastos_x_periodo_det_Info>();
        BindingList<ct_punto_cargo_Info> blst_punto_cargo = new BindingList<ct_punto_cargo_Info>();
        ct_distribucion_gastos_x_periodo_Bus bus_distribucion = new ct_distribucion_gastos_x_periodo_Bus();
        ct_distribucion_gastos_x_periodo_Info info_distribucion = new ct_distribucion_gastos_x_periodo_Info();
        ct_distribucion_gastos_x_periodo_det_Bus bus_distribucion_det = new ct_distribucion_gastos_x_periodo_det_Bus();
        #endregion

        #region Delegados
        public delegate void delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed;
        #endregion

        public frmCon_distribucion_gastos_x_punto_cargo_mant()
        {
            InitializeComponent();
            event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed += frmCon_distribucion_gastos_x_punto_cargo_mant_event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed;
        }

        void frmCon_distribucion_gastos_x_punto_cargo_mant_event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        set_info_in_controls();
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

        public void set_info(ct_distribucion_gastos_x_periodo_Info _info)
        {
            try
            {
                info_distribucion = _info;
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

        private void set_info_in_controls()
        {
            try
            {
                txt_IdDistribucion.Text = info_distribucion.IdDistribucion.ToString();
                de_fecha.EditValue = info_distribucion.Fecha;
                txt_observacion.Text = info_distribucion.Observacion;
                ucCon_Periodo1.Set_Periodo(info_distribucion.IdPeriodo);

                info_distribucion.lst_det = bus_distribucion_det.get_list(info_distribucion.IdEmpresa, info_distribucion.IdDistribucion);
                blst_det = new BindingList<ct_distribucion_gastos_x_periodo_det_Info>(info_distribucion.lst_det);
                gridControl_distribucion.DataSource = blst_det;
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
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

        private void buscar()
        {
            try
            {
                if (ucCon_Periodo1.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Seleccione el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                blst_gastos = new BindingList<ct_distribucion_gastos_x_periodo_det_Info>(bus_distribucion_det.get_list(param.IdEmpresa, ucCon_Periodo1.Get_Periodo_Info().IdPeriodo));
                gridControl_saldo_cuentas.DataSource = blst_gastos;
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

        private bool Validar()
        {
            try
            {
                txt_IdDistribucion.Focus();

                if (de_fecha.EditValue == null)
                {
                    MessageBox.Show("Ingrese la fecha",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucCon_Periodo1.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Seleccione el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
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

        private void limpiar()
        {
            try
            {
                txt_IdDistribucion.Text = "";
                de_fecha.EditValue = null;
                txt_observacion.Text = null;
                ucCon_Periodo1.Set_Periodo(0);
                blst_gastos = new BindingList<ct_distribucion_gastos_x_periodo_det_Info>();
                gridControl_saldo_cuentas.DataSource = blst_gastos;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                Cargar_combo();
                set_accion_in_controls();
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

        private void frmCon_distribucion_gastos_x_punto_cargo_Load(object sender, EventArgs e)
        {
            try
            {
                de_fecha.EditValue = DateTime.Now.Date;
                Cargar_combo();
                set_accion_in_controls();
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

        private void Cargar_combo()
        {
            try
            {
                ucCon_Periodo1.Cargar_combos();
                List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
                lst_punto_cargo = bus_punto_cargo.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                blst_punto_cargo = new BindingList<ct_punto_cargo_Info>(lst_punto_cargo);
                gridControl_punto_cargo.DataSource = blst_punto_cargo;
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

        private void frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed(sender, e);
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

        private void get_info()
        {
            try
            {
                info_distribucion.IdEmpresa = param.IdEmpresa;
                info_distribucion.IdDistribucion = txt_IdDistribucion.Text == "" ? 0 : Convert.ToDecimal(txt_IdDistribucion.Text);
                info_distribucion.IdPeriodo = ucCon_Periodo1.Get_Periodo_Info().IdPeriodo;
                info_distribucion.Fecha = Convert.ToDateTime(de_fecha.EditValue).Date;
                info_distribucion.Observacion = txt_observacion.Text;                
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

        private void gridView_punto_cargo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                ct_punto_cargo_Info row_pc = new ct_punto_cargo_Info();
                row_pc = (ct_punto_cargo_Info)gridView_punto_cargo.GetRow(e.RowHandle);
                
                if (row_pc == null)
                    return;
                if (e.Column == col_check_pc)
                {
                    calcular_porcentaje();
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

        private void calcular_porcentaje()
        {
            try
            {
                double contador_check = blst_punto_cargo.Where(q => q.Checked == true).Count();
                if (contador_check != 0)
                {
                    double valor = Math.Round(Convert.ToDouble((100 / contador_check)),2,MidpointRounding.AwayFromZero);
                    foreach (var item in blst_punto_cargo)
                    {
                        if (item.Checked)
                            item.porcentaje = valor;
                        else
                            item.porcentaje = 0;                        
                    }
                    gridControl_punto_cargo.RefreshDataSource();
                }else
                    foreach (var item_2 in blst_punto_cargo)
                    {
                        item_2.porcentaje = 0;
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

        private void gridView_punto_cargo_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_check_pc)
                {
                    gridView_punto_cargo.SetRowCellValue(e.RowHandle, e.Column, e.Value);
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_grabar())
                {
                    
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_grabar())
                {
                    this.Close();
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

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_grabar())
                {
                    this.Close();
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

        private bool Accion_grabar()
        {
            try
            {
                bool res = false;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = GuardarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = ModificarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        res = AnularDB();
                        break;
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

        private bool GuardarDB()
        {
            try
            {
                if (!Validar())
                    return false;

                get_info();

                if (bus_distribucion.GuardarDB(info_distribucion))
                {
                    txt_IdDistribucion.Text = info_distribucion.IdDistribucion.ToString();
                    
                    MessageBox.Show("Registro guardado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
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
                if (!Validar())
                    return false;

                get_info();

                if (bus_distribucion.ModificarDB(info_distribucion))
                {
                    MessageBox.Show("Registro modificado exitosamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
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
                if (bus_distribucion.AnularDB(info_distribucion.IdEmpresa, info_distribucion.IdDistribucion))
                {
                    MessageBox.Show("Registro anulado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
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

        private void btn_imprimir_saldo_cuentas_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl_saldo_cuentas.ShowPrintPreview();
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

        private void btn_distribuir_Click(object sender, EventArgs e)
        {
            try
            {
                if (distribuir())
                    MessageBox.Show("Distribución exitosa",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

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

        private bool distribuir()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();

                if (txt_IdDistribucion.Text == "")
                {
                    get_info();
                    if (!GuardarDB())
                        return false;                    
                }

                foreach (var cuenta in blst_gastos.Where(q => q.Checked == true).ToList())
                {
                    cuenta.valor_aux = Math.Abs(cuenta.valor);
                    int contador = blst_punto_cargo.Where(q => q.Checked == true).Count();
                    int cont = 1;
                    foreach (var punto_cargo in blst_punto_cargo.Where(q => q.Checked == true).ToList())
                    {
                        ct_distribucion_gastos_x_periodo_det_Info new_det = new ct_distribucion_gastos_x_periodo_det_Info();
                        new_det.IdEmpresa = param.IdEmpresa;
                        new_det.IdDistribucion = info_distribucion.IdDistribucion;
                        new_det.IdCtaCble = cuenta.IdCtaCble;
                        new_det.IdPunto_cargo = punto_cargo.IdPunto_cargo;

                        if (Math.Abs((cuenta.valor * (punto_cargo.porcentaje / 100))) < 3)
                        {
                            new_det.valor = cuenta.valor;
                            cuenta.valor_aux = 0;                            
                        }
                        else
                        {
                            if (cont == contador)
                            {
                                new_det.valor = cuenta.valor < 0 ? cuenta.valor_aux * -1 : cuenta.valor_aux;
                                cuenta.valor_aux = 0;
                            }
                            else
                            {
                                new_det.valor = Math.Round(cuenta.valor * (punto_cargo.porcentaje / 100), 2, MidpointRounding.AwayFromZero);
                                cuenta.valor_aux = Math.Abs(cuenta.valor_aux) < Math.Abs(new_det.valor) ? 0 : Math.Abs(cuenta.valor_aux) - Math.Abs(new_det.valor);
                            }
                        }
                        bus_distribucion_det.guardarDB(new_det);
                        cont++;
                        if (cuenta.valor_aux == 0)
                            break;
                    }
                }

                Accion = Cl_Enumeradores.eTipo_action.actualizar;

                buscar();
                Cargar_combo();
                set_info_in_controls();

                splashScreenManager1.CloseWaitForm();

                return true;
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void chk_seleccionar_visibles_cuenta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_saldo_cuentas.RowCount; i++)
                {
                    gridView_saldo_cuentas.SetRowCellValue(i, col_check_cuenta, chk_seleccionar_visibles_cuenta.Checked);
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

        private void chk_seleccionar_visibles_punto_cargo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_punto_cargo.RowCount; i++)
                {
                    gridView_punto_cargo.SetRowCellValue(i, col_check_pc, chk_seleccionar_visibles_punto_cargo.Checked);
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

        private void gridView_distribucion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ct_distribucion_gastos_x_periodo_det_Info row = (ct_distribucion_gastos_x_periodo_det_Info)gridView_distribucion.GetFocusedRow();
                        bus_distribucion_det.eliminarDB(row.IdEmpresa, row.IdDistribucion, row.Secuencia);
                        gridView_distribucion.DeleteSelectedRows();
                    }
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
    }
}
