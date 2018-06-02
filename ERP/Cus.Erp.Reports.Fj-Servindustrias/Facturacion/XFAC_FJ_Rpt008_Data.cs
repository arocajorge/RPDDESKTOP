using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt008_Data
    {
        public List<XFAC_FJ_Rpt008_Info> get_list(int IdEmpresa, decimal IdCliente, int IdVendedor, decimal IdTransportista, int IdPunto_cargo, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<XFAC_FJ_Rpt008_Info> Lista;
                decimal IdCliente_ini = IdCliente;
                decimal IdCliente_fin = IdCliente == 0 ? 99999 : IdCliente;

                int IdVendedor_ini = IdVendedor;
                int IdVendedor_fin = IdVendedor == 0 ? 9999 : IdVendedor;

                decimal IdTransportista_ini = IdTransportista;
                decimal IdTransportista_fin = IdTransportista == 0 ? 99999 : IdTransportista;

                int IdPunto_cargo_ini = IdPunto_cargo;
                int IdPunto_cargo_fin = IdPunto_cargo == 0 ? 9999 : IdPunto_cargo;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
                {
                    Lista = (from q in Context.vwFAC_FJ_Rpt008
                             where IdEmpresa == q.IdEmpresa && IdCliente_ini <= q.IdCliente && q.IdCliente <= IdCliente_fin
                             && IdVendedor_ini <= q.IdVendedor && q.IdVendedor <= IdVendedor_fin
                             && IdTransportista_ini <= q.IdTransportista && q.IdTransportista <= IdTransportista_fin
                             && IdPunto_cargo_ini <= q.IdPunto_cargo && q.IdPunto_cargo <= IdPunto_cargo_fin
                             && Fecha_ini <= q.Fecha && q.Fecha <= Fecha_fin
                             select new XFAC_FJ_Rpt008_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdOrdenTrabajo_Pla = q.IdOrdenTrabajo_Pla,
                                 IdCliente = q.IdCliente,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 IdVendedor = q.IdVendedor,
                                 Ve_Vendedor = q.Ve_Vendedor,
                                 IdTransportista = q.IdTransportista,
                                 Nombre = q.Nombre,
                                 IdPunto_cargo = q.IdPunto_cargo,
                                 nom_punto_cargo = q.nom_punto_cargo,
                                 Fecha = q.Fecha,
                                 Descripcion = q.Descripcion,
                                 km_salida = q.km_salida,
                                 km_llegada = q.km_llegada,
                                 Valor = q.Valor
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
