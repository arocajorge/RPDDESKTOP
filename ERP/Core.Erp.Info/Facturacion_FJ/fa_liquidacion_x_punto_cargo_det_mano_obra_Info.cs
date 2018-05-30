using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_x_punto_cargo_det_mano_obra_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int mo_secuencia { get; set; }
        public double mo_horas { get; set; }
        public double mo_precio_uni { get; set; }
        public double mo_por_ganancia { get; set; }
        public double mo_valor_ganancia { get; set; }
        public double mo_precio_total { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdActividad { get; set; }
        public decimal IdTecnico { get; set; }

        public List<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info> lst_mano_obra_det { get; set; }

        public fa_liquidacion_x_punto_cargo_det_mano_obra_Info()
        {
            lst_mano_obra_det = new List<fa_liquidacion_x_punto_cargo_det_mano_obra_det_Info>();
        }
    }
}
