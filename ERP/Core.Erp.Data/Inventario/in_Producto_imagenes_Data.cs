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
    public class in_Producto_imagenes_Data
    {
        public in_Producto_imagenes_Info get_info(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_imagenes_Info info;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    info = (from q in Context.in_Producto_imagenes
                            where q.IdEmpresa == IdEmpresa
                            && q.IdProducto == IdProducto
                            select new in_Producto_imagenes_Info
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdProducto = q.IdProducto,
                                Secuencia = q.Secuencia,
                                Imagen = q.Imagen,                                
                            }).FirstOrDefault();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(in_Producto_imagenes_Info info)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    in_Producto_imagenes Entity = new in_Producto_imagenes
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdProducto = info.IdProducto,
                        Secuencia = info.Secuencia = 1,
                        Imagen = info.Imagen
                    };
                    Context.in_Producto_imagenes.Add(Entity);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Context.Database.ExecuteSqlCommand("DELETE in_Producto_imagenes where IdEmpresa = " + IdEmpresa + " and IdProducto = " + IdProducto);
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
