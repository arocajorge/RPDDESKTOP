using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt014_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string Descripcion { get; set; }
        public string ca_descripcion { get; set; }
        public string Asistencia { get; set; }
        public Nullable<int> es_fecha_registro { get; set; }
    }
}
