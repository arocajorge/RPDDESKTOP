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
    
    public partial class prd_ControlProduccion_Obrero_Det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdControlProduccionObrero { get; set; }
        public int Secuencia { get; set; }
        public System.TimeSpan HoraInicio { get; set; }
        public double Cantidad { get; set; }
        public decimal IdProducto { get; set; }
        public string CodBarra { get; set; }
        public string CodBarraMaestro { get; set; }
    }
}
