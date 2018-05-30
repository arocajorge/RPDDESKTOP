using Core.Erp.Data.Contabilidad_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Contabilidad_Fj;

namespace Core.Erp.Business.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_det_Bus
    {
        ct_distribucion_gastos_x_periodo_det_Data oData = new ct_distribucion_gastos_x_periodo_det_Data();

        public List<ct_distribucion_gastos_x_periodo_det_Info> get_list(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdDistribucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_det_Bus) };
            }
        }

        public List<ct_distribucion_gastos_x_periodo_det_Info> get_list(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_det_Bus) };
            }
        }

        public bool guardarDB(ct_distribucion_gastos_x_periodo_det_Info info)
        {
            try
            {
                return oData.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_det_Bus) };
            }
        }
               
        public bool eliminarDB(int IdEmpresa, decimal IdDistribución, int Secuencia)
        {
            try
            {
                return oData.eliminarDB(IdEmpresa, IdDistribución, Secuencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(ct_distribucion_gastos_x_periodo_det_Bus) };
            }
        }

    }
}
