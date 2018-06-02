
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using DevExpress.XtraBars;
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


namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt010_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();

        int IdEmpresa = 0;
        decimal IdEmpleado = 0;
        int IdNomina = 0;
        DateTime FechaI;
        DateTime FechaFin;
        int IdDivision = 0;

        public XROL_Rpt010_frm()
        {
            InitializeComponent();

            ucRo_Menu_Reportes.event_btnsalir_ItemClick += ucRo_Menu_Reportes_event_btnsalir_ItemClick;

            ucRo_Menu_Reportes.event_cmdCargar_ItemClick += ucRo_Menu_Reportes_event_cmdCargar_ItemClick;
        }

        void ucRo_Menu_Reportes_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (getInfo())
            {
                pu_CargarReporte();
            }
        }

        void ucRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void XROL_Rpt010_frm_Load(object sender, EventArgs e)
        {
          
            ucRo_Menu_Reportes.setFechaInicial(param.Fecha_Transac.ToShortDateString());
            ucRo_Menu_Reportes.setFechaFinal(param.Fecha_Transac.ToShortDateString());

    
        }


        private Boolean getInfo() 
        {
            try {
                IdEmpresa = param.IdEmpresa;
                IdNomina = (ucRo_Menu_Reportes.getIdNominaTipo() == "") ? 0 : Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipo());
                IdEmpleado = (ucRo_Menu_Reportes.getIdEmpleado() == 0) ? 0 : Convert.ToDecimal(ucRo_Menu_Reportes.getIdEmpleado());
                FechaI = Convert.ToDateTime(ucRo_Menu_Reportes.getFechaInicial());
                FechaFin = Convert.ToDateTime(ucRo_Menu_Reportes.getFechaFinal());
                IdDivision = ucRo_Menu_Reportes.getIdDivision() == "" ? 0 : Convert.ToInt32(ucRo_Menu_Reportes.getIdDivision());
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        
        }




        private void pu_CargarReporte()
        {
            try
            {
                XROL_Rpt010_rpt Reporte = new XROL_Rpt010_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["p_IdEmpresa"].Value = IdEmpresa;
                Reporte.Parameters["p_idnomina"].Value = IdNomina;
                Reporte.Parameters["p_IdEmpleado"].Value = IdEmpleado;
                Reporte.Parameters["s_fechaInicial"].Value = FechaI;
                Reporte.Parameters["s_fechaFinal"].Value = FechaFin;
                Reporte.Parameters["s_iddivision"].Value = IdDivision;

               
                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

     

    }
}
