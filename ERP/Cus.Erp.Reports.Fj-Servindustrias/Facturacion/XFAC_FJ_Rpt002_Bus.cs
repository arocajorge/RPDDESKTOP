using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt002_Bus
    {
        XFAC_FJ_Rpt002_Data oData = new XFAC_FJ_Rpt002_Data();

        public List<XFAC_FJ_Rpt002_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                return oData.Get_List(IdEmpresa, IdPrefacturacion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
