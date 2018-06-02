using Core.Erp.Data.Alerta;
using Core.Erp.Info.Alerta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Alerta
{
    public class tb_sis_alerta_Bus
    {
        tb_sis_alerta_Data oData = new tb_sis_alerta_Data();

        public List<tb_sis_alerta_Info> get_list()
        {
            try
            {
                return oData.get_list();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(tb_sis_alerta_Bus) };
            }
        }

        public bool guardarDB(tb_sis_alerta_Info info)
        {
            try
            {
                return oData.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_alerta_Bus) };
            }
        }

        public bool modificarDB(tb_sis_alerta_Info info)
        {
            try
            {
                return oData.modificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarDB", ex.Message), ex) { EntityType = typeof(tb_sis_alerta_Bus) };
            }
        }

        public string Get_Numero(string CodModulo)
        {
            try
            {
                return oData.Get_Numero(CodModulo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarDB", ex.Message), ex) { EntityType = typeof(tb_sis_alerta_Bus) };
            }
        }        
    }
}
