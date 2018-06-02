

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Parametros_Data
    {
        string mensaje = "";
        public  ro_Parametros_Info GetInfo(int IdEmpresa)
        {
            try
            {
                ro_Parametros_Info info = new ro_Parametros_Info();

                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    ro_Parametros q = Context.ro_Parametros.FirstOrDefault(v => v.IdEmpresa == IdEmpresa);
                    if (q == null) return null;

                    info = new ro_Parametros_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdTipoCbte_AsientoSueldoXPagar = q.IdTipoCbte_AsientoSueldoXPagar,
                        GeneraOP_PagoPrestamos = q.GeneraOP_PagoPrestamos,
                        IdTipoOP_PagoPrestamos = q.IdTipoOP_PagoPrestamos,
                        IdFormaOP_PagoPrestamos = q.IdFormaOP_PagoPrestamos,
                        GeneraOP_LiquidacionVacaciones = q.GeneraOP_LiquidacionVacaciones,
                        IdTipoOP_LiquidacionVacaciones = q.IdTipoOP_LiquidacionVacaciones,
                        IdTipoFlujoOP_LiquidacionVacaciones = q.IdTipoFlujoOP_LiquidacionVacaciones,
                        IdFormaOP_LiquidacionVacaciones = q.IdFormaOP_LiquidacionVacaciones,
                        DescuentaIESS_LiquidacionVacaciones = q.DescuentaIESS_LiquidacionVacaciones,
                        cta_contable_IESS_Vacaciones = q.cta_contable_IESS_Vacaciones,
                        GeneraOP_ActaFiniquito = q.GeneraOP_ActaFiniquito,
                        IdTipoOP_ActaFiniquito = q.IdTipoOP_ActaFiniquito,
                        IdFormaPagoOP_ActaFiniquito = q.IdFormaPagoOP_ActaFiniquito,
                        Sueldo_basico = q.Sueldo_basico,
                        Porcentaje_aporte_patr = q.Porcentaje_aporte_patr,
                        Porcentaje_aporte_pers = q.Porcentaje_aporte_pers,
                        IdRubro_acta_finiquito = q.IdRubro_acta_finiquito,
                    };
                }

                return info;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ro_Parametros_Info> Get_list(int IdEmpresa)
        {
            List<ro_Parametros_Info> lst = new List<ro_Parametros_Info>();
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_Parametros
                                 where a.IdEmpresa == IdEmpresa
                                 select a);

                    foreach (var item in datos)
                    {
                        ro_Parametros_Info info = new ro_Parametros_Info();
                        info.IdTipoCbte_AsientoSueldoXPagar = Convert.ToInt32(item.IdTipoCbte_AsientoSueldoXPagar);                      
                        info.GeneraOP_PagoPrestamos = item.GeneraOP_PagoPrestamos;
                        info.IdFormaOP_PagoPrestamos = item.IdFormaOP_PagoPrestamos;
                        info.IdTipoOP_PagoPrestamos = item.IdTipoOP_PagoPrestamos;
                        info.GeneraOP_ActaFiniquito = item.GeneraOP_ActaFiniquito;
                        info.IdFormaPagoOP_ActaFiniquito = item.IdFormaPagoOP_ActaFiniquito;
                        info.IdTipoOP_ActaFiniquito = item.IdTipoOP_ActaFiniquito;
                        info.DescuentaIESS_LiquidacionVacaciones = item.DescuentaIESS_LiquidacionVacaciones;
                        info.GeneraOP_LiquidacionVacaciones = item.GeneraOP_LiquidacionVacaciones;
                        info.IdFormaOP_LiquidacionVacaciones = item.IdFormaOP_LiquidacionVacaciones;
                        info.IdTipoFlujoOP_LiquidacionVacaciones = item.IdTipoFlujoOP_LiquidacionVacaciones;
                        info.IdTipoOP_LiquidacionVacaciones = item.IdTipoOP_LiquidacionVacaciones;
                        info.cta_contable_IESS_Vacaciones = item.cta_contable_IESS_Vacaciones;
                        lst.Add(info);
                    }



                }

                return lst;
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
      
        public Boolean grabarSBasico(int idempresa, double Sbasico)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Parametros.First(A => A.IdEmpresa == idempresa);
                    context.SaveChanges();
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

        public Boolean GrabarBD(ro_Parametros_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var contact = (from a in db.ro_Parametros
                                       where a.IdEmpresa==info.IdEmpresa
                                       select a).FirstOrDefault();
                    if (contact != null)
                    {
                       
                        contact.IdTipoCbte_AsientoSueldoXPagar = info.IdTipoCbte_AsientoSueldoXPagar;

                       
                      

                        contact.GeneraOP_PagoPrestamos = info.GeneraOP_PagoPrestamos;
                        contact.IdFormaOP_PagoPrestamos = info.IdFormaOP_PagoPrestamos;
                        contact.IdTipoOP_PagoPrestamos = info.IdTipoOP_PagoPrestamos;



                        contact.DescuentaIESS_LiquidacionVacaciones = info.DescuentaIESS_LiquidacionVacaciones;
                        contact.GeneraOP_LiquidacionVacaciones = info.GeneraOP_LiquidacionVacaciones;
                        contact.IdFormaOP_LiquidacionVacaciones = info.IdFormaOP_LiquidacionVacaciones;
                        contact.IdTipoFlujoOP_LiquidacionVacaciones = info.IdTipoFlujoOP_LiquidacionVacaciones;
                        contact.IdTipoOP_LiquidacionVacaciones = info.IdTipoOP_LiquidacionVacaciones;
                        contact.cta_contable_IESS_Vacaciones = info.cta_contable_IESS_Vacaciones;

                        contact.GeneraOP_ActaFiniquito = info.GeneraOP_ActaFiniquito;
                        contact.IdFormaPagoOP_ActaFiniquito = info.IdFormaPagoOP_ActaFiniquito;
                        contact.IdTipoOP_ActaFiniquito = info.IdTipoOP_ActaFiniquito;



                        db.SaveChanges();
                    }

                    else
                    {
                        ro_Parametros add = new ro_Parametros();
                        add.IdEmpresa = info.IdEmpresa;
                        
                        add.IdTipoCbte_AsientoSueldoXPagar = info.IdTipoCbte_AsientoSueldoXPagar;

                        
                     



                        add.GeneraOP_PagoPrestamos = info.GeneraOP_PagoPrestamos;
                        add.IdFormaOP_PagoPrestamos = info.IdFormaOP_PagoPrestamos;
                        add.IdTipoOP_PagoPrestamos = info.IdTipoOP_PagoPrestamos;

                        add.DescuentaIESS_LiquidacionVacaciones = info.DescuentaIESS_LiquidacionVacaciones;
                        add.GeneraOP_LiquidacionVacaciones = info.GeneraOP_LiquidacionVacaciones;
                        add.IdFormaOP_LiquidacionVacaciones = info.IdFormaOP_LiquidacionVacaciones;
                        add.IdTipoFlujoOP_LiquidacionVacaciones = info.IdTipoFlujoOP_LiquidacionVacaciones;
                        add.IdTipoOP_LiquidacionVacaciones = info.IdTipoOP_LiquidacionVacaciones;
                        add.cta_contable_IESS_Vacaciones = info.cta_contable_IESS_Vacaciones; 




                        db.ro_Parametros.Add(add);
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
    }
}
