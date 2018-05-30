using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int eg_secuencia { get; set; }
        public double eg_cantidad { get; set; }
        public double eg_precio_uni { get; set; }
        public double eg_por_ganancia { get; set; }
        public double eg_valor_ganancia { get; set; }
        public double eg_precio_total { get; set; }
        public Nullable<int> inv_IdEmpresa { get; set; }
        public Nullable<int> inv_IdSucursal { get; set; }
        public Nullable<int> inv_IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> inv_IdNumMovi { get; set; }
        public Nullable<int> inv_Secuencia { get; set; }
        public string IdUnidadMedida { get; set; }
        public decimal IdProducto { get; set; }
        public double pr_precio_publico { get; set; }

        public bool eg_estado { get; set; }
    }
}
