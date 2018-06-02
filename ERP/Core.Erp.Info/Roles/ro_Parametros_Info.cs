using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Parametros_Info
    {
        public int IdEmpresa { get; set; }
        public Nullable<int> IdTipoCbte_AsientoSueldoXPagar { get; set; }
        public Nullable<bool> GeneraOP_PagoPrestamos { get; set; }
        public string IdTipoOP_PagoPrestamos { get; set; }
        public string IdFormaOP_PagoPrestamos { get; set; }
        public Nullable<bool> GeneraOP_LiquidacionVacaciones { get; set; }
        public string IdTipoOP_LiquidacionVacaciones { get; set; }
        public Nullable<int> IdTipoFlujoOP_LiquidacionVacaciones { get; set; }
        public string IdFormaOP_LiquidacionVacaciones { get; set; }
        public Nullable<bool> DescuentaIESS_LiquidacionVacaciones { get; set; }
        public string cta_contable_IESS_Vacaciones { get; set; }
        public Nullable<bool> GeneraOP_ActaFiniquito { get; set; }
        public string IdTipoOP_ActaFiniquito { get; set; }
        public string IdFormaPagoOP_ActaFiniquito { get; set; }
        public double Sueldo_basico { get; set; }
        public double Porcentaje_aporte_pers { get; set; }
        public double Porcentaje_aporte_patr { get; set; }
        public string IdRubro_acta_finiquito { get; set; }

        public ro_Parametros_Info()
        {

        }
    }
}
