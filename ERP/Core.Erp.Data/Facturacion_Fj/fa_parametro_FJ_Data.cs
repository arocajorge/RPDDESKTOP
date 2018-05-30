using Core.Erp.Info.Facturacion_FJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_parametro_FJ_Data
    {
        public fa_parametro_FJ_Info get_info(int IdEmpresa)
        {
            try
            {
                fa_parametro_FJ_Info info = new fa_parametro_FJ_Info();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    info = (from q in Context.fa_parametro_FJ
                            where q.IdEmpresa == IdEmpresa
                            select new fa_parametro_FJ_Info
                            {
                                IdEmpresa = q.IdEmpresa,
                                p_IdCod_Impuesto_IVA = q.p_IdCod_Impuesto_IVA,
                                p_IdProducto_prefacturacion = q.p_IdProducto_prefacturacion,
                                p_tipo_porc_ganancia_tarifario_cat = q.p_tipo_porc_ganancia_tarifario_cat
                            }).FirstOrDefault();

                }

                return info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool guardarDB(fa_parametro_FJ_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_parametro_FJ Entity = Context.fa_parametro_FJ.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa);
                    if (Entity != null)
                    {
                        Entity.p_tipo_porc_ganancia_tarifario_cat = info.p_tipo_porc_ganancia_tarifario_cat;
                        Entity.p_IdProducto_prefacturacion = info.p_IdProducto_prefacturacion;
                        Entity.p_IdCod_Impuesto_IVA = info.p_IdCod_Impuesto_IVA;
                        Context.SaveChanges();
                    }
                    else
                    {
                        Entity = new fa_parametro_FJ();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.p_tipo_porc_ganancia_tarifario_cat = info.p_tipo_porc_ganancia_tarifario_cat;
                        Entity.p_IdProducto_prefacturacion = info.p_IdProducto_prefacturacion;
                        Entity.p_IdCod_Impuesto_IVA = info.p_IdCod_Impuesto_IVA;
                        Context.fa_parametro_FJ.Add(Entity);
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
