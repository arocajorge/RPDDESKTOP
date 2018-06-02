using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_liquidacion_x_punto_cargo_det_mano_obra_Data
    {
        fa_liquidacion_x_punto_cargo_det_mano_obra_det_Data odata_det = new fa_liquidacion_x_punto_cargo_det_mano_obra_det_Data();

        public List<fa_liquidacion_x_punto_cargo_det_mano_obra_Info> get_list(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                List<fa_liquidacion_x_punto_cargo_det_mano_obra_Info> Lista = new List<fa_liquidacion_x_punto_cargo_det_mano_obra_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_liquidacion_x_punto_cargo_det_mano_obra
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              && q.IdLiquidacion == IdLiquidacion
                              select q;

                    foreach (var item in lst)
                    {
                        fa_liquidacion_x_punto_cargo_det_mano_obra_Info info = new fa_liquidacion_x_punto_cargo_det_mano_obra_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.mo_secuencia = item.mo_secuencia;
                        info.IdActividad = item.IdActividad;
                        info.IdTecnico = item.IdTecnico;
                        info.mo_horas = item.mo_horas;
                        info.IdProducto = item.IdProducto;
                        info.mo_precio_uni = item.mo_precio_uni;
                        info.mo_por_ganancia = item.mo_por_ganancia;
                        info.mo_valor_ganancia = item.mo_valor_ganancia;
                        info.mo_precio_total = item.mo_precio_total;

                        info.lst_mano_obra_det = odata_det.get_list(info.IdEmpresa, info.IdSucursal, info.IdCentroCosto, info.IdLiquidacion, info.mo_secuencia);

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

        public bool guardarDB(fa_liquidacion_x_punto_cargo_det_mano_obra_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_liquidacion_x_punto_cargo_det_mano_obra Entity = new fa_liquidacion_x_punto_cargo_det_mano_obra();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdSucursal = info.IdSucursal;
                    Entity.IdCentroCosto = info.IdCentroCosto;
                    Entity.IdLiquidacion = info.IdLiquidacion;
                    Entity.mo_secuencia = info.mo_secuencia;
                    Entity.IdActividad = info.IdActividad;
                    Entity.IdTecnico = info.IdTecnico;
                    Entity.mo_horas = info.mo_horas;
                    Entity.IdProducto = info.IdProducto;
                    Entity.mo_precio_uni = info.mo_precio_uni;
                    Entity.mo_por_ganancia = info.mo_por_ganancia;
                    Entity.mo_valor_ganancia = info.mo_valor_ganancia;
                    Entity.mo_precio_total = info.mo_precio_total;
                    Context.fa_liquidacion_x_punto_cargo_det_mano_obra.Add(Entity);
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

        public bool guardarDB(List<fa_liquidacion_x_punto_cargo_det_mano_obra_Info> lst)
        {
            try
            {
                int secuencia = 1;
                foreach (var item in lst)
                {
                    item.mo_secuencia = secuencia;
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
                string comando = "delete Fj_servindustrias.fa_liquidacion_x_punto_cargo_det_mano_obra where IdEmpresa = "+IdEmpresa.ToString()+" and IdSucursal = "+IdSucursal.ToString()+" and IdCentroCosto = '"+IdCentroCosto+"' and IdLiquidacion = "+IdLiquidacion.ToString();
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
