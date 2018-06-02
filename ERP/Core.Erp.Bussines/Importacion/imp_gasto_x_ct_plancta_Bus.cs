using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Importacion
{
    public class imp_gasto_x_ct_plancta_Bus
    {
        imp_gasto_x_ct_plancta_Data odata = new imp_gasto_x_ct_plancta_Data();

        public List<imp_gasto_x_ct_plancta_Info> get_list(int IdEmpresa)
        {
            try
            {
                return odata.get_list(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_gasto_x_ct_plancta_Bus) };
            }
        }

        public bool guardarDB(imp_gasto_x_ct_plancta_Info info)
        {
            try
            {
                return odata.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(imp_gasto_x_ct_plancta_Bus) };
            }
        }
    }
}
