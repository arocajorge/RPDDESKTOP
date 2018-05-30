using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt022_Data
    {
        public List<XINV_Rpt022_Info> Get_List(int IdEmpresa, decimal IdDev_Inven, ref string msg)
        {
            List<XINV_Rpt022_Info> Lista = new List<XINV_Rpt022_Info>();
            try
            {
                using (Entities_Inventario_General context = new Entities_Inventario_General())
                {
                    var contact = from q in context.vwINV_Rpt022
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdDev_Inven == IdDev_Inven
                                  select q;

                    foreach (var item in contact)
                    {
                        XINV_Rpt022_Info Info = new XINV_Rpt022_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdDev_Inven = item.IdDev_Inven;
                        Info.secuencia = item.secuencia;
                        Info.IdEmpresa_movi_inv = item.IdEmpresa_movi_inv;
                        Info.IdSucursal_movi_inv = item.IdSucursal_movi_inv;
                        Info.IdBodega_movi_inv = item.IdBodega_movi_inv;
                        Info.IdMovi_inven_tipo_movi_inv = item.IdMovi_inven_tipo_movi_inv;
                        Info.IdNumMovi_movi_inv = item.IdNumMovi_movi_inv;
                        Info.Secuencia_movi_inv = item.Secuencia_movi_inv;
                        Info.cod_Dev_Inven = item.cod_Dev_Inven;
                        Info.Fecha = item.Fecha;
                        Info.num_egreso = item.num_egreso;
                        Info.IdProducto = item.IdProducto;
                        Info.nom_punto_cargo = item.nom_punto_cargo;
                        Info.pr_codigo = item.pr_codigo;
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.Descripcion = item.Descripcion;
                        Info.cantidad_a_devolver = item.cantidad_a_devolver;
                        Info.Su_Descripcion = item.Su_Descripcion;
                        Info.bo_Descripcion = item.bo_Descripcion;
                        Info.observacion = item.observacion;

                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt022_Info>();
            }
        }
    }
}
