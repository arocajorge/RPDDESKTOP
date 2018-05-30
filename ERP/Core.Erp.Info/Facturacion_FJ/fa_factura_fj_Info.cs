using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_factura_fj_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string Atencion_a { get; set; }
        public string num_oc { get; set; }
        public string descripcion_fact { get; set; }
        public Nullable<System.DateTime> fecha_cobro_1 { get; set; }
        public Nullable<System.DateTime> fecha_cobro_2 { get; set; }
    }
}
