using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt016_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_Tipo_Liq { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string cod_Pago_Variable { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Nombres { get; set; }
        public string ca_descripcion { get; set; }
        public Nullable<double> Meta { get; set; }
        public Nullable<double> Real { get; set; }
        public Nullable<double> Cumplimiento { get; set; }
        public Nullable<double> Variable_porcentaje_prorrateado { get; set; }
        public double Valor { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string ru_descripcion { get; set; }
        public double Valor_bono { get; set; }


    }
}
