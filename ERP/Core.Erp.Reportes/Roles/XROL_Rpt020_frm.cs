using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt020_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus Departamento_bus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> Lis_Departamento = new List<ro_Departamento_Info>();
        ro_Empleado_Bus Empleado_Bus = new ro_Empleado_Bus();
        List<ro_Empleado_Info> Lis_Empleado = new List<ro_Empleado_Info>();
        public XROL_Rpt020_frm()
        {
            InitializeComponent();
        }



        private void pu_GenerarReporte()
        {
            try
            {
                XROL_Rpt020_rpt Reporte = new XROL_Rpt020_rpt();

                Reporte.RequestParameters = false;
                Reporte.Parameters["fechaInicial"].Value = Convert.ToDateTime(ucRo_Menu.getFechaInicial());
                Reporte.Parameters["fechaFinal"].Value = Convert.ToDateTime(ucRo_Menu.getFechaInicial());
                Reporte.Parameters["idnomina"].Value = ucRo_Menu.getIdNominaTipo() == "" ? 0 : Convert.ToInt32(ucRo_Menu.getIdNominaTipo());
                Reporte.CreateDocument();
                Reporte.ShowPreview();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

         public bool validar()
        {
            bool bandera = true;
            try
            {
                if (ucRo_Menu.getIdNominaTipo() == "") 
                {
                    bandera = false;
                    //  MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la)+"nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Seleccione la nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }




                if (Convert.ToDateTime(ucRo_Menu.getFechaInicial()).Date > Convert.ToDateTime(ucRo_Menu.getFechaFinal()).Date) 
                {
                    bandera = false;
                    MessageBox.Show("fecha inicio no puede ser mayor que la fecha final", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return bandera;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return bandera;
            }

        }

        private void XROL_Rpt020_frm_Load(object sender, EventArgs e)
        {
           
        }

       

        private void ucRo_Menu_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                pu_GenerarReporte();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
