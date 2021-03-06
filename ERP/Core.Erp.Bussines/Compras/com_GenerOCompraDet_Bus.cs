﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
namespace Core.Erp.Business
{
    public class com_GenerOCompraDet_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_GenerOCompraDet_Data Data = new com_GenerOCompraDet_Data();

        public Boolean GuardarDB(List<prd_GenerOCompra_Info> LstInfo)
        {
            try
            {
                return Data.GuardarDB(LstInfo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_GenerOCompraDet_Bus) };
            }
        
        }
        public Boolean EliminarDB(List<com_GenerOCompraDet_Info> LstInfo, ref string msg)
        {
            try
            {
                return Data.EliminarDB(LstInfo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(com_GenerOCompraDet_Bus) };
            }
        }

        public List<com_ListadoMateriales_Det_Info> Get_List_ListadoMateriales_Det(int idempresa, decimal idtrans)
        {
            try
            {
                return Data.Get_List_ListadoMateriales_Det(idempresa,  idtrans );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMateriales_Det", ex.Message), ex) { EntityType = typeof(com_GenerOCompraDet_Bus) };
            }
        }

        public List<com_ListadoMateriales_Det_Info> Get_List_ListadoMateriales_Det(int idempresa, decimal idlistadoMat, int iddetalle)
        {
            try
            {
                return Data.Get_List_ListadoMateriales_Det(idempresa, idlistadoMat, iddetalle);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoMateriales_Det", ex.Message), ex) { EntityType = typeof(com_GenerOCompraDet_Bus) };
            }
        }
       
    }
}
