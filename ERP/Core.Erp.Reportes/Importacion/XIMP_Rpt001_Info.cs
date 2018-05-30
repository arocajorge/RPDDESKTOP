using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Importacion
{
   public class XIMP_Rpt001_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdOrdenCompra_ext { get; set; }
       public string pe_direccion { get; set; }
       public string pe_telefonoCasa { get; set; }
       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string ca_descripcion { get; set; }
       public string pr_descripcion { get; set; }
       public string pr_codigo { get; set; }
       public string Descripcion_Ciudad { get; set; }
       public Nullable<System.DateTime> oe_fecha_llegada_est { get; set; }
       public Nullable<System.DateTime> oe_fecha_embarque_est { get; set; }
       public Nullable<System.DateTime> oe_fecha_desaduanizacion_est { get; set; }
       public string oe_observacion { get; set; }
       public string oe_codigo { get; set; }
       public double oe_valor_flete { get; set; }
       public double oe_valor_seguro { get; set; }
       public Nullable<System.DateTime> fecha_creacion { get; set; }
       public Nullable<System.DateTime> oe_fecha_llegada { get; set; }
       public Nullable<System.DateTime> oe_fecha_embarque { get; set; }
       public System.DateTime oe_fecha { get; set; }
       public double od_cantidad { get; set; }
       public double od_costo { get; set; }
       public double od_por_descuento { get; set; }
       public double od_descuento { get; set; }
       public double od_costo_final { get; set; }
       public double od_subtotal { get; set; }
       public double od_cantidad_recepcion { get; set; }
       public double od_costo_convertido { get; set; }
       public double od_total_fob { get; set; }
       public double od_factor_costo { get; set; }
       public double od_costo_bodega { get; set; }
       public double od_costo_total { get; set; }
       public string paisOrigen { get; set; }
       public string paisEmbarque { get; set; }
       public string pe_nombreCompleto { get; set; }

    }
}
