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
  public  class XROLES_Rpt019_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt019_Info> Get_List(int IdEmpresa, int IdNomina,int idnominatipo,int idperiodo, DateTime fechaI, DateTime fechaF)
      {
          List<XROLES_Rpt019_Info> lista = new List<XROLES_Rpt019_Info>();
          try
          {
              fechaF = Convert.ToDateTime(fechaF.ToShortDateString());
             
              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {

                 // db.SetCommandTimeOut(30000);
                  var query =( from q in db.vwROLES_Rpt019
                           where
                               q.FechaPago>=fechaI
                               && q.FechaPago<=fechaF
                               && q.IdEmpresa==IdEmpresa
                               && q.IdNomina_Tipo==IdNomina
                               && q.IdNomina_Tipo_Liq==idnominatipo
                               && q.IdPeriodo==idperiodo
                              select q);

                  foreach (var item in query)
                  {
                      XROLES_Rpt019_Info info = new XROLES_Rpt019_Info();
                     
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdNomina_Tipo = item.IdNomina_Tipo;
                      info.IdNomina_Tipo_Liq = item.IdNomina_Tipo_Liq;
                      info.IdPeriodo = item.IdPeriodo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Nombres = item.Nombres;
                      info.ca_descripcion = item.ca_descripcion;
                      info.Valor = item.Valor;
                      info.Valor_bono = item.Valor_bono;
                      

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
