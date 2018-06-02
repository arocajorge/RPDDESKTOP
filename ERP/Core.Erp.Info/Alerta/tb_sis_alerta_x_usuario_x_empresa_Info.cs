using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Alerta
{
    public class tb_sis_alerta_x_usuario_x_empresa_Info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public string CodAlerta { get; set; }
        public Nullable<int> IdSucursal { get; set; }

        public List<tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info> lst_eventos { get; set; }

        public tb_sis_alerta_x_usuario_x_empresa_Info()
        {
            lst_eventos = new List<tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info>();
        }
    }
}
