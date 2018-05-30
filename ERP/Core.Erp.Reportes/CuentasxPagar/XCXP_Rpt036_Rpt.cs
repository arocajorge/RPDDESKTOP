using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt036_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXP_Rpt036_Rpt()
        {
            InitializeComponent();
            this.lbl_fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCXP_Rpt036_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;


                lblEmpresa.Text = param.InfoEmpresa.em_nombre;
                lbl_usuario.Text = param.IdUsuario;


                XCXP_Rpt036_Bus rptBus = new XCXP_Rpt036_Bus();
                List<XCXP_Rpt036_Info> lstInfo = new List<XCXP_Rpt036_Info>();

                decimal IdProveedor = Convert.ToDecimal(p_IdProveedor.Value);
                bool no_mostrar_saldo_0 = Convert.ToBoolean(p_no_mostrar_saldo_0.Value);
                DateTime Fecha_ini = Convert.ToDateTime(p_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(p_Fecha_fin.Value);
                bool mostrar_origen_bodega = Convert.ToBoolean(p_mostrar_origen_bodega.Value);
                bool mostrar_origen_caja = Convert.ToBoolean(p_mostrar_origen_caja.Value);
                lstInfo = rptBus.get_list(param.IdEmpresa, IdProveedor, no_mostrar_saldo_0,Fecha_ini,Fecha_fin,mostrar_origen_bodega,mostrar_origen_caja);

                
                this.DataSource = lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt035_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt035_rpt) };
            }
        }

        private void xrPictureBox_bodega_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //xrPictureBox_bodega.ImageUrl = Core.Erp.Reportes.
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt035_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt035_rpt) };
            }
        }

    }
}
