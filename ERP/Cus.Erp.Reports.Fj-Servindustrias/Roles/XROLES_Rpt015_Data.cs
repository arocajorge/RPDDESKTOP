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
  public  class XROLES_Rpt015_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt015_Info> Get_List(int IdEmpresa,decimal idempleado, int idremplazo)
      {
          List<XROLES_Rpt015_Info> lista = new List<XROLES_Rpt015_Info>();
          try
          {
         
             
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(30000);
                  var query =from q in db.vwROLES_Rpt015
                            where q.IdEmpresa==IdEmpresa
                            && q.IdEmpleado==idempleado
                            && q.Id_remplazo==idremplazo
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt015_Info info = new XROLES_Rpt015_Info();
                     
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.Id_remplazo = item.Id_remplazo;
                      info.Cedula_empleado_Remplazado = item.Cedula_empleado_Remplazado;
                      info.empleado_remplazado = item.empleado_remplazado;
                      
                      info.Cedula_remplazo = item.Cedula_remplazo;
                      info.Remplazo = item.Remplazo;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Valor_descuento_empleado = item.Valor_descuento_empleado;
                      info.Fecha_descuenta_rol = item.Fecha_descuenta_rol;

                      info.valor_x_dia_remplazo = item.valor_x_dia_remplazo;
                      info.Total_pagar_remplazo = item.Total_pagar_remplazo;
                      info.Descuenta_rol = item.Descuenta_rol;
                      info.Fecha = item.Fecha;
                      info.Fecha_Entrada = item.Fecha_Entrada;

                       info.Fecha_Salida = item.Fecha_Salida;
                       info.Observacion = item.Observacion;
                      info.MotivoAusencia=item.MotivoAusencia;
                      info.trasnferencia = "Transferencia";
                      info.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                      info.Dias = GetDias(info.Fecha_Salida,info.Fecha_Entrada);






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
