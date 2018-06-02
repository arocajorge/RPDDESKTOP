
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Roles
{
    public class ro_Participacion_Utilidad_Data
    {
        private string mensaje = "";

        public List<ro_Participacion_Utilidad_Info> GetListGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                List<ro_Participacion_Utilidad_Info> oListado = new List<ro_Participacion_Utilidad_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwro_participacion_utilidad
                                 where a.IdEmpresa == idEmpresa                               
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Participacion_Utilidad_Info item = new ro_Participacion_Utilidad_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNomina = info.IdNomina;
                        item.IdNominaTipo_liq = info.IdNominaTipo_liq;
                        item.IdUtilidad = info.IdUtilidad;
                        item.IdPeriodo = info.IdPeriodo;
                        item.UtilidadDerechoIndividual = info.UtilidadDerechoIndividual;
                        item.UtilidadCargaFamiliar = info.UtilidadCargaFamiliar;
                        item.pe_FechaIni = info.pe_FechaIni;
                        item.pe_FechaFin = info.pe_FechaFin;
                        item.Cerrado = info.Cerrado;
                        item.Procesado = info.Procesado;
                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public ro_Participacion_Utilidad_Info GetInfoPorIdPeriodo(int idEmpresa, int idPeriodo, ref string msg)
        {
            try
            {
                ro_Participacion_Utilidad_Info item = new ro_Participacion_Utilidad_Info();
              
                using (EntitiesRoles db = new EntitiesRoles())
                {
                       ro_participacion_utilidad info = (from a in db.ro_participacion_utilidad
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdPeriodo == idPeriodo
                                 select a).FirstOrDefault();


                       item.IdEmpresa = info.IdEmpresa;
                       item.IdNomina = info.IdNomina;
                       item.IdNominaTipo_liq = info.IdNominaTipo_liq;
                       item.IdUtilidad = info.IdUtilidad;
                       item.IdPeriodo = info.IdPeriodo;
                       item.UtilidadDerechoIndividual = info.UtilidadDerechoIndividual;
                       item.UtilidadCargaFamiliar = info.UtilidadCargaFamiliar;
                       item.LimiteDistribucionUtilidad = info.LimiteDistribucionUtilidad;
                       item.FechaIngresa = info.FechaIngresa;
                       item.UsuarioIngresa = info.UsuarioIngresa;
                       item.Observacion = info.Observacion;
                  
                }
                return item;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean GetExiste(ro_Participacion_Utilidad_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_participacion_utilidad
                                where a.IdEmpresa == info.IdEmpresa
                                && a.IdPeriodo == info.IdPeriodo
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean GuardarBD(ro_Participacion_Utilidad_Info info,ref int IdUtilidad, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_participacion_utilidad item = new ro_participacion_utilidad();
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdNomina = info.IdNomina;
                    item.IdNominaTipo_liq = info.IdNominaTipo_liq;
                    item.IdUtilidad =getId(info.IdEmpresa);
                    item.IdPeriodo = info.IdPeriodo;
                    item.UtilidadDerechoIndividual = info.UtilidadDerechoIndividual;
                    item.UtilidadCargaFamiliar = info.UtilidadCargaFamiliar;
                    item.LimiteDistribucionUtilidad = info.LimiteDistribucionUtilidad;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;
                    item.Observacion = info.Observacion;
                    db.ro_participacion_utilidad.Add(item);
                    db.SaveChanges();
                    IdUtilidad = item.IdUtilidad;
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }



        public Boolean ModificarBD(ro_Participacion_Utilidad_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_participacion_utilidad item = (from a in db.ro_participacion_utilidad
                                                          where a.IdEmpresa==info.IdEmpresa
                                                          && a.IdUtilidad==info.IdUtilidad
                                                          select a).FirstOrDefault();
                    item.IdNomina = info.IdNomina;
                    item.IdNominaTipo_liq = info.IdNomina;
                    item.IdPeriodo = info.IdPeriodo;
                    item.UtilidadDerechoIndividual = info.UtilidadDerechoIndividual;
                    item.UtilidadCargaFamiliar = info.UtilidadCargaFamiliar;
                    item.LimiteDistribucionUtilidad = info.LimiteDistribucionUtilidad;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_participacion_utilidad
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_participacion_utilidad
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdUtilidad).Max();

                    Id = Convert.ToInt32(select_em) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public List<ro_Participacion_Utilidad_Empleado_Info> Get_nomina_x_utilidades(int idEmpresa, int IdNomina_Tipo, DateTime FechaInicio, DateTime FechaFin)
        {
            List<ro_Participacion_Utilidad_Empleado_Info> oListadoInfo = new List<ro_Participacion_Utilidad_Empleado_Info>();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var select = (from a in db.vwro_empleadoXdepXcargo
                                  where a.IdEmpresa == idEmpresa
                                  && a.IdNomina_Tipo == IdNomina_Tipo
                                   && a.em_fechaIngaRol < FechaFin
                                  && a.considera_pago_utilidad == true
                                  && (a.em_fechaSalida == null
                                  || a.em_fechaSalida > FechaInicio)
                                  select a
                                    );

                    foreach (var item in select)
                    {
                        ro_Participacion_Utilidad_Empleado_Info info = new ro_Participacion_Utilidad_Empleado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.em_fechaTerminoContra = item.em_fechaTerminoContra;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.NomCompleto = item.Apellido + " " + item.Nombre;                        
                        info.em_status = item.em_status;
                        oListadoInfo.Add(info);
                    }

                }

                return (oListadoInfo);
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
