using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Alerta
{
    public class tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public string CodAlerta { get; set; }
        public string enum_evento { get; set; }
        public string observacion { get; set; }

        public bool seleccionado { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Formulario { get; set; }
        public string nom_Asembly { get; set; }
    }
}
