using Core.Erp.Business.General;
using Core.Erp.Info.General;
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

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_producto_alerta_x_sucursal : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
        BindingList<in_Producto_alerta_x_sucursal_Info> blst_producto = new BindingList<in_Producto_alerta_x_sucursal_Info>();
        in_Producto_alerta_x_sucursal_Bus bus_producto = new in_Producto_alerta_x_sucursal_Bus();
        #endregion

        public FrmIn_producto_alerta_x_sucursal()
        {
            InitializeComponent();
        }

        private void cargar_combos()
        {
            try
            {
                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.Properties.DataSource = lst_sucursal;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_sucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_sucursal.EditValue != null)
                {
                    blst_producto = new BindingList<in_Producto_alerta_x_sucursal_Info>(bus_producto.get_list(param.IdEmpresa, Convert.ToInt32(cmb_sucursal.EditValue)));
                }
                else
                    blst_producto = new BindingList<in_Producto_alerta_x_sucursal_Info>();
                gridControl_productos.DataSource = blst_producto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_producto_alerta_x_sucursal_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_sucursal.Focus();

                if (cmb_sucursal.EditValue == null)
                {
                    MessageBox.Show("Seleccione la sucursal ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                List<in_Producto_alerta_x_sucursal_Info> lst = get_info();

                if (bus_producto.guardarDB(lst, param.IdEmpresa, Convert.ToInt32(cmb_sucursal.EditValue)))
                {
                    cmb_sucursal.EditValue = null;   
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_sucursal.Focus();

                if (cmb_sucursal.EditValue == null)
                {
                    MessageBox.Show("Seleccione la sucursal ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                List<in_Producto_alerta_x_sucursal_Info> lst = get_info();
                
                if (bus_producto.guardarDB(lst,param.IdEmpresa,Convert.ToInt32(cmb_sucursal.EditValue)))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<in_Producto_alerta_x_sucursal_Info> get_info()
        {
            try
            {
                List<in_Producto_alerta_x_sucursal_Info> Lista = new List<in_Producto_alerta_x_sucursal_Info>(blst_producto.Where(q => q.se_controla_stock_minimo == true).ToList());

                foreach (var item in Lista)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdSucursal = Convert.ToInt32(cmb_sucursal.EditValue);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<in_Producto_alerta_x_sucursal_Info>();
            }
        }
    }
}
