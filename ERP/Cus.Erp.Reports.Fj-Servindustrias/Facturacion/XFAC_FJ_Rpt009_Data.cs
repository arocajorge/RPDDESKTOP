using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt009_Data
    {
        public List<XFAC_FJ_Rpt009_Info> get_list(int IdEmpresa, decimal IdCliente, int IdVendedor,int IdPunto_cargo_grupo, int IdPunto_cargo, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<XFAC_FJ_Rpt009_Info> Lista;

                decimal IdCliente_ini = IdCliente;
                decimal IdCliente_fin = IdCliente == 0 ? 99999 : IdCliente;

                int IdVendedor_ini = IdVendedor;
                int IdVendedor_fin = IdVendedor == 0 ? 9999 : IdVendedor;

                int IdPunto_cargo_grupo_ini = IdPunto_cargo_grupo;
                int IdPunto_cargo_grupo_fin = IdPunto_cargo_grupo == 0 ? 9999 : IdPunto_cargo_grupo;

                int IdPunto_cargo_ini = IdPunto_cargo;
                int IdPunto_cargo_fin = IdPunto_cargo == 0 ? 9999 : IdPunto_cargo;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    Lista = (from q in Context.vwFAC_FJ_Rpt009
                             where q.IdEmpresa == IdEmpresa
                             && IdCliente_ini <= q.IdCliente && q.IdCliente <= IdCliente_fin
                             && IdVendedor_ini <= q.IdVendedor && q.IdVendedor <= IdVendedor_fin
                             && IdPunto_cargo_grupo_ini <= q.IdPunto_cargo_grupo && q.IdPunto_cargo_grupo <= IdPunto_cargo_grupo_fin
                             && IdPunto_cargo_ini <= q.IdPunto_Cargo && q.IdPunto_Cargo <= IdPunto_cargo_fin
                             && Fecha_ini <= q.vt_fecha && q.vt_fecha <= Fecha_fin
                             select new XFAC_FJ_Rpt009_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdCbteVta = q.IdCbteVta,
                                 Secuencia = q.Secuencia,
                                 vt_fecha = q.vt_fecha,
                                 IdCliente = q.IdCliente,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 IdVendedor = q.IdVendedor,
                                 Ve_Vendedor = q.Ve_Vendedor,
                                 pr_descripcion = q.pr_descripcion,
                                 vt_Subtotal = q.vt_Subtotal,
                                 vt_iva = q.vt_iva,
                                 vt_total = q.vt_total,
                                 IdPunto_Cargo = q.IdPunto_Cargo,
                                 IdPunto_cargo_grupo = q.IdPunto_cargo_grupo,
                                 nom_punto_cargo = q.nom_punto_cargo == null ? "SIN PUNTO DE CARGO" : q.nom_punto_cargo,
                                 vt_NumFactura = q.vt_NumFactura,
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
