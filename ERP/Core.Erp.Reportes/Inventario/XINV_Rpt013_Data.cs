﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt013_Data
    {
        public List<XINV_Rpt013_Info> Get_list(int IdEmpresa, int IdSucursal, List<int> lst_bodega, decimal IdProducto, string IdCentroCosto, List<string> lst_subcentro, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                decimal IdProducto_ini = IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 99999 : IdProducto;

                List<XINV_Rpt013_Info> Lista = new List<XINV_Rpt013_Info>();
                using (Entities_Inventario_General Context = new Entities_Inventario_General())
                {
                    IQueryable<vwINV_Rpt013> lst;

                    if (lst_bodega.Count > 0 && lst_subcentro.Count > 0)//Si escoge sucursal, bodegas, centro y subcentro
                    {
                        lst = from q in Context.vwINV_Rpt013
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && lst_bodega.Contains(q.IdBodega)
                              && q.IdCentroCosto == IdCentroCosto
                              && lst_subcentro.Contains(q.IdCentroCosto_sub_centro_costo)
                              && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                              && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                              select q;
                    }
                    else
                        if ((IdCentroCosto == "" || IdCentroCosto == null) && (IdSucursal == 0))// Si no escoge nada
                        {
                            lst = from q in Context.vwINV_Rpt013
                                  where q.IdEmpresa == IdEmpresa
                                  && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                  && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                                  select q;
                        }
                        else
                            if (lst_bodega.Count > 0 && (IdCentroCosto == "" || IdCentroCosto == null))//Si escoge sucursal y bodega pero no escoge centro
                            {
                                lst = from q in Context.vwINV_Rpt013
                                      where q.IdEmpresa == IdEmpresa
                                      && q.IdSucursal == IdSucursal
                                      && lst_bodega.Contains(q.IdBodega)
                                      && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                      && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                                      select q;
                            }
                            else //Si solo escoge centro y subcentro de costo pero no escoge sucursal ni bodega
                            {
                                lst = from q in Context.vwINV_Rpt013
                                      where q.IdEmpresa == IdEmpresa
                                      && q.IdCentroCosto == IdCentroCosto
                                      && lst_subcentro.Contains(q.IdCentroCosto_sub_centro_costo)
                                      && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                      && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                                      select q;
                            }

                    foreach (var item in lst)
                    {
                        XINV_Rpt013_Info info = new XINV_Rpt013_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.IdNumMovi = item.IdNumMovi;
                        info.Secuencia = item.Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.cod_producto = item.cod_producto;
                        info.nom_producto = item.nom_producto;
                        info.IdUnidadMedida = item.IdUnidadMedida;
                        info.nom_unidad_medida = item.nom_unidad_medida;
                        info.cm_fecha = item.cm_fecha;
                        info.cod_bodega = item.cod_bodega;
                        info.nom_bodega = item.nom_bodega;
                        info.cod_sucursal = item.cod_sucursal;
                        info.nom_sucursal = item.nom_sucursal;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_centro_costo = item.nom_centro_costo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.nom_subcentro_costo = item.nom_subcentro_costo;
                        info.dm_cantidad = item.dm_cantidad;
                        info.mv_costo = item.mv_costo;
                        info.Total = item.Total;
                        info.mv_tipo_movi = item.mv_tipo_movi;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.cod_Punto_cargo_grupo = item.cod_Punto_cargo_grupo;
                        info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.codPunto_cargo = item.codPunto_cargo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.CodMoviInven = item.CodMoviInven;
                        Lista.Add(info);
                    }
                    
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
