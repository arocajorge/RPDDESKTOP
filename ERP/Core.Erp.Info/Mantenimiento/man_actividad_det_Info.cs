using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Mantenimiento
{
    public class man_actividad_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdActividad { get; set; }
        public int ac_secuencia { get; set; }
        public decimal IdActividad_hijo { get; set; }
    }
}
