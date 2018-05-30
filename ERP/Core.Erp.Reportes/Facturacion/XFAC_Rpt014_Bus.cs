using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
   public  class XFAC_Rpt014_Bus
    {
       XFAC_Rpt014_Data Odata = new XFAC_Rpt014_Data();


       public List<XFAC_Rpt014_Info> Get_List_Data_Reporte(int IdEmpresa, decimal IdCliente, int idguia, ref string MensajeError)
       {
           try
           {

               return Odata.Get_List_Data_Reporte(IdEmpresa, IdCliente, idguia, ref MensajeError);
           }
           catch (Exception ex)
           {

               return new List<XFAC_Rpt014_Info>();
           }
       }
    }
}
