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
    public class fa_registro_unidades_x_equipo_det_Data
    {
        string MensajeError = "";

        public List<fa_registro_unidades_x_equipo_det_Info> Get_List_det(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_Info> Lista = new List<fa_registro_unidades_x_equipo_det_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_registro_unidades_x_equipo_det
                              where info.IdEmpresa == q.IdEmpresa
                              && info.IdRegistro == q.IdRegistro
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_Info Info_det = new fa_registro_unidades_x_equipo_det_Info();

                        Info_det.IdEmpresa = item.IdEmpresa;
                        Info_det.IdRegistro = item.IdRegistro;
                        Info_det.IdFecha = item.IdFecha;
                        Info_det.IdUnidad_Medida = item.IdUnidad_Medida;
                        Info_det.IdTipo_Reg_cat = item.IdTipo_Reg_cat;
                        Info_det.IdActivoFijo = item.IdActivoFijo;
                        Info_det.Valor = item.Valor;
                        Info_det.fecha_reg = item.fecha_reg;
                        Info_det.fecha_modi = item.fecha_modi;
                        Info_det.IdPeriodo = item.IdPeriodo;
                        Info_det.CodActivoFijo = "[" + item.IdActivoFijo + "] " + item.CodActivoFijo;
                        Lista.Add(Info_det);    
                    }                    
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public double get_unidades_periodo_anterior(int IdEmpresa, int IdPeriodo, decimal IdActivoFijo)
        {
            try
            {
                double unidad_periodo_anterior = 0;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_registro_unidades_x_equipo_det
                              join c in Context.fa_registro_unidades_x_equipo
                              on new { q.IdEmpresa, q.IdRegistro } equals new { c.IdEmpresa, c.IdRegistro}
                              where q.IdEmpresa == IdEmpresa && q.IdPeriodo < IdPeriodo
                              && q.IdActivoFijo == IdActivoFijo && c.estado_cierre == true
                              && c.Estado == "A"
                              select q;

                    if (lst.Count()>0)
                    {
                        unidad_periodo_anterior = lst.Max(q => q.Valor);
                    }
                }
                return unidad_periodo_anterior;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<fa_registro_unidades_x_equipo_det_Info> Lista)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_registro_unidades_x_equipo_det_Info item in Lista)
                    {
                        fa_registro_unidades_x_equipo_det Entity = new fa_registro_unidades_x_equipo_det();

                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdRegistro = item.IdRegistro;
                        Entity.IdFecha = item.IdFecha;
                        Entity.IdUnidad_Medida = item.IdUnidad_Medida;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.IdTipo_Reg_cat = item.IdTipo_Reg_cat;                        
                        Entity.Valor = item.Valor;
                        Entity.fecha_reg = DateTime.Now;
                        Entity.fecha_modi = DateTime.Now;
                        Entity.IdPeriodo = item.IdPeriodo;

                        Context.fa_registro_unidades_x_equipo_det.Add(Entity);
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<fa_registro_unidades_x_equipo_det_Info> Lista)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_registro_unidades_x_equipo_det_Info item in Lista)
                    {
                        fa_registro_unidades_x_equipo_det Entity = Context.fa_registro_unidades_x_equipo_det.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa
                            && q.IdRegistro == item.IdRegistro && q.IdActivoFijo == item.IdActivoFijo && q.IdFecha == item.IdFecha && q.IdPeriodo == item.IdPeriodo);

                        if (Entity!=null)
                        {
                            Entity.IdEmpresa = item.IdEmpresa;
                            Entity.IdRegistro = item.IdRegistro;
                            Entity.IdFecha = item.IdFecha;
                            Entity.IdUnidad_Medida = item.IdUnidad_Medida;
                            Entity.IdTipo_Reg_cat = item.IdTipo_Reg_cat;
                            Entity.IdActivoFijo = item.IdActivoFijo;
                            Entity.Valor = item.Valor;
                            Entity.fecha_reg = item.fecha_reg;
                            Entity.fecha_modi = item.fecha_modi;
                            Context.SaveChanges();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())//IdPeriodo IdRegistro
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_registro_unidades_x_equipo_det where IdEmpresa = " + info.IdEmpresa + " and IdRegistro = "+info.IdRegistro);
                    return true;
                }
            }
            catch (Exception ex)
            {
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
