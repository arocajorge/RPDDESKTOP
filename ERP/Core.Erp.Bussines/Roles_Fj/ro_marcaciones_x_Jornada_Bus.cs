using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
namespace Core.Erp.Business.Roles_Fj
{
   public class ro_marcaciones_x_Jornada_Bus
   {
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       ro_Parametro_calculo_Horas_Extras_Bus bus_parametros_calculo_horas_extras = new ro_Parametro_calculo_Horas_Extras_Bus();
       ro_Parametro_calculo_Horas_Extras_Info info_parametro = new ro_Parametro_calculo_Horas_Extras_Info();
     
       TimeSpan inicioHora25 = TimeSpan.FromHours(19); //19:00 PM
       TimeSpan finalHora25 = TimeSpan.FromHours(6); //06:00 AM
       //HORAS EXTRAS 50
       TimeSpan inicioHora50 = TimeSpan.FromHours(6); //06:00 AM
       TimeSpan finalHora50 = TimeSpan.FromHours(24); //24:00 PM
       //HORAS EXTRAS 100
       TimeSpan inicioHora100 = TimeSpan.FromHours(0); //00:00 PM
       TimeSpan finalHora100 = TimeSpan.FromHours(6); //06:00 AM


       double Horas_25 = 0;
       double Horas_50 = 0;
       double Horas_100 = 0;
       decimal IdEmpleado = 0;
       DateTime fecha_pago = new DateTime();
       String Nombre = "";
       String Cedula = "";
       int horas = 0;
       int minutos = 0;
       TimeSpan es_hora;
       double Horas_tmp = 0;

