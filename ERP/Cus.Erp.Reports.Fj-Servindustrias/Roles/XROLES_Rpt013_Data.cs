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
  public  class XROLES_Rpt013_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt013_Info> Get_List(int IdEmpresa, DateTime fechaI, DateTime fechaF, string estado)
      {
          List<XROLES_Rpt013_Info> lista = new List<XROLES_Rpt013_Info>();
          try
          {

              fechaI = fechaI.Date;
              fechaF = fechaF.Date;
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(30000);
                  var query = from q in db.vwROLES_Rpt013
                            where q.IdEmpresa==IdEmpresa
                            && q.FechaSalida>=fechaI
                            && q.FechaSalida<=fechaF
                           && estado.Contains(q.EstadoLiquidacion)
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt013_Info info = new XROLES_Rpt013_Info();
                     
                      info.IdEmpresa = item.IdEmpresa;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Empleado = item.Empleado;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.em_codigo = item.em_codigo;
                      info.Observacion = item.Observacion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Ingresos = item.Ingresos;
                      info.Egresos = item.Egresos;
                      info.UltimaRemuneracion = item.UltimaRemuneracion;
                      info.FechaSalida = item.FechaSalida;
                      info.FechaIngreso = item.FechaIngreso;
                      info.TipoTerminacion = item.TipoTerminacion;
                      info.de_descripcion = item.de_descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.ValorDesaucio = item.ValorDesaucio;
                      info.Neto = info.Ingresos - info.Egresos;
                      info.Antiguedad=item.antiguedad_string;
                      info.EstadoLiquidacion = item.EstadoLiquidacion;
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
