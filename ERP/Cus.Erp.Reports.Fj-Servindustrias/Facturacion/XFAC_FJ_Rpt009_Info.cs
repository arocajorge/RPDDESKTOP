using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt009_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int Secuencia { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public int IdVendedor { get; set; }
        public string Ve_Vendedor { get; set; }
        public string pr_descripcion { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public double vt_total { get; set; }
        public int IdPunto_Cargo { get; set; }
        public int IdPunto_cargo_grupo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string vt_NumFactura { get; set; }
    }
}
