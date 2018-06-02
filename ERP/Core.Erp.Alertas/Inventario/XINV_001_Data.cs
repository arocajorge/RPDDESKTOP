using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Alertas.Inventario
{
    public class XINV_001_Data
    {
        public List<XINV_001_Info> get_list(int IdEmpresa, int IdSucursal, bool mostrar_productos_sin_alerta)
        {
            try
            {
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                string ESTADO_ALERTA = mostrar_productos_sin_alerta == false ? "ALERTA" : "";

                List<XINV_001_Info> Lista = new List<XINV_001_Info>();

                using (Entities_alerta_rpt Context = new Entities_alerta_rpt())
                {
                    Lista = (from q in Context.vwINV_Alerta_001
                             where q.IdEmpresa == IdEmpresa
                             && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                             && q.ESTADO_ALERTA.Contains(ESTADO_ALERTA)
                             select new XINV_001_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 Su_Descripcion = q.Su_Descripcion,
                                 IdProducto = q.IdProducto,
                                 pr_codigo = q.pr_codigo,
                                 pr_descripcion = q.pr_descripcion,
                                 pr_stock_minimo = q.pr_stock_minimo,
                                 stock_inventario = q.stock_inventario,
                                 stock_pendiente_ingreso = q.stock_pendiente_ingreso,
                                 stock_solicitud_sin_aprobacion = q.stock_solicitud_sin_aprobacion,
                                 ESTADO_ALERTA = q.ESTADO_ALERTA                             
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
