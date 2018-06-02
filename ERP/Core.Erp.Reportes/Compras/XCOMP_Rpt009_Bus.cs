using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt009_Bus
    {
        XCOMP_Rpt009_Data oData = new XCOMP_Rpt009_Data();

        public List<XCOMP_Rpt009_Info> get_list(int IdEmpresa, int IdSucursal, decimal IdSolicitante, DateTime Fecha_ini, DateTime Fecha_fin, decimal IdProducto)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, IdSolicitante, Fecha_ini, Fecha_fin,IdProducto);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
