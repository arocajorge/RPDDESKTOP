using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Importacion
{
   public class XIMP_Rpt001_Data
    {
       public List<XIMP_Rpt001_Info> GetList(int IdEmpresa, decimal IdOrdencompra)
       {
           try
           {
               List<XIMP_Rpt001_Info> lista = new List<XIMP_Rpt001_Info>();

               using (Entity_Importaciones_Rpt entity=new Entity_Importaciones_Rpt())
               {
                   var query = (from q in entity.vwIMP_Rpt001
                                where q.IdEmpresa == IdEmpresa
                                && q.IdOrdenCompra_ext == IdOrdencompra
                                select new XIMP_Rpt001_Info
                                {
                                    IdEmpresa=q.IdEmpresa,
                                    IdOrdenCompra_ext=q.IdOrdenCompra_ext,
                                    pe_direccion=q.pe_direccion,
                                    pe_telefonoCasa=q.pe_telefonoCasa,
                                    pe_apellido=q.pe_apellido,
                                    pe_nombre=q.pe_nombre,
                                    ca_descripcion=q.ca_descripcion,
                                    pr_descripcion=q.pr_descripcion,
                                    pr_codigo=q.pr_codigo,
                                    Descripcion_Ciudad=q.Descripcion_Ciudad,
                                    oe_fecha_llegada_est=q.oe_fecha_llegada_est ,
                                    oe_fecha_embarque_est=q.oe_fecha_embarque_est ,
                                    oe_fecha_desaduanizacion_est=q.oe_fecha_desaduanizacion_est ,
                                    oe_observacion=q.oe_observacion ,
                                    oe_codigo=q.oe_codigo ,
                                    oe_valor_flete=q. oe_valor_flete,
                                    oe_valor_seguro=q. oe_valor_seguro,
                                    fecha_creacion=q.fecha_creacion ,
                                    oe_fecha_llegada=q. oe_fecha_llegada,
                                    oe_fecha_embarque=q.oe_fecha_embarque,
                                    oe_fecha=q. oe_fecha,
                                    od_cantidad=q. od_cantidad,
                                    od_costo=q. od_costo,
                                    od_por_descuento=q.od_por_descuento ,
                                    od_descuento=q. od_descuento,
                                    od_costo_final=q. od_costo_final,
                                    od_subtotal=q. od_subtotal,
                                    od_cantidad_recepcion=q. od_cantidad_recepcion,
                                    od_costo_convertido=q.od_costo_convertido ,
                                    od_total_fob=q. od_total_fob,
                                    od_factor_costo=q. od_factor_costo,
                                    od_costo_bodega=q.od_costo_bodega ,
                                    od_costo_total=q. od_costo_total,
                                    paisOrigen=q. paisEmbarque,
                                    paisEmbarque = q.paisEmbarque,
                                    pe_nombreCompleto=q.pe_nombreCompleto


                                }).ToList();
               }

               return lista;

           }
           catch (Exception)
           {

               return new List<XIMP_Rpt001_Info>() ;
           } 
       }
    }
}
