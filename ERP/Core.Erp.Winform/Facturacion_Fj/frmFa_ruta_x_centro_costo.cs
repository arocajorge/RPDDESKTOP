using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion_FJ;
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

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_ruta_x_centro_costo : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_ruta_x_centro_costo_Bus bus_ruta_x_centro_costo = new fa_ruta_x_centro_costo_Bus();
        BindingList<fa_ruta_x_centro_costo_Info> blst_ruta_x_centro_costo = new BindingList<fa_ruta_x_centro_costo_Info>();
        List<ct_Centro_costo_Info> lst_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();
        #endregion

        public frmFa_ruta_x_centro_costo()
        {
            InitializeComponent();
        }

        private void cargar_combos()
        {
            try
            {
                string mensaje_error ="";
                lst_centro_costo = bus_centro_costo.Get_list_Centro_Costo_x_cliente(param.IdEmpresa, ref mensaje_error);
                cmb_centro_costo.Properties.DataSource = lst_centro_costo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                List<fa_ruta_x_centro_costo_Info> lst = new List<fa_ruta_x_centro_costo_Info>();
                
                if (cmb_centro_costo.EditValue != null)
                {
                    string IdCentroCosto = cmb_centro_costo.EditValue.ToString();

                    lst = bus_ruta_x_centro_costo.get_list(param.IdEmpresa, IdCentroCosto, false);
                    lst.AddRange(bus_ruta_x_centro_costo.get_no_list(param.IdEmpresa, IdCentroCosto));
                }                

                blst_ruta_x_centro_costo = new BindingList<fa_ruta_x_centro_costo_Info>(lst);
                gridControl_ruta_x_centro_costo.DataSource = blst_ruta_x_centro_costo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_centro_costo.EditValue == null)
                {
                    MessageBox.Show("Seleccione el centro de costo",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                List<fa_ruta_x_centro_costo_Info> lst = new List<fa_ruta_x_centro_costo_Info>(blst_ruta_x_centro_costo);
                bus_ruta_x_centro_costo.eliminarDB(param.IdEmpresa, cmb_centro_costo.EditValue.ToString());
                if (bus_ruta_x_centro_costo.guardarDB(lst))
                {
                    MessageBox.Show("Registros guardados exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cmb_centro_costo.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_centro_costo.EditValue == null)
                {
                    MessageBox.Show("Seleccione el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                List<fa_ruta_x_centro_costo_Info> lst = new List<fa_ruta_x_centro_costo_Info>(blst_ruta_x_centro_costo);
                bus_ruta_x_centro_costo.eliminarDB(param.IdEmpresa, cmb_centro_costo.EditValue.ToString());
                if (bus_ruta_x_centro_costo.guardarDB(lst))
                {
                    MessageBox.Show("Registros guardados exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void frmFa_ruta_x_centro_costo_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
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
