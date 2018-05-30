using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class fa_factura_det_x_fa_descuento_Info
    {
        public int IdEmpresa_fa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_de { get; set; }
        public decimal IdDescuento { get; set; }
        public int Secuencia_reg { get; set; }
        public double de_valor { get; set; }

        public double de_porcentaje { get; set; }
    }
}
