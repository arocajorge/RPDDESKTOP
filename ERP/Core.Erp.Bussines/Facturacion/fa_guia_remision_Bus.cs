using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;


using Core.Erp.Info.class_sri.GuiaRemision;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri;


namespace Core.Erp.Business.Facturacion
{
    public class fa_guia_remision_Bus
    {

        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_guia_remision_Data oData = new fa_guia_remision_Data();

        fa_guia_remision_det_x_factura_Bus bus_deta_x_factura = new fa_guia_remision_det_x_factura_Bus();

        public List<fa_guia_remision_Info> Get_List_guia_remision(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin
           , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oData.Get_List_guia_remision(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
               
            }
            
        }

        public Boolean ActualizarEstado(int idempresa, fa_guia_remision_Info oGuia)
        {
            try
            {
                return oData.ActualizarEstado(idempresa, oGuia);
            }
            catch (Exception ex )
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstado", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
        }

        public Boolean Validar_Objeto(fa_guia_remision_Info info,ref string msg)
        {
            try
            {
                Boolean res=true;

                if (info.IdEmpresa == 0 || info.IdSucursal == 0 || info.IdBodega == 0 || info.IdCliente == 0)
                {
                    msg = "el IdEmpresa==0 o info.IdSucursal == 0  info.IdBodega == 0 || info.IdCliente == 0) son cero estos son PK no pueden ser cero ";
                    res = false;
                }

                if (info.ListaDetalle.Count == 0)
                {
                    msg = "la guia de remision no tiene items ";
                    res = false;
                }


                return res;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_Objeto", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
        }


        public Boolean GrabarDB(fa_guia_remision_Info info, ref decimal id, ref string numDocFactu, ref string msg)
        {
            try
            {
                Boolean res = true;
                
                if (Validar_Objeto(info,ref msg))
                {
                    //grabacion general de guia de remision
                    res = oData.GrabarDB(info, ref id, ref msg);
                    /////////////////////////////////////
                    if (res)//grabando detalle
                    {
                        fa_guia_remision_det_bus BusDetGuia = new fa_guia_remision_det_bus();
                        res = BusDetGuia.GuardarDB(info.ListaDetalle);
                    }

                    if (res)
                    {
                        bus_deta_x_factura.GuardarDB(Get_det_guia_x_fac(info.ListaDetalle));
                    }
                }
                else
                {
                    res =false;
                }
                

                return res;


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public Boolean VerificarCodigo(string Codigo, int idempresa)
        {
            try
            {
                return oData.VerificarCodigo(Codigo, idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public Boolean ModificarDB(fa_guia_remision_Info info, ref string msg)
        {
            try
            {
              return oData.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public Boolean Imprimir(fa_guia_remision_Info info, ref  string msg)
        {
            try
            {
               return oData.Imprimir(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Imprimir", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }

        }

        public Boolean VerificarNumguia(fa_guia_remision_Info info)
        {
            try
            {
                return oData.VerificarNumguia(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarNumguia", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
            
        }

 
        public List<fa_guia_remision_Info> Get_List_guia_remision(int idEmpresa, int idSucursal, int idBodega, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_List_guia_remision(idEmpresa, idSucursal, idBodega, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParaFactura", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
            
        }

        public fa_guia_remision_Info Get_Info_guia_remision(int idEmpresa, int idSucursal, int idBodega, decimal idGuir)
        {
            try
            {
                return oData.Get_Info_guia_remision(idEmpresa, idSucursal, idBodega, idGuir);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParaFacturaGuir", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
            
        }

        private List<fa_guia_remision_det_x_factura_Info> Get_det_guia_x_fac(List<fa_guia_remision_det_Info> lista)
        {
            try
            {
                int secuencia = 0;
                List<fa_guia_remision_det_x_factura_Info> lista_det_x_fac = new List<fa_guia_remision_det_x_factura_Info>();
                foreach (var item in lista)
                {
                    secuencia++;
                    fa_guia_remision_det_x_factura_Info info = new fa_guia_remision_det_x_factura_Info();
                    info.IdEmpresa_guia = item.IdEmpresa;
                    info.IdSucursal_guia = item.IdSucursal;
                    info.IdBodega_guia = item.IdBodega;
                    info.Secuencia_guia = secuencia;
                    info.IdGuiaRemision_guia = item.IdGuiaRemision;
                    info.IdEmpresa_fact = item.IdEmpresa;
                    info.IdSucursal_fact = item.IdSucursal;
                    info.IdBodega_fact = item.IdBodega;
                    info.IdCbteVta_fact = item.IdComprobante;
                    info.Secuencia_fact = item.secuancia_fac;
                    lista_det_x_fac.Add(info);
                   
                }

                return lista_det_x_fac;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerParaFacturaGuir", ex.Message), ex) { EntityType = typeof(fa_guia_remision_Bus) };
            }
            
        }
    }
}
