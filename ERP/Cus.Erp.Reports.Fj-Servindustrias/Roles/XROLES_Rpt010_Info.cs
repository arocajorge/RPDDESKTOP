using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt010_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Empleado { get; set; }
        public string ca_descripcion { get; set; }
        public Nullable<double> SueldoActual { get; set; }
        public double Valor_bono { get; set; }
        public string es_fechaRegistro { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public Nullable<double> sueldo_x_dias_trabajados { get; set; }
        public Nullable<double> alimentacio { get; set; }
        public Nullable<double> transporte { get; set; }
        public Nullable<double> HorasExtras { get; set; }
        public Nullable<double> variable { get; set; }
        public Nullable<double> Iess { get; set; }
        public Nullable<double> dias_trabajados { get; set; }
        public string TipoAsistencia { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public Nullable<double> TotalPagar { get; set; }
        public string fu_descripcion { get; set; }

    }
}
