using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt020_Data
    {
        public List<XCXC_Rpt020_Info> get_list(int IdEmpresa, decimal IdCliente, DateTime Fecha_corte, bool no_mostrar_saldo_0, bool mostrar_anuladas)
        {
            try
            {
                decimal IdCliente_Ini = IdCliente;
                decimal IdCliente_fin = IdCliente == 0 ? 99999 : IdCliente;

                Fecha_corte = Fecha_corte.Date;
                string estado = mostrar_anuladas == true ? "" : "A";
                string estado_cancelacion = no_mostrar_saldo_0 == true ? "PENDIENTE" : "";

                List<XCXC_Rpt020_Info> Lista;

                using (Entities_CuentasxCobrar Context = new Entities_CuentasxCobrar())
                {
                    Lista = (from q in Context.spCXC_Rpt020(IdEmpresa, IdCliente_Ini, IdCliente_fin, estado, Fecha_corte)
                             where q.Estado_documento.Contains(estado_cancelacion)
                             select new XCXC_Rpt020_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdCbteVta = q.IdCbteVta,
                                 vt_tipoDoc = q.vt_tipoDoc,
                                 vt_NumFactura = q.vt_NumFactura,
                                 vt_Observacion = q.vt_Observacion,
                                 vt_fecha = q.vt_fecha,
                                 valor_doc = q.valor_doc,
                                 valor = q.valor,
                                 Debito = q.Debito,
                                 Credito = q.Credito,
                                 saldo = q.saldo,
                                 IdCliente = q.IdCliente,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 Estado = q.Estado,
                                 Tipo_cbte = q.Tipo_cbte,
                                 orden = q.orden,
                                 Tipo_cobro = q.Tipo_cobro,
                                 num_documento_cobro = q.num_documento_cobro,
                                 IdCobro = q.IdCobro,
                                 Estado_documento = q.Estado_documento,
                                 cr_observacion = q.cr_observacion
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
