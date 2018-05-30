using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
   public class ro_Acta_Finiquito_Detalle_x_vacaciones_Data
   {
       public bool Guardar_DB(ro_Acta_Finiquito_Detalle_x_vacaciones_Info info)
       {
           try
           {
               using (EntitiesRoles db = new EntitiesRoles())
               {
                   ro_Acta_Finiquito_Detalle_x_vacaciones add = new ro_Acta_Finiquito_Detalle_x_vacaciones();
                   add.IdEmpresa = info.IdEmpresa;
                   add.IdNominatipo = info.IdNominatipo;
                   add.IdEmpleado = info.IdEmpleado;
                   add.IdLiquidacion = info.IdLiquidacion;
                   add.Anio = info.Anio;
                   add.Mes = info.Mes;
                   add.Total_Remuneracion = info.Total_Remuneracion;
                   add.Total_Vacaciones = info.Total_Vacaciones;
                   add.Valor_Cancelar = info.Total_Vacaciones;
                   add.Sec = info.Sec;
                   add.DiasTrabajados = info.DiasTrabajados;
                   db.ro_Acta_Finiquito_Detalle_x_vacaciones.Add(add);
                   db.SaveChanges();
                   return true;
               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);

               throw new Exception(ex.ToString());
           }
       }

       public bool Eliminar(ro_Acta_Finiquito_Detalle_x_vacaciones_Info info)
       {
           string mensaje = "";
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   db.Database.ExecuteSqlCommand(" delete ro_Acta_Finiquito_Detalle_x_vacaciones where IdEmpresa='" + info.IdEmpresa + "'  and IdNominatipo='" + info.IdNominatipo + "'  and IdEmpleado='" + info.IdEmpleado + "'  and IdLiquidacion ='" + info.IdLiquidacion + "'");
                   return true;
               }
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

       public List<ro_Acta_Finiquito_Detalle_x_vacaciones_Info> Get_Lis(int IdEmpresa, int idempleado, int idsolicitud)
       {
           List<ro_Acta_Finiquito_Detalle_x_vacaciones_Info> Lst = new List<ro_Acta_Finiquito_Detalle_x_vacaciones_Info>();
           EntitiesRoles oEnti = new EntitiesRoles();
           try
           {
               var Query = from q in oEnti.ro_Acta_Finiquito_Detalle_x_vacaciones
                           where q.IdEmpresa == IdEmpresa
                           && q.IdEmpleado == idempleado
                           && q.IdLiquidacion == idsolicitud
                           select q;
               foreach (var item in Query)
               {

                   ro_Acta_Finiquito_Detalle_x_vacaciones_Info add = new ro_Acta_Finiquito_Detalle_x_vacaciones_Info();
                   add.IdEmpresa = item.IdEmpresa;
                   add.IdNominatipo = item.IdNominatipo;
                   add.IdEmpleado = item.IdEmpleado;
                   add.IdLiquidacion = item.IdLiquidacion;
                   add.Anio = item.Anio;
                   add.Mes = item.Mes;
                   add.Total_Remuneracion = item.Total_Remuneracion;
                   add.Total_Vacaciones = item.Total_Vacaciones;
                   add.Valor_Cancelar = item.Valor_Cancelar;
                   add.DiasTrabajados = item.DiasTrabajados;

                   Lst.Add(add);
               }
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               throw new Exception(ex.ToString());
           }

       }

    }
}
