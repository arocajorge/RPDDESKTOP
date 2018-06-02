
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt028_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdTipoNomina { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Empleado { get; set; }
        public string Estado { get; set; }
        public string ca_descripcion { get; set; }
        public Nullable<System.DateTime> em_fechaIngaRol { get; set; }
        public Nullable<System.DateTime> em_fechaSalida { get; set; }
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public string MotivoTerminacion { get; set; }
        public string Af_DescripcionCorta { get; set; }
        public string Centro_costo { get; set; }

        public XROL_Rpt028_Info() { }

    }
}
