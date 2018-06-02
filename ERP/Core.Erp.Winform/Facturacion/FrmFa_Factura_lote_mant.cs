using Core.Erp.Business.Caja;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Caja;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Reportes.Facturacion;
using System.IO;
using Core.Erp.Winform.General;
using Core.Erp.Winform.CuentasxCobrar;
using Core.Erp.Winform.Inventario;

namespace Core.Erp.Winform.Facturacion
{
    public partial class FrmFa_Factura_lote_mant : Form
    {
        #region Declaracion Variable
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param;
        fa_factura_Bus bus_factura;
        List<fa_factura_Info> lst_factura;
        Cl_Enumeradores.eTipo_action Accion;
        fa_factura_Info info_factura;
        List<fa_PuntoVta_Info> lst_punto_venta;
        fa_PuntoVta_Bus bus_punto_venta;
        List<fa_Vendedor_Info> lst_vendedor;
        fa_Vendedor_Bus bus_vendedor;
        List<caj_Caja_Info> lst_caja;
        caj_Caja_Bus bus_caja;
        List<fa_TerminoPago_Info> lst_termino_pago;
        fa_TerminoPago_Bus bus_termino_pago;
        fa_parametro_info info_fa_param;
        fa_parametro_Bus bus_fa_param;
        BindingList<fa_factura_det_info> blst_det;
        List<in_Producto_Info> lst_producto;
        in_producto_Bus bus_producto;
        List<tb_sis_impuesto_Info> lst_impuesto;
        tb_sis_impuesto_Bus bus_impuesto;
        string MensajeError;
        static string result = Path.GetTempPath();
        String RootReporte = result + @"Factura.repx";
        fa_factura_det_Bus bus_factura_det;
        List<fa_cliente_contactos_Info> lst_contacto;
        fa_cliente_contactos_Bus bus_contacto;
        fa_cuotas_x_doc_Bus bus_cuotas;
        BindingList<fa_cuotas_x_doc_Info> blst_cuotas;
        #endregion

        #region delegado
        public delegate void delegate_FrmFa_Factura_lote_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FrmFa_Factura_lote_mant_FormClosed event_delegate_FrmFa_Factura_lote_mant_FormClosed;
        #endregion

        public FrmFa_Factura_lote_mant()
        {
            InitializeComponent();
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_factura = new fa_factura_Bus();
            lst_factura = new List<fa_factura_Info>();
            info_factura = new fa_factura_Info();
            lst_punto_venta = new List<fa_PuntoVta_Info>();
            bus_punto_venta = new fa_PuntoVta_Bus();
            lst_vendedor = new List<fa_Vendedor_Info>();
            bus_vendedor = new fa_Vendedor_Bus();
            lst_caja = new List<caj_Caja_Info>();
            bus_caja = new caj_Caja_Bus();
            lst_termino_pago = new List<fa_TerminoPago_Info>();
            bus_termino_pago = new fa_TerminoPago_Bus();
            info_fa_param = new fa_parametro_info();
            bus_fa_param = new fa_parametro_Bus();
            blst_det = new BindingList<fa_factura_det_info>();
            lst_producto = new List<in_Producto_Info>();
            bus_producto = new in_producto_Bus();
            lst_impuesto = new List<tb_sis_impuesto_Info>();
            bus_impuesto = new tb_sis_impuesto_Bus();
            bus_factura_det = new fa_factura_det_Bus();
            lst_contacto = new List<fa_cliente_contactos_Info>();
            bus_contacto = new fa_cliente_contactos_Bus();
            blst_cuotas = new BindingList<fa_cuotas_x_doc_Info>();
            bus_cuotas = new fa_cuotas_x_doc_Bus();
            MensajeError = "";
            event_delegate_FrmFa_Factura_lote_mant_FormClosed += FrmFa_Factura_lote_mant_event_delegate_FrmFa_Factura_lote_mant_FormClosed;
        }

