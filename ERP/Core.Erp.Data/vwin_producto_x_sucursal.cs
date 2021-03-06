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
    
    public partial class vwin_producto_x_sucursal
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdProductoTipo { get; set; }
        public string IdPresentacion { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<int> pr_precio_minimo { get; set; }
        public Nullable<int> pr_precio_publico { get; set; }
        public Nullable<double> pr_costo_promedio { get; set; }
        public Nullable<double> pr_pedidos { get; set; }
        public Nullable<double> pr_stock { get; set; }
        public Nullable<double> pr_disponible { get; set; }
        public string Descripcion_UniMedida { get; set; }
        public string Descripcion_TipoConsumo { get; set; }
        public string IdUnidadMedida_Consumo { get; set; }
        public string IdCtaCble_Inventario { get; set; }
        public string IdCtaCble_Gasto_x_cxp { get; set; }
        public string IdCentroCosto_sub_centro_costo_cost { get; set; }
        public string IdCentroCosto_sub_centro_costo_cxp { get; set; }
        public string IdCtaCble_Costo { get; set; }
        public string IdCtaCble_CosBaseIva { get; set; }
        public string IdCtaCble_CosBase0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }
        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_DesIva { get; set; }
        public string IdCtaCble_Des0 { get; set; }
        public string IdCtaCble_DevIva { get; set; }
        public string IdCtaCble_Dev0 { get; set; }
        public string IdCtaCble_Vta { get; set; }
        public string IdCentroCosto_sub_centro_costo_inv { get; set; }
        public string IdCentroCosto_x_Gasto_x_cxp { get; set; }
        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentro_Costo_Costo { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public bool Aparece_modu_Ventas { get; set; }
        public bool Aparece_modu_Compras { get; set; }
        public bool Aparece_modu_Inventario { get; set; }
        public bool Aparece_modu_Activo_F { get; set; }
        public Nullable<double> precio_minimo { get; set; }
    }
}
