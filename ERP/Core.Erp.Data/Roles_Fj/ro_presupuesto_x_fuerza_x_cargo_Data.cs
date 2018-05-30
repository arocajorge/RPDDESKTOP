using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles_Fj;


namespace Core.Erp.Data.Roles_Fj
{
    public class ro_presupuesto_x_fuerza_x_cargo_Data
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";
        public Boolean GrabarBD(ro_presupuesto_x_fuerza_x_cargo_Info info, ref string msg)
        {
            try
            {
                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var contact = (from a in db.ro_presupuesto_x_fuerza_x_cargo
                                   where a.IdEmpresa == info.IdEmpresa
                                   && a.IdNomina == info.IdNomina
                                   && a.IdFuerza == info.IdFuerza
                                   && a.Anio == info.Anio
                                   && a.Mes == info.Mes
                                   && a.IdCargo==info.IdCargo
                                   select a).FirstOrDefault();
                    if (contact != null)
                    {
                        contact.CantidadEmpleados = info.CantidadEmpleados;
                        contact.Presupuesto = info.Presupuesto;
                        contact.Observacion = info.Observacion;
                        contact.diasEfectivos = info.diasEfectivos;
                        contact.Dias_SyD_y_Feriado = info.Dias_SyD_y_Feriado;
                        contact.BaseVariable = info.BaseVariable;
                        db.SaveChanges();
                    }

                    else
                    {
                        ro_presupuesto_x_fuerza_x_cargo add = new ro_presupuesto_x_fuerza_x_cargo();

                        add.IdEmpresa = info.IdEmpresa;
                        add.IdNomina = info.IdNomina;
                        add.Anio = info.Anio;
                        add.Mes = info.Mes;
                        add.IdFuerza = info.IdFuerza;
                        add.IdCargo = info.IdCargo;
                        add.Presupuesto = info.Presupuesto;
                        add.Observacion = info.Observacion;
                        add.CantidadEmpleados = info.CantidadEmpleados;
                        add.diasEfectivos = info.diasEfectivos;
                        add.Dias_SyD_y_Feriado = info.Dias_SyD_y_Feriado;
                        add.BaseVariable = info.BaseVariable;

                        db.ro_presupuesto_x_fuerza_x_cargo.Add(add);
                        db.SaveChanges();

                    }




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

        public List<ro_presupuesto_x_fuerza_x_cargo_Info> GetPresupuesto(int IdEmpresa, int idnomina, int anio, int mes)
        {
            try
            {
                List<ro_presupuesto_x_fuerza_x_cargo_Info> lista = new List<ro_presupuesto_x_fuerza_x_cargo_Info>();

                using (EntityRoles_FJ contact = new EntityRoles_FJ())
                {


                    var sel = (from s in contact.ro_presupuesto_x_fuerza_x_cargo
                               where s.IdEmpresa == IdEmpresa
                               && s.IdNomina==idnomina
                               && s.Anio==anio
                               && s.Mes==mes
                               select s);


                    foreach (var item in sel)
                    {
                        ro_presupuesto_x_fuerza_x_cargo_Info add = new ro_presupuesto_x_fuerza_x_cargo_Info();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdNomina = item.IdNomina;
                        add.Anio = item.Anio;
                        add.Mes = item.Mes;
                        add.IdFuerza = item.IdFuerza;
                        add.IdCargo = item.IdCargo;
                        add.CantidadEmpleados = item.CantidadEmpleados;
                        add.Presupuesto = item.Presupuesto;
                        add.Observacion = item.Observacion;
                        add.diasEfectivos = item.diasEfectivos;
                        add.Dias_SyD_y_Feriado = item.Dias_SyD_y_Feriado;
                        add.BaseVariable = item.BaseVariable;


                        lista.Add(add);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<ro_presupuesto_x_fuerza_x_cargo_Info> GetPresupuesto(int IdEmpresa,int anio,int mes)
        {
            try
            {
                List<ro_presupuesto_x_fuerza_x_cargo_Info> lista = new List<ro_presupuesto_x_fuerza_x_cargo_Info>();

                using (EntityRoles_FJ contact = new EntityRoles_FJ())
                {


                    var sel = (from s in contact.vwro_presupuesto_x_fuerza_x_cargo
                               where s.IdEmpresa == IdEmpresa
                               && s.Anio==anio
                               && s.Mes==mes
                               
                               select s);


                    foreach (var item in sel)
                    {
                        ro_presupuesto_x_fuerza_x_cargo_Info add = new ro_presupuesto_x_fuerza_x_cargo_Info();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdNomina = item.IdNomina;
                        add.Anio = item.Anio;
                        add.Mes = item.Mes;
                        add.IdFuerza = item.IdFuerza;
                        add.IdCargo = item.IdCargo;
                        add.CantidadEmpleados = item.CantidadEmpleados;
                        add.Presupuesto = item.Presupuesto;
                        add.Observacion = item.Observacion;
                        add.diasEfectivos = item.diasEfectivos;
                        add.Dias_SyD_y_Feriado = item.Dias_SyD_y_Feriado;
                        add.BaseVariable = item.BaseVariable;
                        add.IdCentroCosto = item.IdCentroCosto;
                        add.IdSuccentroCosto = item.IdSuccentroCosto;
                        lista.Add(add);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


    }
}
