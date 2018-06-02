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
  public  class fa_pre_facturacion_proyeccion_mano_obra_Data
    {

        string MensajeError = "";

        public List<fa_pre_facturacion_proyeccion_mano_obra_Info> GetList(int idEmpresa, int IdPeriodo)
        {
            try
            {
                List<fa_pre_facturacion_proyeccion_mano_obra_Info> Lista = new List<fa_pre_facturacion_proyeccion_mano_obra_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_proyeccion_mano_obra
                              where idEmpresa == q.IdEmpresa
                              && q.IdPeriodo == IdPeriodo
                              select q;

                  

                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_proyeccion_mano_obra_Info info = new fa_pre_facturacion_proyeccion_mano_obra_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCargo = item.IdCargo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdSubcentroCosto = item.IdSubcentroCosto;
                        info.valor_proyectado = item.valor_proyectado;
                        info.ValorRealManoObra = item.ValorRealManoObra;
                        info.DiferenciaManoObra = item.DiferenciaManoObra;
                        info.fu_descripcion = item.fu_descripcion;
                        info.ca_descripcion = item.ca_descripcion;
                        info.ValorModificadoManoObra = item.ValorModificadoManoObra;
                        Lista.Add(info);
                    }
                    /*
                    if (lst.Count() == 0)
                    {
                        Lista = GetList(idEmpresa);
                    }
                     */
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

        public List<fa_pre_facturacion_proyeccion_mano_obra_Info> GetList(int idEmpresa)
        {
            try
            {
                List<fa_pre_facturacion_proyeccion_mano_obra_Info> Lista = new List<fa_pre_facturacion_proyeccion_mano_obra_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_proyeccion_mano_obra
                              where idEmpresa == q.IdEmpresa
                              select q;



                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_proyeccion_mano_obra_Info info = new fa_pre_facturacion_proyeccion_mano_obra_Info();

                        info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        info.IdCargo = item.IdCargo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdSubcentroCosto = item.IdSubcentroCosto;
                        info.valor_proyectado = item.valor_proyectado;
                        info.ValorRealManoObra = item.ValorRealManoObra;
                        info.DiferenciaManoObra = item.DiferenciaManoObra;
                        info.fu_descripcion = item.fu_descripcion;
                        info.ca_descripcion = item.ca_descripcion;
                        info.ValorModificadoManoObra = item.ValorModificadoManoObra;
                        Lista.Add(info);
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


        public bool GuardarDB(List<fa_pre_facturacion_proyeccion_mano_obra_Info> Lst_Info)
        {
            try
            {


              
                int Secuencia = 0;
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_pre_facturacion_proyeccion_mano_obra_Info item in Lst_Info)
                    {
                        fa_pre_facturacion_proyeccion_mano_obra Entity = new fa_pre_facturacion_proyeccion_mano_obra();
                        Secuencia++;
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPrefacturacion = item.IdPrefacturacion;
                        Entity.IdPeriodo = item.IdPeriodo;
                        Entity.IdCargo = item.IdCargo;
                        Entity.IdCentroCosto = item.IdCentroCosto;
                        Entity.IdSubcentroCosto = item.IdSubcentroCosto;
                        Entity.valor_proyectado =Convert.ToDouble( item.valor_proyectado);
                        Entity.ValorRealManoObra = item.ValorRealManoObra;
                        Entity.DiferenciaManoObra = item.DiferenciaManoObra;
                        Entity.ValorModificadoManoObra = item.ValorModificadoManoObra;
                        Context.fa_pre_facturacion_proyeccion_mano_obra.Add(Entity);
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

        public bool EliminarDB(fa_pre_facturacion_proyeccion_mano_obra_Info info)
        {
            try
            {

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_proyeccion_mano_obra where IdPeriodo = " + info.IdPeriodo + " and IdEmpresa = " + info.IdEmpresa + " ");
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
    }
}
