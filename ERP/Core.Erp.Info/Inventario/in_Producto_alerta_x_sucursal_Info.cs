using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_Producto_alerta_x_sucursal_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdProducto { get; set; }
        public bool se_controla_stock_minimo { get; set; }
        public double pr_stock_minimo { get; set; }
        public string observacion { get; set; }

        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
    }
}
