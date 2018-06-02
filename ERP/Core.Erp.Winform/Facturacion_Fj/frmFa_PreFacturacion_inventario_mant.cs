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
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Cus.Erp.Reports.FJ.Facturacion;
using System.Linq;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_PreFacturacion_inventario_mant : DevExpress.XtraEditors.XtraForm
    {
        #region delegados
        public delegate void delegate_frmFa_PreFacturacion_inventario_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmFa_PreFacturacion_inventario_mant_FormClosed event_delegate_frmFa_PreFacturacion_inventario_mant_FormClosed;

        private void frmFa_PreFacturacion_inventario_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            event_delegate_frmFa_PreFacturacion_inventario_mant_FormClosed(sender, e);
        }

        void frmFa_PreFacturacion_inventario_mant_event_delegate_frmFa_PreFacturacion_inventario_mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion

        #region Variables
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_pre_facturacion_Bus bus_prefacturacion = new fa_pre_facturacion_Bus();
        fa_pre_facturacion_Info info_prefacturacion = new fa_pre_facturacion_Info();
        List<fa_pre_facturacion_Info> lst_prefacturacion = new List<fa_pre_facturacion_Info>();

        List<fa_cliente_x_ct_centro_costo_Info> lst_Cliente_x_Centro_costo = new List<fa_cliente_x_ct_centro_costo_Info>();
        fa_cliente_x_ct_centro_costo_Info info_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Info();
        fa_cliente_x_ct_centro_costo_Bus bus_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> lst_subcentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus bus_subcentro = new ct_centro_costo_sub_centro_costo_Bus();
        List<in_movi_inven_tipo_Info> lst_movi_inven_tipo = new List<in_movi_inven_tipo_Info>();
        in_movi_inven_tipo_Bus bus_movi_inven_tipo = new in_movi_inven_tipo_Bus();
        List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();
        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
        List<cp_proveedor_Info> lst_proveedor = new List<cp_proveedor_Info>();
        cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();

        BindingList<fa_pre_facturacion_det_ing_egr_inven_Info> blst_egr = new BindingList<fa_pre_facturacion_det_ing_egr_inven_Info>();
        BindingList<fa_pre_facturacion_det_ing_egr_inven_Info> blst_ing = new BindingList<fa_pre_facturacion_det_ing_egr_inven_Info>();
        BindingList<fa_pre_facturacion_det_ing_egr_inven_Info> blst_con = new BindingList<fa_pre_facturacion_det_ing_egr_inven_Info>();
        BindingList<fa_pre_facturacion_det_ing_egr_inven_Info> blst_det = new BindingList<fa_pre_facturacion_det_ing_egr_inven_Info>();
        fa_pre_facturacion_det_ing_egr_inven_Bus bus_det = new fa_pre_facturacion_det_ing_egr_inven_Bus();
        #endregion

        public frmFa_PreFacturacion_inventario_mant()
        {
            InitializeComponent();
            event_delegate_frmFa_PreFacturacion_inventario_mant_FormClosed += frmFa_PreFacturacion_inventario_mant_event_delegate_frmFa_PreFacturacion_inventario_mant_FormClosed;
        }

        private void frmFa_PreFacturacion_inventario_mant_Load(object sender, EventArgs e)
        {
            try
            {
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

                ucCon_Periodo1.Set_Periodo(info_prefacturacion.IdPeriodo);
                de_Fecha.EditValue = info_prefacturacion.fecha;
                chk_estado_cierre.Checked = info_prefacturacion.estado_cierre;
                cmb_centro_costo.EditValue = info_prefacturacion.IdCentroCosto;
                if (info_prefacturacion.estado == "I")
                    lblAnulado.Visible = true;

                blst_det = new BindingList<fa_pre_facturacion_det_ing_egr_inven_Info>(bus_det.get_list(param.IdEmpresa, info_prefacturacion.IdPreFacturacion));
                gridControl_detalle.DataSource = blst_det;
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
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_info_in_controls();
                        ucGe_Menu_Superior_Mant1.btnGuardar.Visible = true;
                        ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.btnGuardar.Visible = false;
                        ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = false;
                        set_info_in_controls();
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

        private void ucCon_Periodo1_event_delegate_cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucCon_Periodo1.Get_Periodo_Info() != null)
                {
                    de_fecha_ini_eg.DateTime = ucCon_Periodo1.Get_Periodo_Info().pe_FechaIni.Date;
                    de_fecha_fin_eg.DateTime = ucCon_Periodo1.Get_Periodo_Info().pe_FechaFin.Date;

                    de_fecha_ini_cd.DateTime = ucCon_Periodo1.Get_Periodo_Info().pe_FechaIni.Date;
                    de_fecha_fin_cd.DateTime = ucCon_Periodo1.Get_Periodo_Info().pe_FechaFin.Date;
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
                de_fecha_ini_in.DateTime = DateTime.Now.AddMonths(-6);
                ucCon_Periodo1.Cargar_combos();
                lst_Cliente_x_Centro_costo = bus_Cliente_x_Centro_costo.Get_Vista_Clientes_x_Centro_costo(param.IdEmpresa);
                cmb_centro_costo.Properties.DataSource = lst_Cliente_x_Centro_costo;

                lst_movi_inven_tipo = bus_movi_inven_tipo.Get_list_movi_inven_tipo(param.IdEmpresa, "-");
                cmb_chk_tipo_movimiento_egresos.Properties.DataSource = lst_movi_inven_tipo;
                cmb_tipo_movi_egr.DataSource = lst_movi_inven_tipo;

                lst_movi_inven_tipo = bus_movi_inven_tipo.Get_list_movi_inven_tipo(param.IdEmpresa, "+");
                cmb_chk_tipo_movimiento_ingresos.Properties.DataSource = lst_movi_inven_tipo;
                cmb_tipo_movi_in.DataSource = lst_movi_inven_tipo;

                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto_eg.DataSource = lst_producto;
                cmb_producto_in.DataSource = lst_producto;
                cmb_producto_cd.DataSource = lst_producto;
                cmb_producto_det.DataSource = lst_producto;

                lst_punto_cargo = bus_punto_cargo.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                cmb_punto_cargo_eg.DataSource = lst_punto_cargo;
                cmb_punto_cargo_cd.DataSource = lst_punto_cargo;
                cmb_punto_cargo_det.DataSource = lst_punto_cargo;

                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal_egr.DataSource = lst_sucursal;

                lst_proveedor = bus_proveedor.Get_List_proveedor(param.IdEmpresa);
                cmb_proveedor_in.DataSource = lst_proveedor;
                cmb_proveedor_cd.DataSource = lst_proveedor;
                cmb_proveedor_det.DataSource = lst_proveedor;
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

        private void btn_buscar_egresos_Click(object sender, EventArgs e)
        {
            try
            {
                buscar_egresos();
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

        private void buscar_egresos()
        {
            try
            {
                List<int> lst_IdMovi_inven_tipo = new List<int>();
                foreach (var item in cmb_chk_tipo_movimiento_egresos.Properties.GetItems().GetCheckedValues())
                {
                    lst_IdMovi_inven_tipo.Add(Convert.ToInt32(item));
                }

                if (lst_IdMovi_inven_tipo.Count == 0)
                {
                    MessageBox.Show("Seleccione los tipos de movimientos a buscar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (de_fecha_ini_eg.EditValue == null || de_fecha_fin_eg.EditValue == null)
                {
                    MessageBox.Show("Ingrese el rango de fechas a buscar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                blst_egr = new BindingList<fa_pre_facturacion_det_ing_egr_inven_Info>(bus_det.get_list(param.IdEmpresa, cmb_centro_costo.EditValue.ToString(), "EGR_VARIOS", de_fecha_ini_eg.DateTime.Date, de_fecha_fin_eg.DateTime.Date, lst_IdMovi_inven_tipo));
                gridControl_egresos.DataSource = blst_egr;
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardar())
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardar())
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

        private void btn_aprobar_egresos_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = false;
                List<fa_pre_facturacion_det_ing_egr_inven_Info> lst_det_egr = new List<fa_pre_facturacion_det_ing_egr_inven_Info>(blst_egr.Where(q => q.seleccionado == true).ToList());
                List<fa_pre_facturacion_det_ing_egr_inven_Info> lst_det_ing = new List<fa_pre_facturacion_det_ing_egr_inven_Info>(blst_ing.Where(q => q.seleccionado == true).ToList());

                foreach (var item in lst_det_egr)
                {
                    int cont = 0;

                    fa_pre_facturacion_det_ing_egr_inven_Info info = new fa_pre_facturacion_det_ing_egr_inven_Info();
                    info = lst_det_ing.OrderByDescending(q=>q.cm_fecha).ToList().FirstOrDefault(q => q.IdProducto == item.IdProducto && q.saldo_aux > 0);
                    item.saldo_aux = item.eg_cantidad;
                    while (info != null && item.saldo_aux != 0)
                    {
                        fa_pre_facturacion_det_ing_egr_inven_Info info_guardar = new fa_pre_facturacion_det_ing_egr_inven_Info();
                        info_guardar = item;
                        info_guardar.IdEmpresa = param.IdEmpresa;
                        info_guardar.IdPreFacturacion = info_prefacturacion.IdPreFacturacion;

                        info_guardar.in_IdEmpresa = info.in_IdEmpresa;
                        info_guardar.in_IdSucursal = info.in_IdSucursal;
                        info_guardar.in_IdMovi_inven_tipo = info.in_IdMovi_inven_tipo;
                        info_guardar.in_IdNumMovi = info.in_IdNumMovi;
                        info_guardar.in_Secuencia = info.in_Secuencia;
                        info_guardar.in_cantidad = info.saldo_aux >= item.eg_cantidad ? Convert.ToDouble(item.eg_cantidad) : Convert.ToDouble(info.saldo_aux);
                        info_guardar.costo_uni = info.costo_uni;
                        info_guardar.subtotal = info.costo_uni * info_guardar.in_cantidad;
                        info_guardar.IdProveedor = info.IdProveedor;
                        info_guardar.cp_fecha = info.cp_fecha;
                        info_guardar.eg_fecha = item.eg_fecha;
                        info_guardar.eg_codigo = item.eg_codigo;
                        info_guardar.cp_numero = info.cp_numero;
                        //Si el saldo del ingreso > cantidad egresada
                        if (info.saldo_aux >= item.eg_cantidad)
                        {
                            lst_det_ing.FirstOrDefault(q => q.in_IdEmpresa == info.in_IdEmpresa && q.in_IdSucursal == info.in_IdSucursal && q.in_IdMovi_inven_tipo == info.in_IdMovi_inven_tipo && q.in_IdNumMovi == info.in_IdNumMovi).saldo_aux -= item.in_cantidad;
                            item.saldo_aux = 0;
                        }
                        else //Si la cantidad egresada es mayor al ingreso
                        {
                            item.saldo_aux -= info.saldo_aux;
                            info_guardar.eg_cantidad = info.saldo_aux;
                            lst_det_ing.FirstOrDefault(q => q.in_IdEmpresa == info.in_IdEmpresa && q.in_IdSucursal == info.in_IdSucursal && q.in_IdMovi_inven_tipo == info.in_IdMovi_inven_tipo && q.in_IdNumMovi == info.in_IdNumMovi).saldo_aux = 0;                            
                        }
                        
                        res = bus_det.guardarDB(info_guardar);
                        info = lst_det_ing.OrderByDescending(q => q.cm_fecha).ToList().FirstOrDefault(q => q.IdProducto == item.IdProducto && q.saldo_aux > 0);
                        cont++;
                    }

                    if (cont == 0)
                    {
                        fa_pre_facturacion_det_ing_egr_inven_Info info_guardar = new fa_pre_facturacion_det_ing_egr_inven_Info();
                        info_guardar = item;
                        info_guardar.IdEmpresa = param.IdEmpresa;
                        info_guardar.IdPreFacturacion = info_prefacturacion.IdPreFacturacion;

                        info_guardar.in_IdSucursal = null;
                        info_guardar.in_IdMovi_inven_tipo = null;
                        info_guardar.in_IdNumMovi = null;
                        info_guardar.in_Secuencia = null;
                        info_guardar.in_cantidad = 0;
                        info_guardar.costo_uni = 0;
                        info_guardar.subtotal = 0;
                        info_guardar.IdProveedor = null;
                        info_guardar.cp_fecha = null;
                        info_guardar.eg_fecha = item.eg_fecha;
                        info_guardar.eg_codigo = item.eg_codigo;
                        info_guardar.cp_numero = null;
                        res = bus_det.guardarDB(info_guardar);

                        item.saldo_aux = 0;
                    }

                    if (item.saldo_aux > 0)
                    {
                        fa_pre_facturacion_det_ing_egr_inven_Info info_guardar = new fa_pre_facturacion_det_ing_egr_inven_Info();
                        info_guardar = item;
                        info_guardar.IdEmpresa = param.IdEmpresa;
                        info_guardar.IdPreFacturacion = info_prefacturacion.IdPreFacturacion;
                        info_guardar.eg_cantidad = item.saldo_aux;

                        info_guardar.in_IdSucursal = null;
                        info_guardar.in_IdMovi_inven_tipo = null;
                        info_guardar.in_IdNumMovi = null;
                        info_guardar.in_Secuencia = null;
                        info_guardar.in_cantidad = 0;
                        info_guardar.costo_uni = 0;
                        info_guardar.subtotal = 0;
                        info_guardar.IdProveedor = null;
                        info_guardar.cp_fecha = null;
                        info_guardar.eg_fecha = item.eg_fecha;
                        info_guardar.eg_codigo = item.eg_codigo;
                        info_guardar.cp_numero = null;
                        res = bus_det.guardarDB(info_guardar);
                    }
                }
                set_info_in_controls();
                buscar_egresos();
                buscar_ingresos();
                if (res)
                {
                    MessageBox.Show("Registros aprobados exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void btn_buscar_ingresos_Click(object sender, EventArgs e)
        {
            try
            {
                buscar_ingresos();
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

        private void buscar_ingresos()
        {
            try
            {
                List<int> lst_IdMovi_inven_tipo = new List<int>();
                foreach (var item in cmb_chk_tipo_movimiento_ingresos.Properties.GetItems().GetCheckedValues())
                {
                    lst_IdMovi_inven_tipo.Add(Convert.ToInt32(item));
                }

                if (lst_IdMovi_inven_tipo.Count == 0)
                {
                    MessageBox.Show("Seleccione los tipos de movimientos a buscar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (de_fecha_ini_in.EditValue == null || de_fecha_fin_in.EditValue == null)
                {
                    MessageBox.Show("Ingrese el rango de fechas a buscar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                blst_ing = new BindingList<fa_pre_facturacion_det_ing_egr_inven_Info>(bus_det.get_list(param.IdEmpresa, cmb_centro_costo.EditValue.ToString(), "ING_VARIOS", de_fecha_ini_in.DateTime.Date, de_fecha_fin_in.DateTime.Date, lst_IdMovi_inven_tipo));
                gridControl_ingresos.DataSource = blst_ing;
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

        private void de_fecha_fin_eg_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                de_fecha_fin_in.DateTime = de_fecha_fin_eg.DateTime;
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

        private void chk_seleccionar_egresos_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_egresos.RowCount; i++)
                {
                    gridView_egresos.SetRowCellValue(i, col_seleccionado_eg, chk_seleccionar_egresos_visibles.Checked);
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

        private void chk_seleccionar_ingresos_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_ingresos.RowCount; i++)
                {
                    gridView_ingresos.SetRowCellValue(i, col_seleccionado_in, chk_seleccionar_ingresos_visibles.Checked);
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

        private void btn_buscar_consumo_directo_Click(object sender, EventArgs e)
        {
            try
            {
                buscar_consumo_directo();
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

        private void buscar_consumo_directo()
        {
            try
            {
                List<int> lst_IdMovi_inven_tipo = new List<int>();

                if (de_fecha_ini_cd.EditValue == null || de_fecha_fin_cd.EditValue == null)
                {
                    MessageBox.Show("Ingrese el rango de fechas a buscar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                blst_con = new BindingList<fa_pre_facturacion_det_ing_egr_inven_Info>(bus_det.get_list(param.IdEmpresa, cmb_centro_costo.EditValue.ToString(), "ING_CON_DIR", de_fecha_ini_cd.DateTime.Date, de_fecha_fin_cd.DateTime.Date, lst_IdMovi_inven_tipo));
                gridControl_consumo_directo.DataSource = blst_con;
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

        private void btn_aprobar_consumo_directo_Click(object sender, EventArgs e)
        {
            try
            {
                List<fa_pre_facturacion_det_ing_egr_inven_Info> lst_det = new List<fa_pre_facturacion_det_ing_egr_inven_Info>(blst_con.Where(q => q.seleccionado == true));

                foreach (var item in lst_det)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPreFacturacion = info_prefacturacion.IdPreFacturacion;
                    bus_det.guardarDB(item);
                }

                set_info_in_controls();
                buscar_consumo_directo();
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

        private void chk_seleccionar_consumo_directo_visible_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_consumo_directo.RowCount; i++)
                {
                    gridView_consumo_directo.SetRowCellValue(i, col_seleccionado_cd, chk_seleccionar_consumo_directo_visible.Checked);
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

        private void cmb_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lst_subcentro = new List<ct_centro_costo_sub_centro_costo_Info>();
                if (cmb_centro_costo.EditValue != null)
                {
                    lst_subcentro = bus_subcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, cmb_centro_costo.EditValue.ToString());
                }
                cmb_subcentro_det.DataSource = lst_subcentro;
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

        private bool guardar()
        {
            try
            {
                List<fa_pre_facturacion_det_ing_egr_inven_Info> lista_grabar = new List<fa_pre_facturacion_det_ing_egr_inven_Info>(blst_det);
                foreach (var item in lista_grabar)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPreFacturacion = Convert.ToDecimal(txt_IdPreFacturacion.Text);
                }
                if (bus_det.eliminarDB(info_prefacturacion.IdEmpresa, info_prefacturacion.IdPreFacturacion))
                {
                    if (bus_det.guardarDB(lista_grabar))
                    {
                        MessageBox.Show("Registros guardados exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;
                    }
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

        private void gridView_detalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        fa_pre_facturacion_det_ing_egr_inven_Info row = (fa_pre_facturacion_det_ing_egr_inven_Info)gridView_detalle.GetFocusedRow();
                        bus_det.eliminarDB(row.IdEmpresa, row.IdPreFacturacion, row.Secuencia);
                        gridView_detalle.DeleteSelectedRows();
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XFAC_FJ_Rpt004_Rpt rpt = new XFAC_FJ_Rpt004_Rpt();
                rpt.p_IdPrefacturacion.Value = Convert.ToDecimal(txt_IdPreFacturacion.Text);
                rpt.ShowPreviewDialog();
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

        private void gridView_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_pre_facturacion_det_ing_egr_inven_Info row = (fa_pre_facturacion_det_ing_egr_inven_Info)gridView_detalle.GetRow(e.RowHandle);

                if (row == null)
                    return;

                if (e.Column == col_cantidad || e.Column == col_costo_uni)
                {
                    row.subtotal = Convert.ToDouble(row.eg_cantidad) * row.costo_uni;
                }
                if (e.Column == col_punto_cargo)
                {
                    ct_punto_cargo_Info row_pc = lst_punto_cargo.FirstOrDefault(q => q.IdPunto_cargo == row.IdPunto_cargo);
                    if (row_pc != null)
                    {
                        row.IdActivoFijo = row_pc.IdActivoFijo == null ? 0 : Convert.ToInt32(row_pc.IdActivoFijo);
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

        private void btn_eliminar_todo_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar todos los registros",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bus_det.eliminarDB(param.IdEmpresa, Convert.ToDecimal(txt_IdPreFacturacion.Text));
                    set_info_in_controls();
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