using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt020_Bus
    {
        XCXC_Rpt020_Data oData = new XCXC_Rpt020_Data();

        public List<XCXC_Rpt020_Info> get_list(int IdEmpresa, decimal IdCliente, DateTime Fecha_corte, bool no_mostrar_saldo_0, bool mostrar_anuladas)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdCliente, Fecha_corte, no_mostrar_saldo_0, mostrar_anuladas);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
