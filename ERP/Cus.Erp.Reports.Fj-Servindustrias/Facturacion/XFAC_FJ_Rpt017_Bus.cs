using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt017_Bus
    {
        XFAC_FJ_Rpt017_Data oData = new XFAC_FJ_Rpt017_Data();

        public List<XFAC_FJ_Rpt017_Info> get_list(int IdEmpresa, decimal IdCliente, DateTime Fecha_ini, DateTime Fecha_fin, bool no_mostrar_saldo_0)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdCliente, Fecha_ini, Fecha_fin, no_mostrar_saldo_0);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
