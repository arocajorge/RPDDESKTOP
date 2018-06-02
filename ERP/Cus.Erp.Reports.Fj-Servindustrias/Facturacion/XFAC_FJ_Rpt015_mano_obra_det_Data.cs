using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_mano_obra_det_Data
    {
        public List<XFAC_FJ_Rpt015_mano_obra_det_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion, int mo_secuencia)
        {
            try
            {
                List<XFAC_FJ_Rpt015_mano_obra_det_Info> Lista = new List<XFAC_FJ_Rpt015_mano_obra_det_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt015_mano_obra_det
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              && q.IdLiquidacion == IdLiquidacion
                              && q.mo_secuencia == mo_secuencia
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt015_mano_obra_det_Info info = new XFAC_FJ_Rpt015_mano_obra_det_Info();
                        info.IdRow = item.IdRow;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.IdActividad = item.IdActividad;
                        info.ac_descripcion = item.ac_descripcion;
                        info.mo_secuencia = item.mo_secuencia;                        
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
