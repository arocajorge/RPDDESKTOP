using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
namespace Core.Erp.Business.Roles_Graf
{
    public class ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Bus
    {
        
        ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Data data = new ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Data();
        public bool Guardar_DB(ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info info)
        {
            try
            {

                return data.Guardar_DB(info);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Sucursal", ex.Message), ex) { EntityType = typeof(ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Bus) };

            }
        }

        public bool Eliminar(ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info info)
        {
            string mensaje = "";
            try
            {

                return data.Eliminar(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Sucursal", ex.Message), ex) { EntityType = typeof(ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Bus) };

    

            }
        }

        public List<ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info> Get_Lis(int IdEmpresa, int idempleado, int idsolicitud)
        {
            try
            {
                return data.Get_Lis(IdEmpresa, idempleado, idsolicitud);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Sucursal", ex.Message), ex) { EntityType = typeof(ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Bus) };

    
            }

        }

    }

}