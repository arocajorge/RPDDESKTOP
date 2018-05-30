using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_ingresos_egresos_Data
    {
        public List<XFAC_FJ_Rpt015_ingresos_egresos_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion, string Tipo)
        {
            try
            {
                List<XFAC_FJ_Rpt015_ingresos_egresos_Info> Lista = new List<XFAC_FJ_Rpt015_ingresos_egresos_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt015_ingresos_egresos
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              && q.IdLiquidacion == IdLiquidacion
                              && q.Tipo == Tipo
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt015_ingresos_egresos_Info info = new XFAC_FJ_Rpt015_ingresos_egresos_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.eg_secuencia = item.eg_secuencia;
                        info.eg_cantidad = item.eg_cantidad;
                        info.eg_precio_uni = item.eg_precio_uni;
                        info.eg_precio_total = item.eg_precio_total;
                        info.pr_descripcion = item.pr_descripcion;
                        info.nom_uni_medida = item.nom_uni_medida;
                        info.Tipo = item.Tipo;
                        info.pr_codigo = item.pr_codigo;
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
