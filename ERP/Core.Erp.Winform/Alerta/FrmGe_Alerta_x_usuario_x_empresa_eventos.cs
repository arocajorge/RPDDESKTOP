using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Alerta;
using Core.Erp.Business.Alerta;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Alerta
{
    public partial class FrmGe_Alerta_x_usuario_x_empresa_eventos : Form
    {
        #region
        tb_sis_alerta_x_usuario_x_empresa_Info info_alerta = new tb_sis_alerta_x_usuario_x_empresa_Info();
        BindingList<tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info> blst_alerta = new BindingList<tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info>();
        Dictionary<int, string> enums;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public FrmGe_Alerta_x_usuario_x_empresa_eventos()
        {
            InitializeComponent();
        }

        public void set_info(tb_sis_alerta_x_usuario_x_empresa_Info _info)
        {
            try
            {
                info_alerta = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                enums = Enum.GetValues(typeof(Cl_Enumeradores.eEventos_alerta)).
                    Cast<Cl_Enumeradores.eEventos_alerta>().ToDictionary(x => (int)x, x => x.ToString());
                cmb_evento.DataSource = enums.ToList();

                blst_alerta = new BindingList<tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info>();
                tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info evento = new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info();
                evento.enum_evento = Cl_Enumeradores.eEventos_alerta.INICIO_SESION.ToString();
                blst_alerta.Add(evento);
                evento = new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info();
                evento.enum_evento = Cl_Enumeradores.eEventos_alerta.TRANSACCIONES.ToString();
                blst_alerta.Add(evento);
                evento = new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info();
                evento.enum_evento = Cl_Enumeradores.eEventos_alerta.CIERRE_SESION.ToString();
                blst_alerta.Add(evento);

                foreach (var item in info_alerta.lst_eventos)
                {
                    if (blst_alerta.Where(q=>q.enum_evento == item.enum_evento).Count() > 0)
                    {
                        blst_alerta.FirstOrDefault(q => q.enum_evento == item.enum_evento).seleccionado = true;
                    }
                }

                gridControl_eventos.DataSource = blst_alerta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Alerta_x_usuario_x_empresa_eventos_Load(object sender, EventArgs e)
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

        public tb_sis_alerta_x_usuario_x_empresa_Info get_info()
        {
            try
            {
                toolStrip1.Focus();
                info_alerta.lst_eventos = blst_alerta.Where(q => q.seleccionado == true).ToList();
                return info_alerta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
