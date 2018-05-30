using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cus.ERP.Reports.Grafinpren.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Cus.ERP.Reports.Grafinpren.Roles
{
   public class XROLES_GRAF_Rpt001_Data
    {


       public List<XROLES_GRAF_Rpt001_Info> Get_lisaVacaciones_x_mes(int IdEmpresa, decimal IdEmpleado, int IdLiquidacion, string mensaje)
       {
           try
           {
               List<XROLES_GRAF_Rpt001_Info> Lista = new List<XROLES_GRAF_Rpt001_Info>();
               using (EntitiesRoles_Graf Context = new EntitiesRoles_Graf())
               {
                   var selectGuia = from q in Context.vwROLES_GRAF_Rpt001
                                    where q.IdEmpresa == IdEmpresa
                                             && q.IdEmpresa == IdEmpresa
                                             && q.IdEmpleado == IdEmpleado
                                             && q.IdLiquidacion == IdLiquidacion
                                    select q;


                   foreach (var item in selectGuia)
                   {
                       XROLES_GRAF_Rpt001_Info info = new XROLES_GRAF_Rpt001_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdLiquidacion = item.IdLiquidacion;
                       info.IdCargo = item.IdCargo;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.Nombres = item.Nombres;
                       info.ca_descripcion = item.ca_descripcion;
                       info.Observaciones = item.Observaciones;
                       info.ValorCancelado = item.ValorCancelado;
                       info.FechaPago = item.FechaPago;
                       info.Gozadas_Pagadas = item.Gozadas_Pagadas;
                       info.Total_Remuneracion = item.Total_Remuneracion;
                       info.Total_Vacaciones = item.Total_Vacaciones;
                       info.Valor_Cancelar = item.Valor_Cancelar;

                       Lista.Add(info);
                   }
               }
               return Lista;
           }
           catch (Exception ex)
           {
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
  
  
    }
}
