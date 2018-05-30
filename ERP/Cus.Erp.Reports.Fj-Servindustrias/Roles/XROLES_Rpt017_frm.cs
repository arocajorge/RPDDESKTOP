using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraBars;
using Core.Erp.Info.Roles;
using System.IO;
using System.Diagnostics;

namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROLES_Rpt017_frm : Form
    {
        public XROLES_Rpt017_frm()
        {
            InitializeComponent();
        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<XROLES_Rpt017_Info> lista = new List<XROLES_Rpt017_Info>();
        XROLES_Rpt017_Bus bus = new XROLES_Rpt017_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_perio = new Core.Erp.Info.Roles.ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        private void ucRo_Menu_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GenerarReporte();
        }



        private void GenerarReporte()
        {
            try
            {
                XROLES_Rpt017_Rpt Reporte = new XROLES_Rpt017_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;


                ro_periodo_x_ro_Nomina_TipoLiqui_Info infoperiodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                info_perio = ucRo_Menu.Get_Info_Periodo();

                Reporte.Parameters["idnomina"].Value = ucRo_Menu.getIdNominaTipo();
                Reporte.Parameters["iddivision"].Value = ucRo_Menu.getIdDivision();

                Reporte.Parameters["fechai"].Value =ucRo_Menu.getFechaInicial();
                Reporte.Parameters["fechaf"].Value = ucRo_Menu.getFechaFinal();
                Reporte.ShowPreview();


                  


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucRo_Menu_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
              
            }
        }

        private void pivotGridControl1_Click(object sender, EventArgs e)
        {

        }

    }
}
