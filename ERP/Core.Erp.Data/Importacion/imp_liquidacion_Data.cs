using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Importacion
{
    public class imp_liquidacion_Data
    {
        public List<imp_liquidacion_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<imp_liquidacion_Info> Lista;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    Lista = (from q in Context.imp_liquidacion
                             where q.IdEmpresa == IdEmpresa
                             && Fecha_ini <= q.li_fecha && q.li_fecha <= Fecha_fin
                             select new imp_liquidacion_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdLiquidacion = q.IdLiquidacion,
                                 li_num_documento = q.li_num_documento,
                                 li_codigo = q.li_codigo,
                                 li_num_DAU = q.li_num_DAU,
                                 li_fecha = q.li_fecha,
                                 li_observacion = q.li_observacion,
                                 li_factor_conversion = q.li_factor_conversion,
                                 li_total_fob = q.li_total_fob,
                                 li_total_gastos = q.li_total_gastos,
                                 li_total_bodega = q.li_total_bodega,
                                 li_factor_costo = q.li_factor_costo,
                                 estado = q.estado,
                                 cerrado = q.cerrado
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        private decimal get_id(int IdEmpresa)
        {
            try
            {
                decimal ID = 1;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    var lst = from q in Context.imp_liquidacion
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() != 0)
                        ID = lst.Max(q => q.IdLiquidacion) + 1;
                }

                return ID;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(imp_liquidacion_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_liquidacion Entity = new imp_liquidacion();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdLiquidacion = info.IdLiquidacion = get_id(info.IdEmpresa);
                    Entity.li_num_documento = info.li_num_documento;
                    Entity.li_codigo = info.li_codigo;
                    Entity.li_num_DAU = info.li_num_DAU;
                    Entity.li_fecha = info.li_fecha;
                    Entity.li_observacion = info.li_observacion;
                    Entity.li_factor_conversion = info.li_factor_conversion;
                    Entity.li_total_fob = info.li_total_fob;
                    Entity.li_total_gastos = info.li_total_gastos;
                    Entity.li_total_bodega = info.li_total_bodega;
                    Entity.li_factor_costo = info.li_factor_costo;
                    Entity.cerrado = false;
                    Entity.estado = info.estado = true;
                    Context.imp_liquidacion.Add(Entity);
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool modificarDB(imp_liquidacion_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_liquidacion Entity = Context.imp_liquidacion.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdLiquidacion == info.IdLiquidacion);
                    if (Entity != null)
                    {
                        Entity.li_num_documento = info.li_num_documento;
                        Entity.li_codigo = info.li_codigo;
                        Entity.li_num_DAU = info.li_num_DAU;
                        Entity.li_fecha = info.li_fecha;
                        Entity.li_observacion = info.li_observacion;
                        Entity.li_factor_conversion = info.li_factor_conversion;
                        Entity.li_total_fob = info.li_total_fob;
                        Entity.li_total_gastos = info.li_total_gastos;
                        Entity.li_total_bodega = info.li_total_bodega;
                        Entity.li_factor_costo = info.li_factor_costo;                        
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool modificarDB_cierre(imp_liquidacion_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_liquidacion Entity = Context.imp_liquidacion.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdLiquidacion == info.IdLiquidacion);
                    if (Entity != null)
                    {
                        Entity.cerrado = info.cerrado = true;
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool anularDB(imp_liquidacion_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_liquidacion Entity = Context.imp_liquidacion.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdLiquidacion == info.IdLiquidacion);
                    if (Entity != null)
                    {
                        Entity.li_observacion = "***ANULADO*** " + Entity.li_observacion;
                        Entity.estado = info.estado = false;
                        Context.SaveChanges();
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
