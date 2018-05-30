using Core.Erp.Data.General;
using Core.Erp.Info.Contabilidad_Fj;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Contabilidad_Fj
{
    public class ct_distribucion_gastos_x_periodo_det_Data
    {
        public List<ct_distribucion_gastos_x_periodo_det_Info> get_list(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                List<ct_distribucion_gastos_x_periodo_det_Info> Lista;

                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    Lista = (from q in Context.vwct_distribucion_gastos_x_periodo_det
                             where q.IdEmpresa == IdEmpresa && q.IdDistribucion == IdDistribucion
                             select new ct_distribucion_gastos_x_periodo_det_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdDistribucion = q.IdDistribucion,
                                 Secuencia = q.Secuencia,
                                 IdCtaCble = q.IdCtaCble,
                                 IdPunto_cargo = q.IdPunto_cargo,
                                 valor = q.valor,
                                 pc_Cuenta = q.pc_Cuenta,
                                 nom_punto_cargo = q.nom_punto_cargo
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_distribucion_gastos_x_periodo_det_Info> get_list(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                List<ct_distribucion_gastos_x_periodo_det_Info> Lista;

                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    Lista = (from q in Context.vwct_distribucion_gastos_x_periodo_det_para_distribuir
                             where q.IdEmpresa == IdEmpresa && q.IdPeriodo == IdPeriodo
                             select new ct_distribucion_gastos_x_periodo_det_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdCtaCble = q.IdCtaCble,
                                 pc_Cuenta = q.pc_Cuenta,
                                 valor = q.dc_Valor                                 
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public int get_id(int IdEmpresa, decimal IdDistribucion)
        {
            try
            {
                int ID = 1;

                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    var lst = from q in Context.ct_distribucion_gastos_x_periodo_det
                              where q.IdEmpresa == IdEmpresa && q.IdDistribucion == IdDistribucion
                              select q;

                    if (lst.Count() > 0)
                        ID = lst.Max(q => q.Secuencia) + 1;
                }

                return ID;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(ct_distribucion_gastos_x_periodo_det_Info info)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    ct_distribucion_gastos_x_periodo_det Entity = new ct_distribucion_gastos_x_periodo_det();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdDistribucion = info.IdDistribucion;
                    Entity.Secuencia = info.Secuencia = get_id(info.IdEmpresa,info.IdDistribucion);
                    Entity.IdCtaCble = info.IdCtaCble;
                    Entity.IdPunto_cargo = info.IdPunto_cargo;
                    Entity.valor = info.valor;
                    Context.ct_distribucion_gastos_x_periodo_det.Add(Entity);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdDistribución, int Secuencia)
        {
            try
            {
                using (EntitiesContabilidad_FJ Context = new EntitiesContabilidad_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.ct_distribucion_gastos_x_periodo_det where IdEmpresa =  "+IdEmpresa+" and IdDistribucion = "+IdDistribución+" and Secuencia = "+Secuencia);
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
