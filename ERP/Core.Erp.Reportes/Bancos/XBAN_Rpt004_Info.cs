using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt004_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipocbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public string cb_Cheque { get; set; }
        public Nullable<double> cb_Valor { get; set; }
        public Nullable<double> debe { get; set; }
        public Nullable<double> haber { get; set; }
        public Nullable<double> saldo { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdEmpresa_cxp { get; set; }
        public Nullable<int> IdTipoCbte_cxp { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public string observacion_deuda { get; set; }
        public Nullable<System.DateTime> fecha_deuda { get; set; }
        public int num_querry { get; set; }
        public int orden { get; set; }
        public int IdBanco { get; set; }
        public string ba_descripcion { get; set; }

   
    }
}
