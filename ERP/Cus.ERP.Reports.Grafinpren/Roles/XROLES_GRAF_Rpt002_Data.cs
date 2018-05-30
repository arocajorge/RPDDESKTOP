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
   public class XROLES_GRAF_Rpt002_Data
    {

       public List<XROLES_GRAF_Rpt002_Info> Get_listaNovedades(int IdEmpresa, decimal IdEmpleado, int IdLiquidacion, ref  string mensaje)
       {
           try
           {
               List<XROLES_GRAF_Rpt002_Info> Lista = new List<XROLES_GRAF_Rpt002_Info>();

               double iess = 0;
               double vacaciones = 0;
               using (EntitiesRoles_Graf Context = new EntitiesRoles_Graf())
               {
                   var selectGuia = from q in Context.vwROLES_GRAF_Rpt002
                                    where q.IdEmpresa == IdEmpresa
                                             && q.IdEmpresa == IdEmpresa
                                             && q.IdEmpleado == IdEmpleado
                                             && q.IdLiquidacion == IdLiquidacion
                                    select q;




                   foreach (var item in selectGuia)
                   {
                       XROLES_GRAF_Rpt002_Info info = new XROLES_GRAF_Rpt002_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdLiquidacion = item.IdLiquidacion;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.Nombres = item.Nombres;
                       info.Observaciones = item.Observaciones;
                       info.ValorCancelado = item.ValorCancelado;
                       info.FechaPago = item.FechaPago;
                       info.Gozadas_Pagadas = item.Gozadas_Pagadas;
                       info.Egreso = item.Valor;
                       vacaciones = item.ValorCancelado;
                       iess =Convert.ToDouble( item.Iess);
                       Lista.Add(info);
                   }


                   XROLES_GRAF_Rpt002_Info info_iess = new XROLES_GRAF_Rpt002_Info();
                   info_iess.Egreso = iess;
                   info_iess.ru_descripcion = "APORTES AL IESS";
                   Lista.Add(info_iess);


                   XROLES_GRAF_Rpt002_Info info_vacaciones = new XROLES_GRAF_Rpt002_Info();
                   info_vacaciones.Egreso = vacaciones;
                   info_iess.ru_descripcion = "VACACIONES";
                   Lista.Add(info_vacaciones);


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
