using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_Fact_x_Gastos_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int secuencia { get; set; }
        public string IdCentro_Costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdEmpresa_ct { get; set; }
        public Nullable<int> IdTipoCbte_ct { get; set; }
        public Nullable<decimal> IdCbteCble_ct { get; set; }
        public double Cantidad { get; set; }
        public double Costo_Uni { get; set; }
        public double Subtotal { get; set; }
        public double Por_Iva { get; set; }
        public double Valor_Iva { get; set; }
        public double Total { get; set; }
        public double Valor_a_cobrar { get; set; }
        public bool Facturar { get; set; }
        public Nullable<decimal> IdTarifario { get; set; }
        public double Porc_ganancia { get; set; }
        public string num_documento { get; set; }
        public string nom_proveedor { get; set; }
        public System.DateTime Fecha_documento { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdTipoMovi_grupo { get; set; }
        public Nullable<int> secuencia_ct { get; set; }
        public Nullable<decimal> IdCuota { get; set; }
        public Nullable<int> secuencia_cuota { get; set; }

        public string nom_punto_cargo { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string tg_descripcion { get; set; }
        public bool Checked { get; set; }
    }
}
