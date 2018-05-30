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
using Core.Erp.Business.Roles;
using Cus.Erp.Reports.FJ.Roles;

namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROL_Rpt002_frm : Form
    {
        public XROL_Rpt002_frm()
        {
            InitializeComponent();
            ucRo_Menu_Reportes.event_cmdImprimir_ItemClick += ucRo_Menu_Reportes_event_cmdImprimir_ItemClick;
            
        }
        int _idEmpresa;
        decimal _idEmpleado;
        int _idNominaTipo;
        int _idNominaTipoLiqui;
        int _idPeriodo;
        int _IdDepartamento = 0;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Empleado_Info> ListaE = new List<ro_Empleado_Info>();
        ro_Empleado_Bus BusE = new ro_Empleado_Bus();

        void ucRo_Menu_Reportes_event_cmdImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void XROL_Rpt002_frm_Load(object sender, EventArgs e)
        {
           
        }

        private void ucRo_Menu_Reportes_Load(object sender, EventArgs e)
        {

            
        }

        private void pu_GenerarReporte()
        {
            try
            {
                XROL_Rpt003_rpt Reporte = new XROL_Rpt003_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;


                if (pu_setInfo())
                {

                    ro_periodo_x_ro_Nomina_TipoLiqui_Info info_perio = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                    info_perio = ucRo_Menu_Reportes.Get_Info_Periodo();
                    Reporte.Parameters["IdEmpresa"].Value = _idEmpresa;
                    Reporte.Parameters["IdNomina"].Value = _idNominaTipo;
                    Reporte.Parameters["anio"].Value = info_perio.pe_FechaFin.Year;
                    Reporte.Parameters["mes"].Value = info_perio.pe_FechaFin.Month;


                    if (_idEmpleado != 0)
                    {
                        ListaE = BusE.Get_Lis_Empleado_x_Periodo_Nomina(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo).Where(v => v.IdEmpleado == _idEmpleado).ToList().OrderBy(x => x.pe_apellido).ToList();
                    }

                    if (_IdDepartamento != 0 && _idEmpleado == 0)
                    {
                        ListaE = BusE.Get_Lis_Empleado_x_Periodo_Nomina(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo).Where(v => v.IdDepartamento == _IdDepartamento).ToList().OrderBy(x => x.pe_apellido).ToList();
                    }

                    if (_idEmpleado == 0 && _IdDepartamento == 0)
                    {
                        ListaE = BusE.Get_Lis_Empleado_x_Periodo_Nomina(param.IdEmpresa, _idNominaTipo, _idNominaTipoLiqui, _idPeriodo);
                    }

                    if (ListaE.Count() == 0)
                    {
                        MessageBox.Show("No hay datos para la consulta", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        return;
                    }
                    else
                    {
                        Reporte.ListEmpleado(ListaE);
                        Reporte.Landscape = true;
                        Reporte.ShowPreview();
                    }



                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private Boolean pu_setInfo()
        {
            try
            {
                _idEmpresa = param.IdEmpresa;
                _idNominaTipo = Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipo());
                _idNominaTipoLiqui = Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipoLiqui());
                _idPeriodo = Convert.ToInt32(ucRo_Menu_Reportes.getIdPeriodo());
                _idEmpleado = Convert.ToInt32(ucRo_Menu_Reportes.getIdEmpleado());
                if (ucRo_Menu_Reportes.getIdDepartamento() != "")
                {
                    _IdDepartamento = Convert.ToInt32(ucRo_Menu_Reportes.getIdDepartamento());
                }
                else
                {
                    _IdDepartamento = 0;
                }
                _idEmpleado = Convert.ToInt32(ucRo_Menu_Reportes.getIdEmpleado());
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void ucRo_Menu_Reportes_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            pu_GenerarReporte();
        }

        private void ucRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

    }
}
