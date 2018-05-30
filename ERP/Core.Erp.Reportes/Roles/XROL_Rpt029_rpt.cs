using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;

using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt029_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        string mensaje = "";


        public XROL_Rpt029_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt029_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                string esta = "";

                XROL_Rpt029_Bus oReporteBus = new XROL_Rpt029_Bus();
                List<XROL_Rpt029_Info> oListado = new List<XROL_Rpt029_Info>();

                int idnomina = Convert.ToInt32(Parameters["IdNomina"].Value);
                int iddivision =Convert.ToInt32( Parameters["iddivision"].Value);
                DateTime FechaInicio = Convert.ToDateTime(Parameters["fechai"].Value);
                DateTime FechaFinal = Convert.ToDateTime(Parameters["fechaf"].Value);
                 esta = Convert.ToString(Parameters["estado"].Value);
                bool considerar_fecha_ingreso = Convert.ToBoolean(p_considerar_fecha_ingreso.Value);


                int idEmpresa = param.IdEmpresa;
                xrPictureBox2.Image = param.InfoEmpresa.em_logo_Image;
                lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
                if (iddivision!=0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(param.IdEmpresa,idnomina, iddivision,FechaInicio,FechaFinal,esta,considerar_fecha_ingreso);
                    this.DataSource = oListado.ToArray();
                    return;
                }


                if (iddivision == 0)
                {
                    oListado = oReporteBus.GetListConsultaGeneral(param.IdEmpresa, idnomina, FechaInicio, FechaFinal, esta, considerar_fecha_ingreso);
                    this.DataSource = oListado.ToArray();
                    return;
                }
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XROL_Rpt029_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XROL_Rpt029_rpt) };
            }
        }

    }
}
