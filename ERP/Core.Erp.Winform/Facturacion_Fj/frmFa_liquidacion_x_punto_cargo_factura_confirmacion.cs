using Core.Erp.Business.Caja;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Cus.Erp.Reports.FJ.Facturacion;
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

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_liquidacion_x_punto_cargo_factura_confirmacion : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_Caja_Bus Bus_Caja = new caj_Caja_Bus();
        fa_parametro_info Info_Param_fact = new fa_parametro_info();
        string MensajeError = "";
        fa_parametro_Bus Bus_Param_facturacion = new fa_parametro_Bus();
        fa_factura_fj_Bus bus_factura_fj = new fa_factura_fj_Bus();
        fa_Vendedor_Bus bus_vendedor = new fa_Vendedor_Bus();
        List<fa_TerminoPago_Info> list_TerminoPago = new List<fa_TerminoPago_Info>();
        fa_TerminoPago_Bus Bus_Termino_pago = new fa_TerminoPago_Bus();
        List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();
        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        BindingList<fa_factura_det_info> blst_factura_det = new BindingList<fa_factura_det_info>();
        fa_factura_Info info_factura = new fa_factura_Info();
        fa_factura_Bus bus_factura = new fa_factura_Bus();
        List<tb_sis_impuesto_Info> lst_impuesto = new List<tb_sis_impuesto_Info>();
        tb_sis_impuesto_Bus bus_impuesto = new tb_sis_impuesto_Bus();
        static string result = Path.GetTempPath();
        String RootReporte = result + @"Factura.repx";
        fa_liquidacion_x_punto_cargo_Bus bus_liquidacion_x_punto_cargo = new fa_liquidacion_x_punto_cargo_Bus();
        List<fa_liquidacion_x_punto_cargo_Info> lst_liquidacion_x_punto_cargo = new List<fa_liquidacion_x_punto_cargo_Info>();
        List<fa_pre_facturacion_det_Info> lst_prefacturacion_det = new List<fa_pre_facturacion_det_Info>();
        List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> lst_unidades_x_AF = new List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>();
        fa_registro_unidades_x_equipo_det_ini_x_Af_Bus bus_unidades_x_AF = new fa_registro_unidades_x_equipo_det_ini_x_Af_Bus();
        fa_pre_facturacion_det_Bus bus_prefacturacion_det = new fa_pre_facturacion_det_Bus();
        Cl_Enumeradores.eTipo_horas_facturar eTipo_horas;
        public delegate void delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed event_delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed;
        #endregion

        public frmFa_liquidacion_x_punto_cargo_factura_confirmacion()
        {
            InitializeComponent();
            event_delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed += frmFa_liquidacion_x_punto_cargo_factura_confirmacion_event_delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed;
        }

        void frmFa_liquidacion_x_punto_cargo_factura_confirmacion_event_delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmFa_liquidacion_x_punto_cargo_factura_confirmacion_Load(object sender, EventArgs e)
        {
            try
            {
                UCSucursal.cmb_sucursal.Properties.ReadOnly = true;
                //UCSucursal.cmb_bodega.Properties.ReadOnly = true;
                cargar_combos();
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

        private void cargar_combos()
        {
            try
            {
                Info_Param_fact = Bus_Param_facturacion.Get_Info_parametro(param.IdEmpresa);
                ucFa_FormaPago_x_Factura.Cargar_grid();
                cmbCaja.Properties.DataSource = Bus_Caja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                cmbCaja.EditValue = Info_Param_fact.IdCaja_Default_Factura;
                cmb_vendedor.Properties.DataSource = bus_vendedor.Get_List_Vendedores(param.IdEmpresa);
                cmb_vendedor.EditValue = 1;
                list_TerminoPago = new List<fa_TerminoPago_Info>();
                list_TerminoPago = Bus_Termino_pago.Get_List_TerminoPago("");
                cmbTerminoPago.Properties.DataSource = list_TerminoPago;
                lst_producto = bus_producto.Get_list_Producto_modulo_x_Ventas(param.IdEmpresa);
                cmb_producto.DataSource = lst_producto;
                lst_punto_cargo = bus_punto_cargo.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                cmb_punto_cargo.DataSource = lst_punto_cargo;
                lst_impuesto = bus_impuesto.Get_List_impuesto_para_Ventas("IVA");
                cmb_impuesto.DataSource = lst_impuesto;
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
                UCNumDoc.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.FACT;
                if (UCSucursal.get_sucursal() != null && UCSucursal.get_bodega() != null)
                {
                    UCNumDoc.IdEstablecimiento = UCSucursal.get_sucursal().Su_CodigoEstablecimiento;
                    UCNumDoc.IdPuntoEmision = UCSucursal.get_bodega().cod_punto_emision;
                    UCNumDoc.Get_Primer_Documento_no_usado();
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

        private void UCSucursal_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
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

        private void UCSucursal_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
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

        private void cmbTerminoPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTerminoPago.EditValue != null)
                {
                    if (cmbTerminoPago.Text != "")
                    {
                        fa_TerminoPago_Info Info_TerminoPago = new fa_TerminoPago_Info();
                        Info_TerminoPago = list_TerminoPago.Where(q => q.IdTerminoPago == Convert.ToString(cmbTerminoPago.EditValue)).FirstOrDefault();
                        spinEditDiasPlazo.EditValue = Info_TerminoPago.Dias_Vct;
                    }
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

        private void spinEditDiasPlazo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (spinEditDiasPlazo.EditValue != null)
                {
                    if (spinEditDiasPlazo.Text != "")
                    {
                        dateFechaVencimiento.Value = dateFecha.Value.AddDays(Convert.ToInt32(spinEditDiasPlazo.EditValue));
                    }
                }
                else
                {
                    dateFechaVencimiento.Value = DateTime.Now;
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

        public void set_info(fa_factura_Info info)
        {
            try
            {
                info_factura = info;
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

        public void set_info(List<fa_liquidacion_x_punto_cargo_Info> info)
        {
            try
            {
                lst_liquidacion_x_punto_cargo = info;
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

        public void set_info(List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> info, Cl_Enumeradores.eTipo_horas_facturar _eTipo_horas)
        {
            try
            {
                lst_unidades_x_AF = info;
                eTipo_horas = _eTipo_horas;
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

        public void set_info(List<fa_pre_facturacion_det_Info> info)
        {
            try
            {
                lst_prefacturacion_det = info;
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
                UCSucursal.cmb_sucursal.EditValue = info_factura.IdSucursal;
                UCSucursal.cmb_bodega.EditValue = info_factura.IdBodega;
                ucFa_ClienteCmb.cmb_cliente.EditValue = info_factura.IdCliente;
                //txt_atencion_a.Text = info_factura.Factura_Fj.Atencion_a;
                cmbTerminoPago.EditValue = info_factura.vt_tipo_venta;

                blst_factura_det = new BindingList<fa_factura_det_info>(info_factura.DetFactura_List);
                gridControl_factura_det.DataSource = blst_factura_det;
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

        public void get_info()
        {
            try
            {
                tb_sis_Documento_Tipo_Talonario_Info talonarioInfo = new tb_sis_Documento_Tipo_Talonario_Info();
                talonarioInfo = UCNumDoc.Get_Info_Talonario();
                info_factura.CodCbteVta = "";
                info_factura.Estado = "A";
                info_factura.Fecha_Transaccion = DateTime.Now;
                info_factura.Fecha_UltAnu = DateTime.Now;
                info_factura.Fecha_UltMod = DateTime.Now;
                info_factura.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
                info_factura.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                info_factura.IdCliente = Convert.ToInt32(ucFa_ClienteCmb.get_ClienteInfo().IdCliente);
                info_factura.IdEmpresa = param.IdEmpresa;
                info_factura.vt_fecha = Convert.ToDateTime(dateFecha.Value);
                info_factura.IdPeriodo = (info_factura.vt_fecha.Year * 100) + info_factura.vt_fecha.Month;
                info_factura.IdUsuario = param.IdUsuario;
                info_factura.IdUsuarioUltAnu = param.IdUsuario;
                info_factura.IdUsuarioUltModi = param.IdUsuario;
                info_factura.ip = param.ip;
                info_factura.nom_pc = param.nom_pc;
                
                info_factura.vt_fech_venc = Convert.ToDateTime(dateFechaVencimiento.Value);
                info_factura.vt_flete = 0;
                info_factura.vt_interes = 0;
                info_factura.vt_NumFactura = talonarioInfo.NumDocumento;
                info_factura.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                info_factura.vt_plazo = Convert.ToInt32(spinEditDiasPlazo.Value);


                info_factura.vt_Observacion = txt_observacion.Text;

                info_factura.vt_OtroValor1 = 0;
                info_factura.vt_OtroValor2 = 0;

                info_factura.vt_seguro = 0;
                info_factura.vt_serie1 = talonarioInfo.Establecimiento;
                info_factura.vt_serie2 = talonarioInfo.PuntoEmision;
                info_factura.EsDocumentoElectronico = (bool)talonarioInfo.es_Documento_electronico;
                info_factura.vt_tipo_venta = info_factura.IdTerminoPago;
                info_factura.vt_tipoDoc = "FACT";
                info_factura.vt_anio = info_factura.vt_fecha.Year;
                info_factura.vt_mes = info_factura.vt_fecha.Month;
                info_factura.IdVendedor = Convert.ToInt32(cmb_vendedor.EditValue);
                info_factura.Cliente = ucFa_ClienteCmb.cmb_cliente.Text;

                info_factura.DetFactura_List = new List<fa_factura_det_info>(blst_factura_det.Where(q => q.IdProducto != 0));

                info_factura.lista_formaPago_x_Factura = ucFa_FormaPago_x_Factura.Get_List_factura_x_formaPago();
                //info_factura.Factura_Fj = Get_Info_Factura_fj();
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

        private fa_factura_fj_Info Get_Info_Factura_fj()
        {
            try
            {
                fa_factura_fj_Info info_fj = new fa_factura_fj_Info();

                info_fj.IdEmpresa = param.IdEmpresa;
                info_fj.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                info_fj.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
                info_fj.num_oc = txt_num_oc.Text;
                info_fj.Atencion_a = txt_atencion_a.Text;
                info_fj.descripcion_fact = txt_referencia.Text;
                info_fj.fecha_cobro_1 = de_fecha_cobro_1.EditValue == null ? info_factura.vt_fech_venc : de_fecha_cobro_1.DateTime;
                info_fj.fecha_cobro_2 = de_fecha_cobro_1.EditValue == null ? info_factura.vt_fech_venc : de_fecha_cobro_2.DateTime;
                return info_fj;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_factura_fj_Info();
            }
        }        
        
        private void gridView_factura_det_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_factura_det_info row = (fa_factura_det_info)gridView_factura_det.GetRow(e.RowHandle);
                if (row == null) return;
                if (e.Column == col_IdCod_Impuesto)
                {
                    tb_sis_impuesto_Info info_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto_Iva);
                    if (info_impuesto == null)
                    {
                        row.IdCod_Impuesto_Iva = param.iva.IdCod_Impuesto;
                        row.vt_por_iva = param.iva.porcentaje;
                    }
                    else
                    {
                        row.IdCod_Impuesto_Iva = info_impuesto.IdCod_Impuesto;
                        row.vt_por_iva = info_impuesto.porcentaje;
                    }
                    row.vt_iva = row.vt_Subtotal * (row.vt_por_iva == null ? 0 : Convert.ToDouble(row.vt_por_iva) / 100);
                    row.vt_total = row.vt_Subtotal + row.vt_iva;
                }

                if (e.Column == col_vt_cantidad || e.Column == col_vt_precio || e.Column == col_vt_por_des)
                {
                    row.vt_DescUnitario = (row.vt_cantidad * row.vt_Precio) * (row.vt_PorDescUnitario / 100);
                    row.vt_PrecioFinal = row.vt_Precio  - (row.vt_Precio * (row.vt_PorDescUnitario / 100));
                    row.vt_Subtotal = (row.vt_cantidad * row.vt_Precio) - row.vt_DescUnitario;
                    row.vt_iva = row.vt_Subtotal * (row.vt_por_iva == null ? 0 : Convert.ToDouble(row.vt_por_iva) / 100);
                    row.vt_total = row.vt_Subtotal + row.vt_iva;
                }

                if (e.Column == col_IdPunto_cargo)
                {
                    ct_punto_cargo_Info info_punto_cargo = lst_punto_cargo.FirstOrDefault(q => q.IdPunto_cargo == row.IdPunto_cargo);
                    if (info_punto_cargo == null)
                    {
                        row.IdCentroCosto = null;
                        row.IdCentroCosto_sub_centro_costo = null;
                        row.IdPunto_cargo_grupo = null;
                    }
                    else
                    {
                        row.IdCentroCosto = info_punto_cargo.IdCentroCosto_Scc;
                        row.IdCentroCosto_sub_centro_costo = info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc;
                        row.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
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

        private bool guardarDB()
        {
            try
            {
                if (!validar()) return false;

                bool res = false;
                decimal IdFactura = 0;
                string num_doc = "";
                get_info();
                if (bus_factura.GuardarDB(info_factura, ref IdFactura, ref num_doc, ref MensajeError, ref MensajeError))
                {
                    /*
                        fa_factura_fj_Bus bus_fact_fj = new fa_factura_fj_Bus();
                        info_factura.Factura_Fj.IdEmpresa = param.IdEmpresa;
                        info_factura.Factura_Fj.IdSucursal = info_factura.IdSucursal;
                        info_factura.Factura_Fj.IdBodega = info_factura.IdBodega;
                        info_factura.Factura_Fj.IdCbteVta = info_factura.IdCbteVta;
                        bus_fact_fj.GuardarDB(info_factura.Factura_Fj);
                    /*
                    foreach (var item in lst_liquidacion_x_punto_cargo)
                    {
                        item.vt_IdEmpresa = info_factura.IdEmpresa;
                        item.vt_IdSucursal = info_factura.IdSucursal;
                        item.vt_IdBodega = info_factura.IdBodega;
                        item.vt_IdCbteVta = info_factura.IdCbteVta;


                        if (!bus_liquidacion_x_punto_cargo.ModificarDB_num_factura(item))
                        {
                            MessageBox.Show("Error al relacionar factura con liquidaciones", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    */
                    if (lst_prefacturacion_det.Count > 0)
                    {
                        foreach (var item in lst_prefacturacion_det)
                        {
                            item.IdEmpresa_vta = info_factura.IdEmpresa;
                            item.IdSucursal = info_factura.IdSucursal;
                            item.IdBodega = info_factura.IdBodega;
                            item.IdCbteVta = info_factura.IdCbteVta;
                        }
                        if (!bus_prefacturacion_det.modificarDB(lst_prefacturacion_det))
                        {
                            MessageBox.Show("Error al relacionar factura con prefacturación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    if (lst_unidades_x_AF.Count > 0)
                    {
                        foreach (var item in lst_unidades_x_AF)
                        {
                            if (eTipo_horas == Cl_Enumeradores.eTipo_horas_facturar.HORAS_NORMALES)
                            {
                                item.IdEmpresa_hn = info_factura.IdEmpresa;
                                item.IdSucursal_hn = info_factura.IdSucursal;
                                item.IdBodega_hn = info_factura.IdBodega;
                                item.IdCbteVta_hn = info_factura.IdCbteVta;
                            }
                            else
                            {
                                item.IdEmpresa_he = info_factura.IdEmpresa;
                                item.IdSucursal_he = info_factura.IdSucursal;
                                item.IdBodega_he = info_factura.IdBodega;
                                item.IdCbteVta_he = info_factura.IdCbteVta;
                            }                            
                        }
                        if (!bus_unidades_x_AF.ModificarDB(lst_unidades_x_AF))
                        {
                            MessageBox.Show("Error al relacionar factura el registro de unidades", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    

                    MessageBox.Show("Factura guardada exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;

                    if (MessageBox.Show("Desea imprimir la factura # " + num_doc + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void imprimir()
        {
            try
            {
                XFAC_FJ_Rpt014_Rpt rptSoporte = new XFAC_FJ_Rpt014_Rpt();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus busDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();
                
                InfoDoc_x_Emp = busDoc_x_Emp.get_DisenioRpt(param.IdEmpresa, Cl_Enumeradores.eTipoDocumento_Talonario.FACT.ToString());
                if (InfoDoc_x_Emp.File_Disenio_Reporte != null)
                {
                    File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                    rptSoporte.LoadLayout(RootReporte);
                }

                XFAC_FJ_Rpt014_Bus busRpt = new XFAC_FJ_Rpt014_Bus();
                List<XFAC_FJ_Rpt014_Info> lstRpt = new List<XFAC_FJ_Rpt014_Info>();
                rptSoporte.RequestParameters = false;

                rptSoporte.P_IdSucursal.Value = info_factura.IdSucursal;
                rptSoporte.P_IdSucursal.Visible = false;

                rptSoporte.P_IdBodega.Value = info_factura.IdBodega;
                rptSoporte.P_IdBodega.Visible = false;

                rptSoporte.P_IdCbteVta.Value = info_factura.IdCbteVta;
                rptSoporte.P_IdCbteVta.Visible = false;

                rptSoporte.P_Numero_lineas.Value = Info_Param_fact.NumeroDeItemFact;
                rptSoporte.P_Numero_lineas.Visible = false;

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

        public Boolean validar()
        {
            try
            {
                UCSucursal.Focus();
                cmbTerminoPago.Focus();

                double TotalPorcent = 0;
                
                if (TotalPorcent > 100) { MessageBox.Show("La suma del porcentaje de formas de cobro no puede exeder el 100% "); ;return false; };

                if (cmb_vendedor.EditValue == null) { MessageBox.Show("No ha Ingresado Vendedor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }

                if (ucFa_ClienteCmb.get_ClienteInfo() == null)
                {
                    MessageBox.Show("No ha Ingresado Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txt_observacion.Text == "") { MessageBox.Show("No ha Ingresado la Observacion"); txt_observacion.Focus(); return false; }


                if (cmbCaja.EditValue == null || Convert.ToString(cmbCaja.EditValue) == "" || Convert.ToInt32(cmbCaja.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese la caja ", param.Nombre_sistema);
                    return false;
                }

                if (this.cmbTerminoPago.EditValue == null || Convert.ToString(cmbTerminoPago.EditValue) == "")
                {
                    MessageBox.Show("Ingrese el Término de Pago ", param.Nombre_sistema);
                    return false;
                }

                int count1 = blst_factura_det.Count(v => v.IdProducto > 0);

                if (count1 == 0)
                {
                    MessageBox.Show("No ha agregado Ningún Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                int count2 = ucFa_FormaPago_x_Factura.Get_List_factura_x_formaPago().Count();

                if (count2 == 0)
                {
                    MessageBox.Show("No ha seleccionado forma de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in blst_factura_det)
                {
                    if (item.IdProducto != 0)
                    {
                       in_Producto_Info Info_producto = lst_producto.FirstOrDefault(q => q.IdProducto == item.IdProducto);


                        if (item.vt_cantidad == 0)
                        {
                            MessageBox.Show("El item " + Info_producto.pr_descripcion + " registra valores de cantidad en 0. Por favor ingrese la cantidad ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }

                if (UCNumDoc.Get_Info_Talonario().NumDocumento == null)
                {
                    return false;
                    if (UCNumDoc.Get_Info_Talonario().NumDocumento == null)
                    {
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

        private void ucGe_Menu_Superior_Mant1_event_btnAceptar_Click(object sender, EventArgs e)
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void dateFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateFechaVencimiento.Value != null)
                {
                    de_fecha_cobro_1.EditValue = dateFechaVencimiento.Value;
                    de_fecha_cobro_2.EditValue = dateFechaVencimiento.Value;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            event_delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed(sender, e);
        }
    }
}
