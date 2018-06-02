using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_ruta_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRuta { get; set; }
        public string ru_descripcion { get; set; }
        public double ru_cantidad_km { get; set; }
        public string ru_observacion { get; set; }
        public bool estado { get; set; }
    }
}
