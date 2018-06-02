using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_proforma_Bus
    {
        fa_proforma_Data odata = new fa_proforma_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_proforma_det_Bus bus_det = new fa_proforma_det_Bus();

        public List<fa_proforma_Info> get_list(int IdEmpresa, int IdSucursal, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdSucursal, Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(fa_proforma_Bus) };
            }
        }

        public bool guardarDB(fa_proforma_Info info)
        {
            try
            {
                info.IdUsuario_creacion = param.IdUsuario;
                info.fecha_creacion = DateTime.Now;
                if (odata.guardarDB(info))
                {
                    foreach (var item in info.lst_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdProforma = info.IdProforma;
                    }
                    return bus_det.guardarDB(info.lst_det);
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(fa_proforma_Bus) };
            }
        }

        public bool modificarDB(fa_proforma_Info info)
        {
            try
            {
                info.IdUsuario_modificacion = param.IdUsuario;
                info.fecha_modificacion = DateTime.Now;
                if (odata.modificarDB(info))
                {
                    foreach (var item in info.lst_det)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdProforma = info.IdProforma;
                    }
                    bus_det.eliminarDB(info.IdEmpresa, info.IdSucursal, info.IdProforma);
                    return bus_det.guardarDB(info.lst_det);
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(fa_proforma_Bus) };
            }
        }

        public bool anularDB(fa_proforma_Info info)
        {
            try
            {
                info.IdUsuario_anulacion = param.IdUsuario;
                info.fecha_anulacion = DateTime.Now;
                return odata.anularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(fa_proforma_Bus) };
            }
        }

    }
}
