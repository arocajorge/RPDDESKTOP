
using System;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt004_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        public XROL_Rpt004_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt004_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
            lb_nombrecomercial.Text = param.InfoEmpresa.em_nombre;


            XROL_Rpt004_Bus oReporteBus = new XROL_Rpt004_Bus();
            List<XROL_Rpt004_Info> oListado = new List<XROL_Rpt004_Info>();

            int idEmpresa = param.IdEmpresa;
            int IdDepartamento=Convert.ToInt32(Parameters["p_IdDepartamento"].Value);
            DateTime fechaInicial = Convert.ToDateTime(Parameters["s_fechaInicial"].Value);
            DateTime fechaFinal = Convert.ToDateTime(Parameters["s_fechaFinal"].Value);

            decimal idEmpleado = Convert.ToDecimal(Parameters["p_IdEmpleado"].Value);            
            decimal idDivision = Convert.ToDecimal(Parameters["p_IdDivision"].Value);
            string idCentroCosto = Parameters["p_IdCentroCosto"].Value.ToString();
            string idRubro = Parameters["p_IdRubro"].Value.ToString();
            string estado = Parameters["estado"].Value.ToString();

            // Reporte.Parameters["p_IdDepartamento"].Value = ucRo_Menu_Reportes.getIdDepartamento();

                        
            //FILTROS



            if (idRubro == "" && idEmpleado > 0 && IdDepartamento == 0 && idDivision==0 )
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal,  Convert.ToInt32(idEmpleado),  estado);
                this.DataSource = oListado.ToArray();
                return;
            }


            if ( idRubro != "" && idEmpleado>0 && IdDepartamento>0)
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, idRubro,Convert.ToInt32( idEmpleado), IdDepartamento,estado, ref mensaje);
                this.DataSource = oListado.ToArray();
                return;
            }

          


            if (idRubro != "" && idEmpleado ==0 && IdDepartamento>0)
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, idRubro, IdDepartamento, estado, ref mensaje);
                this.DataSource = oListado.ToArray();
                return;
            }



            if (idRubro == "" && idEmpleado == 0 && IdDepartamento > 0)
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, IdDepartamento, estado, ref mensaje);
                this.DataSource = oListado.ToArray();
                return;
            }

            if (idRubro == "" && idEmpleado == 0 && IdDepartamento == 0)
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, estado, ref mensaje);
                this.DataSource = oListado.ToArray();
                return;
            }

            if (idRubro != "" && idEmpleado == 0 && IdDepartamento == 0)
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, fechaInicial, fechaFinal, idRubro, estado, ref mensaje);
                this.DataSource = oListado.ToArray();
                return;
            }

            if (idRubro != "" && idEmpleado != 0 && IdDepartamento == 0)
            {
                oListado = oReporteBus.GetListConsultaPorFecha(idEmpresa, idEmpleado, fechaInicial, fechaFinal, idRubro, estado, ref mensaje);
                this.DataSource = oListado.ToArray();
                return;
            }



        }

    }
}
