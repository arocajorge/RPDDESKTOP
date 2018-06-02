using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Cus.Erp.Reports.FJ.Bancos
{
    public class XBAN_FJ_Rpt004_Data
    {
        public List<XBAN_FJ_Rpt004_Info> Get_list_reporte(int IdEmpresa, List<int> lst_IdTipoFlujo, int IdPeriodo_ini, int IdPeriodo_fin, bool Mostrar_detallado, int IdBanco, bool Mostrar_solo_conciliado, bool Mostrar_beneficiario)
        {
            try
            {
                List<XBAN_FJ_Rpt004_Info> lstRpt = new List<XBAN_FJ_Rpt004_Info>();

                int IdBanco_ini = IdBanco;
                int IdBanco_fin = IdBanco == 0 ? 9999 : IdBanco;

                using (Entities_banco_fj_rpt Context = new Entities_banco_fj_rpt())
                {
                    Context.SetCommandTimeOut(3000);
                    IEnumerable<spBAN_FJ_Rpt004_Result> lst;
                    foreach (var item_tipoFlujo in lst_IdTipoFlujo)
                    {
                        lst = from q in Context.spBAN_FJ_Rpt004(IdEmpresa, IdPeriodo_ini, IdPeriodo_fin, item_tipoFlujo, item_tipoFlujo, IdBanco_ini, IdBanco_fin, Mostrar_detallado, Mostrar_solo_conciliado)
                                  select q;
                        foreach (var item in lst)
                        {
                            XBAN_FJ_Rpt004_Info info = new XBAN_FJ_Rpt004_Info();
                            info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                            info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                            info.Tipo_cbte_cxp = item.Tipo_cbte_cxp;
                            info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                            info.IdEmpresa_pago = item.IdEmpresa_pago;
                            info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                            info.Tipo_cbte_pago = item.Tipo_cbte_pago;
                            info.IdCbteCble_pago = item.IdCbteCble_pago;
                            info.co_observacion = Mostrar_beneficiario == true ? item.pe_nombreCompleto : item.co_observacion;
                            info.cb_Fecha = item.cb_Fecha;
                            info.IdTipoFlujo = item.IdTipoFlujo;
                            info.nom_tipo_flujo = item.nom_tipo_flujo;
                            info.cod_flujo = item.cod_flujo;
                            info.Tipo = item.Tipo;
                            info.dc_Valor = item.dc_Valor;
                            info.IdBanco = item.IdBanco;
                            info.nom_banco = item.nom_banco;
                            info.Tipo_movi = item.Tipo_movi;
                            info.orden = item.orden;
                            lstRpt.Add(info);
                        }
                    }

                    if (lst_IdTipoFlujo.Count == 0)
                    {
                        lst = from q in Context.spBAN_FJ_Rpt004(IdEmpresa, IdPeriodo_ini, IdPeriodo_fin, 1, 9999, IdBanco_ini, IdBanco_fin, Mostrar_detallado, Mostrar_solo_conciliado)
                              select q;

                        foreach (var item in lst)
                        {
                            XBAN_FJ_Rpt004_Info info = new XBAN_FJ_Rpt004_Info();
                            info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                            info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                            info.Tipo_cbte_cxp = item.Tipo_cbte_cxp;
                            info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                            info.IdEmpresa_pago = item.IdEmpresa_pago;
                            info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                            info.Tipo_cbte_pago = item.Tipo_cbte_pago;
                            info.IdCbteCble_pago = item.IdCbteCble_pago;
                            info.co_observacion = Mostrar_beneficiario == true ? item.pe_nombreCompleto : item.co_observacion;
                            info.cb_Fecha = item.cb_Fecha;
                            info.IdTipoFlujo = item.IdTipoFlujo;
                            info.nom_tipo_flujo = item.nom_tipo_flujo;
                            info.cod_flujo = item.cod_flujo;
                            info.Tipo = item.Tipo;
                            info.dc_Valor = item.dc_Valor;
                            info.IdBanco = item.IdBanco;
                            info.nom_banco = item.nom_banco;
                            info.Tipo_movi = item.Tipo_movi;
                            info.orden = item.orden;
                            lstRpt.Add(info);
                        }
                    }
                }

                return lstRpt;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_FJ_Rpt004_Data) };
            }
        }
    }
}