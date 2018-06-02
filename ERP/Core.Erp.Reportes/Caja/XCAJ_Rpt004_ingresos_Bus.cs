using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt004_ingresos_Bus
    {
        XCAJ_Rpt004_ingresos_Data odata = new XCAJ_Rpt004_ingresos_Data();

        public List<XCAJ_Rpt004_ingresos_Info> get_list(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdConciliacion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
