using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
using Core.Erp.Data.Roles;

namespace Core.Erp.Business.Roles
{
   public class ro_Acta_Finiquito_Detalle_x_vacaciones_Bus
   {
       ro_Acta_Finiquito_Detalle_x_vacaciones_Data data = new Data.Roles.ro_Acta_Finiquito_Detalle_x_vacaciones_Data();
       public bool Guardar_DB(ro_Acta_Finiquito_Detalle_x_vacaciones_Info info)
       {
           try
           {
               return data.Guardar_DB(info);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };

           }
       }

       public bool Eliminar(ro_Acta_Finiquito_Detalle_x_vacaciones_Info info)
       {
           string mensaje = "";
           try
           {
               return data.Eliminar(info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };

           }
       }
       public List<ro_Acta_Finiquito_Detalle_x_vacaciones_Info> Get_Lis(int IdEmpresa, int idempleado, int idsolicitud)
       {
           try
           {
               return data.Get_Lis(IdEmpresa, idempleado, idsolicitud);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarHistoricoVaca", ex.Message), ex) { EntityType = typeof(ro_historico_vacaciones_x_empleado_Bus) };

           }
       }
  
    }
}
