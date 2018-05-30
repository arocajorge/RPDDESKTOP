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
    public class imp_orden_compra_ext_det_Data
    {
        public List<imp_orden_compra_ext_det_Info> get_list(int IdEmpresa, decimal IdOrdenCompra_ext)
        {
            try
            {
                List<imp_orden_compra_ext_det_Info> Lista;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    Lista = (from q in Context.imp_orden_compra_ext_det
                             where q.IdEmpresa == IdEmpresa
                             && q.IdOrdenCompra_ext == IdOrdenCompra_ext
                             select new imp_orden_compra_ext_det_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                 Secuencia = q.Secuencia,
                                 IdProducto = q.IdProducto,
                                 IdUnidadMedida = q.IdUnidadMedida,
                                 od_cantidad = q.od_cantidad,
                                 od_costo = q.od_costo,
                                 od_por_descuento = q.od_por_descuento,
                                 od_descuento = q.od_descuento,
                                 od_costo_final = q.od_costo_final,
                                 od_subtotal = q.od_subtotal,
                                 od_cantidad_recepcion = q.od_cantidad_recepcion,
                                 od_costo_convertido = q.od_costo_convertido,
                                 od_total_fob = q.od_total_fob,
                                 od_factor_costo = q.od_factor_costo,
                                 od_costo_bodega = q.od_costo_bodega,
                                 od_costo_total = q.od_costo_total
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

        public List<imp_orden_compra_ext_det_Info> get_list(int IdEmpresa, List<decimal> IdOrdenCompra_ext)
        {
            try
            {
                List<imp_orden_compra_ext_det_Info> Lista = new List<imp_orden_compra_ext_det_Info>();

                using (Entities_importacion Context = new Entities_importacion())
                {
                    foreach (var item in IdOrdenCompra_ext)
                    {
                        Lista.AddRange((from q in Context.imp_orden_compra_ext_det
                                        where q.IdEmpresa == IdEmpresa
                                        && q.IdOrdenCompra_ext == item
                                        select new imp_orden_compra_ext_det_Info
                                        {
                                            IdEmpresa = q.IdEmpresa,
                                            IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                            Secuencia = q.Secuencia,
                                            IdProducto = q.IdProducto,
                                            IdUnidadMedida = q.IdUnidadMedida,
                                            od_cantidad = q.od_cantidad,
                                            od_costo = q.od_costo,
                                            od_por_descuento = q.od_por_descuento,
                                            od_descuento = q.od_descuento,
                                            od_costo_final = q.od_costo_final,
                                            od_subtotal = q.od_subtotal,
                                            od_cantidad_recepcion = q.od_cantidad_recepcion,
                                            od_costo_convertido = q.od_costo_convertido,
                                            od_total_fob = q.od_total_fob,
                                            od_factor_costo = q.od_factor_costo,
                                            od_costo_bodega = q.od_costo_bodega,
                                            od_costo_total = q.od_costo_total
                                        }).ToList());
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
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdOrdenCompra_ext)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    Context.Database.ExecuteSqlCommand("DELETE imp_orden_compra_ext_det WHERE IdEmpresa = " + IdEmpresa + " AND IdOrdenCompra_ext = " + IdOrdenCompra_ext);
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

        public bool guardarDB(List<imp_orden_compra_ext_det_Info> Lista)
        {
            try
            {
                int sec = 1;
                using (Entities_importacion Context = new Entities_importacion())
                {
                    foreach (var item in Lista)
                    {
                        imp_orden_compra_ext_det Entity = new imp_orden_compra_ext_det(){
                            IdEmpresa = item.IdEmpresa,
                            IdOrdenCompra_ext = item.IdOrdenCompra_ext,
                            Secuencia = item.Secuencia = sec,
                            IdProducto = item.IdProducto,
                            IdUnidadMedida = item.IdUnidadMedida,
                            od_cantidad = item.od_cantidad,
                            od_costo = item.od_costo,
                            od_por_descuento = item.od_por_descuento,
                            od_descuento = item.od_descuento,
                            od_costo_final = item.od_costo_final,
                            od_subtotal = item.od_subtotal,
                            od_cantidad_recepcion = item.od_cantidad_recepcion,
                            od_costo_convertido = item.od_costo_convertido,
                            od_total_fob = item.od_total_fob,
                            od_factor_costo = item.od_factor_costo,
                            od_costo_bodega = item.od_costo_bodega,
                            od_costo_total = item.od_costo_total
                    };
                        Context.imp_orden_compra_ext_det.Add(Entity);
                        Context.SaveChanges();
                        sec++;
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
