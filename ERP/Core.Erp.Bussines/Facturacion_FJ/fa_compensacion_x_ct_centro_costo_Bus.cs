using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
  public  class fa_compensacion_x_ct_centro_costo_Bus
  {
      fa_compensacion_x_ct_centro_costo_Data data = new fa_compensacion_x_ct_centro_costo_Data();
      fa_compensacion_x_ct_centro_costo_det_Data data_det = new fa_compensacion_x_ct_centro_costo_det_Data();
      public bool Guardar_DB(fa_compensacion_x_ct_centro_costo_Info info)
      {
          try
          {
              int secuencia = 0;
              int IdCompensacion = 0;
              if (data.Guardar_DB(info, ref IdCompensacion))
              {

                  if (data_det.EliminarDB(info))
                  {
                      foreach (var item in info.lista)
                      {
                          secuencia++;
                          item.IdCompensacion = IdCompensacion;
                          item.Secuencia = secuencia;
                          item.IdEmpresa = info.IdEmpresa;

                      }

                      data_det.Guardar_DB(info.lista);
                  }
              }

              return true;
          }
          catch (Exception ex)
          {
              return false;
             
          }
      }


      public bool Modificar_DB(fa_compensacion_x_ct_centro_costo_Info info)
      {
          try
          {
              int secuencia = 0;

              if (data.Modificar_DB(info))
              {
                  if (data_det.EliminarDB(info))
                  {
                      foreach (var item in info.lista)
                      {
                          secuencia++;
                          item.IdCompensacion = info.IdCompensacion;
                          item.Secuencia = secuencia;
                          item.IdEmpresa = info.IdEmpresa;

                      }

                      data_det.Guardar_DB(info.lista);
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              return false;

          }
      }



      public bool Anular_DB(fa_compensacion_x_ct_centro_costo_Info info)
      {
          try
          {
              return data.Anular_DB(info);

          }
          catch (Exception ex)
          {
              return false;

          }
      }




      public List<fa_compensacion_x_ct_centro_costo_Info> GetList(int IdEmpresa)
      {
          try
          {
              return data.GetList(IdEmpresa);

          }
          catch (Exception ex)
          {
              return new List<fa_compensacion_x_ct_centro_costo_Info>();

          }
      }
    }
}
