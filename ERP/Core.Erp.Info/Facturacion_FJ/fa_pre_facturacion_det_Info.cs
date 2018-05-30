using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int Secuencia { get; set; }
        public decimal IdGrupo { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public decimal IdProducto { get; set; }
        public double subtotal { get; set; }
        public double valor_ganancia { get; set; }
        public string IdCod_Impuesto { get; set; }
        public double por_iva { get; set; }
        public double valor_iva { get; set; }
        public double total { get; set; }
        public Nullable<int> IdEmpresa_vta { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public Nullable<decimal> IdCbteVta { get; set; }
        public int IdProceso_prefacturacion { get; set; }

        public bool seleccionado { get; set; }
    }
}
