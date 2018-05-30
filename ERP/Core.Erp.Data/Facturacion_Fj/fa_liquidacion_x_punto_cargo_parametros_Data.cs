using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_liquidacion_x_punto_cargo_parametros_Data
    {
        public fa_liquidacion_x_punto_cargo_parametros_Info get_info(int IdEmpresa)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_parametros_Info info = new fa_liquidacion_x_punto_cargo_parametros_Info();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_liquidacion_x_punto_cargo_parametros
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.eg_IdProducto = item.eg_IdProducto;
                        info.in_IdProducto = item.in_IdProducto;
                        info.lo_IdProducto = item.lo_IdProducto;
                    }
                }

                return info;
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

        public bool guardarDB(fa_liquidacion_x_punto_cargo_parametros_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_liquidacion_x_punto_cargo_parametros
                              where q.IdEmpresa == info.IdEmpresa
                              select q;

                    if (lst.Count() == 0)
                    {
                        fa_liquidacion_x_punto_cargo_parametros Entity = new fa_liquidacion_x_punto_cargo_parametros();
                        Entity.IdEmpresa = info.IdEmpresa;
                        Entity.eg_IdProducto = info.eg_IdProducto;
                        Entity.in_IdProducto = info.in_IdProducto;
                        Entity.lo_IdProducto = info.lo_IdProducto;
                        Context.fa_liquidacion_x_punto_cargo_parametros.Add(Entity);
                        Context.SaveChanges();
                    }
                    else
                    {
                        fa_liquidacion_x_punto_cargo_parametros Entity = Context.fa_liquidacion_x_punto_cargo_parametros.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa);
                        if (Entity!= null)
                        {
                            Entity.eg_IdProducto = info.eg_IdProducto;
                            Entity.in_IdProducto = info.in_IdProducto;
                            Entity.lo_IdProducto = info.lo_IdProducto;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}