using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;

namespace Cus.Erp.Reports.FJ.Roles
{
  public  class XROLES_Rpt020_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt020_Info> Get_List(int IdEmpresa, int IdSucursal, int IdTipoMovi, int IdNumMovi)
      {
          List<XROLES_Rpt020_Info> lista = new List<XROLES_Rpt020_Info>();
          try
          {
         
             
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(30000);
                  var query = from q in db.vwROLES_Rpt020
                          where 
                           q.IdEmpresa==IdEmpresa
                           && q.IdSucursal==IdSucursal
                           && q.IdMovi_inven_tipo==IdTipoMovi
                           && q.IdNumMovi==IdNumMovi

                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt020_Info info = new XROLES_Rpt020_Info();
                     
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdSucursal = item.IdSucursal;
                      info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                      info.IdNumMovi = item.IdNumMovi;
                      info.Secuencia = item.Secuencia;
                      info.IdProducto = item.IdProducto;
                      info.pr_codigo = item.pr_codigo;
                      info.pr_descripcion = item.pr_descripcion;
                      info.dm_cantidad = item.dm_cantidad;
                      info.IdEmpleado = item.IdEmpleado;
                      info.pe_nombreCompleto = item.pe_apellido+" "+item.pe_nombre;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.nom_Centro_costo = item.nom_Centro_costo;
                      info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                      info.nom_punto_cargo = item.nom_punto_cargo;
                      info.cm_observacion = item.cm_observacion;
                      info.cm_fecha = item.cm_fecha;
                      info.CodMoviInven = item.CodMoviInven;
                      info.ca_descripcion = item.ca_descripcion;
                      info.de_descripcion = item.de_descripcion;
                      






                      lista.Add(info);
                  }
              }
          
              return lista;
          }
          catch (Exception ex)
          {
              string mensaje = "";
              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }
   
    }
}
