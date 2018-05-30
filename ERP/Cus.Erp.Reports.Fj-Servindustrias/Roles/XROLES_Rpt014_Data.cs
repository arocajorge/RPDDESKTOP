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
  public  class XROLES_Rpt014_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt014_Info> Get_List(int IdEmpresa, DateTime fechaI, DateTime fechaF)
      {
          List<XROLES_Rpt014_Info> lista = new List<XROLES_Rpt014_Info>();
          try
          {

              fechaI = Convert.ToDateTime(fechaI.ToShortDateString());
              fechaF = Convert.ToDateTime(fechaF.ToShortDateString());
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(30000);
                  var query = from q in db.spROLES_Rpt014(IdEmpresa,fechaI,fechaF)
                            where q.IdEmpresa==IdEmpresa
                          //  && q.es_fecha_registro
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt014_Info info = new XROLES_Rpt014_Info();
                     
                      info.IdEmpresa = item.IdEmpresa;
                      info.Descripcion = item.Descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Asistencia = item.Asistencia;
                      info.es_fecha_registro = item.es_fecha_registro;
                      
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
