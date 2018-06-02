
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Acta_Finiquito_Detalle_Data
    {
        string mensaje = "";

        public List<ro_Acta_Finiquito_Detalle_Info> GetListConsultaPorId(int idEmpresa, decimal idEmpleado, decimal idActaFiniquito)
        {
            List<ro_Acta_Finiquito_Detalle_Info> listado = new List<ro_Acta_Finiquito_Detalle_Info>();

            try
            {
                EntitiesRoles db = new EntitiesRoles();
                var datos = (from a in db.ro_Acta_Finiquito_Detalle
                             where a.IdEmpresa == idEmpresa &&  a.IdActaFiniquito == idActaFiniquito
                             select a);

                foreach (var item in datos)
                {
                    ro_Acta_Finiquito_Detalle_Info info = new ro_Acta_Finiquito_Detalle_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActaFiniquito = item.IdActaFiniquito;
                    info.IdSecuencia = item.IdSecuencia;
                    info.Observacion = item.Observacion;
                    info.Valor = item.Valor;
                    listado.Add(info);
                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GetExiste(ro_Acta_Finiquito_Detalle_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_Acta_Finiquito_Detalle
                                where a.IdEmpresa == info.IdEmpresa 
                                && a.IdActaFiniquito == info.IdActaFiniquito && a.IdSecuencia==info.IdSecuencia
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int GetId(int idEmpresa, decimal idEmpleado, decimal idActaFiniquito)
        {
            int Id = 0;
            try
            {

                EntitiesRoles db = new EntitiesRoles();
                var selecte = db.ro_Acta_Finiquito_Detalle.Count(q => q.IdEmpresa == idEmpresa &&
                             q.IdActaFiniquito==idActaFiniquito);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in db.ro_Acta_Finiquito_Detalle
                                     where q.IdEmpresa == idEmpresa && q.IdActaFiniquito==idActaFiniquito
                                     select q.IdSecuencia).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarBD(ro_Acta_Finiquito_Detalle_Info item, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    ro_Acta_Finiquito_Detalle info = new ro_Acta_Finiquito_Detalle();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActaFiniquito = item.IdActaFiniquito;
                    info.IdSecuencia =  GetId(item.IdEmpresa, item.IdEmpleado, item.IdActaFiniquito);
                    info.Observacion = item.Observacion;
                    info.Valor = item.Valor;
                    info.IdRubro = item.IdRubro;
                    db.ro_Acta_Finiquito_Detalle.Add(info);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarBD(ro_Acta_Finiquito_Detalle_Info item, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var info = db.ro_Acta_Finiquito_Detalle.First(v => v.IdEmpresa == item.IdEmpresa
                                && v.IdActaFiniquito == item.IdActaFiniquito 
                               
                                &&v.IdSecuencia==item.IdSecuencia);
                               info.Valor = item.Valor;
                    
                  

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, decimal idActaFiniquito,ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_Acta_Finiquito_Detalle where IdEmpresa =" + idEmpresa.ToString()
                                           
                                            + " AND IdActaFiniquito=" + idActaFiniquito.ToString()
                                           );
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
