using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt004_Data
    {
        public List<XCAJ_Rpt004_Info> Get_List(int IdEmpresa, decimal IdConcilacion_Caja)
        {
            try
            {
                List<XCAJ_Rpt004_Info> Lista = new List<XCAJ_Rpt004_Info>();

                using (EntitiesCaja_General Context = new EntitiesCaja_General())
                {
                    Lista = (from q in Context.vwCAJ_Rpt004
                             where q.IdEmpresa == IdEmpresa
                             && q.IdConciliacion_Caja == IdConcilacion_Caja
                             select new XCAJ_Rpt004_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdConciliacion_Caja = q.IdConciliacion_Caja,
                                 Secuencia = q.Secuencia,
                                 IdEmpresa_OGiro = q.IdEmpresa_OGiro,
                                 IdTipoCbte_Ogiro = q.IdTipoCbte_Ogiro,
                                 IdCbteCble_Ogiro = q.IdCbteCble_Ogiro,
                                 co_factura = q.co_factura,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 co_FechaFactura = q.co_FechaFactura,
                                 co_total = q.co_total,
                                 valor_retencion = q.valor_retencion,
                                 valor_a_pagar = q.valor_a_pagar,
                                 Valor_a_aplicar = q.Valor_a_aplicar,
                                 co_observacion = q.co_observacion,
                                 Saldo_cont_al_periodo = q.Saldo_cont_al_periodo,
                                 Ingresos = q.Ingresos,
                                 Total_fact_vale = q.Total_fact_vale,
                                 Dif_x_pagar_o_cobrar = q.Dif_x_pagar_o_cobrar,
                                 TIPO = q.TIPO,
                                 Fecha_ini = q.Fecha_ini,
                                 Fecha_fin = q.Fecha_fin,
                                 valor_a_reponer = q.valor_a_reponer
                             }).ToList();
                }
                
                return Lista;
            }
            catch (Exception ex)
            {

                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt004_Data) };
            }
        }
    }
}
