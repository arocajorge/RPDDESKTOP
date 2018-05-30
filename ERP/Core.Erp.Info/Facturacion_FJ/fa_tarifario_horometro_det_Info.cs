using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_tarifario_horometro_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTarifario { get; set; }
        public int Secuencia { get; set; }
        public int IdActivoFijo { get; set; }
        public double valor_unidad { get; set; }
        public double unidades_minimas { get; set; }
        public double total_valor_x_unidades_minimas { get; set; }
        //Campos para calcular tarifario
        public decimal IdProducto_normal { get; set; }
        public decimal IdProducto_extra { get; set; }
        public string IdCod_Impuesto { get; set; }
        public double porcentaje { get; set; }
    }
}
