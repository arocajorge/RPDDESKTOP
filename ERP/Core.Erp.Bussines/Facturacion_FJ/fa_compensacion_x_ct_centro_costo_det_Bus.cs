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
  public  class fa_compensacion_x_ct_centro_costo_det_det_Bus
  {
      fa_compensacion_x_ct_centro_costo_det_Data data = new fa_compensacion_x_ct_centro_costo_det_Data();
      public bool Guardar_DB(List<fa_compensacion_x_ct_centro_costo_det_Info> lista)
      {
          try
          {
              return data.Guardar_DB(lista);

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
              return data.EliminarDB(info);

          }
          catch (Exception ex)
          {
              return false;

          }
      }




      public List<fa_compensacion_x_ct_centro_costo_det_Info> GetList(int IdEmpresa, int IdCompensacion)
      {
          try
          {
              return data.GetList(IdEmpresa, IdCompensacion);

          }
          catch (Exception ex)
          {
              return new List<fa_compensacion_x_ct_centro_costo_det_Info>();

          }
      }
    }
}
