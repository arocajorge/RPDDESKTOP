using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Importacion
{
    public class imp_liquidacion_det_x_imp_orden_compra_ext_Bus
    {
        imp_liquidacion_det_x_imp_orden_compra_ext_Data odata = new imp_liquidacion_det_x_imp_orden_compra_ext_Data();

        public List<imp_liquidacion_det_x_imp_orden_compra_ext_Info> get_list(int IdEmpresa, decimal IdLiquidacion)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdLiquidacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_liquidacion_det_x_imp_orden_compra_ext_Bus) };
            }
        }

        public bool guardarDB(List<imp_liquidacion_det_x_imp_orden_compra_ext_Info> Lista)
        {
            try
            {
                return odata.guardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(imp_liquidacion_det_x_imp_orden_compra_ext_Bus) };
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdLiquidacion)
        {
            try
            {
                return odata.eliminarDB(IdEmpresa, IdLiquidacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarDB", ex.Message), ex) { EntityType = typeof(imp_liquidacion_det_x_imp_orden_compra_ext_Bus) };
            }
        }
    }
}
