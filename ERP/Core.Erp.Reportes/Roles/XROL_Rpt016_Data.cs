using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt016_Data
  {
      string mensaje = "";
      tb_Empresa_Data empresa_data = new tb_Empresa_Data();
      tb_Empresa_Info info_empresa = new tb_Empresa_Info();
      public List<XROL_Rpt016_Info> Get_Valor_Acumulado_x_empleado(int idEmpresa, int idNomina,string Rubro, DateTime fi, DateTime ff)
      {
          try
          {
              List<XROL_Rpt016_Info> Listado = new List<XROL_Rpt016_Info>();
              info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
              int idempleado = 0;
              int sec = 0;
              using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
              {
                  var select = from a in enti.spROL_Rpt016(idEmpresa, idNomina, fi, ff)
                               where
                                a.IdRubro==Rubro
                               orderby a.pe_apellido ascending
                               select a;

                  foreach (var item in select)
                  {
                      XROL_Rpt016_Info info = new XROL_Rpt016_Info();
                      if (idempleado != item.IdEmpleado)
                      {
                          sec = sec + 1;
                      }
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNominaTipo = item.IdNominaTipo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                      info.IdPeriodo=item.IdPeriodo;
                      info.IdRubro = item.IdRubro;
                      info.IdDepartamento = item.IdDepartamento;
                      info.pe_anio = item.pe_anio;
                      info.pe_FechaIni = item.pe_FechaIni;
                      info.pe_FechaFin = item.pe_FechaFin;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.pe_apellido = item.pe_apellido + " " + item.pe_nombre;
                      info.ru_descripcion = item.ru_descripcion;
                      info.Valor = item.Valor;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Descripcion = item.Descripcion;
                      info.de_descripcion = item.de_descripcion;
                      info.pe_anio = item.pe_anio;
                      info.pe_mes = item.pe_mes;

                      info.ca_descripcion = item.ca_descripcion;
                      info.em_fechaIngaRol = item.em_fechaIngaRol;
                      info.em_fechaSalida = item.em_fechaSalida;
                      info.Centro_costo = item.pe_cedulaRuc;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;

                      info.ru_descripcion=item.ru_descripcion;
                      idempleado =Convert.ToInt32( item.IdEmpleado);

                      Listado.Add(info);   
                  }

                  return Listado;
              }



          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              return new List<XROL_Rpt016_Info>();
          }
      }

      public List<XROL_Rpt016_Info> Get_Valor_Acumulado_x_empleado(int idEmpresa, int idNomina, decimal IdEmpleado, string Rubro, DateTime fi, DateTime ff)
      {
          try
          {
              List<XROL_Rpt016_Info> Listado = new List<XROL_Rpt016_Info>();
              info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
              int idempleado = 0;
              int sec = 0;
              using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
              {
                  var select = from a in enti.spROL_Rpt016(idEmpresa, idNomina, fi, ff)
                               where
                                a.IdRubro==Rubro
                                && a.IdEmpleado == IdEmpleado
                               orderby a.pe_apellido ascending
                               select a;

                  foreach (var item in select)
                  {
                      XROL_Rpt016_Info info = new XROL_Rpt016_Info();
                      if (idempleado != item.IdEmpleado)
                      {
                          sec = sec + 1;
                      }
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNominaTipo = item.IdNominaTipo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                      info.IdPeriodo = item.IdPeriodo;
                      info.IdRubro = item.IdRubro;
                      info.IdDepartamento = item.IdDepartamento;
                      info.pe_anio = item.pe_anio;
                      info.pe_FechaIni = item.pe_FechaIni;
                      info.pe_FechaFin = item.pe_FechaFin;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.pe_apellido = item.pe_apellido + " " + item.pe_nombre;
                      info.ru_descripcion = item.ru_descripcion;
                      info.Valor = item.Valor;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Descripcion = item.Descripcion;
                      info.de_descripcion = item.de_descripcion;
                      info.pe_anio = item.pe_anio;
                      info.pe_mes = item.pe_mes;


                      info.ca_descripcion = item.ca_descripcion;
                      info.em_fechaIngaRol = item.em_fechaIngaRol;
                      info.em_fechaSalida = item.em_fechaSalida;
                      info.Centro_costo = item.pe_cedulaRuc;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;

                      

                      info.ru_descripcion = item.ru_descripcion;
                      idempleado = Convert.ToInt32(item.IdEmpleado);

                      Listado.Add(info);
                  }

                  return Listado;
              }



          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              return new List<XROL_Rpt016_Info>();
          }
      }




  }
}
