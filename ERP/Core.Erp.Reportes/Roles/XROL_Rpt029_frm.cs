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
    public partial class XROL_Rpt029_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<ro_Catalogo_Info> lista_catalogo = new System.Collections.Generic.List<ro_Catalogo_Info>();
        ro_Catalogo_Bus bus_catalogo = new ro_Catalogo_Bus();

        List<string> catalogo = new System.Collections.Generic.List<string>();

      

        ro_Departamento_Bus Departamento_bus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> Lis_Departamento = new List<ro_Departamento_Info>();
        ro_Cargo_Bus Cargo_bus = new ro_Cargo_Bus();
        List<ro_Cargo_Info> lista_cargo = new List<ro_Cargo_Info>();
        int _idEmpresa = 0;



        public XROL_Rpt029_frm()
        {
            InitializeComponent();

           

        }

        

        void ucRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private Boolean getInfo()
        {
            try
            {
                _idEmpresa = param.IdEmpresa;
                
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }

        private void CargarReporte()
        {
            try
            {
                string catalogo_busqueda="";


                foreach (var item in ucRo_Menu.GetListEstados())
                {
                    catalogo_busqueda += item.ToString();
                }

                XROL_Rpt029_rpt Reporte = new XROL_Rpt029_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;
                Reporte.Parameters["IdNomina"].Value =ucRo_Menu.getIdNominaTipo() == "" ? 0 : Convert.ToInt32(ucRo_Menu.getIdNominaTipo());
                Reporte.Parameters["iddivision"].Value = ucRo_Menu.getIdDivision() == "" ? 0 : Convert.ToInt32(ucRo_Menu.getIdDivision());
                Reporte.Parameters["fechai"].Value = ucRo_Menu.getFechaInicial() == "" ? "" : Convert.ToString(ucRo_Menu.getFechaInicial());
                Reporte.Parameters["fechaf"].Value = ucRo_Menu.getFechaFinal() == "" ? "" : Convert.ToString(ucRo_Menu.getFechaFinal());
                Reporte.Parameters["estado"].Value = catalogo_busqueda;
                Reporte.p_considerar_fecha_ingreso.Value = Convert.ToBoolean(ucRo_Menu.bei_check1.EditValue);


                Reporte.CreateDocument();
                Reporte.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      
        
        
        private void XROL_Rpt029_frm_Load(object sender, EventArgs e)
        {
            try
            {

                
                lista_catalogo = bus_catalogo.Get_List_Catalogo_x_Tipo(25);

                foreach (var item in lista_catalogo)
                {
                    catalogo.Add(item.ca_descripcion);
                }


                ucRo_Menu.SetEstado(catalogo);
            
}
            catch (Exception ex)
            {
                
            }
        }


     
        private void Cmbsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void ucRo_Menu_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarReporte();
        }


     
    }
}
