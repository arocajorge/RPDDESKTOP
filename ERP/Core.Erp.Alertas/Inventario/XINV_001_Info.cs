using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Alertas.Inventario
{
    public class XINV_001_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public double pr_stock_minimo { get; set; }
        public Nullable<double> stock_inventario { get; set; }
        public Nullable<double> stock_pendiente_ingreso { get; set; }
        public Nullable<double> stock_solicitud_sin_aprobacion { get; set; }
        public string ESTADO_ALERTA { get; set; }
    }
}