       public List<ro_Nomina_X_Horas_Extras_Info> lista_nomina_x_horas_Hextras = new List<Info.Roles.ro_Nomina_X_Horas_Extras_Info>();
       public List<ro_marcaciones_x_Jornada_Info> Get_list_Horas_Extras(List<ro_marcaciones_x_Jornada_Info> lista, double Suel_Actual)
       {
           try
           {
               
               info_parametro = bus_parametros_calculo_horas_extras.Get_info(param.IdEmpresa);
               List<ro_marcaciones_x_Jornada_Info> lista_horas_extras_25_50_100 = new List<ro_marcaciones_x_Jornada_Info>();
             
               // recorro las marcaciones y sumo las horas extras del 25%, 50%, 100%
               foreach (var item in lista)
               {


                  

                   Horas_25 = 0; Horas_50 = 0; Horas_100 = 0; horas = 0; minutos = 0; Horas_tmp = 0;
                   es_hora = new TimeSpan();
                   IdEmpleado = item.IdEmpleado;
                   fecha_pago = Convert.ToDateTime(item.es_fechaRegistro);
                   Nombre = item.pe_NombreCompleto;
                   Cedula = item.pe_cedula;
                   int dia_Semana = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                   if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours == 0)// si tiene una sola jornada le resto la hora de almuerzo
                   {
                       if (dia_Semana == 6 || dia_Semana == 0 ||item.EsFeriado=="S")
                       {
                           if (item.es_tot_horasTrabajadas >= 1)
                           {
                               if (item.es_tot_horasTrabajadas >= 9)
                               {
                                   item.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas - 1;
                               }
                               else
                               {
                                   item.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas;
                               }

                           }
                       }
                       else
                       {
                           item.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas - 1;
                           horas = ((TimeSpan)item.es_Hora_ingreso_jornada1).Hours;
                           minutos = ((TimeSpan)item.es_Hora_ingreso_jornada1).Minutes;
                           item.es_Hora_ingreso_jornada1 = new TimeSpan(horas, minutos, 0);
                       }
                   }
                   if (dia_Semana == 6 || dia_Semana == 0 || item.EsFeriado == "S")// sumo las horas trabajadas al 100% correspondiente al sabado y domingo
                   {
                      
                       Horas_100 =  item.es_tot_horasTrabajadas;                      
                   }
                   else
                   {
                       if (item.es_tot_horasTrabajadas >= 0)// si trabajo mas de ocho horas
                       {
                           #region Horas al 100% de 00:00 a 06:00
                           if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours == 0)//si trabajo una sola jornada y tiene horas al 100% de 00:00 a 06:00
                           {
                               if (
                                   (item.es_Hora_ingreso_jornada1 > inicioHora100 && item.es_Hora_ingreso_jornada1 < finalHora100) ||
                                   (item.es_Hora_salida_jornada1 > inicioHora100 && item.es_Hora_salida_jornada1 < finalHora100) ||
                                   (item.es_Hora_ingreso_jornada1 > inicioHora100 && item.es_Hora_ingreso_jornada1 > finalHora100
                                   && ((TimeSpan)item.es_Hora_ingreso_jornada1).Hours > 12)



                                   )
                               {
                                   if (item.es_tot_horasTrabajadas > 8)
                                       Horas_100 = Get_Horas_100_x_dia(item);// calculo de horas al 100%

                               }

                               else
                               {




                               }
                           }
                           else//si trabajo dos jornada y tiene horas al 100% de 00:00 a 06:00
                           {

                               if (
                                    ((TimeSpan)item.es_Hora_salida_jornada2).TotalHours >= inicioHora100.TotalHours
                                   && ((TimeSpan)item.es_Hora_ingreso_jornada2).TotalHours >= inicioHora100.TotalHours)
                               {
                                   Horas_100 = Get_Horas_100_x_dia_con_dos_jornadas(item);// calculo de horas al 100%
                               }

                           }



                           #endregion
                           #region Horas al 50% de 18:00 a 24:00

                           if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours == 0)// tiene horas al 50% de 06:00h a 24:00h en una sola jornada 
                           {
                               if ((item.es_Hora_ingreso_jornada1 > inicioHora50 && item.es_Hora_ingreso_jornada1 < finalHora50) ||
                                  (item.es_Hora_salida_jornada1 > inicioHora50 && item.es_Hora_salida_jornada1 < finalHora50) ||
                                  (item.es_Hora_ingreso_jornada1 > inicioHora50 && item.es_Hora_ingreso_jornada1 > finalHora50)
                                  )
                               {
                                   if (item.es_tot_horasTrabajadas > 8)
                                   Horas_50 = Get_Horas_50_x_dia(item);// calculo de horas al 50%

                               }
                           }
                           else// si tiene horas al 50% y trabajo dos jornadas
                           {
                               if (((item.es_Hora_ingreso_jornada1 > inicioHora50 && item.es_Hora_ingreso_jornada1 < finalHora50) ||
                                         (item.es_Hora_salida_jornada1 > inicioHora50 && item.es_Hora_salida_jornada1 < finalHora50) ||
                                         (item.es_Hora_ingreso_jornada1 > inicioHora50 && item.es_Hora_ingreso_jornada1 > finalHora50))
                                   ||
                                         ((item.es_Hora_ingreso_jornada2 > inicioHora50 && item.es_Hora_ingreso_jornada2 < finalHora50) ||
                                         (item.es_Hora_salida_jornada2 > inicioHora50 && item.es_Hora_salida_jornada2 < finalHora50) ||
                                         (item.es_Hora_ingreso_jornada2 > inicioHora50 && item.es_Hora_ingreso_jornada2 > finalHora50))
                                   )
                               {
                                   if (item.es_tot_horasTrabajadas > 8)
                                   Horas_50 = Get_Horas_50_x_dia_con_dos_jornadas(item);// calculo de horas al 50% con doble jornada
                               }
                           }
                           #endregion
                           #region Horas al 25% de 19:00 a 06:00
                           if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours == 0)// tiene horas al 25% de 19:00h a 06:00h en una sola jornada
                           { // tiene horas al 25% de 19:00h a 06:00h en la jornada 1

                               if ((item.es_Hora_ingreso_jornada1 >= inicioHora25 && item.es_Hora_ingreso_jornada1 <= finalHora25) ||
                                  (item.es_Hora_salida_jornada1 >= inicioHora25 && item.es_Hora_salida_jornada1 <= finalHora25) ||
                                  (item.es_Hora_ingreso_jornada1 >= inicioHora25 && item.es_Hora_ingreso_jornada1 >= finalHora25) ||
                                   (item.es_Hora_ingreso_jornada1 <= inicioHora25 && item.es_Hora_ingreso_jornada1 >= finalHora25 && ((TimeSpan)item.es_Hora_ingreso_jornada1).Hours > 12)

                                  )
                               {
                                   if (((TimeSpan)item.es_Hora_ingreso_jornada1).Hours > 0)
                                   {
                                       if (item.pe_cedula == "0803134915")
                                       {
                                       }
                                       if(dia_Semana!=6 && dia_Semana!=7)
                                       Horas_25 = Get_Horas_25_x_dia(item); // calculo de horas al 25%
                                   }
                               }
                           }
                           else
                           {




                               if ((item.es_Hora_ingreso_jornada2 >= inicioHora25 && item.es_Hora_ingreso_jornada2 <= finalHora25) ||
                                     (item.es_Hora_salida_jornada2 >= inicioHora25 && item.es_Hora_salida_jornada2 <= finalHora25) ||
                                     (item.es_Hora_ingreso_jornada2 >= inicioHora25 && item.es_Hora_ingreso_jornada2 >= finalHora25) ||
                                      (item.es_Hora_ingreso_jornada2 <= inicioHora25 && item.es_Hora_ingreso_jornada2 >= finalHora25 && ((TimeSpan)item.es_Hora_ingreso_jornada2).Hours > 12)

                                     )
                               {
                                   if (((TimeSpan)item.es_Hora_ingreso_jornada2).Hours > 0)
                                   {

                                       if (dia_Semana != 6 && dia_Semana != 7)
                                           Horas_25 = Get_Horas_25_x_dia(item); // calculo de horas al 25%
                                   }
                               }




                           }
                           #endregion


                       }
                   }

