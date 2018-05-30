using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_logistica_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int lo_secuencia { get; set; }
        public double lo_cantidad { get; set; }
        public double lo_kilometros { get; set; }
        public string lo_descripcion { get; set; }
        public double lo_precio_uni_kilometro { get; set; }
        public double lo_precio_total { get; set; }
    }
}
