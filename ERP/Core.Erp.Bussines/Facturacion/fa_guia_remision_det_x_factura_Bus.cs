using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;

using Core.Erp.Info.class_sri;

using System.Xml.Serialization;

namespace Core.Erp.Business.Facturacion
{
   public class fa_guia_remision_det_x_factura_Bus
   {
       fa_guia_remision_det_x_factura_Data data = new fa_guia_remision_det_x_factura_Data();
       public List<fa_guia_remision_det_x_factura_Info> Get_List_factura_sin_guia(int IdEmpresa, int IdSucursal, int IdBodega, int idcleinte, DateTime FechaIni, DateTime FechaFin)
       {
           try
           {
               return data.Get_List_factura_sin_guia(IdEmpresa, IdSucursal,IdBodega, idcleinte, FechaIni, FechaFin);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabecera", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };


           }
       }


       public bool GuardarDB(List<fa_guia_remision_det_x_factura_Info> lista)
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
       public List<fa_guia_remision_det_x_factura_Info> Get_List_factura_con_guia(int IdEmpresa, int IdSucursal, int IdBodega, int idguia)
       {
           try
           {
               return data.Get_List_factura_con_guia(IdEmpresa, IdSucursal, IdBodega, idguia);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabecera", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };


           }
       }

   }
}
