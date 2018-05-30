using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt006_Data
    {
        public List<XFAC_FJ_Rpt006_Info> get_list(int IdEmpresa, int IdSucursal, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<XFAC_FJ_Rpt006_Info> Lista;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {

                    Lista = (from q in Context.vwFAC_FJ_Rpt006
                             where q.IdEmpresa == IdEmpresa
                             && Fecha_ini <= q.li_fecha && q.li_fecha <= Fecha_fin
                             && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                             select new XFAC_FJ_Rpt006_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 Su_Descripcion = q.Su_Descripcion,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdLiquidacion = q.IdLiquidacion,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 Centro_costo = q.Centro_costo,
                                 IdPunto_cargo = q.IdPunto_cargo,
                                 nom_punto_cargo = q.nom_punto_cargo,
                                 tecnico_1 = q.tecnico_1,
                                 tecnico_2 = q.tecnico_2,
                                 subtotal_eg = q.subtotal_eg,
                                 subtotal_in = q.subtotal_in,
                                 subtotal_mo = q.subtotal_mo,
                                 subtotal_lo = q.subtotal_lo,
                                 li_subtotal = q.li_subtotal,
                                 li_valor_iva = q.li_valor_iva,
                                 li_total = q.li_total,
                                 li_fecha = q.li_fecha,
                                 li_num_orden = q.li_num_orden,
                                 li_reporte_mantenimiento = q.li_reporte_mantenimiento,
                                 li_fecha_orden_mantenimiento = q.li_fecha_orden_mantenimiento,
                                 li_fecha_reporte_mantenimiento = q.li_fecha_reporte_mantenimiento,
                                 num_oc = q.num_oc,
                                 subtotal_fa = q.subtotal_fa,
                                 iva_fa = q.iva_fa,
                                 total_fa = q.total_fa,
                                 vt_fecha = q.vt_fecha,
                                 vt_NumFactura = q.vt_NumFactura,
                                 estado_fac = q.estado_fac,
                                 IdPeriodo = q.IdPeriodo,
                                 smes = q.smes,
                                 pe_mes = q.pe_mes,
                                 IdanioFiscal = q.IdanioFiscal
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
