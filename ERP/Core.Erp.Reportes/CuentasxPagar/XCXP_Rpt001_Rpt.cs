using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Extensions;

using Core.Erp.Info.General;


namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCXP_Rpt001_Rpt()
        {
            
            InitializeComponent();
        }


        private void XCXP_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                lbl_fecha.Text = DateTime.Now.ToLongDateString();
                lblEmpresa.Text = param.InfoEmpresa.em_nombre;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XCXP_Rpt001_Bus repbus = new XCXP_Rpt001_Bus();
                List<XCXP_Rpt001_Info> ListDataRpt = new List<XCXP_Rpt001_Info>();
                Decimal IdProveedor = 0;
                DateTime co_fechaOg_Fin = DateTime.Now;
                int IdClase_proveedor = 0;
                bool no_mostrar_saldo_0 = false;

                IdClase_proveedor = Convert.ToInt32(p_IdClase_proveedor.Value);
                IdProveedor = Convert.ToDecimal(p_IdProveedor.Value);
                co_fechaOg_Fin = Convert.ToDateTime(p_fecha_corte.Value);
                no_mostrar_saldo_0 = Convert.ToBoolean(p_no_mostrar_saldo_0.Value);
                bool no_mostrar_en_conciliacion = Convert.ToBoolean(p_no_mostrar_en_conciliacion.Value);

                ListDataRpt = repbus.get_list(param.IdEmpresa, IdClase_proveedor, IdProveedor, co_fechaOg_Fin, no_mostrar_saldo_0,no_mostrar_en_conciliacion);
                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt001_Rpt) };
                
            }

            
        }

    }
}
