using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt021_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdDescuento { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string nom_cargo { get; set; }
        public string nom_rubro { get; set; }
        public string Observacion { get; set; }
        public double Valor { get; set; }
        public System.DateTime Fecha_Incidente { get; set; }
        public bool Estado { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }
    }
}
