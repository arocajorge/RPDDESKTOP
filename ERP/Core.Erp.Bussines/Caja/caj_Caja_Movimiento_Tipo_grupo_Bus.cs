using Core.Erp.Data.Caja;
using Core.Erp.Info.Caja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Caja
{
    public class caj_Caja_Movimiento_Tipo_grupo_Bus
    {
        caj_Caja_Movimiento_Tipo_grupo_Data oData = new caj_Caja_Movimiento_Tipo_grupo_Data();

        public List<caj_Caja_Movimiento_Tipo_grupo_Info> get_list()
        {
            try
            {
                return oData.get_list();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_caja", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_grupo_Bus) };
            }
        }

        public bool guardarDB(caj_Caja_Movimiento_Tipo_grupo_Info info)
        {
            try
            {
                return oData.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_caja", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_grupo_Bus) };
            }
        }
        
        public bool modificarDB(caj_Caja_Movimiento_Tipo_grupo_Info info)
        {
            try
            {
                return oData.modificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_caja", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_grupo_Bus) };
            }
        }

        public bool anularDB(caj_Caja_Movimiento_Tipo_grupo_Info info)
        {
            try
            {
                return oData.anularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_caja", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_grupo_Bus) };
            }
        }
    }
}
