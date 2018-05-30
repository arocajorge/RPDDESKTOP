using Core.Erp.Business.Caja;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Caja;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Reportes.Facturacion;
using Core.Erp.Winform.CuentasxCobrar;
using Core.Erp.Winform.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_proforma_facturacion : Form
    {
        #region Variables
        fa_proforma_Info info_proforma;
        fa_proforma_Bus bus_proforma;
        cl_parametrosGenerales_Bus param;
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
        List<fa_PuntoVta_Info> lst_punto_venta;
        fa_PuntoVta_Bus bus_punto_venta;
        List<fa_Vendedor_Info> lst_vendedor;
        fa_Vendedor_Bus bus_vendedor;
        List<caj_Caja_Info> lst_caja;
        caj_Caja_Bus bus_caja;
        string MensajeError = "";
        fa_factura_Info info_factura;
        fa_factura_Bus bus_factura;
        static string result = Path.GetTempPath();
        String RootReporte = result + @"Factura.repx";
        List<fa_cliente_contactos_Info> lst_contacto;
        fa_cliente_contactos_Bus bus_contacto;
        fa_cuotas_x_doc_Bus bus_cuotas;
        BindingList<fa_cuotas_x_doc_Info> blst_cuotas;
        #endregion

        public frmFa_proforma_facturacion()
        {
            InitializeComponent();
            info_proforma = new fa_proforma_Info();
            bus_proforma = new fa_proforma_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
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
            lst_punto_venta = new List<fa_PuntoVta_Info>();
            bus_punto_venta = new fa_PuntoVta_Bus();
            lst_vendedor = new List<fa_Vendedor_Info>();
            bus_vendedor = new fa_Vendedor_Bus();
            lst_caja = new List<caj_Caja_Info>();
            bus_caja = new caj_Caja_Bus();
            info_factura = new fa_factura_Info();
            bus_factura = new fa_factura_Bus();
            lst_contacto = new List<fa_cliente_contactos_Info>();
            bus_contacto = new fa_cliente_contactos_Bus();
            blst_cuotas = new BindingList<fa_cuotas_x_doc_Info>();
            bus_cuotas = new fa_cuotas_x_doc_Bus();
        }

        private void gridView_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_proforma_det_Info row = (fa_proforma_det_Info)gridView_detalle.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_checked)
                {
                    if (row.pd_checked)
                        row.pd_cantidad_aprobada = row.pd_cantidad_pendiente;
                    else
                        row.pd_cantidad_aprobada = 0;

                    row.pd_descuento_uni = Math.Round((row.pd_precio * row.pd_por_descuento_uni) / 100, 2, MidpointRounding.AwayFromZero);
                    row.pd_precio_final = row.pd_precio - row.pd_descuento_uni;
                    row.pd_subtotal = row.pd_cantidad_aprobada * row.pd_precio_final;
                    row.pd_iva = Math.Round(Convert.ToDouble(row.pd_subtotal * (row.pd_por_iva / 100)), 2, MidpointRounding.AwayFromZero);
                    row.pd_total = row.pd_subtotal + row.pd_iva;

                    if (cmb_termino_pago.EditValue != null)
                    {
                        fa_TerminoPago_Info Info_TerminoPago = new fa_TerminoPago_Info();
                        Info_TerminoPago = lst_termino_pago.Where(q => q.IdTerminoPago == Convert.ToString(cmb_termino_pago.EditValue)).FirstOrDefault();
                        if (Info_TerminoPago.Num_Cuotas > 0)
                        {
                            crear_cuotas(Info_TerminoPago.IdTerminoPago);
                        }
                    }
                }

                if (e.Column == col_can_aprobada)
                {
                    if (row.pd_cantidad == 0)
                        row.pd_checked = false;
                    else
                        row.pd_checked = true;
                    row.pd_descuento_uni = Math.Round((row.pd_precio * row.pd_por_descuento_uni) / 100, 2, MidpointRounding.AwayFromZero);
                    row.pd_precio_final = row.pd_precio - row.pd_descuento_uni;
                    row.pd_subtotal = row.pd_cantidad_aprobada * row.pd_precio_final;
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

        private void frmFa_proforma_facturacion_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
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

                lst_vendedor = bus_vendedor.Get_List_Vendedores(param.IdEmpresa);
                cmb_vendedor.Properties.DataSource = lst_vendedor;

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

                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto_det.DataSource = lst_producto;

                blst_cuotas = new BindingList<fa_cuotas_x_doc_Info>();
                gridControl_detalle_cuotas.DataSource = blst_cuotas;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarNumDoc()
        {
            try
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
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_cliente_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fa_Cliente_Info cliente = cmb_cliente.get_ClienteInfo();
                lst_contacto = new List<fa_cliente_contactos_Info>();
                if (cliente != null && cliente.IdEmpresa != 0 && cmb_punto_venta.EditValue != null)
                {
                    ucFa_FormaPago_x_Factura.set_forma_pago(cliente.FormaPago);
                    cmb_termino_pago.EditValue = cliente.IdTipoCredito;
                    fa_PuntoVta_Info row_punto_venta = lst_punto_venta.FirstOrDefault(q => q.IdPuntoVta == Convert.ToDecimal(cmb_punto_venta.EditValue));
                    blst_det = new BindingList<fa_proforma_det_Info>(bus_proforma_det.get_list_para_facturar(param.IdEmpresa, row_punto_venta.IdSucursal, Convert.ToInt32(row_punto_venta.IdBodega), cliente.IdCliente));
                    lst_contacto = bus_contacto.get_list(param.IdEmpresa, cliente.IdCliente);
                    if (lst_contacto.Count != 0)
                        cmb_contacto.EditValue = lst_contacto.First().IdContacto;
                }
                else
                    blst_det = new BindingList<fa_proforma_det_Info>();
                gridControl_detalle.DataSource = blst_det;
                cmb_contacto.Properties.DataSource = lst_contacto;
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

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDB())
                {
                    limpiar();
                }
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
                txt_observacion.Text = "";
                cmb_caja.EditValue = null;
                cmb_cliente.set_ClienteInfo(0);
                cmb_punto_venta.EditValue = null;
                cmb_vendedor.EditValue = null;
                cmb_termino_pago.EditValue = null;
                de_fecha.EditValue = DateTime.Now.Date;
                de_fecha_vcto.EditValue = DateTime.Now.Date;

                UCNumDoc.Set_Serie_Num_Documento("", "", "");
                cargar_combos();
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

        private void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDB())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_detalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_checked)
                    gridView_detalle.SetRowCellValue(e.RowHandle, col_checked, e.Value);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_detalle.RowCount; i++)
                {
                    gridView_detalle.SetRowCellValue(i, col_checked, chk_seleccionar_visibles);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {
                if (cmb_caja.EditValue == null)
                {
                    MessageBox.Show("Seleccione la caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_punto_venta.EditValue == null)
                {
                    MessageBox.Show("Seleccione el punto de venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_cliente.get_ClienteInfo().IdEmpresa == 0)
                {
                    MessageBox.Show("Seleccione el cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_contacto.EditValue == null)
                {
                    MessageBox.Show("Seleccione el contacto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                if (blst_det.Where(q => q.pd_checked == true).Count() == 0)
                {
                    MessageBox.Show("No ha seleccionado registros", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in blst_det.Where(q => q.pd_checked == true).ToList())
                {
                    if (item.pd_cantidad_aprobada == 0)
                    {
                        MessageBox.Show("Existen registros con cantidad 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                info_factura = new fa_factura_Info();
                info_factura.IdEmpresa = param.IdEmpresa;
                fa_PuntoVta_Info pto_vta = lst_punto_venta.FirstOrDefault(q => q.IdPuntoVta == Convert.ToInt32(cmb_punto_venta.EditValue));
                info_factura.IdSucursal = pto_vta.IdSucursal;
                info_factura.IdBodega = Convert.ToInt32(pto_vta.IdBodega);
                info_factura.IdCbteVta = 0;
                info_factura.IdPuntoVta = pto_vta.IdPuntoVta;

                info_factura.vt_tipoDoc = UCNumDoc.Get_Info_Talonario().CodDocumentoTipo;
                info_factura.vt_serie1 = UCNumDoc.Get_Info_Talonario().Establecimiento;
                info_factura.vt_serie2 = UCNumDoc.Get_Info_Talonario().PuntoEmision;
                info_factura.vt_NumFactura = UCNumDoc.Get_Info_Talonario().NumDocumento;
                info_factura.vt_autorizacion = UCNumDoc.Get_Info_Talonario().NumAutorizacion;

                info_factura.IdCliente = cmb_cliente.get_ClienteInfo().IdCliente;
                info_factura.IdVendedor = Convert.ToInt32(cmb_vendedor.EditValue);
                info_factura.vt_fecha = de_fecha.DateTime.Date;
                info_factura.vt_fech_venc = de_fecha_vcto.DateTime.Date;
                info_factura.vt_plazo = Convert.ToInt32(spinEditDiasPlazo.EditValue);
                info_factura.vt_tipo_venta = cmb_termino_pago.EditValue.ToString();
                info_factura.vt_Observacion = txt_observacion.Text;
                info_factura.IdContacto = Convert.ToInt32(cmb_contacto.EditValue);
                info_factura.IdPeriodo = Convert.ToInt32(de_fecha.DateTime.Date.Year.ToString() + de_fecha.DateTime.Date.Month.ToString("00"));
                info_factura.vt_anio = de_fecha.DateTime.Date.Year;
                info_factura.vt_mes = de_fecha.DateTime.Date.Month;
                info_factura.IdCaja = Convert.ToInt32(cmb_caja.EditValue);
                if (de_fecha_primer_pago.EditValue != null)
                    info_factura.fecha_primera_cuota = de_fecha_primer_pago.DateTime.Date;
                else
                    info_factura.fecha_primera_cuota = null;
                info_factura.valor_abono = txt_valor_abono.Text == "" ? 0 : Convert.ToDouble(txt_valor_abono.Text);

                info_factura.DetFactura_List = new List<fa_factura_det_info>();
                foreach (var item in blst_det.Where(q => q.pd_checked == true).ToList())
                {
                    fa_factura_det_info det = new fa_factura_det_info();
                    det.IdEmpresa_pf = item.IdEmpresa;
                    det.IdSucursal_pf = item.IdSucursal;
                    det.IdProforma = item.IdProforma;
                    det.Secuencia_pf = item.Secuencia;

                    det.IdProducto = item.IdProducto;
                    det.vt_cantidad = item.pd_cantidad_aprobada;
                    det.vt_Precio = item.pd_precio;
                    det.vt_PorDescUnitario = item.pd_por_descuento_uni;
                    det.vt_DescUnitario = item.pd_descuento_uni;
                    det.vt_PrecioFinal = item.pd_precio_final;
                    det.vt_Subtotal = item.pd_subtotal;
                    det.IdCod_Impuesto_Iva = item.IdCod_Impuesto;
                    det.vt_por_iva = item.pd_por_iva;
                    det.vt_iva = item.pd_iva;
                    det.vt_total = item.pd_total;
                    info_factura.DetFactura_List.Add(det);
                }
                info_factura.lst_cuotas = new List<fa_cuotas_x_doc_Info>(blst_cuotas);
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

        private bool guardarDB()
        {
            try
            {
                bool res = false;

                if (!validar())
                    return false;
                decimal ID = 0;
                string num_documento = "";
                string mensajeDocumentoDupli = "";
                get_info();

                if (bus_factura.GuardarDB(info_factura, ref ID, ref num_documento, ref MensajeError, ref mensajeDocumentoDupli))
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

                if (MessageBox.Show("¿Desea imprimir el soporte de la factura?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    imprimir();
                }

                bus_proforma_det.anular_detalle(blst_det.Where(q => q.anulado == true).ToList());

                /*
                if (MessageBox.Show("¿Desea realizar la cobranza de la factura?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    info_factura.Subtotal = info_factura.DetFactura_List.Sum(q => q.vt_Subtotal);
                    info_factura.IVA = info_factura.DetFactura_List.Sum(q => q.vt_iva);
                    info_factura.Total = info_factura.DetFactura_List.Sum(q => q.vt_total);
                    info_factura.vt_saldo = info_factura.Total;

                    frmCxc_cobros_x_factura frm = new frmCxc_cobros_x_factura();
                    frm.set_info(info_factura);
                    frm.ShowDialog();
                }
                */
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
                    if (MessageBox.Show("Desea mostrar el detalle de las cuotas al imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        mostrar_cuotas = true;
                lstRpt = busRpt.get_ImpresionFactura(info_factura.IdEmpresa, info_factura.IdSucursal, info_factura.IdBodega, info_factura.IdCbteVta,mostrar_cuotas);
                rptSoporte.lstRpt = lstRpt;
                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();
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

        private void crear_cuotas(string IdTerminoPago)
        {
            try
            {
                fa_TerminoPago_Distribucion_Bus bus_tdistribucion = new fa_TerminoPago_Distribucion_Bus();
                var lst_distribucion = bus_tdistribucion.Get_List_TerminoPago_Distribucion(IdTerminoPago);
                double total = blst_det.Where(q=>q.pd_checked == true).Sum(q => q.pd_total);
                double valor_abono = string.IsNullOrEmpty(txt_valor_abono.Text) ? 0 : Convert.ToDouble(txt_valor_abono.Text);
                double valor_a_distribuir = total - valor_abono;
                DateTime? primera_cuota = null;
                if (lst_distribucion.Count > 0)
                {
                    primera_cuota = de_fecha.DateTime.AddDays(lst_distribucion.Where(q => q.Secuencia == 1).FirstOrDefault().Num_Dias_Vcto);
                    de_fecha_primer_pago.DateTime = primera_cuota == null ? de_fecha.DateTime : Convert.ToDateTime(primera_cuota);
                }
                blst_cuotas = new BindingList<fa_cuotas_x_doc_Info>();
                if (primera_cuota == null)
                    primera_cuota = de_fecha.DateTime;
                int num_cuota = 1;
                foreach (var item in lst_distribucion)
                {
                    fa_cuotas_x_doc_Info i_cuota = new fa_cuotas_x_doc_Info
                    {
                        valor_a_cobrar = valor_a_distribuir * (item.Por_distribucion / 100),
                        fecha_vcto_cuota = num_cuota == 1 ? Convert.ToDateTime(primera_cuota) : Convert.ToDateTime(Convert.ToDateTime(primera_cuota).AddDays(item.Num_Dias_Vcto)),
                        num_cuota = num_cuota++,
                    };
                    blst_cuotas.Add(i_cuota);
                }
                gridControl_detalle_cuotas.DataSource = null;
                gridControl_detalle_cuotas.DataSource = blst_cuotas;
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

        private void ver_stock()
        {
            try
            {
                fa_proforma_det_Info row = (fa_proforma_det_Info)gridView_detalle.GetFocusedRow();
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
    }
}
