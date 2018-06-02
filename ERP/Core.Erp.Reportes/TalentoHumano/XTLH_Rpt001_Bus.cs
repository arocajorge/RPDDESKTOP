using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Reportes.TalentoHumano;
namespace Core.Erp.Reportes.TalentoHumano
{
   public class XTLH_Rpt001_Bus
    {
       XTLH_Rpt001_Data data = new XTLH_Rpt001_Data();

       public List<XTLH_Rpt001_Info> getList(int IdEmpresa, int IdCalendario)
       {
           try
           {
               return data.getList(IdEmpresa,IdCalendario);
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}