        void FrmFa_Factura_lote_mant_event_delegate_FrmFa_Factura_lote_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FrmFa_Factura_lote_mant_Load(object sender, EventArgs e)
        {
            try
            {
                blst_det = new BindingList<fa_factura_det_info>();
                gridControl_detalle.DataSource = blst_det;
                blst_cuotas = new BindingList<fa_cuotas_x_doc_Info>();
                gridControl_detalle_cuotas.DataSource = blst_cuotas;
                cargar_combos();
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

        private void cargar_combos()
        {
            try
            {
                info_fa_param = bus_fa_param.Get_Info_parametro(param.IdEmpresa);

                lst_vendedor = bus_vendedor.Get_List_Vendedores(param.IdEmpresa);
                cmb_vendedor.Properties.DataSource = lst_vendedor;
                if (Accion == Cl_Enumeradores.eTipo_action.grabar && lst_vendedor.Count > 0)
                    cmb_vendedor.EditValue = lst_vendedor.First().IdVendedor;

                lst_punto_venta = bus_punto_venta.Get_List_PuntoVta(param.IdEmpresa);
                cmb_punto_venta.Properties.DataSource = lst_punto_venta;
                if (lst_punto_venta.FirstOrDefault(q => q.IdSucursal == param.IdSucursal) != null) 
                    cmb_punto_venta.EditValue = lst_punto_venta.FirstOrDefault(q => q.IdSucursal == param.IdSucursal).IdPuntoVta;

                lst_caja = bus_caja.Get_list_caja(param.IdEmpresa, ref MensajeError);
                cmb_caja.Properties.DataSource = lst_caja;
                cmb_caja.EditValue = info_fa_param.IdCaja_Default_Factura;

                lst_termino_pago = bus_termino_pago.Get_List_TerminoPago();
                cmb_termino_pago.Properties.DataSource = lst_termino_pago;

                ucFa_FormaPago_x_Factura.Cargar_grid();
                UCNumDoc.Cargar_parametros();
                de_fecha.DateTime = DateTime.Now.Date;
                spinEditDiasPlazo.EditValue = 1;

                lst_impuesto = bus_impuesto.Get_List_impuesto("IVA");
                cmb_impuesto.DataSource = lst_impuesto;

                lst_producto = bus_producto.Get_list_Producto_modulo_x_Ventas(param.IdEmpresa);
                cmb_producto_det.DataSource = lst_producto;

                col_precio.OptionsColumn.AllowEdit = false;
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

        public void set_info(fa_factura_Info _info)
        {
            try
            {
                info_factura = _info;
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

        public void set_accion(Cl_Enumeradores.eTipo_action _accion)
        {
            try
            {
                Accion = _accion;
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
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;

                        cmb_caja.Properties.ReadOnly = false;
                        cmb_cliente.cmb_cliente.Properties.ReadOnly = false;
                        cmb_punto_venta.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;

                        cmb_caja.Properties.ReadOnly = true;
                        cmb_cliente.cmb_cliente.Properties.ReadOnly = false;
                        cmb_punto_venta.Properties.ReadOnly = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;

                        cmb_caja.Properties.ReadOnly = true;
                        cmb_cliente.cmb_cliente.Properties.ReadOnly = true;
                        cmb_punto_venta.Properties.ReadOnly = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                      
                        cmb_caja.Properties.ReadOnly = true;
                        cmb_cliente.cmb_cliente.Properties.ReadOnly = true;
                        cmb_punto_venta.Properties.ReadOnly = true;
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

        private void limpiar()
        {
            try
            {
                txtIdFactura.Text = "";
                txt_observacion.Text = "";
                cmb_caja.EditValue = null;
                cmb_cliente.set_ClienteInfo(0);
                cmb_punto_venta.EditValue = null;
                cmb_vendedor.EditValue = null;
                cmb_termino_pago.EditValue = null;
                de_fecha.EditValue = DateTime.Now.Date;
                de_fecha_vcto.EditValue = DateTime.Now.Date;

                UCNumDoc.Set_Serie_Num_Documento("", "", "");
                lblAnulado.Visible = false;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                blst_det = new BindingList<fa_factura_det_info>();
                gridControl_detalle.DataSource = blst_det;
                cargar_combos();
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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
                if (accion_guardar())
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
                if (accion_guardar())
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

        private void cmb_punto_venta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargarNumDoc();                
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

        public void cargarNumDoc()
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar || Accion == Cl_Enumeradores.eTipo_action.duplicar)
                {
                    UCNumDoc.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.FACT;
                    if (cmb_punto_venta.EditValue != null)
                    {
                        fa_PuntoVta_Info pto_vta = lst_punto_venta.FirstOrDefault(q => q.IdPuntoVta == Convert.ToInt32(cmb_punto_venta.EditValue));
                        UCNumDoc.IdEstablecimiento = pto_vta.Su_CodigoEstablecimiento;
                        UCNumDoc.IdPuntoEmision = pto_vta.cod_PuntoVta;
                        UCNumDoc.Get_Primer_Documento_no_usado();
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

        private void cmb_cliente_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fa_Cliente_Info cliente = cmb_cliente.get_ClienteInfo();
                lst_contacto = new List<fa_cliente_contactos_Info>();
                if (cliente!= null && cliente.IdEmpresa != 0)
                {
                    ucFa_FormaPago_x_Factura.set_forma_pago(cliente.FormaPago);
                    cmb_termino_pago.EditValue = cliente.IdTipoCredito;
                    lst_contacto = bus_contacto.get_list(param.IdEmpresa, cliente.IdCliente);                    
                    if (lst_contacto.Count != 0)
                        cmb_contacto.EditValue = lst_contacto.First().IdContacto;
                }
                cmb_contacto.Properties.DataSource = lst_contacto;
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

        private void cmb_termino_pago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_termino_pago.EditValue != null)
                {
                    fa_TerminoPago_Info Info_TerminoPago = new fa_TerminoPago_Info();
                    Info_TerminoPago = lst_termino_pago.Where(q => q.IdTerminoPago == Convert.ToString(cmb_termino_pago.EditValue)).FirstOrDefault();
                    spinEditDiasPlazo.EditValue = Info_TerminoPago.Dias_Vct;
                    
                        crear_cuotas(Info_TerminoPago.IdTerminoPago);
                    
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

        private void crear_cuotas(string IdTerminoPago)
        {
            try
            {
                
                fa_TerminoPago_Distribucion_Bus bus_tdistribucion = new fa_TerminoPago_Distribucion_Bus();
                var lst_distribucion = bus_tdistribucion.Get_List_TerminoPago_Distribucion(IdTerminoPago);
                double total = blst_det.Sum(q=>q.vt_total);
                double valor_abono = string.IsNullOrEmpty(txt_valor_abono.Text) ? 0 : Convert.ToDouble(txt_valor_abono.Text);                
                double valor_a_distribuir = total - valor_abono;
                DateTime? primera_cuota = null;
                if (lst_distribucion.Count > 0)
                {
                    primera_cuota = de_fecha.DateTime.AddDays(lst_distribucion.Where(q => q.Secuencia == 1).FirstOrDefault().Num_Dias_Vcto);
                    de_fecha_primer_pago.DateTime = primera_cuota == null ? de_fecha.DateTime : Convert.ToDateTime(primera_cuota);
                }
                blst_cuotas = new BindingList<fa_cuotas_x_doc_Info>();
                if(primera_cuota == null)
                    primera_cuota = de_fecha.DateTime;
                int num_cuota = 1;
                foreach (var item in lst_distribucion)
                {
                    fa_cuotas_x_doc_Info i_cuota = new fa_cuotas_x_doc_Info
                    {
                        valor_a_cobrar = valor_a_distribuir * (item.Por_distribucion/100),
                        fecha_vcto_cuota = num_cuota == 1 ? Convert.ToDateTime(primera_cuota) : Convert.ToDateTime(Convert.ToDateTime(primera_cuota).AddDays(item.Num_Dias_Vcto)),
                        num_cuota = num_cuota++,
                    };
                    blst_cuotas.Add(i_cuota);
                }
                gridControl_detalle_cuotas.DataSource = null;
                gridControl_detalle_cuotas.DataSource = blst_cuotas;                
            }
            catch (Exception)
            {
                
                throw;
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

        private void gridView_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_factura_det_info row = (fa_factura_det_info)gridView_detalle.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_IdProducto)
                {
                    in_Producto_Info row_producto = lst_producto.FirstOrDefault(q => q.IdProducto == row.IdProducto);
                    if (row_producto == null)
                        return;

                    #region Ver lote

                    if (row_producto.IdProducto_padre != null)
                    {
                        if (cmb_punto_venta.EditValue == null)
                            return;
                        fa_PuntoVta_Info row_punto_venta = lst_punto_venta.FirstOrDefault(q => q.IdPuntoVta == Convert.ToInt32(cmb_punto_venta.EditValue));
                        row_producto.IdSucursal = row_punto_venta.IdSucursal;
                        row_producto.IdBodega = Convert.ToInt32(row_punto_venta.IdBodega);
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
                            row.vt_Precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1);
                            break;
                        case 2:
                            row.vt_Precio = row_producto.precio_2 == null ? (row.vt_Precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1)) : Convert.ToDouble(row_producto.precio_2);
                            break;
                        case 3:
                            row.vt_Precio = row_producto.precio_3 == null ? (row.vt_Precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1)) : Convert.ToDouble(row_producto.precio_3);
                            break;
                        case 4:
                            row.vt_Precio = row_producto.precio_4 == null ? (row.vt_Precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1)) : Convert.ToDouble(row_producto.precio_4);
                            break;
                        case 5:
                            row.vt_Precio = row_producto.precio_5 == null ? (row.vt_Precio = row_producto.precio_1 == null ? 0 : Convert.ToDouble(row_producto.precio_1)) : Convert.ToDouble(row_producto.precio_5);
                            break;
                    }
                    row.IdCod_Impuesto_Iva = row_producto.IdCod_Impuesto_Iva;
                    tb_sis_impuesto_Info row_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto_Iva);
                    if (row_impuesto != null)
                        row.vt_por_iva = row_impuesto.porcentaje;
                    row.vt_DescUnitario = Math.Round((row.vt_Precio * row.vt_PorDescUnitario) / 100, 2, MidpointRounding.AwayFromZero);
                    row.vt_PrecioFinal = row.vt_Precio - row.vt_DescUnitario;
                    row.vt_Subtotal = row.vt_cantidad * row.vt_PrecioFinal;
                    row.vt_iva = Math.Round(Convert.ToDouble(row.vt_Subtotal * (row.vt_por_iva / 100)), 2, MidpointRounding.AwayFromZero);
                    row.vt_total = row.vt_Subtotal + row.vt_iva;
                }

                if (e.Column == col_cantidad || e.Column == col_precio || e.Column == col_por_descuento)
                {
                    row.vt_DescUnitario = Math.Round((row.vt_Precio * row.vt_PorDescUnitario) / 100,2,MidpointRounding.AwayFromZero);
                    row.vt_PrecioFinal = row.vt_Precio - row.vt_DescUnitario;
                    row.vt_Subtotal = row.vt_cantidad * row.vt_PrecioFinal;
                    row.vt_iva = Math.Round(Convert.ToDouble(row.vt_Subtotal * (row.vt_por_iva / 100)), 2, MidpointRounding.AwayFromZero);
                    row.vt_total = row.vt_Subtotal + row.vt_iva;
                }

                if (e.Column == col_impuesto)
                {
                    tb_sis_impuesto_Info row_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto_Iva);
                    if (row_impuesto != null)
                    {
                        row.vt_por_iva = row_impuesto.porcentaje;
                    }
                    row.vt_iva = Math.Round(Convert.ToDouble(row.vt_Subtotal * (row.vt_por_iva / 100)), 2, MidpointRounding.AwayFromZero);
                    row.vt_total = row.vt_Subtotal + row.vt_iva;
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

        private void get_info()
        {
            try
            {
                info_factura = new fa_factura_Info();
                info_factura.IdEmpresa = param.IdEmpresa;
                fa_PuntoVta_Info pto_vta = lst_punto_venta.FirstOrDefault(q=>q.IdPuntoVta == Convert.ToInt32(cmb_punto_venta.EditValue));
                info_factura.IdSucursal = pto_vta.IdSucursal;
                info_factura.IdBodega = Convert.ToInt32(pto_vta.IdBodega);
                info_factura.IdCbteVta = txtIdFactura.Text == "" ? 0 : Convert.ToDecimal(txtIdFactura.Text);
                info_factura.IdPuntoVta = pto_vta.IdPuntoVta;
                
                info_factura.vt_tipoDoc = UCNumDoc.Get_Info_Talonario().CodDocumentoTipo;
                info_factura.vt_serie1 = UCNumDoc.Get_Info_Talonario().Establecimiento;
                info_factura.vt_serie2 = UCNumDoc.Get_Info_Talonario().PuntoEmision;
                info_factura.vt_NumFactura = UCNumDoc.Get_Info_Talonario().NumDocumento;
                info_factura.vt_autorizacion = UCNumDoc.Get_Info_Talonario().NumAutorizacion;

                info_factura.IdCliente = cmb_cliente.get_ClienteInfo().IdCliente;
                info_factura.IdContacto = Convert.ToInt32(cmb_contacto.EditValue);
                info_factura.IdVendedor = Convert.ToInt32(cmb_vendedor.EditValue);
                info_factura.vt_fecha = de_fecha.DateTime.Date;
                info_factura.vt_fech_venc = de_fecha_vcto.DateTime.Date;
                info_factura.vt_plazo = Convert.ToInt32(spinEditDiasPlazo.EditValue);
                info_factura.vt_tipo_venta = cmb_termino_pago.EditValue.ToString();
                info_factura.vt_Observacion = txt_observacion.Text;
                if (de_fecha_primer_pago.EditValue != null)
                    info_factura.fecha_primera_cuota = de_fecha_primer_pago.DateTime.Date;
                else
                    info_factura.fecha_primera_cuota = null;
                info_factura.valor_abono = txt_valor_abono.Text == "" ? 0 : Convert.ToDouble(txt_valor_abono.Text);
                info_factura.IdPeriodo = Convert.ToInt32(de_fecha.DateTime.Date.Year.ToString()+de_fecha.DateTime.Date.Month.ToString("00"));
                info_factura.vt_anio = de_fecha.DateTime.Date.Year;
                info_factura.vt_mes = de_fecha.DateTime.Date.Month;
                info_factura.IdCaja = Convert.ToInt32(cmb_caja.EditValue);

                info_factura.lst_cuotas = new List<fa_cuotas_x_doc_Info>(blst_cuotas);
                info_factura.DetFactura_List = new List<fa_factura_det_info>(blst_det.Where(q=>q.IdProducto != 0).ToList());
                info_factura.lista_formaPago_x_Factura = new List<fa_factura_x_formaPago_Info>(ucFa_FormaPago_x_Factura.Get_List_factura_x_formaPago());
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
                if (cmb_caja.EditValue == null)
                {
                    MessageBox.Show("Seleccione la caja",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_punto_venta.EditValue == null)
                {
                    MessageBox.Show("Seleccione el punto de venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_cliente.get_ClienteInfo() == null || cmb_cliente.get_ClienteInfo().IdEmpresa == 0)
                {
                    MessageBox.Show("Seleccione el cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_vendedor.EditValue == null)
                {
                    MessageBox.Show("Seleccione el vendedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_termino_pago.EditValue == null)
                {
                    MessageBox.Show("Seleccione el termino de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucFa_FormaPago_x_Factura.Get_List_factura_x_formaPago().Count == 0)
                {
                    MessageBox.Show("Seleccione la forma de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_det.Where(q=>q.IdProducto != 0).Count() == 0)
                {
                    MessageBox.Show("Ingrese los items para la venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in blst_det.Where(q=>q.IdProducto != 0).ToList())
                {
                    if (item.vt_cantidad == 0)
                    {
                        MessageBox.Show("Existen registros con cantidad 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;    
                    }
                    /*
                    if (item.vt_Precio == 0)
                    {
                        MessageBox.Show("Existen registros con precio 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                     */ 
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

        private bool accion_guardar()
        {
            try
            {
                txtIdFactura.Focus();
                bool res = false;

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

        private void imprimir()
        {
            try
            {
                
                XFAC_Rpt008_rpt rptSoporte = new XFAC_Rpt008_rpt(param.IdUsuario);
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus busDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();

                InfoDoc_x_Emp = busDoc_x_Emp.get_DisenioRpt(param.IdEmpresa, Cl_Enumeradores.eTipoDocumento_Talonario.FACT.ToString());
                if (InfoDoc_x_Emp.File_Disenio_Reporte != null)
                {
                    File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                    rptSoporte.LoadLayout(RootReporte);
                }

                XFAC_Rpt008_Bus busRpt = new XFAC_Rpt008_Bus();
                List<XFAC_Rpt008_Info> lstRpt = new List<XFAC_Rpt008_Info>();
                rptSoporte.RequestParameters = false;

                var io = lst_termino_pago.FirstOrDefault(q => q.IdTerminoPago == info_factura.vt_tipo_venta);
                bool mostrar_cuotas = false;
                if (io.Num_Cuotas > 0)
                    if (MessageBox.Show("Desea mostrar el detalle de las cuotas al imprimir",param.Nombre_sistema,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        mostrar_cuotas = true;

                lstRpt = busRpt.get_ImpresionFactura(info_factura.IdEmpresa, info_factura.IdSucursal, info_factura.IdBodega, info_factura.IdCbteVta, mostrar_cuotas);
                rptSoporte.lstRpt = lstRpt;
                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();

                bus_factura.Actualizar_campo_facturado(info_factura);


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

        private bool guardarDB()
        {
            try
            {
                decimal ID = 0;
                string num_doc = UCNumDoc.Get_Info_Talonario().NumDocumento;
                string mensajeDocumentoDupli = "";
                bool res = false;

                if (!validar())
                    return false;

                get_info();

                if (bus_factura.GuardarDB(info_factura, ref ID, ref num_doc, ref MensajeError, ref mensajeDocumentoDupli))
                {
                    MessageBox.Show("Registro guardado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;
                }
                else
                {
                    if (mensajeDocumentoDupli == "")
                    {
                        MessageBox.Show(MensajeError, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(mensajeDocumentoDupli, param.Nombre_sistema);
                        cargarNumDoc();
                    }
                }

                if (MessageBox.Show("¿Desea imprimir el soporte de la factura?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    imprimir();
                }
                /*
                if (MessageBox.Show("¿Desea realizar la cobranza de la factura?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    info_factura.Subtotal = info_factura.DetFactura_List.Sum(q => q.vt_Subtotal);
                    info_factura.IVA = info_factura.DetFactura_List.Sum(q => q.vt_iva);
                    info_factura.Total = info_factura.DetFactura_List.Sum(q => q.vt_total);

                    frmCxc_cobros_x_factura frm = new frmCxc_cobros_x_factura();
                    frm.set_info(info_factura);
                    frm.ShowDialog();
                }*/

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
                string num_doc = UCNumDoc.Get_Info_Talonario().NumDocumento;
                bool res = false;

                if (!validar())
                    return false;

                get_info();

                if (bus_factura.ModificarDB(info_factura, ref MensajeError))
                {
                    MessageBox.Show("Registro modificado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;
                }

                if (MessageBox.Show("Desea imprimir el soporte de la factura?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    imprimir();
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
                if (MessageBox.Show("¿Realmente Desea Anular la Factura?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    if (info_factura.Estado == "I" || lblAnulado.Visible == true)
                    {
                        MessageBox.Show("La Factura se encuentra Anulada.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return res;
                    }

                    get_info();
                    frm.ShowDialog();
                    info_factura.MotivoAnulacion = frm.motivoAnulacion;
                    string mensaje_error = "";

                    res = bus_factura.AnularDB(info_factura, param.Fecha_Transac, ref mensaje_error);
                    if (res)
                    {
                        MessageBox.Show("La Factura se Anuló Correctamente.\n" + "**** " + frm.motivoAnulacion + " ****"); lblAnulado.Visible = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al anular Factura " + "**** " + frm.motivoAnulacion + " ****"); lblAnulado.Visible = true;
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

        private void set_info_in_controls()
        {
            try
            {
                txtIdFactura.Text = info_factura.IdCbteVta.ToString();
                txt_observacion.Text = info_factura.vt_Observacion;
                cmb_caja.EditValue = info_factura.IdCaja;
                cmb_cliente.set_ClienteInfo(info_factura.IdCliente);
                cmb_punto_venta.EditValue = info_factura.IdPuntoVta;
                cmb_vendedor.EditValue = info_factura.IdVendedor;
                cmb_termino_pago.EditValue = info_factura.vt_tipo_venta;
                de_fecha.EditValue = info_factura.vt_fecha;
                de_fecha_vcto.EditValue = info_factura.vt_fech_venc;
                de_fecha_primer_pago.EditValue = info_factura.fecha_primera_cuota;
                txt_valor_abono.EditValue = info_factura.valor_abono;
                UCNumDoc.Set_Serie_Num_Documento(info_factura.vt_serie1, info_factura.vt_serie2, info_factura.vt_NumFactura);
                cmb_contacto.EditValue = info_factura.IdContacto;
                blst_det = new BindingList<fa_factura_det_info>(bus_factura_det.Get_List_factura_det(info_factura.IdEmpresa, info_factura.IdSucursal, info_factura.IdBodega, info_factura.IdCbteVta, ref MensajeError));
                foreach (var item in blst_det)
                {
                    agregar_producto_en_combo(item.IdProducto);
                }
                blst_cuotas = new BindingList<fa_cuotas_x_doc_Info>(bus_cuotas.get_list(info_factura.IdEmpresa, info_factura.IdSucursal, info_factura.IdBodega, info_factura.IdCbteVta));
                gridControl_detalle_cuotas.DataSource = blst_cuotas;
                gridControl_detalle.DataSource = blst_det;
                ucFa_FormaPago_x_Factura.Cargar_grid_x_Factura(info_factura.IdEmpresa, info_factura.IdSucursal, info_factura.IdBodega, info_factura.IdCbteVta);
                lblAnulado.Visible = info_factura.Estado == "A" ? false : true;
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

        private void FrmFa_Factura_lote_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_FrmFa_Factura_lote_mant_FormClosed(sender, e);
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
                if (!String.IsNullOrEmpty(txt_codigo_barra.Text) && e.KeyChar == (char)Keys.Enter)
                {
                    in_Producto_Info row_producto = lst_producto.FirstOrDefault(q => q.pr_codigo_barra == txt_codigo_barra.Text.ToString());
                    if(row_producto != null)
                        if (row_producto.IdProducto_padre != null)
                        {
                            fa_PuntoVta_Info row_punto_venta = lst_punto_venta.FirstOrDefault(q => q.IdPuntoVta == Convert.ToInt32(cmb_punto_venta.EditValue));
                            row_producto.IdSucursal = row_punto_venta.IdSucursal;
                            row_producto.IdBodega = Convert.ToInt32(row_punto_venta.IdBodega);
                            FrmIn_producto_asignacion_lote frm = new FrmIn_producto_asignacion_lote();
                            frm.set_funcion(Cl_Enumeradores.eFuncion_pantalla_lote.SELECCIONAR);
                            frm.set_info(Convert.ToDecimal(row_producto.IdProducto_padre), row_producto.IdSucursal,row_producto.IdBodega);
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

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
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

        private void btn_desbloquear_precios_Click(object sender, EventArgs e)
        {
            frmFa_clave_desbloqueo frm = new frmFa_clave_desbloqueo();
            frm.ShowDialog();
            if (frm.Result == System.Windows.Forms.DialogResult.Yes)
            {
                col_por_descuento.OptionsColumn.AllowEdit = true;
                col_precio.OptionsColumn.AllowEdit = true;
            }
            else
            {
                col_por_descuento.OptionsColumn.AllowEdit = false;
                col_precio.OptionsColumn.AllowEdit = false;
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
                        if (cmb_punto_venta.EditValue == null)
                            return;
                        fa_PuntoVta_Info row_punto_venta = lst_punto_venta.FirstOrDefault(q => q.IdPuntoVta == Convert.ToInt32(cmb_punto_venta.EditValue));
                        row_producto.IdSucursal = row_punto_venta.IdSucursal;
                        row_producto.IdBodega = Convert.ToInt32(row_punto_venta.IdBodega);
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

        private void txt_valor_abono_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_termino_pago.EditValue != null)
                {
                    fa_TerminoPago_Info Info_TerminoPago = new fa_TerminoPago_Info();
                    Info_TerminoPago = lst_termino_pago.Where(q => q.IdTerminoPago == Convert.ToString(cmb_termino_pago.EditValue)).FirstOrDefault();
                    spinEditDiasPlazo.EditValue = Info_TerminoPago.Dias_Vct;
                    if (Info_TerminoPago.Num_Cuotas > 0)
                    {
                        crear_cuotas(Info_TerminoPago.IdTerminoPago);
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

        private void de_fecha_primer_pago_EditValueChanged(object sender, EventArgs e)
        {
            if (cmb_termino_pago.EditValue != null)
            {
                fa_TerminoPago_Info Info_TerminoPago = new fa_TerminoPago_Info();
                Info_TerminoPago = lst_termino_pago.Where(q => q.IdTerminoPago == Convert.ToString(cmb_termino_pago.EditValue)).FirstOrDefault();
                spinEditDiasPlazo.EditValue = Info_TerminoPago.Dias_Vct;
                if (Info_TerminoPago.Num_Cuotas > 0)
                {
                    crear_cuotas(Info_TerminoPago.IdTerminoPago);
                }
            }
        }
    }
}
