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
    public partial class XACTF_FJ_Rpt002_frm : Form
    {
        public XACTF_FJ_Rpt002_frm()
        {
            InitializeComponent();
        }


        List<Af_Activo_fijo_Categoria_Info> lis_categoria = new List<Af_Activo_fijo_Categoria_Info>();
        Af_Activo_fijo_Categoria_Bus categoria_bus = new Af_Activo_fijo_Categoria_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private void GenerarReporte()
        {
            try
            {
                XACTF_FJ_Rpt002_Rpt Reporte = new XACTF_FJ_Rpt002_Rpt();
                
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                Reporte.Parameters["fechaInicial"].Value = Convert.ToDateTime(ucactF_Menu_Reportes1.dtpFechaIni.EditValue);
                Reporte.Parameters["fechaFinal"].Value = Convert.ToDateTime(ucactF_Menu_Reportes1.dtpFechaFin.EditValue);
                Reporte.Parameters["id_categoria"].Value = ucactF_Menu_Reportes1.barEditItemCategoria.EditValue == null ? 0 : Convert.ToInt32(ucactF_Menu_Reportes1.barEditItemCategoria.EditValue);


                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
            }
        }
        private void XACTF_FJ_Rpt002_frm_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void ucactF_Menu_Reportes1_event_btnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void ucactF_Menu_Reportes1_event_btnGenerar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                GenerarReporte();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
