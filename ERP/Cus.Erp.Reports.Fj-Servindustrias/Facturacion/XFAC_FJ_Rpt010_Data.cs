using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt010_Data
    {
        public List<XFAC_FJ_Rpt010_Info> get_list(int IdEmpresa, string IdCentroCosto, string IdCentroCosto_sub_centro_costo, int IdPeriodo_ini, int IdPeriodo_fin, int IdPunto_cargo)
        {
            try
            {
                List<XFAC_FJ_Rpt010_Info> Lista;
                int IdPunto_cargo_ini = IdPunto_cargo;
                int IdPunto_cargo_fin = IdPunto_cargo == 0 ? 9999 : IdPunto_cargo;
                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    if (IdCentroCosto == "")
                        Lista = (from q in Context.vwFAC_FJ_Rpt010
                                 where q.IdEmpresa == IdEmpresa
                                 && IdPeriodo_ini <= q.IdPeriodo && q.IdPeriodo <= IdPeriodo_fin
                                 && IdPunto_cargo_ini <= q.IdPunto_cargo && q.IdPunto_cargo <= IdPunto_cargo_fin
                                 select new XFAC_FJ_Rpt010_Info
                                 {
                                     IdRow = q.IdRow,
                                     IdEmpresa = q.IdEmpresa,
                                     IdRegistro = q.IdRegistro,
                                     IdActivoFijo = q.IdActivoFijo,
                                     IdPeriodo = q.IdPeriodo,
                                     IdCbteVta_hn = q.IdCbteVta_hn,
                                     vt_NumFactura_hn = q.vt_NumFactura_hn,
                                     Af_ValorUnidad_Actu = q.Af_ValorUnidad_Actu,
                                     unidades_maximas = q.unidades_maximas,
                                     diferencia_a_facturar = q.diferencia_a_facturar,
                                     IdPunto_cargo = q.IdPunto_cargo,
                                     nom_punto_cargo = q.nom_punto_cargo,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdCbteVta_he = q.IdCbteVta_he,
                                     vt_NumFactura_he = q.vt_NumFactura_he,
                                     nom_Centro_costo = q.nom_Centro_costo,
                                     nom_Centro_costo_sub_centro_costo = q.nom_Centro_costo_sub_centro_costo,
                                     nom_periodo = q.nom_periodo
                                 }).ToList();
                    else
                        if (IdCentroCosto != "" && IdCentroCosto_sub_centro_costo == "")
                            Lista = (from q in Context.vwFAC_FJ_Rpt010
                                     where q.IdEmpresa == IdEmpresa
                                     && IdPeriodo_ini <= q.IdPeriodo && q.IdPeriodo <= IdPeriodo_fin
                                     && IdPunto_cargo_ini <= q.IdPunto_cargo && q.IdPunto_cargo <= IdPunto_cargo_fin
                                     && IdCentroCosto == q.IdCentroCosto
                                     select new XFAC_FJ_Rpt010_Info
                                     {
                                         IdRow = q.IdRow,
                                         IdEmpresa = q.IdEmpresa,
                                         IdRegistro = q.IdRegistro,
                                         IdActivoFijo = q.IdActivoFijo,
                                         IdPeriodo = q.IdPeriodo,
                                         IdCbteVta_hn = q.IdCbteVta_hn,
                                         vt_NumFactura_hn = q.vt_NumFactura_hn,
                                         Af_ValorUnidad_Actu = q.Af_ValorUnidad_Actu,
                                         unidades_maximas = q.unidades_maximas,
                                         diferencia_a_facturar = q.diferencia_a_facturar,
                                         IdPunto_cargo = q.IdPunto_cargo,
                                         nom_punto_cargo = q.nom_punto_cargo,
                                         IdCentroCosto = q.IdCentroCosto,
                                         IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                         IdCbteVta_he = q.IdCbteVta_he,
                                         vt_NumFactura_he = q.vt_NumFactura_he,
                                         nom_Centro_costo = q.nom_Centro_costo,
                                         nom_Centro_costo_sub_centro_costo = q.nom_Centro_costo_sub_centro_costo,
                                         nom_periodo = q.nom_periodo
                                     }).ToList();
                        else
                            Lista = (from q in Context.vwFAC_FJ_Rpt010
                                     where q.IdEmpresa == IdEmpresa
                                     && IdPeriodo_ini <= q.IdPeriodo && q.IdPeriodo <= IdPeriodo_fin
                                     && IdPunto_cargo_ini <= q.IdPunto_cargo && q.IdPunto_cargo <= IdPunto_cargo_fin
                                     && IdCentroCosto == q.IdCentroCosto
                                     && IdCentroCosto_sub_centro_costo == q.IdCentroCosto_sub_centro_costo
                                     select new XFAC_FJ_Rpt010_Info
                                     {
                                         IdRow = q.IdRow,
                                         IdEmpresa = q.IdEmpresa,
                                         IdRegistro = q.IdRegistro,
                                         IdActivoFijo = q.IdActivoFijo,
                                         IdPeriodo = q.IdPeriodo,
                                         IdCbteVta_hn = q.IdCbteVta_hn,
                                         vt_NumFactura_hn = q.vt_NumFactura_hn,
                                         Af_ValorUnidad_Actu = q.Af_ValorUnidad_Actu,
                                         unidades_maximas = q.unidades_maximas,
                                         diferencia_a_facturar = q.diferencia_a_facturar,
                                         IdPunto_cargo = q.IdPunto_cargo,
                                         nom_punto_cargo = q.nom_punto_cargo,
                                         IdCentroCosto = q.IdCentroCosto,
                                         IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                         IdCbteVta_he = q.IdCbteVta_he,
                                         vt_NumFactura_he = q.vt_NumFactura_he,
                                         nom_Centro_costo = q.nom_Centro_costo,
                                         nom_Centro_costo_sub_centro_costo = q.nom_Centro_costo_sub_centro_costo,
                                         nom_periodo = q.nom_periodo
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
