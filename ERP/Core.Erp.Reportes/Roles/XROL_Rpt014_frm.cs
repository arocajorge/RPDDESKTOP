using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt014_frm : Form
    {
        public XROL_Rpt014_frm()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<ro_Nomina_Tipo_Info> ListadoNomina = new List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus Bus_Nomina = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus Bus_Departamento = new ro_Departamento_Bus();
        List<ro_Departamento_Info> ListadoDepartamento = new List<ro_Departamento_Info>();
        List<ro_Empleado_Info> ListaEmpleado = new List<ro_Empleado_Info>();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        List<XROL_Rpt014_Info> listado_Rubos_x_Empleado = new List<XROL_Rpt014_Info>();
        XROL_Rpt014_Bus Bus_list_Rubros = new XROL_Rpt014_Bus();
        int idnomina = 0;
        int iddivision = 0;

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void XROL_Rpt014_frm_Load(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnGenerar_Reporte_Click(object sender, EventArgs e)
        {
           
        }

        private void ucRo_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_Reportes1_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                idnomina =ucRo_Menu_Reportes1.getIdNominaTipo()==""?0: Convert.ToInt32(ucRo_Menu_Reportes1.getIdNominaTipo());
                iddivision =(ucRo_Menu_Reportes1.getIdDivision()=="")?0: Convert.ToInt32(ucRo_Menu_Reportes1.getIdDivision());
                if (iddivision != 0)
                    listado_Rubos_x_Empleado = Bus_list_Rubros.Get_list_Rubros_X_Empleados(param.IdEmpresa, Convert.ToInt32(idnomina), Convert.ToInt32(iddivision));
                else

                    listado_Rubos_x_Empleado = Bus_list_Rubros.Get_list_Rubros_X_Empleados(param.IdEmpresa, Convert.ToInt32(idnomina));



                XROL_Rpt014_Rpt reporte = new XROL_Rpt014_Rpt();

                reporte.Set_Lista(listado_Rubos_x_Empleado);
                ReportPrintTool pt = new ReportPrintTool(reporte);
                reporte.CreateDocument();
                pt.ShowPreview();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
