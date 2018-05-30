using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDistribucion { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
        public List<ct_distribucion_gastos_x_periodo_det_Info> lst_det { get; set; }

        public ct_distribucion_gastos_x_periodo_Info()
        {
            lst_det = new List<ct_distribucion_gastos_x_periodo_det_Info>();
        }
    }
}
