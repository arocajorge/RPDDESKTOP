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
  public  class XROLES_Rpt012_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt012_Info> Get_Nomina_consolidada(ro_periodo_x_ro_Nomina_TipoLiqui_Info info_)
      {
          List<XROLES_Rpt012_Info> lista = new List<XROLES_Rpt012_Info>();
          try
          {
         
             /*
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {
                 // db.SetCommandTimeOut(30000);
                  var query = from q in db.spROLES_Rpt012(info_.IdEmpresa, info_.IdNomina_Tipo, info_.pe_anio, info_.pe_mes, info_.IdPeriodo)
                            
                              select q;

                  foreach (var item in query)
                  {
                      XROLES_Rpt012_Info info = new XROLES_Rpt012_Info();
                     
                      info.IdEmpresa = item.IdEmpresa;
                      info.Nombres = item.Nombres;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.em_fechaIngaRol = item.em_fechaIngaRol.ToString().Substring(0, 10);
                      info.em_fechaSalida = item.em_fechaSalida;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Valor = item.Valor;
                      info.Descripcion = item.Descripcion;
                      info.pe_anio = item.pe_anio;
                      info.pe_mes = item.pe_mes;
                      info.pe_FechaIni = item.pe_FechaIni.ToString().Substring(0,10);
                      info.Descripcion = item.Descripcion;
                      info.Catalogo = item.Catalogo;
                      info.zo_descripcion = item.zo_descripcion;
                      info.fu_descripcion = item.fu_descripcion;
                      info.Disco = item.Disco;
                      info.Placa = item.Placa;
                      info.ru_descripcion = item.ru_descripcion;
                      info.Orden = item.Orden;
                      info.ca_descripcion = item.ca_descripcion;
                      if (item.Dias_vacaciones == null)
                          info.Dias_vacaciones = 0;
                      else
                      info.Dias_vacaciones = item.Dias_vacaciones;

                      lista.Add(info);
                  }
              }
          */
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
