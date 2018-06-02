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
    public class fa_tarifario_horometro_det_Data
    {
        public List<fa_tarifario_horometro_det_Info> get_list(int IdEmpresa, int IdTarifario)
        {
            try
            {
                List<fa_tarifario_horometro_det_Info> Lista;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.fa_tarifario_horometro_det
                             where q.IdEmpresa == IdEmpresa && q.IdTarifario == IdTarifario
                             select new fa_tarifario_horometro_det_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdTarifario = q.IdTarifario,
                                 Secuencia = q.Secuencia,
                                 IdActivoFijo = q.IdActivoFijo,
                                 valor_unidad = q.valor_unidad,
                                 unidades_minimas = q.unidades_minimas,
                                 total_valor_x_unidades_minimas = q.total_valor_x_unidades_minimas
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

        public bool guardarDB(List<fa_tarifario_horometro_det_Info> lst)
        {
            try
            {
                int Secuencia = 1;
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lst)
                    {
                        fa_tarifario_horometro_det Entity = new fa_tarifario_horometro_det();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdTarifario = item.IdTarifario;
                        Entity.Secuencia = item.Secuencia = Secuencia;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.valor_unidad = item.valor_unidad;
                        Entity.unidades_minimas = item.unidades_minimas;
                        Entity.total_valor_x_unidades_minimas = item.total_valor_x_unidades_minimas;                        
                        Context.fa_tarifario_horometro_det.Add(Entity);
                        Context.SaveChanges();
                        Secuencia++;
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

        public bool eliminarDB(int IdEmpresa, int IdTarifario)
        {
            try
            {
                
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_tarifario_horometro_det where IdEmpresa = "+IdEmpresa+" and IdTarifario = "+IdTarifario);
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
