using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt003_Info> lst_rpt = new List<XFAC_FJ_Rpt003_Info>();
        XFAC_FJ_Rpt003_Bus bus_rpt = new XFAC_FJ_Rpt003_Bus();

        public XFAC_FJ_Rpt003_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_FJ_Rpt003_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lbl_empresa.Text = param.NombreEmpresa;
                lbl_empresa_2.Text = param.NombreEmpresa;
                lbl_para_nom_gerente_fecha_mes_dia.Text = lbl_para_nom_gerente_fecha_mes_dia.Text.Replace("[XXX_NOM_GERENTE]", param.InfoEmpresa.em_gerente).Replace("[XXX_PARA]", p_Para.Value.ToString()).Replace("[XXX_FECHA_MES_DIA]", DateTime.Now.ToString("MMMMM dd"));
                lbl_nom_gerente.Text = lbl_nom_gerente.Text.Replace("[XXX_NOM_GERENTE]", param.InfoEmpresa.em_gerente);
                lbl_direccion_telf_fax_email.Text = lbl_direccion_telf_fax_email.Text.Replace("[XXX_DIRECCION]", param.InfoEmpresa.em_direccion).Replace("[XXX_TELF]", param.InfoEmpresa.em_telefonos).Replace("[XXX_FAX]", param.InfoEmpresa.em_fax).Replace("[XXX_EMAIL]", param.InfoEmpresa.em_Email).Replace("[XXX_TELF_INT]", param.InfoEmpresa.em_tel_int);
                
                decimal IdCliente = Convert.ToDecimal(p_IdCliente.Value);
                DateTime Fecha_ini = Convert.ToDateTime(p_Fecha_ini.Value);
                DateTime Fecha_fin = Convert.ToDateTime(p_Fecha_fin.Value);
                lst_rpt = bus_rpt.get_list(param.IdEmpresa, IdCliente, Fecha_ini, Fecha_fin);

                if (lst_rpt.Count > 0)
                    lbl_titulo_cliente.Text = lbl_titulo_cliente.Text.Replace("[XXX_CLIENTE]", lst_rpt[0].pe_nombreCompleto);

                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
