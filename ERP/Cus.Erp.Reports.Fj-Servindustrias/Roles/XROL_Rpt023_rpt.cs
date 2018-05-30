using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Drawing.Printing;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Roles;
using System.Collections.Generic;
using System.Collections;


namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROL_Rpt023_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<ro_Empleado_Info> ListaEmpleado = new List<ro_Empleado_Info>();

        public XROL_Rpt023_rpt()
        {
            InitializeComponent();
            xrSubreportRol.ReportSource.RequestParameters = false;
        }

        private void XROL_Rpt012_rpt_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {
                this.DataSource = ListaEmpleado;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void xrSubreportRol_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {

                int idEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                decimal idEmpleado = ((ro_Empleado_Info)GetCurrentRow()).IdEmpleado;
                int idNominaTipo = Convert.ToInt32(this.IdNomina.Value);
                int mes = Convert.ToInt32(this.mes.Value);
                int anio = Convert.ToInt32(this.anio.Value);

                ((XRSubreport)sender).ReportSource.Parameters["IdEmpresa_"].Value = idEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["IdEmpleado_"].Value = idEmpleado;
                ((XRSubreport)sender).ReportSource.Parameters["IdNomina"].Value = idNominaTipo;
                ((XRSubreport)sender).ReportSource.Parameters["anio"].Value = anio;
                ((XRSubreport)sender).ReportSource.Parameters["mes"].Value = mes;
                ((XRSubreport)sender).ReportSource.RequestParameters = false;

            }
            catch (Exception ex)
            {
                
                
            }


            




        }
        
       
        

        public void ListEmpleado(List<ro_Empleado_Info> Lis)
        {
            try
            {
                ListaEmpleado = Lis;
            }
            catch (Exception)
            {
                
               
            }
        }

     

        private void xrSubreportRolCopia_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {


                int idEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                decimal idEmpleado = ((ro_Empleado_Info)GetCurrentRow()).IdEmpleado;
                int idNominaTipo = Convert.ToInt32(this.IdNomina.Value);
                int mes = Convert.ToInt32(this.mes.Value);
                int anio = Convert.ToInt32(this.anio.Value);

                ((XRSubreport)sender).ReportSource.Parameters["IdEmpresa_"].Value = idEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["IdEmpleado_"].Value = idEmpleado;
                ((XRSubreport)sender).ReportSource.Parameters["IdNomina"].Value = idNominaTipo;
                ((XRSubreport)sender).ReportSource.Parameters["anio"].Value = anio;
                ((XRSubreport)sender).ReportSource.Parameters["mes"].Value = mes;
                ((XRSubreport)sender).ReportSource.RequestParameters = false;
            }
            catch (Exception ex)
            {


            }

        }

        
    }
}
