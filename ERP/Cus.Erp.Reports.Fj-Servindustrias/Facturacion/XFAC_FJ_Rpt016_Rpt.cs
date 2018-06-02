using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.General;
using System.Windows.Forms;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt016_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_FJ_Rpt016_Rpt()
        {
            InitializeComponent();
        }
        XFAC_FJ_Rpt016_Bus BUS = new XFAC_FJ_Rpt016_Bus();
        List<XFAC_FJ_Rpt016_Info> Lst_Rpt = new List<XFAC_FJ_Rpt016_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private void XFAC_FJ_Rpt016_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                Lst_Rpt = BUS.GetList_procesar(param.IdEmpresa,Convert.ToInt32( IdPeriodo.Value),Convert.ToDateTime( FechaInicio.Value), Convert.ToDateTime(FechaFin.Value));
                this.DataSource = Lst_Rpt;

               lb_nombre_reporte.Text="MANO OBRA "+Mes(Convert.ToDateTime(FechaInicio.Value).Month)+" "+Convert.ToDateTime(FechaInicio.Value).Year.ToString();

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private string Mes(int mes)
        {
            try
            {

                string NombreMes = "";
                switch (mes)
                {
                    case 1:
                        NombreMes = "ENERO";
                        break;
                    case 2:
                        NombreMes = "FEBRERO";
                        break;
                    case 3:
                        NombreMes = "MARZO";
                        break;
                    case 4:
                        NombreMes = "ABRIL";
                        break;
                    case 5:
                        NombreMes = "MAYO";
                        break;
                    case 6:
                        NombreMes = "JUNIO";
                        break;
                    case 7:
                        NombreMes = "JULIO";
                        break;
                    case 8:
                        NombreMes = "AGOSTO";
                        break;
                    case 9:
                        NombreMes = "SEPTIEMBRE";
                        break;
                    case 10:
                        NombreMes = "OCTUBRE";
                        break;
                    case 11:
                        NombreMes = "NOVIEMBRE";
                        break;
                    case 12:
                        NombreMes = "DICIEMBRE";
                        break;
                    default:
                        break;
                }
                return NombreMes;
            }
            catch (Exception )
            {
                
                throw;
            }
        }

    }
}
