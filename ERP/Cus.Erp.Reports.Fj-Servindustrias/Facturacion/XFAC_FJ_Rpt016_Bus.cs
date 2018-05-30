using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt016_Bus
    {


       XFAC_FJ_Rpt016_Data data = new XFAC_FJ_Rpt016_Data();
       public List<XFAC_FJ_Rpt016_Info> GetList_procesar(int idEmpresa, int IdPeriodo, DateTime FechaInicio, DateTime FechaFin)
       {
           try
           {
               return data.GetList_procesar(idEmpresa, IdPeriodo, FechaInicio, FechaFin);
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}
