using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt004_Bus
    {
        XBAN_Rpt004_Data odata = new XBAN_Rpt004_Data();
        public List<XBAN_Rpt004_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin, int idBancoIni, int idBancoFin, string TipoCbte)
        {
            try
            {
                return odata.Cargar_data(idempresa, FechaIni, FechaFin, idBancoIni, idBancoFin, TipoCbte);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
            


        }
    }
}
