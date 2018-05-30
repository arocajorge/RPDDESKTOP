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
    public class fa_pre_facturacion_det_otros_Data
    {
        public List<fa_pre_facturacion_det_otros_Info> get_list(int IdEmpresa, decimal IdPreFacturacion)
        {
            try
            {
                List<fa_pre_facturacion_det_otros_Info> Lista;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.fa_pre_facturacion_det_otros
                             where q.IdEmpresa == IdEmpresa && q.IdPreFacturacion == IdPreFacturacion
                             select new fa_pre_facturacion_det_otros_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdPreFacturacion = q.IdPreFacturacion,
                                 Secuencia = q.Secuencia,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdActivoFijo = q.IdActivoFijo,
                                 observacion = q.observacion,
                                 valor = q.valor
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

        public bool guardarDB(fa_pre_facturacion_det_otros_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion_det_otros Entity = new fa_pre_facturacion_det_otros();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdPreFacturacion = info.IdPreFacturacion;
                    Entity.Secuencia = info.Secuencia;
                    Entity.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                    Entity.IdCentroCosto = info.IdCentroCosto;
                    Entity.IdActivoFijo = info.IdActivoFijo;
                    Entity.observacion = info.observacion;
                    Entity.valor = info.valor;
                    Context.fa_pre_facturacion_det_otros.Add(Entity);
                    Context.SaveChanges();
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

        public bool guardarDB(List<fa_pre_facturacion_det_otros_Info> Lista)
        {
            try
            {
                int Secuencia = 1;
                foreach (var item in Lista)
                {
                    item.Secuencia = Secuencia;
                    if (!guardarDB(item))
                        return false;
                    Secuencia++;
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

        public bool eliminarDB(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_Otros where IdEmpresa = "+IdEmpresa+" and IdPrefacturacion = "+IdPrefacturacion);
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
