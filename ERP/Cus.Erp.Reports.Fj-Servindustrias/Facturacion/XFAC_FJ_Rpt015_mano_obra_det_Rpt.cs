using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt015_mano_obra_det_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt015_mano_obra_det_Info> Lst_Rpt = new List<XFAC_FJ_Rpt015_mano_obra_det_Info>();
        XFAC_FJ_Rpt015_mano_obra_det_Bus bus_Rpt = new XFAC_FJ_Rpt015_mano_obra_det_Bus();

        public XFAC_FJ_Rpt015_mano_obra_det_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt015_mano_obra_det_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int IdSucursal = Convert.ToInt32(p_IdSucursal.Value);
                string IdCentroCosto = p_IdCentroCosto.Value.ToString();
                decimal IdLiquidacion = Convert.ToDecimal(p_IdLiquidacion.Value);

                Lst_Rpt = bus_Rpt.get_list(param.IdEmpresa, IdSucursal, IdCentroCosto, IdLiquidacion);
                this.DataSource = Lst_Rpt;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

    }
}
