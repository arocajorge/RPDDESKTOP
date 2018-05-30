using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario_Fj
{
    public class in_Ing_Egr_Inven_fj_Data
    {
        public in_Ing_Egr_Inven_fj_Info get_info(int IdEmpresa, int IdSucursal, int IdMoviInven_tipo, decimal IdNumMovi)
        {
            try
            {
                in_Ing_Egr_Inven_fj_Info info = new in_Ing_Egr_Inven_fj_Info();

                using (EntitiesInventario_Fj Context = new EntitiesInventario_Fj())
                {
                    var lst = from q in Context.in_Ing_Egr_Inven_fj
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdMovi_inven_tipo == IdMoviInven_tipo
                              && q.IdNumMovi == IdNumMovi
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.IdNumMovi = item.IdNumMovi;
                        info.cod_orden_mantenimiento = item.cod_orden_mantenimiento;
                        info.IdEmpleado = item.IdEmpleado;
                    }
                }

                return info;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(in_Ing_Egr_Inven_fj_Info info)
        {
            try
            {
                using (EntitiesInventario_Fj Context = new EntitiesInventario_Fj())
                {
                    in_Ing_Egr_Inven_fj Entity = new in_Ing_Egr_Inven_fj();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdSucursal = info.IdSucursal;
                    Entity.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                    Entity.IdNumMovi = info.IdNumMovi;
                    Entity.cod_orden_mantenimiento = info.cod_orden_mantenimiento;
                    Entity.IdEmpleado = info.IdEmpleado;
                    Context.in_Ing_Egr_Inven_fj.Add(Entity);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool modificarDB(in_Ing_Egr_Inven_fj_Info info)
        {
            try
            {
                using (EntitiesInventario_Fj Context = new EntitiesInventario_Fj())
                {
                    in_Ing_Egr_Inven_fj Entity = Context.in_Ing_Egr_Inven_fj.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);
                    if (Entity != null)
                    {
                        Entity.cod_orden_mantenimiento = info.cod_orden_mantenimiento;
                        Entity.IdEmpleado = info.IdEmpleado;
                        Context.SaveChanges();
                    }
                    else
                        guardarDB(info);                    
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
