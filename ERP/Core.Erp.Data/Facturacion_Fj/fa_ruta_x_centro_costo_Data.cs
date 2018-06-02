using Core.Erp.Data.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_ruta_x_centro_costo_Data
    {
        public List<fa_ruta_x_centro_costo_Info> get_list(int IdEmpresa, string IdCentroCosto, bool Mostrar_anulados)
        {
            try
            {
                List<fa_ruta_x_centro_costo_Info> Lista = new List<fa_ruta_x_centro_costo_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    IQueryable<vwfa_ruta_x_centro_costo> lst;
                    if (Mostrar_anulados)
                    {
                        lst = from q in Context.vwfa_ruta_x_centro_costo
                              where q.IdEmpresa == IdEmpresa
                              && q.IdCentroCosto == IdCentroCosto
                              select q;    
                    }else
                        lst = from q in Context.vwfa_ruta_x_centro_costo
                              where q.IdEmpresa == IdEmpresa
                              && q.IdCentroCosto == IdCentroCosto
                              && q.estado == true
                              select q;    
                    

                    foreach (var item in lst)
                    {
                        fa_ruta_x_centro_costo_Info info = new fa_ruta_x_centro_costo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdRuta = item.IdRuta;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.ru_costo_x_km = item.ru_costo_x_km;

                        info.ru_descripcion = item.ru_descripcion;
                        info.ru_cantidad_km = item.ru_cantidad_km;
                        info.ru_observacion = item.ru_observacion;
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

        public List<fa_ruta_x_centro_costo_Info> get_no_list(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                List<fa_ruta_x_centro_costo_Info> Lista = new List<fa_ruta_x_centro_costo_Info>();

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    using (Entity_Facturacion_FJ Context_f = new Entity_Facturacion_FJ())
                    {
                        var lst = from q in Context.Af_ruta
                                  where q.IdEmpresa == IdEmpresa
                                  && q.estado == true
                                  select q;

                        var lst_2 = from q in Context_f.vwfa_ruta_x_centro_costo
                                    where q.IdEmpresa == IdEmpresa && q.IdCentroCosto == IdCentroCosto
                                    && q.estado == true
                                    select q;

                        foreach (var item in lst)
                        {
                            if (lst_2.Where(q=>q.IdEmpresa == item.IdEmpresa && q.IdRuta == item.IdRuta).Count() == 0)
                            {
                                fa_ruta_x_centro_costo_Info info = new fa_ruta_x_centro_costo_Info();
                                info.IdEmpresa = item.IdEmpresa;
                                info.IdRuta = item.IdRuta;
                                info.IdCentroCosto = IdCentroCosto;
                                info.ru_costo_x_km = 0;

                                info.ru_descripcion = item.ru_descripcion;
                                info.ru_cantidad_km = item.ru_cantidad_km;
                                info.ru_observacion = item.ru_observacion;
                                Lista.Add(info);
                            }                            
                        }
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

        public bool guardarDB(List<fa_ruta_x_centro_costo_Info> Lista)
        {
            try
            {                
                foreach (var item in Lista)
                {
                    using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                    {
                        fa_ruta_x_centro_costo Entity = new fa_ruta_x_centro_costo();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdCentroCosto = item.IdCentroCosto;
                        Entity.IdRuta = item.IdRuta;
                        Entity.ru_costo_x_km = item.ru_costo_x_km;
                        Context.fa_ruta_x_centro_costo.Add(Entity);
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
            }
        }

        public bool eliminarDB(int IdEmpresa, string IdCentroCosto)
        {
            try
            {   
                    using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                    {
                        string comando = "DELETE Fj_servindustrias.fa_ruta_x_centro_costo WHERE IdEmpresa = " + IdEmpresa.ToString() + " and IdCentroCosto = '" + IdCentroCosto + "'";
                        Context.Database.ExecuteSqlCommand(comando);
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
    }
}
