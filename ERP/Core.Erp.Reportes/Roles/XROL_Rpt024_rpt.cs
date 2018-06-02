using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt024_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";


        public XROL_Rpt024_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt005_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XROL_Rpt024_Bus oReporteBus = new XROL_Rpt024_Bus();
            List<XROL_Rpt024_Info> oListado = new List<XROL_Rpt024_Info>();

            int idEmpresa = param.IdEmpresa;
            decimal IdEmpleado = 0;
            DateTime fechaI;
            DateTime FechaF;
            int iddivision_;
            idEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
            IdEmpleado = Convert.ToDecimal(Parameters["IdEmpleado"].Value);

            fechaI = Convert.ToDateTime(Parameters["fechai"].Value);
            FechaF = Convert.ToDateTime(Parameters["fechaf"].Value);
            iddivision_ = Convert.ToInt32(Parameters["iddivision"].Value);

            //s_fechaPeriodo.Value = "Período del " + fechaInicial.ToShortDateString() + " al " + fechaFinal.ToShortDateString();
            if(IdEmpleado!=0)

                oListado = oReporteBus.GetListConsultaPorPrestamo(idEmpresa, iddivision_, IdEmpleado, fechaI, FechaF, ref mensaje);
            else
                oListado = oReporteBus.GetListConsultaPorPrestamo(idEmpresa, iddivision_, fechaI, FechaF, ref mensaje);
            this.DataSource = oListado.ToArray();

            lb_impresion.Text = DateTime.Now.ToString().Substring(0,10);
            lbusuario.Text = param.IdUsuario;
        }

    }
}
