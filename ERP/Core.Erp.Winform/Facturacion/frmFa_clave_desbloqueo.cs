using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_clave_desbloqueo : Form
    {
        public DialogResult Result;
        cl_parametrosGenerales_Bus param;

        public frmFa_clave_desbloqueo()
        {
            InitializeComponent();
            Result = DialogResult.No;
            param = cl_parametrosGenerales_Bus.Instance;
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            if(txt_clave_desbloqueo.Text == "")
                MessageBox.Show("Ingrese la contraseña", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            fa_parametro_info info_param = new fa_parametro_info();
            fa_parametro_Bus bus_param = new fa_parametro_Bus();
            info_param = bus_param.Get_Info_parametro(param.IdEmpresa);
            if (info_param.clave_desbloqueo_precios == txt_clave_desbloqueo.Text)
            {
                Result = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
            else
            {
                Result = System.Windows.Forms.DialogResult.No;
                MessageBox.Show("Contraseña invalida",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txt_clave_desbloqueo.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Result = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void txt_clave_desbloqueo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_validar_Click(null, null);
            }
        }
    }
}
