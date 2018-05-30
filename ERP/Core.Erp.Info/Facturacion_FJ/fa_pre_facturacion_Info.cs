using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int IdPeriodo { get; set; }
        public string Observacion { get; set; }
        public bool estado_cierre { get; set; }
        public System.DateTime fecha { get; set; }
        public string estado { get; set; }
        public string IdCentroCosto { get; set; }

        public int pe_mes { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string nom_Centro_costo { get; set; }
        public int TotalEquipos { get; set; }
        public double ValorFacturar { get; set; }
        public List<fa_pre_facturacion_det_Fact_x_Gastos_Info> lst_det_fact { get; set; }
        public List<fa_pre_facturacion_det_Info> lst_det { get; set; }
        public List<fa_pre_facturacion_activos_Info> lst_det_act { get; set; }
        public List<fa_pre_facturacion_det_otros_Info> lst_det_otros { get; set; }
        
    }
}
