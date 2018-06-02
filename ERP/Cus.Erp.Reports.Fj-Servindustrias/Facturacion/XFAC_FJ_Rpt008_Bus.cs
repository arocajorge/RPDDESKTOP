using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt008_Bus
    {
        XFAC_FJ_Rpt008_Data oData = new XFAC_FJ_Rpt008_Data();
        public List<XFAC_FJ_Rpt008_Info> get_list(int IdEmpresa, decimal IdCliente, int IdVendedor, decimal IdTransportista, int IdPunto_cargo, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdCliente, IdVendedor, IdTransportista, IdPunto_cargo, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
