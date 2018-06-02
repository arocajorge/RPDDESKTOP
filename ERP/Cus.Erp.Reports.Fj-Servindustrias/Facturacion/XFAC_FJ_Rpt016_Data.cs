using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
  public  class XFAC_FJ_Rpt016_Data
  {
      public List<XFAC_FJ_Rpt016_Info> GetList_procesar(int idEmpresa, int IdPeriodo, DateTime FechaInicio, DateTime FechaFin)
      {
          try
          {
              FechaFin = FechaFin.Date;
              FechaInicio = FechaInicio.Date;
              List<XFAC_FJ_Rpt016_Info> Lista = new List<XFAC_FJ_Rpt016_Info>();
              using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
              {
                  var lst = from q in Context.spFAC_FJ_Rpt016(idEmpresa,IdPeriodo,FechaInicio,FechaFin)                           
                            select q;
                  foreach (var item in lst)
                  {
                      XFAC_FJ_Rpt016_Info info = new XFAC_FJ_Rpt016_Info();
                      info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                      info.IdCentroCosto = item.IdCentroCosto;
                      info.IdPeriodo =Convert.ToInt32( item.IdPeriodo);
                      info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                      info.IdEmpleado = item.IdEmpleado;
                      info.IdCargo = item.IdCargo;
                      info.IdActivoFijo = item.IdActivoFijo;
                      info.pe_apellido =  item.Empleado;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                      info.Salario = Convert.ToDouble(item.Salario);
                      info.ca_descripcion = item.ca_descripcion;
                      info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                      info.HorasExtras = Convert.ToDouble(item.HorasExtras);
                      info.TotalIngresos = Convert.ToDouble(item.TotalIngresos);
                      info.Total_mas_Beneficios = item.Total_mas_Beneficios;
                      info.TotalManoObra = item.TotalManoObra;
                      info.Alimentacion = item.Alimentacion;
                      info.Centro_costo = item.Centro_costo;
                      info.SubcentroCosto = item.SubcentroCosto;
                      info.nom_tarifario = item.nom_tarifario;
                      info.porcentaje = item.porcentaje;
                      info.IdTarifario = item.IdTarifario;
                      Lista.Add(info);
                  }
              }
              return Lista;
          }
          catch (Exception ex)
          {
             
              throw new Exception(ex.ToString());
          }
      }

    }
}
