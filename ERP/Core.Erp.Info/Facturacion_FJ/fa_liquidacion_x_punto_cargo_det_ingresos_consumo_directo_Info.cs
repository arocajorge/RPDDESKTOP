using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int in_secuencia { get; set; }
        public double in_cantidad { get; set; }
        public double in_precio_uni { get; set; }
        public double in_por_ganancia { get; set; }
        public double in_valor_ganancia { get; set; }
        public double in_precio_total { get; set; }
        public Nullable<int> inv_IdEmpresa { get; set; }
        public Nullable<int> inv_IdSucursal { get; set; }
        public Nullable<int> inv_IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> inv_IdNumMovi { get; set; }
        public Nullable<int> inv_Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string IdUnidadMedida { get; set; }
        public double pr_precio_publico { get; set; }

        public bool in_estado { get; set; }
    }
}
