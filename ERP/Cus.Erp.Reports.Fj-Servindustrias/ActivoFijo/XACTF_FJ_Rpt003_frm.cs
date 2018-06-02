using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public partial class XACTF_FJ_Rpt003_frm : Form
    {
        public XACTF_FJ_Rpt003_frm()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        private void btn_Impromir_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }


        private void GenerarReporte()
        {
            try
            {
                XACTF_FJ_Rpt003_Rpt Reporte = new XACTF_FJ_Rpt003_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdCentro"].Value = (ucactF_Menu_Reportes1.cmb_centro_costo.EditValue==null)?"":ucactF_Menu_Reportes1.cmb_centro_costo.EditValue.ToString();
                Reporte.Parameters["IsSubcentro"].Value = (ucactF_Menu_Reportes1.cmb_subcentrocosto.EditValue==null)?"":ucactF_Menu_Reportes1.cmb_subcentrocosto.EditValue.ToString();
                Reporte.Parameters["ubicacion"].Value = (ucactF_Menu_Reportes1.bariten_ubicacion.EditValue);
                Reporte.Parameters["fi"].Value = (ucactF_Menu_Reportes1.dtpFechaIni.EditValue);
                Reporte.Parameters["ff"].Value = (ucactF_Menu_Reportes1.dtpFechaFin.EditValue);
                printControl1.PrintingSystem = Reporte.PrintingSystem;
                printControl1.Enabled = true;
                Reporte.CreateDocument();
                
            }
            catch (Exception ex)
            {
            }
        }

        private void ucactF_Menu_Reportes1_event_btnGenerar_ItemClick(object sender, ItemClickEventArgs e)
        {
            GenerarReporte();
        }

        private void ucactF_Menu_Reportes1_event_btnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

    

      
    }
}
