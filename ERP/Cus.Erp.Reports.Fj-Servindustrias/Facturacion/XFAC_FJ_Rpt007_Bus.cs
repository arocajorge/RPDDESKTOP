using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt007_Bus
    {
        XFAC_FJ_Rpt007_Data oData = new XFAC_FJ_Rpt007_Data();

        public List<XFAC_FJ_Rpt007_Info> get_list(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdPeriodo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<XFAC_FJ_Rpt007_Info> get_list(int IdEmpresa, int IdPeriodo, decimal IdCliente)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdPeriodo,IdCliente);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
