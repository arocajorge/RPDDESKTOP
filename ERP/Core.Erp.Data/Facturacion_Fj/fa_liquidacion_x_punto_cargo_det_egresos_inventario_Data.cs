using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_liquidacion_x_punto_cargo_det_egresos_inventario_Data
    {
        public List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> Lista = new List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_liquidacion_x_punto_cargo_det_egresos_inventario
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              && q.IdLiquidacion == IdLiquidacion
                              select q;

                    foreach (var item in lst)
                    {
                        fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info info = new fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.eg_secuencia = item.eg_secuencia;
                        info.eg_cantidad = item.eg_cantidad;
                        info.eg_precio_uni = item.eg_precio_uni;
                        info.eg_por_ganancia = item.eg_por_ganancia;
                        info.eg_valor_ganancia = item.eg_valor_ganancia;
                        info.eg_precio_total = item.eg_precio_total;
                        info.inv_IdEmpresa = item.inv_IdEmpresa;
                        info.inv_IdSucursal = item.inv_IdSucursal;
                        info.inv_IdMovi_inven_tipo = item.inv_IdMovi_inven_tipo;
                        info.inv_IdNumMovi = item.inv_IdNumMovi;
                        info.inv_Secuencia = item.inv_Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.IdUnidadMedida = item.IdUnidadMedida;
                        info.pr_precio_publico = item.pr_precio_publico;
                        info.eg_estado = true;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_x_punto_cargo_det_egresos_inventario Entity = new fa_liquidacion_x_punto_cargo_det_egresos_inventario();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdSucursal = info.IdSucursal;
                    Entity.IdCentroCosto = info.IdCentroCosto;
                    Entity.IdLiquidacion = info.IdLiquidacion;
                    Entity.eg_secuencia = info.eg_secuencia;
                    Entity.eg_cantidad = info.eg_cantidad;
                    Entity.eg_precio_uni = info.eg_precio_uni;
                    Entity.eg_por_ganancia = info.eg_por_ganancia;
                    Entity.eg_valor_ganancia = info.eg_valor_ganancia;
                    Entity.eg_precio_total = info.eg_precio_total;
                    Entity.inv_IdEmpresa = info.inv_IdEmpresa;
                    Entity.inv_IdSucursal = info.inv_IdSucursal;
                    Entity.inv_IdMovi_inven_tipo = info.inv_IdMovi_inven_tipo;
                    Entity.inv_IdNumMovi = info.inv_IdNumMovi;
                    Entity.inv_Secuencia = info.inv_Secuencia;
                    Entity.IdProducto = info.IdProducto;
                    Entity.IdUnidadMedida = info.IdUnidadMedida;
                    Entity.pr_precio_publico = info.pr_precio_publico;
                    Context.fa_liquidacion_x_punto_cargo_det_egresos_inventario.Add(Entity);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> lst)
        {
            try
            {
                int secuencia = 1;
                foreach (var item in lst)
                {
                    item.eg_secuencia = secuencia;
                    if (!guardarDB(item)) return false;
                    secuencia++;
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

        public bool eliminarDB(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                string comando = "delete Fj_servindustrias.fa_liquidacion_x_punto_cargo_det_egresos_inventario where IdEmpresa = " + IdEmpresa.ToString() + " and IdSucursal = " + IdSucursal.ToString() + " and IdCentroCosto = '" + IdCentroCosto + "' and IdLiquidacion = " + IdLiquidacion.ToString();
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand(comando);
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

        public List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> get_list(int IdPunto_cargo, string cod_orden_mantenimiento, int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> Lista = new List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    IQueryable<vwfa_liquidacion_x_punto_cargo_det_ing_egr_inven> lst;
                    
                    //Query para obtener movimientos que no esten en una liquidacion
                    lst = from q in Context.vwfa_liquidacion_x_punto_cargo_det_ing_egr_inven
                          where q.IdPunto_cargo == IdPunto_cargo
                          && q.cod_orden_mantenimiento == cod_orden_mantenimiento
                          && q.li_IdLiquidacion == null && q.signo == "-"
                          select q;

                    foreach (var item in lst)
                    {
                        fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info info = new fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info();
                        info.inv_IdEmpresa = item.IdEmpresa;
                        info.inv_IdSucursal = item.IdSucursal;
                        info.inv_IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.inv_IdNumMovi = item.IdNumMovi;
                        info.inv_Secuencia = item.Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.IdUnidadMedida = item.IdUnidadMedida;
                        info.eg_cantidad = Math.Abs(item.dm_cantidad);
                        info.eg_precio_uni = item.mv_costo;
                        info.eg_precio_total = item.mv_costo;
                        info.pr_precio_publico = item.mv_costo;
                        Lista.Add(info);
                    }
                    if (IdLiquidacion != 0)
                    {
                        var lst_2 = from q in Context.fa_liquidacion_x_punto_cargo_det_egresos_inventario
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal
                          && q.IdCentroCosto == IdCentroCosto
                          && q.IdLiquidacion == IdLiquidacion
                          select q;

                        foreach (var item in lst_2)
                        {
                            fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info info = new fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdLiquidacion = item.IdLiquidacion;
                            info.eg_secuencia = item.eg_secuencia;
                            info.eg_cantidad = item.eg_cantidad;
                            info.eg_precio_uni = item.eg_precio_uni;
                            info.eg_por_ganancia = item.eg_por_ganancia;
                            info.eg_valor_ganancia = item.eg_valor_ganancia;
                            info.eg_precio_total = item.eg_precio_total;
                            info.inv_IdEmpresa = item.inv_IdEmpresa;
                            info.inv_IdSucursal = item.inv_IdSucursal;
                            info.inv_IdMovi_inven_tipo = item.inv_IdMovi_inven_tipo;
                            info.inv_IdNumMovi = item.inv_IdNumMovi;
                            info.inv_Secuencia = item.inv_Secuencia;
                            info.IdProducto = item.IdProducto;
                            info.IdUnidadMedida = item.IdUnidadMedida;
                            info.pr_precio_publico = item.pr_precio_publico;
                            info.eg_estado = true;
                            Lista.Add(info);
                        }
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
