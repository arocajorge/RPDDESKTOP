using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_tarifario_horometro_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTarifario { get; set; }
        public string IdCentroCosto { get; set; }
        public int IdPeriodo_ini { get; set; }
        public int IdPeriodo_fin { get; set; }
        public string Observacion { get; set; }
        public bool estado { get; set; }
        public decimal IdProducto_hora_regular { get; set; }
        public decimal IdProducto_hora_extra { get; set; }
        public string IdCod_Impuesto { get; set; }
        public double porcentaje { get; set; }

        public string Centro_costo { get; set; }
        public List<fa_tarifario_horometro_det_Info> lst_det { get; set; }

        public fa_tarifario_horometro_Info()
        {
            lst_det = new List<fa_tarifario_horometro_det_Info>();
        }
    }
}
