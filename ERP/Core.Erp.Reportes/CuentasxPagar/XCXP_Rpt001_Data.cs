using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt001_Data
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public List<XCXP_Rpt001_Info> get_list(int IdEmpresa, int IdClase_proveedor, decimal IdProveedor, DateTime Fecha_corte, bool no_mostrar_saldo_0, bool no_mostrar_en_conciliacion)
        {
            try
            {
                List<XCXP_Rpt001_Info> Lista;

                int IdClase_proveedor_ini = IdClase_proveedor;
                int IdClase_proveedor_fin = IdClase_proveedor == 0 ? 9999 : IdClase_proveedor;

                decimal IdProveedor_ini = IdProveedor;
                decimal IdProveedor_fin = IdProveedor == 0 ? 99999: IdProveedor;

                Fecha_corte = Fecha_corte.Date;

                string estado_pago = no_mostrar_saldo_0 == true ? "PENDIENTE" : "";

                using (EntitiesCXP_General Context = new EntitiesCXP_General())
                {
                    if (!no_mostrar_en_conciliacion)
                    Lista = (from q in Context.spCXP_Rpt001(IdEmpresa, IdProveedor_ini, IdProveedor_fin, IdClase_proveedor_ini, IdClase_proveedor_fin, Fecha_corte)
                             where q.estado_pago.Contains(estado_pago)
                             select new XCXP_Rpt001_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                 IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                 IdOrden_giro_Tipo = q.IdOrden_giro_Tipo,
                                 Documento = q.Documento,
                                 nom_tipo_doc = q.nom_tipo_doc,
                                 cod_tipo_doc = q.cod_tipo_doc,
                                 co_fechaOg = q.co_fechaOg,
                                 IdProveedor = q.IdProveedor,
                                 nom_proveedor = q.nom_proveedor,
                                 total = q.total,
                                 valor = q.valor,
                                 Valor_debe = q.Valor_debe,
                                 Valor_Haber = q.Valor_Haber,
                                 Saldo = q.Saldo,
                                 estado_pago = q.estado_pago,
                                 Observacion = q.Observacion,
                                 Ruc_Proveedor = q.Ruc_Proveedor,
                                 representante_legal = q.representante_legal,
                                 Tipo_cbte = q.Tipo_cbte,
                                 IdEmpresa_pago = q.IdEmpresa_pago,
                                 IdTipoCbte_pago = q.IdTipoCbte_pago,
                                 IdCbteCble_pago = q.IdCbteCble_pago,
                                 cb_Observacion_pago = q.cb_Observacion_pago,
                                 tc_TipoCbte_pago = q.tc_TipoCbte_pago,
                                 cb_Cheque_pago = q.cb_Cheque_pago,
                                 IdClaseProveedor = q.IdClaseProveedor,
                                 descripcion_clas_prove = q.descripcion_clas_prove,
                                 NUM_QUERRY = q.NUM_QUERRY,
                                 en_conciliacion = q.en_conciliacion
                             }).ToList();
                    else
                        Lista = (from q in Context.spCXP_Rpt001(IdEmpresa, IdProveedor_ini, IdProveedor_fin, IdClase_proveedor_ini, IdClase_proveedor_fin, Fecha_corte)
                                 where q.estado_pago.Contains(estado_pago) && q.en_conciliacion == false
                                 select new XCXP_Rpt001_Info
                                 {
                                     IdRow = q.IdRow,
                                     IdEmpresa = q.IdEmpresa,
                                     IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                     IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                     IdOrden_giro_Tipo = q.IdOrden_giro_Tipo,
                                     Documento = q.Documento,
                                     nom_tipo_doc = q.nom_tipo_doc,
                                     cod_tipo_doc = q.cod_tipo_doc,
                                     co_fechaOg = q.co_fechaOg,
                                     IdProveedor = q.IdProveedor,
                                     nom_proveedor = q.nom_proveedor,
                                     total = q.total,
                                     valor = q.valor,
                                     Valor_debe = q.Valor_debe,
                                     Valor_Haber = q.Valor_Haber,
                                     Saldo = q.Saldo,
                                     estado_pago = q.estado_pago,
                                     Observacion = q.Observacion,
                                     Ruc_Proveedor = q.Ruc_Proveedor,
                                     representante_legal = q.representante_legal,
                                     Tipo_cbte = q.Tipo_cbte,
                                     IdEmpresa_pago = q.IdEmpresa_pago,
                                     IdTipoCbte_pago = q.IdTipoCbte_pago,
                                     IdCbteCble_pago = q.IdCbteCble_pago,
                                     cb_Observacion_pago = q.cb_Observacion_pago,
                                     tc_TipoCbte_pago = q.tc_TipoCbte_pago,
                                     cb_Cheque_pago = q.cb_Cheque_pago,
                                     IdClaseProveedor = q.IdClaseProveedor,
                                     descripcion_clas_prove = q.descripcion_clas_prove,
                                     NUM_QUERRY = q.NUM_QUERRY,
                                     en_conciliacion = q.en_conciliacion
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
