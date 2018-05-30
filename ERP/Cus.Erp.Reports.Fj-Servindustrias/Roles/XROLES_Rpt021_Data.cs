using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt021_Data
    {
        public List<XROLES_Rpt021_Info> get_list(int IdEmpresa, int IdNomina_tipo, decimal IdEmpleado, int IdDescuento)
        {
            try
            {
                List<XROLES_Rpt021_Info> Lista = new List<XROLES_Rpt021_Info>();

                using (Entities_Roles_Fj_Rpt Context = new Entities_Roles_Fj_Rpt())
                {
                    Lista = (from q in Context.vwROLES_Rpt021
                             where q.IdEmpresa == IdEmpresa
                             && q.IdNomina_Tipo == IdNomina_tipo
                             && q.IdEmpleado == IdEmpleado
                             && q.IdDescuento == IdDescuento
                             select new XROLES_Rpt021_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdNomina_Tipo = q.IdNomina_Tipo,
                                 IdEmpleado = q.IdEmpleado,
                                 IdDescuento = q.IdDescuento,
                                 pe_apellido = q.pe_apellido,
                                 pe_nombre = q.pe_nombre,
                                 nom_cargo = q.nom_cargo,
                                 nom_rubro = q.nom_rubro,
                                 Observacion = q.Observacion,
                                 Valor = q.Valor,
                                 Fecha_Incidente = q.Fecha_Incidente,
                                 Estado = q.Estado,
                                 pe_cedulaRuc = q.pe_cedulaRuc,
                                 Descripcion = q.Descripcion,
                                 pe_nombreCompleto = q.pe_apellido +" "+ q.pe_nombre
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
