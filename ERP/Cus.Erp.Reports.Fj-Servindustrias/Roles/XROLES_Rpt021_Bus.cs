using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt021_Bus
    {
        XROLES_Rpt021_Data oData = new XROLES_Rpt021_Data();

        public List<XROLES_Rpt021_Info> get_list(int IdEmpresa, int IdNomina_tipo, decimal IdEmpleado, int IdDescuento)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdNomina_tipo, IdEmpleado, IdDescuento);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
