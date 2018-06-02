using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;

namespace Core.Erp.Business.Facturacion
{
   public class fa_cliente_contactos_Bus

    {
       fa_cliente_contactos_Data data = new fa_cliente_contactos_Data();
       public List<fa_cliente_contactos_Info> get_list(int IdEmpresa, decimal IdCliete)
        {
            try
            {
                return data.get_list(IdEmpresa, IdCliete);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabecera", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };


            }
        }


        public bool GuardarDB(List<fa_cliente_contactos_Info> lista)
        {
            try
            {  
                return data.GuardarDB(lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabecera", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };


            }
        }


       
   
    }
}
