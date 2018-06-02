/*CLASE: XROL_Rpt006_rpt
 *CREADO POR: ALBERTO MENA
 *FECHA: 18-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt006_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";
        
        public XROL_Rpt006_rpt()
        {
            InitializeComponent();
        }

     
        private void XROL_Rpt006_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XROL_Rpt006_Bus oReporteBus = new XROL_Rpt006_Bus();
            List<XROL_Rpt006_Info> oListado = new List<XROL_Rpt006_Info>();

            int idNominaTipo = Convert.ToInt32(Parameters["p_IdNominaTipo"].Value);
            int idNominaTipoLiqui = Convert.ToInt32(Parameters["p_IdNominaTipoLiqui"].Value);
            int idPeriodo = Convert.ToInt32(Parameters["p_IdPeriodo"].Value);            
            decimal idDivision = Convert.ToDecimal(Parameters["p_IdDivision"].Value);
            string idCentroCosto = Parameters["p_IdCentroCosto"].Value.ToString();
            int iddepartamento =(int) Parameters["iddepartamento"].Value;

            oListado = oReporteBus.GetListPorNominaPeriodo(param.IdEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje);

            this.DataSource = oListado.ToArray();
            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
            lb_nombrecomercial.Text = param.InfoEmpresa.em_nombre;

            this.DataSource = oListado.ToArray();

        }









    }
}
