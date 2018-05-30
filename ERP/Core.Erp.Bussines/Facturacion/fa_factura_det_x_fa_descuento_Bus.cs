using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    public class fa_factura_det_x_fa_descuento_Bus
    {
        fa_factura_det_x_fa_descuento_Data oData = new fa_factura_det_x_fa_descuento_Data();

        public List<fa_factura_det_x_fa_descuento_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, int Secuencia)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, Secuencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_factura_det_x_fa_descuento_Bus) };
            }    
        }

        public bool GuardarDB(fa_factura_det_x_fa_descuento_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_factura_det_x_fa_descuento_Bus) };
            }  
        }

        public bool GuardarDB(List<fa_factura_det_x_fa_descuento_Info> lst)
        {
            try
            {
                return oData.GuardarDB(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_factura_det_x_fa_descuento_Bus) };
            }  
        }

        public bool EliminarDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_factura_det_x_fa_descuento_Bus) };
            }  
        }
        
    }
}
