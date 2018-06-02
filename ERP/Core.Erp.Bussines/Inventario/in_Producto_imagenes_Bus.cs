using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario
{
    public class in_Producto_imagenes_Bus
    {
        in_Producto_imagenes_Data odata = new in_Producto_imagenes_Data();

        public in_Producto_imagenes_Info get_info(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                return odata.get_info(IdEmpresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_info", ex.Message), ex) { EntityType = typeof(in_Producto_imagenes_Bus) };
            }
        }

        public bool guardarDB(in_Producto_imagenes_Info info)
        {
            try
            {
                return odata.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(in_Producto_imagenes_Bus) };
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                return odata.eliminarDB(IdEmpresa, IdProducto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarDB", ex.Message), ex) { EntityType = typeof(in_Producto_imagenes_Bus) };
            }
        }
    }
}
