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
    public class fa_tarifario_horometro_Data
    {
        public List<fa_tarifario_horometro_Info> get_list(int IdEmpresa)
        {
            try
            {
                List<fa_tarifario_horometro_Info> Lista;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.vwfa_tarifario_horometro
                             where q.IdEmpresa == IdEmpresa
                             select new fa_tarifario_horometro_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdTarifario = q.IdTarifario,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdPeriodo_ini = q.IdPeriodo_ini,
                                 IdPeriodo_fin = q.IdPeriodo_fin,
                                 Observacion = q.Observacion,
                                 estado = q.estado,
                                 IdProducto_hora_regular = q.IdProducto_hora_regular,
                                 IdProducto_hora_extra = q.IdProducto_hora_extra,
                                 Centro_costo = q.Centro_costo,
                                 IdCod_Impuesto = q.IdCod_Impuesto,
                                 porcentaje = q.porcentaje
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

        private int get_id(int IdEmpresa)
        {
            try
            {
                int ID = 1;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_tarifario_horometro
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() > 0)
                        ID = lst.Max(q => q.IdTarifario) + 1;
                }

                return ID;
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

        public bool guardarDB(fa_tarifario_horometro_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_tarifario_horometro Entity = new fa_tarifario_horometro();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdTarifario = info.IdTarifario = get_id(info.IdEmpresa);
                    Entity.IdCentroCosto = info.IdCentroCosto;
                    Entity.IdPeriodo_ini = info.IdPeriodo_ini;
                    Entity.IdPeriodo_fin = info.IdPeriodo_fin;
                    Entity.Observacion = info.Observacion;
                    Entity.estado = info.estado = true;
                    Entity.IdProducto_hora_regular = info.IdProducto_hora_regular;
                    Entity.IdProducto_hora_extra = info.IdProducto_hora_extra;
                    Entity.IdCod_Impuesto = info.IdCod_Impuesto;
                    Entity.porcentaje = info.porcentaje;
                    Context.fa_tarifario_horometro.Add(Entity);
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

        public bool modificarDB(fa_tarifario_horometro_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_tarifario_horometro Entity = Context.fa_tarifario_horometro.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdTarifario == info.IdTarifario);
                    if (Entity!=null)
                    {
                        Entity.IdCentroCosto = info.IdCentroCosto;
                        Entity.IdPeriodo_ini = info.IdPeriodo_ini;
                        Entity.IdPeriodo_fin = info.IdPeriodo_fin;
                        Entity.Observacion = info.Observacion;
                        Entity.IdProducto_hora_regular = info.IdProducto_hora_regular;
                        Entity.IdProducto_hora_extra = info.IdProducto_hora_extra;
                        Entity.IdCod_Impuesto = info.IdCod_Impuesto;
                        Entity.porcentaje = info.porcentaje;
                        Context.SaveChanges();    
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

        public bool anularDB(fa_tarifario_horometro_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_tarifario_horometro Entity = Context.fa_tarifario_horometro.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdTarifario == info.IdTarifario);
                    if (Entity != null)
                    {
                        Entity.estado = false;
                        Context.SaveChanges();
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
    }
}
