using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.TalentoHumano
{
  public  class XTLH_Rpt001_Data
  {
      public List< XTLH_Rpt001_Info> getList(int IdEmpresa, int IdCalendario)
      {
          try
          {
              int secuencia = 0;

              List< XTLH_Rpt001_Info> listado = new List< XTLH_Rpt001_Info>();

              using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
              {
                  /*

                  var querry = (from q in db.vwTLH_Rpt001
                                where q.IdEmpresa == IdEmpresa
                                && q.IdCalendario == IdCalendario
                                select q);
                  foreach (var item in querry.ToList())
                  {
                      secuencia++;
                       XTLH_Rpt001_Info info = new  XTLH_Rpt001_Info();

                      info.IdEmpresa = item.IdEmpresa;
                      info.IdPregunta = item.IdPregunta;
                      info.Descripcion = item.Descripcion;
                      info.IdCalendario = item.IdCalendario;
                      info.Fecha_evaluacion = item.Fecha_evaluacion;
                      info.TotalRegistro_x_pregunta = item.TotalRegistro_x_pregunta;
                      info.Descripcion_opcion = item.Descripcion_opcion;
                      info.TotalRegistro_x_pregunta_x_opcion = item.TotalRegistro_x_pregunta_x_opcion;

                      double numero = Convert.ToDouble(item.TotalRegistro_x_pregunta);
                      double opciones = Convert.ToDouble(item.TotalRegistro_x_pregunta_x_opcion);
                      info.porcentaje = Convert.ToDouble(opciones / numero);
                      listado.Add(info);
                  }
                  */
              }
              return listado;
          }
          catch (Exception ex)
          {
             
              throw ;
          }

      }

    }
}
