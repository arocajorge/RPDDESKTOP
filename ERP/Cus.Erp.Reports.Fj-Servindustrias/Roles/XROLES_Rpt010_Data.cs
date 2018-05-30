using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
namespace Cus.Erp.Reports.FJ.Roles
{
  public  class XROLES_Rpt010_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt010_Info> Get_list_Horas_Extras(int IdEmpresa, int IdNomina_Tipo,int IdNomina_Tipo_Liqui,int IdPeriodo, DateTime Fecha_Inicio, DateTime Fecha_Fin)
      {
          List<XROLES_Rpt010_Info> lista = new List<XROLES_Rpt010_Info>();
          try
          {
         

              int cont = 0;
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(50000);
                  var query = from q in db.spROLES_Rpt010(IdEmpresa, IdNomina_Tipo, IdNomina_Tipo_Liqui, IdPeriodo, Fecha_Inicio, Fecha_Fin)
                            
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt010_Info info = new XROLES_Rpt010_Info();
                      cont++;
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.ca_descripcion = item.ca_descripcion;
                      info.SueldoActual = item.SueldoActual;
                      info.Valor_bono = item.Valor_bono;
                      info.es_fechaRegistro = item.es_fecha_registro.ToString();
                      info.IdNominaTipo = item.IdNominaTipo;
                      info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                      info.sueldo_x_dias_trabajados = item.sueldo_x_dias_trabajados;
                      info.alimentacio = item.alimentacio;
                      info.transporte = item.transporte;
                      info.HorasExtras = item.HorasExtras;
                      info.variable = item.variable;
                      info.Iess = item.Iess;
                      info.dias_trabajados = item.dias_trabajados;
                      info.Empleado = item.Empleado;
                      info.TipoAsistencia = item.TipoAsistencia;
                      info.FechaInicio = item.FechaInicio.ToString().Substring(0, 10);
                      info.FechaFin =Convert.ToString( Convert.ToDateTime(item.FechaInicio).AddDays(Convert.ToInt32( item.dias_trabajados)-1));
                      info.TotalPagar = item.TotalPagar;
                      info.fu_descripcion = item.fu_descripcion;
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
