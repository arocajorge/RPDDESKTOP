using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_pre_facturacion_activos_Data
    {
        public List<fa_pre_facturacion_activos_Info> get_list(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<fa_pre_facturacion_activos_Info> Lista = new List<fa_pre_facturacion_activos_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.fa_pre_facturacion_activos
                             where q.IdEmpresa == IdEmpresa
                             && q.IdPreFacturacion == IdPrefacturacion
                             select new fa_pre_facturacion_activos_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdPreFacturacion = q.IdPreFacturacion,
                                 Secuencia = q.Secuencia,
                                 IdActivoFijo = q.IdActivoFijo,
                                 por_ganancia = q.por_ganancia,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 IdGrupo = q.IdGrupo,
                                 IdPeriodo_fin = q.IdPeriodo_fin,
                                 IdPeriodo_ini = q.IdPeriodo_ini,
                                 cant_act_x_scc = q.cant_act_x_scc,
                                 valor_depr_x_scc = q.valor_depr_x_scc,
                                 valor_movilizacion = q.valor_movilizacion
                             }).ToList();
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

        public List<fa_pre_facturacion_activos_Info> get_list(int IdEmpresa, string IdCentroCosto, int IdPeriodo)
        {
            try
            {
                List<fa_pre_facturacion_activos_Info> Lista = new List<fa_pre_facturacion_activos_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.vwfa_pre_facturacion_activos_data
                             where q.IdEmpresa == IdEmpresa
                             && q.IdCentroCosto == IdCentroCosto
                             && q.IdPeriodo_ini <= IdPeriodo && IdPeriodo <= q.IdPeriodo_fin
                             select new fa_pre_facturacion_activos_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdActivoFijo = q.IdActivoFijo,
                                 por_ganancia = q.porcentaje,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 IdGrupo = q.IdGrupo,
                                 IdPeriodo_fin = q.IdPeriodo_fin,
                                 IdPeriodo_ini = q.IdPeriodo_ini,
                                 cant_act_x_scc = q.cant_af_x_scc,
                                 valor_depr_x_scc = q.Valor_depreciacion,
                                 valor_movilizacion = q.valor_minimo_movilizacion
                             }).ToList();
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

        public bool guardarDB(List<fa_pre_facturacion_activos_Info> lst)
        {
            try
            {
                int secuencia = 1;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_activos Entity = new fa_pre_facturacion_activos();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPreFacturacion = item.IdPreFacturacion;
                        Entity.Secuencia = item.Secuencia = secuencia;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.por_ganancia = item.por_ganancia;
                        Entity.IdCentroCosto = item.IdCentroCosto;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.IdPeriodo_ini = item.IdPeriodo_ini;
                        Entity.IdPeriodo_fin = item.IdPeriodo_fin;
                        Entity.IdGrupo = item.IdGrupo;
                        Entity.cant_act_x_scc = item.cant_act_x_scc;
                        Entity.valor_depr_x_scc = item.valor_depr_x_scc;
                        Entity.valor_movilizacion = item.valor_movilizacion;
                        Context.fa_pre_facturacion_activos.Add(Entity);
                        Context.SaveChanges();
                        secuencia++;
                    }
                }

                return true;
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

        public bool eliminarDB(int IdEmpresa, decimal IdPreFacturacion)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("DELETE fj_servindustrias.fa_pre_facturacion_activos WHERE IdEmpresa = "+IdEmpresa+" and IdPreFacturacion = "+IdPreFacturacion);
                }

                return true;
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
