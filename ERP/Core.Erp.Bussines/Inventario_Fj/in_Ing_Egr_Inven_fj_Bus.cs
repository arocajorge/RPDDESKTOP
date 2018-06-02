using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario_Fj;
using Core.Erp.Data.Inventario_Fj;

namespace Core.Erp.Business.Inventario_Fj
{
    public class in_Ing_Egr_Inven_fj_Bus
    {
        in_Ing_Egr_Inven_fj_Data oData = new in_Ing_Egr_Inven_fj_Data();

        public in_Ing_Egr_Inven_fj_Info get_info(int IdEmpresa, int IdSucursal, int IdMoviInven_tipo, decimal IdNumMovi)
        {
            try
            {
                return oData.get_info(IdEmpresa, IdSucursal, IdMoviInven_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_info", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_fj_Bus) };
            }
        }

        public bool guardarDB(in_Ing_Egr_Inven_fj_Info info)
        {
            try
            {
                return oData.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_fj_Bus) };
            }
        }

        public bool modificarDB(in_Ing_Egr_Inven_fj_Info info)
        {
            try
            {
                return oData.modificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_fj_Bus) };
            }
        }
    }
}
