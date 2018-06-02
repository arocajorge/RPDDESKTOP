using Core.Erp.Data.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_Producto_alerta_x_sucursal_Bus
    {
        in_Producto_alerta_x_sucursal_Data oData = new in_Producto_alerta_x_sucursal_Data();

        public List<in_Producto_alerta_x_sucursal_Info> get_list(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(in_Producto_alerta_x_sucursal_Bus) };
            }
        }

        public bool eliminarDB(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return oData.eliminarDB(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarDB", ex.Message), ex) { EntityType = typeof(in_Producto_alerta_x_sucursal_Bus) };
            }
        }

        public bool guardarDB(List<in_Producto_alerta_x_sucursal_Info> Lista, int IdEmpresa, int IdSucursal)
        {
            try
            {
                eliminarDB(IdEmpresa, IdSucursal);
                return oData.guardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(in_Producto_alerta_x_sucursal_Bus) };
            }
        }
    }
}
