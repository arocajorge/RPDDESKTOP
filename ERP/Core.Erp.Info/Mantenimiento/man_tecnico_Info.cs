using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Mantenimiento
{
    public class man_tecnico_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdTecnico { get; set; }
        public decimal IdEmpleado { get; set; }
        public string te_codigo { get; set; }
        public string te_observacion { get; set; }
        public bool estado { get; set; }

        public string pe_cedulaRuc { get; set; }
        public string pe_nombreCompleto { get; set; }
    }
}
