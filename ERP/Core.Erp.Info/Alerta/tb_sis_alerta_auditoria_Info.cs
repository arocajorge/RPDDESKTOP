using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Alerta
{
    public class tb_sis_alerta_auditoria_Info
    {
        public decimal IdRegistro { get; set; }
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public string CodAlerta { get; set; }
        public string enum_evento { get; set; }
        public System.DateTime fecha_transac { get; set; }
        public string observacion { get; set; }
    }
}
