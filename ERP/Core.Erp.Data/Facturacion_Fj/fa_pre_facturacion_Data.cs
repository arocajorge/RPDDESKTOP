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
    public class fa_pre_facturacion_Data
    {
        public List<fa_pre_facturacion_Info> Get_List(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;
                List<fa_pre_facturacion_Info> Lista = new List<fa_pre_facturacion_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion
                              where q.IdEmpresa == IdEmpresa &&
                              FechaIni <= q.fecha && q.fecha <= FechaFin
                              select q;

                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_Info info = new fa_pre_facturacion_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPreFacturacion = item.IdPreFacturacion;
                        info.IdPeriodo = item.IdPeriodo;
                        info.Observacion = item.Observacion;
                        info.estado_cierre = item.estado_cierre;
                        info.fecha = item.fecha;
                        info.estado = item.estado;

                        info.pe_mes = item.pe_mes;
                        info.pe_FechaIni = item.pe_FechaIni;
                        info.pe_FechaFin = item.pe_FechaFin;
                        info.nom_Centro_costo = item.nom_Centro_costo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.TotalEquipos = item.TotalEquipos;
                        info.ValorFacturar = item.ValorFacturar;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public fa_pre_facturacion_Info Get_Info(int IdEmpresa, decimal IdPreFacturacion)
        {
            try
            {
                fa_pre_facturacion_Info info = new fa_pre_facturacion_Info();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion Entity = Context.fa_pre_facturacion.FirstOrDefault(q => q.IdEmpresa == IdEmpresa && q.IdPreFacturacion == IdPreFacturacion);

                    if (Entity!=null)
                    {
                        info.IdEmpresa = Entity.IdEmpresa;
                        info.IdPreFacturacion = Entity.IdPreFacturacion;
                        info.IdPeriodo = Entity.IdPeriodo;
                        info.Observacion = Entity.Observacion;
                        info.estado_cierre = Entity.estado_cierre;
                        info.fecha = Entity.fecha;
                        info.estado = Entity.estado;
                        info.IdCentroCosto = Entity.IdCentroCosto;
                        info.TotalEquipos = Entity.TotalEquipos;
                        info.ValorFacturar = Entity.ValorFacturar;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public fa_pre_facturacion_Info Get_Info_x_periodo(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                fa_pre_facturacion_Info info = new fa_pre_facturacion_Info();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion Entity = Context.fa_pre_facturacion.FirstOrDefault(q => q.IdEmpresa == IdEmpresa && q.IdPeriodo == IdPeriodo);

                    if (Entity != null)
                    {
                        info.IdEmpresa = Entity.IdEmpresa;
                        info.IdPreFacturacion = Entity.IdPreFacturacion;
                        info.IdPeriodo = Entity.IdPeriodo;
                        info.Observacion = Entity.Observacion;
                        info.estado_cierre = Entity.estado_cierre;
                        info.fecha = Entity.fecha;
                        info.estado = Entity.estado;
                        info.TotalEquipos = Entity.TotalEquipos;
                        info.ValorFacturar = Entity.ValorFacturar;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion Entity = new fa_pre_facturacion();

                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdPreFacturacion = info.IdPreFacturacion = GetId(info.IdEmpresa);
                    Entity.IdPeriodo = info.IdPeriodo;
                    Entity.Observacion = info.Observacion;
                    Entity.estado_cierre = info.estado_cierre;
                    Entity.fecha = info.fecha;
                    Entity.estado = "A";
                    Entity.IdCentroCosto = info.IdCentroCosto;
                    Entity.ValorFacturar = (info.ValorFacturar == null) ? 0 : Convert.ToDouble(info.ValorFacturar);
                    Entity.TotalEquipos = (info.TotalEquipos == null) ? 0 : Convert.ToInt32(info.TotalEquipos);
                    Context.fa_pre_facturacion.Add(Entity);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion Entity = Context.fa_pre_facturacion.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdPreFacturacion == info.IdPreFacturacion);
                    if (Entity!=null)
                    {
                        Entity.Observacion = info.Observacion;
                        Entity.fecha = info.fecha;
                        Entity.estado_cierre = info.estado_cierre;
                        Entity.TotalEquipos = info.TotalEquipos;
                        Entity.ValorFacturar = info.ValorFacturar;
                    }
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(fa_pre_facturacion_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    fa_pre_facturacion Entity = Context.fa_pre_facturacion.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdPreFacturacion == info.IdPreFacturacion);

                    if (Entity != null)
                    {   
                        info.Observacion = "**ANULADO**"+Entity.Observacion;
                        Entity.estado_cierre = info.estado_cierre = true;                        
                        info.estado = Entity.estado;
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }        }

        private decimal GetId(int IdEmpresa)
        {
            try
            {

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_pre_facturacion
                              where q.IdEmpresa == IdEmpresa
                              select q;

                    if (lst.Count() == 0)
                    {
                        return 1;
                    }
                    else
                        return lst.Max(q => q.IdPreFacturacion) + 1;
                }
            }
            catch (Exception ex)
            {

                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
