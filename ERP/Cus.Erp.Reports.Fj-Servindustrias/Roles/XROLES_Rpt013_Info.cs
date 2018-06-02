using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt013_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Empleado { get; set; }
        public string em_codigo { get; set; }
        public string Observacion { get; set; }
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public double UltimaRemuneracion { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public string IdCausaTerminacion { get; set; }
        public string TipoTerminacion { get; set; }
        public string de_descripcion { get; set; }
        public string ca_descripcion { get; set; }
        public Nullable<double> ValorDesaucio { get; set; }
        public double Neto { get; set; }
        public string Antiguedad { get; set; }
        public string EstadoLiquidacion { get; set; }

    }
}
