using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using System.Linq;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_orden_compra_ext_mant : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        imp_orden_compra_ext_Info info_oc_ext;
        imp_orden_compra_ext_Bus bus_oc_ext;
        cl_parametrosGenerales_Bus param;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        List<tb_pais_Info> lst_pais;
        tb_pais_Bus bus_pais;
        List<tb_moneda_info> lst_moneda;
        tb_moneda_Bus bus_moneda;
        Cl_Enumeradores.eTipo_action Accion;
        List<cp_proveedor_Info> lst_proveedor;
        cp_proveedor_Bus bus_proveedor;
        List<in_Producto_Info> lst_producto;
        in_producto_Bus bus_producto;
        List<ct_Plancta_Info> lst_plancta;
        ct_Plancta_Bus bus_plancta;
        List<in_UnidadMedida_Info> lst_unidad_medida;
        in_UnidadMedida_Bus bus_unidad_medida;
        List<tb_ciudad_Info> lst_ciudad;
        tb_Ciudad_Bus bus_ciudad;
        BindingList<imp_orden_compra_ext_det_Info> blst_det;
        imp_orden_compra_ext_det_Bus bus_det;
        #endregion

        #region delegados
        public delegate void delegate_frmImp_orden_compra_ext_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmImp_orden_compra_ext_mant_FormClosed event_delegate_frmImp_orden_compra_ext_mant_FormClosed;

        void frmImp_orden_compra_ext_mant_event_delegate_frmImp_orden_compra_ext_mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmImp_orden_compra_ext_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmImp_orden_compra_ext_mant_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public frmImp_orden_compra_ext_mant()
        {
            InitializeComponent();
            info_oc_ext = new imp_orden_compra_ext_Info();
            bus_oc_ext = new imp_orden_compra_ext_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            bus_moneda = new tb_moneda_Bus();
            lst_moneda = new List<tb_moneda_info>();
            bus_pais = new tb_pais_Bus();
            lst_pais = new List<tb_pais_Info>();
            event_delegate_frmImp_orden_compra_ext_mant_FormClosed += frmImp_orden_compra_ext_mant_event_delegate_frmImp_orden_compra_ext_mant_FormClosed;
            lst_proveedor = new List<cp_proveedor_Info>();
            bus_proveedor = new cp_proveedor_Bus();
            lst_producto = new List<in_Producto_Info>();
            bus_producto = new in_producto_Bus();
            lst_plancta = new List<ct_Plancta_Info>();
            bus_plancta = new ct_Plancta_Bus();
            lst_unidad_medida = new List<in_UnidadMedida_Info>();
            bus_unidad_medida = new in_UnidadMedida_Bus();
            lst_ciudad = new List<tb_ciudad_Info>();
            bus_ciudad = new tb_Ciudad_Bus();
            blst_det = new BindingList<imp_orden_compra_ext_det_Info>();
            bus_det = new imp_orden_compra_ext_det_Bus();
        }        

        public void set_info(imp_orden_compra_ext_Info _info)
        {
            try
            {
                info_oc_ext = _info;
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

        private void cargar_combos()
        {
            try
            {
                string mensaje = "";
                lst_moneda = bus_moneda.Get_List_Moneda();
                cmb_moneda_destino.Properties.DataSource = lst_moneda;
                cmb_moneda_origen.Properties.DataSource = lst_moneda;

                lst_pais = bus_pais.Get_List_pais();
                cmb_pais_embarque.Properties.DataSource = lst_pais;
                cmb_pais_origen.Properties.DataSource = lst_pais;

                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto_det.DataSource = lst_producto;

                lst_proveedor = bus_proveedor.Get_List_proveedor(param.IdEmpresa);
                cmb_proveedor.Properties.DataSource = lst_proveedor;

                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida_det.DataSource = lst_unidad_medida;

                lst_plancta = bus_plancta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref mensaje);
                cmb_plancta.Properties.DataSource = lst_plancta;

                List<imp_catalogo_Info> lst_catalogo = new List<imp_catalogo_Info>();
                imp_catalogo_Bus bus_catalogo = new imp_catalogo_Bus();
                
                lst_catalogo = bus_catalogo.get_list(Convert.ToInt32(Cl_Enumeradores.eImp_catalogo.VIAS));
                cmb_catalogo_vias.Properties.DataSource = lst_catalogo;

                lst_catalogo = bus_catalogo.get_list(Convert.ToInt32(Cl_Enumeradores.eImp_catalogo.FORMA_PAGO));
                cmb_catalogo_forma_pago.Properties.DataSource = lst_catalogo;

                lst_ciudad = bus_ciudad.Get_List_Ciudad();
                cmb_ciudad_destino.Properties.DataSource = lst_ciudad;

                de_Fecha.DateTime = DateTime.Now.Date;
                gridControl_det.DataSource = blst_det;
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
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = true;
                        menu.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = true;
                        menu.Visible_btnGuardar = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        menu.Visible_bntAnular = true;
                        menu.Visible_bntGuardar_y_Salir = false;
                        menu.Visible_btnGuardar = false;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = false;
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

        private void set_info_in_controls()
        {
            try
            {
                txt_IdOrden_compra_ext.Text = info_oc_ext.IdOrdenCompra_ext.ToString();
                txt_codigo.Text = info_oc_ext.oe_codigo;
                txt_observacion.Text = info_oc_ext.oe_observacion;
                txt_valor_flete.Text = info_oc_ext.oe_valor_flete.ToString();
                txt_valor_seguro.Text = info_oc_ext.oe_valor_seguro.ToString();
                
                cmb_plancta.EditValue = info_oc_ext.IdCtaCble_importacion;
                cmb_proveedor.EditValue = info_oc_ext.IdProveedor;
                cmb_catalogo_forma_pago.EditValue = info_oc_ext.IdCatalogo_forma_pago;
                cmb_catalogo_vias.EditValue = info_oc_ext.IdCatalogo_via;
                cmb_ciudad_destino.EditValue = info_oc_ext.IdCiudad_destino;
                cmb_pais_embarque.EditValue = info_oc_ext.IdPais_embarque;
                cmb_pais_origen.EditValue = info_oc_ext.IdPais_origen;
                cmb_moneda_destino.EditValue = info_oc_ext.IdMoneda_destino;
                cmb_moneda_origen.EditValue = info_oc_ext.IdMoneda_origen;

                de_Fecha.DateTime = info_oc_ext.oe_fecha;
                de_fecha_desaduanizacion_est.EditValue = info_oc_ext.oe_fecha_desaduanizacion_est;
                de_fecha_embarque_est.EditValue = info_oc_ext.oe_fecha_embarque_est;
                de_fecha_llega_est.EditValue = info_oc_ext.oe_fecha_llegada_est;
                lbl_anulado.Visible = !info_oc_ext.estado;
                blst_det = new BindingList<imp_orden_compra_ext_det_Info>(bus_det.get_list(info_oc_ext.IdEmpresa, info_oc_ext.IdOrdenCompra_ext));
                gridControl_det.DataSource = blst_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_info()
        {
            try
            {
                info_oc_ext.IdEmpresa = param.IdEmpresa;
                info_oc_ext.IdOrdenCompra_ext = txt_IdOrden_compra_ext.Text == "" ? 0 : Convert.ToDecimal(txt_IdOrden_compra_ext.Text);
                info_oc_ext.oe_codigo = txt_codigo.Text;
                info_oc_ext.oe_observacion = txt_observacion.Text;
                info_oc_ext.oe_valor_flete = txt_valor_flete.Text == "" ? 0 : Convert.ToDouble(txt_valor_flete.Text);
                info_oc_ext.oe_valor_seguro = txt_valor_seguro.Text == "" ? 0 : Convert.ToDouble(txt_valor_seguro.Text);

                info_oc_ext.IdCtaCble_importacion = cmb_plancta.EditValue.ToString();
                info_oc_ext.IdProveedor =  Convert.ToDecimal(cmb_proveedor.EditValue);
                info_oc_ext.IdCatalogo_forma_pago = Convert.ToInt32(cmb_catalogo_forma_pago.EditValue);
                info_oc_ext.IdCatalogo_via = Convert.ToInt32(cmb_catalogo_vias.EditValue);
                info_oc_ext.IdCiudad_destino = cmb_ciudad_destino.EditValue.ToString();
                info_oc_ext.IdPais_embarque = cmb_pais_embarque.EditValue.ToString();
                info_oc_ext.IdPais_origen = cmb_pais_origen.EditValue.ToString();
                info_oc_ext.IdMoneda_destino = Convert.ToInt32(cmb_moneda_destino.EditValue);
                info_oc_ext.IdMoneda_origen = Convert.ToInt32(cmb_moneda_origen.EditValue);

                info_oc_ext.oe_fecha = de_Fecha.DateTime.Date;
                if (de_fecha_desaduanizacion_est.EditValue == null) info_oc_ext.oe_fecha_desaduanizacion_est = null; else info_oc_ext.oe_fecha_desaduanizacion_est = de_fecha_desaduanizacion_est.DateTime.Date;
                if (de_fecha_llega_est.EditValue == null) info_oc_ext.oe_fecha_llegada_est = null; else info_oc_ext.oe_fecha_llegada_est = de_fecha_llega_est.DateTime.Date;
                if (de_fecha_embarque_est.EditValue == null) info_oc_ext.oe_fecha_embarque_est = null; else info_oc_ext.oe_fecha_embarque_est = de_fecha_embarque_est.DateTime.Date;

                info_oc_ext.lst_det = new List<imp_orden_compra_ext_det_Info>(blst_det);
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
                txt_IdOrden_compra_ext.Text = string.Empty;
                txt_codigo.Text = string.Empty;
                txt_observacion.Text = string.Empty;
                txt_valor_flete.Text = string.Empty;
                txt_valor_seguro.Text = string.Empty;

                cmb_plancta.EditValue = null;
                cmb_proveedor.EditValue = null;
                cmb_catalogo_forma_pago.EditValue = null;
                cmb_catalogo_vias.EditValue = null;
                cmb_ciudad_destino.EditValue = null;
                cmb_pais_embarque.EditValue = null;
                cmb_pais_origen.EditValue = null;
                cmb_moneda_destino.EditValue = null;
                cmb_moneda_origen.EditValue = null;

                de_Fecha.DateTime = DateTime.Now.Date;
                de_fecha_desaduanizacion_est.EditValue = null;
                de_fecha_embarque_est.EditValue = null;
                de_fecha_llega_est.EditValue = null;
                lbl_anulado.Visible = false;
                blst_det = new BindingList<imp_orden_compra_ext_det_Info>();
                gridControl_det.DataSource = blst_det;

                Accion = Cl_Enumeradores.eTipo_action.grabar;
                cargar_combos();
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImp_orden_compra_ext_mant_Load(object sender, EventArgs e)
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

        private bool validar()
        {
            try
            {
                txt_IdOrden_compra_ext.Focus();

                if (cmb_proveedor.EditValue == null)
                {
                    MessageBox.Show("Seleccione el proveedor",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_plancta.EditValue == null)
                {
                    MessageBox.Show("Seleccione la cuenta contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_pais_embarque.EditValue == null)
                {
                    MessageBox.Show("Seleccione el pais de embarque", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_pais_origen.EditValue == null)
                {
                    MessageBox.Show("Seleccione el pais de origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_moneda_origen.EditValue == null)
                {
                    MessageBox.Show("Seleccione la moneda origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_moneda_destino.EditValue == null)
                {
                    MessageBox.Show("Seleccione la moneda destino", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_ciudad_destino.EditValue == null)
                {
                    MessageBox.Show("Seleccione la ciudad destino", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_catalogo_forma_pago.EditValue == null)
                {
                    MessageBox.Show("Seleccione la forma de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_catalogo_vias.EditValue == null)
                {
                    MessageBox.Show("Seleccione la vía de embarque", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_det.Count == 0)
                {
                    MessageBox.Show("Seleccione los productos a importarse", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in blst_det)
                {
                    if (item.od_cantidad == 0)
                    {
                        MessageBox.Show("Existen items con cantidad 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
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

                if (bus_oc_ext.guardarDB(info_oc_ext))
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

                if (bus_oc_ext.modificarDB(info_oc_ext))
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

                if (bus_oc_ext.anularDB(info_oc_ext))
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

        private void menu_event_btnGuardar_Click(object sender, EventArgs e)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnAnular_Click(object sender, EventArgs e)
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

        private void gridView_det_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                imp_orden_compra_ext_det_Info row = (imp_orden_compra_ext_det_Info)gridView_det.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_IdProducto)
                {
                    in_Producto_Info row_producto = lst_producto.FirstOrDefault(q => q.IdProducto == row.IdProducto);
                    if (row_producto == null)
                        return;
                    row.IdUnidadMedida = row_producto.IdUnidadMedida;
                }

                if (e.Column == col_cantidad || e.Column == col_costo || e.Column == col_por_descuento)
                {
                    row.od_descuento = (row.od_costo * row.od_por_descuento) / 100;
                    row.od_costo_final = row.od_costo - row.od_descuento;
                    row.od_subtotal = row.od_costo_final * row.od_cantidad;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_det_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_det.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}