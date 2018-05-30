using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt012_Bus
    {
        public List<XFAC_Rpt012_Info> get_list(int IdEmpresa, int IdSucursal, decimal IdProforma, bool buscar_imagen)
        {
            try
            {
                XFAC_Rpt012_Data odata = new XFAC_Rpt012_Data();
                return odata.get_list(IdEmpresa, IdSucursal, IdProforma,buscar_imagen);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
