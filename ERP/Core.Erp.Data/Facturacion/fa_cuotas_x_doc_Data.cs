using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_cuotas_x_doc_Data
    {
        public List<fa_cuotas_x_doc_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                List<fa_cuotas_x_doc_Info> Lista;

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    Lista = (from q in Context.fa_cuotas_x_doc
                             where q.IdEmpresa == IdEmpresa
                             && q.IdSucursal == IdSucursal
                             && q.IdBodega == IdBodega
                             && q.IdCbteVta == IdCbteVta
                             select new fa_cuotas_x_doc_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdCbteVta = q.IdCbteVta,
                                 secuencia = q.secuencia,
                                 num_cuota = q.num_cuota,
                                 fecha_vcto_cuota = q.fecha_vcto_cuota,
                                 valor_a_cobrar = q.valor_a_cobrar,
                                 Estado = q.Estado,
                             }).ToList();   
                }

                return Lista;
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
                int secuencia = 1;
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    foreach (var item in Lista)
                    {
                        fa_cuotas_x_doc Entity = new fa_cuotas_x_doc
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdSucursal = item.IdSucursal,
                            IdBodega = item.IdBodega,
                            IdCbteVta = item.IdCbteVta,
                            secuencia = item.secuencia = secuencia++,
                            num_cuota = item.num_cuota,
                            fecha_vcto_cuota = item.fecha_vcto_cuota,
                            valor_a_cobrar = item.valor_a_cobrar,
                            Estado = item.Estado,
                        };
                        Context.fa_cuotas_x_doc.Add(Entity);
                    }
                    Context.SaveChanges();
                }

                return true;
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
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    int rows = Context.Database.ExecuteSqlCommand("DELETE fa_cuotas_x_doc WHERE IdEmpresa = "+IdEmpresa+" AND IdSucursal = "+IdSucursal + " AND IdBodega = "+IdBodega+" AND IdCbteVta = "+IdCbteVta);
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
