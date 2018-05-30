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
    public class imp_orden_compra_ext_Data
    {
        public List<imp_orden_compra_ext_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<imp_orden_compra_ext_Info> Lista;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    Lista = (from q in Context.imp_orden_compra_ext
                             where q.IdEmpresa == IdEmpresa
                             && Fecha_ini <= q.oe_fecha && q.oe_fecha <= Fecha_fin
                             select new imp_orden_compra_ext_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                 IdMoneda_origen = q.IdMoneda_origen,
                                 IdMoneda_destino = q.IdMoneda_destino,
                                 IdProveedor = q.IdProveedor,
                                 IdPais_origen = q.IdPais_origen,
                                 IdPais_embarque = q.IdPais_embarque,
                                 IdCiudad_destino = q.IdCiudad_destino,
                                 IdCatalogo_via = q.IdCatalogo_via,
                                 IdCatalogo_forma_pago = q.IdCatalogo_forma_pago,
                                 oe_fecha = q.oe_fecha,
                                 oe_fecha_llegada_est = q.oe_fecha_llegada_est,
                                 oe_fecha_embarque_est = q.oe_fecha_embarque_est,
                                 oe_fecha_desaduanizacion_est = q.oe_fecha_desaduanizacion_est,
                                 IdCtaCble_importacion = q.IdCtaCble_importacion,
                                 oe_observacion = q.oe_observacion,
                                 oe_codigo = q.oe_codigo,
                                 oe_valor_flete = q.oe_valor_flete,
                                 oe_valor_seguro = q.oe_valor_seguro,
                                 estado = q.estado,

                                 IdUsuario_creacion = q.IdUsuario_creacion,
                                 fecha_creacion = q.fecha_creacion,
                                 IdUsuario_modificacion = q.IdUsuario_modificacion,
                                 fecha_modificacion = q.fecha_modificacion,
                                 IdUsuario_anulacion = q.IdUsuario_anulacion,
                                 fecha_anulacion = q.fecha_anulacion,
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

        public List<imp_orden_compra_ext_Info> get_list(int IdEmpresa)
        {
            try
            {
                List<imp_orden_compra_ext_Info> Lista;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    Lista = (from q in Context.imp_orden_compra_ext
                             where q.IdEmpresa == IdEmpresa
                             select new imp_orden_compra_ext_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                 IdMoneda_origen = q.IdMoneda_origen,
                                 IdMoneda_destino = q.IdMoneda_destino,
                                 IdProveedor = q.IdProveedor,
                                 IdPais_origen = q.IdPais_origen,
                                 IdPais_embarque = q.IdPais_embarque,
                                 IdCiudad_destino = q.IdCiudad_destino,
                                 IdCatalogo_via = q.IdCatalogo_via,
                                 IdCatalogo_forma_pago = q.IdCatalogo_forma_pago,
                                 oe_fecha = q.oe_fecha,
                                 oe_fecha_llegada_est = q.oe_fecha_llegada_est,
                                 oe_fecha_embarque_est = q.oe_fecha_embarque_est,
                                 oe_fecha_desaduanizacion_est = q.oe_fecha_desaduanizacion_est,
                                 IdCtaCble_importacion = q.IdCtaCble_importacion,
                                 oe_observacion = q.oe_observacion,
                                 oe_codigo = q.oe_codigo,
                                 oe_valor_flete = q.oe_valor_flete,
                                 oe_valor_seguro = q.oe_valor_seguro,
                                 estado = q.estado,

                                 IdUsuario_creacion = q.IdUsuario_creacion,
                                 fecha_creacion = q.fecha_creacion,
                                 IdUsuario_modificacion = q.IdUsuario_modificacion,
                                 fecha_modificacion = q.fecha_modificacion,
                                 IdUsuario_anulacion = q.IdUsuario_anulacion,
                                 fecha_anulacion = q.fecha_anulacion,
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
                    var lst = from q in Context.imp_orden_compra_ext
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() != 0)
                        ID = lst.Max(q => q.IdOrdenCompra_ext) + 1;
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

        public bool guardarDB(imp_orden_compra_ext_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_orden_compra_ext Entity = new imp_orden_compra_ext();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdOrdenCompra_ext = info.IdOrdenCompra_ext = get_id(info.IdEmpresa);
                    Entity.IdMoneda_origen = info.IdMoneda_origen;
                    Entity.IdMoneda_destino = info.IdMoneda_destino;
                    Entity.IdProveedor = info.IdProveedor;
                    Entity.IdPais_origen = info.IdPais_origen;
                    Entity.IdPais_embarque = info.IdPais_embarque;
                    Entity.IdCiudad_destino = info.IdCiudad_destino;
                    Entity.IdCatalogo_via = info.IdCatalogo_via;
                    Entity.IdCatalogo_forma_pago = info.IdCatalogo_forma_pago;
                    Entity.oe_fecha = info.oe_fecha;
                    Entity.oe_fecha_llegada_est = info.oe_fecha_llegada_est;
                    Entity.oe_fecha_embarque_est = info.oe_fecha_embarque_est;
                    Entity.oe_fecha_desaduanizacion_est = info.oe_fecha_desaduanizacion_est;
                    Entity.IdCtaCble_importacion = info.IdCtaCble_importacion;
                    Entity.oe_observacion = info.oe_observacion;
                    Entity.oe_codigo = info.oe_codigo;
                    Entity.oe_valor_flete = info.oe_valor_flete;
                    Entity.oe_valor_seguro = info.oe_valor_seguro;
                    Entity.estado = info.estado = true;
                    
                    Entity.IdUsuario_creacion = info.IdUsuario_creacion;
                    Entity.fecha_creacion = info.fecha_creacion;
                    Context.imp_orden_compra_ext.Add(Entity);
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

        public bool modificarDB(imp_orden_compra_ext_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_orden_compra_ext Entity = Context.imp_orden_compra_ext.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenCompra_ext == info.IdOrdenCompra_ext);
                    if (Entity == null) return false;

                    Entity.IdMoneda_origen = info.IdMoneda_origen;
                    Entity.IdMoneda_destino = info.IdMoneda_destino;
                    Entity.IdProveedor = info.IdProveedor;
                    Entity.IdPais_origen = info.IdPais_origen;
                    Entity.IdPais_embarque = info.IdPais_embarque;
                    Entity.IdCiudad_destino = info.IdCiudad_destino;
                    Entity.IdCatalogo_via = info.IdCatalogo_via;
                    Entity.IdCatalogo_forma_pago = info.IdCatalogo_forma_pago;
                    Entity.oe_fecha = info.oe_fecha;
                    Entity.oe_fecha_llegada_est = info.oe_fecha_llegada_est;
                    Entity.oe_fecha_embarque_est = info.oe_fecha_embarque_est;
                    Entity.oe_fecha_desaduanizacion_est = info.oe_fecha_desaduanizacion_est;
                    Entity.IdCtaCble_importacion = info.IdCtaCble_importacion;
                    Entity.oe_observacion = info.oe_observacion;
                    Entity.oe_valor_flete = info.oe_valor_flete;
                    Entity.oe_valor_seguro = info.oe_valor_seguro;
                    Entity.oe_codigo = info.oe_codigo;

                    Entity.IdUsuario_modificacion = info.IdUsuario_modificacion;
                    Entity.fecha_modificacion = info.fecha_modificacion;
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

        public bool anularDB(imp_orden_compra_ext_Info info)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    imp_orden_compra_ext Entity = Context.imp_orden_compra_ext.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenCompra_ext == info.IdOrdenCompra_ext);
                    if (Entity == null) return false;

                    Entity.oe_observacion = "***ANULADO*** "+info.oe_observacion;

                    Entity.IdUsuario_anulacion = info.IdUsuario_anulacion;
                    Entity.fecha_anulacion = info.fecha_anulacion;
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
    }
}
