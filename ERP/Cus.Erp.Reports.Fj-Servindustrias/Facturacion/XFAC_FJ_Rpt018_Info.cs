using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt018_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public Nullable<double> vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> vt_total { get; set; }
        public Nullable<System.DateTime> fecha_cobro_1 { get; set; }
        public Nullable<System.DateTime> fecha_cobro_2 { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public System.DateTime vt_fecha { get; set; }
    }
}
