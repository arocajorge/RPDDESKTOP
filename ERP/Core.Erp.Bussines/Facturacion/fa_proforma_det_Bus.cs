using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    public class fa_proforma_det_Bus
    {
        fa_proforma_det_Data oData = new fa_proforma_det_Data();

        public List<fa_proforma_det_Info> get_list(int IdEmpresa, int IdSucursal, decimal IdProforma)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, IdProforma);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(fa_proforma_det_Bus) };
            }
        }

        public List<fa_proforma_det_Info> get_list_para_facturar(int IdEmpresa,int IdSucursal, int IdBodega, decimal IdCliente)
        {
            try
            {
                return oData.get_list_para_facturar(IdEmpresa, IdSucursal,IdBodega, IdCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(fa_proforma_det_Bus) };
            }
        }

        public bool guardarDB(List<fa_proforma_det_Info> lista)
        {
            try
            {
                return oData.guardarDB(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(fa_proforma_det_Bus) };
            }
        }

        public bool eliminarDB(int IdEmpresa, int IdSucursal, decimal IdProforma)
        {
            try
            {
                return oData.eliminarDB(IdEmpresa, IdSucursal, IdProforma);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarDB", ex.Message), ex) { EntityType = typeof(fa_proforma_det_Bus) };
            }
        }

        public bool anular_detalle(List<fa_proforma_det_Info> lista)
        {
            try
            {
                return oData.anular_detalle(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarDB", ex.Message), ex) { EntityType = typeof(fa_proforma_det_Bus) };
            }
        }
    }
}
