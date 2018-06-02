using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data;
using System.IO;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt012_Data
    {
        public List<XFAC_Rpt012_Info> get_list(int IdEmpresa, int IdSucursal, decimal IdProforma, bool buscar_imagen)
        {
            try
            {
                List<XFAC_Rpt012_Info> Lista;

                using (EntitiesFacturacion_Reportes Context = new EntitiesFacturacion_Reportes())
                {
                    Lista = (from q in Context.vwFAC_Rpt012
                             where q.IdEmpresa == IdEmpresa
                             && q.IdSucursal == IdSucursal
                             && q.IdProforma == IdProforma
                             select new XFAC_Rpt012_Info
                             {
                                 IdRow = q.IdRow,
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdProforma = q.IdProforma,
                                 Secuencia = q.Secuencia,
                                 nom_TerminoPago = q.nom_TerminoPago,
                                 pf_plazo = q.pf_plazo,
                                 pf_codigo = q.pf_codigo,
                                 pf_fecha = q.pf_fecha,
                                 estado = q.estado,
                                 pf_atencion_a = q.pf_atencion_a,
                                 Codigo = q.Codigo,
                                 Ve_Vendedor = q.Ve_Vendedor,
                                 pr_descripcion = q.pr_descripcion,
                                 pd_cantidad = q.pd_cantidad,
                                 pd_precio = q.pd_precio,
                                 pd_por_descuento_uni = q.pd_por_descuento_uni,
                                 pd_descuento_uni = q.pd_descuento_uni,
                                 pd_precio_final = q.pd_precio_final,
                                 pd_subtotal = q.pd_subtotal,
                                 pd_por_iva = q.pd_por_iva,
                                 pd_iva = q.pd_iva,
                                 pd_total = q.pd_total,
                                 nom_marca = q.nom_marca,
                                 nom_modelo = q.nom_modelo,
                                 IdProducto = q.IdProducto,
                                 observacion = q.pr_observacion,
                                 pf_dias_entrega = q.pr_dias_entrega,                             
                             }).ToList();
                }
                if (buscar_imagen)
                {
                    using (EntitiesInventario Context = new EntitiesInventario())
                    {
                        foreach (var item in Lista)
                        {
                            var lst = from q in Context.in_Producto_imagenes
                                      where q.IdEmpresa == item.IdEmpresa
                                      && q.IdProducto == item.IdProducto
                                      && q.Secuencia == 1
                                      select q;

                            if (lst.Count() > 0)
                                if (lst.FirstOrDefault().Imagen != null)
                                {
                                    MemoryStream ms = new MemoryStream(lst.FirstOrDefault().Imagen);
                                    item.Imagen_image = System.Drawing.Bitmap.FromStream(ms);
                                }
                        }
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
