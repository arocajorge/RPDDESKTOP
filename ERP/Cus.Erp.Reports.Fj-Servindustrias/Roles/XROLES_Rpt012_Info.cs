using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt012_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public Nullable<int> pe_anio { get; set; }
        public Nullable<int> pe_mes { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string zo_descripcion { get; set; }
        public string fu_descripcion { get; set; }
        public string Disco { get; set; }
        public string Placa { get; set; }
        public string ru_descripcion { get; set; }
        public string em_fechaIngaRol { get; set; }
        public string pe_FechaIni { get; set; }
        public string em_fechaSalida { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string ca_descripcion { get; set; }
        public int ca_orden { get; set; }
        public string ca_estado { get; set; }
        public string Catalogo { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public int Orden { get; set; }
        public Nullable<int> Dias_vacaciones { get; set; }

    }
}
