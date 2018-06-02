using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_parametro_FJ_Bus
    {
        fa_parametro_FJ_Data oData = new fa_parametro_FJ_Data();

        public fa_parametro_FJ_Info get_info(int IdEmpresa)
        {
            try
            {
                return oData.get_info(IdEmpresa);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool guardarDB(fa_parametro_FJ_Info info)
        {
            try
            {
                return oData.guardarDB(info);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
