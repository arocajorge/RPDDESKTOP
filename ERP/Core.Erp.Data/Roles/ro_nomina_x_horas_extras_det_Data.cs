using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;
using System.Data.OleDb;

namespace Core.Erp.Data.Roles
{
   public class ro_nomina_x_horas_extras_det_Data
    {
        private string mensaje = "";

        public List<ro_nomina_x_horas_extras_det_Info> Get_List_Nomina_X_Horas_Extras(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {
            try
            {
                List<ro_nomina_x_horas_extras_det_Info> oListado = new List<ro_nomina_x_horas_extras_det_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwro_nomina_x_horas_extras_det
                                 where a.IdEmpresa == idEmpresa
                                 //&& a.IdNominaTipo == idNominaTipo
                                 //&& a.IdNominaTipoLiqui == idNominaTipoLiqui
                                 //&& a.IdPeriodo == idPeriodo
                                 orderby a.pe_apellido ascending
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_nomina_x_horas_extras_det_Info item = new ro_nomina_x_horas_extras_det_Info();

                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        //item.IdNominaTipo = info.IdNominaTipo;
                        //item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        //item.IdPeriodo = info.IdPeriodo;
                        item.IdCalendario = info.IdCalendario;
                        item.IdTurno = info.IdTurno;
                        item.IdHorario = info.IdHorario;

                        item.FechaRegistro = info.FechaRegistro;
                        item.time_entrada1 = info.time_entrada1;
                        item.time_entrada2 = info.time_entrada2;
                        item.time_salida1 = info.time_salida1;
                        item.time_salida2 = info.time_salida2;
                        item.hora_extra25 = info.hora_extra25;
                        item.hora_extra50 = info.hora_extra50;
                        item.hora_extra100 = info.hora_extra100;
                        item.hora_atraso = info.hora_atraso;
                        item.hora_temprano = info.hora_temprano;
                        item.hora_trabajada = info.hora_trabajada;
                        //VISTA
                        item.pe_nombreCompleto = info.pe_apellido + " " + info.pe_nombre;
                        item.pe_cedulaRuc = info.pe_cedulaRuc;
                        item.ca_descripcion = info.ca_descripcion;
                        item.tu_descripcion = info.tu_descripcion;

                        item.es_HorasExtrasAutorizadas = info.es_HorasExtrasAutorizadas;


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

      
        public Boolean GetExiste(ro_nomina_x_horas_extras_det_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_nomina_x_horas_extras_det
                                where a.IdEmpresa == info.IdEmpresa
                                && a.IdEmpleado == info.IdEmpleado
                                && a.IdCalendario == info.IdCalendario
                                && a.IdTurno == info.IdTurno
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


        public Boolean GuardarBD(ro_nomina_x_horas_extras_det_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_nomina_x_horas_extras_det item = new ro_nomina_x_horas_extras_det();

                    item.IdEmpresa = info.IdEmpresa;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdCalendario = info.IdCalendario;
                    item.IdTurno = Convert.ToInt32(info.IdTurno);
                    item.IdHorario = (info.IdHorario == 0 ? 1 : info.IdHorario);

                    item.FechaRegistro = info.FechaRegistro;
                    item.time_entrada1 = info.time_entrada1;
                    item.time_entrada2 = info.time_entrada2;
                    item.time_salida1 = info.time_salida1;
                    item.time_salida2 = info.time_salida2;

                    item.hora_extra25 = info.hora_extra25;
                    item.hora_extra50 = info.hora_extra50;
                    item.hora_extra100 = info.hora_extra100;
                    item.hora_atraso = info.hora_atraso;
                    item.hora_temprano = info.hora_temprano;
                    item.hora_trabajada = info.hora_trabajada;


                    db.ro_nomina_x_horas_extras_det.Add(item);
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


        public Boolean ModificarBD(ro_nomina_x_horas_extras_det_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_nomina_x_horas_extras_det item = (from a in db.ro_nomina_x_horas_extras_det
                                                         where a.IdEmpresa == info.IdEmpresa
                                                         && a.IdEmpleado == info.IdEmpleado
                                                         && a.IdCalendario == info.IdCalendario
                                                         && a.IdTurno == info.IdTurno
                                                         select a).FirstOrDefault();

                    item.FechaRegistro = info.FechaRegistro;
                    item.time_entrada1 = info.time_entrada1;
                    item.time_entrada2 = info.time_entrada2;
                    item.time_salida1 = info.time_salida1;
                    item.time_salida2 = info.time_salida2;
                    item.hora_extra25 = info.hora_extra25;
                    item.hora_extra50 = info.hora_extra50;
                    item.hora_extra100 = info.hora_extra100;
                    item.hora_atraso = info.hora_atraso;
                    item.hora_temprano = info.hora_temprano;
                    item.hora_trabajada = info.hora_trabajada;


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

        public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo, decimal idEmpleado, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_nomina_x_horas_extras where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNomina_Tipo=" + idNomina.ToString()
                       + " AND IdNomina_TipoLiqui=" + idNominaLiqui.ToString()
                       + " AND IdPeriodo=" + idPeriodo.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                       );
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

        public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_nomina_x_horas_extras where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNominaTipo=" + idNomina.ToString()
                       + " AND IdNominaTipoLiqui=" + idNominaLiqui.ToString()
                       + " AND IdPeriodo=" + idPeriodo.ToString()

                       );
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
        public List<ro_nomina_x_horas_extras_det_Info> Get_List_Nomina_X_Horas_Extras(int idEmpresa)
        {
            try
            {
                List<ro_nomina_x_horas_extras_det_Info> Lista;

                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    Lista = (from he in Context.ro_nomina_x_horas_extras
                             join n in Context.ro_Nomina_Tipo
                             on he.IdEmpresa equals n.IdEmpresa
                             join nt in Context.ro_Nomina_Tipoliqui
                             on new { n.IdEmpresa, n.IdNomina_Tipo } equals new { nt.IdEmpresa, nt.IdNomina_Tipo }
                             join pn in Context.ro_periodo_x_ro_Nomina_TipoLiqui
                             on new { nt.IdEmpresa, nt.IdNomina_Tipo, nt.IdNomina_TipoLiqui } equals new { pn.IdEmpresa, pn.IdNomina_Tipo, pn.IdNomina_TipoLiqui }
                             join p in Context.ro_periodo
                             on new { pn.IdEmpresa, pn.IdPeriodo } equals new { p.IdEmpresa, p.IdPeriodo }
                             where he.IdEmpresa == idEmpresa
                             && pn.IdNomina_Tipo == he.IdNominaTipo
                             && pn.IdNomina_TipoLiqui == he.IdNominaTipoLiqui
                             && pn.IdPeriodo == he.IdPeriodo
                             select new ro_nomina_x_horas_extras_det_Info
                             {
                                 IdEmpresa = he.IdEmpresa,
                                 IdHorasExtras = he.IdHorasExtras
                                



                             }).ToList();

                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
