using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_Bus
    {
        XFAC_FJ_Rpt015_Data oData = new XFAC_FJ_Rpt015_Data();

        public List<XFAC_FJ_Rpt015_Info> get_info(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                return oData.get_info(IdEmpresa, IdSucursal, IdCentroCosto, IdLiquidacion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
