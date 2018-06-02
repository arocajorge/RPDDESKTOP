using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt002_Data
    {
        public List<XFAC_FJ_Rpt002_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<XFAC_FJ_Rpt002_Info> Lista = new List<XFAC_FJ_Rpt002_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {

                    var lst = from q in Context.vwFAC_FJ_Rpt002
                              where IdEmpresa == q.IdEmpresa && IdPrefacturacion == q.IdPreFacturacion
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt002_Info info = new XFAC_FJ_Rpt002_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPreFacturacion = item.IdPreFacturacion;
                        info.secuencia = item.secuencia;
                        info.IdCentro_Costo = item.IdCentro_Costo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        info.IdCbteCble_ct = item.IdCbteCble_ct;
                        info.Cantidad = item.Cantidad;
                        info.Costo_Uni = item.Costo_Uni;
                        info.Subtotal = item.Subtotal;
                        info.Por_Iva = item.Por_Iva;
                        info.Valor_Iva = item.Valor_Iva;
                        info.Total = item.Total;
                        info.Valor_a_cobrar = item.Valor_a_cobrar;
                        info.Facturar = item.Facturar;
                        info.IdTarifario = item.IdTarifario;
                        info.Porc_ganancia = item.Porc_ganancia;
                        info.num_documento = item.num_documento;
                        info.nom_proveedor = item.nom_proveedor;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.Fecha_documento = item.Fecha_documento;
                        info.Observacion = item.Observacion;
                        info.IdTipoMovi_grupo = item.IdTipoMovi_grupo;
                        info.tg_descripcion = item.tg_descripcion;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
