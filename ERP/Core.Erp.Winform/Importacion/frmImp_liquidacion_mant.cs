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
using Core.Erp.Info.Importacion;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using System.Linq;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_liquidacion_mant : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        imp_liquidacion_Info info_liquidacion;
        imp_liquidacion_Bus bus_liquidacion;
        cl_parametrosGenerales_Bus param;
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        BindingList<imp_liquidacion_det_x_imp_orden_compra_ext_Info> blst_det_oc;
        imp_liquidacion_det_x_imp_orden_compra_ext_Bus bus_det_oc;
        BindingList<imp_orden_compra_ext_det_Info> blst_det_oc_det;
        imp_orden_compra_ext_det_Bus bus_det_oc_det;
        List<in_Producto_Info> lst_producto;
        in_producto_Bus bus_producto;
        List<in_UnidadMedida_Info> lst_unidad_medida;
        in_UnidadMedida_Bus bus_unidad_medida;
        List<ct_Cbtecble_tipo_Info> lst_tipo_cbte;
        ct_Cbtecble_tipo_Bus bus_tipo_cbte;
        List<imp_gasto_x_ct_plancta_Info> lst_gasto_tipo;
        imp_gasto_x_ct_plancta_Bus bus_gasto_tipo;
        BindingList<imp_orden_compra_ext_ct_cbteble_det_gastos_Info> blst_det_gastos;
        imp_orden_compra_ext_ct_cbteble_det_gastos_Bus bus_det_gastos;
        #endregion

        #region Delegados
        public delegate void delegate_frmImp_liquidacion_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmImp_liquidacion_mant_FormClosed event_delegate_frmImp_liquidacion_mant_FormClosed;

        void frmImp_liquidacion_mant_event_delegate_frmImp_liquidacion_mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void frmImp_liquidacion_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmImp_liquidacion_mant_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public frmImp_liquidacion_mant()
        {
            InitializeComponent();
            event_delegate_frmImp_liquidacion_mant_FormClosed += frmImp_liquidacion_mant_event_delegate_frmImp_liquidacion_mant_FormClosed;
            info_liquidacion = new imp_liquidacion_Info();
            bus_liquidacion = new imp_liquidacion_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            blst_det_oc = new BindingList<imp_liquidacion_det_x_imp_orden_compra_ext_Info>();
            bus_det_oc = new imp_liquidacion_det_x_imp_orden_compra_ext_Bus();
            blst_det_oc_det = new BindingList<imp_orden_compra_ext_det_Info>();
            bus_det_oc_det = new imp_orden_compra_ext_det_Bus();
            lst_producto = new List<in_Producto_Info>();
            bus_producto = new in_producto_Bus();
            lst_unidad_medida = new List<in_UnidadMedida_Info>();
            bus_unidad_medida = new in_UnidadMedida_Bus();
            lst_gasto_tipo = new List<imp_gasto_x_ct_plancta_Info>();
            bus_gasto_tipo = new imp_gasto_x_ct_plancta_Bus();
            lst_tipo_cbte = new List<ct_Cbtecble_tipo_Info>();
            bus_tipo_cbte = new ct_Cbtecble_tipo_Bus();
            blst_det_gastos = new BindingList<imp_orden_compra_ext_ct_cbteble_det_gastos_Info>();
            bus_det_gastos = new imp_orden_compra_ext_ct_cbteble_det_gastos_Bus();
        }
        
        public void set_info(imp_liquidacion_Info _info)
        {
            try
            {
                info_liquidacion = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                cargar_combos();
                cargar_oc_ext_x_liquidar();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = true;
                        menu.Visible_bntLimpiar = true;
                        menu.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = true;
                        menu.Visible_bntLimpiar = true;
                        menu.Visible_btnGuardar = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        menu.Visible_bntAnular = true;
                        menu.Visible_bntGuardar_y_Salir = false;
                        menu.Visible_bntLimpiar = true;
                        menu.Visible_btnGuardar = false;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = false;
                        menu.Visible_bntLimpiar = false;
                        menu.Visible_btnGuardar = false;
                        set_info_in_controls();
                        break;
                }
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
                string mensaje = "";
                de_fecha.DateTime = DateTime.Now.Date;
                txt_conversion_moneda.Text = "1";

                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto_det.DataSource = lst_producto;

                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida_det.DataSource = lst_unidad_medida;

                lst_gasto_tipo = bus_gasto_tipo.get_list(param.IdEmpresa);
                cmb_gasto_tipo.DataSource = lst_gasto_tipo;

                lst_tipo_cbte = bus_tipo_cbte.Get_list_Cbtecble_tipo(param.IdEmpresa, ref mensaje);
                cmb_tipo_cbte.DataSource = lst_tipo_cbte;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImp_liquidacion_mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_oc_ext_x_liquidar()
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    blst_det_oc = new BindingList<imp_liquidacion_det_x_imp_orden_compra_ext_Info>(bus_det_oc.get_list(param.IdEmpresa, 0));
                else
                    blst_det_oc = new BindingList<imp_liquidacion_det_x_imp_orden_compra_ext_Info>(bus_det_oc.get_list(param.IdEmpresa, info_liquidacion.IdLiquidacion));
                gridControl_oc_ext.DataSource = blst_det_oc;

                calcular_totales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_oc_ext_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                imp_liquidacion_det_x_imp_orden_compra_ext_Info row = (imp_liquidacion_det_x_imp_orden_compra_ext_Info)gridView_oc_ext.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column == col_seleccionado)
                {
                    cargar_detalles_oc();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_detalles_oc()
        {
            try
            {
                
                List<decimal> lst_oc = new List<decimal>();
                foreach (var item in blst_det_oc.Where(q=>q.seleccionado == true))
                {
                    lst_oc.Add(item.IdOrdenCompra_ext);
                }
                
                #region Detalle de oc
                blst_det_oc_det = new BindingList<imp_orden_compra_ext_det_Info>(bus_det_oc_det.get_list(param.IdEmpresa, lst_oc));
                gridControl_oc_ex_det.DataSource = blst_det_oc_det;
                #endregion

                #region Detalle de gastos
                blst_det_gastos = new BindingList<imp_orden_compra_ext_ct_cbteble_det_gastos_Info>(bus_det_gastos.get_list(param.IdEmpresa, lst_oc));
                gridControl_gastos.DataSource = blst_det_gastos;
                #endregion

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_oc_ext_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_seleccionado)
                {
                    gridView_oc_ext.SetRowCellValue(e.RowHandle, col_seleccionado, e.Value);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnGuardar_Click(object sender, EventArgs e)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnAnular_Click(object sender, EventArgs e)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        private bool validar()
        {
            try
            {
                txt_IdLiquidacion.Focus();

                if (de_fecha.EditValue == null)
                {
                    MessageBox.Show("Ingrese la fecha de la liquidación",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_det_oc.Where(q=>q.seleccionado == true).Count() == 0)
                {
                    MessageBox.Show("Seleccione las órdenes de compra externas a liquidar",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(txt_conversion_moneda.Text))
                {
                    MessageBox.Show("Ingrese el factor de conversión de la moneda",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void get_info()
        {
            try
            {
                info_liquidacion.IdEmpresa = param.IdEmpresa;
                info_liquidacion.IdLiquidacion = txt_IdLiquidacion.Text == "" ? 0 : Convert.ToDecimal(txt_IdLiquidacion.Text);
                info_liquidacion.li_codigo = txt_codigo.Text;
                info_liquidacion.li_num_documento = txt_num_documento.Text;
                info_liquidacion.li_num_DAU = txt_num_dau.Text;
                info_liquidacion.li_observacion = txt_observacion.Text;
                info_liquidacion.li_fecha = de_fecha.DateTime.Date;
                info_liquidacion.li_factor_conversion = txt_factor_costo.Text == "" ? 0 : Convert.ToDouble(txt_factor_costo.Text);
                info_liquidacion.li_total_fob = txt_total_fob.Text == "" ? 0 : Convert.ToDouble(txt_total_fob.Text);
                info_liquidacion.li_total_gastos = txt_total_gastos.Text == "" ? 0 : Convert.ToDouble(txt_total_gastos.Text);
                info_liquidacion.li_total_bodega = txt_total_bodega.Text == "" ? 0 : Convert.ToDouble(txt_total_bodega.Text);
                info_liquidacion.li_factor_costo = txt_factor_costo.Text == "" ? 0 : Convert.ToDouble(txt_factor_costo.Text);

                info_liquidacion.lst_det_oc = new List<imp_liquidacion_det_x_imp_orden_compra_ext_Info>(blst_det_oc.Where(q => q.seleccionado == true));

                foreach (var item in info_liquidacion.lst_det_oc)
                {
                    item.info_oc.lst_det = blst_det_oc_det.Where(q => q.IdOrdenCompra_ext == item.IdOrdenCompra_ext).ToList();
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
                txt_IdLiquidacion.Text = info_liquidacion.IdLiquidacion.ToString();
                txt_codigo.Text = info_liquidacion.li_codigo;
                txt_num_documento.Text = info_liquidacion.li_num_documento;
                txt_num_dau.Text = info_liquidacion.li_num_DAU;
                txt_observacion.Text = info_liquidacion.li_observacion;
                de_fecha.DateTime = info_liquidacion.li_fecha;
                txt_conversion_moneda.Text = info_liquidacion.li_factor_conversion.ToString();
                txt_total_fob.Text = info_liquidacion.li_total_fob.ToString();
                txt_total_gastos.Text = info_liquidacion.li_total_gastos.ToString();
                txt_total_bodega.Text = info_liquidacion.li_total_bodega.ToString();
                txt_factor_costo.Text = info_liquidacion.li_factor_costo.ToString();
                lbl_anulado.Visible = !info_liquidacion.estado;
                cargar_detalles_oc();
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
                txt_IdLiquidacion.Text = "";
                txt_codigo.Text = "";
                txt_num_documento.Text = "";
                txt_num_dau.Text = "";
                txt_observacion.Text = "";
                de_fecha.DateTime = DateTime.Now.Date;
                txt_conversion_moneda.Text = "";
                txt_total_fob.Text = "";
                txt_total_gastos.Text = "";
                txt_total_bodega.Text = "";
                txt_factor_costo.Text = "";
                lbl_anulado.Visible = false;

                Accion = Cl_Enumeradores.eTipo_action.grabar;
                info_liquidacion = new imp_liquidacion_Info();
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool accion_guardar()
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool guardarDB()
        {
            try
            {
                bool res = false;

                if (bus_liquidacion.guardarDB(info_liquidacion))
                {
                    MessageBox.Show("Registro guardado exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    res = true;
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool modificarDB()
        {
            try
            {
                bool res = false;

                if (bus_liquidacion.modificarDB(info_liquidacion))
                {
                    MessageBox.Show("Registro modificado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool anularDB()
        {
            try
            {
                bool res = false;

                if (bus_liquidacion.anularDB(info_liquidacion))
                {
                    MessageBox.Show("Registro anulado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    res = true;
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void txt_conversion_moneda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (IsDigitsOnly(txt_conversion_moneda.Text))
                {
                    foreach (var item in blst_det_oc_det)
                    {
                        item.od_costo_convertido = item.od_costo_final * Convert.ToDouble(txt_conversion_moneda.Text);
                        item.od_total_fob = Math.Round(item.od_costo_convertido * item.od_cantidad_recepcion);
                    }
                    calcular_totales();
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcular_totales()
        {
            try
            {
                #region Gastos
                double total_flete = 0;
                double total_seguro = 0;
                double total_arancel = 0;
                double total_varios = 0;
                double total_no_afectan_costo = 0;

                foreach (var item in blst_det_gastos)
                {
                    switch (item.IdGasto_tipo)
                    {
                        case 1:
                            total_flete += item.dc_Valor;
                            break;
                        case 2:
                            total_seguro += item.dc_Valor;
                            break;
                        case 3:
                            total_arancel += item.dc_Valor;
                            break;
                        case 4:
                            total_varios += item.dc_Valor;
                            break;
                        default:
                            total_no_afectan_costo += item.dc_Valor;
                            break;
                    }
                }

                txt_total_flete.Text = total_flete.ToString();
                txt_total_seguro.Text = total_seguro.ToString();
                txt_total_arancel.Text = total_arancel.ToString();
                txt_total_varios.Text = total_varios.ToString();
                txt_total_no_afecta_costo.Text = total_no_afectan_costo.ToString();
                #endregion

                #region Inventario
                double total_fob = 0;
                double total_gastos = 0;
                double factor_costo = 0;
                double total_bodega = 0;

                total_gastos = Math.Round(total_flete + total_seguro + total_arancel + total_varios,2,MidpointRounding.AwayFromZero);
                total_fob = Math.Round(blst_det_oc_det.Sum(q => q.od_total_fob),2,MidpointRounding.AwayFromZero);
                factor_costo = Math.Round((total_gastos + total_fob) / total_fob,2,MidpointRounding.AwayFromZero);

                foreach (var item in blst_det_oc_det)
                {
                    item.od_factor_costo = factor_costo;
                    item.od_costo_bodega = Math.Round(item.od_costo_convertido * item.od_factor_costo,2,MidpointRounding.AwayFromZero);
                    item.od_costo_total = Math.Round(item.od_cantidad_recepcion * item.od_costo_bodega,2,MidpointRounding.AwayFromZero);
                    total_bodega += item.od_costo_total;
                }

                txt_total_fob.Text = total_fob.ToString();
                txt_total_gastos.Text = total_gastos.ToString();
                txt_factor_costo.Text = factor_costo.ToString();
                txt_total_bodega.Text = total_bodega.ToString();
                #endregion
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}