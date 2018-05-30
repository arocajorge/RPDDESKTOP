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
  public  class XROLES_Rpt018_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt018_Info> Get_List(int IdEmpresa, DateTime fechaI, DateTime fechaF)
      {
          List<XROLES_Rpt018_Info> lista = new List<XROLES_Rpt018_Info>();
          try
          {
         
             
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(30000);
                  var query = from q in db.spROLES_Rpt018(IdEmpresa,fechaI,fechaF)
                          //  && q.es_fecha_registro
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt018_Info info = new XROLES_Rpt018_Info();
                     
                      info.EmpleadosActivos = item.EmpleadosActivos;
                      info.EmpleadosNuevos = item.EmpleadosNuevos;
                      info.EmpleadosPasivos = item.EmpleadosPasivos;
                      info.Faltas = item.Falta;
                     if(item.EmpleadosNuevos>0)
                      info.Nuevos_menosPasivos =Convert.ToInt32( item.EmpleadosNuevos - item.EmpleadosPasivos);
                      if (info.Nuevos_menosPasivos == 0)
                          info.TotalRoracion = 0;
                      else

                      info.TotalRoracion = Convert.ToDouble(item.EmpleadosActivos / info.Nuevos_menosPasivos)*100;
                      info.TotalAusentismo = Convert.ToDouble(item.Falta / (item.EmpleadosActivos * 26))*100;

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
