using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt036_Data
    {
        public List<XCXP_Rpt036_Info> get_list(int IdEmpresa, decimal IdProveedor, bool no_mostrar_saldo_0, DateTime Fecha_ini, DateTime Fecha_fin, bool mostrar_origen_bodega, bool mostrar_origen_caja)
        {
            try
            {
                List<XCXP_Rpt036_Info> Lista;
                decimal IdProveedor_ini = IdProveedor;
                decimal IdProveedor_fin = IdProveedor == 0 ? 99999 : IdProveedor;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                
                using (EntitiesCXP_General Context = new EntitiesCXP_General())
                {
                    if(no_mostrar_saldo_0)
                    Lista = (from q in Context.vwCXP_Rpt036
                             where q.IdEmpresa == IdEmpresa
                             && IdProveedor_ini <= q.IdProveedor && q.IdProveedor <= IdProveedor_fin
                             && Fecha_ini <= q.co_FechaFactura && q.co_FechaFactura <= Fecha_fin
                             && q.Saldo > 0
                             select new XCXP_Rpt036_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                 IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                 co_FechaFactura = q.co_FechaFactura,
                                 co_FechaContabilizacion = q.co_FechaContabilizacion,
                                 co_factura = q.co_factura,
                                 IdProveedor = q.IdProveedor,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 pe_cedulaRuc = q.pe_cedulaRuc,
                                 co_observacion = q.co_observacion,
                                 co_subtotal_iva = q.co_subtotal_iva,
                                 co_subtotal_siniva = q.co_subtotal_siniva,
                                 co_valoriva = q.co_valoriva,
                                 co_total = q.co_total,
                                 Total_Retencion = q.Total_Retencion,
                                 monto_pagado = q.monto_pagado,
                                 Saldo = q.Saldo,
                                 origen_bodega = q.origen_bodega,
                                 origen_caja = q.origen_caja,
                             }).ToList();
                    else
                        Lista = (from q in Context.vwCXP_Rpt036
                                 where q.IdEmpresa == IdEmpresa
                                 && IdProveedor_ini <= q.IdProveedor && q.IdProveedor <= IdProveedor_fin
                                 && Fecha_ini <= q.co_FechaFactura && q.co_FechaFactura <= Fecha_fin
                                 select new XCXP_Rpt036_Info
                                 {
                                     IdRow = q.IdRow,
                                     IdEmpresa = q.IdEmpresa,
                                     IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                     IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                     co_FechaFactura = q.co_FechaFactura,
                                     co_FechaContabilizacion = q.co_FechaContabilizacion,
                                     co_factura = q.co_factura,
                                     IdProveedor = q.IdProveedor,
                                     pe_nombreCompleto = q.pe_nombreCompleto,
                                     pe_cedulaRuc = q.pe_cedulaRuc,
                                     co_observacion = q.co_observacion,
                                     co_subtotal_iva = q.co_subtotal_iva,
                                     co_subtotal_siniva = q.co_subtotal_siniva,
                                     co_valoriva = q.co_valoriva,
                                     co_total = q.co_total,
                                     Total_Retencion = q.Total_Retencion,
                                     monto_pagado = q.monto_pagado,
                                     Saldo = q.Saldo,
                                     origen_bodega = q.origen_bodega,
                                     origen_caja = q.origen_caja,
                                 }).ToList();

                    if (!mostrar_origen_bodega)
                        Lista = Lista.Where(q => q.origen_bodega != true).ToList();

                    if (!mostrar_origen_caja)
                        Lista = Lista.Where(q => q.origen_caja != true).ToList();
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