                   if (Horas_50 < 0)
                       Horas_50 = Horas_50 * -1;


                   // creo las novedades
                   if (info_parametro.Se_calcula_horas_Extras_al100 == true || info_parametro.Se_calcula_horas_Extras_al50 == true || info_parametro.Se_calcula_horas_Extras_al25 == true)
                   {
                       if (Horas_100 > 0 || Horas_25 > 0 || Horas_50 > 0)// si es que tiene horas al 100%
                       {
                           ro_marcaciones_x_Jornada_Info info_horas_extras = new ro_marcaciones_x_Jornada_Info();
                           info_horas_extras.IdEmpresa = param.IdEmpresa;
                           info_horas_extras.IdEmpleado = IdEmpleado;
                           info_horas_extras.pe_NombreCompleto = Nombre;
                           info_horas_extras.em_cedula = Cedula;
                           info_horas_extras.secuencia = 1;
                           info_horas_extras.IdRubro = "9";
                           info_horas_extras.FechaPago = fecha_pago;
                           info_horas_extras.Sueldo_Actual = Suel_Actual;
                           info_horas_extras.Calculo_Horas_extras_Sobre = item.grupo.Calculo_Horas_extras_Sobre;

                           // HORAS SOBRETIEMPO 100
                           if (Horas_100 > 0)
                           {
                               if (item.grupo.Calculo_Horas_extras_Sobre > 0)
                               {
                                   info_horas_extras.Valor_100 = Math.Round(Horas_100 * ((Suel_Actual / item.grupo.Calculo_Horas_extras_Sobre) * 2), 2);
                               }
                               else
                               {
                                   info_horas_extras.Valor_100 = Math.Round(Horas_100 * ((Suel_Actual / 160) * 2), 2);

                               }
                           }

                           // HORAS SOBRETIEMPO 50
                           if (Horas_50 > 0)
                           {
                               if (item.grupo.Calculo_Horas_extras_Sobre > 0)
                               {
                                   info_horas_extras.Valor_50 = Math.Round(Horas_50 * ((Suel_Actual / item.grupo.Calculo_Horas_extras_Sobre) * 1.5), 2);
                               }
                               else
                               {
                                   info_horas_extras.Valor_50 = Math.Round(Horas_50 * ((Suel_Actual / 160) * 0.5), 2);

                               }
                           }
                           if (Horas_25 > 0)
                           {
                               // HORAS SOBRETIEMPO 25
                               if (item.grupo.Calculo_Horas_extras_Sobre > 0)
                               {
                                   info_horas_extras.Valor_25 = Math.Round(Horas_25 * ((Suel_Actual / item.grupo.Calculo_Horas_extras_Sobre) * 0.25), 2);
                               }
                               else
                               {
                                   info_horas_extras.Valor_25 = Math.Round(Horas_25 * ((Suel_Actual / 160) * 0.25), 2);

                               }
                           }
                           if (item.es_tot_horasTrabajadas > 0)
                           {

                               info_horas_extras.Horas_100 = Horas_100;
                               info_horas_extras.Horas_50 = Horas_50;
                               info_horas_extras.Horas_25 = Horas_25;
                           }
                           else
                           {

                               if (dia_Semana == 6 || dia_Semana == 0 || item.EsFeriado == "S")
                               {
                                   info_horas_extras.Horas_100 = Horas_100;
                                   info_horas_extras.Horas_50 = Horas_50;
                                   info_horas_extras.Horas_25 = Horas_25;


                               }
                               else
                               {
                                   info_horas_extras.Horas_100 = 0;
                                   info_horas_extras.Horas_50 = 0;
                                   info_horas_extras.Horas_25 = 0;
                               }
                           }
                           info_horas_extras.Observacion = "Horas extras correspondiente al " + fecha_pago.Month.ToString().PadLeft(2, '0') + "/" + fecha_pago.Year;
                           info_horas_extras.es_Hora_ingreso_jornada1 = item.es_Hora_ingreso_jornada1;
                           info_horas_extras.es_Hora_ingreso_jornada2 = item.es_Hora_ingreso_jornada2;
                           info_horas_extras.es_Hora_salida_jornada1 = item.es_Hora_salida_jornada1;
                           info_horas_extras.es_Hora_salida_jornada2 = item.es_Hora_salida_jornada2;
                           if (item.es_Fech_remplazo != null)
                           {
                               info_horas_extras.es_Fech_remplazo =Convert.ToDateTime( item.es_Fech_remplazo);
                           }
                           info_horas_extras.es_tot_horasTrabajadas = item.es_tot_horasTrabajadas;
                           info_horas_extras.cargo = item.cargo;
                           info_horas_extras.departamento = item.departamento;
                           lista_horas_extras_25_50_100.Add(info_horas_extras);

                       }
                   }
                  
                   


               }

             


               return lista_horas_extras_25_50_100;

               
           }
           catch (Exception )
           {

               return new List<ro_marcaciones_x_Jornada_Info>();
           }
       }
       private double Get_Horas_25_x_dia(ro_marcaciones_x_Jornada_Info info)
       {

           try
           {
               if (info.pe_cedula == "0803134915")
               {
               }
               if (((TimeSpan)info.es_Hora_ingreso_jornada1).Hours > 0 && ((TimeSpan)info.es_Hora_ingreso_jornada2).Hours > 0)
                   return 0;



               Horas_tmp = 0;
               horas = 0;
               minutos = 0;
               horas = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Hours);
               minutos = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Minutes);
               horas = horas + 8;     
               es_hora = new TimeSpan(horas, minutos, 0);
               if (((TimeSpan)info.es_Hora_ingreso_jornada1).Hours >= 19)// si ingreso des pues de las siete
               {
                   es_hora = new TimeSpan(horas, minutos, 0);
                   Horas_tmp = (es_hora -(TimeSpan) info.es_Hora_ingreso_jornada1).TotalHours;
               }
               else
               {                   
                   Horas_tmp = (es_hora - inicioHora25).TotalHours;
               }
               if (Horas_tmp < 0)
               {
                   Horas_tmp = Horas_tmp * -1;
               }

               return Horas_tmp;

              

           }
           catch (Exception ex)
           {

               return 0;
           }
       }
       private double Get_Horas_50_x_dia(ro_marcaciones_x_Jornada_Info info)
       {

           try
           {
               if (info.pe_cedula == "0803060433")
               {
               }
              
               Horas_tmp = 0;
               horas = 0;
               minutos = 0;

               horas = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Hours);
               if (horas > 1 && horas < 6)
               {
                 
                   Horas_tmp = info.es_tot_horasTrabajadas - 8;
                   return Horas_tmp;
               }

               if (((TimeSpan)info.es_Hora_ingreso_jornada1).Hours <= 24 && ((TimeSpan)info.es_Hora_salida_jornada1).Hours <= 8)
               {
                   if (((TimeSpan)info.es_Hora_salida_jornada1).Hours > 0 
                       && ((TimeSpan)info.es_Hora_salida_jornada1).Hours < 6 
                       && ((TimeSpan)info.es_Hora_ingreso_jornada1).Hours >= 15)
                   {
                       Horas_tmp = 0;
                   }
                   else
                   {
                       Horas_tmp = ((TimeSpan)info.es_Hora_salida_jornada1 - inicioHora50).TotalHours;
                   }
                
               }
               else
               {
                 
                   horas = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Hours);
                   minutos = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Minutes);
                   horas = horas + 8;
                   if (horas > 24)
                   {
                       horas = horas - 24;
                   }
                   es_hora = new TimeSpan(horas, minutos, 0);
                   Horas_tmp = ((TimeSpan)info.es_Hora_salida_jornada1 - es_hora).TotalHours;
                   Horas_tmp = Horas_tmp - 1;
               }
               return Horas_tmp ;
           }
           catch (Exception ex)
           {

               return 0;
           }
       }
       private double Get_Horas_50_x_dia_con_dos_jornadas(ro_marcaciones_x_Jornada_Info info)
      {

           try
           {

               double totaHoras=0;
               if (info.es_tot_horasTrabajadas <= 8)
                   return 0;

               double Hora_j1=0;
               double Hora_j2 = 0;
               Horas_tmp = 0;
              double horasI = 0;
              double horasS = 0;
              double horas_aux = 0;
              TimeSpan finalhoras_5 = TimeSpan.FromHours(24);
               minutos = 0;
              
               // primera jornada

               horasS = ((TimeSpan)(info.es_Hora_salida_jornada1)).Hours;
               horasI = ((TimeSpan)(info.es_Hora_ingreso_jornada1)).Hours;

                if (horasI > horasS)
               {
                   horas_aux = ((TimeSpan)(finalhoras_5 - (TimeSpan)info.es_Hora_ingreso_jornada1)).TotalHours;
                   horas_aux = horas_aux + ((TimeSpan)((TimeSpan)info.es_Hora_salida_jornada1) - TimeSpan.FromDays(0)).TotalHours;
                   Hora_j1 = horas_aux;
               }
                else
                {
               Hora_j1 = ((TimeSpan)(info.es_Hora_salida_jornada1 - (TimeSpan)info.es_Hora_ingreso_jornada1) ).TotalHours;

               }
              
              // segunda jornada

               horasS = ((TimeSpan)(info.es_Hora_salida_jornada2)).Hours;
               horasI = ((TimeSpan)(info.es_Hora_ingreso_jornada2)).Hours;
               if (horasI > horasS)
               {
                   horas_aux = 0;
                   horas_aux = ((TimeSpan)(finalhoras_5 - (TimeSpan)info.es_Hora_ingreso_jornada2)).TotalHours;
                   horas_aux = horas_aux + ((TimeSpan)((TimeSpan)info.es_Hora_salida_jornada2)-TimeSpan.FromDays(0)).TotalHours;
                   Hora_j2 = horas_aux;


               }
                else
               {
                   Hora_j2 = ((TimeSpan)(info.es_Hora_salida_jornada2 - (TimeSpan)info.es_Hora_ingreso_jornada2)).TotalHours;
               }

               totaHoras = Hora_j1 + Hora_j2;
               if (totaHoras >= 9
                   && ((TimeSpan)info.es_Hora_salida_jornada2).TotalHours >= inicioHora100.TotalHours
                   && ((TimeSpan)info.es_Hora_ingreso_jornada2).TotalHours >= inicioHora100.TotalHours)
               {

                   Horas_tmp = (Hora_j1 + Hora_j2) - 8 - ((TimeSpan)info.es_Hora_salida_jornada2).TotalHours;
               }
               else
               {
                   Horas_tmp = (Hora_j1 + Hora_j2) - 8;
               }

             
              
               return Horas_tmp;
           }
           catch (Exception ex)
           {

               return 0;
           }
       }
       private double Get_Horas_100_x_dia(ro_marcaciones_x_Jornada_Info info)
       {

           try
           {
               Horas_tmp = 0;
               horas = 0;
               minutos = 0;
               if (info.pe_cedula == "1205205006")
               {
               }
            


               if (info.es_tot_horasTrabajadas <= 8)
                   return 0;

               horas = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).TotalHours);
               if (horas > 1 && horas < 6)
                   return 0;
               horas = horas + 8;
               if (horas >= 24)
               {
                   horas = horas - 24;
               }
               minutos = Convert.ToInt32(((TimeSpan)(info.es_Hora_ingreso_jornada1)).Minutes);
               es_hora = new TimeSpan(horas, minutos, 0);
               Horas_tmp = (es_hora - finalHora100).TotalHours;
               if (((TimeSpan)info.es_Hora_salida_jornada1).TotalHours < finalHora100.TotalHours)
               {
                   if ( ((TimeSpan)info.es_Hora_salida_jornada1).Hours > inicioHora100.Hours &&   ((TimeSpan)info.es_Hora_salida_jornada1).Hours > finalHora100.Hours)
                   {
                       Horas_tmp = ((TimeSpan)info.es_Hora_salida_jornada1).TotalHours - inicioHora100.Hours;
                   }
                   else
                   {

                       Horas_tmp = horas - ((TimeSpan)info.es_Hora_salida_jornada1).TotalHours;
                       if (Horas_tmp < 0)
                           Horas_tmp = Horas_tmp * -1;
                       Horas_tmp = Horas_tmp - 1;
                   }
               }
               else
               {
                   if (((TimeSpan)info.es_Hora_salida_jornada1).TotalHours >= finalHora100.TotalHours)
                   {
                       if (info.es_tot_horasTrabajadas <= 8)
                       {
                           Horas_tmp = 0;
                       }
                       else
                       {
                           if (Horas_tmp < 0)
                               Horas_tmp = Horas_tmp * -1;
                           Horas_tmp = Horas_tmp - 1;
                       }
                   }
                   else

                   Horas_tmp = horas - finalHora100.TotalHours;
               }
               if (Horas_tmp < 0)
               {
                Horas_tmp = Horas_tmp * -1;
               }
               return Horas_tmp;

           }
           catch (Exception ex)
           {

              return 0;
           }
       }

       private double Get_Horas_100_x_dia_con_dos_jornadas(ro_marcaciones_x_Jornada_Info info)
       {

           try
           {

               double totaHoras = 0;
               if (info.es_tot_horasTrabajadas <= 8)
                   return 0;

               double Hora_j1 = 0;
               double Hora_j2 = 0;
               Horas_tmp = 0;
               double horasI = 0;
               double horasS = 0;
               double horas_aux = 0;
               TimeSpan finalhoras_5 = TimeSpan.FromHours(24);
               minutos = 0;

               // primera jornada

               horasS = ((TimeSpan)(info.es_Hora_salida_jornada1)).Hours;
               horasI = ((TimeSpan)(info.es_Hora_ingreso_jornada1)).Hours;

               if (horasI > horasS)
               {
                   horas_aux = ((TimeSpan)(finalhoras_5 - (TimeSpan)info.es_Hora_ingreso_jornada1)).TotalHours;
                   horas_aux = horas_aux + ((TimeSpan)((TimeSpan)info.es_Hora_salida_jornada1) - TimeSpan.FromDays(0)).TotalHours;
                   Hora_j1 = horas_aux;
               }
               else
               {
                   Hora_j1 = ((TimeSpan)(info.es_Hora_salida_jornada1 - (TimeSpan)info.es_Hora_ingreso_jornada1)).TotalHours;

               }

               // segunda jornada

               horasS = ((TimeSpan)(info.es_Hora_salida_jornada2)).Hours;
               horasI = ((TimeSpan)(info.es_Hora_ingreso_jornada2)).Hours;
               if (horasI > horasS)
               {
                   horas_aux = 0;
                   horas_aux = ((TimeSpan)(finalhoras_5 - (TimeSpan)info.es_Hora_ingreso_jornada2)).TotalHours;
                   horas_aux = horas_aux + ((TimeSpan)((TimeSpan)info.es_Hora_salida_jornada2) - TimeSpan.FromDays(0)).TotalHours;
                   Hora_j2 = horas_aux;


               }
               else
               {
                   Hora_j2 = ((TimeSpan)(info.es_Hora_salida_jornada2 - (TimeSpan)info.es_Hora_ingreso_jornada2)).TotalHours;
               }

               totaHoras = Hora_j1 + Hora_j2;
               if (totaHoras >= 9
                   && ((TimeSpan)info.es_Hora_salida_jornada2).TotalHours >= inicioHora100.TotalHours
                   && ((TimeSpan)info.es_Hora_ingreso_jornada2).TotalHours >= inicioHora100.TotalHours)
               {

                   Horas_tmp = ((TimeSpan)info.es_Hora_salida_jornada2).TotalHours;
               }
               else
               {
                   Horas_tmp = (Hora_j1 + Hora_j2) - 8;
               }



               return Horas_tmp;
           }
           catch (Exception ex)
           {

               return 0;
           }
       }
     
       public List<ro_marcaciones_x_empleado_Info> Get_List_Marcaciones(List<ro_marcaciones_x_Jornada_Info> lista, int IdPeriodo)
       {
           try
           {
               int secuencia = 0;
               tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
               tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();
               List<ro_marcaciones_x_empleado_Info> lista_marcaciones = new List<ro_marcaciones_x_empleado_Info>();
               foreach (var item in lista)
               {
                   InfoCalendario = Bus_Calendario.Get_Info_Calendario(Convert.ToDateTime(item.es_fechaRegistro));                            

                   ro_marcaciones_x_empleado_Info info;
                   if ( ((TimeSpan) item.es_Hora_ingreso_jornada1).Hours>0)// ingreso primera jornada
                   {
                       secuencia = secuencia + 1;
                       info = new Info.Roles.ro_marcaciones_x_empleado_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdNomina_Tipo = item.Id_nomina_Tipo;
                      // info.IdRegistro = "IN1-"+Convert.ToDateTime(item.es_fechaRegistro).Day.ToString()+"/" + Convert.ToDateTime(item.es_fechaRegistro).Month.ToString()+"/"+ Convert.ToDateTime(item.es_fechaRegistro).Year.ToString()  ;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdTipoMarcaciones = "IN1";
                       info.secuencia = secuencia;
                       info.es_Hora = item.es_Hora_ingreso_jornada1;
                       info.es_fechaRegistro = item.es_fechaRegistro;
                       info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                       info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                       info.es_semana = InfoCalendario.Semana_x_anio;
                       info.es_sdia = InfoCalendario.NombreDia;
                       info.es_idDia = (int) Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                       info.es_dia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek; 
                       info.es_EsActualizacion = "N";
                       info.IdTipoMarcaciones_Biometrico = "IN1";
                       info.Observacion = "Importadas por proceso del sistema";
                       info.Estado = "A";
                       info.IdUsuario = param.IdUsuario;
                       info.Fecha_Transac = DateTime.Now;
                       info.IdPeriodo = IdPeriodo;
                       lista_marcaciones.Add(info);

                   }



                   if ( ((TimeSpan) item.es_Hora_salida_jornada1).Hours>0)// ingreso primera jornada
                   {
                       secuencia = secuencia + 1;
                       info = new Info.Roles.ro_marcaciones_x_empleado_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdNomina_Tipo = item.Id_nomina_Tipo;
                      // info.IdRegistro = "OUT1-" + Convert.ToDateTime(item.es_fechaRegistro).Day.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Month.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Year.ToString();
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdTipoMarcaciones = "OUT1";
                       info.secuencia = secuencia;
                       info.es_Hora = item.es_Hora_salida_jornada1;
                       info.es_fechaRegistro = item.es_fechaRegistro;
                       info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                       info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                       info.es_semana = InfoCalendario.Semana_x_anio;
                       info.es_sdia = InfoCalendario.NombreDia;
                       info.es_idDia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                       info.es_dia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek; 
                       info.es_EsActualizacion = "N";
                       info.IdTipoMarcaciones_Biometrico = "OUT1";
                       info.Observacion = "Importadas por proceso del sistema";
                       info.Estado = "A";
                       info.IdUsuario = param.IdUsuario;
                       info.Fecha_Transac = DateTime.Now;
                       info.IdPeriodo = IdPeriodo;
                       lista_marcaciones.Add(info);

                   }









                   if ( ((TimeSpan) item.es_Hora_ingreso_jornada2).Hours>0)// ingreso primera jornada
                   {
                       secuencia = secuencia + 1;
                       info = new Info.Roles.ro_marcaciones_x_empleado_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdNomina_Tipo = item.Id_nomina_Tipo;
                     //  info.IdRegistro = "IN2-" + Convert.ToDateTime(item.es_fechaRegistro).Day.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Month.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Year.ToString();
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdTipoMarcaciones = "IN2";
                       info.secuencia = secuencia;
                       info.es_Hora = item.es_Hora_ingreso_jornada2;
                       info.es_fechaRegistro = item.es_fechaRegistro;
                       info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                       info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                       info.es_semana = InfoCalendario.Semana_x_anio;
                       info.es_sdia = InfoCalendario.NombreDia;
                       info.es_idDia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                       info.es_dia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek; 
                       info.es_EsActualizacion = "N";
                       info.IdTipoMarcaciones_Biometrico = "IN2";
                       info.Observacion = "Importadas por proceso del sistema";
                       info.Estado = "A";
                       info.IdUsuario = param.IdUsuario;
                       info.Fecha_Transac = DateTime.Now;
                       info.IdPeriodo = IdPeriodo;
                       lista_marcaciones.Add(info);

                   }



                      if ( ((TimeSpan) item.es_Hora_salida_jornada2).Hours>0)// ingreso primera jornada
                       {
                       secuencia = secuencia + 1;
                       info = new Info.Roles.ro_marcaciones_x_empleado_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdNomina_Tipo = item.Id_nomina_Tipo;
                      // info.IdRegistro = "OUT2-" + Convert.ToDateTime(item.es_fechaRegistro).Day.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Month.ToString() + "/" + Convert.ToDateTime(item.es_fechaRegistro).Year.ToString();
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdTipoMarcaciones = "OUT2";
                       info.secuencia = secuencia;
                       info.es_Hora = item.es_Hora_salida_jornada2;
                       info.es_fechaRegistro = item.es_fechaRegistro;
                       info.es_anio = Convert.ToDateTime(item.es_fechaRegistro).Year;
                       info.es_mes = Convert.ToDateTime(item.es_fechaRegistro).Month;
                       info.es_semana = InfoCalendario.Semana_x_anio;
                       info.es_sdia = InfoCalendario.NombreDia;
                       info.es_idDia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek;
                       info.es_dia = (int)Convert.ToDateTime(item.es_fechaRegistro).DayOfWeek; 
                       info.es_EsActualizacion = "N";
                       info.IdTipoMarcaciones_Biometrico = "OUT2";
                       info.Observacion = "Importadas por proceso del sistema";
                       info.Estado = "A";
                       info.IdUsuario = param.IdUsuario;
                       info.Fecha_Transac = DateTime.Now;
                       info.IdPeriodo = IdPeriodo;
                       lista_marcaciones.Add(info);

                   }

               }

               return lista_marcaciones;
           }
           catch (Exception ex)
           {
               
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Marcaciones", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_Jornada_Bus) };

           }
       }
       public List<ro_Nomina_X_Horas_Extras_Info> get_nomina_x_Horas_Extras()
       {
           try
           {
               return lista_nomina_x_horas_Hextras;
           }
           catch (Exception ex)
           {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_nomina_x_Horas_Extras", ex.Message), ex) { EntityType = typeof(ro_marcaciones_x_Jornada_Bus) };

           }
       }
   
   }
}
