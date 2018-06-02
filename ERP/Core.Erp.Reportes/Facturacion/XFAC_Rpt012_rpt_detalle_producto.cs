using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt012_rpt_detalle_producto : DevExpress.XtraReports.UI.XtraReport
    {
        #region Variables
        List<XFAC_Rpt012_Info> lst_rpt;
        XFAC_Rpt012_Bus bus_rpt;
        fa_parametro_info info_fa_param;
        fa_parametro_Bus bus_fa_param;
        cl_parametrosGenerales_Bus param;
        #endregion

        public XFAC_Rpt012_rpt_detalle_producto()
        {
            InitializeComponent();
            lst_rpt = new List<XFAC_Rpt012_Info>();
            bus_rpt = new XFAC_Rpt012_Bus();
            info_fa_param = new fa_parametro_info();
            bus_fa_param = new fa_parametro_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
        }

        private void XFAC_Rpt012_rpt_detalle_producto_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                info_fa_param = bus_fa_param.Get_Info_parametro(param.IdEmpresa);
                int IdSucursal = p_IdSucursal.Value == null ? 0 : Convert.ToInt32(p_IdSucursal.Value);
                decimal IdProforma = p_IdProforma.Value == null ? 0 : Convert.ToDecimal(p_IdProforma.Value);
                lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdSucursal, IdProforma,true);
               
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}
