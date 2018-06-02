using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_mano_obra_det_Bus
    {
        XFAC_FJ_Rpt015_mano_obra_det_Data oData = new XFAC_FJ_Rpt015_mano_obra_det_Data();

        public List<XFAC_FJ_Rpt015_mano_obra_det_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, IdCentroCosto, IdLiquidacion);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
