using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt007_frm : Form
    {
        public XFAC_FJ_Rpt007_frm()
        {
            InitializeComponent();
            ucFa_Menu_Reportes1.bei_check_1.Caption = "Detallado";
        }

        private void ucFa_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!Convert.ToBoolean(ucFa_Menu_Reportes1.bei_check_1.EditValue))
                {
                    XFAC_FJ_Rpt007_Rpt rpt = new XFAC_FJ_Rpt007_Rpt();
                    rpt.IdCliente.Value = (ucFa_Menu_Reportes1.cmbCliente.EditValue == null) ? 0 :ucFa_Menu_Reportes1.cmbCliente.EditValue;
                    rpt.IdPeriodo.Value = ucFa_Menu_Reportes1.bei_periodo_fin.EditValue == null ? 0 : ucFa_Menu_Reportes1.bei_periodo_fin.EditValue;
                    if (rpt.IdPeriodo.Value.ToString().Length == 6)
                        rpt.es_mes.Value = obtener_mes(rpt.IdPeriodo.Value.ToString().Substring(4, 2)) + "  DEL  " + rpt.IdPeriodo.Value.ToString().Substring(0, 4);
                    ReportPrintTool pt = new ReportPrintTool(rpt);
                    printControl1.PrintingSystem = pt.PrintingSystem;
                    rpt.CreateDocument();
                }
                else
                {
                    XFAC_FJ_Rpt007_detallado_Rpt rpt = new XFAC_FJ_Rpt007_detallado_Rpt();
                    rpt.IdCliente.Value = (ucFa_Menu_Reportes1.cmbCliente.EditValue == null) ? 0 : ucFa_Menu_Reportes1.cmbCliente.EditValue;
                    rpt.IdPeriodo.Value = ucFa_Menu_Reportes1.bei_periodo_fin.EditValue == null ? 0 : ucFa_Menu_Reportes1.bei_periodo_fin.EditValue;
                    if (rpt.IdPeriodo.Value.ToString().Length == 6)
                        rpt.es_mes.Value = obtener_mes(rpt.IdPeriodo.Value.ToString().Substring(4, 2)) + "  DEL  " + rpt.IdPeriodo.Value.ToString().Substring(0, 4);
                    ReportPrintTool pt = new ReportPrintTool(rpt);
                    printControl1.PrintingSystem = pt.PrintingSystem;
                    rpt.CreateDocument();
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void ucFa_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                
               
            }
        }

        private string obtener_mes(string es_mes)
        {
            try
            {
                switch (es_mes)
                {
                    case "01":
                        return "ENERO";
                    case "02":
                        return "FEBRERO";
                    case "03":
                        return "MARZO";
                    case "04":
                        return "ABRIL";
                    case "05":
                        return "MAYO";
                    case "06":
                        return "JUNIO";
                    case "07":
                        return "JULIO";
                    case "08":
                        return "AGOSTO";
                    case "09":
                        return "SEPTIEMBRE";
                    case "10":
                        return "OCTUBRE";
                    case "11":
                        return "NOVIEMBRE";
                    case "12":
                        return "DICIEMBRE";
                    default:
                        return "";
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
