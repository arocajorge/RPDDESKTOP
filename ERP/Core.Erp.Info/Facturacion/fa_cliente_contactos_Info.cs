using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
   public class fa_cliente_contactos_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdCliente { get; set; }
       public int IdContacto { get; set; }
       public string Nombres { get; set; }
       public string Telefono { get; set; }
       public string Celular { get; set; }
       public string Correo { get; set; }
       public string Direccion { get; set; }
       public string IdCiudad { get; set; }
       public string IdParroquia { get; set; }       
    }
}
