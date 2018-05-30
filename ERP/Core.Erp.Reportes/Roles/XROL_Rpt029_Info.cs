using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt029_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdTipoNomina { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Empleado { get; set; }
        public Nullable<System.DateTime> em_fecha_ingreso { get; set; }
        public Nullable<System.DateTime> em_fechaSalida { get; set; }
        public string ca_descripcion { get; set; }
        public string EstadoEmpleado { get; set; }
        public string Centro_costo { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public string Antiguedad { get; set; }

        public XROL_Rpt029_Info() { }
    }
}
