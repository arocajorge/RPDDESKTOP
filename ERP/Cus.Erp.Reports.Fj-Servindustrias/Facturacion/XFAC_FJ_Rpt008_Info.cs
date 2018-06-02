using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt008_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdOrdenTrabajo_Pla { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public string Ve_Vendedor { get; set; }
        public Nullable<decimal> IdTransportista { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double km_salida { get; set; }
        public double km_llegada { get; set; }
        public Nullable<double> Valor { get; set; }
    }
}
