using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt013_Data
   {
       string mensaje = "";
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       
       public List<XROL_Rpt013_Info> Get_List_Vacaciones(int IdEmpresa, decimal IdEmpleado, int idsolicitud)
       {
           try
           {
               //DateTime Fi = Convert.ToDateTime(FechaInicio.ToShortDateString());
               //DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());

               List<XROL_Rpt013_Info> listado = new List<XROL_Rpt013_Info>();

               using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
               {

                   var querry = (from q in db.vwROL_Rpt013
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdEmpleado == IdEmpleado    
                                 && q.IdSolicitudVaca==idsolicitud
                                 select q); 
                   foreach (var item in querry.ToList())
                   {
                       XROL_Rpt013_Info info = new XROL_Rpt013_Info();

                       info.IdEmpresa =item.IdEmpresa;
                       info.IdEmpleado = item.IdEmpleado;
                       info.pe_apellido = item.pe_apellido+" "+item.pe_nombre;
                       info.pe_apellido_remplazo = item.pe_apellido_remplazo+" "+item.pe_nombre_remplazo;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.Anio_Desde = item.Anio_Desde;
                       info.Anio_Hasta = item.Anio_Hasta;
                       info.AnioServicio = item.AnioServicio;
                       info.Dias_a_disfrutar = item.Dias_a_disfrutar;
                       info.Dias_pendiente = item.Dias_pendiente;
                       info.Dias_q_Corresponde = item.Dias_q_Corresponde;
                       info.pe_nombre_remplazo = item.pe_nombre_remplazo;
                       info.Observacion = item.Observacion;
                       info.Anio_Desde = item.Anio_Desde;
                       info.Anio_Hasta = item.Anio_Hasta;
                       info.AnioServicio = item.AnioServicio;
                       info.Fecha_Desde = item.Fecha_Desde;
                       info.Fecha_Hasta = item.Fecha_Hasta;
                       info.Fecha_Retorno = item.Fecha_Retorno;
                       info.Fecha_Desde = item.Fecha_Desde;
                       info.Fecha_Hasta = item.Fecha_Hasta;
                       info.em_fechaIngaRol = item.em_fechaIngaRol;
                       info.IdSolicitudVaca = item.IdSolicitudVaca;
                       info.de_descripcion = item.de_descripcion;
                       info.ca_descripcion = item.ca_descripcion;
                       info.Observacion = item.Observacion;
                       if (item.Gozadas_Pgadas == true)
                       {
                           info.Gozadas_Pgadas = "Gozadas";
                       }
                       else
                       {
                           info.Gozadas_Pgadas = "Pagadas";
                       }
                       if (item.Fecha_Desde.Year == 1)
                       {

                       }
                       info.Fecha = item.Fecha;
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

     
    }
}
