using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Mantenimiento
{
    public class man_actividad_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdActividad { get; set; }
        public string ac_codigo { get; set; }
        public string ac_descripcion { get; set; }
        public string ac_observacion { get; set; }
        public double ac_cant_horas_min { get; set; }
        public bool estado { get; set; }
        public List<man_actividad_det_Info> lst_actividad_det { get; set; }

        public man_actividad_Info()
        {
            lst_actividad_det = new List<man_actividad_det_Info>();
        }

    }
}
