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
    
    public partial class vwcp_Retencion_valor_total_x_cbte_cxp
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public Nullable<double> Total_Retencion { get; set; }
        public string serie { get; set; }
        public string NumRetencion { get; set; }
        public string NAutorizacion { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
    }
}
