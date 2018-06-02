using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt009_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public int Secuencia { get; set; }
        public System.DateTime fecha_sol { get; set; }
        public decimal IdSolicitante { get; set; }
        public string nom_solicitante { get; set; }
        public string pr_codigo { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string nom_producto { get; set; }
        public double cantidad_sol { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public Nullable<int> ocd_IdEmpresa { get; set; }
        public Nullable<int> ocd_IdSucursal { get; set; }
        public Nullable<decimal> ocd_IdOrdenCompra { get; set; }
        public Nullable<int> ocd_Secuencia { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<System.DateTime> fecha_oc { get; set; }
        public Nullable<double> cantidad_com { get; set; }
        public Nullable<double> do_precioCompra { get; set; }
        public Nullable<System.DateTime> fecha_inv { get; set; }
        public Nullable<double> cantidad_inv { get; set; }
    }
}
