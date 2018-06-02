
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Participacion_Utilidad_Info
    {
        public List<ro_Participacion_Utilidad_Empleado_Info> oListRo_Participacion_Utilidad_Empleado_Info = new List<ro_Participacion_Utilidad_Empleado_Info>();

        public int IdEmpresa { get; set; }
        public int IdUtilidad { get; set; }
        public int IdNomina { get; set; }
        public int IdNominaTipo_liq { get; set; }
        public int IdPeriodo { get; set; }
        public double UtilidadDerechoIndividual { get; set; }
        public double UtilidadCargaFamiliar { get; set; }
        public double LimiteDistribucionUtilidad { get; set; }
        public Nullable<System.DateTime> FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public string Observacion { get; set; }
        public string IdUsuarioModifica { get; set; }
        public Nullable<System.DateTime> Fecha_ultima_modif { get; set; }
        public string IdUsuario_anula { get; set; }
        public Nullable<System.DateTime> Fecha_anulacion { get; set; }
        public string Estado { get; set; }
        public string Cerrado { get; set; }
        public string Procesado { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string Descripcion { get; set; }
        public ro_Participacion_Utilidad_Info() { }

    }
}
