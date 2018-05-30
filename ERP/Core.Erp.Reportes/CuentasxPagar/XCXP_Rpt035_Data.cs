using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt035_Data
    {
        string mensaje = "";


        public List<XCXP_Rpt035_Info> get_Reporte_Estado_Cuenta_Proveedor_con_Dias_Vencidos(int IdEmpresa, DateTime FechaCorte,decimal IdProveedorIni,decimal IdProveedorFin,bool no_mostrar_en_conciliacion, bool no_mostrar_saldo_0)
        {
            try
            {
                FechaCorte = FechaCorte.Date;
                
                List<XCXP_Rpt035_Info> lstRpt = new List<XCXP_Rpt035_Info>();

                using (EntitiesCXP_General listado = new EntitiesCXP_General())
                {
                    listado.SetCommandTimeOut(3000);

                    if (no_mostrar_en_conciliacion && no_mostrar_saldo_0)
                        lstRpt = (from q in listado.spCXP_Rpt035(IdEmpresa, FechaCorte, IdProveedorIni, IdProveedorFin)
                                  where q.Saldo != 0 && q.en_conciliacion == false
                                  select new XCXP_Rpt035_Info
                                  {
                                      IdRow = q.IdRow,
                                      IdEmpresa = q.IdEmpresa,
                                      IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                      IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                      IdOrden_giro_Tipo = q.IdOrden_giro_Tipo,
                                      Documento = q.Documento,
                                      nom_tipo_doc = q.nom_tipo_doc,
                                      cod_tipo_doc = q.cod_tipo_doc,
                                      IdProveedor = q.IdProveedor,
                                      nom_proveedor = q.nom_proveedor,
                                      Valor_a_pagar = q.Valor_a_pagar,
                                      MontoAplicado = q.MontoAplicado,
                                      Saldo = q.Saldo,
                                      Observacion = q.Observacion,
                                      Ruc_Proveedor = q.Ruc_Proveedor,
                                      representante_legal = q.representante_legal,
                                      Tipo_cbte = q.Tipo_cbte,
                                      Plazo_fact = q.Plazo_fact,
                                      co_fechaOg = q.co_fechaOg,
                                      co_FechaFactura_vct = q.co_FechaFactura_vct,
                                      Dias_Vcto = q.Dias_Vcto,
                                      Fecha_corte = q.Fecha_corte,
                                      x_Vencer = q.x_Vencer,
                                      Vencido = q.Vencido,
                                      Vencido_1_30 = q.Vencido_1_30,
                                      Vencido_31_60 = q.Vencido_31_60,
                                      Vencido_60_90 = q.Vencido_60_90,
                                      Vencido_mayor_90 = q.Vencido_mayor_90,
                                  }).ToList();
                    else
                        if (!no_mostrar_en_conciliacion && no_mostrar_saldo_0)
                            lstRpt = (from q in listado.spCXP_Rpt035(IdEmpresa, FechaCorte, IdProveedorIni, IdProveedorFin)
                                      where q.Saldo != 0
                                      select new XCXP_Rpt035_Info
                                      {
                                          IdRow = q.IdRow,
                                          IdEmpresa = q.IdEmpresa,
                                          IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                          IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                          IdOrden_giro_Tipo = q.IdOrden_giro_Tipo,
                                          Documento = q.Documento,
                                          nom_tipo_doc = q.nom_tipo_doc,
                                          cod_tipo_doc = q.cod_tipo_doc,
                                          IdProveedor = q.IdProveedor,
                                          nom_proveedor = q.nom_proveedor,
                                          Valor_a_pagar = q.Valor_a_pagar,
                                          MontoAplicado = q.MontoAplicado,
                                          Saldo = q.Saldo,
                                          Observacion = q.Observacion,
                                          Ruc_Proveedor = q.Ruc_Proveedor,
                                          representante_legal = q.representante_legal,
                                          Tipo_cbte = q.Tipo_cbte,
                                          Plazo_fact = q.Plazo_fact,
                                          co_fechaOg = q.co_fechaOg,
                                          co_FechaFactura_vct = q.co_FechaFactura_vct,
                                          Dias_Vcto = q.Dias_Vcto,
                                          Fecha_corte = q.Fecha_corte,
                                          x_Vencer = q.x_Vencer,
                                          Vencido = q.Vencido,
                                          Vencido_1_30 = q.Vencido_1_30,
                                          Vencido_31_60 = q.Vencido_31_60,
                                          Vencido_60_90 = q.Vencido_60_90,
                                          Vencido_mayor_90 = q.Vencido_mayor_90,
                                      }).ToList();
                        else
                            if (!no_mostrar_en_conciliacion && !no_mostrar_saldo_0)
                                lstRpt = (from q in listado.spCXP_Rpt035(IdEmpresa, FechaCorte, IdProveedorIni, IdProveedorFin)
                                          select new XCXP_Rpt035_Info
                                          {
                                              IdRow = q.IdRow,
                                              IdEmpresa = q.IdEmpresa,
                                              IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                              IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                              IdOrden_giro_Tipo = q.IdOrden_giro_Tipo,
                                              Documento = q.Documento,
                                              nom_tipo_doc = q.nom_tipo_doc,
                                              cod_tipo_doc = q.cod_tipo_doc,
                                              IdProveedor = q.IdProveedor,
                                              nom_proveedor = q.nom_proveedor,
                                              Valor_a_pagar = q.Valor_a_pagar,
                                              MontoAplicado = q.MontoAplicado,
                                              Saldo = q.Saldo,
                                              Observacion = q.Observacion,
                                              Ruc_Proveedor = q.Ruc_Proveedor,
                                              representante_legal = q.representante_legal,
                                              Tipo_cbte = q.Tipo_cbte,
                                              Plazo_fact = q.Plazo_fact,
                                              co_fechaOg = q.co_fechaOg,
                                              co_FechaFactura_vct = q.co_FechaFactura_vct,
                                              Dias_Vcto = q.Dias_Vcto,
                                              Fecha_corte = q.Fecha_corte,
                                              x_Vencer = q.x_Vencer,
                                              Vencido = q.Vencido,
                                              Vencido_1_30 = q.Vencido_1_30,
                                              Vencido_31_60 = q.Vencido_31_60,
                                              Vencido_60_90 = q.Vencido_60_90,
                                              Vencido_mayor_90 = q.Vencido_mayor_90,
                                          }).ToList();
                            else
                                lstRpt = (from q in listado.spCXP_Rpt035(IdEmpresa, FechaCorte, IdProveedorIni, IdProveedorFin)
                                          where q.en_conciliacion == false
                                          select new XCXP_Rpt035_Info
                                          {
                                              IdRow = q.IdRow,
                                              IdEmpresa = q.IdEmpresa,
                                              IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                              IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                              IdOrden_giro_Tipo = q.IdOrden_giro_Tipo,
                                              Documento = q.Documento,
                                              nom_tipo_doc = q.nom_tipo_doc,
                                              cod_tipo_doc = q.cod_tipo_doc,
                                              IdProveedor = q.IdProveedor,
                                              nom_proveedor = q.nom_proveedor,
                                              Valor_a_pagar = q.Valor_a_pagar,
                                              MontoAplicado = q.MontoAplicado,
                                              Saldo = q.Saldo,
                                              Observacion = q.Observacion,
                                              Ruc_Proveedor = q.Ruc_Proveedor,
                                              representante_legal = q.representante_legal,
                                              Tipo_cbte = q.Tipo_cbte,
                                              Plazo_fact = q.Plazo_fact,
                                              co_fechaOg = q.co_fechaOg,
                                              co_FechaFactura_vct = q.co_FechaFactura_vct,
                                              Dias_Vcto = q.Dias_Vcto,
                                              Fecha_corte = q.Fecha_corte,
                                              x_Vencer = q.x_Vencer,
                                              Vencido = q.Vencido,
                                              Vencido_1_30 = q.Vencido_1_30,
                                              Vencido_31_60 = q.Vencido_31_60,
                                              Vencido_60_90 = q.Vencido_60_90,
                                              Vencido_mayor_90 = q.Vencido_mayor_90,
                                          }).ToList();
                }
                return lstRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXP_Rpt035_Info>();
            }
        }
    }
}
