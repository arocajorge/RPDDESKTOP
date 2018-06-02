using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Cus.Erp.Reports.FJ.Facturacion;
using Core.Erp.Info.Mantenimiento;
using Core.Erp.Business.Mantenimiento;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_liquidacion_x_punto_cargo_mant : Form
    {
        #region Delegados
        public delegate void delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed event_delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed;
        #endregion

        #region Variables
        Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_liquidacion_x_punto_cargo_Info info_liquidacion = new fa_liquidacion_x_punto_cargo_Info();
        fa_liquidacion_x_punto_cargo_Bus bus_liquidacion = new fa_liquidacion_x_punto_cargo_Bus();
        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        List<fa_TerminoPago_Info> lst_termino_pago = new List<fa_TerminoPago_Info>();
        fa_TerminoPago_Bus bus_termino_pago = new fa_TerminoPago_Bus();
        List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();
        List<tb_sis_impuesto_Info> lst_impuestos = new List<tb_sis_impuesto_Info>();
        tb_sis_impuesto_Bus bus_impuestos = new tb_sis_impuesto_Bus();
        BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_Info> blst_liquidacion_mano_obra = new BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_Info>();
        fa_liquidacion_x_punto_cargo_det_mano_obra_Bus bus_liquidacion_mano_obra = new fa_liquidacion_x_punto_cargo_det_mano_obra_Bus();
        BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info> blst_liquidacion_mano_obra_det = new BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info>();
        fa_liquidacion_x_punto_cargo_det_mano_obra_det_Bus bus_liquidacion_mano_obra_det = new fa_liquidacion_x_punto_cargo_det_mano_obra_det_Bus();
        BindingList<fa_liquidacion_x_punto_cargo_det_logistica_Info> blst_liquidacion_logistica = new BindingList<fa_liquidacion_x_punto_cargo_det_logistica_Info>();
        fa_liquidacion_x_punto_cargo_det_logistica_Bus bus_liquidacion_logistica = new fa_liquidacion_x_punto_cargo_det_logistica_Bus();
        BindingList<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> blst_liquidacion_egresos = new BindingList<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>();
        fa_liquidacion_x_punto_cargo_det_egresos_inventario_Bus bus_liquidacion_egresos = new fa_liquidacion_x_punto_cargo_det_egresos_inventario_Bus();
        BindingList<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info> blst_liquidacion_ingresos = new BindingList<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info>();
        fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Bus bus_liquidacion_ingresos = new fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Bus();
        fa_factura_Info info_factura = new fa_factura_Info();
        fa_liquidacion_x_punto_cargo_parametros_Info info_param_liq = new fa_liquidacion_x_punto_cargo_parametros_Info();
        fa_liquidacion_x_punto_cargo_parametros_Bus bus_param_liq = new fa_liquidacion_x_punto_cargo_parametros_Bus();
        List<in_UnidadMedida_Info> lst_unidad_medida = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_unidad_medida = new in_UnidadMedida_Bus();
        List<fa_ruta_x_centro_costo_Info> lst_ruta_x_centro_costo = new List<fa_ruta_x_centro_costo_Info>();
        fa_ruta_x_centro_costo_Bus bus_ruta_x_centro_costo = new fa_ruta_x_centro_costo_Bus();
        List<man_tecnico_Info> lst_tecnico = new List<man_tecnico_Info>();
        man_tecnico_Bus bus_tecnico = new man_tecnico_Bus();
        List<man_actividad_Info> lst_actividad = new List<man_actividad_Info>();
        man_actividad_Bus bus_actividad = new man_actividad_Bus();
        man_actividad_det_Bus bus_actividad_det = new man_actividad_det_Bus();
        #endregion

        public frmFa_liquidacion_x_punto_cargo_mant()
        {
            InitializeComponent();
            event_delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed += frmFa_liquidacion_x_punto_cargo_mant_event_delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed;
        }

        void frmFa_liquidacion_x_punto_cargo_mant_event_delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmFa_liquidacion_x_punto_cargo_mant_Load(object sender, EventArgs e)
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

        private void frmFa_liquidacion_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            event_delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed(sender, e);
        }

        public void set_info(fa_liquidacion_x_punto_cargo_Info info)
        {
            try
            {
                info_liquidacion = info;
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

        private void set_accion_in_controls()
        {
            try
            {
                cargar_combos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucge_menu.Visible_bntAnular = false;
                        ucge_menu.Visible_btnGuardar = true;
                        ucge_menu.Visible_bntGuardar_y_Salir = true;
                        ucge_menu.Visible_bntImprimir = false;
                        ucge_menu.Visible_bntLimpiar = true;
                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_cmb_Centro_costo = false;
                        ucIn_Sucursal_Bodega1.cmb_sucursal.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucge_menu.Visible_bntAnular = false;
                        ucge_menu.Visible_btnGuardar = true;
                        ucge_menu.Visible_bntGuardar_y_Salir = true;
                        ucge_menu.Visible_bntImprimir = true;
                        ucge_menu.Visible_bntLimpiar = true;
                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_cmb_Centro_costo = true;
                        ucIn_Sucursal_Bodega1.cmb_sucursal.Properties.ReadOnly = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucge_menu.Visible_bntAnular = true;
                        ucge_menu.Visible_btnGuardar = false;
                        ucge_menu.Visible_bntGuardar_y_Salir = false;
                        ucge_menu.Visible_bntImprimir = false;
                        ucge_menu.Visible_bntLimpiar = false;
                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_cmb_Centro_costo = true;
                        ucIn_Sucursal_Bodega1.cmb_sucursal.Properties.ReadOnly = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucge_menu.Visible_bntAnular = false;
                        ucge_menu.Visible_btnGuardar = false;
                        ucge_menu.Visible_bntGuardar_y_Salir = false;
                        ucge_menu.Visible_bntImprimir = true;
                        ucge_menu.Visible_bntLimpiar = false;
                        ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_cmb_Centro_costo = true;
                        ucIn_Sucursal_Bodega1.cmb_sucursal.Properties.ReadOnly = true;
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
                ucIn_Sucursal_Bodega1.set_Idsucursal(info_liquidacion.IdSucursal);
                ucIn_Sucursal_Bodega1.set_Idbodega(info_liquidacion.IdSucursal,info_liquidacion.IdBodega == null ? 0 : Convert.ToInt32(info_liquidacion.IdBodega));
                ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo(info_liquidacion.IdCentroCosto);
                ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo_sub_centro_costo(info_liquidacion.IdCentroCosto_sub_centro_costo);
                txt_IdLiquidacion.Text = info_liquidacion.IdLiquidacion.ToString();
                cmb_punto_cargo.EditValue = info_liquidacion.IdPunto_cargo;
                cmb_termino_pago.EditValue = info_liquidacion.IdTerminoPago;
                de_fecha.DateTime = info_liquidacion.li_fecha;
                txt_horometro.Text = info_liquidacion.li_num_horas;
                txt_atencion_a.Text = info_liquidacion.li_atencion_a;
                txt_num_orden.Text = info_liquidacion.li_num_orden;
                txt_tipo_pedido.Text = info_liquidacion.li_tipo_pedido;
                lbl_anulado.Visible = !info_liquidacion.estado;
                cmb_producto_logistica.EditValue = info_liquidacion.lo_IdProducto;
                cmb_producto_egresos.EditValue = info_liquidacion.eg_IdProducto;
                cmb_producto_ingresos.EditValue = info_liquidacion.in_IdProducto;
                txt_observacion.Text = info_liquidacion.li_observacion;
                txt_reporte_mantenimiento.Text = info_liquidacion.li_reporte_mantenimiento;
                de_fecha_orden.EditValue = info_liquidacion.li_fecha_orden_mantenimiento;
                de_fecha_reporte.EditValue = info_liquidacion.li_fecha_reporte_mantenimiento;
                blst_liquidacion_mano_obra = new BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_Info>(bus_liquidacion_mano_obra.get_list(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion));
                gridControl_mano_obra.DataSource = blst_liquidacion_mano_obra;
                blst_liquidacion_logistica = new BindingList<fa_liquidacion_x_punto_cargo_det_logistica_Info>(bus_liquidacion_logistica.get_list(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion));
                gridControl_logistica.DataSource = blst_liquidacion_logistica;
                blst_liquidacion_egresos = new  BindingList<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>(bus_liquidacion_egresos.get_list(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion));
                gridControl_egresos.DataSource = blst_liquidacion_egresos;
                blst_liquidacion_ingresos = new BindingList<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info>(bus_liquidacion_ingresos.get_list(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion));
                gridControl_ingresos.DataSource = blst_liquidacion_ingresos;

                txt_subtotal.Text = info_liquidacion.li_subtotal.ToString();
                cmb_impuesto.EditValue = info_liquidacion.IdCod_Impuesto;
                txt_por_iva.Text = info_liquidacion.li_por_iva.ToString();
                txt_valor_iva.Text = info_liquidacion.li_valor_iva.ToString();
                txt_total.Text = info_liquidacion.li_total.ToString();
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
                de_fecha.EditValue = DateTime.Now.Date;
                lst_punto_cargo = bus_punto_cargo.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                cmb_punto_cargo.Properties.DataSource = lst_punto_cargo;
                lst_termino_pago = bus_termino_pago.Get_List_TerminoPago();
                cmb_termino_pago.Properties.DataSource = lst_termino_pago;
                ucFa_Cliente_x_centro_costo_cmb1.Cargar_combos();
                lst_impuestos = bus_impuestos.Get_List_impuesto_para_Ventas("IVA");
                cmb_impuesto.Properties.DataSource = lst_impuestos;
                cmb_impuesto.EditValue = param.iva.IdCod_Impuesto;

                cmb_producto_mo.DataSource = bus_producto.Get_list_Producto_x_modulo_mantenimiento(param.IdEmpresa);

                lst_producto = bus_producto.Get_list_Producto_modulo_x_Ventas(param.IdEmpresa);
                cmb_producto_logistica.Properties.DataSource = lst_producto;
                cmb_producto_egresos.Properties.DataSource = lst_producto;
                cmb_producto_ingresos.Properties.DataSource = lst_producto;
                //cmb_producto_mo.DataSource = lst_producto;
                lst_producto = bus_producto.Get_list_Producto_modulo_x_inventario(param.IdEmpresa);
                cmb_producto_eg.DataSource = lst_producto;
                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto_in.DataSource = lst_producto;
                
                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida_eg.DataSource = lst_unidad_medida;
                cmb_unidad_medida_in.DataSource = lst_unidad_medida;

                info_param_liq = bus_param_liq.get_info(param.IdEmpresa);
                cmb_producto_logistica.EditValue = info_param_liq.lo_IdProducto;
                cmb_producto_egresos.EditValue = info_param_liq.eg_IdProducto;
                cmb_producto_ingresos.EditValue = info_param_liq.in_IdProducto;

                blst_liquidacion_mano_obra = new BindingList<fa_liquidacion_x_punto_cargo_det_mano_obra_Info>();
                gridControl_mano_obra.DataSource = blst_liquidacion_mano_obra;      
                blst_liquidacion_logistica = new BindingList<fa_liquidacion_x_punto_cargo_det_logistica_Info>();
                gridControl_logistica.DataSource = blst_liquidacion_logistica;
                blst_liquidacion_egresos = new BindingList<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>();
                gridControl_egresos.DataSource = blst_liquidacion_egresos;
                blst_liquidacion_ingresos = new BindingList<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info>();
                gridControl_ingresos.DataSource = blst_liquidacion_ingresos;

                lst_actividad = bus_actividad.get_list(param.IdEmpresa, false);
                cmb_actividad.DataSource = lst_actividad;

                lst_tecnico = bus_tecnico.get_list(param.IdEmpresa, false);
                cmb_tecnico.DataSource = lst_tecnico;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private bool validar()
        {
            try
            {
                txt_IdLiquidacion.Focus();
                calcular_totales();
                if (cmb_impuesto.EditValue == null)
                {
                    MessageBox.Show("Seleccione el impuesto a ser utilizado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.get_sucursal() == null || ucIn_Sucursal_Bodega1.get_sucursal().IdSucursal == 0)
                {
                    MessageBox.Show("Seleccione la sucursal",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.get_bodega() == null || ucIn_Sucursal_Bodega1.get_bodega().IdSucursal == 0)
                {
                    MessageBox.Show("Seleccione la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo() == null)
                {
                    MessageBox.Show("Seleccione el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo() == null)
                {
                    MessageBox.Show("Seleccione el subcentro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_punto_cargo.EditValue == null)
                {
                    MessageBox.Show("Seleccione el punto de cargo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_termino_pago.EditValue == null)
                {
                    MessageBox.Show("Seleccione el termino de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (de_fecha.EditValue == null)
                {
                    MessageBox.Show("Ingrese la fecha", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txt_num_orden.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el numero de orden de mantenimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txt_reporte_mantenimiento.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el reporte de mantenimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_liquidacion_logistica.Count > 0)
                {
                    if (cmb_producto_logistica.EditValue == null)
                    {
                        MessageBox.Show("Seleccione el producto para facturar la logistica", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if (blst_liquidacion_egresos.Count > 0)
                {
                    if (cmb_producto_egresos.EditValue == null)
                    {
                        MessageBox.Show("Seleccione el producto para facturar los repuestos y materiales", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if (blst_liquidacion_ingresos.Count > 0)
                {
                    if (cmb_producto_ingresos.EditValue == null)
                    {
                        MessageBox.Show("Seleccione el producto para facturar los servicios complementarios internos y externos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool guardarDB()
        {
            try
            {
                bool res = false;
                if (bus_liquidacion.GuardarDB(info_liquidacion))
                {
                    MessageBox.Show("Registro guardado exitosamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    res = true;
                    if (MessageBox.Show("Desea imprimir la transaccion?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        imprimir();
                    }                    
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

        private bool modificarDB()
        {
            try
            {
                bool res = false;
                if (bus_liquidacion.ModificarDB(info_liquidacion))
                {
                    MessageBox.Show("Registro modificado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;
                    if (MessageBox.Show("Desea imprimir la transaccion?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        imprimir();
                    }                    
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

        private bool anularDB()
        {
            try
            {
                bool res = false;
                if (bus_liquidacion.AnularDB(info_liquidacion))
                {
                    MessageBox.Show("Registro anulado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;
                    if (MessageBox.Show("Desea imprimir la transaccion?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        imprimir();
                    }
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

        private void imprimir()
        {
            try
            {
                XFAC_FJ_Rpt015_Rpt rpt = new XFAC_FJ_Rpt015_Rpt();
                rpt.p_IdSucursal.Value = info_liquidacion.IdSucursal;
                rpt.p_IdLiquidacion.Value = info_liquidacion.IdLiquidacion;
                rpt.p_IdCentroCosto.Value = info_liquidacion.IdCentroCosto;
                rpt.ShowPreviewDialog();
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
                ucIn_Sucursal_Bodega1.InicializarSucursal();
                ucIn_Sucursal_Bodega1.InicializarBodega();
                ucFa_Cliente_x_centro_costo_cmb1.Inicializar_Combos();
                txt_IdLiquidacion.Text = "";
                cmb_punto_cargo.EditValue = null;
                cmb_termino_pago.EditValue = null;
                de_fecha.DateTime = DateTime.Now.Date;
                txt_horometro.Text = "";
                txt_atencion_a.Text = "";
                txt_num_orden.Text = "";
                txt_tipo_pedido.Text = "";
                lbl_anulado.Visible = false;
                info_liquidacion = new fa_liquidacion_x_punto_cargo_Info();
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion_in_controls();
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
                info_liquidacion.IdEmpresa = param.IdEmpresa;
                info_liquidacion.IdSucursal = ucIn_Sucursal_Bodega1.get_IdSucursal();
                info_liquidacion.IdBodega = ucIn_Sucursal_Bodega1.get_IdBodega();
                info_liquidacion.IdCentroCosto = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo().IdCentroCosto;
                info_liquidacion.IdCentroCosto_sub_centro_costo = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;
                info_liquidacion.IdLiquidacion = txt_IdLiquidacion.Text == "" ? 0 : Convert.ToDecimal(txt_IdLiquidacion.Text);
                info_liquidacion.IdPunto_cargo = Convert.ToInt32(cmb_punto_cargo.EditValue);
                info_liquidacion.IdTerminoPago = cmb_termino_pago.EditValue.ToString();
                info_liquidacion.li_fecha = de_fecha.DateTime.Date;
                
                if (de_fecha_orden.EditValue != null)
                    info_liquidacion.li_fecha_orden_mantenimiento = de_fecha_orden.DateTime.Date;   
                else
                    info_liquidacion.li_fecha_orden_mantenimiento = null;

                if (de_fecha_reporte.EditValue != null)
                    info_liquidacion.li_fecha_reporte_mantenimiento = de_fecha_reporte.DateTime.Date;
                else
                    info_liquidacion.li_fecha_reporte_mantenimiento = null;

                info_liquidacion.li_num_horas = txt_horometro.Text;
                info_liquidacion.li_atencion_a = txt_atencion_a.Text;
                info_liquidacion.li_num_orden = txt_num_orden.Text;
                info_liquidacion.li_tipo_pedido = txt_tipo_pedido.Text;
                info_liquidacion.li_reporte_mantenimiento = txt_reporte_mantenimiento.Text;
                if (cmb_producto_logistica.EditValue != null) info_liquidacion.lo_IdProducto = Convert.ToDecimal(cmb_producto_logistica.EditValue);
                else info_liquidacion.lo_IdProducto = null;
                if (cmb_producto_egresos.EditValue != null) info_liquidacion.eg_IdProducto = Convert.ToDecimal(cmb_producto_egresos.EditValue);
                else info_liquidacion.eg_IdProducto = null;
                if (cmb_producto_ingresos.EditValue != null) info_liquidacion.in_IdProducto = Convert.ToDecimal(cmb_producto_ingresos.EditValue);
                else info_liquidacion.in_IdProducto = null;
                info_liquidacion.li_subtotal = txt_subtotal.Text == "" ? 0 : Convert.ToDouble(txt_subtotal.Text);
                info_liquidacion.li_por_iva = txt_por_iva.Text == "" ? 0 : Convert.ToDouble(txt_por_iva.Text);
                info_liquidacion.li_valor_iva = txt_valor_iva.Text == "" ? 0 : Convert.ToDouble(txt_valor_iva.Text);
                info_liquidacion.li_total = txt_total.Text == "" ? 0 : Convert.ToDouble(txt_total.Text);
                info_liquidacion.IdCod_Impuesto = cmb_impuesto.EditValue.ToString();
                info_liquidacion.li_observacion = txt_observacion.Text;

                info_liquidacion.lst_det_mano_obra = new List<fa_liquidacion_x_punto_cargo_det_mano_obra_Info>(blst_liquidacion_mano_obra);
                info_liquidacion.lst_det_logistica = new List<fa_liquidacion_x_punto_cargo_det_logistica_Info>(blst_liquidacion_logistica);
                info_liquidacion.lst_det_egresos = new List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>(blst_liquidacion_egresos.Where(q=>q.eg_estado == true));
                info_liquidacion.lst_det_ingresos = new List<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info>(blst_liquidacion_ingresos.Where(q => q.in_estado == true));
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucge_menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucge_menu_event_btnGuardar_Click(object sender, EventArgs e)
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucge_menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucge_menu_event_btnAnular_Click(object sender, EventArgs e)
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucge_menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        private void ucge_menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_mano_obra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_det_mano_obra_Info row = (fa_liquidacion_x_punto_cargo_det_mano_obra_Info)gridView_mano_obra.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_mo_IdProducto)
                {
                    in_Producto_Info info_producto = lst_producto.FirstOrDefault(q => q.IdProducto == row.IdProducto);
                    if (info_producto!= null)
                    {
                        row.mo_precio_uni = info_producto.pr_precio_publico == null ? 0 : Convert.ToDouble(info_producto.pr_precio_publico);
                        row.mo_valor_ganancia = row.mo_precio_uni * (row.mo_por_ganancia / 100);
                        row.mo_precio_total = (row.mo_precio_uni + row.mo_valor_ganancia) * row.mo_horas;
                    }
                }

                if (e.Column == col_mo_precio_uni || e.Column == col_mo_horas || e.Column == col_mo_por_ganancia)
                {
                    row.mo_valor_ganancia = row.mo_precio_uni * (row.mo_por_ganancia/100);
                    row.mo_precio_total = (row.mo_precio_uni + row.mo_valor_ganancia) * row.mo_horas;
                }

                if (e.Column == col_IdActividad_mo)
                {
                    man_actividad_Info info_actividad = lst_actividad.FirstOrDefault(q => q.IdActividad == row.IdActividad);
                    if (info_actividad != null)
                    {
                        row.mo_horas = info_actividad.ac_cant_horas_min;                        
                        row.mo_valor_ganancia = row.mo_precio_uni * (row.mo_por_ganancia / 100);
                        row.mo_precio_total = (row.mo_precio_uni + row.mo_valor_ganancia) * row.mo_horas;
                        row.mo_valor_ganancia = row.mo_precio_uni * (row.mo_por_ganancia / 100);
                        row.mo_precio_total = (row.mo_precio_uni + row.mo_valor_ganancia) * row.mo_horas;
                    }
                    row.lst_mano_obra_det = new List<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info>();
                    List<man_actividad_det_Info> lst_actividad_det = bus_actividad_det.get_list(param.IdEmpresa, row.IdActividad);
                    foreach (var item in lst_actividad_det)
                    {
                        fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info info_mo = new fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info();
                        info_mo.IdEmpresa = param.IdEmpresa;
                        info_mo.IdActividad = item.IdActividad_hijo;
                        row.lst_mano_obra_det.Add(info_mo);
                    }
                }
                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_logistica_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_det_logistica_Info row = (fa_liquidacion_x_punto_cargo_det_logistica_Info)gridView_logistica.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_IdRuta_lo)
                {
                    fa_ruta_x_centro_costo_Info info_ruta = lst_ruta_x_centro_costo.FirstOrDefault(q => q.IdRuta == row.IdRuta);
                    if (info_ruta != null)
                    {
                        row.lo_precio_uni_kilometro = info_ruta.ru_costo_x_km;
                        row.lo_kilometros = info_ruta.ru_cantidad_km;

                        row.lo_cantidad = 1;
                        row.lo_por_ganancia = 0;
                        row.lo_precio_total = 0;
                        row.lo_valor_ganancia = 0;

                        row.lo_valor_ganancia = row.lo_precio_uni_kilometro * (row.lo_por_ganancia / 100);
                        row.lo_precio_total = (row.lo_precio_uni_kilometro + row.lo_valor_ganancia) * row.lo_kilometros * row.lo_cantidad;
                    }
                }

                if (e.Column == col_lo_precio_uni || e.Column == col_lo_cantidad || e.Column == col_lo_kilometros || e.Column == col_lo_por_ganancia)
                {
                    row.lo_valor_ganancia = row.lo_precio_uni_kilometro * (row.lo_por_ganancia/100);
                    row.lo_precio_total = (row.lo_precio_uni_kilometro + row.lo_valor_ganancia) * row.lo_kilometros * row.lo_cantidad;
                }
                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_buscar_egresos_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validar()) return;

                List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> lst_liquidacion_egresos_temp = new List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>();
                lst_liquidacion_egresos_temp = blst_liquidacion_egresos.Where(q => q.eg_estado == true).ToList();

                get_info();

                List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> lst_liquidacion_egresos_nuevos_registros = new List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>();
                blst_liquidacion_egresos = new BindingList<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>(lst_liquidacion_egresos_temp);

                lst_liquidacion_egresos_nuevos_registros = bus_liquidacion_egresos.get_list(info_liquidacion.IdPunto_cargo, info_liquidacion.li_num_orden, info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion);
                foreach (var item in lst_liquidacion_egresos_nuevos_registros)
                {
                    if (blst_liquidacion_egresos.Where(q => q.inv_IdEmpresa == item.inv_IdEmpresa && q.inv_IdSucursal == item.inv_IdSucursal && q.inv_IdMovi_inven_tipo == item.inv_IdMovi_inven_tipo && q.inv_IdNumMovi == item.inv_IdNumMovi && q.inv_Secuencia == item.inv_Secuencia).Count() == 0)
                    {
                        item.eg_estado = false;
                        blst_liquidacion_egresos.Add(item);
                    }
                }
                gridControl_egresos.DataSource = blst_liquidacion_egresos;

                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_buscar_ingresos_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validar()) return;

                List<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info> lst_liquidacion_ingresos_temp = new List<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info>();
                lst_liquidacion_ingresos_temp = blst_liquidacion_ingresos.Where(q => q.in_estado == true).ToList();

                get_info();

                List<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info> lst_liquidacion_ingresos_nuevos_registros = new List<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info>();
                blst_liquidacion_ingresos = new BindingList<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info>(lst_liquidacion_ingresos_temp);

                lst_liquidacion_ingresos_nuevos_registros = bus_liquidacion_ingresos.get_list(info_liquidacion.IdPunto_cargo, info_liquidacion.li_num_orden, info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion);
                foreach (var item in lst_liquidacion_ingresos_nuevos_registros)
                {
                    if (blst_liquidacion_ingresos.Where(q => q.inv_IdEmpresa == item.inv_IdEmpresa && q.inv_IdSucursal == item.inv_IdSucursal && q.inv_IdMovi_inven_tipo == item.inv_IdMovi_inven_tipo && q.inv_IdNumMovi == item.inv_IdNumMovi && q.inv_Secuencia == item.inv_Secuencia).Count() == 0)
                    {
                        item.in_estado = false;
                        blst_liquidacion_ingresos.Add(item);
                    }
                }
                gridControl_ingresos.DataSource = blst_liquidacion_ingresos;

                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void chk_seleccionar_visibles_egresos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_egresos.RowCount; i++)
                {
                    gridView_egresos.SetRowCellValue(i, col_eg_estado, chk_seleccionar_visibles_egresos.Checked);
                }
                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void chk_seleccionar_visibles_ingresos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_ingresos.RowCount; i++)
                {
                    gridView_ingresos.SetRowCellValue(i, col_eg_estado, chk_seleccionar_visibles_egresos.Checked);
                }
                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_egresos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info row = (fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info)gridView_egresos.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_IdProducto_eg)
                {
                    in_Producto_Info info_prod = lst_producto.FirstOrDefault(q => q.IdProducto == row.IdProducto);
                    if (info_prod != null)
                    {
                        row.eg_precio_uni = info_prod.pr_precio_publico == null ? 0 : Convert.ToDouble(info_prod.pr_precio_publico);
                        row.eg_precio_total = 0;
                        row.eg_por_ganancia = 0;
                        row.eg_valor_ganancia = 0;
                        row.IdUnidadMedida = info_prod.IdUnidadMedida_Consumo;
                        row.pr_precio_publico = row.eg_precio_uni;
                    }
                }

                if (e.Column == col_eg_precio_uni)
                {
                    
                }

                if (e.Column == col_eg_cantidad || e.Column == col_eg_por_ganancia || e.Column == col_eg_precio_uni)
                {
                    row.eg_valor_ganancia = row.eg_precio_uni * (row.eg_por_ganancia / 100);
                    row.eg_precio_total = (row.eg_valor_ganancia + row.eg_precio_uni) * row.eg_cantidad;
                }
                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_ingresos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info row = (fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info)gridView_ingresos.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_IdProducto_in)
                {
                    in_Producto_Info info_prod = lst_producto.FirstOrDefault(q => q.IdProducto == row.IdProducto);
                    if (info_prod != null)
                    {
                        row.in_precio_uni = info_prod.pr_precio_publico == null ? 0 : Convert.ToDouble(info_prod.pr_precio_publico);
                        row.in_precio_total = 0;
                        row.in_por_ganancia = 0;
                        row.in_valor_ganancia = 0;
                        row.IdUnidadMedida = info_prod.IdUnidadMedida_Consumo;
                        row.pr_precio_publico = row.in_precio_uni;
                    }
                }

                if (e.Column == col_in_cantidad || e.Column == col_in_por_ganancia || e.Column == col_in_precio_uni)
                {
                    row.in_valor_ganancia = row.in_precio_uni * (row.in_por_ganancia / 100);
                    row.in_precio_total = (row.in_valor_ganancia + row.in_precio_uni) * row.in_cantidad;
                }
                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void calcular_totales()
        {
            try
            {
                double total_mo = 0;
                double total_lo = 0;
                double total_eg = 0;
                double total_in = 0;
                if (blst_liquidacion_mano_obra.Count != 0)
                    total_mo = blst_liquidacion_mano_obra.Sum(q => q.mo_precio_total);
                if (blst_liquidacion_logistica.Count != 0)
                    total_lo = blst_liquidacion_logistica.Sum(q => q.lo_precio_total);
                if (blst_liquidacion_egresos.Where(q=>q.eg_estado == true).Count() != 0 )
                    total_eg = blst_liquidacion_egresos.Where(q=>q.eg_estado == true).Sum(q => q.eg_precio_total);
                if (blst_liquidacion_ingresos.Where(q => q.in_estado == true).Count() != 0)
                    total_in = blst_liquidacion_ingresos.Where(q => q.in_estado == true).Sum(q => q.in_precio_total);

                double subtotal = total_mo + total_lo + total_eg + total_in;
                txt_subtotal.Text = Math.Round(subtotal, 2, MidpointRounding.AwayFromZero).ToString();
                double por_iva = Convert.ToDouble(txt_por_iva.Text);
                double valor_iva = subtotal * (por_iva / 100);
                txt_valor_iva.Text = Math.Round(valor_iva, 2, MidpointRounding.AwayFromZero).ToString();
                double total = subtotal + valor_iva;
                txt_total.Text = Math.Round(total, 2, MidpointRounding.AwayFromZero).ToString();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_impuesto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_impuesto.EditValue == null)
                {
                    cmb_impuesto.EditValue = param.iva.IdCod_Impuesto;
                }else
                    txt_por_iva.Text = lst_impuestos.FirstOrDefault(q=>q.IdCod_Impuesto == cmb_impuesto.EditValue.ToString()).porcentaje.ToString();

                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_punto_cargo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    return;
                }

                if (cmb_punto_cargo.EditValue == null)
                {
                    ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo(null);
                }
                else
                {
                    int IdPunto_cargo = Convert.ToInt32(cmb_punto_cargo.EditValue);
                    ct_punto_cargo_Info info_punto_cargo = lst_punto_cargo.FirstOrDefault(q => q.IdPunto_cargo == IdPunto_cargo);
                    if (info_punto_cargo != null)
                    {
                        ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo(info_punto_cargo.IdCentroCosto_Scc);
                        ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo_sub_centro_costo(info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc);
                    }
                    else
                        ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo(null);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucFa_Cliente_x_centro_costo_cmb1_event_delegate_cmb_Centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string IdCentroCosto = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo() == null ? "" :ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo().IdCentroCosto;
                lst_ruta_x_centro_costo = bus_ruta_x_centro_costo.get_list(param.IdEmpresa, IdCentroCosto,false);
                cmb_ruta.DataSource = lst_ruta_x_centro_costo;
            }
           catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_egresos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info row = (fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info)gridView_egresos.GetRow(e.RowHandle);
                if (row == null) return;
                if (Math.Round(row.pr_precio_publico, 2, MidpointRounding.AwayFromZero) != Math.Round(row.eg_precio_uni, 2, MidpointRounding.AwayFromZero))
                {
                    e.Appearance.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    e.Appearance.ForeColor = Color.Black;
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_ingresos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info row = (fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info)gridView_ingresos.GetRow(e.RowHandle);
                if (row == null) return;
                if (Math.Round(row.pr_precio_publico, 2, MidpointRounding.AwayFromZero) != Math.Round(row.in_precio_uni, 2, MidpointRounding.AwayFromZero))
                {
                    e.Appearance.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    e.Appearance.ForeColor = Color.Black;
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_imagen_Click(object sender, EventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_det_mano_obra_Info row = (fa_liquidacion_x_punto_cargo_det_mano_obra_Info)gridView_mano_obra.GetFocusedRow();
                frmFa_liquidacion_x_punto_cargo_mano_obra_det frm = new frmFa_liquidacion_x_punto_cargo_mano_obra_det();
                frm.set_info(row);
                frm.ShowDialog();
                if (frm.Dialog_result == DialogResult.OK)
                    row = frm.get_info();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_mano_obra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_mano_obra.DeleteSelectedRows();
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

        private void gridView_logistica_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_logistica.DeleteSelectedRows();
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

        private void gridView_mano_obra_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_logistica_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                calcular_totales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_recalcular_Click(object sender, EventArgs e)
        {
            try
            {
                calcular_totales();
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
