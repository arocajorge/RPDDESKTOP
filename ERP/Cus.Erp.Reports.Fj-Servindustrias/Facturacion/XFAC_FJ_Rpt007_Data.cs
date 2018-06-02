using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt007_Data
    {
        public List<XFAC_FJ_Rpt007_Info> get_list(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                List<XFAC_FJ_Rpt007_Info> Lista;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    Lista = (from q in Context.vwFAC_FJ_Rpt007
                             where q.IdEmpresa == IdEmpresa
                             && q.IdPeriodo == IdPeriodo
                             select new XFAC_FJ_Rpt007_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdPeriodo =q.IdPeriodo ,
                                 IdActivoFijo = q.IdActivoFijo,
                                 Valor_Maximo_x_periodo =q.Valor_Maximo_x_periodo ,
                                 Af_ValorUnidad_Actu =q.Af_ValorUnidad_Actu ,
                                 Af_DescripcionCorta = q.Af_DescripcionCorta,
                                Centro_costo =q. Centro_costo,
                                SucentroCosto =q.SucentroCosto ,
                                Total_horas_operadores =q.Total_horas_operadores ,
                                Total_Horas_maquina =q.Total_Horas_maquina ,
                                diferencia =q.diferencia ,
                                por_horas_ocupada_la_maquina_vx_ho =q. por_horas_ocupada_la_maquina_vx_ho
                                                     }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<XFAC_FJ_Rpt007_Info> get_list(int IdEmpresa, int IdPeriodo, decimal IdCliente)
        {
            try
            {
                List<XFAC_FJ_Rpt007_Info> Lista;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    Lista = (from q in Context.vwFAC_FJ_Rpt007
                             where q.IdEmpresa == IdEmpresa
                             && q.IdPeriodo == IdPeriodo
                             && q.IdCliente_cli==IdCliente
                             select new XFAC_FJ_Rpt007_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdPeriodo = q.IdPeriodo,
                                 IdActivoFijo = q.IdActivoFijo,
                                 Valor_Maximo_x_periodo = q.Valor_Maximo_x_periodo,
                                 Af_ValorUnidad_Actu = q.Af_ValorUnidad_Actu,
                                 Af_DescripcionCorta = q.Af_DescripcionCorta,
                                 Centro_costo = q.Centro_costo,
                                 SucentroCosto = q.SucentroCosto,
                                 Total_horas_operadores = q.Total_horas_operadores,
                                 Total_Horas_maquina = q.Total_Horas_maquina,
                                 diferencia = q.diferencia,
                                 por_horas_ocupada_la_maquina_vx_ho = q.por_horas_ocupada_la_maquina_vx_ho
                             }).ToList();
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
