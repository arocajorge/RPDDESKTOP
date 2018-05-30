using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;

namespace Core.Erp.Business.Importacion
{
    public class imp_catalogo_Bus
    {
        imp_catalogo_Data odata = new imp_catalogo_Data();

        public List<imp_catalogo_Info> get_list(int IdCatalogo_tipo)
        {
            try
            {
                return odata.get_list(IdCatalogo_tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_catalogo_Bus) };
            } 
        }

        public bool guardarDB(imp_catalogo_Info info)
        {
            try
            {
                return odata.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(imp_catalogo_Bus) };
            }
        }

        public bool modificarDB(imp_catalogo_Info info)
        {
            try
            {
                return odata.modificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarDB", ex.Message), ex) { EntityType = typeof(imp_catalogo_Bus) };
            }
        }

        public bool anularDB(imp_catalogo_Info info)
        {
            try
            {
                return odata.anularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "anularDB", ex.Message), ex) { EntityType = typeof(imp_catalogo_Bus) };
            }
        }
    }
}
