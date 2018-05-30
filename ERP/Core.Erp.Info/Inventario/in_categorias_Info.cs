using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_categorias_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public string ca_Categoria2 { get; set; }
        public bool check { get; set; }
        public string Estado { get; set; }
        public string IdCtaCtble_Inve { get; set; }
        public string IdCtaCble_venta { get; set; }

        public string IdCtaCtble_Costo { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string cod_categoria { get; set; }
        public in_categorias_Info() {
        }

    }
}
