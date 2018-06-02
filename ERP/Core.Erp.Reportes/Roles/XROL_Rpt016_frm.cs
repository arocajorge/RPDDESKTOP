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
    public partial class XROL_Rpt016_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus Departamento_bus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> Lis_Departamento = new List<ro_Departamento_Info>();
        ro_rubro_tipo_Bus Rubro_Bus = new ro_rubro_tipo_Bus();
        List<ro_rubro_tipo_Info> List_rubro = new List<ro_rubro_tipo_Info>();
        ro_Empleado_Bus Empleado_Bus = new ro_Empleado_Bus();
        List<ro_Empleado_Info> Lis_Empleado = new List<ro_Empleado_Info>();

        public XROL_Rpt016_frm()
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
                string rubros_ = "";

                List<string> lista_filtrar = new List<string>();

                lista_filtrar = ucRo_Menu.GetListEstados();

                foreach (var item in lista_filtrar)
                {
                    rubros_ += item.ToString();
                }

                XROL_Rpt016_Rpt Reporte = new XROL_Rpt016_Rpt();


                Reporte.RequestParameters = false;
                Reporte.Parameters["s_fechaInicial"].Value = Convert.ToString(ucRo_Menu.getFechaInicial());
                Reporte.Parameters["s_fechaFinal"].Value = Convert.ToString(ucRo_Menu.getFechaFinal());
                Reporte.Parameters["p_IdDepartamento"].Value = ucRo_Menu.getIdDepartamento() == "" ? 0 : Convert.ToInt32(ucRo_Menu.getIdDepartamento());
                Reporte.Parameters["p_idnomina"].Value = ucRo_Menu.getIdNominaTipo() == "" ? 0 : Convert.ToInt32(ucRo_Menu.getIdNominaTipo());
                Reporte.Parameters["idrubro"].Value = ucRo_Menu.getIdRubro() == "" ? 0 : Convert.ToInt32(ucRo_Menu.getIdRubro());
                Reporte.Parameters["p_IdEmpleado"].Value = ucRo_Menu.getIdEmpleado() == 0 ? 0 : Convert.ToInt32(ucRo_Menu.getIdEmpleado());
                Reporte.Parameters["p_iddivision"].Value = ucRo_Menu.getIdDivision() == "" ? 0 : Convert.ToInt32(ucRo_Menu.getIdDivision());

                
                
                Reporte.CreateDocument();
                Reporte.ShowPreview();

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
                Cargar_Datos();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void Cargar_Datos()
        {

            try
            {

                List<string> lista_rub = new List<string>();


                List_rubro = Rubro_Bus.Get_listarubro_provisiones(param.IdEmpresa);
                foreach (var item in List_rubro)
                {
                    lista_rub.Add(item.ru_descripcion);
                }

                ucRo_Menu.SetEstado(lista_rub);
            }
            catch (Exception )
            {
                
                throw;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    pu_GenerarReporte();
                }
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
                /*
                if (cmbnomina.EditValue == null)
                {
                    bandera = false;
                  //  MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la)+"nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                      MessageBox.Show("Seleccione la nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (cmb_Departamento.EditValue== null)
                {
                    bandera = false;
                    MessageBox.Show("Seleccione el departamento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //if (cmbRubros.EditValue == null)
                //{
                //    bandera = false;
                //    MessageBox.Show("Seleccione el rubro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
               
                if (Convert.ToDateTime( dtp_fecha_inicio.EditValue).Date >Convert.ToDateTime( dtp_fecha_fin.EditValue).Date)
                {
                    bandera = false;
                    MessageBox.Show("fecha inicio no puede ser mayor que la fecha final", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                */
                return bandera;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return bandera;
            }
        
        }

       

      
    
        private void ucRo_Menu_event_btnsalir_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Close();

        }

        private void ucRo_Menu_event_cmdCargar_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            pu_GenerarReporte();
        }

    
       
    }
}
