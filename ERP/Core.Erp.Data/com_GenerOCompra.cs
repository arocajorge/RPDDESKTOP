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
    
    public partial class com_GenerOCompra
    {
        public com_GenerOCompra()
        {
            this.com_GenerOCompra_Det = new HashSet<com_GenerOCompra_Det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdTransaccion { get; set; }
        public int IdSucursal { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string Usuario { get; set; }
        public string g_ocObservacion { get; set; }
        public string Estado { get; set; }
        public string IdUsuarioAnula { get; set; }
        public Nullable<System.DateTime> FechaAnula { get; set; }
        public string MotivoAnulacion { get; set; }
    
        public virtual ICollection<com_GenerOCompra_Det> com_GenerOCompra_Det { get; set; }
    }
}
