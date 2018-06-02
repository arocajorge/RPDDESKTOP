using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario_Fj
{
    public class in_Ing_Egr_Inven_fj_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string cod_orden_mantenimiento { get; set; }
        public Nullable<decimal> IdEmpleado { get; set; }
    }
}
