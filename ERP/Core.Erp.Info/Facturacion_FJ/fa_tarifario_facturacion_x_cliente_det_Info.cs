using Core.Erp.Info.ActivoFijo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
   public class fa_tarifario_facturacion_x_cliente_det_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdTarifario { get; set; }
       public int Secuencia { get; set; }
       public int cantidad { get; set; }  
       public int IdCategoriaAF { get; set; }

       public List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> lst_det_x_af { get; set; }
       public List<Af_Activo_fijo_Info> lst_Activos { get; set; }

       public fa_tarifario_facturacion_x_cliente_det_Info()
       {
           lst_Activos = new List<Af_Activo_fijo_Info>();
           lst_det_x_af = new List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info>();
       }
   }
}
