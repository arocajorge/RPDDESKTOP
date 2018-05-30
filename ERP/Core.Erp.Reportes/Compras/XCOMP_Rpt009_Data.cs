using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt009_Data
    {
        public List<XCOMP_Rpt009_Info> get_list(int IdEmpresa, int IdSucursal, decimal IdSolicitante, DateTime Fecha_ini, DateTime Fecha_fin, decimal IdProducto)
        {
            try
            {
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                decimal IdSolicitante_ini = IdSolicitante;
                decimal IdSolicitante_fin = IdSolicitante == 0 ? 99999 : IdSolicitante;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                List<XCOMP_Rpt009_Info> Lista;

                using (EntitiesCompra_reporte_Ge Context = new EntitiesCompra_reporte_Ge())
                {
                    if(IdProducto == 0)
                    Lista = (from q in Context.vwCOMP_Rpt009
                             where IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                             && IdSolicitante_ini <= q.IdSolicitante && q.IdSolicitante<= IdSolicitante_fin
                              && Fecha_ini <= q.fecha_sol && q.fecha_sol <= Fecha_fin
                             select new XCOMP_Rpt009_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdSolicitudCompra = q.IdSolicitudCompra,
                                 Secuencia = q.Secuencia,
                                 fecha_sol = q.fecha_sol,
                                 IdSolicitante = q.IdSolicitante,
                                 nom_solicitante = q.nom_solicitante,
                                 pr_codigo = q.pr_codigo,
                                 IdProducto = q.IdProducto,
                                 nom_producto = q.nom_producto,
                                 cantidad_sol = q.cantidad_sol,
                                 IdPunto_cargo = q.IdPunto_cargo,
                                 nom_punto_cargo = q.nom_punto_cargo,
                                 ocd_IdEmpresa = q.ocd_IdEmpresa,
                                 ocd_IdSucursal = q.ocd_IdSucursal,
                                 ocd_IdOrdenCompra = q.ocd_IdOrdenCompra,
                                 ocd_Secuencia = q.ocd_Secuencia,
                                 IdProveedor = q.IdProveedor,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 fecha_oc = q.fecha_oc,
                                 cantidad_com = q.cantidad_com,
                                 do_precioCompra = q.do_precioCompra,
                                 fecha_inv = q.fecha_inv,
                                 cantidad_inv = q.cantidad_inv,
                             }).ToList();
                    else
                    Lista = (from q in Context.vwCOMP_Rpt009
                             where IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                             && IdSolicitante_ini <= q.IdSolicitante && q.IdSolicitante <= IdSolicitante_fin
                              && Fecha_ini <= q.fecha_sol && q.fecha_sol <= Fecha_fin
                              && q.IdProducto == IdProducto
                             select new XCOMP_Rpt009_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdSolicitudCompra = q.IdSolicitudCompra,
                                 Secuencia = q.Secuencia,
                                 fecha_sol = q.fecha_sol,
                                 IdSolicitante = q.IdSolicitante,
                                 nom_solicitante = q.nom_solicitante,
                                 pr_codigo = q.pr_codigo,
                                 IdProducto = q.IdProducto,
                                 nom_producto = q.nom_producto,
                                 cantidad_sol = q.cantidad_sol,
                                 IdPunto_cargo = q.IdPunto_cargo,
                                 nom_punto_cargo = q.nom_punto_cargo,
                                 ocd_IdEmpresa = q.ocd_IdEmpresa,
                                 ocd_IdSucursal = q.ocd_IdSucursal,
                                 ocd_IdOrdenCompra = q.ocd_IdOrdenCompra,
                                 ocd_Secuencia = q.ocd_Secuencia,
                                 IdProveedor = q.IdProveedor,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 fecha_oc = q.fecha_oc,
                                 cantidad_com = q.cantidad_com,
                                 do_precioCompra = q.do_precioCompra,
                                 fecha_inv = q.fecha_inv,
                                 cantidad_inv = q.cantidad_inv,
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
