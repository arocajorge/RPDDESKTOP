using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Importacion
{
    public class imp_liquidacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdLiquidacion { get; set; }
        public string li_num_documento { get; set; }
        public string li_codigo { get; set; }
        public string li_num_DAU { get; set; }
        public System.DateTime li_fecha { get; set; }
        public string li_observacion { get; set; }
        public double li_factor_conversion { get; set; }
        public double li_total_fob { get; set; }
        public double li_total_gastos { get; set; }
        public double li_total_bodega { get; set; }
        public double li_factor_costo { get; set; }
        public bool estado { get; set; }
        public bool cerrado { get; set; }

        public List<imp_liquidacion_det_x_imp_orden_compra_ext_Info> lst_det_oc { get; set; }

        public imp_liquidacion_Info()
        {
            lst_det_oc = new List<imp_liquidacion_det_x_imp_orden_compra_ext_Info>();
        }
    }
}
