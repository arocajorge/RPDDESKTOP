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
    public class imp_catalogo_tipo_Data
    {
        public List<imp_catalogo_tipo_Info> get_list()
        {
            try
            {
                List<imp_catalogo_tipo_Info> Lista;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    Lista = (from q in Context.imp_catalogo_tipo
                             select new imp_catalogo_tipo_Info
                             {
                                 IdCatalogo_tipo = q.IdCatalogo_tipo,
                                 ct_descripcion = q.ct_descripcion,
                                 estado = q.estado
                             }).ToList();
                }

                Lista.ForEach(q => q.ct_descripcion_2 = "[" + q.IdCatalogo_tipo.ToString("000") + "]" + q.ct_descripcion);

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

        private int get_id()
        {
            try
            {
                int ID = 1;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    var lst = from q in Context.imp_catalogo_tipo
                              select q;

                    if (lst.Count() != 0)
                        ID = lst.Max(q => q.IdCatalogo_tipo) + 1;
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

        public bool guardarDB(imp_catalogo_tipo_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_catalogo_tipo Entity = new imp_catalogo_tipo();
                    Entity.IdCatalogo_tipo = info.IdCatalogo_tipo = get_id();
                    Entity.ct_descripcion = info.ct_descripcion;
                    Entity.estado = info.estado = true;
                    Context.imp_catalogo_tipo.Add(Entity);
                    Context.SaveChanges();
                    return true;
                }
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

        public bool modificarDB(imp_catalogo_tipo_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_catalogo_tipo Entity = Context.imp_catalogo_tipo.FirstOrDefault(q => q.IdCatalogo_tipo == info.IdCatalogo_tipo);
                    if (Entity == null)
                        return false;
                    Entity.ct_descripcion = info.ct_descripcion;
                    Context.SaveChanges();
                    return true;
                }
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

        public bool anularDB(imp_catalogo_tipo_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_catalogo_tipo Entity = Context.imp_catalogo_tipo.FirstOrDefault(q => q.IdCatalogo_tipo == info.IdCatalogo_tipo);
                    if (Entity == null)
                        return false;
                    Entity.estado = info.estado = false;
                    Context.SaveChanges();
                    return true;
                }
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
