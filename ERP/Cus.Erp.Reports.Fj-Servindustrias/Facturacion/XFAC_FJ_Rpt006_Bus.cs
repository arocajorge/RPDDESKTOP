using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    class XFAC_FJ_Rpt006_Bus
    {
        XFAC_FJ_Rpt006_Data oData = new XFAC_FJ_Rpt006_Data();
        public List<XFAC_FJ_Rpt006_Info> get_list(int IdEmpresa, int IdSucursal, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
