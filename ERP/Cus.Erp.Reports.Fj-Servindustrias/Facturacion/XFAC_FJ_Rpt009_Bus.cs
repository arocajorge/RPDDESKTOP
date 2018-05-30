using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt009_Bus
    {
        XFAC_FJ_Rpt009_Data oData = new XFAC_FJ_Rpt009_Data();

        public List<XFAC_FJ_Rpt009_Info> get_list(int IdEmpresa, decimal IdCliente, int IdVendedor, int IdPunto_cargo_grupo, int IdPunto_cargo, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdCliente, IdVendedor,IdPunto_cargo_grupo, IdPunto_cargo, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
