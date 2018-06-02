using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt018_Info
    {
        public int IdEmpresa { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> EmpleadosActivos { get; set; }
        public Nullable<int> EmpleadosPasivos { get; set; }
        public Nullable<int> EmpleadosNuevos { get; set; }
        public Nullable<int> Faltas { get; set; }
        public int Nuevos_menosPasivos { get; set; }
        public double TotalRoracion { get; set; }
        public double TotalAusentismo { get; set; }

    }
}
