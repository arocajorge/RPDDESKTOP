using Core.Erp.Business.Alerta;
using Core.Erp.Business.General;
using Core.Erp.Info.Alerta;
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

namespace Core.Erp.Alertas.Inventario
{
    public partial class XINV_001_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<XINV_001_Info> lst_rpt = new List<XINV_001_Info>();
        XINV_001_Bus bus_rpt = new XINV_001_Bus();
        tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info info_alerta = new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info();
        tb_sis_alerta_x_usuario_x_empresa_x_eventos_Bus bus_alerta = new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Bus();
        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();

        public XINV_001_frm()
        {
            InitializeComponent();
        }

        private void XINV_001_frm_Load(object sender, EventArgs e)
        {
            try
            {
                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.Properties.DataSource = lst_sucursal;
                info_alerta = bus_alerta.get_list(param.IdEmpresa, param.IdUsuario, "INV_001").FirstOrDefault();
                cmb_sucursal.EditValue = info_alerta.IdSucursal;

                load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_data()
        {
            try
            {
                lst_rpt = bus_rpt.get_list(param.IdEmpresa, cmb_sucursal.EditValue == null ? 0 : Convert.ToInt32(cmb_sucursal.EditValue), chk_mostrar_todo.Checked);
                gridControl_alerta.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl_alerta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
