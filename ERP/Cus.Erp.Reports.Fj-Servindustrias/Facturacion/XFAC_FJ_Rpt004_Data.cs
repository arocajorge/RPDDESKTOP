using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt004_Data
    {
        public List<XFAC_FJ_Rpt004_Info> get_list(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<XFAC_FJ_Rpt004_Info> Lista;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    Lista = (from q in Context.vwFAC_FJ_Rpt004
                             where q.IdEmpresa == IdEmpresa
                             && q.IdPreFacturacion == IdPrefacturacion
                             select new XFAC_FJ_Rpt004_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdPreFacturacion = q.IdPreFacturacion,
                                 Secuencia = q.Secuencia,
                                 eg_IdEmpresa = q.eg_IdEmpresa,
                                 eg_IdSucursal = q.eg_IdSucursal,
                                 eg_IdMovi_inven_tipo = q.eg_IdMovi_inven_tipo,
                                 eg_IdNumMovi = q.eg_IdNumMovi,
                                 eg_Secuencia = q.eg_Secuencia,
                                 eg_cantidad = q.eg_cantidad,
                                 eg_fecha = q.eg_fecha,
                                 eg_codigo = q.eg_codigo,
                                 in_IdEmpresa = q.in_IdEmpresa,
                                 in_IdSucursal = q.in_IdSucursal,
                                 in_IdMovi_inven_tipo = q.in_IdMovi_inven_tipo,
                                 in_IdNumMovi = q.in_IdNumMovi,
                                 in_Secuencia = q.in_Secuencia,
                                 in_cantidad = q.in_cantidad,
                                 IdProveedor = q.IdProveedor,
                                 cp_fecha = q.cp_fecha,
                                 cp_numero = q.cp_numero,
                                 IdActivoFijo = q.IdActivoFijo,
                                 costo_uni = q.costo_uni,
                                 subtotal = q.subtotal,
                                 IdProducto = q.IdProducto,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 pr_codigo = q.pr_codigo,
                                 pr_descripcion = q.pr_descripcion,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 nom_punto_cargo = q.nom_punto_cargo,
                                 Centro_costo = q.Centro_costo
                             }).ToList();
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
