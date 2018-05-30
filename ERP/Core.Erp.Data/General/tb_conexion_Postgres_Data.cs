using Core.Erp.Info.General;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.General
{
    public class tb_conexion_Postgres_Data
    {
        NpgsqlConnection cnn;
        public NpgsqlConnection conectar(string Conexion, ref string mensaje)
        {
            try
            {
                mensaje = string.Empty;
                cnn = new NpgsqlConnection(Conexion);
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }


        } 
    }
}
