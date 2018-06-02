using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_parametro_FJ_Info
    {
        public int IdEmpresa { get; set; }
        public string p_tipo_porc_ganancia_tarifario_cat { get; set; }
        public Nullable<decimal> p_IdProducto_prefacturacion { get; set; }
        public string p_IdCod_Impuesto_IVA { get; set; }
    }
}
