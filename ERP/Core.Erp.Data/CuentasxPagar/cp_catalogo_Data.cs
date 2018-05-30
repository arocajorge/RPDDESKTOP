using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_catalogo_Data
    {
        string mensaje = "";
        public List<cp_catalogo_Info> Get_List_catalogo(string IdCatalogo_tipo)
        {
            try
            {
                List<cp_catalogo_Info> Lst = new List<cp_catalogo_Info>();
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    Lst = (from q in CxP.cp_catalogo
                           where q.IdCatalogo_tipo == IdCatalogo_tipo
                           select new cp_catalogo_Info
                           {
                               IdCatalogo = q.IdCatalogo,
                               IdCatalogo_tipo = q.IdCatalogo_tipo,
                               Nombre = q.Nombre,
                               Estado = q.Estado,
                               Abrebiatura = q.Abrebiatura,
                               NombreIngles = q.NombreIngles,
                               Orden = q.Orden,
                           }).ToList();

                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
