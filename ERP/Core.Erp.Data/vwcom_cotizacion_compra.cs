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
    
    public partial class vwcom_cotizacion_compra
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int IdSucursal { get; set; }
        public string Observacion { get; set; }
        public string nom_sucursal { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
    }
}
