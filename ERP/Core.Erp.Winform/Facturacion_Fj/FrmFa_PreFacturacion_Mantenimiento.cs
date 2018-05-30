using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using System.Linq;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Facturacion;
using Cus.Erp.Reports.FJ.Facturacion;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_PreFacturacion_Mantenimiento : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_pre_facturacion_Bus bus_prefacturacion = new fa_pre_facturacion_Bus();
        fa_pre_facturacion_Info info_prefacturacion = new fa_pre_facturacion_Info();
        List<ct_Centro_costo_Info> lst_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();
        BindingList<fa_pre_facturacion_det_Info> blst_det = new BindingList<fa_pre_facturacion_det_Info>();
        fa_pre_facturacion_det_Bus bus_det = new fa_pre_facturacion_det_Bus();
        Dictionary<int, string> colorEnums;
        List<tb_sis_impuesto_Info> lst_impuesto = new List<tb_sis_impuesto_Info>();
        tb_sis_impuesto_Bus bus_impuesto = new tb_sis_impuesto_Bus();
        Cl_Enumeradores.eProceso_prefactura proceso;
        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Bus bus_tarifario_x_cliente = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Bus();
        BindingList<fa_pre_facturacion_activos_Info> blst_activos = new BindingList<fa_pre_facturacion_activos_Info>();
        fa_pre_facturacion_activos_Bus bus_activos = new fa_pre_facturacion_activos_Bus();
        BindingList<fa_pre_facturacion_det_otros_Info> blst_otros = new BindingList<fa_pre_facturacion_det_otros_Info>();
        fa_pre_facturacion_det_otros_Bus bus_otros = new fa_pre_facturacion_det_otros_Bus();
        #endregion

        #region Delagados
        public delegate void delegate_frmFa_PreFacturacion_Mantenimiento_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmFa_PreFacturacion_Mantenimiento_FormClosed event_delegate_frmFa_PreFacturacion_Mantenimiento_FormClosed;
        #endregion

        public frmFa_PreFacturacion_Mantenimiento()
        {
            InitializeComponent();
            event_delegate_frmFa_PreFacturacion_Mantenimiento_FormClosed += frmFa_PreFacturacion_Mantenimiento_event_delegate_frmFa_PreFacturacion_Mantenimiento_FormClosed;
        }

        void frmFa_PreFacturacion_Mantenimiento_event_delegate_frmFa_PreFacturacion_Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmFa_PreFacturacion_Mantenimiento_Load(object sender, EventArgs e)
        {
            set_accion_in_controls();
        }

        public void set_info(fa_pre_facturacion_Info _info)
        {
            try
            {
                info_prefacturacion = _info;
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
                txt_IdPreFacturacion.Text = info_prefacturacion.IdPreFacturacion.ToString();
                txt_Observacion.Text = info_prefacturacion.Observacion;
                ucCon_Periodo1.Set_Periodo(info_prefacturacion.IdPeriodo);
                de_Fecha.EditValue = info_prefacturacion.fecha;
                chk_estado_cierre.Checked = info_prefacturacion.estado_cierre;
                cmb_centro_costo.EditValue = info_prefacturacion.IdCentroCosto;
                txtvalorafacturar.EditValue = info_prefacturacion.ValorFacturar;
                txttotalequipos.EditValue = info_prefacturacion.TotalEquipos;
                if (info_prefacturacion.estado == "I")
                    lblAnulado.Visible = true;

                blst_det = new BindingList<fa_pre_facturacion_det_Info>(bus_det.get_list(info_prefacturacion.IdEmpresa, info_prefacturacion.IdPreFacturacion));
                gridControl_prefacturacion.DataSource = blst_det;
                blst_activos = new BindingList<fa_pre_facturacion_activos_Info>(bus_activos.get_list(param.IdEmpresa, info_prefacturacion.IdPreFacturacion));
                gridControl_activos.DataSource = blst_activos;
                blst_otros = new BindingList<fa_pre_facturacion_det_otros_Info>(bus_otros.get_list(param.IdEmpresa, info_prefacturacion.IdPreFacturacion));
                gridControl_otros.DataSource = blst_otros;

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

        private void limpiar()
        {
            try
            {
                txt_IdPreFacturacion.Text = "";
                txt_Observacion.Text = "";
                ucCon_Periodo1.Set_Periodo(info_prefacturacion.IdPeriodo);
                de_Fecha.EditValue = DateTime.Now.Date;
                chk_estado_cierre.Checked = false;
                cmb_centro_costo.EditValue = null;
                lblAnulado.Visible = false;

                Accion = Cl_Enumeradores.eTipo_action.grabar;
                info_prefacturacion = new fa_pre_facturacion_Info();
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
                cargar_combos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.btnGuardar.Visible = true;
                        ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = true;
                        cmb_centro_costo.Properties.ReadOnly = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_info_in_controls();
                        ucGe_Menu_Superior_Mant1.btnGuardar.Visible = true;
                        ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = true;
                        cmb_centro_costo.Properties.ReadOnly = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.btnGuardar.Visible = false;
                        ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = false;
                        set_info_in_controls();
                        cmb_centro_costo.Properties.ReadOnly = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.btnGuardar.Visible = false;
                        ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = false;
                        set_info_in_controls();
                        cmb_centro_costo.Properties.ReadOnly = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucCon_Periodo1.ReadOnly_cmb_Periodo = true;
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

        private void cargar_combos()
        {
            try
            {
                de_Fecha.DateTime = DateTime.Now.Date;

                string MensajeError = "";
                lst_centro_costo = bus_centro_costo.Get_list_Centro_Costo_x_cliente(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo.Properties.DataSource = lst_centro_costo;

                ucCon_Periodo1.Cargar_combos();

                colorEnums = Enum.GetValues(typeof(Cl_Enumeradores.eProceso_prefactura)).
                    Cast<Cl_Enumeradores.eProceso_prefactura>().ToDictionary(x => (int)x, x => x.ToString());
                cmb_proceso.Properties.DataSource = colorEnums.ToList();
                cmb_proceso_grid.DataSource = colorEnums.ToList();
                List<fa_grupo_x_sub_centro_costo_Info> lst_grupo = new List<fa_grupo_x_sub_centro_costo_Info>();
                fa_grupo_x_sub_centro_costo_Bus bus_grupo = new fa_grupo_x_sub_centro_costo_Bus();
                lst_grupo = bus_grupo.Get_List_Grup_Sub(param.IdEmpresa);
                cmb_grupo.DataSource = lst_grupo;
                cmb_grupo_act.DataSource = lst_grupo;

                List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
                in_producto_Bus bus_producto = new in_producto_Bus();
                lst_producto = bus_producto.Get_list_Producto_modulo_x_Ventas(param.IdEmpresa);
                cmb_producto.DataSource = lst_producto;

                lst_impuesto = bus_impuesto.Get_List_impuesto("IVA");
                cmb_impuesto.DataSource = lst_impuesto;

                ucIn_Sucursal_Bodega1.set_Idsucursal(param.IdSucursal);
                List<Af_Activo_fijo_Info> lst_activo_fijo = new List<Af_Activo_fijo_Info>();
                Af_Activo_fijo_Bus bus_activo_fijo = new Af_Activo_fijo_Bus();
                lst_activo_fijo = bus_activo_fijo.Get_List_ActivoFijo(param.IdEmpresa);
                cmb_activo_act.DataSource = lst_activo_fijo;
                cmb_act_otros.DataSource = lst_activo_fijo;
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
                info_prefacturacion.IdEmpresa = param.IdEmpresa;
                info_prefacturacion.IdCentroCosto = cmb_centro_costo.EditValue.ToString();
                info_prefacturacion.IdPeriodo = ucCon_Periodo1.Get_Periodo_Info().IdPeriodo;
                info_prefacturacion.Observacion = txt_Observacion.Text;
                info_prefacturacion.fecha = de_Fecha.DateTime.Date;
                info_prefacturacion.estado_cierre = chk_estado_cierre.Checked;
                info_prefacturacion.TotalEquipos = (txttotalequipos.EditValue == null) ? 0 : Convert.ToInt32(txttotalequipos.EditValue);
                info_prefacturacion.ValorFacturar = (txtvalorafacturar.EditValue == null) ? 0 : Convert.ToDouble(txtvalorafacturar.EditValue);
                info_prefacturacion.lst_det = new List<fa_pre_facturacion_det_Info>(blst_det);
                info_prefacturacion.lst_det_act = new List<fa_pre_facturacion_activos_Info>(blst_activos);
                info_prefacturacion.lst_det_otros = new List<fa_pre_facturacion_det_otros_Info>(blst_otros);
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

        private bool validar()
        {
            try
            {
                if (cmb_centro_costo.EditValue == null)
                {
                    MessageBox.Show("Seleccione el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool guardarDB()
        {
            try
            {
                if (bus_prefacturacion.GuardarDB(info_prefacturacion))
                {
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

        private bool modificarDB()
        {
            try
            {
                if (bus_prefacturacion.ModificarDB(info_prefacturacion))
                {
                    MessageBox.Show("Registro actualizado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private bool anularDB()
        {
            try
            {
                if (bus_prefacturacion.AnularDB(info_prefacturacion))
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

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
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
                if (accion_grabar())
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
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
                if (accion_grabar())
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

        private void frmFa_PreFacturacion_Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmFa_PreFacturacion_Mantenimiento_FormClosed(sender, e);
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

        private void btn_agregar_detalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validar()) return;

                

                if (cmb_proceso.EditValue == null)
                {
                    MessageBox.Show("Seleccione el proceso que desea agregar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (blst_det.Where(q=>q.IdProceso_prefacturacion == Convert.ToInt32(cmb_proceso.EditValue)).Count() > 0)
                {
                    MessageBox.Show("El proceso seleccionado ya ha sido agregado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                 proceso = (Cl_Enumeradores.eProceso_prefactura)Enum.Parse(typeof(Cl_Enumeradores.eProceso_prefactura), colorEnums.FirstOrDefault(q => q.Key == Convert.ToInt32(cmb_proceso.EditValue)).Value);
                List<fa_pre_facturacion_det_Info> lst_temp = new List<fa_pre_facturacion_det_Info>(blst_det);
                
                switch (proceso)
                {
                    case Cl_Enumeradores.eProceso_prefactura.MO_DIFERENCIA:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_diferencia_mano_obra(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.GASTOS_X_FACTURA:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_gastos(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue),chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.DEPRECIACION_X_TARIFARIO:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_depreciacion(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.POLIZA_X_ACT:
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.POLIZA_X_CUO:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_poliza_x_cuota(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.COMPENSACION:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_compensacion(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.SUMINISTROS_Y_MATERIALES:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_inventario(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.MANO_DE_OBRA_X_AF:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_mano_obra(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.DEPRECIACION_X_SUBCENTRO:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_depreciacion_x_subcentro(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.OTROS:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_otros(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.MOVILIZACION_X_AF:
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_movilizacion(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked));
                        splashScreenManager1.CloseWaitForm();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.SUPERVISORES:

                        if (txtvalorafacturar.Text ==""|| Convert.ToDouble(txtvalorafacturar.Text) == 0)
                        {
                            MessageBox.Show("Ingrese el valor a facturar por activo",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (txttotalequipos.Text == "" || Convert.ToInt32(txttotalequipos.Text) == 0)
                        {
                            MessageBox.Show("No tiene activos en tarifarios para este centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        splashScreenManager1.ShowWaitForm();
                        lst_temp.AddRange(bus_det.get_list_disponibilidad(info_prefacturacion, Convert.ToInt32(cmb_proceso.EditValue), chk_fee.Checked, Convert.ToDouble(txtvalorafacturar.Text), Convert.ToInt32(txttotalequipos.Text)));
                        splashScreenManager1.CloseWaitForm();
                        break;
                        
                }
                blst_det = new BindingList<fa_pre_facturacion_det_Info>(lst_temp);
                gridControl_prefacturacion.DataSource = blst_det;
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
                
            }
        }

        private void cmb_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                List<ct_centro_costo_sub_centro_costo_Info> lst_subcentro = new List<ct_centro_costo_sub_centro_costo_Info>();
                if (cmb_centro_costo.EditValue != null)
                {
                    ct_centro_costo_sub_centro_costo_Bus bus_subcentro = new ct_centro_costo_sub_centro_costo_Bus();
                    lst_subcentro = bus_subcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, cmb_centro_costo.EditValue.ToString());
                    
                    if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        int cantidad_activos_en_tarifario = bus_tarifario_x_cliente.get_cantidad_activos_x_centro_costo(param.IdEmpresa, cmb_centro_costo.EditValue.ToString());
                        txttotalequipos.Text = cantidad_activos_en_tarifario.ToString();    
                    }
                }
                cmb_subcentro.DataSource = lst_subcentro;
                cmb_subcentro_act.DataSource = lst_subcentro;
                cmb_subcentro_otros.DataSource = lst_subcentro;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    procesar_activos();
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

        private void btn_eliminar_detalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_proceso.EditValue == null)
                {
                    MessageBox.Show("Seleccione el proceso que desea agregar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (blst_det.Where(q => q.IdProceso_prefacturacion == Convert.ToInt32(cmb_proceso.EditValue)).Count() == 0)
                {
                    MessageBox.Show("El proceso seleccionado no existe en el detalle de la prefacturacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (blst_det.Where(q => q.IdProceso_prefacturacion == Convert.ToInt32(cmb_proceso.EditValue) && q.IdCbteVta != null).Count()>0)
                {
                    MessageBox.Show("El proceso seleccionado ya ha sido facturado total o parcialmente y no puede eliminarse", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                blst_det = new BindingList<fa_pre_facturacion_det_Info>(blst_det.Where(q => q.IdProceso_prefacturacion != Convert.ToInt32(cmb_proceso.EditValue)).ToList());
                gridControl_prefacturacion.DataSource = blst_det;
                
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

        private void gridView_prefacturacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_pre_facturacion_det_Info row = (fa_pre_facturacion_det_Info)gridView_prefacturacion.GetRow(e.RowHandle);

                if(row == null)return;

                if (e.Column == col_impuesto)
                {
                    tb_sis_impuesto_Info info_impuesto = new tb_sis_impuesto_Info();
                    info_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto);
                    if (info_impuesto != null)
                    {
                        row.por_iva = info_impuesto.porcentaje;
                        row.valor_iva = (row.subtotal + row.valor_ganancia) * (row.por_iva / 100);
                        row.total = row.subtotal + row.valor_ganancia + row.valor_iva;
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

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validar()) return;

                List<fa_pre_facturacion_det_Info> lst_validaciones = new List<fa_pre_facturacion_det_Info>(blst_det.Where(q => q.seleccionado == true));

                if (lst_validaciones.Count == 0)
                {
                    MessageBox.Show("Seleccione registros para facturar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (lst_validaciones.Where(q=>q.Secuencia == 0).Count() > 0)
                {
                    MessageBox.Show("Debe guardar los cambios antes de facturar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ucIn_Sucursal_Bodega1.get_IdSucursal() == 0)
                {
                    MessageBox.Show("Seleccione la sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ucIn_Sucursal_Bodega1.get_IdBodega() == 0)
                {
                    MessageBox.Show("Seleccione la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var lst = (from q in lst_validaciones
                           group q by new { q.IdGrupo }
                               into grouping
                               select new { grouping.Key }).ToList();

                foreach (var item in lst)
                {
                    List<fa_pre_facturacion_det_Info> lst_temporal = new List<fa_pre_facturacion_det_Info>(blst_det.Where(q => q.seleccionado == true && q.IdGrupo == item.Key.IdGrupo));
                    if (lst.Count > 0)
                    {
                        fa_factura_Info info_factura = get_info_factura(lst_temporal);
                        frmFa_liquidacion_x_punto_cargo_factura_confirmacion frm_con = new frmFa_liquidacion_x_punto_cargo_factura_confirmacion();
                        frm_con.set_info(info_factura);
                        frm_con.set_info(lst_temporal);
                        frm_con.ShowDialog();
                    }                    
                }
                set_info_in_controls();
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

        private fa_factura_Info get_info_factura(List<fa_pre_facturacion_det_Info> Lista)
        {
            try
            {
                fa_factura_Info info_factura = new fa_factura_Info();
                info_factura.IdCbteVta = 0;
                info_factura.CodCbteVta = "";
                info_factura.Estado = "A";
                info_factura.Fecha_Transaccion = DateTime.Now;
                info_factura.Fecha_UltAnu = DateTime.Now;
                info_factura.Fecha_UltMod = DateTime.Now;
                info_factura.IdBodega = ucIn_Sucursal_Bodega1.get_IdSucursal();
                info_factura.IdSucursal = ucIn_Sucursal_Bodega1.get_IdBodega();
                info_factura.IdCliente = lst_centro_costo.FirstOrDefault(q => q.IdCentroCosto == cmb_centro_costo.EditValue.ToString()).IdCliente_cli;
                info_factura.IdEmpresa = param.IdEmpresa;
                info_factura.IdPeriodo = (DateTime.Now.Year * 100) + DateTime.Now.Month;
                info_factura.IdUsuario = param.IdUsuario;
                info_factura.IdUsuarioUltAnu = param.IdUsuario;
                info_factura.IdUsuarioUltModi = param.IdUsuario;
                info_factura.ip = param.ip;
                info_factura.nom_pc = param.nom_pc;
                info_factura.vt_fecha = DateTime.Now.Date;
                info_factura.vt_flete = 0;
                info_factura.vt_interes = 0;
                info_factura.vt_OtroValor1 = 0;
                info_factura.vt_OtroValor2 = 0;
                info_factura.vt_tipo_venta = "CON";
                info_factura.vt_seguro = 0;
                info_factura.vt_anio = info_factura.vt_fecha.Year;
                info_factura.vt_mes = info_factura.vt_fecha.Month;

                info_factura.DetFactura_List = new List<fa_factura_det_info>();

                var lst = (from q in Lista
                           group q by new {q.IdEmpresa,q.IdProducto,q.IdCod_Impuesto,q.por_iva }
                               into grouping
                               select new
                               {
                                   grouping.Key.IdEmpresa,
                                   grouping.Key.IdProducto,
                                   subtotal = grouping.Sum(d=>d.subtotal+d.valor_ganancia),
                                   grouping.Key.IdCod_Impuesto,
                                   iva = grouping.Sum(d=>d.valor_iva),
                                   grouping.Key.por_iva,
                                   total = grouping.Sum(d=>d.total)
                               }).ToList();

                foreach (var item in lst)
                {
                    fa_factura_det_info det_mo = new fa_factura_det_info();
                    det_mo.IdEmpresa = info_factura.IdEmpresa;
                    det_mo.IdSucursal = info_factura.IdSucursal;
                    det_mo.IdBodega = info_factura.IdBodega;
                    det_mo.IdCbteVta = 0;
                    det_mo.vt_cantidad = 1;
                    det_mo.vt_Precio = item.subtotal;
                    det_mo.vt_PorDescUnitario = 0;
                    det_mo.vt_DescUnitario = 0;
                    det_mo.vt_PrecioFinal = item.subtotal;
                    det_mo.IdProducto = item.IdProducto;
                    det_mo.vt_Subtotal = item.subtotal;
                    det_mo.vt_iva = item.iva;
                    det_mo.vt_total = det_mo.vt_Subtotal + det_mo.vt_iva;
                    det_mo.vt_estado = "A";
                    det_mo.vt_por_iva = item.por_iva;
                    det_mo.IdPunto_cargo = null;
                    det_mo.IdPunto_cargo_grupo = null;
                    det_mo.IdCentroCosto = null;
                    det_mo.IdCentroCosto_sub_centro_costo = null;
                    det_mo.IdCod_Impuesto_Iva = item.IdCod_Impuesto;
                    det_mo.vt_detallexItems = " ";
                    info_factura.DetFactura_List.Add(det_mo);
                }

                return info_factura;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        private void gridView_prefacturacion_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                fa_pre_facturacion_det_Info row = (fa_pre_facturacion_det_Info)gridView_prefacturacion.GetRow(e.RowHandle);

                if (row == null) return;
                if (row.IdCbteVta != null) e.Appearance.ForeColor = Color.Blue;
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

        private void gridView_prefacturacion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                fa_pre_facturacion_det_Info row = (fa_pre_facturacion_det_Info)gridView_prefacturacion.GetRow(e.FocusedRowHandle);

                if (row == null)
                    gridView_prefacturacion.OptionsBehavior.ReadOnly = false;
                else
                    if(row.IdCbteVta == null)
                        gridView_prefacturacion.OptionsBehavior.ReadOnly = false;
                    else
                        gridView_prefacturacion.OptionsBehavior.ReadOnly = true;                
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                proceso = (Cl_Enumeradores.eProceso_prefactura)Enum.Parse(typeof(Cl_Enumeradores.eProceso_prefactura), colorEnums.FirstOrDefault(q => q.Key == Convert.ToInt32(cmb_proceso.EditValue)).Value);

                switch (proceso)
                {
                    case Cl_Enumeradores.eProceso_prefactura.MO_DIFERENCIA:

                        break;
                    case Cl_Enumeradores.eProceso_prefactura.GASTOS_X_FACTURA:
                        XFAC_FJ_Rpt002_Rpt rpt = new XFAC_FJ_Rpt002_Rpt();
                        rpt.P_IdPrefacturacion.Value = info_prefacturacion.IdPreFacturacion;
                        rpt.ShowPreviewDialog();
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.DEPRECIACION_X_TARIFARIO:
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.POLIZA_X_ACT:
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.POLIZA_X_CUO:
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.COMPENSACION:
                        break;
                    case Cl_Enumeradores.eProceso_prefactura.MANO_DE_OBRA_X_AF:
                        XFAC_FJ_Rpt016_Rpt Reporte = new XFAC_FJ_Rpt016_Rpt();
                        Reporte.Parameters["IdPeriodo"].Value = info_prefacturacion.IdPeriodo;
                        Reporte.Parameters["FechaInicio"].Value = info_prefacturacion.pe_FechaIni;
                        Reporte.Parameters["FechaFin"].Value = info_prefacturacion.pe_FechaFin;
                        Reporte.ShowPreviewDialog();
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

        private void btn_reprocesar_activos_Click(object sender, EventArgs e)
        {
            procesar_activos();
        }

        private void procesar_activos()
        {
            try
            {
                if (cmb_centro_costo.EditValue != null && ucCon_Periodo1.Get_Periodo_Info() != null)
                {
                    blst_activos = new BindingList<fa_pre_facturacion_activos_Info>(bus_activos.get_list(param.IdEmpresa,cmb_centro_costo.EditValue.ToString(),ucCon_Periodo1.Get_Periodo_Info().IdPeriodo));
                    gridControl_activos.DataSource = blst_activos;
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

        private void ucCon_Periodo1_event_delegate_cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    procesar_activos();
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

        private void chk_seleccionar_visibles_det_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_prefacturacion.RowCount; i++)
                {
                    gridView_prefacturacion.SetRowCellValue(i, col_check, chk_seleccionar_visibles_det.Checked);
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