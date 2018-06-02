using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_factura_det_x_fa_descuento : Form
    {
        #region
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<fa_factura_det_x_fa_descuento_Info> blst_descuento_x_factura = new BindingList<fa_factura_det_x_fa_descuento_Info>();
        List<fa_descuento_Info> lst_descuento = new List<fa_descuento_Info>();
        fa_descuento_Bus bus_descuento = new fa_descuento_Bus();
        fa_factura_det_info info_factura_det = new fa_factura_det_info();
        List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();
        string MensajeError = "";
        public DialogResult Dialog_result = DialogResult.Cancel;
        #endregion

        public frmFa_factura_det_x_fa_descuento()
        {
            InitializeComponent();
        }

        public void set_info(fa_factura_det_info _info)
        {
            try
            {
                info_factura_det = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public fa_factura_det_info get_info()
        {
            try
            {
                info_factura_det.lst_descuento_x_factura_det = new List<fa_factura_det_x_fa_descuento_Info>(blst_descuento_x_factura);

                return info_factura_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new fa_factura_det_info();
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                blst_descuento_x_factura = new BindingList<fa_factura_det_x_fa_descuento_Info>();

                cmb_producto.EditValue = info_factura_det.IdProducto;
                txt_Cantidad.Text = info_factura_det.vt_cantidad.ToString();
                txt_iva.Text = info_factura_det.vt_iva.ToString();
                txt_precio.Text = info_factura_det.vt_Precio.ToString();
                txt_descuento.Text = info_factura_det.vt_DescUnitario.ToString();
                txt_subtotal.Text = info_factura_det.vt_Subtotal.ToString();
                txt_total.Text = info_factura_det.vt_total.ToString();

                blst_descuento_x_factura = new BindingList<fa_factura_det_x_fa_descuento_Info>(info_factura_det.lst_descuento_x_factura_det);
                gridControl_descuento.DataSource = blst_descuento_x_factura;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                blst_descuento_x_factura = new BindingList<fa_factura_det_x_fa_descuento_Info>();
                calcular();
                
                Dialog_result = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_producto.Focus();
                Dialog_result = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFa_factura_det_x_fa_descuento_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                set_info_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto.Properties.DataSource = lst_producto;

                lst_descuento = bus_descuento.Get_Lista_Descuento(param.IdEmpresa, ref MensajeError);
                cmb_descuento.DataSource = lst_descuento;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcular()
        {
            try
            {
                info_factura_det.lst_descuento_x_factura_det = new List<fa_factura_det_x_fa_descuento_Info>();
                info_factura_det.vt_DescUnitario = 0;
                info_factura_det.vt_PorDescUnitario = 0;
                foreach (var item in blst_descuento_x_factura)
                {
                    info_factura_det.vt_DescUnitario += item.de_valor* Convert.ToDouble(txt_Cantidad.Text);
                    info_factura_det.vt_PorDescUnitario += item.de_porcentaje;
                }
                info_factura_det.vt_PrecioFinal = info_factura_det.vt_Precio - info_factura_det.vt_DescUnitario;
                info_factura_det.vt_Subtotal = info_factura_det.vt_PrecioFinal * info_factura_det.vt_cantidad;
                info_factura_det.vt_iva = Convert.ToDouble((info_factura_det.vt_por_iva)/100) * info_factura_det.vt_Subtotal;
                info_factura_det.vt_total = info_factura_det.vt_Subtotal + info_factura_det.vt_iva;
                info_factura_det.lst_descuento_x_factura_det = new List<fa_factura_det_x_fa_descuento_Info>(blst_descuento_x_factura);
                set_info_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_descuento_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_descuento_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_factura_det_x_fa_descuento_Info row = (fa_factura_det_x_fa_descuento_Info)gridView_descuento.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_IdDescuento)
                {
                    fa_descuento_Info info_descuento = lst_descuento.FirstOrDefault(q => q.IdDescuento == row.IdDescuento);
                    if (info_descuento!= null)
                    {
                        row.de_porcentaje = info_descuento.de_porcentaje;
                        row.de_valor = info_factura_det.vt_Precio * Convert.ToDouble(row.de_porcentaje / 100);                        
                    }
                }

                calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_descuento_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_descuento.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
