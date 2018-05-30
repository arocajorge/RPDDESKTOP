using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
   public class fa_pre_facturacion_mano_obra_servindustria_Bus
   {
       fa_pre_facturacion_mano_obra_servindustria_Data oData = new fa_pre_facturacion_mano_obra_servindustria_Data();

       public List<fa_pre_facturacion_mano_obra_servindustria_Info> GetList(int idEmpresa, int IdPeriodo)
       {
           try
           {
               return oData.GetList_historico(idEmpresa, IdPeriodo);
           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }

       public bool GuardarDB(List<fa_pre_facturacion_mano_obra_servindustria_Info> Lst_Info)
       {
           try
           {
              
                   oData.GuardarDB(Lst_Info);
               
               return true;
           }

           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }

       public bool EliminarDB(int IdEmpresa, int IdPeriodo, decimal IdPrefacturacion)
       {
           try
           {
               return oData.EliminarDB(IdEmpresa, IdPeriodo, IdPrefacturacion);
           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
    }
}
