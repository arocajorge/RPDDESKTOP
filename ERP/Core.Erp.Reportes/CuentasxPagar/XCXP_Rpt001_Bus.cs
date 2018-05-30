using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt001_Bus
    {
        XCXP_Rpt001_Data estadodata = new XCXP_Rpt001_Data();


        public List<XCXP_Rpt001_Info> get_list(int IdEmpresa, int IdClase_proveedor, decimal IdProveedor, DateTime Fecha_corte, bool no_mostrar_saldo_0, bool no_mostrar_en_conciliacion)
        {
            try
            {
                return estadodata.get_list(IdEmpresa, IdClase_proveedor, IdProveedor, Fecha_corte, no_mostrar_saldo_0,no_mostrar_en_conciliacion);
            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt001_Info>();
            }
        }

        public XCXP_Rpt001_Bus()
        {
        }
    }
}
