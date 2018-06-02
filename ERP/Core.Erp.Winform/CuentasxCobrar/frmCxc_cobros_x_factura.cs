using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_cobros_x_factura : Form
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param;
        fa_factura_Info info_factura;
        tb_banco_Bus bus_banco;
        List<tb_banco_Info> lst_banco;
        List<cxc_cobro_tipo_Info> lst_cobro_tipo;
        cxc_cobro_tipo_Bus bus_cobro_tipo;
        BindingList<cxc_cobro_Info> blst_det;
        cxc_cobro_Bus bus_cobro;
        #endregion

        public frmCxc_cobros_x_factura()
        {
            InitializeComponent();
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            info_factura = new fa_factura_Info();
            bus_banco = new tb_banco_Bus();
            lst_banco = new List<tb_banco_Info>();
            bus_cobro_tipo = new cxc_cobro_tipo_Bus();
            lst_cobro_tipo = new List<cxc_cobro_tipo_Info>();
            blst_det = new BindingList<cxc_cobro_Info>();
            bus_cobro = new cxc_cobro_Bus();
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

        private void frmCxc_cobros_x_factura_Load(object sender, EventArgs e)
        {
            try
            {
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
                lst_banco = bus_banco.Get_List_Banco();
                cmb_banco.DataSource = lst_banco;

                lst_cobro_tipo = bus_cobro_tipo.Get_List_Cobro_Tipo();
                cmb_cobro_tipo.DataSource = lst_cobro_tipo;

                gridControl_cobros.DataSource = blst_det;
                de_fecha.DateTime = DateTime.Now.Date;
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

        private void set_info_in_controls()
        {
            try
            {
                txt_num_factura.Text = info_factura.vt_serie1 + "-" + info_factura.vt_serie2 + "-" + info_factura.vt_NumFactura;
                txt_subtotal.Text = info_factura.Subtotal.ToString();
                txt_valor_iva.Text = info_factura.IVA.ToString();
                txt_total.Text = info_factura.Total.ToString();
                txt_saldo_anterior.Text = info_factura.vt_saldo == null ? "0" : info_factura.vt_saldo.ToString();
                calcular_saldo();
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
                bool res = true;
                string mensaje = "";
                if (!validar())
                    return false;

                foreach (var item in blst_det)
                {
                    cxc_cobro_Info info_cobro = new cxc_cobro_Info();
                    info_cobro = armar_cobro_x_tipo(item);
                    if (!bus_cobro.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref info_cobro, ref mensaje, 0))
                        res = false;

                    if (!res)
                        return false;                    
                }

                if (res)
                {
                    MessageBox.Show("Cobranza realizada exitosamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
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

        private cxc_cobro_Info armar_cobro_x_tipo(cxc_cobro_Info _cobro)
        {
            try
            {
                cxc_cobro_Info info_cobro = new cxc_cobro_Info();

                info_cobro.IdEmpresa = info_factura.IdEmpresa;
                info_cobro.IdSucursal = info_factura.IdSucursal;
                info_cobro.IdCobro_tipo = _cobro.IdCobro_tipo;
                info_cobro.IdCliente = info_factura.IdCliente;
                info_cobro.cr_TotalCobro = _cobro.dc_ValorPago;
                info_cobro.cr_fecha = de_fecha.DateTime.Date;
                info_cobro.cr_fechaCobro = de_fecha.DateTime.Date;
                info_cobro.cr_fechaDocu = de_fecha.DateTime.Date;
                info_cobro.cr_observacion = "Canc./: FACT-" + Convert.ToDecimal(info_factura.vt_NumFactura).ToString();
                info_cobro.cr_Banco = _cobro.IdBanco == null ? "" : lst_banco.FirstOrDefault(q => q.IdBanco == _cobro.IdBanco).ba_descripcion;
                info_cobro.cr_cuenta = _cobro.cr_cuenta;
                info_cobro.cr_NumDocumento = _cobro.cr_NumDocumento;
                info_cobro.cr_es_anticipo = "N";
                info_cobro.IdCaja = Convert.ToInt32(info_factura.IdCaja);

                info_cobro.ListaCobro = new List<cxc_cobro_Det_Info>();
                cxc_cobro_Det_Info det = new cxc_cobro_Det_Info();
                det.IdEmpresa = info_factura.IdEmpresa;
                det.IdSucursal = info_factura.IdSucursal;
                det.dc_TipoDocumento = info_factura.vt_tipoDoc;
                det.IdBodega_Cbte = info_factura.IdBodega;
                det.IdCbte_vta_nota = info_factura.IdCbteVta;
                det.dc_ValorPago = _cobro.dc_ValorPago;
                det.IdUsuario = param.IdUsuario;
                det.nom_pc = param.nom_pc;
                det.ip = param.ip;
                info_cobro.ListaCobro.Add(det);

                return info_cobro;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new cxc_cobro_Info();
            }
        }

        private bool validar()
        {
            try
            {
                txt_num_factura.Focus();

                if (blst_det.Count == 0)
                {
                    MessageBox.Show("Ingrese el detalle de la cobranza para la factura",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_det.Sum(q=>q.dc_ValorPago) > Convert.ToDouble(txt_saldo_anterior.Text))
                {
                    MessageBox.Show("La suma de los cobros supera el valor de la factura", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in blst_det)
                {
                    if (item.dc_ValorPago == 0)
                    {
                        MessageBox.Show("Existen tipos de cobro con valor 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void gridView_cobros_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cxc_cobro_Info row = (cxc_cobro_Info)gridView_cobros.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column == col_tipo_cobro)
                {
                    cxc_cobro_tipo_Info row_cobro_tipo = lst_cobro_tipo.FirstOrDefault(q => q.IdCobro_tipo == row.IdCobro_tipo);
                    if (row_cobro_tipo != null)
                    {
                        if (row_cobro_tipo.ESRetenFTE == "S")
                        {
                            row.dc_ValorPago = Math.Round((info_factura.Subtotal * row_cobro_tipo.PorcentajeRet) / 100, 2, MidpointRounding.AwayFromZero);
                        }
                        else
                            if (row_cobro_tipo.ESRetenIVA == "S")
                            {
                                row.dc_ValorPago = Math.Round((info_factura.IVA * row_cobro_tipo.PorcentajeRet) / 100, 2, MidpointRounding.AwayFromZero);
                            }
                    }
                }

                if (e.Column == col_valor)
                {
                    calcular_saldo();
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

        private void calcular_saldo()
        {
            try
            {
                double saldo = Math.Round(Convert.ToDouble((info_factura.vt_saldo == 0 ? info_factura.Total : info_factura.vt_saldo)) - blst_det.Sum(q => q.dc_ValorPago), 2, MidpointRounding.AwayFromZero);
                txt_saldo.Text = saldo.ToString();
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

        private void gridView_cobros_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                calcular_saldo();
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
