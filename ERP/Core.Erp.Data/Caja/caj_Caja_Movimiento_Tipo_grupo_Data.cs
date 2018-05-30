using Core.Erp.Data.General;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Caja
{
    public class caj_Caja_Movimiento_Tipo_grupo_Data
    {
        public List<caj_Caja_Movimiento_Tipo_grupo_Info> get_list()
        {
            try
            {
                List<caj_Caja_Movimiento_Tipo_grupo_Info> Lista = new List<caj_Caja_Movimiento_Tipo_grupo_Info>();

                using (EntitiesCaja Context = new EntitiesCaja())
                {
                    Lista = (from q in Context.caj_Caja_Movimiento_Tipo_grupo
                             select new caj_Caja_Movimiento_Tipo_grupo_Info
                             {
                                 IdTipoMovi_grupo = q.IdTipoMovi_grupo,
                                 tg_descripcion = q.tg_descripcion,
                                 estado = q.estado
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        private int get_id()
        {
            try
            {
                int ID = 1;

                using (EntitiesCaja Context = new EntitiesCaja())
                {
                    var lst = from q in Context.caj_Caja_Movimiento_Tipo_grupo
                              select q;

                    if (lst.Count() > 0)
                        ID = lst.Max(q => q.IdTipoMovi_grupo) + 1;
                }

                return ID;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(caj_Caja_Movimiento_Tipo_grupo_Info info)
        {
            try
            {
                using (EntitiesCaja Context = new EntitiesCaja())
                {
                    caj_Caja_Movimiento_Tipo_grupo Entity = new caj_Caja_Movimiento_Tipo_grupo();
                    Entity.IdTipoMovi_grupo = info.IdTipoMovi_grupo = get_id();
                    Entity.tg_descripcion = info.tg_descripcion;
                    Entity.estado = info.estado = true;
                    Context.caj_Caja_Movimiento_Tipo_grupo.Add(Entity);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool modificarDB(caj_Caja_Movimiento_Tipo_grupo_Info info)
        {
            try
            {
                using (EntitiesCaja Context = new EntitiesCaja())
                {
                    caj_Caja_Movimiento_Tipo_grupo Entity = Context.caj_Caja_Movimiento_Tipo_grupo.FirstOrDefault(q => q.IdTipoMovi_grupo == info.IdTipoMovi_grupo);
                    if (Entity != null)
                    {                        
                        Entity.tg_descripcion = info.tg_descripcion;
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool anularDB(caj_Caja_Movimiento_Tipo_grupo_Info info)
        {
            try
            {
                using (EntitiesCaja Context = new EntitiesCaja())
                {
                    caj_Caja_Movimiento_Tipo_grupo Entity = Context.caj_Caja_Movimiento_Tipo_grupo.FirstOrDefault(q => q.IdTipoMovi_grupo == info.IdTipoMovi_grupo);
                    if (Entity != null)
                    {
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
