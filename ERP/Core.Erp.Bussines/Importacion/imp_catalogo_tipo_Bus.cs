using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Importacion
{
    public class imp_catalogo_tipo_Bus
    {
        imp_catalogo_tipo_Data odata = new imp_catalogo_tipo_Data();

        public List<imp_catalogo_tipo_Info> get_list()
        {
            try
            {
                return odata.get_list();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_catalogo_tipo_Bus) };
            }           
        }

        public bool guardarDB(imp_catalogo_tipo_Info info)
        {
            try
            {
                return odata.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(imp_catalogo_tipo_Bus) };
            }           
        }

        public bool modificarDB(imp_catalogo_tipo_Info info)
        {
            try
            {
                return odata.modificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarDB", ex.Message), ex) { EntityType = typeof(imp_catalogo_tipo_Bus) };
            }
        }

        public bool anularDB(imp_catalogo_tipo_Info info)
        {
            try
            {
                return odata.anularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "anularDB", ex.Message), ex) { EntityType = typeof(imp_catalogo_tipo_Bus) };
            }
        }

    }
}
