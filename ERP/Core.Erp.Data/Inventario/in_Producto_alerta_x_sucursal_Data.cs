using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario
{
    public class in_Producto_alerta_x_sucursal_Data
    {
        public List<in_Producto_alerta_x_sucursal_Info> get_list(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<in_Producto_alerta_x_sucursal_Info> Lista = new List<in_Producto_alerta_x_sucursal_Info>();

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Lista = (from q in Context.vwin_Producto_alerta_x_sucursal
                             where q.IdEmpresa == IdEmpresa
                             && q.IdSucursal == IdSucursal
                             select new in_Producto_alerta_x_sucursal_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdProducto = q.IdProducto,
                                 se_controla_stock_minimo = q.se_controla_stock_minimo,
                                 pr_stock_minimo = q.pr_stock_minimo,
                                 observacion = q.observacion,
                                 pr_codigo = q.pr_codigo,
                                 pr_descripcion = q.pr_descripcion
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, int IdSucursal)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Context.Database.ExecuteSqlCommand("DELETE in_Producto_alerta_x_sucursal WHERE IdEmpresa = "+IdEmpresa+" and IdSucursal = "+IdSucursal);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(List<in_Producto_alerta_x_sucursal_Info> Lista)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    foreach (var item in Lista)
                    {
                        in_Producto_alerta_x_sucursal Entity = new in_Producto_alerta_x_sucursal();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdSucursal = item.IdSucursal;
                        Entity.IdProducto = item.IdProducto;
                        Entity.se_controla_stock_minimo = item.se_controla_stock_minimo;
                        Entity.pr_stock_minimo = item.pr_stock_minimo;
                        Entity.observacion = item.observacion;
                        Context.in_Producto_alerta_x_sucursal.Add(Entity);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
