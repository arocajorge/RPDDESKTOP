using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Contabilidad
{
    public class XCONTA_FJ_Rpt001_Bus
    {
        XCONTA_FJ_Rpt001_Data oData = new XCONTA_FJ_Rpt001_Data();

        public List<XCONTA_FJ_Rpt001_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, int IdPunto_cargo, bool mostrar_saldo_0, int Nivel)
        {
            try
            {
                return oData.get_list(IdEmpresa, Fecha_ini, Fecha_fin, IdPunto_cargo, mostrar_saldo_0, Nivel);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
