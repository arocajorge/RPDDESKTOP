using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
   public  class XFAC_Rpt014_Data
    {
 
       public List<XFAC_Rpt014_Info> Get_List_Data_Reporte(int IdEmpresa,decimal IdCliente, int Numguia,ref string MensajeError)
       {
           List<XFAC_Rpt014_Info> lista = new List<XFAC_Rpt014_Info>();
           try
           {

               
               using (EntitiesFacturacion_Reportes listado = new EntitiesFacturacion_Reportes())
               {

                 
                   var select = from q in listado.vwFAC_Rpt014
                                where q.IdEmpresa==IdEmpresa
                                && q.IdCliente==IdCliente
                                select q;
                       ;
                    
                   foreach (var item in select)
                   {
                       XFAC_Rpt014_Info infoRpt = new XFAC_Rpt014_Info();

                       infoRpt.IdEmpresa = item.IdEmpresa;
                       infoRpt.IdSucursal = item.IdSucursal;
                       infoRpt.IdBodega = item.IdBodega;
                       infoRpt.IdGuiaRemision = item.IdGuiaRemision;
                       infoRpt.CodGuiaRemision = item.CodGuiaRemision;
                       infoRpt.CodDocumentoTipo = item.CodDocumentoTipo;
                       infoRpt.Serie1 = item.Serie1;
                       infoRpt.Serie2 = item.Serie2;
                       infoRpt.NumGuia_Preimpresa = item.NumGuia_Preimpresa;
                       infoRpt.Fecha_Autorizacion = item.Fecha_Autorizacion;
                       infoRpt.NUAutorizacion = item.NUAutorizacion;
                       infoRpt.gi_fecha = item.gi_fecha;
                       infoRpt.gi_fech_venc = item.gi_fech_venc;
                       infoRpt.gi_Observacion = item.gi_Observacion;
                       infoRpt.gi_FechaInicioTraslado = item.gi_FechaInicioTraslado;
                       infoRpt.gi_FechaFinTraslado = item.gi_FechaFinTraslado;
                       infoRpt.placa = item.placa;
                       infoRpt.ruta = item.ruta;
                       infoRpt.Direccion_Origen = item.Direccion_Origen;
                       infoRpt.pe_apellido = item.pe_apellido;
                       infoRpt.pe_nombre = item.pe_nombre;
                       infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                       infoRpt.vt_serie1 = item.vt_serie1;
                       infoRpt.vt_serie2 = item.vt_serie2;
                       infoRpt.vt_NumFactura = item.vt_NumFactura;
                       infoRpt.Nombre = item.Nombre;
                       infoRpt.Cedula = item.Cedula;
                       infoRpt.gi_cantidad = item.gi_cantidad;
                       infoRpt.pr_descripcion = item.pr_descripcion;
                       infoRpt.gi_detallexItems = item.gi_detallexItems;
                       infoRpt.pr_codigo = item.pr_codigo;
                       lista.Add(infoRpt);
                   }
                  
               }

                

               return lista;
           }
           catch (Exception ex)
           {
               MensajeError = ex.InnerException.ToString();
               return lista;
           }
       
       }
    }
}
