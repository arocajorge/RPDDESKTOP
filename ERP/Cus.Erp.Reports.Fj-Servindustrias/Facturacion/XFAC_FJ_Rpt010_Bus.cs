using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt010_Bus
    {
        XFAC_FJ_Rpt010_Data oData = new XFAC_FJ_Rpt010_Data();

        public List<XFAC_FJ_Rpt010_Info> get_list(int IdEmpresa, string IdCentroCosto, string IdCentroCosto_sub_centro_costo, int IdPeriodo_ini, int IdPeriodo_fin, int IdPunto_cargo)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdCentroCosto, IdCentroCosto_sub_centro_costo, IdPeriodo_ini, IdPeriodo_fin, IdPunto_cargo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
