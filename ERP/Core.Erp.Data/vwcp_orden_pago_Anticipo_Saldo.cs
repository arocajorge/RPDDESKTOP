//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcp_orden_pago_Anticipo_Saldo
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public string Referencia { get; set; }
        public string tc_TipoCbte { get; set; }
        public Nullable<double> Valor_cbte { get; set; }
        public double valor_cancelado { get; set; }
        public Nullable<double> valor_saldo_cbte { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> IdEmpresaOP { get; set; }
        public Nullable<decimal> IdOrdenPagoOP { get; set; }
        public Nullable<int> SecuenciaOP { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCtaCble_Anticipo { get; set; }
        public string Beneficiario { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
    }
}
