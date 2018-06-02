
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_Acta_Finiquito_Detalle_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdActaFiniquito { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdSecuencia { get; set; }
        public string Observacion { get; set; }
        public string IdRubro { get; set; }
        public double Valor { get; set; }
        
        public ro_Acta_Finiquito_Detalle_Info() { }
    }
}
