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
    
    public partial class prod_ModeloProduccion_CusTalme
    {
        public int IdModeloProd { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> IdSucursal_IngxProduc { get; set; }
        public Nullable<int> IdBodega_IngxProduc { get; set; }
        public Nullable<int> IdMovi_inven_tipo_x_IngxProduc_ProdTermi { get; set; }
        public Nullable<int> IdMovi_inven_tipo_x_EgrxProduc_MatPri { get; set; }
        public Nullable<int> IdCargo_JefeTurno { get; set; }
        public Nullable<int> IdSucursal_EgrxMateriaPrima { get; set; }
        public Nullable<int> IdBodega_EgrxMateriaPrima { get; set; }
    }
}
