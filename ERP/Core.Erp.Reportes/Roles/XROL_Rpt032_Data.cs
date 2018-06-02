using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt032_Data
   {
       string mensaje = "";
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       
       public List<XROL_Rpt032_Info> Get_List_Vacaciones(int IdEmpresa, decimal IdEmpleado, int idsolicitud)
       {
           try
           {
               int secuencia = 0;
              
               List<XROL_Rpt032_Info> listado = new List<XROL_Rpt032_Info>();

               using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
               {

                   var querry = (from q in db.vwROL_Rpt032
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdEmpleado == IdEmpleado    
                                 && q.IdActaFiniquito==idsolicitud
                                 select q); 
                   foreach (var item in querry.ToList())
                   {
                       secuencia++;
                       XROL_Rpt032_Info info = new XROL_Rpt032_Info();

                       info.IdEmpresa =item.IdEmpresa;
                       info.IdActaFiniquito=item.IdActaFiniquito;
                       info.IdEmpleado = item.IdEmpleado;
                       info.pe_apellido = item.pe_apellido+" "+item.pe_nombre;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.FechaIngreso = item.FechaIngreso;
                       info.FechaSalida = item.FechaSalida;
                       info.UltimaRemuneracion = item.UltimaRemuneracion;
                       info.Observacion = item.Observacion;
                       info.Ingresos = item.Ingresos;
                       info.Egresos = item.Egresos;
                       info.Observacion = item.Observacion;


                        info.ca_descripcion = item.ca_descripcion;
                       info.Anio = item.Anio;
                       info.Mes = item.Mes;
                       info.Total_Remuneracion = item.Total_Remuneracion;
                       info.Total_Vacaciones = item.Decimo;

                       info.Cargo = item.Cargo;
                       info.de_descripcion = item.de_descripcion;
                       info.DiasTrabajados = item.DiasTrabajados;
                       info.ob = item.ob;

                       listado.Add(info);
                   }

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


       private String DevolverMes(int mes_)
       {
           try
           {

               string Nombre_mes = "";
               switch (mes_)
               {
                   case 01:
                       Nombre_mes = "ENERO";
                       break;
                   case 02:
                       Nombre_mes = "FEBRERO";
                       break;
                   case 03:
                       Nombre_mes = "MARZO";
                       break;
                   case 04:
                       Nombre_mes = "ABRIL";
                       break;
                   case 05:
                       Nombre_mes = "MAYO";
                       break;
                   case 06:
                       Nombre_mes = "JUNIO";
                       break;
                   case 07:
                       Nombre_mes = "JULIO";
                       break;
                   case 08:
                       Nombre_mes = "AGOSTO";
                       break;
                   case 09:
                       Nombre_mes = "SEPTIEMBRE";
                       break;
                   case 10:
                       Nombre_mes = "OCTUBRE";
                       break;
                   case 11:
                       Nombre_mes = "NOVIEMBRE";
                       break;
                   case 12:
                       Nombre_mes = "DICIEMBRE";
                       break;
                   default:
                       break;
               }


               return Nombre_mes;
           }
           catch (Exception)
           {

               return "";
           }
       }
    }
}
