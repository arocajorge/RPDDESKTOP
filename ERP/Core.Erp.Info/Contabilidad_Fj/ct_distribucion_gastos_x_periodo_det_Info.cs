using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDistribucion { get; set; }
        public int Secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public int IdPunto_cargo { get; set; }
        public double valor { get; set; }

        public string nom_punto_cargo { get; set; }
        public string pc_Cuenta { get; set; }
        public double valor_aux { get; set; }
        public bool Checked { get; set; }
    }
}
