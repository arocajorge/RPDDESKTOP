using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt007_Info
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int IdActivoFijo { get; set; }
        public Nullable<double> Valor_Maximo_x_periodo { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public string Af_DescripcionCorta { get; set; }
        public string Centro_costo { get; set; }
        public string SucentroCosto { get; set; }
        public Nullable<decimal> Total_horas_operadores { get; set; }
        public Nullable<double> Total_Horas_maquina { get; set; }
        public Nullable<double> diferencia { get; set; }
        public Nullable<double> por_horas_ocupada_la_maquina_vx_ho { get; set; }
    }
}
