using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_activos_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int Secuencia { get; set; }
        public int IdActivoFijo { get; set; }
        public double por_ganancia { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public int IdPeriodo_ini { get; set; }
        public int IdPeriodo_fin { get; set; }
        public int cant_act_x_scc { get; set; }
        public decimal IdGrupo { get; set; }
        public Nullable<double> valor_depr_x_scc { get; set; }
        public Nullable<double> valor_movilizacion { get; set; }
    }
}
