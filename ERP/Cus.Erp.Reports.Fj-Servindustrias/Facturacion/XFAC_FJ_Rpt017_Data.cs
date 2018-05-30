using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt017_Data
    {
        public List<XFAC_FJ_Rpt017_Info> get_list(int IdEmpresa, decimal IdCliente, DateTime Fecha_ini, DateTime Fecha_fin, bool no_mostrar_saldo_0)
        {
            try
            {
                List<XFAC_FJ_Rpt017_Info> Lista;

                decimal IdCliente_ini = IdCliente;
                decimal IdCliente_fin = IdCliente == 0 ? 99999 : IdCliente;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {

                    Lista = (from q in Context.spFAC_FJ_Rpt017(IdEmpresa, IdCliente_ini, IdCliente_fin, Fecha_ini, Fecha_fin, no_mostrar_saldo_0)
                             select new XFAC_FJ_Rpt017_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdCbteVta = q.IdCbteVta,
                                 vt_tipoDoc = q.vt_tipoDoc,
                                 vt_NumFactura = q.vt_NumFactura,
                                 vt_fecha = q.vt_fecha,
                                 IdCliente = q.IdCliente,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 vt_Subtotal = q.vt_Subtotal,
                                 vt_iva = q.vt_iva,
                                 vt_total = q.vt_total,
                                 dc_ValorPago = q.dc_ValorPago,
                                 vt_saldo = q.vt_saldo,
                                 cr_fecha = q.cr_fecha,
                                 Estado_cobro = q.Estado_cobro,
                                 num_oc = q.num_oc,
                                 cant_cobro = q.cant_cobro,
                                 IdPeriodo = q.IdPeriodo,
                                 nombre_periodo = q.nombre_periodo,
                                 vt_Observacion = q.vt_Observacion,
                                 saldo_total = q.saldo_total
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
