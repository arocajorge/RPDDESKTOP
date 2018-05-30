using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_mano_obra_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int mo_secuencia { get; set; }
        public decimal IdTecnico { get; set; }
        public double mo_horas { get; set; }
        public string mo_descripcion { get; set; }
        public double mo_precio_uni { get; set; }
        public double mo_precio_total { get; set; }
        public string ac_codigo { get; set; }
        public string ac_descripcion { get; set; }
        public string te_codigo { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdActividad { get; set; }
        public string ti_codigo { get; set; }

        public List<XFAC_FJ_Rpt015_mano_obra_det_Info> lst_mano_obra_det { get; set; }
    }
}
