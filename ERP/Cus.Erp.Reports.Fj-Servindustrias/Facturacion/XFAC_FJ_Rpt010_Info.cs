using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt010_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdRegistro { get; set; }
        public int IdActivoFijo { get; set; }
        public int IdPeriodo { get; set; }
        public Nullable<decimal> IdCbteVta_hn { get; set; }
        public string vt_NumFactura_hn { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public double unidades_maximas { get; set; }
        public double diferencia_a_facturar { get; set; }
        public int IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<decimal> IdCbteVta_he { get; set; }
        public string vt_NumFactura_he { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string nom_periodo { get; set; }
    }
}
