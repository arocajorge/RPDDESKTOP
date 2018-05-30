using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Alertas.Inventario
{
    public class XINV_001_Bus
    {
        XINV_001_Data oData = new XINV_001_Data();

        public List<XINV_001_Info> get_list(int IdEmpresa, int IdSucursal, bool mostrar_productos_sin_alerta)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, mostrar_productos_sin_alerta);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
