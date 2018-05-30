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
    public partial class XROL_Rpt019_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus Departamento_bus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> Lis_Departamento = new List<ro_Departamento_Info>();
        ro_rubro_tipo_Bus Rubro_Bus = new ro_rubro_tipo_Bus();
        List<ro_rubro_tipo_Info> List_rubro = new List<ro_rubro_tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();


        public XROL_Rpt019_frm()
        {
            InitializeComponent();
        }


        private void GenerarReporte()
        {
            try
            {
                XROL_Rpt019_rpt Reporte = new XROL_Rpt019_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;
                Reporte.Parameters["idNominaTipo"].Value = ucRo_Menu.getIdNominaTipo()==""?"0":ucRo_Menu.getIdNominaTipo();
                Reporte.Parameters["idNominaTipoLiqui"].Value = ucRo_Menu.getIdNominaTipoLiqui() == "" ? "0" : ucRo_Menu.getIdNominaTipoLiqui(); 

                Reporte.Parameters["fecha_inicio"].Value = ucRo_Menu.getFechaInicial();
                Reporte.Parameters["fecha_fin"].Value = ucRo_Menu.getFechaFinal();

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
                
                if (Convert.ToDateTime(ucRo_Menu.getFechaInicial()).Date > Convert.ToDateTime(ucRo_Menu.getFechaFinal()).Date )
                {
                    bandera = false;
                    MessageBox.Show("fecha inicio no puede ser mayor que la fecha final", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (ucRo_Menu.getIdNominaTipo()=="")
                {
                    bandera = false;
                    MessageBox.Show("Seleccione la nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (ucRo_Menu.getIdNominaTipoLiqui() == "")
                {
                    bandera = false;
                    MessageBox.Show("Seleccione la proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       

       

        private void XROL_Rpt019_frm_Load(object sender, EventArgs e)
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

        private void ucRo_Menu_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (validar())
                {
                    GenerarReporte();
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void printControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
