using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.FJ.Bancos
{
  public  class XBAN_FJ_Rpt001_Data
  {  
      public List<XBAN_FJ_Rpt001_Info> Get_List_Conciliacion(int idEmpresa, int IdBanco, decimal IdPersona, DateTime Fecha_I, DateTime Fecha_F,  string Estado)
      {
          try
          {
              List<XBAN_FJ_Rpt001_Info> Lista = new List<XBAN_FJ_Rpt001_Info>();
              Fecha_I = Fecha_I.Date;
              Fecha_F = Fecha_F.Date;

              int IdBanco_ini = IdBanco;
              int IdBanco_fin = IdBanco == 0 ? 9999 : IdBanco;

              decimal IdPersona_ini = IdPersona;
              decimal IdPersona_fin = IdPersona == 0 ? 99999 : IdPersona;

   
              using (Entities_banco_fj_rpt Context = new Entities_banco_fj_rpt())
              {
                  var lst = from q in Context.vwBAN_FJ_Rpt001
                            where q.IdEmpresa == idEmpresa
                            && IdBanco_ini <= q.IdBanco && q.IdBanco <= IdBanco_fin
                            && IdPersona_ini <= q.IdPersona_Girado_a && q.IdPersona_Girado_a <= IdPersona_fin
                             && q.cb_Fecha >= Fecha_I
                             && q.cb_Fecha <= Fecha_F
                             && q.IdCatalogo.Contains(Estado)
                            select q;

                  foreach (var item in lst)
                  {
                      XBAN_FJ_Rpt001_Info Info = new XBAN_FJ_Rpt001_Info();
                      Info.IdEmpresa = item.IdEmpresa;
                      Info.IdCbteCble = item.IdCbteCble;
                      Info.IdTipocbte = item.IdTipocbte;
                      Info.cb_FechaCheque = item.cb_FechaCheque;
                      Info.cb_Cheque = item.cb_Cheque;
                      Info.pe_nombreCompleto = item.pe_nombreCompleto;
                      Info.cb_Valor = item.cb_Valor;
                      Info.ca_descripcion = item.ca_descripcion;
                      Info.cb_Fecha = item.cb_Fecha;
                      Info.Nombre = item.Nombre;
                      Info.pe_nombreCompleto = item.pe_nombreCompleto.Trim();
                      Info.cb_Observacion = item.cb_Observacion;
                      Info.ba_descripcion = item.ba_descripcion;
                      Info.IdBanco = item.IdBanco;
                      Info.IdPersona_Girado_a = item.IdPersona_Girado_a;
                      Lista.Add(Info);

                  }
              }
              return Lista;
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
