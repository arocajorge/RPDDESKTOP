using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROL_Rpt022_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int idEmpresa = 0;
        decimal idEmpleado = 0;
        int idNominaTipo = 0;
        int mes_ = 0;
        int idDepartamento = 0;
        int anio_ = 0;
        string mensaje = "";
        public XROL_Rpt022_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt002_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            try
            {
                XROL_Rpt002_Bus oReporteBus = new XROL_Rpt002_Bus();
                List<XROL_Rpt002_Info> oListado = new List<XROL_Rpt002_Info>();




            idEmpresa = Convert.ToInt32(Parameters["IdEmpresa_"].Value);
            idEmpleado = Convert.ToDecimal(Parameters["IdEmpleado_"].Value);
            idNominaTipo = Convert.ToInt32(Parameters["IdNomina"].Value);
            mes_ = Convert.ToInt32(Parameters["mes"].Value);
            anio_ = Convert.ToInt32(Parameters["anio"].Value);
          

            //INFO
            ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
            List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
            ro_periodo_x_ro_Nomina_TipoLiqui_Info info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
            string Nombre_mes = "";

            switch (mes_)
            {
                case 01:
                    Nombre_mes = "ENERO";
                    break;
                case 02:
                    Nombre_mes = "FEBRERO";
                    break;
                case 03:
                    Nombre_mes = "MARZO";
                    break;
                case 04:
                    Nombre_mes = "ABRIL";
                    break;
                case 05:
                    Nombre_mes = "MAYO";
                    break;
                case 06:
                    Nombre_mes = "JUNIO";
                    break;
                case 07:
                    Nombre_mes = "JULIO";
                    break;
                case 08:
                    Nombre_mes = "AGOSTO";
                    break;
                case 09:
                    Nombre_mes = "SEPTIEMBRE";
                    break;
                case 10:
                    Nombre_mes = "OCTUBRE";
                    break;
                case 11:
                    Nombre_mes = "NOVIEMBRE";
                    break;
                case 12:
                    Nombre_mes = "DICIEMBRE";
                    break;
                default:
                    break;
            }
           // xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
            lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
            lbcomprobante.Text = "COMPROBANTE DE PAGO DE  " + Nombre_mes + " " + anio_;
            lbRuc.Text = "RUC #" + param.InfoEmpresa.em_ruc;
            oListado = oReporteBus.GetListConsultaGeneral(idEmpresa, idEmpleado, idNominaTipo, anio_, mes_, ref mensaje);
      
            
            this.DataSource = oListado.ToArray();

            if (oListado.Count() > 0)
            {
                if (idEmpleado == 37)
                {
                }
                XROL_Rpt002_Info info_ = oListado.FirstOrDefault();

                double egresos = oListado.Sum(v => v.Egresos);
                double ingresos = oListado.Sum(v => v.Ingresos);
                lb_liquido.Text =(ingresos-egresos).ToString("n2");
                if (info_.IdEmpleado == 37)
                {
                }
             
            }
      

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }


       
    }
}
