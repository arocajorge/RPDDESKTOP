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
    public partial class XROL_Rpt030_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        List<ro_Pago_decimos_x_Empleado_Info> lista_decimo = new List<ro_Pago_decimos_x_Empleado_Info>();
        public string Concepro { get; set; }
        public XROL_Rpt030_rpt()
        {
            InitializeComponent();
        }


        public void SetLista(List<ro_Pago_decimos_x_Empleado_Info> lista)
        {
            try
            {
                lista_decimo = lista;
            }
            catch (Exception ex)
            {
                
               
            }
        }
        private void XROL_Rpt005_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XROL_Rpt030_Bus oReporteBus = new XROL_Rpt030_Bus();
            List<XROL_Rpt030_Info> oListado = new List<XROL_Rpt030_Info>();



            
            int idNominaTipo = 0;
            int iddivision = 0;
            DateTime fechaInicio ;
            DateTime fechaFin ;
            
            //string format = "dd/MM/yyyy";

           // idNominaTipo = Convert.ToInt32(Parameters["idnomina"].Value);
           // iddivision = Convert.ToInt32(Parameters["iddivision"].Value);
            fechaInicio = Convert.ToDateTime(Parameters["fechai"].Value);
            fechaFin = Convert.ToDateTime(Parameters["fechaf"].Value);


            oListado = oReporteBus.GetLista(param.IdEmpresa, fechaInicio, fechaFin);

            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
          


            this.DataSource = oListado.ToArray();

            
        }

    }
}
