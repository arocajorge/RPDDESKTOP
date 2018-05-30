using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_otros_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int Secuencia { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdCentroCosto { get; set; }
        public Nullable<int> IdActivoFijo { get; set; }
        public string observacion { get; set; }
        public double valor { get; set; }
    }
}
