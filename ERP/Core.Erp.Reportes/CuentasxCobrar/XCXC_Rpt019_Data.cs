using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt019_Data
    {
        public List<XCXC_Rpt019_Info> get_list(int IdEmpresa, decimal IdCliente, bool no_mostrar_saldo_0, bool mostrar_anuladas, DateTime Fecha_corte)
        {
            try
            {
                decimal IdCliente_ini = IdCliente;
                decimal IdCliente_fin = IdCliente == 0 ? 99999 : IdCliente;

                string estado = mostrar_anuladas == true ? "" : "A";

                List<XCXC_Rpt019_Info> Lista;

                using (Entities_CuentasxCobrar Context = new Entities_CuentasxCobrar())
                {
                    Lista = (from q in Context.spCXC_Rpt018(IdEmpresa, IdCliente_ini, IdCliente_fin, Fecha_corte, no_mostrar_saldo_0, estado)
                             select new XCXC_Rpt019_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdCbteVta = q.IdCbteVta,
                                 dc_tipo_documento = q.dc_tipo_documento,
                                 observacion = q.observacion,
                                 num_documento = q.num_documento,
                                 fecha = q.fecha,
                                 fecha_vcto = q.fecha_vcto,
                                 IdCliente = q.IdCliente,
                                 nom_cliente = q.nom_cliente,
                                 subtotal = q.subtotal,
                                 valor_iva = q.valor_iva,
                                 valor_total = q.valor_total,
                                 valor_retencion = q.valor_retencion,
                                 valor_pagos = q.valor_pagos,
                                 valor_nc = q.valor_nc,
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
