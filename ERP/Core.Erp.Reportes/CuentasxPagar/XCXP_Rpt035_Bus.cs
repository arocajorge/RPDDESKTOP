using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt035_Bus
    {
       XCXP_Rpt035_Data dataRpt = new XCXP_Rpt035_Data();

       public List<XCXP_Rpt035_Info> get_Reporte_Estado_Cuenta_Proveedor_con_Dias_Vencidos(int IdEmpresa, DateTime FechaCorte, decimal IdProveedorIni, decimal IdProveedorFin, bool no_mostrar_en_conciliacion, bool no_mostrar_saldo_0)
       {
            try
            {
                return dataRpt.get_Reporte_Estado_Cuenta_Proveedor_con_Dias_Vencidos(IdEmpresa, FechaCorte, IdProveedorIni, IdProveedorFin,no_mostrar_en_conciliacion,no_mostrar_saldo_0);
            }
            catch (Exception)
            {
                return new List<XCXP_Rpt035_Info>();
            }
        }
    }
}
