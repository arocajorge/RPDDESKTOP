using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.Inventario;
using Core.Erp.Reportes.Facturacion;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_proforma_mant : Form
    {
        #region Variables
        fa_proforma_Info info_proforma;
        fa_proforma_Bus bus_proforma;
        cl_parametrosGenerales_Bus param;
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        List<tb_sis_impuesto_Info> lst_impuesto;
        tb_sis_impuesto_Bus bus_impuesto;
        List<in_Producto_Info> lst_producto;
        in_producto_Bus bus_producto;
        fa_parametro_info info_fa_param;
        fa_parametro_Bus bus_fa_param;
        List<fa_TerminoPago_Info> lst_termino_pago;
        fa_TerminoPago_Bus bus_termino_pago;
        BindingList<fa_proforma_det_Info> blst_det;
        List<tb_Sucursal_Info> lst_sucursal;
        tb_Sucursal_Bus bus_sucursal;
        fa_proforma_det_Bus bus_proforma_det;
        List<tb_Bodega_Info> lst_bodega;
        tb_Bodega_Bus bus_bodega;
        List<fa_Vendedor_Info> lst_vendedor;
        fa_Vendedor_Bus bus_vendedor;
        #endregion

        #region delegados
        public delegate void delegate_frmFa_proforma_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmFa_proforma_mant_FormClosed event_delegate_frmFa_proforma_mant_FormClosed;

        void frmFa_proforma_mant_event_delegate_frmFa_proforma_mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion

        public frmFa_proforma_mant()
        {
            InitializeComponent();
            info_proforma = new fa_proforma_Info();
            bus_proforma = new fa_proforma_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            event_delegate_frmFa_proforma_mant_FormClosed += frmFa_proforma_mant_event_delegate_frmFa_proforma_mant_FormClosed;
            lst_impuesto = new List<tb_sis_impuesto_Info>();
            bus_impuesto = new tb_sis_impuesto_Bus();
            lst_producto = new List<in_Producto_Info>();
            bus_producto = new in_producto_Bus();
            info_fa_param = new fa_parametro_info();
            bus_fa_param = new fa_parametro_Bus();
            lst_termino_pago = new List<fa_TerminoPago_Info>();
            bus_termino_pago = new fa_TerminoPago_Bus();
            blst_det = new BindingList<fa_proforma_det_Info>();
            lst_sucursal = new List<tb_Sucursal_Info>();
            bus_sucursal = new tb_Sucursal_Bus();
            bus_proforma_det = new fa_proforma_det_Bus();
            lst_bodega = new List<tb_Bodega_Info>();
            bus_bodega = new tb_Bodega_Bus();
            lst_vendedor = new List<fa_Vendedor_Info>();
            bus_vendedor = new fa_Vendedor_Bus();
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
                        uc_menu.Visible_bntAnular = false;
                        uc_menu.Visible_bntGuardar_y_Salir = true;
                        uc_menu.Visible_btnGuardar = true;
                        uc_menu.Visible_bntLimpiar = true;
                        uc_menu.Visible_bntImprimir = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        uc_menu.Visible_bntAnular = false;
                        uc_menu.Visible_bntGuardar_y_Salir = true;
                        uc_menu.Visible_btnGuardar = true;
                        uc_menu.Visible_bntLimpiar = true;
                        uc_menu.Visible_bntImprimir = true;
                        set_info_in_controls();
                        cmb_sucursal.Properties.ReadOnly = true;
                        cmb_bodega.Properties.ReadOnly = true;
                        cmb_cliente.Perfil_Lectura();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        uc_menu.Visible_bntAnular = true;
                        uc_menu.Visible_bntGuardar_y_Salir = false;
                        uc_menu.Visible_btnGuardar = false;
                        uc_menu.Visible_bntLimpiar = false;
                        uc_menu.Visible_bntImprimir = true;
                        set_info_in_controls();
                        cmb_sucursal.Properties.ReadOnly = true;
                        cmb_bodega.Properties.ReadOnly = true;
                        cmb_cliente.Perfil_Lectura();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        uc_menu.Visible_bntAnular = false;
                        uc_menu.Visible_bntGuardar_y_Salir = false;
                        uc_menu.Visible_btnGuardar = false;
                        uc_menu.Visible_bntLimpiar = false;
                        uc_menu.Visible_bntImprimir = true;
                        set_info_in_controls();
                        cmb_sucursal.Properties.ReadOnly = true;
                        cmb_bodega.Properties.ReadOnly = true;
                        cmb_cliente.Perfil_Lectura();
                        break;                 
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_info(fa_proforma_Info _info)
        {
            try
            {
                info_proforma = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimir()
        {
            try
            {
                DialogResult result = MessageBox.Show("Impresión formato normal [SI]\nImpresión formato con imágen[NO]\nNo imprimir [CANCELAR]", param.Nombre_sistema, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.No:
                        XFAC_Rpt012_rpt_detalle_producto rpt_d = new XFAC_Rpt012_rpt_detalle_producto();
                        rpt_d.p_IdSucursal.Value = info_proforma.IdSucursal;
                        rpt_d.p_IdProforma.Value = info_proforma.IdProforma;
                        rpt_d.ShowPreviewDialog();
                        break;
                    case DialogResult.Yes:
                        XFAC_Rpt012_Rpt rpt = new XFAC_Rpt012_Rpt();
                        rpt.p_IdSucursal.Value = info_proforma.IdSucursal;
                        rpt.p_IdProforma.Value = info_proforma.IdProforma;
                        rpt.ShowPreviewDialog();
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
                txt_id_proforma.Text = info_proforma.IdProforma.ToString();
                txt_observacion.Text = info_proforma.pf_observacion;
                cmb_sucursal.EditValue = info_proforma.IdSucursal;
                cmb_bodega.EditValue = info_proforma.IdBodega;
                cmb_cliente.set_ClienteInfo(info_proforma.IdCliente);
                cmb_termino_pago.EditValue = info_proforma.IdTerminoPago;
                de_fecha.EditValue = info_proforma.pf_fecha;
                txt_codigo.Text = info_proforma.pf_codigo;
                spinEditDiasPlazo.EditValue = info_proforma.pf_plazo;
                de_fecha_vcto.EditValue = info_proforma.pf_fecha_vcto;
                cmb_vendedor.EditValue = info_proforma.IdVendedor;
                txt_atencion_a.Text = info_proforma.pf_atencion_a;
                txt_dias_entrega.Text = info_proforma.pr_dias_entrega.ToString();
                blst_det = new BindingList<fa_proforma_det_Info>(bus_proforma_det.get_list(info_proforma.IdEmpresa, info_proforma.IdSucursal, info_proforma.IdProforma));
                gridControl_detalle.DataSource = blst_det;

                lbl_anulado.Visible = !info_proforma.estado;
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
                txt_id_proforma.Text = "";
                txt_observacion.Text = "";
                cmb_sucursal.EditValue = null;
                cmb_cliente.set_ClienteInfo(0);
                cmb_termino_pago.EditValue = null;
                de_fecha.EditValue = DateTime.Now.Date;
                txt_codigo.Text = "";
                spinEditDiasPlazo.EditValue = 0;
                de_fecha_vcto.EditValue = DateTime.Now.Date;
                blst_det = new BindingList<fa_proforma_det_Info>();
                gridControl_detalle.DataSource = blst_det;
                cmb_vendedor.EditValue = null;
                txt_atencion_a.Text = "";
                lbl_anulado.Visible = false;
                cargar_combos();
                txt_dias_entrega.Text = "0";
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                info_fa_param = bus_fa_param.Get_Info_parametro(param.IdEmpresa);
                                
                lst_termino_pago = bus_termino_pago.Get_List_TerminoPago();
                cmb_termino_pago.Properties.DataSource = lst_termino_pago;

                de_fecha.DateTime = DateTime.Now.Date;
                spinEditDiasPlazo.EditValue = 1;

                lst_impuesto = bus_impuesto.Get_List_impuesto("IVA");
                cmb_impuesto.DataSource = lst_impuesto;

                lst_producto = bus_producto.Get_list_Producto_modulo_x_Ventas(param.IdEmpresa);
                cmb_producto_det.DataSource = lst_producto;

                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.Properties.DataSource = lst_sucursal;
                cmb_sucursal.EditValue = param.IdSucursal;

                lst_vendedor = bus_vendedor.Get_List_Vendedores(param.IdEmpresa);
                cmb_vendedor.Properties.DataSource = lst_vendedor;

                col_precio.OptionsColumn.AllowEdit = false;

                blst_det = new BindingList<fa_proforma_det_Info>();
                gridControl_detalle.DataSource = blst_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmFa_proforma_mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFa_proforma_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmFa_proforma_mant_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_proforma_det_Info row = (fa_proforma_det_Info)gridView_detalle.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_IdProducto)
                {
                    in_Producto_Info row_producto = lst_producto.FirstOrDefault(q => q.IdProducto == row.IdProducto);
                    if (row_producto == null)
                        return;

                    #region Ver lote

                    if (row_producto.IdProducto_padre != null)
                    {

                        row_producto.IdSucursal = Convert.ToInt32(cmb_sucursal.EditValue);
                        row_producto.IdBodega = Convert.ToInt32(cmb_bodega.EditValue);
                        FrmIn_producto_asignacion_lote frm = new FrmIn_producto_asignacion_lote();
                        frm.set_funcion(Cl_Enumeradores.eFuncion_pantalla_lote.SELECCIONAR);
                        frm.set_info(Convert.ToDecimal(row_producto.IdProducto_padre), row_producto.IdSucursal, row_producto.IdBodega);
                        frm.ShowDialog();
                        if (frm.Result == System.Windows.Forms.DialogResult.OK)
                        {
                            in_producto_lote info_retorno = frm.get_info_retorno();
                            if (info_retorno == null)
                            {
                                MessageBox.Show("No ha seleccionado ningún lote", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            agregar_producto_en_combo(info_retorno.IdProducto == null ? 0 : Convert.ToDecimal(info_retorno.IdProducto));
                            int cont = lst_producto.Where(q => q.IdProducto == info_retorno.IdProducto).Count();
                            if (cont == 0)
                            {
                                MessageBox.Show("El producto seleccionado no esta habilitado para facturacion, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            row_producto = lst_producto.FirstOrDefault(q => q.IdProducto == info_retorno.IdProducto);
                            row.IdProducto = info_retorno.IdProducto == null ? row_producto.IdProducto : Convert.ToDecimal(info_retorno.IdProducto);
                        }
                    }

                    #endregion

                    int nivel_precio = (cmb_cliente.get_ClienteInfo().NivelPrecio == null || cmb_cliente.get_ClienteInfo().NivelPrecio == 0) ? 1 : Convert.ToInt32(cmb_cliente.get_ClienteInfo().NivelPrecio);
                    switch (nivel_precio)
                    {
                        case 1:
                            row.pd_precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1);
                            break;
                        case 2:
                            row.pd_precio = row_producto.precio_2 == null ? (row.pd_precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1)) : Convert.ToDouble(row_producto.precio_2);
                            break;
                        case 3:
                            row.pd_precio = row_producto.precio_3 == null ? (row.pd_precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1)) : Convert.ToDouble(row_producto.precio_3);
                            break;
                        case 4:
                            row.pd_precio = row_producto.precio_4 == null ? (row.pd_precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1)) : Convert.ToDouble(row_producto.precio_4);
                            break;
                        case 5:
                            row.pd_precio = row_producto.precio_5 == null ? (row.pd_precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1)) : Convert.ToDouble(row_producto.precio_5);
                            break;
                    }
                    row.IdCod_Impuesto = row_producto.IdCod_Impuesto_Iva;
                    tb_sis_impuesto_Info row_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto);
                    if (row_impuesto != null)
                        row.pd_por_iva = row_impuesto.porcentaje;
                }

                if (e.Column == col_cantidad || e.Column == col_precio || e.Column == col_por_descuento)
                {
                    row.pd_descuento_uni = Math.Round((row.pd_precio * row.pd_por_descuento_uni) / 100, 2, MidpointRounding.AwayFromZero);
                    row.pd_precio_final = row.pd_precio - row.pd_descuento_uni;
                    row.pd_subtotal = row.pd_cantidad * row.pd_precio_final;
                    row.pd_iva = Math.Round(Convert.ToDouble(row.pd_subtotal * (row.pd_por_iva / 100)), 2, MidpointRounding.AwayFromZero);
                    row.pd_total = row.pd_subtotal + row.pd_iva;
                }

                if (e.Column == col_impuesto)
                {
                    tb_sis_impuesto_Info row_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto);
                    if (row_impuesto != null)
                    {
                        row.pd_por_iva = row_impuesto.porcentaje;
                    }
                    row.pd_iva = Math.Round(Convert.ToDouble(row.pd_subtotal * (row.pd_por_iva / 100)), 2, MidpointRounding.AwayFromZero);
                    row.pd_total = row.pd_subtotal + row.pd_iva;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_termino_pago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_termino_pago.EditValue != null)
                {
                    fa_TerminoPago_Info Info_TerminoPago = new fa_TerminoPago_Info();
                    Info_TerminoPago = lst_termino_pago.Where(q => q.IdTerminoPago == Convert.ToString(cmb_termino_pago.EditValue)).FirstOrDefault();
                    spinEditDiasPlazo.EditValue = Info_TerminoPago.Dias_Vct;
                }
                else
                {
                    spinEditDiasPlazo.EditValue = 1;
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

        private void de_fecha_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spinEditDiasPlazo_EditValueChanged(null, null);
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

        private void spinEditDiasPlazo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (spinEditDiasPlazo.EditValue != null)
                {
                    if (spinEditDiasPlazo.Text != "")
                    {
                        de_fecha_vcto.DateTime = de_fecha.DateTime.AddDays(Convert.ToInt32(spinEditDiasPlazo.EditValue));
                    }
                }
                else
                {
                    de_fecha_vcto.DateTime = DateTime.Now.Date;
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

        private bool validar()
        {
            try
            {
                txt_id_proforma.Focus();
                if (cmb_sucursal.EditValue == null)
                {
                    MessageBox.Show("Seleccione la sucursal",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_bodega.EditValue == null)
                {
                    MessageBox.Show("Seleccione la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_cliente.get_ClienteInfo().IdCliente == 0)
                {
                    MessageBox.Show("Seleccione el cliente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_termino_pago.EditValue == null)
                {
                    MessageBox.Show("Seleccione el término de pago",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_vendedor.EditValue == null)
                {
                    MessageBox.Show("Seleccione el vendedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_det.Where(q=>q.IdProducto!= 0).Count() == 0)
                {
                    MessageBox.Show("Ingrese el detalle de la proforma",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in blst_det.Where(q => q.IdProducto != 0).ToList())
                {
                    if (item.pd_cantidad == 0)
                    {
                        MessageBox.Show("Existen productos con cantidad 0 en el detalle",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return false;    
                    }
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

        private void get_info()
        {
            try
            {
                info_proforma.IdEmpresa = param.IdEmpresa;
                info_proforma.IdProforma = txt_id_proforma.Text == "" ? 0 : Convert.ToDecimal(txt_id_proforma.Text);
                info_proforma.IdSucursal = Convert.ToInt32(cmb_sucursal.EditValue);
                info_proforma.IdBodega = Convert.ToInt32(cmb_bodega.EditValue);
                info_proforma.IdCliente = cmb_cliente.get_ClienteInfo().IdCliente;
                info_proforma.IdTerminoPago = cmb_termino_pago.EditValue.ToString();
                info_proforma.pf_fecha = de_fecha.DateTime.Date;
                info_proforma.pf_plazo = Convert.ToInt32(spinEditDiasPlazo.EditValue);
                info_proforma.pf_fecha_vcto = de_fecha_vcto.DateTime.Date;
                info_proforma.pf_observacion = txt_observacion.Text;
                info_proforma.pf_codigo = txt_codigo.Text;
                info_proforma.pf_atencion_a = txt_atencion_a.Text;
                info_proforma.IdVendedor = Convert.ToInt32(cmb_vendedor.EditValue);
                info_proforma.pr_dias_entrega = string.IsNullOrEmpty(txt_dias_entrega.Text) ? 0 : Convert.ToInt32(txt_dias_entrega.Text);
                info_proforma.lst_det = new List<fa_proforma_det_Info>(blst_det.Where(q=>q.IdProducto != 0).ToList());
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
                bool res = false;

                if (bus_proforma.guardarDB(info_proforma))
                {
                    MessageBox.Show("Registro guardado exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    res = true;

                    if (MessageBox.Show("Desea imprimir la proforma?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        imprimir();
                    }
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

        private bool modificarDB()
        {
            try
            {
                bool res = false;

                if (bus_proforma.modificarDB(info_proforma))
                {
                    MessageBox.Show("Registro modificado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;

                    if (MessageBox.Show("Desea imprimir la proforma?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        imprimir();
                    }
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

        private bool anularDB()
        {
            try
            {
                bool res = false;

                if (bus_proforma.anularDB(info_proforma))
                {
                    MessageBox.Show("Registro anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void uc_menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir();
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_cliente_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fa_Cliente_Info cliente = cmb_cliente.get_ClienteInfo();

                if (cliente != null && cliente.IdEmpresa != 0)
                {
                    cmb_termino_pago.EditValue = cliente.IdTipoCredito;
                    txt_atencion_a.Text = cliente.Persona_Info.pe_nombreCompleto;
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

        private void cmb_sucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_sucursal.EditValue == null)
                    lst_bodega = new List<tb_Bodega_Info>();
                else
                    lst_bodega = bus_bodega.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(cmb_sucursal.EditValue));
                cmb_bodega.Properties.DataSource = lst_bodega;
                cmb_bodega.EditValue = null;
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
        
        private void txt_codigo_barra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txt_codigo_barra.Text) && e.KeyChar == (char)Keys.Enter && cmb_bodega.EditValue != null)
                {
                    in_Producto_Info row_producto = lst_producto.FirstOrDefault(q => q.pr_codigo_barra == txt_codigo_barra.Text.ToString());
                    if (row_producto != null)
                        if (row_producto.IdProducto_padre != null)
                        {

                            tb_Bodega_Info row_bodega = lst_bodega.FirstOrDefault(q => q.IdBodega == Convert.ToInt32(cmb_bodega.EditValue));
                            if (row_bodega == null)
                                return;
                            row_producto.IdSucursal = row_bodega.IdSucursal;
                            row_producto.IdBodega = Convert.ToInt32(row_bodega.IdBodega);
                            FrmIn_producto_asignacion_lote frm = new FrmIn_producto_asignacion_lote();
                            frm.set_funcion(Cl_Enumeradores.eFuncion_pantalla_lote.SELECCIONAR);
                            frm.set_info(Convert.ToDecimal(row_producto.IdProducto_padre), row_producto.IdSucursal, row_producto.IdBodega);
                            frm.ShowDialog();
                            if (frm.Result == System.Windows.Forms.DialogResult.OK)
                            {
                                in_producto_lote info_retorno = frm.get_info_retorno();

                                row_producto = lst_producto.FirstOrDefault(q => q.IdProducto == info_retorno.IdProducto);
                                if (row_producto != null)
                                {
                                    int cont = blst_det.Where(q => q.IdProducto == row_producto.IdProducto).Count();
                                    if (cont > 0)
                                    {
                                        MessageBox.Show("El producto seleccionado ya existe en el detalle de la factura", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }

                                    for (int i = 0; i < gridView_detalle.RowCount; i++)
                                    {
                                        if (Convert.ToDecimal(gridView_detalle.GetRowCellValue(i, col_IdProducto)) == 0)
                                        {
                                            gridView_detalle.SetRowCellValue(i, col_IdProducto, row_producto.IdProducto);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    gridControl_detalle.DataSource = null;
                    gridControl_detalle.DataSource = blst_det;
                    txt_codigo_barra.Text = "";
                    txt_codigo_barra.Focus();
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

        private void btn_desbloquear_precios_Click(object sender, EventArgs e)
        {
            frmFa_clave_desbloqueo frm = new frmFa_clave_desbloqueo();
            frm.ShowDialog();
            if (frm.Result == System.Windows.Forms.DialogResult.Yes)
            {
                col_precio.OptionsColumn.AllowEdit = true;
            }else
                col_precio.OptionsColumn.AllowEdit = false;
        }

        private void ver_stock()
        {
            try
            {
                fa_factura_det_info row = (fa_factura_det_info)gridView_detalle.GetFocusedRow();
                if (row == null)
                    return;
                in_Producto_Info row_producto = row == null ? null : lst_producto.FirstOrDefault(q => q.IdProducto == row.IdProducto);

                #region Ver lote

                if (row_producto.IdProducto_padre != null)
                {
                    if (cmb_sucursal.EditValue == null || cmb_bodega.EditValue == null)
                        return;
                    row_producto.IdSucursal = Convert.ToInt32(cmb_sucursal.EditValue);
                    row_producto.IdBodega = Convert.ToInt32(cmb_bodega.EditValue);
                    FrmIn_producto_asignacion_lote frm = new FrmIn_producto_asignacion_lote();
                    frm.set_funcion(Cl_Enumeradores.eFuncion_pantalla_lote.SELECCIONAR);
                    frm.set_info(Convert.ToDecimal(row_producto.IdProducto_padre), row_producto.IdSucursal, row_producto.IdBodega);
                    frm.ShowDialog();
                    if (frm.Result == System.Windows.Forms.DialogResult.OK)
                    {
                        in_producto_lote info_retorno = frm.get_info_retorno();
                        if (info_retorno == null)
                        {
                            MessageBox.Show("No ha seleccionado ningún lote", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        agregar_producto_en_combo(info_retorno.IdProducto == null ? 0 : Convert.ToDecimal(info_retorno.IdProducto));
                        int cont = lst_producto.Where(q => q.IdProducto == info_retorno.IdProducto).Count();
                        if (cont == 0)
                        {
                            MessageBox.Show("El producto seleccionado no esta habilitado para facturacion, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        row_producto = lst_producto.FirstOrDefault(q => q.IdProducto == info_retorno.IdProducto);
                        row.IdProducto = info_retorno.IdProducto == null ? row_producto.IdProducto : Convert.ToDecimal(info_retorno.IdProducto);
                        gridView_detalle.RefreshRow(gridView_detalle.FocusedRowHandle);
                    }
                }

                #endregion
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

        private void agregar_producto_en_combo(decimal IdProducto)
        {
            try
            {
                if (lst_producto.Where(q => q.IdProducto == IdProducto).Count() > 0)
                    return;
                in_Producto_Info i_producto = bus_producto.Get_info_Producto_para_combo(param.IdEmpresa, IdProducto);
                if (i_producto == null)
                    return;
                lst_producto.Add(i_producto);
                cmb_producto_det.DataSource = lst_producto;
                gridView_detalle.RefreshRow(gridView_detalle.FocusedRowHandle);
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

        private void cmb_imagen_Click(object sender, EventArgs e)
        {
            try
            {
                ver_stock();
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
        private void cmb_imagen_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ver_stock();
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

        private void gridView_detalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿Está seguro que desea Eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridView_detalle.DeleteSelectedRows();
                }
            }
        }
    }
}
