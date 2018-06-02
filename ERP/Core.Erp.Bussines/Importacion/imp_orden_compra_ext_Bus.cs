using Core.Erp.Data.Importacion;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_orden_compra_ext_Bus
    {
        imp_orden_compra_ext_Data odata = new imp_orden_compra_ext_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        imp_orden_compra_ext_det_Bus bus_det = new imp_orden_compra_ext_det_Bus();

        public List<imp_orden_compra_ext_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return odata.get_list(IdEmpresa, Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_Bus) };
            }
        }

        public List<imp_orden_compra_ext_Info> get_list(int IdEmpresa)
        {
            try
            {
                return odata.get_list(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_Bus) };
            }
        }

        public bool guardarDB(imp_orden_compra_ext_Info info)
        {
            try
            {
                info.IdUsuario_creacion = param.IdUsuario;
                info.fecha_creacion = param.Fecha_Transac;
                if (odata.guardarDB(info))
                {
                    foreach (var item in info.lst_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdOrdenCompra_ext = info.IdOrdenCompra_ext;
                    }
                    bus_det.guardarDB(info.lst_det);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "guardarDB", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_Bus) };
            }
        }

        public bool anularDB(imp_orden_compra_ext_Info info)
        {
            try
            {
                info.IdUsuario_anulacion = param.IdUsuario;
                info.fecha_anulacion = param.Fecha_Transac;
                return odata.anularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "anularDB", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_Bus) };
            }
        }

        public bool modificarDB(imp_orden_compra_ext_Info info)
        {
            try
            {
                info.IdUsuario_modificacion = param.IdUsuario;
                info.fecha_modificacion = param.Fecha_Transac;
                if (odata.modificarDB(info))
                {
                    foreach (var item in info.lst_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdOrdenCompra_ext = info.IdOrdenCompra_ext;
                    }
                    bus_det.eliminarDB(info.IdEmpresa, info.IdOrdenCompra_ext);
                    bus_det.guardarDB(info.lst_det);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "modificarDB", ex.Message), ex) { EntityType = typeof(imp_orden_compra_ext_Bus) };
            }
        }
    }
}
