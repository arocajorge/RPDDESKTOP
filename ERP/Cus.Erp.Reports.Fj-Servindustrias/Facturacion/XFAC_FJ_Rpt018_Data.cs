using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt018_Data
    {
        public List<XFAC_FJ_Rpt018_Info> get_list(int IdEmpresa, decimal IdCliente,DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                decimal IdCliente_ini = IdCliente;
                decimal IdCliente_fin = IdCliente == 0 ? 9999 : IdCliente;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                List<XFAC_FJ_Rpt018_Info> Lista;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    Lista = (from q in Context.vwFAC_FJ_Rpt018
                             where q.IdEmpresa == IdEmpresa
                             && IdCliente_ini <= q.IdCliente && q.IdCliente <= IdCliente_fin
                             && Fecha_ini <= q.vt_fecha &&  q.vt_fecha <= Fecha_fin
                             select new XFAC_FJ_Rpt018_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 vt_Subtotal = q.vt_Subtotal,
                                 vt_iva = q.vt_iva,
                                 vt_total = q.vt_total,
                                 fecha_cobro_1 = q.fecha_cobro_1,
                                 fecha_cobro_2 = q.fecha_cobro_2,
                                 IdCliente = q.IdCliente,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 vt_fecha = q.vt_fecha
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
