using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    public class fa_cuotas_x_doc_Bus
    {
        fa_cuotas_x_doc_Data odata = new fa_cuotas_x_doc_Data();

        public List<fa_cuotas_x_doc_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool guardarDB(List<fa_cuotas_x_doc_Info> Lista)
        {
            try
            {
                return odata.guardarDB(Lista);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool eliminarDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return odata.eliminarDB(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
