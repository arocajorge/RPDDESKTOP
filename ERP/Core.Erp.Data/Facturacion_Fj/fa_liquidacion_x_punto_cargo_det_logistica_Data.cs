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
    public class fa_liquidacion_x_punto_cargo_det_logistica_Data
    {
        public List<fa_liquidacion_x_punto_cargo_det_logistica_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                List<fa_liquidacion_x_punto_cargo_det_logistica_Info> Lista = new List<fa_liquidacion_x_punto_cargo_det_logistica_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_liquidacion_x_punto_cargo_det_logistica
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              && q.IdLiquidacion == IdLiquidacion
                              select q;

                    foreach (var item in lst)
                    {
                        fa_liquidacion_x_punto_cargo_det_logistica_Info info = new fa_liquidacion_x_punto_cargo_det_logistica_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.lo_secuencia = item.lo_secuencia;
                        info.lo_cantidad = item.lo_cantidad;
                        info.IdRuta = item.IdRuta;
                        info.lo_kilometros = item.lo_kilometros;
                        info.lo_por_ganancia = item.lo_por_ganancia;
                        info.lo_valor_ganancia = item.lo_valor_ganancia;
                        info.lo_precio_total = item.lo_precio_total;
                        info.lo_precio_uni_kilometro = item.lo_precio_uni_kilometro;
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

        public bool guardarDB(fa_liquidacion_x_punto_cargo_det_logistica_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_x_punto_cargo_det_logistica Entity = new fa_liquidacion_x_punto_cargo_det_logistica();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdSucursal = info.IdSucursal;
                    Entity.IdCentroCosto = info.IdCentroCosto;
                    Entity.IdLiquidacion = info.IdLiquidacion;
                    Entity.lo_secuencia = info.lo_secuencia;
                    Entity.lo_kilometros = info.lo_kilometros;
                    Entity.IdRuta = info.IdRuta;
                    Entity.lo_cantidad = info.lo_cantidad;
                    Entity.lo_precio_uni_kilometro = info.lo_precio_uni_kilometro;
                    Entity.lo_por_ganancia = info.lo_por_ganancia;
                    Entity.lo_valor_ganancia = info.lo_valor_ganancia;
                    Entity.lo_precio_total = info.lo_precio_total;
                    Context.fa_liquidacion_x_punto_cargo_det_logistica.Add(Entity);
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

        public bool guardarDB(List<fa_liquidacion_x_punto_cargo_det_logistica_Info> lst)
        {
            try
            {
                int secuencia = 1;
                foreach (var item in lst)
                {
                    item.lo_secuencia = secuencia;
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
                string comando = "delete Fj_servindustrias.fa_liquidacion_x_punto_cargo_det_logistica where IdEmpresa = " + IdEmpresa.ToString() + " and IdSucursal = " + IdSucursal.ToString() + " and IdCentroCosto = '" + IdCentroCosto + "' and IdLiquidacion = " + IdLiquidacion.ToString();
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
    }
}
