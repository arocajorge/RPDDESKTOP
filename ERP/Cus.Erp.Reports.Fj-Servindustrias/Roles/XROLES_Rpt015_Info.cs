using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt015_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Id_remplazo { get; set; }
        public string Cedula_empleado_Remplazado { get; set; }
        public string empleado_remplazado { get; set; }
        public string Cedula_remplazo { get; set; }
        public string Remplazo { get; set; }
        public string ca_descripcion { get; set; }
        public Nullable<double> Valor_descuento_empleado { get; set; }
        public Nullable<System.DateTime> Fecha_descuenta_rol { get; set; }
        public double valor_x_dia_remplazo { get; set; }
        public double Total_pagar_remplazo { get; set; }
        public bool Descuenta_rol { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime Fecha_Salida { get; set; }
        public System.DateTime Fecha_Entrada { get; set; }
        public string Observacion { get; set; }
        public string MotivoAusencia { get; set; }
        public string Centro_costo { get; set; }
        public string DescripcionProcesoNomina { get; set; }
        public string Dias { get; set; }
        public string trasnferencia { get; set; }


    }
}
