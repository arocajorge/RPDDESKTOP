using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt017_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Empleado { get; set; }
        public string Cargo { get; set; }
        public Nullable<int> Asistencia { get; set; }
        public Nullable<int> Atraso { get; set; }
        public Nullable<int> Falta { get; set; }
        public Nullable<int> Permiso { get; set; }
        public Nullable<int> SinLaborar { get; set; }
        public Nullable<int> Suspendido { get; set; }
        public Nullable<int> Vacaciones { get; set; }

    }
}
