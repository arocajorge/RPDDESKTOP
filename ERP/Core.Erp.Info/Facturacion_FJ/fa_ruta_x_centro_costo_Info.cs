using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_ruta_x_centro_costo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRuta { get; set; }
        public string IdCentroCosto { get; set; }
        public double ru_costo_x_km { get; set; }

        public string ru_descripcion { get; set; }
        public double ru_cantidad_km { get; set; }
        public string ru_observacion { get; set; }
    }
}
