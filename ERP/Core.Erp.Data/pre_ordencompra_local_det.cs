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
    
    public partial class pre_ordencompra_local_det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdPedidoXPre { get; set; }
        public int Secuencia_reg_ped { get; set; }
        public decimal IdPresupuesto_pre { get; set; }
        public int IdAnio_pre { get; set; }
        public int Secuencia_pre { get; set; }
        public string Producto { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioCompra { get; set; }
        public double do_porc_des { get; set; }
        public double do_descuento { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public string do_ManejaIva { get; set; }
        public string do_observacion { get; set; }
        public string do_NumDocumento { get; set; }
    }
}
