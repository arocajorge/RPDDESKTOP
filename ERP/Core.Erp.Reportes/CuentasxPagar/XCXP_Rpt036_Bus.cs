using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt036_Bus
    {
        XCXP_Rpt036_Data oData = new XCXP_Rpt036_Data();

        public List<XCXP_Rpt036_Info> get_list(int IdEmpresa, decimal IdProveedor, bool no_mostrar_saldo_0, DateTime Fecha_ini, DateTime Fecha_fin, bool mostrar_origen_bodega, bool mostrar_origen_caja)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdProveedor, no_mostrar_saldo_0,Fecha_ini,Fecha_fin,mostrar_origen_bodega,mostrar_origen_caja);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
