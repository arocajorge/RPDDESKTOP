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
  public  class XROLES_Rpt017_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt017_Info> Get_List(int IdEmpresa,int idnomina,  int IdDivision, DateTime fechaI, DateTime FechaF)
      {
          List<XROLES_Rpt017_Info> lista = new List<XROLES_Rpt017_Info>();
          try
          {
         
             
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(30000);
                  var query = from q in db.spROLES_Rpt017(IdEmpresa, idnomina, IdDivision, fechaI, FechaF)
                           
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt017_Info info = new XROLES_Rpt017_Info();                    
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;

                       info.IdEmpleado = item.IdEmpleado;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.Empleado = item.Empleado;
                      info.Cargo = item.Cargo;
                       info.Asistencia = item.Asistencia;
                      info.Atraso = item.Atraso;
                       info.Falta = item.Falta;
                      info.Permiso = item.Permiso;
                       info.SinLaborar = item.SinLaborar;
                      info.Suspendido = item.Suspendido;
                      info.Vacaciones=item.Vacaciones;
                     


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

      private string GetDias(DateTime fechai, DateTime fechaf)
      {
          string diaas = "";

          try
          {

              while (fechai <= fechaf)
              {
                  diaas += fechai.Day+",";
                  fechai = fechai.AddDays(1);
              }

              return diaas;
          }
          catch (Exception)
          {
              return diaas;
            
          }
      }
   
    }
}
