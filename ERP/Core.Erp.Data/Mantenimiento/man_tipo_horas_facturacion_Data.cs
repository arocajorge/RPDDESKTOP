using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Mantenimiento
{
    public class man_tipo_horas_facturacion_Data
    {
        public List<man_tipo_horas_facturacion_Info> get_list(int IdEmpresa, bool mostrar_anuladas)
        {
            try
            {
                List<man_tipo_horas_facturacion_Info> Lista = new List<man_tipo_horas_facturacion_Info>();

                using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                {
                    IQueryable<man_tipo_horas_facturacion> lst;

                    if(mostrar_anuladas)
                        lst = from q in Context.man_tipo_horas_facturacion
                              where q.IdEmpresa == IdEmpresa
                              select q;
                    else
                        lst = from q in Context.man_tipo_horas_facturacion
                              where q.IdEmpresa == IdEmpresa
                              && q.estado == true
                              select q;

                    foreach (var item in lst)
                    {
                        man_tipo_horas_facturacion_Info info = new man_tipo_horas_facturacion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipo = item.IdTipo;
                        info.IdProducto = item.IdProducto;
                        info.ti_codigo = item.ti_codigo;
                        info.ti_observacion = item.ti_observacion;
                        info.estado = item.estado;
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

        public bool guardarDB(List<man_tipo_horas_facturacion_Info> lst)
        {
            try
            {
                int secuencia = 1;
                foreach (var item in lst)
                {
                    using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                    {
                        man_tipo_horas_facturacion Entity = new man_tipo_horas_facturacion();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdTipo = item.IdTipo = secuencia;
                        Entity.IdProducto = item.IdProducto;
                        Entity.ti_codigo = item.ti_codigo;
                        Entity.ti_observacion = item.ti_observacion;
                        Entity.estado = item.estado;
                        Context.man_tipo_horas_facturacion.Add(Entity);
                        Context.SaveChanges();
                    }
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

        public bool eliminarDB(int IdEmpresa)
        {
            try
            {
                    using (EntitiesMantenimiento Context = new EntitiesMantenimiento())
                    {
                        Context.Database.ExecuteSqlCommand("DELETE man_tipo_horas_facturacion WHERE IdEmpresa = "+IdEmpresa);
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
