using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Importacion
{
    public class imp_liquidacion_Bus
    {
        imp_liquidacion_Data odata = new imp_liquidacion_Data();
        imp_liquidacion_det_x_imp_orden_compra_ext_Bus bus_det_oc = new imp_liquidacion_det_x_imp_orden_compra_ext_Bus();
        imp_orden_compra_ext_det_Bus bus_oc_det = new imp_orden_compra_ext_det_Bus();

        public List<imp_liquidacion_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return odata.get_list(IdEmpresa, Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_liquidacion_Bus) };
            }
        }

        private bool generar_movimiento_inventario(imp_liquidacion_Info info)
        {
            try
            {
                bool res = false;





                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "generar_movimiento_inventario", ex.Message), ex) { EntityType = typeof(imp_liquidacion_Bus) };
            }
        }

        private bool generar_diario_x_importacion(imp_liquidacion_Info info)
        {
            try
            {
                bool res = false;


                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "generar_diario_x_importacion", ex.Message), ex) { EntityType = typeof(imp_liquidacion_Bus) };
            }
        }

        public bool modificarDB_cierre(imp_liquidacion_Info info)
        {
            try
            {
                bool res = false;

                res = generar_movimiento_inventario(info);
                if (!res)
                    return false;

                res = generar_diario_x_importacion(info);
                if (!res)
                    return false;

                if (odata.modificarDB_cierre(info))
                {
                    res = true;    
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarDB_cierre", ex.Message), ex) { EntityType = typeof(imp_liquidacion_Bus) };
            }
        }

        public bool guardarDB(imp_liquidacion_Info info)
        {
            try
            {
                bool res = false;

                if (odata.guardarDB(info))
                {
                    foreach (var item in info.lst_det_oc)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdLiquidacion = info.IdLiquidacion;

                        bus_oc_det.eliminarDB(info.IdEmpresa, item.IdOrdenCompra_ext);
                        bus_oc_det.guardarDB(item.info_oc.lst_det);
                    }
                    res = bus_det_oc.guardarDB(info.lst_det_oc);
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(imp_liquidacion_Bus) };
            }
        }

        public bool modificarDB(imp_liquidacion_Info info)
        {
            try
            {
                bool res = false;

                if (odata.modificarDB(info))
                {
                    foreach (var item in info.lst_det_oc)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdLiquidacion = info.IdLiquidacion;

                        bus_oc_det.eliminarDB(info.IdEmpresa, item.IdOrdenCompra_ext);
                        bus_oc_det.guardarDB(item.info_oc.lst_det);
                    }
                    bus_det_oc.eliminarDB(info.IdEmpresa, info.IdLiquidacion);
                    res = bus_det_oc.guardarDB(info.lst_det_oc);
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarDB", ex.Message), ex) { EntityType = typeof(imp_liquidacion_Bus) };
            }
        }

        public bool anularDB(imp_liquidacion_Info info)
        {
            try
            {
                if (odata.anularDB(info))
                {
                    bus_det_oc.eliminarDB(info.IdEmpresa, info.IdLiquidacion);
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "anularDB", ex.Message), ex) { EntityType = typeof(imp_liquidacion_Bus) };
            }
        }
    }
}
