using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections;
using System.Collections.Generic;
using Core.Erp.Business.General;
using System.Linq;
namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt013_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XROL_Rpt013_Info> Listado = new List<XROL_Rpt013_Info>();
        XROL_Rpt013_Info info = new XROL_Rpt013_Info();
        XROL_Rpt013_Bus bus = new XROL_Rpt013_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XROL_Rpt013_rpt()
        {
            InitializeComponent();
        }

      

      public  void Set(List<XROL_Rpt013_Info> Lista)
        {

            try
            {
                if (Lista.Count != 0)
                {
                    Listado = Lista;

                    info = Listado.FirstOrDefault();
                }
               
            }
            catch (Exception ex)
            {
                
                
            }
        }

      private void XROL_Rpt013_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
      {
          try
          {

              txtSolicitud.Text = "Yo, " + info.pe_apellido + " con cedula identidad # " + info.pe_cedulaRuc + " solicitud se me conceda a disfrutar o se me cancelen las vacaciones correspondiente al periodo de: " 
                  + info.Anio_Desde.ToString().Substring(0, 10) + " al " + info.Anio_Hasta.ToString().Substring(0, 10) +
              " en las fechas de : " + info.Fecha_Desde.ToString().Substring(0, 10) + " al " + info.Fecha_Hasta.ToString().Substring(0, 10);


          xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
          lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
       //   lb_nombrecomercial.Text = param.InfoEmpresa.em_nombre;


          this.DataSource = Listado.ToArray();
          }
          catch (Exception)
          {
              
            
          }
      }

      
    }
}
