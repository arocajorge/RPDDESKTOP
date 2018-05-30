using Core.Erp.Data.General;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.General
{
    public class tb_conexion_Postgres_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_conexion_Postgres_Data da = new tb_conexion_Postgres_Data();
        public NpgsqlConnection Conexion_Postgres(ref string mensaje)
        {
            
            try
            {
                mensaje = string.Empty;
                NpgsqlConnection cc = new NpgsqlConnection();
                string Conexion = string.Empty;
                switch (param.IdCliente_Ven_x_Default)
                {
                    
                    //case Core.Erp.Info.General.Cl_Enumeradores.eCliente_Vzen.CG:
                     case Core.Erp.Info.General.Cl_Enumeradores.eCliente_Vzen.FJ:
                        Conexion = "Server=192.168.1.71;Port=5432; User Id=itcorp;Password=ITcorp123;Database =SIIS";
                        break;
                    case Core.Erp.Info.General.Cl_Enumeradores.eCliente_Vzen.CAH:
                        Conexion = "Server=192.168.100.31;Port=5432; User Id=postgres;Password=CAH@Jupiter!!;Database =cah_prueba";
                        break;
                    default:
                        break;
                }
                if (Conexion == "")
                {
                    mensaje = "La empresa no contiene cadena de conección, comuniquese con sistemas.. ";
                }
                else
                {
                    cc = da.conectar(Conexion, ref mensaje);
                    if(mensaje !="")
                        mensaje = "Error en la conección postgres, comuniquese con sistemas..";

                }
                return cc;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Conexion_Postgres", ex.Message), ex) { EntityType = typeof(tb_conexion_Postgres_Bus) };
            }
            
        }
    }
}
