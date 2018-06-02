using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Importacion
{
    public class imp_orden_compra_ext_recepcion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenCompra_ext { get; set; }
        public System.DateTime or_fecha { get; set; }
        public string or_observacion { get; set; }
    }
}
