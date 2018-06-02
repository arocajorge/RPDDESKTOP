using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Mantenimiento
{
    public class man_tipo_horas_facturacion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipo { get; set; }
        public decimal IdProducto { get; set; }
        public string ti_codigo { get; set; }
        public string ti_observacion { get; set; }
        public bool estado { get; set; }
    }
}
