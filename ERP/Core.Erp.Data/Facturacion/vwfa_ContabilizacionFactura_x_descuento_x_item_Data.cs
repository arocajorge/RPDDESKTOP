using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class vwfa_ContabilizacionFactura_x_descuento_x_item_Data
    {
        public List<vwfa_ContabilizacionFactura_x_descuento_x_item_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                List<vwfa_ContabilizacionFactura_x_descuento_x_item_Info> Lista = new List<vwfa_ContabilizacionFactura_x_descuento_x_item_Info>();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_ContabilizacionFactura_x_descuento_x_item
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega
                              && q.IdCbteVta == IdCbteVta
                              select q;

                    foreach (var item in lst)
                    {
                        vwfa_ContabilizacionFactura_x_descuento_x_item_Info info = new vwfa_ContabilizacionFactura_x_descuento_x_item_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdCbteVta = item.IdCbteVta;
                        info.de_IdCtaCble = item.de_IdCtaCble;
                        info.de_valor = item.de_valor;
                        info.vt_iva = item.vt_iva;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.IdPunto_Cargo = item.IdPunto_Cargo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.vt_DescUnitario = item.vt_DescUnitario;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
