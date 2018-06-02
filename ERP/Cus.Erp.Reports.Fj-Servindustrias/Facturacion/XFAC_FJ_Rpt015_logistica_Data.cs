using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_logistica_Data
    {
        public List<XFAC_FJ_Rpt015_logistica_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                List<XFAC_FJ_Rpt015_logistica_Info> Lista = new List<XFAC_FJ_Rpt015_logistica_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt015_logistica
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              && q.IdLiquidacion == IdLiquidacion
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt015_logistica_Info info = new XFAC_FJ_Rpt015_logistica_Info();
                        info.IdRow = item.IdRow;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.lo_secuencia = item.lo_secuencia;
                        info.lo_cantidad = item.lo_cantidad;
                        info.lo_kilometros = item.lo_kilometros;
                        info.lo_descripcion = item.lo_descripcion;
                        info.lo_precio_uni_kilometro = item.lo_precio_uni_kilometro;
                        info.lo_precio_total = item.lo_precio_total;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
