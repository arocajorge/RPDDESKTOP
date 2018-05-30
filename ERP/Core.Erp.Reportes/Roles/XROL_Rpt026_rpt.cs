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
    public partial class XROL_Rpt026_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XROL_Rpt026_Info> Listado = new List<XROL_Rpt026_Info>();
        XROL_Rpt026_Info info = new XROL_Rpt026_Info();
        XROL_Rpt026_Bus bus = new XROL_Rpt026_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XROL_Rpt026_rpt()
        {
            InitializeComponent();
        }

      

      public  void Set(List<XROL_Rpt026_Info> Lista)
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

      private void XROL_Rpt026_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
      {
          try
          {
              
          

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
