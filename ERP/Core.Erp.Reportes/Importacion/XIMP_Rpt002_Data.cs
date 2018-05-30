using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Importacion
{
   public class XIMP_Rpt002_Data
    {
       public List<XIMP_Rpt002_Info> GetList(int IdEmpresa, decimal IdOrdencompra)
       {
           try
           {
               List<XIMP_Rpt002_Info> lista = new List<XIMP_Rpt002_Info>();

               using (Entity_Importaciones_Rpt entity=new Entity_Importaciones_Rpt())
               {
                   var query = (from q in entity.vwIMP_Rpt002
                                where q.IdEmpresa == IdEmpresa
                                && q.IdOrdenCompra_ext == IdOrdencompra
                                select new XIMP_Rpt002_Info
                                {
                                    IdEmpresa=q.IdEmpresa,
                                    IdLiquidacion = q.IdLiquidacion,
                                    IdProveedor = q.IdProveedor,
                                    pr_codigo = q.pr_codigo,
                                    IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                    li_fecha = q.li_fecha,
                                    oe_fecha_llegada = q.oe_fecha_llegada,
                                    oe_fecha_embarque = q.oe_fecha_embarque,
                                    oe_fecha_desaduanizacion = q.oe_fecha_desaduanizacion,
                                    fecha_modificacion = q.fecha_modificacion,
                                    li_observacion = q.li_observacion,
                                    li_factor_conversion = q.li_factor_conversion,
                                    li_total_fob = q.li_total_fob,
                                    li_total_gastos = q.li_total_gastos,
                                    li_total_bodega = q.li_total_bodega,
                                    li_factor_costo = q.li_factor_costo,
                                    oe_valor_seguro=q. oe_valor_seguro,
                                    od_cantidad = q.od_cantidad,
                                    od_costo = q.od_costo,
                                    od_por_descuento = q.od_por_descuento,
                                    od_descuento = q.od_descuento,
                                    od_costo_final = q.od_costo_final,
                                    od_subtotal = q.od_subtotal,
                                    od_cantidad_recepcion = q.od_cantidad_recepcion,
                                    od_costo_convertido = q.od_costo_convertido,
                                    od_total_fob = q.od_total_fob,
                                    od_factor_costo = q.od_factor_costo,
                                    od_costo_bodega = q.od_costo_bodega,
                                    od_costo_total = q.od_costo_total,
                                    oe_valor_flete = q.oe_valor_flete,
                                    oe_codigo = q.oe_codigo,
                                    oe_fecha_llegada_est = q.oe_fecha_llegada_est,
                                    oe_fecha_embarque_est = q.oe_fecha_embarque_est,
                                    oe_fecha_desaduanizacion_est = q.oe_fecha_desaduanizacion_est,
                                    oe_fecha = q.oe_fecha,
                                    ca_descripcion = q.ca_descripcion


                                }).ToList();
               }

               return lista;

           }
           catch (Exception)
           {

               return new List<XIMP_Rpt002_Info>() ;
           } 
       }
    }
}
