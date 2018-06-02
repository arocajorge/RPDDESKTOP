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
    public partial class XROL_Rpt022_frm: Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus Departamento_bus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> Lis_Departamento = new List<ro_Departamento_Info>();
        ro_Empleado_Bus Empleado_Bus = new ro_Empleado_Bus();
        List<ro_Empleado_Info> Lis_Empleado = new List<ro_Empleado_Info>();

        public XROL_Rpt022_frm()
        {
            InitializeComponent();
            
            
        }

       

        private void ucRo_Menu_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void ucRo_Menu_event_cmdImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void ucRo_Menu_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pu_GenerarReporte();

        }

        private void pu_GenerarReporte()
        {
            try
            {
                XROL_Rpt022_Rpt Reporte = new XROL_Rpt022_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;
                Reporte.Parameters["s_fechaInicial"].Value= ucRo_Menu_Reportes1.getFechaInicial()==""?DateTime.Now.Date: Convert.ToDateTime(ucRo_Menu_Reportes1.getFechaInicial());
                Reporte.Parameters["s_fechaFinal"].Value = ucRo_Menu_Reportes1.getFechaFinal() == "" ? DateTime.Now.Date : Convert.ToDateTime(ucRo_Menu_Reportes1.getFechaFinal());
                Reporte.Parameters["p_IdEmpleado"].Value =ucRo_Menu_Reportes1.getIdEmpleado()==0?0: Convert.ToInt32(ucRo_Menu_Reportes1.getIdEmpleado());

                
                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void XROL_Rpt016_frm_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

          private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            
        }

       

      

   
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printControlReporte_Load(object sender, EventArgs e)
        {

        }

        private void ucRo_Menu_Reportes1_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_Reportes1_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            pu_GenerarReporte();
        }

       
    }
}
