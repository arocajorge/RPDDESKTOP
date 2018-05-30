using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt003_Data
    {
        public List<XFAC_FJ_Rpt003_Info> get_list(int IdEmpresa, decimal IdCliente, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<XFAC_FJ_Rpt003_Info> Lista;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    Lista = (from q in Context.vwFAC_FJ_Rpt003
                             where q.IdEmpresa == IdEmpresa
                             && q.IdCliente == IdCliente
                             && Fecha_ini <= q.vt_fecha && q.vt_fecha <= Fecha_fin
                             select new XFAC_FJ_Rpt003_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdCbteVta = q.IdCbteVta,
                                 vt_NumFactura = q.vt_NumFactura,
                                 vt_fecha = q.vt_fecha,
                                 IdCliente = q.IdCliente,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 vt_Observacion = q.vt_Observacion,
                                 vt_Subtotal = q.vt_Subtotal,
                                 vt_iva = q.vt_iva,
                                 vt_total = q.vt_total,
                                 dc_ValorPago = q.dc_ValorPago,
                                 saldo = q.saldo
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
