using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Contabilidad
{
    public class XCONTA_FJ_Rpt001_Data
    {
        public List<XCONTA_FJ_Rpt001_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, int IdPunto_cargo, bool mostrar_saldo_0, int Nivel)
        {
            try
            {
                int IdPunto_cargo_ini = IdPunto_cargo;
                int IdPunto_cargo_fin = IdPunto_cargo == 0 ? 9999 : IdPunto_cargo;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                List<XCONTA_FJ_Rpt001_Info> Lista;

                using (Entities_contabilidad_fj_rpt Context = new Entities_contabilidad_fj_rpt())
                {
                    Lista = (from q in Context.spCONTA_FJ_Rpt001(IdEmpresa, Fecha_ini, Fecha_fin, IdPunto_cargo_ini, IdPunto_cargo_fin, mostrar_saldo_0, Nivel)
                             select new XCONTA_FJ_Rpt001_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdCtaCble = q.IdCtaCble,
                                 IdPunto_cargo = q.IdPunto_cargo,
                                 pc_Cuenta = q.pc_Cuenta,
                                 nom_punto_cargo = q.nom_punto_cargo,
                                 IdNivelCta = q.IdNivelCta,
                                 IdGrupoCble = q.IdGrupoCble,
                                 gc_Orden = q.gc_Orden,
                                 IdCtaCblePadre = q.IdCtaCblePadre,
                                 gc_estado_financiero = q.gc_estado_financiero,
                                 pc_EsMovimiento = q.pc_EsMovimiento,
                                 gc_GrupoCble = q.gc_GrupoCble,
                                 bg_saldo_inicial = q.bg_saldo_inicial,
                                 bg_debitos_mes = q.bg_debitos_mes,
                                 bg_creditos_mes = q.bg_creditos_mes,
                                 bg_saldo_mes = q.bg_saldo_mes,
                                 bg_saldo_final = q.bg_saldo_final,
                                 IdCtaCble_2 = q.IdCtaCble_2,
                                 IdCtaCblePadre_2 = q.IdCtaCblePadre_2,
                                 bg_saldo_inicial_mov = q.bg_saldo_inicial,
                                 bg_debitos_mes_mov = q.bg_debitos_mes,
                                 bg_creditos_mes_mov = q.bg_creditos_mes,
                                 bg_saldo_mes_mov = q.bg_saldo_mes,
                                 bg_saldo_final_mov = q.bg_saldo_final
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
