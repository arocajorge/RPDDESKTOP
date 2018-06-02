using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt017_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_NumFactura { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<double> vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> vt_total { get; set; }
        public double dc_ValorPago { get; set; }
        public Nullable<double> vt_saldo { get; set; }
        public Nullable<double> saldo_total { get; set; }
        public Nullable<System.DateTime> cr_fecha { get; set; }
        public string Estado_cobro { get; set; }
        public string num_oc { get; set; }
        public Nullable<int> cant_cobro { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public string nombre_periodo { get; set; }
        public string vt_Observacion { get; set; }
    }
}
