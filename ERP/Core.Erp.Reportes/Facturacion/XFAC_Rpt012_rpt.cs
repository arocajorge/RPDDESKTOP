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
    public partial class XFAC_Rpt012_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        #region Variables
        List<XFAC_Rpt012_Info> lst_rpt;
        XFAC_Rpt012_Bus bus_rpt;
        fa_parametro_info info_fa_param;
        fa_parametro_Bus bus_fa_param;
        cl_parametrosGenerales_Bus param;
        #endregion

        public XFAC_Rpt012_Rpt()
        {
            InitializeComponent();
            lst_rpt = new List<XFAC_Rpt012_Info>();
            bus_rpt = new XFAC_Rpt012_Bus();
            info_fa_param = new fa_parametro_info();
            bus_fa_param = new fa_parametro_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
        }

        private void XFAC_Rpt012_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                info_fa_param = bus_fa_param.Get_Info_parametro(param.IdEmpresa);
                int IdSucursal = p_IdSucursal.Value == null ? 0 : Convert.ToInt32(p_IdSucursal.Value);
                decimal IdProforma = p_IdProforma.Value == null ? 0 : Convert.ToDecimal(p_IdProforma.Value);
                lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdSucursal, IdProforma,false);

                int agregar_linea = info_fa_param.NumeroDeItemProforma == null ? 0 : Convert.ToInt32(info_fa_param.NumeroDeItemProforma) - lst_rpt.Count;
                if (agregar_linea > 0)
                {
                    string nom_termino_pago = "";
                    int plazo = 0;
                    DateTime Fecha = DateTime.Now.Date;
                    string cod_proforma = "";
                    string atencion_a = "";
                    string cod_vendedor = "";
                    if (lst_rpt.Count > 0)
                    {
                        nom_termino_pago = lst_rpt[0].nom_TerminoPago;
                        plazo = lst_rpt[0].pf_plazo;
                        Fecha = lst_rpt[0].pf_fecha;
                        cod_proforma = lst_rpt[0].pf_codigo;
                        atencion_a = lst_rpt[0].pf_atencion_a;
                        cod_vendedor = lst_rpt[0].Codigo;    
                    }
                    
                    for (int i = 0; i < agregar_linea; i++)
                    {
                        
                        XFAC_Rpt012_Info nuevo = new XFAC_Rpt012_Info
                        {
                            nom_TerminoPago = nom_termino_pago,
                            pf_plazo = plazo,
                            pf_fecha = Fecha,
                            pf_codigo = cod_proforma,
                            pf_atencion_a = atencion_a,
                            Codigo = cod_vendedor
                        };

                        lst_rpt.Add(nuevo);
                    }
                }
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}
