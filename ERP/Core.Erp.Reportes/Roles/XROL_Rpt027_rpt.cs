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
    public partial class XROL_Rpt027_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        List<ro_Pago_decimos_x_Empleado_Info> lista_decimo = new List<ro_Pago_decimos_x_Empleado_Info>();
        public string Concepro { get; set; }
        public XROL_Rpt027_rpt()
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
            ro_Pago_decimos_x_Empleado_Bus oReporteBus = new ro_Pago_decimos_x_Empleado_Bus();
            List<ro_Pago_decimos_x_Empleado_Info> oListado = new List<ro_Pago_decimos_x_Empleado_Info>();


            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
            lbdecimo.Text = Concepro;


            this.DataSource = lista_decimo.ToArray();

            
        }

    }
}
