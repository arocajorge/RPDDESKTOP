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
    public partial class XROL_Rpt033_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<XROL_Rpt033_Info> Listado = new List<XROL_Rpt033_Info>();
        XROL_Rpt033_Info info = new XROL_Rpt033_Info();
        XROL_Rpt033_Bus bus = new XROL_Rpt033_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XROL_Rpt033_rpt()
        {
            InitializeComponent();
        }

      

      public  void Set(decimal Idempleado,  decimal idliquidacion)
        {

            try
            {
                Listado = bus.Get_List_Vacaciones(param.IdEmpresa,Convert.ToInt32(  Idempleado),Convert.ToInt32( idliquidacion));
               
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
