
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt030_Info
    {

        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdSolicitudVaca { get; set; }
        public decimal IdEmpleado { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Nombre { get; set; }
        public string ca_descripcion { get; set; }
        public System.DateTime Anio_Desde { get; set; }
        public System.DateTime Anio_Hasta { get; set; }
        public string AnioServicio { get; set; }
        public string Dias_q_Corresponde { get; set; }
        public int Dias_a_disfrutar { get; set; }
        public int Dias_pendiente { get; set; }
        public System.DateTime Fecha_Desde { get; set; }
        public System.DateTime Fecha_Hasta { get; set; }
        public System.DateTime Fecha_Retorno { get; set; }
        public string Observacion { get; set; }
        public string Gozadas_Pgadas { get; set; }
        public double ValorCancelado { get; set; }
        public System.DateTime FechaPago { get; set; }
        public Nullable<double> Iess { get; set; }

        public XROL_Rpt030_Info() { }

    }
}
