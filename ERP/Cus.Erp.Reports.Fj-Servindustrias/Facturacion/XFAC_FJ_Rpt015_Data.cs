using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_Data
    {
        public List<XFAC_FJ_Rpt015_Info> get_info(int IdEmpresa, int IdSucursal, string IdCentroCosto, decimal IdLiquidacion)
        {
            try
            {
                List<XFAC_FJ_Rpt015_Info> Lista = new List<XFAC_FJ_Rpt015_Info>();

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    var lst = from q in Context.vwFAC_FJ_Rpt015
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdCentroCosto == IdCentroCosto
                              && q.IdLiquidacion == IdLiquidacion
                              select q;

                    foreach (var item in lst)
                    {
                        XFAC_FJ_Rpt015_Info info = new XFAC_FJ_Rpt015_Info();

                        info.IdRow = item.IdRow;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdLiquidacion = item.IdLiquidacion;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.li_fecha = item.li_fecha;
                        info.IdTerminoPago = item.IdTerminoPago;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.li_num_orden = item.li_num_orden;
                        info.li_num_horas = item.li_num_horas;
                        info.li_atencion_a = item.li_atencion_a;
                        info.IdBodega = item.IdBodega;
                        info.li_tipo_pedido = item.li_tipo_pedido;
                        info.estado = item.estado;
                        info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.nom_TerminoPago = item.nom_TerminoPago;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.Centro_costo = item.Centro_costo;
                        info.codigo = item.codigo;
                        info.Su_Descripcion = item.Su_Descripcion;
                        info.cod_liquidacion = item.cod_liquidacion;
                        info.li_reporte_mantenimiento = item.li_reporte_mantenimiento;
                        info.li_subtotal = item.li_subtotal;
                        info.li_por_iva = item.li_por_iva;
                        info.li_valor_iva = item.li_valor_iva;
                        info.li_total = item.li_total;
                        info.li_observacion = item.li_observacion;
                        info.su_Direccion = item.Su_Direccion;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
