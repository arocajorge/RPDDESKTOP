using Core.Erp.Data.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_ruta_Data
    {
        public List<Af_ruta_Info> get_list(int IdEmpresa)
        {
            try
            {
                List<Af_ruta_Info> Lista = new List<Af_ruta_Info>();

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var lst = from q in Context.Af_ruta
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        Af_ruta_Info info = new Af_ruta_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdRuta = item.IdRuta;
                        info.ru_descripcion = item.ru_descripcion;
                        info.ru_cantidad_km = item.ru_cantidad_km;
                        info.ru_observacion = item.ru_observacion;
                        info.estado = item.estado;
                        Lista.Add(info);
                    }
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
                mensaje = ex.InnerException + " " + ex.Message;
                //saca la excepción controlada a la proxima capa
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal get_id(int IdEmpresa)
        {
            try
            {
                decimal ID = 0;

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var lst = from q in Context.Af_ruta
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() == 0)
                        ID = 1;
                    else
                        ID = lst.Max(q => q.IdRuta) + 1;
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
                mensaje = ex.InnerException + " " + ex.Message;
                //saca la excepción controlada a la proxima capa
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool guardarDB(Af_ruta_Info info)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    Af_ruta Entity = new Af_ruta();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdRuta = info.IdRuta = get_id(info.IdEmpresa);
                    Entity.ru_descripcion = info.ru_descripcion;
                    Entity.ru_cantidad_km = info.ru_cantidad_km;
                    Entity.ru_observacion = info.ru_observacion;
                    Entity.estado = info.estado = true;
                    Context.Af_ruta.Add(Entity);
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
                mensaje = ex.InnerException + " " + ex.Message;
                //saca la excepción controlada a la proxima capa
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool modificarDB(Af_ruta_Info info)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    Af_ruta Entity = Context.Af_ruta.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdRuta == info.IdRuta);
                    if (Entity != null)
                    {
                        Entity.ru_descripcion = info.ru_descripcion;
                        Entity.ru_cantidad_km = info.ru_cantidad_km;
                        Entity.ru_observacion = info.ru_observacion;                                                
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                //saca la excepción controlada a la proxima capa
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool anularDB(Af_ruta_Info info)
        {
            try
            {
                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    Af_ruta Entity = Context.Af_ruta.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdRuta == info.IdRuta);
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
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                //saca la excepción controlada a la proxima capa
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
