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
    public class imp_gasto_x_ct_plancta_Data
    {
        public List<imp_gasto_x_ct_plancta_Info> get_list(int IdEmpresa)
        {
            try
            {
                List<imp_gasto_x_ct_plancta_Info> Lista;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    Lista = (from q in Context.imp_gasto_x_ct_plancta
                             join g in Context.imp_gasto
                             on new { q.IdGasto_tipo } equals new { g.IdGasto_tipo }
                             where q.IdEmpresa == IdEmpresa
                             select new imp_gasto_x_ct_plancta_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdGasto_tipo = q.IdGasto_tipo,
                                 IdCtaCble = q.IdCtaCble,
                                 info_gasto = new imp_gasto_Info
                                 {
                                     gt_descripcion = g.gt_descripcion,
                                     estado = g.estado
                                 }
                             }).ToList();

                    Lista.AddRange((from q in Context.imp_gasto
                                    where !(from f in Context.imp_gasto_x_ct_plancta
                                            where f.IdEmpresa == IdEmpresa
                                            select f.IdGasto_tipo).Contains(q.IdGasto_tipo)
                                    select new imp_gasto_x_ct_plancta_Info
                                    {
                                        IdEmpresa = IdEmpresa,
                                        IdGasto_tipo = q.IdGasto_tipo,
                                        info_gasto = new imp_gasto_Info
                                        {
                                            gt_descripcion = q.gt_descripcion,
                                            estado = q.estado
                                        }
                                    }).ToList());
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private int get_id_gasto()
        {
            try
            {
                int ID = 1;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    var lst = (from q in Context.imp_gasto
                               select q);

                    if (lst.Count() != 0)
                        ID = lst.Max(q => q.IdGasto_tipo) + 1;
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

        public bool guardarDB(imp_gasto_x_ct_plancta_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    if (info.info_gasto.IdGasto_tipo == 0)
                    {
                        imp_gasto Entity_gasto = new imp_gasto();
                        Entity_gasto.IdGasto_tipo = info.info_gasto.IdGasto_tipo = info.IdGasto_tipo = get_id_gasto();
                        Entity_gasto.gt_descripcion = info.info_gasto.gt_descripcion;
                        Entity_gasto.estado = info.info_gasto.estado = true;
                        Context.imp_gasto.Add(Entity_gasto);
                        Context.SaveChanges();

                        imp_gasto_x_ct_plancta Entity = new imp_gasto_x_ct_plancta();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.IdGasto_tipo = info.IdGasto_tipo;
                        Entity.IdCtaCble = info.IdCtaCble;
                        Context.imp_gasto_x_ct_plancta.Add(Entity);
                        Context.SaveChanges();
                    }
                    else
                    {
                        imp_gasto Entity_gasto = Context.imp_gasto.FirstOrDefault(q => q.IdGasto_tipo == info.IdGasto_tipo);
                        if (Entity_gasto == null)
                            return false;

                        Entity_gasto.gt_descripcion = info.info_gasto.gt_descripcion;
                        Context.SaveChanges();

                        imp_gasto_x_ct_plancta Entity = Context.imp_gasto_x_ct_plancta.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdGasto_tipo == info.IdGasto_tipo);
                        if (Entity == null)
                        {
                            Entity = new imp_gasto_x_ct_plancta();
                            Entity.IdEmpresa = info.IdEmpresa;
                            Entity.IdGasto_tipo = info.IdGasto_tipo;
                            Entity.IdCtaCble = info.IdCtaCble;
                            Context.imp_gasto_x_ct_plancta.Add(Entity);
                            Context.SaveChanges();
                        }
                        else
                        {
                            Entity.IdCtaCble = info.IdCtaCble;
                            Context.SaveChanges();
                        }                        
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
