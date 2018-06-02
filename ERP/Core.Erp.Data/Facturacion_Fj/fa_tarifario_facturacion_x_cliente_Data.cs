using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Facturacion_Fj
{
  public  class fa_tarifario_facturacion_x_cliente_Data
    {
      string MensajeError = "";

      public bool Guardar(fa_tarifario_facturacion_x_cliente_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
              {
                  fa_tarifario_facturacion_x_cliente add = new fa_tarifario_facturacion_x_cliente();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdTarifario = info.IdTarifario = GetId(info.IdEmpresa);
                  add.codTarifario = info.codTarifario;
                  add.nom_tarifario = info.nom_tarifario;
                  add.observacion = info.observacion;
                  add.fecha_inicio = info.fecha_inicio.Date;
                  add.fecha_fin = info.fecha_fin.Date;
                  add.IdUsuario = info.IdUsuario;
                  add.Estado = info.Estado;
                  add.nom_pc = info.nom_pc;
                  add.ip = info.ip;
                  add.IdUsuarioUltMod = info.IdUsuarioUltMod;
                  add.FechaUltMod = info.FechaUltMod;
                  add.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                  add.Fecha_UltAnu = info.Fecha_UltAnu;
                  add.MotiAnula = info.MotiAnula;
                  add.IdCentroCosto = info.IdCentroCosto;
                  add.por_ganancia_inicial = info.por_ganancia_inicial;
                  add.valor_minimo_movilizacion = info.valor_minimo_movilizacion;
                  add.Estado = info.Estado = true;
                  model.fa_tarifario_facturacion_x_cliente.Add(add);
                  model.SaveChanges();
                  return true;
              }

          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public bool Modificar(fa_tarifario_facturacion_x_cliente_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
              {
                  var add = model.fa_tarifario_facturacion_x_cliente.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdTarifario == info.IdTarifario);
                  if (add!=null)
                  {
                      add.codTarifario = info.codTarifario;
                      add.nom_tarifario = info.nom_tarifario;
                      add.observacion = info.observacion;
                      add.fecha_inicio = info.fecha_inicio.Date;
                      add.fecha_fin = info.fecha_fin.Date;
                      add.IdUsuarioUltMod = info.IdUsuarioUltMod;
                      add.FechaUltMod = info.FechaUltMod;
                      add.valor_minimo_movilizacion = info.valor_minimo_movilizacion;
                      add.por_ganancia_inicial = info.por_ganancia_inicial;
                      model.SaveChanges();    
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public bool Anular(fa_tarifario_facturacion_x_cliente_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
              {
                  var add = model.fa_tarifario_facturacion_x_cliente.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdTarifario == info.IdTarifario);

                  add.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                  add.Fecha_UltAnu = info.Fecha_UltAnu;
                  add.MotiAnula = info.MotiAnula;
                  add.Estado = false;
                  model.SaveChanges();
                  return true;
              }
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public List<fa_tarifario_facturacion_x_cliente_Info> Get_List_Tarifarios(int idempresa)
      {
          try
          {
              List<fa_tarifario_facturacion_x_cliente_Info> lista = new List<fa_tarifario_facturacion_x_cliente_Info>();
              using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
              {
                  var query = from q in model.vwfa_tarifario_facturacion_x_cliente
                              where q.IdEmpresa == idempresa
                              select q;

                  foreach (var item in query)
                  {
                      fa_tarifario_facturacion_x_cliente_Info info = new fa_tarifario_facturacion_x_cliente_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTarifario = item.IdTarifario;
                      info.codTarifario = item.codTarifario;
                      info.nom_tarifario = item.nom_tarifario;
                      info.observacion = item.observacion;
                      info.fecha_inicio = item.fecha_inicio;
                      info.fecha_fin = item.fecha_fin;
                      info.IdUsuario = item.IdUsuario;
                      info.Estado = item.Estado;
                      info.nom_pc = item.nom_pc;
                      info.ip = item.ip;
                      info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                      info.FechaUltMod = item.FechaUltMod;
                      info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                      info.Fecha_UltAnu = item.Fecha_UltAnu;
                      info.MotiAnula = item.MotiAnula;
                      info.IdCentroCosto = item.IdCentroCosto;
                      info.valor_minimo_movilizacion = item.valor_minimo_movilizacion;
                      info.Estado = info.Estado;
                      info.Centro_costo = item.Centro_costo;
                      info.por_ganancia_inicial = item.por_ganancia_inicial;
                      lista.Add(info);
                  }
                  return lista;

              }

          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public fa_tarifario_facturacion_x_cliente_Info Get_Info(int idEmpresa, decimal idTarifario)
      {
          try
          {
              fa_tarifario_facturacion_x_cliente_Info info = new fa_tarifario_facturacion_x_cliente_Info();

              using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
              {
                  var lst = from q in Context.fa_tarifario_facturacion_x_cliente
                            where idEmpresa == q.IdEmpresa && q.IdTarifario==idTarifario
                            select q;

                  foreach (var item in lst)
                  {
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTarifario = item.IdTarifario;
                      info.codTarifario = item.codTarifario;
                      info.nom_tarifario = item.nom_tarifario;
                      info.observacion = item.observacion;
                      info.fecha_inicio = item.fecha_inicio;
                      info.fecha_fin = item.fecha_fin;
                      info.IdUsuario = item.IdUsuario;
                      info.Estado = item.Estado;
                      info.nom_pc = item.nom_pc;
                      info.ip = item.ip;
                      info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                      info.FechaUltMod = item.FechaUltMod;
                      info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                      info.Fecha_UltAnu = item.Fecha_UltAnu;
                      info.MotiAnula = item.MotiAnula;
                      info.IdCentroCosto = item.IdCentroCosto;
                      info.valor_minimo_movilizacion = item.valor_minimo_movilizacion;
                      info.Estado = info.Estado;
                      info.por_ganancia_inicial = item.por_ganancia_inicial;
                  }
              }

              return info;
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public int GetId(int idEmpresa)
      {
          try
          {
              int Id;
              Entity_Facturacion_FJ db = new Entity_Facturacion_FJ();

              var selecte = db.fa_tarifario_facturacion_x_cliente.Count(q => q.IdEmpresa == idEmpresa);

              if (selecte == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_em = (from q in db.fa_tarifario_facturacion_x_cliente
                                   where q.IdEmpresa == idEmpresa
                                   select q.IdTarifario).Max();
                  Id = Convert.ToInt32(select_em.ToString()) + 1;
              }

              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }


      }
    }
}
