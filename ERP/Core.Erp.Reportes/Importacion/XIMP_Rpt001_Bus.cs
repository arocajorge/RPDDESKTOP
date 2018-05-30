using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Importacion
{
  public  class XIMP_Rpt001_Bus
  {
      XIMP_Rpt001_Data data = new XIMP_Rpt001_Data();
      public List<XIMP_Rpt001_Info> GetList(int IdEmpresa, decimal IdOrdencompra)
      {
          try
          {
              return data.GetList(IdEmpresa, IdOrdencompra);
          }
          catch (Exception)
          {
              
              return new List<XIMP_Rpt001_Info>();
          }
      }
    }
}
