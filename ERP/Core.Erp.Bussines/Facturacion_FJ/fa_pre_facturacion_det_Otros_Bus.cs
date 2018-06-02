using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_pre_facturacion_det_otros_Bus
    {
        fa_pre_facturacion_det_otros_Data oData = new fa_pre_facturacion_det_otros_Data();

        public List<fa_pre_facturacion_det_otros_Info> get_list(int IdEmpresa, decimal IdPreFacturacion)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdPreFacturacion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool guardarDB(fa_pre_facturacion_det_otros_Info info)
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

        public bool guardarDB(List<fa_pre_facturacion_det_otros_Info> Lista)
        {
            try
            {
                return oData.guardarDB(Lista);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                return oData.eliminarDB(IdEmpresa, IdPrefacturacion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
