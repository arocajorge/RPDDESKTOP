using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Importacion
{
    public class imp_orden_compra_ext_det_Bus
    {
        imp_orden_compra_ext_det_Data odata = new imp_orden_compra_ext_det_Data();

        public List<imp_orden_compra_ext_det_Info> get_list(int IdEmpresa, decimal IdOrdenCompra_ext)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdOrdenCompra_ext);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_det_Bus) };
            }
        }

        public List<imp_orden_compra_ext_det_Info> get_list(int IdEmpresa, List<decimal> IdOrdenCompra_ext)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdOrdenCompra_ext);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_det_Bus) };
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdOrdenCompra_ext)
        {
            try
            {
                return odata.eliminarDB(IdEmpresa, IdOrdenCompra_ext);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarDB", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_det_Bus) };
            }
        }

        public bool guardarDB(List<imp_orden_compra_ext_det_Info> Lista)
        {
            try
            {
                return odata.guardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_det_Bus) };
            }
        }
    }
}
