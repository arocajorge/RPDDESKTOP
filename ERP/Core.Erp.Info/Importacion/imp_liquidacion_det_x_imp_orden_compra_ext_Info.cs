using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Importacion
{
    public class imp_liquidacion_det_x_imp_orden_compra_ext_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int IdEmpresa_oe { get; set; }
        public decimal IdOrdenCompra_ext { get; set; }
        public string observacion { get; set; }
        public imp_orden_compra_ext_Info info_oc { get; set; }
        //Campos vista
        public bool seleccionado { get; set; }
        public DateTime oe_fecha { get; set; }

        public imp_liquidacion_det_x_imp_orden_compra_ext_Info()
        {
            info_oc = new imp_orden_compra_ext_Info();
        }
    }
}
