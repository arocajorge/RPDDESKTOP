using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_mano_obra_Data
    {
        public List<XFAC_FJ_Rpt015_mano_obra_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                XFAC_FJ_Rpt015_mano_obra_det_Data odata_det = new XFAC_FJ_Rpt015_mano_obra_det_Data();
                List<XFAC_FJ_Rpt015_mano_obra_Info> Lista = new List<XFAC_FJ_Rpt015_mano_obra_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt015_mano_obra
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              && q.IdLiquidacion == IdLiquidacion
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt015_mano_obra_Info info = new XFAC_FJ_Rpt015_mano_obra_Info();
                        info.IdRow = item.IdRow;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.mo_secuencia = item.mo_secuencia;
                        info.IdTecnico = item.IdTecnico;
                        info.mo_horas = item.mo_horas;
                        info.mo_descripcion = item.mo_descripcion;
                        info.mo_precio_uni = item.mo_precio_uni;
                        info.mo_precio_total = item.mo_precio_total;
                        info.ac_codigo = item.ac_codigo;
                        info.ac_descripcion = item.ac_descripcion;
                        info.te_codigo = item.te_codigo;
                        info.IdProducto = item.IdProducto;
                        info.IdActividad = item.IdActividad;
                        info.ti_codigo = item.ti_codigo;

                        info.lst_mano_obra_det = new List<XFAC_FJ_Rpt015_mano_obra_det_Info>(odata_det.get_list(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion, info.mo_secuencia));
                        foreach (var item_2 in info.lst_mano_obra_det)
                        {
                            XFAC_FJ_Rpt015_mano_obra_Info info_2 = new XFAC_FJ_Rpt015_mano_obra_Info();
                            info_2.IdRow = item_2.IdRow;
                            info_2.IdEmpresa = item_2.IdEmpresa;
                            info_2.IdSucursal = item_2.IdSucursal;
                            info_2.IdCentroCosto = item_2.IdCentroCosto;
                            info_2.IdLiquidacion = item_2.IdLiquidacion;
                            info_2.mo_secuencia = item_2.mo_secuencia;
                            info_2.ac_descripcion = item_2.ac_descripcion;
                            info_2.IdActividad = item_2.IdActividad;
                            Lista.Add(info_2);
                        }
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
