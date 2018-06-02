using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt010_Data
    {
        string MensajeError = "";

        public List<XINV_Rpt010_Info> Get_List(DateTime Fecha_desde, DateTime Fecha_hasta, int IdEmpresa, int IdSucursal, List<int> lst_bodega, decimal IdProducto, string idUsuario, bool No_mostrar_valores_en_0, bool Mostrar_detallado)
        {
            try
            {
                Fecha_desde = Fecha_desde.Date;
                Fecha_hasta = Fecha_hasta.Date;

                int IdSucursal_ini = IdSucursal == 0 ? 1 : IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                decimal IdProducto_ini = IdProducto == 0 ? 1 : IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 99999 : IdProducto;

                List<XINV_Rpt010_Info> List = new List<XINV_Rpt010_Info>();

                using (Entities_Inventario_General context = new Entities_Inventario_General())
                {
                    context.SetCommandTimeOut(30000);

                    foreach (var item_bodega in lst_bodega)
                    {
                        List = (from q in context.spINV_Rpt010(IdEmpresa, IdSucursal_ini, IdSucursal_fin, item_bodega, item_bodega, IdProducto_ini, IdProducto_fin, Fecha_desde, Fecha_hasta, idUsuario, No_mostrar_valores_en_0, Mostrar_detallado)
                                select new XINV_Rpt010_Info
                                {
                                    IdEmpresa = q.IdEmpresa,
                                    IdSucursal = q.IdSucursal,
                                    IdBodega = q.IdBodega,
                                    IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                    IdNumMovi = q.IdNumMovi,
                                    Secuencia = q.Secuencia,
                                    IdProducto = q.IdProducto,
                                    Saldo_ini_cant = q.Saldo_ini_cant,
                                    Cost_prom_ini = q.Cost_prom_ini,
                                    Saldo_ini_cost = q.Saldo_ini_cost,
                                    cant_ing = q.cant_ing,
                                    cost_ing = q.cost_ing,
                                    total_ing = q.total_ing,
                                    cant_egr = q.cant_egr,
                                    cost_egr = q.cost_egr,
                                    total_egr = q.total_egr,
                                    Saldo_cant = q.Saldo_cant,
                                    Saldo_cost_prom = q.Saldo_cost_prom,
                                    Saldo_cost = q.Saldo_cost,
                                    Saldo_fin_cant = q.Saldo_fin_cant,
                                    Cost_prom_fin = q.Cost_prom_fin,
                                    Saldo_fin_cost = q.Saldo_fin_cost,
                                    IdUsuario = q.IdUsuario,
                                    dm_observacion = q.dm_observacion,
                                    cm_fecha = q.cm_fecha,
                                    tipo_movi = q.tipo_movi,
                                    cod_bodega = q.cod_bodega,
                                    nom_bodega = q.nom_bodega,
                                    cod_sucursal = q.cod_sucursal,
                                    nom_sucursal = q.nom_sucursal,
                                    IdEmpresa_oc = q.IdEmpresa_oc,
                                    IdSucursal_oc = q.IdSucursal_oc,
                                    IdOrdenCompra = q.IdOrdenCompra,
                                    num_factura = q.num_factura,
                                    nom_proveedor = q.nom_proveedor,
                                    pr_codigo = q.pr_codigo,
                                    pr_descripcion = q.pr_descripcion,
                                    IdUnidadMedida = q.IdUnidadMedida,
                                    nom_unidad_consumo = q.nom_unidad_consumo,
                                    cod_unidad_consumo = q.cod_unidad_consumo,
                                }).ToList();
                    }
                    if (lst_bodega.Count == 0)
                    {
                        List = (from q in context.spINV_Rpt010(IdEmpresa, IdSucursal_ini, IdSucursal_fin, 1, 9999, IdProducto_ini, IdProducto_fin, Fecha_desde, Fecha_hasta, idUsuario, No_mostrar_valores_en_0, Mostrar_detallado)
                                select new XINV_Rpt010_Info
                                {
                                    IdEmpresa = q.IdEmpresa,
                                    IdSucursal = q.IdSucursal,
                                    IdBodega = q.IdBodega,
                                    IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                    IdNumMovi = q.IdNumMovi,
                                    Secuencia = q.Secuencia,
                                    IdProducto = q.IdProducto,
                                    Saldo_ini_cant = q.Saldo_ini_cant,
                                    Cost_prom_ini = q.Cost_prom_ini,
                                    Saldo_ini_cost = q.Saldo_ini_cost,
                                    cant_ing = q.cant_ing,
                                    cost_ing = q.cost_ing,
                                    total_ing = q.total_ing,
                                    cant_egr = q.cant_egr,
                                    cost_egr = q.cost_egr,
                                    total_egr = q.total_egr,
                                    Saldo_cant = q.Saldo_cant,
                                    Saldo_cost_prom = q.Saldo_cost_prom,
                                    Saldo_cost = q.Saldo_cost,
                                    Saldo_fin_cant = q.Saldo_fin_cant,
                                    Cost_prom_fin = q.Cost_prom_fin,
                                    Saldo_fin_cost = q.Saldo_fin_cost,
                                    IdUsuario = q.IdUsuario,
                                    dm_observacion = q.dm_observacion,
                                    cm_fecha = q.cm_fecha,
                                    tipo_movi = q.tipo_movi,
                                    cod_bodega = q.cod_bodega,
                                    nom_bodega = q.nom_bodega,
                                    cod_sucursal = q.cod_sucursal,
                                    nom_sucursal = q.nom_sucursal,
                                    IdEmpresa_oc = q.IdEmpresa_oc,
                                    IdSucursal_oc = q.IdSucursal_oc,
                                    IdOrdenCompra = q.IdOrdenCompra,
                                    num_factura = q.num_factura,
                                    nom_proveedor = q.nom_proveedor,
                                    pr_codigo = q.pr_codigo,
                                    pr_descripcion = q.pr_descripcion,
                                    IdUnidadMedida = q.IdUnidadMedida,
                                    nom_unidad_consumo = q.nom_unidad_consumo,
                                    cod_unidad_consumo = q.cod_unidad_consumo,
                                }).ToList();
                    }
                }

                return List;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
