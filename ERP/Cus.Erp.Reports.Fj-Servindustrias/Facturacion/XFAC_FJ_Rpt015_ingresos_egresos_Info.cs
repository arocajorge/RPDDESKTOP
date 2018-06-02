using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_ingresos_egresos_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int eg_secuencia { get; set; }
        public double eg_cantidad { get; set; }
        public double eg_precio_uni { get; set; }
        public double eg_precio_total { get; set; }
        public string pr_descripcion { get; set; }
        public string nom_uni_medida { get; set; }
        public string Tipo { get; set; }
        public string pr_codigo { get; set; }
    }
}
