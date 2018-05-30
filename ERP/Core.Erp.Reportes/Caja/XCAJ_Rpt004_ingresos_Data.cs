using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt004_ingresos_Data
    {
        public List<XCAJ_Rpt004_ingresos_Info> get_list(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                List<XCAJ_Rpt004_ingresos_Info> Lista;

                using (EntitiesCaja_General Context = new EntitiesCaja_General())
                {
                    Lista = (from q in Context.vwCAJ_Rpt004_ingresos
                             where q.IdEmpresa == IdEmpresa
                             && q.IdConciliacion_Caja == IdConciliacion
                             select new XCAJ_Rpt004_ingresos_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdConciliacion_Caja = q.IdConciliacion_Caja,
                                 IdTipocbte = q.IdTipocbte,
                                 IdCbteCble = q.IdCbteCble,
                                 valor_disponible = q.valor_disponible,
                                 valor_aplicado = q.valor_aplicado,
                                 cr_Valor = q.cr_Valor,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 cm_observacion = q.cm_observacion,
                                 cm_fecha = q.cm_fecha,
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
