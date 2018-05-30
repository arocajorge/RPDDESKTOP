using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Contabilidad
{
    public class XCONTA_FJ_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCtaCble { get; set; }
        public int IdPunto_cargo { get; set; }
        public string pc_Cuenta { get; set; }
        public string nom_punto_cargo { get; set; }
        public int IdNivelCta { get; set; }
        public string IdGrupoCble { get; set; }
        public byte gc_Orden { get; set; }
        public Nullable<decimal> IdCtaCblePadre { get; set; }
        public string gc_estado_financiero { get; set; }
        public string pc_EsMovimiento { get; set; }
        public string gc_GrupoCble { get; set; }
        public double bg_saldo_inicial { get; set; }
        public double bg_debitos_mes { get; set; }
        public double bg_creditos_mes { get; set; }
        public double bg_saldo_mes { get; set; }
        public double bg_saldo_final { get; set; }
        public string IdCtaCble_2 { get; set; }
        public string IdCtaCblePadre_2 { get; set; }
        public double bg_saldo_inicial_mov { get; set; }
        public double bg_debitos_mes_mov { get; set; }
        public double bg_creditos_mes_mov { get; set; }
        public double bg_saldo_mes_mov { get; set; }
        public double bg_saldo_final_mov { get; set; }
    }
}
