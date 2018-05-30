using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

using Core.Erp.Data.General;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Facturacion
{
   public class fa_guia_remision_det_x_factura_Data
   {
       string mensaje = "";
       public List<fa_guia_remision_det_x_factura_Info> Get_List_factura_sin_guia(int IdEmpresa, int IdSucursal, int IdBodega, int idcleinte, DateTime FechaIni, DateTime FechaFin)
       {
           try
           {
               List<fa_guia_remision_det_x_factura_Info> FacturaInfo = new List<fa_guia_remision_det_x_factura_Info>();
               EntitiesFacturacion OEFAC = new EntitiesFacturacion();

               int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
               int IdSucursalFin = (IdSucursal == 0) ? 99999 : IdSucursal;
               int IdBodegaIni = (IdBodega == 0) ? 1 : IdBodega;
               int IdBodegaFin = (IdBodega == 0) ? 99999 : IdBodega;
               FechaIni = FechaIni.Date;
               FechaFin = FechaFin.Date;

               var SelectFactura = from q in OEFAC.vwfa_factura_sin_guia
                                   where q.IdEmpresa == IdEmpresa
                                   && q.IdCliente == idcleinte
                                   && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                   && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                   && q.vt_fecha >= FechaIni && q.vt_fecha <= FechaFin
                                   select q;


               foreach (var item in SelectFactura)
               {
                   fa_guia_remision_det_x_factura_Info info = new fa_guia_remision_det_x_factura_Info();

                   List<fa_factura_det_info> ListDet = new List<fa_factura_det_info>();

                   info.IdCbteVta = item.IdCbteVta;
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdSucursal = item.IdSucursal;
                   info.IdBodega = item.IdBodega;
                   info.vt_serie1 = item.vt_serie1;
                   info.vt_serie2 = item.vt_serie2;
                   info.vt_NumFactura = item.vt_NumFactura;
                   info.IdCliente = item.IdCliente;
                   info.vt_fecha = item.vt_fecha;
                   info.vt_Observacion = item.vt_Observacion;
                   FacturaInfo.Add(info);

               }

               return FacturaInfo;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
       public Boolean GuardarDB(List<fa_guia_remision_det_x_factura_Info> listDetalle_Guia_Info)
       {
           try
           {
               int c = 0;


               foreach (var item in listDetalle_Guia_Info)
               {

                   using (EntitiesFacturacion Context = new EntitiesFacturacion())
                   {
                       var Address = new fa_guia_remision_det_x_factura();
                       c++;
                       Address.IdEmpresa_guia = item.IdEmpresa_guia;
                       Address.IdSucursal_guia = item.IdSucursal_guia;
                       Address.IdBodega_guia = item.IdBodega_guia;
                       Address.IdGuiaRemision_guia = item.IdGuiaRemision_guia;
                       Address.Secuencia_guia = c;

                       Address.IdEmpresa_fact = item.IdEmpresa_fact;
                       Address.IdSucursal_fact = item.IdSucursal_fact;
                       Address.IdBodega_fact = item.IdBodega_fact;
                       Address.IdCbteVta_fact = item.IdCbteVta_fact;
                       Address.Secuencia_fact = item.Secuencia_fact;
                       Context.fa_guia_remision_det_x_factura.Add(Address);
                       Context.SaveChanges();
                       Context.Dispose();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }
       public List<fa_guia_remision_det_x_factura_Info> Get_List_factura_con_guia(int IdEmpresa, int IdSucursal, int IdBodega, int idguia)
       {
           try
           {
               List<fa_guia_remision_det_x_factura_Info> FacturaInfo = new List<fa_guia_remision_det_x_factura_Info>();
               EntitiesFacturacion OEFAC = new EntitiesFacturacion();
               var SelectFactura = from q in OEFAC.vwfa_factura_con_guia
                                   where q.IdEmpresa == IdEmpresa
                                   && q.IdGuiaRemision_guia == idguia
                                   && q.IdBodega == IdBodega
                                   && q.IdSucursal ==IdSucursal
                                   select q;


               foreach (var item in SelectFactura)
               {
                   fa_guia_remision_det_x_factura_Info info = new fa_guia_remision_det_x_factura_Info();

                   List<fa_factura_det_info> ListDet = new List<fa_factura_det_info>();

                   info.IdCbteVta = item.IdCbteVta;
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdSucursal = item.IdSucursal;
                   info.IdBodega = item.IdBodega;
                   info.vt_serie1 = item.vt_serie1;
                   info.vt_serie2 = item.vt_serie2;
                   info.vt_NumFactura = item.vt_NumFactura;
                   info.IdCliente = item.IdCliente;
                   info.vt_fecha = item.vt_fecha;
                   info.vt_Observacion = item.vt_Observacion;
                   info.check = true;
                   FacturaInfo.Add(info);

               }

               return FacturaInfo;
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
   
    }
}
