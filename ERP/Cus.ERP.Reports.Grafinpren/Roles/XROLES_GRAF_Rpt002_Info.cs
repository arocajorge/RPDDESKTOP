using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.Roles
{
   public class XROLES_GRAF_Rpt002_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdEmpleado { get; set; }
       public int IdLiquidacion { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string Nombres { get; set; }
       public string Observaciones { get; set; }
       public double ValorCancelado { get; set; }
       public System.DateTime FechaPago { get; set; }
       public string Gozadas_Pagadas { get; set; }
       public double Valor { get; set; }
       public string ru_descripcion { get; set; }


       public double Ingreso { get; set; }

       public double Egreso { get; set; }

    }
}
