using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Alerta
{
    public class tb_sis_alerta_Info
    {
        public string CodAlerta { get; set; }
        public string Nombre { get; set; }
        public string CodModulo { get; set; }
        public string VistaRpt { get; set; }
        public string Formulario { get; set; }
        public string Class_NomReporte { get; set; }
        public string nom_Asembly { get; set; }
        public string Class_Info { get; set; }
        public string Class_Bus { get; set; }
        public string Class_Data { get; set; }
        public bool Estado { get; set; }
        public string observacion { get; set; }
    }
}
