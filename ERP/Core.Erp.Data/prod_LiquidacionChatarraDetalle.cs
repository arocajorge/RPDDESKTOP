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
    
    public partial class prod_LiquidacionChatarraDetalle
    {
        public int IdEmpresa { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int Secuencia { get; set; }
        public Nullable<double> LLeno { get; set; }
        public Nullable<double> Vacio { get; set; }
        public Nullable<double> Merma { get; set; }
        public Nullable<double> Neta { get; set; }
        public Nullable<System.DateTime> fecha_pesaje_lleno { get; set; }
        public Nullable<System.DateTime> fecha_pesaje_vacion { get; set; }
        public string Placa { get; set; }
    }
}
