using Core.Erp.Data.Alerta;
using Core.Erp.Info.Alerta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Alerta
{
    public class tb_sis_alerta_x_usuario_x_empresa_Bus
    {
        tb_sis_alerta_x_usuario_x_empresa_Data oData = new tb_sis_alerta_x_usuario_x_empresa_Data();
        tb_sis_alerta_x_usuario_x_empresa_x_eventos_Bus bus_eventos = new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Bus();

        public List<tb_sis_alerta_x_usuario_x_empresa_Info> get_list(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdUsuario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(tb_sis_alerta_x_usuario_x_empresa_Bus) };
            }
        }

        public bool eliminarDB(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return oData.eliminarDB(IdEmpresa, IdUsuario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(tb_sis_alerta_x_usuario_x_empresa_Bus) };
            }
        }

        public bool guardarDB(tb_sis_alerta_x_usuario_x_empresa_Info info)
        {
            try
            {
                return oData.guardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(tb_sis_alerta_x_usuario_x_empresa_Bus) };
            }
        }

        public bool guardarDB(List<tb_sis_alerta_x_usuario_x_empresa_Info> Lista, int IdEmpresa, string IdUsuario)
        {
            try
            {
                bus_eventos.eliminarDB(IdEmpresa, IdUsuario);
                eliminarDB(IdEmpresa, IdUsuario);
                foreach (var item in Lista)
                {
                    oData.guardarDB(item);
                    bus_eventos.guardarDB(item.lst_eventos);
                }
                
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(tb_sis_alerta_x_usuario_x_empresa_Bus) };
            }
        }
    }
}
