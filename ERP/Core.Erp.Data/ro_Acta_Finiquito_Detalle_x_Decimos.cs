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
    
    public partial class ro_Acta_Finiquito_Detalle_x_Decimos
    {
        public int IdEmpresa { get; set; }
        public int IdNominatipo { get; set; }
        public decimal IdLiquidacion { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Sec { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public double Total_Remuneracion { get; set; }
        public double Decimo { get; set; }
        public Nullable<int> DiasTrabajados { get; set; }
    }
}
