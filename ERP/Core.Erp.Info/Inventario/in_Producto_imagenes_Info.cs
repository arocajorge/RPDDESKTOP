using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_Producto_imagenes_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public int Secuencia { get; set; }
        public byte[] Imagen { get; set; }
        //Campo para tener la imagen en formato image
        public Image Imagen_image { get; set; }
    }
}
