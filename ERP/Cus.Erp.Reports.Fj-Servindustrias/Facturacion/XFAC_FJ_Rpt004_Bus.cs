using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt004_Bus
    {
        XFAC_FJ_Rpt004_Data oData = new XFAC_FJ_Rpt004_Data();
        public List<XFAC_FJ_Rpt004_Info> get_list(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdPrefacturacion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
