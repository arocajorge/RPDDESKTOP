using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt004_Data
    {
        List<XBAN_Rpt004_Info> listadedatos = new List<XBAN_Rpt004_Info>();

        public List<XBAN_Rpt004_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin, int idBancoIni, int idBancoFin, string TipoCbte)
        {

            try
            {                                                                       
                List<XBAN_Rpt004_Info> lista = new List<XBAN_Rpt004_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                TipoCbte = TipoCbte == "DEPO" ? "DEP" : TipoCbte;
                TipoCbte = TipoCbte == "CHEQ" ? "CHE" : TipoCbte;
                TipoCbte = TipoCbte == "NCBA" ? "NCB" : TipoCbte;
                TipoCbte = TipoCbte == "NDBA" ? "NDB" : TipoCbte;

                using (EntitiesBancos_Reporte_Ge ListadoCbte = new EntitiesBancos_Reporte_Ge())
                {
                    lista = (from q in ListadoCbte.vwBAN_Rpt004
                             where q.IdEmpresa == idempresa
                             && idBancoIni <= q.IdBanco && q.IdBanco <= idBancoFin
                             && FechaIni <= q.cb_Fecha && q.cb_Fecha <= FechaFin
                             && q.CodTipoCbte.Contains(TipoCbte)
                             select new XBAN_Rpt004_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdTipocbte = q.IdTipocbte,
                                 IdCbteCble = q.IdCbteCble,
                                 cb_Fecha = q.cb_Fecha,
                                 cb_Observacion = q.cb_Observacion,
                                 cb_Cheque = q.cb_Cheque,
                                 cb_Valor = q.cb_Valor,
                                 debe = q.debe,
                                 haber = q.haber,
                                 saldo = q.saldo,
                                 CodTipoCbte = q.CodTipoCbte,
                                 tc_TipoCbte = q.tc_TipoCbte,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 Estado = q.Estado,
                                 IdEmpresa_cxp = q.IdEmpresa_cxp,
                                 IdTipoCbte_cxp = q.IdTipoCbte_cxp,
                                 IdCbteCble_cxp = q.IdCbteCble_cxp,
                                 observacion_deuda = q.observacion_deuda,
                                 fecha_deuda = q.fecha_deuda,
                                 num_querry = q.num_querry,
                                 orden = q.orden,
                                 IdBanco = q.IdBanco,
                                 ba_descripcion = q.ba_descripcion
                             }).ToList();                           
                }
                return lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt014_Data) };
            }
        }   
    }
}
