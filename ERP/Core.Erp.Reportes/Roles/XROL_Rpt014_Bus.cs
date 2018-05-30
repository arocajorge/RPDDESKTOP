using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt014_Bus
    {
      XROL_Rpt014_Data data = new XROL_Rpt014_Data();
      public List<XROL_Rpt014_Info> Get_list_Rubros_X_Empleados(int idEmpresa, int idNomina, int iddivision)
      {
          try
          {
              return data.Get_list_Rubros_X_Empleados(idEmpresa, idNomina, iddivision);
          }
          catch (Exception ex)
          {
              
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Rubros_X_Empleados", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }
      public List<XROL_Rpt014_Info> Get_list_Rubros_X_Empleados(int idEmpresa, int idNomina)
      {
          try
          {
              return data.Get_list_Rubros_X_Empleados(idEmpresa, idNomina);
          }
          catch (Exception ex)
          {

              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Rubros_X_Empleados", ex.Message), ex) { EntityType = typeof(XROL_Rpt014_Bus) };

          }
      }

    }
}
