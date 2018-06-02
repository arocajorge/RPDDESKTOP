using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
    public class in_Producto_data
    {
        string MensajeError = "";

        public string validar_anulacion(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                string mensaje = string.Empty;
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var sp = Context.spin_Producto_validar_anulacion(IdEmpresa, IdProducto);
                    foreach (var item in sp)
                    {
                        mensaje = item;
                    }
                }
                
                return mensaje;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public decimal get_id_x_lote(int IdEmpresa, string codigo, string lote)
        {
            try
            {
                decimal ID = 0;
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.in_Producto
                              where q.IdEmpresa == IdEmpresa
                              && q.pr_codigo == codigo
                              && q.lote_num_lote == lote
                              select q;

                    if (lst.Count() > 0)
                        ID = lst.First().IdProducto;
                }
                return ID;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<in_Producto_Info> get_list_producto_consulta(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> Lista = new List<in_Producto_Info>();

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Lista = (from p in Context.in_Producto
                             join t in Context.in_ProductoTipo
                             on new { p.IdEmpresa, p.IdProductoTipo } equals new { t.IdEmpresa, t.IdProductoTipo }

                             join pp in Context.in_Producto
                             on new { IdEmpresa = p.IdEmpresa, IdProducto = p.IdProducto_padre } equals new { IdEmpresa = pp.IdEmpresa, IdProducto = (decimal?)pp.IdProducto } into tmp_pp
                             from pp in tmp_pp.DefaultIfEmpty()

                             join c in Context.in_categorias
                             on new { p.IdEmpresa, p.IdCategoria } equals new { c.IdEmpresa, c.IdCategoria }

                             join l in Context.in_linea
                             on new { p.IdEmpresa, p.IdCategoria, p.IdLinea } equals new { l.IdEmpresa, l.IdCategoria, l.IdLinea }

                             join g in Context.in_grupo
                             on new { p.IdEmpresa, p.IdCategoria, p.IdLinea, p.IdGrupo } equals new { g.IdEmpresa, g.IdCategoria, g.IdLinea, g.IdGrupo }

                             join sg in Context.in_subgrupo
                             on new { IdEmpresa = p.IdEmpresa, IdCategoria = p.IdCategoria, IdLinea = p.IdLinea, IdGrupo = p.IdGrupo, IdSubGrupo = p.IdSubGrupo } equals new { IdEmpresa = sg.IdEmpresa, IdCategoria = sg.IdCategoria, IdLinea = sg.IdLinea, IdGrupo = sg.IdGrupo, IdSubGrupo = sg.IdSubgrupo }

                             join pr in Context.in_presentacion
                             on new { p.IdEmpresa, p.IdPresentacion } equals new { pr.IdEmpresa, pr.IdPresentacion }

                             join m in Context.in_Marca
                             on new { p.IdEmpresa, p.IdMarca } equals new { m.IdEmpresa, m.IdMarca}

                             where p.IdEmpresa == IdEmpresa
                             select new in_Producto_Info
                             {
                                 IdEmpresa = p.IdEmpresa,
                                 IdProducto = p.IdProducto,
                                 pr_codigo = p.pr_codigo,
                                 pr_codigo2 = p.pr_codigo2,
                                 pr_descripcion = p.pr_descripcion,
                                 pr_descripcion_2 = p.pr_descripcion_2,
                                 IdProductoTipo = p.IdProductoTipo,
                                 IdMarca = p.IdMarca,
                                 IdPresentacion = p.IdPresentacion,
                                 IdCategoria = p.IdCategoria,
                                 IdLinea = p.IdLinea,
                                 IdGrupo = p.IdGrupo,
                                 IdSubGrupo = p.IdSubGrupo,
                                 IdUnidadMedida = p.IdUnidadMedida,
                                 IdUnidadMedida_Consumo = p.IdUnidadMedida_Consumo,
                                 //IdNaturaleza = p.IdNaturaleza,
                                 pr_codigo_barra = p.pr_codigo_barra,
                                 pr_observacion = p.pr_observacion,
                                 IdUsuario = p.IdUsuario,
                                 Fecha_Transac = p.Fecha_Transac,
                                 IdUsuarioUltMod = p.IdUsuarioUltMod,
                                 Fecha_UltMod = p.Fecha_UltMod,
                                 IdUsuarioUltAnu = p.IdUsuarioUltAnu,
                                 Fecha_UltAnu = p.Fecha_UltAnu,
                                 pr_motivoAnulacion = p.pr_motivoAnulacion,
                                 nom_pc = p.nom_pc,
                                 ip = p.ip,
                                 Estado = p.Estado,
                                 IdCod_Impuesto_Iva = p.IdCod_Impuesto_Iva,
                                 Aparece_modu_Ventas = p.Aparece_modu_Ventas,
                                 Aparece_modu_Compras = p.Aparece_modu_Compras,
                                 Aparece_modu_Inventario = p.Aparece_modu_Inventario,
                                 Aparece_modu_Activo_F = p.Aparece_modu_Activo_F,
                                 IdProducto_padre = p.IdProducto_padre,
                                 lote_fecha_fab = p.lote_fecha_fab,
                                 lote_fecha_vcto = p.lote_fecha_vcto,
                                 lote_num_lote = p.lote_num_lote,
                                 precio_1 = p.precio_1,
                                 precio_2 = p.precio_2,
                                 signo_2 = p.signo_2,
                                 porcentaje_2 = p.porcentaje_2,
                                 precio_3 = p.precio_3,
                                 signo_3 = p.signo_3,
                                 porcentaje_3 = p.porcentaje_3,
                                 precio_4 = p.precio_4,
                                 signo_4 = p.signo_4,
                                 porcentaje_4 = p.porcentaje_4,
                                 precio_5 = p.precio_5,
                                 signo_5 = p.signo_5,
                                 porcentaje_5 = p.porcentaje_5,
                                 se_distribuye = p.se_distribuye,
                                 //Tipo Producto
                                 nom_Tipo_Producto = t.tp_descripcion,
                                 //Producto padre
                                 pr_descripcion_padre = pp.pr_descripcion,
                                 //Categoria
                                 nom_Categoria = c.ca_Categoria,
                                 //Linea
                                 nom_Linea = l.nom_linea,
                                 //Grupo
                                 nom_Grupo = g.nom_grupo,
                                 //Subgrupo
                                 nom_SubGrupo = sg.nom_subgrupo,
                                 //Marca
                                 nom_Marca = m.Descripcion,
                                 //Presentación
                                 nom_Presentacion = pr.nom_presentacion
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                lM = (from C in OECbtecble_Info.vwin_producto
                      where C.IdEmpresa == IdEmpresa
                      select new in_Producto_Info
                      {
                          IdEmpresa = C.IdEmpresa,
                          Estado = C.Estado.Trim(),
                          Fecha_Transac = C.Fecha_Transac,
                          Fecha_UltAnu = C.Fecha_UltAnu,
                          Fecha_UltMod = C.Fecha_UltMod,
                          IdPresentacion = C.IdPresentacion,
                          nom_Categoria = C.ca_Categoria,
                          nom_Linea = C.nom_linea,
                          nom_Grupo = C.nom_grupo,
                          nom_SubGrupo = C.nom_subgrupo,
                          nom_Tipo_Producto = C.tp_descripcion,
                          pr_descripcion_2 = C.pr_descripcion_2,
                          pr_descripcion = C.pr_descripcion,
                          pr_descripcion2 = "[" + C.pr_codigo + "] " + C.pr_descripcion,
                          IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,

                          IdMarca = C.IdMarca,

                          IdProducto = C.IdProducto,

                          IdProductoTipo = C.IdProductoTipo,

                          IdUnidadMedida = C.IdUnidadMedida.Trim(),
                          IdUsuario = C.IdUsuario.Trim(),
                          IdUsuarioUltAnu = C.IdUsuarioUltAnu,
                          IdUsuarioUltMod = C.IdUsuarioUltMod,
                          ip = C.ip.Trim(),
                          nom_pc = C.nom_pc.Trim(),
                          pr_codigo = C.pr_codigo.Trim(),
                          pr_codigo_barra = C.pr_codigo_barra.Trim(),
                          pr_observacion = C.pr_observacion.Trim(),
                          pr_pedidos = C.pr_pedidos,
                          
                          precio_1 = C.precio_1,

                          precio_2 = C.precio_2,
                          signo_2 = C.signo_2,
                          porcentaje_2 = C.porcentaje_2,

                          precio_3 = C.precio_3,
                          signo_3 = C.signo_3,
                          porcentaje_3 = C.porcentaje_3,

                          precio_4 = C.precio_4,
                          signo_4 = C.signo_4,
                          porcentaje_4 = C.porcentaje_4,

                          precio_5 = C.precio_5,
                          signo_5 = C.signo_5,
                          porcentaje_5 = C.porcentaje_5,

                          se_distribuye = C.se_distribuye,
                          IdCategoria = C.IdCategoria.Trim(),
                          IdLinea = C.IdLinea,
                          IdGrupo = C.IdGrupo,
                          IdSubGrupo = C.IdSubGrupo,

                          IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                          Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                          Aparece_modu_Compras = C.Aparece_modu_Compras,
                          Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                          Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,

                          IdProducto_padre = C.IdProducto_padre,
                          lote_fecha_fab = C.lote_fecha_fab,
                          lote_fecha_vcto = C.lote_fecha_vcto,
                          lote_num_lote = C.lote_num_lote,
                          pr_descripcion_padre = C.pr_descripcion_padre,
                          pr_codigo2 = C.pr_codigo2,
                          pr_descripcion_combo = C.pr_descripcion + " - " + C.nom_presentacion
                      }).ToList();
                foreach (var item in lM.Where(q => q.lote_fecha_vcto != null))
                {
                    item.pr_descripcion_combo += " - " + item.nom_Categoria + " - " + item.lote_num_lote + " - " + Convert.ToDateTime(item.lote_fecha_vcto).Date.ToShortDateString();
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_x_producto_padre(int IdEmpresa, decimal IdProducto_padre)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                lM = (from C in OECbtecble_Info.in_Producto
                      where C.IdEmpresa == IdEmpresa
                      && C.IdProducto_padre == IdProducto_padre
                      select new in_Producto_Info
                      {
                          IdEmpresa = C.IdEmpresa,
                          IdProducto = C.IdProducto,
                          pr_codigo = C.pr_codigo,
                          pr_codigo2 = C.pr_codigo2,
                          pr_descripcion = C.pr_descripcion,
                          pr_descripcion_2 = C.pr_descripcion_2,
                          IdProductoTipo = C.IdProductoTipo,
                          IdMarca = C.IdMarca,
                          IdPresentacion = C.IdPresentacion,
                          IdCategoria = C.IdCategoria,
                          IdLinea = C.IdLinea,
                          IdGrupo = C.IdGrupo,
                          IdSubGrupo = C.IdSubGrupo,
                          IdUnidadMedida = C.IdUnidadMedida,
                          IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                          pr_codigo_barra = C.pr_codigo_barra,
                          pr_observacion = C.pr_observacion,
                          IdUsuario = C.IdUsuario,
                          Fecha_Transac = C.Fecha_Transac,
                          IdUsuarioUltMod = C.IdUsuarioUltMod,
                          Fecha_UltMod = C.Fecha_UltMod,
                          IdUsuarioUltAnu = C.IdUsuarioUltAnu,
                          Fecha_UltAnu = C.Fecha_UltAnu,
                          pr_motivoAnulacion = C.pr_motivoAnulacion,
                          nom_pc = C.nom_pc,
                          ip = C.ip,
                          Estado = C.Estado,
                          IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                          Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                          Aparece_modu_Compras = C.Aparece_modu_Compras,
                          Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                          Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,
                          IdProducto_padre = C.IdProducto_padre,
                          lote_fecha_fab = C.lote_fecha_fab,
                          lote_fecha_vcto = C.lote_fecha_vcto,
                          lote_num_lote = C.lote_num_lote,
                          precio_1 = C.precio_1,

                          precio_2 = C.precio_2,
                          signo_2 = C.signo_2,
                          porcentaje_2 = C.porcentaje_2,

                          precio_3 = C.precio_3,
                          signo_3 = C.signo_3,
                          porcentaje_3 = C.porcentaje_3,

                          precio_4 = C.precio_4,
                          signo_4 = C.signo_4,
                          porcentaje_4 = C.porcentaje_4,

                          precio_5 = C.precio_5,
                          signo_5 = C.signo_5,
                          porcentaje_5 = C.porcentaje_5,
                          se_distribuye = C.se_distribuye,
                      }).ToList();

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_maneja_lote(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                lM = (from C in OECbtecble_Info.vwin_producto
                      where C.IdEmpresa == IdEmpresa
                      && C.tp_ManejaLote == true
                      select new in_Producto_Info
                      {
                          IdEmpresa = C.IdEmpresa,
                          Estado = C.Estado.Trim(),
                          Fecha_Transac = C.Fecha_Transac,
                          Fecha_UltAnu = C.Fecha_UltAnu,
                          Fecha_UltMod = C.Fecha_UltMod,
                          IdPresentacion = C.IdPresentacion,
                          nom_Categoria = C.ca_Categoria,
                          nom_Linea = C.nom_linea,
                          nom_Grupo = C.nom_grupo,
                          nom_SubGrupo = C.nom_subgrupo,
                          nom_Tipo_Producto = C.tp_descripcion,
                          pr_descripcion_2 = C.pr_descripcion_2,
                          pr_descripcion = C.pr_descripcion,
                          pr_descripcion2 = "[" + C.pr_codigo + "] " + C.pr_descripcion,
                          IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                          se_distribuye = C.se_distribuye,
                          IdMarca = C.IdMarca,
                          pr_descripcion_combo = C.pr_descripcion + " - " + C.nom_presentacion + " - "+C.ca_Categoria,
                          IdProducto = C.IdProducto,

                          IdProductoTipo = C.IdProductoTipo,

                          IdUnidadMedida = C.IdUnidadMedida.Trim(),
                          IdUsuario = C.IdUsuario.Trim(),
                          IdUsuarioUltAnu = C.IdUsuarioUltAnu,
                          IdUsuarioUltMod = C.IdUsuarioUltMod,
                          ip = C.ip.Trim(),
                          nom_pc = C.nom_pc.Trim(),
                          pr_codigo = C.pr_codigo.Trim(),
                          pr_codigo_barra = C.pr_codigo_barra.Trim(),
                          pr_observacion = C.pr_observacion.Trim(),
                          pr_pedidos = C.pr_pedidos,

                          precio_1 = C.precio_1,

                          precio_2 = C.precio_2,
                          signo_2 = C.signo_2,
                          porcentaje_2 = C.porcentaje_2,

                          precio_3 = C.precio_3,
                          signo_3 = C.signo_3,
                          porcentaje_3 = C.porcentaje_3,

                          precio_4 = C.precio_4,
                          signo_4 = C.signo_4,
                          porcentaje_4 = C.porcentaje_4,

                          precio_5 = C.precio_5,
                          signo_5 = C.signo_5,
                          porcentaje_5 = C.porcentaje_5,

                          IdCategoria = C.IdCategoria.Trim(),
                          IdLinea = C.IdLinea,
                          IdGrupo = C.IdGrupo,
                          IdSubGrupo = C.IdSubGrupo,
                          IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                          Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                          Aparece_modu_Compras = C.Aparece_modu_Compras,
                          Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                          Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,

                          IdProducto_padre = C.IdProducto_padre,
                          lote_fecha_fab = C.lote_fecha_fab,
                          lote_fecha_vcto = C.lote_fecha_vcto,
                          lote_num_lote = C.lote_num_lote,
                          pr_descripcion_padre = C.pr_descripcion_padre,
                          nom_Presentacion = C.nom_presentacion,

                      }).ToList();


                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Producto_maneja_inventario(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_Info info;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    in_Producto Entity = Context.in_Producto.Where(q=>q.IdEmpresa == IdEmpresa && q.IdProducto == IdProducto).FirstOrDefault();
                    if (Entity == null) return new in_Producto_Info();
                    in_ProductoTipo Entity_tipo = Context.in_ProductoTipo.Where(q => q.IdEmpresa == IdEmpresa && q.IdProductoTipo == Entity.IdProductoTipo).FirstOrDefault();
                    if (Entity_tipo == null) return new in_Producto_Info();
                    info = new in_Producto_Info
                    {
                        IdEmpresa = Entity.IdEmpresa,
                        IdProducto = Entity.IdProducto,
                        maneja_inventario = Entity_tipo.tp_ManejaInven == "S" ? true : false,
                        IdUnidadMedida_Consumo = Entity.IdUnidadMedida_Consumo
                    };
                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_ManejaSeries(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                lM = (from C in OECbtecble_Info.vwin_producto
                      where C.IdEmpresa == IdEmpresa
                      //&& C.pr_ManejaSeries == "S"
                      select new in_Producto_Info
       {
           IdEmpresa = C.IdEmpresa,
           Estado = C.Estado.Trim(),
           Fecha_Transac = C.Fecha_Transac,
           Fecha_UltAnu = C.Fecha_UltAnu,
           Fecha_UltMod = C.Fecha_UltMod,
           IdPresentacion = C.IdPresentacion,
           nom_Categoria = C.ca_Categoria,
           nom_Linea = C.nom_linea,
           nom_Grupo = C.nom_grupo,
           nom_SubGrupo = C.nom_subgrupo,
           nom_Tipo_Producto = C.tp_descripcion,
           pr_descripcion_2 = C.pr_descripcion_2,
           pr_descripcion = C.pr_descripcion,
           pr_descripcion2 = "[" + C.pr_codigo + "] " + C.pr_descripcion,
           IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,

           IdMarca = C.IdMarca,

           IdProducto = C.IdProducto,

           IdProductoTipo = C.IdProductoTipo,

           IdUnidadMedida = C.IdUnidadMedida.Trim(),
           IdUsuario = C.IdUsuario.Trim(),
           IdUsuarioUltAnu = C.IdUsuarioUltAnu,
           IdUsuarioUltMod = C.IdUsuarioUltMod,
           ip = C.ip.Trim(),
           nom_pc = C.nom_pc.Trim(),
           pr_codigo = C.pr_codigo.Trim(),
           pr_codigo_barra = C.pr_codigo_barra.Trim(),
           pr_observacion = C.pr_observacion.Trim(),
           pr_pedidos = C.pr_pedidos,

           precio_1 = C.precio_1,

           precio_2 = C.precio_2,
           signo_2 = C.signo_2,
           porcentaje_2 = C.porcentaje_2,

           precio_3 = C.precio_3,
           signo_3 = C.signo_3,
           porcentaje_3 = C.porcentaje_3,

           precio_4 = C.precio_4,
           signo_4 = C.signo_4,
           porcentaje_4 = C.porcentaje_4,

           precio_5 = C.precio_5,
           signo_5 = C.signo_5,
           porcentaje_5 = C.porcentaje_5,
           se_distribuye = C.se_distribuye,
           IdCategoria = C.IdCategoria.Trim(),
           IdLinea = C.IdLinea,
           IdGrupo = C.IdGrupo,
           IdSubGrupo = C.IdSubGrupo,

           IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
           Aparece_modu_Ventas = C.Aparece_modu_Ventas,
           Aparece_modu_Compras = C.Aparece_modu_Compras,
           Aparece_modu_Inventario = C.Aparece_modu_Inventario,
           Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,

           IdProducto_padre = C.IdProducto_padre,
           lote_fecha_fab = C.lote_fecha_fab,
           lote_fecha_vcto = C.lote_fecha_vcto,
           lote_num_lote = C.lote_num_lote,
           pr_descripcion_padre = C.pr_descripcion_padre
       }).ToList();
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool codigo_lote_existe(int IdEmpresa,decimal IdProducto_padre, string lote_numero)
        {
            try
            {
                lote_numero = lote_numero.Trim();
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.in_Producto
                              where q.IdEmpresa == IdEmpresa && q.lote_num_lote == lote_numero
                              && q.IdProducto_padre == IdProducto_padre
                              select q;

                    if (lst.Count() > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Codigo_Producto(int IdEmpresa, decimal IdProducto)
        {
            string cod_producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    cod_producto = item.pr_codigo;
                }
                return cod_producto;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Descripcion_Producto(int IdEmpresa, decimal IdProducto)
        {
            string Des_producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    Des_producto = item.pr_descripcion;
                }
                return Des_producto;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string DescripcionTot_Producto(int IdEmpresa, decimal IdProducto)
        {
            string producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    producto = "[" + item.IdProducto + "] [" + item.pr_codigo + "] [" + item.pr_descripcion + "]";
                }
                return producto;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {


                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdBodega == IdBodega && C.IdSucursal == IdSucursal

                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.pr_descripcion_2 = "[" + item.pr_codigo.Trim() + "]" + item.pr_descripcion.Trim();
                    info.IdBodega = item.IdBodega;
                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_pedidos = item.pr_Pedidos_inv;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.pr_codigo = item.pr_codigo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                    info.IdCtaCble_Costo_categoria = item.IdCtaCtble_Costo_categoria;
                    info.IdCtaCble_Inventario_categoria = item.IdCtaCtble_Inve_categoria;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Bodega = item.bo_Descripcion.Trim();
                    info.nom_Sucursal = item.Su_Descripcion;

                    info.nom_Categoria = item.nom_Categoria;
                    info.nom_Linea = item.nom_linea;
                    info.nom_Tipo_Producto = item.nom_Tipo_Producto;



                    lM.Add(info);
                }



                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_sucursal
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_stock = item.pr_stock;
                    info.pr_pedidos = item.pr_pedidos;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdUnidadMedida = item.IdUnidadMedida;


                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_compra(int IdEmpresa, int IdSucursal)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                using (EntitiesInventario OEInventario = new EntitiesInventario())
                {
                    OEInventario.SetCommandTimeOut(3000);

                    lM = (from C in OEInventario.vwin_producto_x_sucursal
                          where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                          && C.Aparece_modu_Compras == true
                          select new in_Producto_Info
                          {
                              pr_costo_promedio = C.pr_costo_promedio,
                              IdEmpresa = C.IdEmpresa,
                              IdProducto = C.IdProducto,
                              pr_codigo = C.pr_codigo.Trim(),
                              pr_descripcion = C.pr_descripcion,
                              pr_descripcion_2 = "[" + C.pr_codigo + "] - " + C.pr_descripcion,
                              precio_minimo = C.precio_minimo,
                              pr_stock = C.pr_stock,
                              pr_pedidos = C.pr_pedidos,

                              pr_precio_publico = C.pr_precio_publico,
                              pr_precio_minimo = C.pr_precio_minimo,
                              IdSucursal = C.IdSucursal,
                              IdUnidadMedida = C.IdUnidadMedida,


                              IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                              nom_UnidadMedida = C.Descripcion_UniMedida,
                              nom_Tipo_Producto = C.Descripcion_TipoConsumo,


                              IdCtaCble_Inventario = C.IdCtaCble_Inventario,
                              IdCtaCble_Costo = C.IdCtaCble_Costo,
                              IdCtaCble_Ven0 = C.IdCtaCble_Ven0,
                              IdCtaCble_VenIva = C.IdCtaCble_VenIva,
                              IdCtaCble_Vta = C.IdCtaCble_Vta,
                              IdCtaCble_CosBase0 = C.IdCtaCble_CosBase0,
                              IdCtaCble_CosBaseIva = C.IdCtaCble_CosBaseIva,
                              IdCtaCble_Des0 = C.IdCtaCble_Des0,
                              IdCtaCble_DesIva = C.IdCtaCble_DesIva,
                              IdCtaCble_Dev0 = C.IdCtaCble_Dev0,
                              IdCtaCble_DevIva = C.IdCtaCble_DevIva,

                              IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,

                              Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                              Aparece_modu_Compras = C.Aparece_modu_Compras,
                              Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                              Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,
                              IdProductoTipo = C.IdProductoTipo,
                          }).ToList();
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_ventas(int IdEmpresa, int IdSucursal)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_sucursal
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        && C.Aparece_modu_Ventas == true
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_stock = item.pr_stock;
                    info.pr_pedidos = item.pr_pedidos;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    

                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.IdProductoTipo = item.IdProductoTipo;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_ventas(int IdEmpresa)
        {                List<in_Producto_Info> lM = new List<in_Producto_Info>();

            try
            {

                EntitiesInventario OEInventario = new EntitiesInventario();
               lM =( from C in OEInventario.in_Producto
                                        join presentacion in OEInventario.in_presentacion
                                        on C.IdPresentacion equals presentacion.IdPresentacion
                                        where C.IdEmpresa == IdEmpresa
                                        && C.IdEmpresa==presentacion.IdEmpresa
                                        && C.Aparece_modu_Ventas == true
                                        select  new in_Producto_Info
                                        {
                    IdEmpresa = C.IdEmpresa,
                    IdProducto = C.IdProducto,
                    pr_codigo = C.pr_codigo.Trim(),
                    pr_descripcion = C.pr_descripcion,
                    pr_descripcion_2 = C.pr_descripcion_2 == null ? "[" + C.pr_codigo + "] - " + C.pr_descripcion : C.pr_descripcion_2,
                    precio_1 = C.precio_1,
                    precio_2 = C.precio_2,
                    precio_3 = C.precio_3,
                    precio_4 = C.precio_4,
                    precio_5 = C.precio_5,
                    IdUnidadMedida = C.IdUnidadMedida,
                    pr_codigo_barra = C.pr_codigo_barra,
                    IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                    IdProducto_padre = C.IdProducto_padre,
                    IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,

                    Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                    Aparece_modu_Compras = C.Aparece_modu_Compras,
                    Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                    Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,
                    IdProductoTipo = C.IdProductoTipo,
                    lote_fecha_fab = C.lote_fecha_fab,
                    lote_fecha_vcto = C.lote_fecha_vcto,
                    lote_num_lote = C.lote_num_lote,
                    nom_Presentacion = presentacion.nom_presentacion,

                    pr_descripcion_combo = C.pr_descripcion + " - " + presentacion.nom_presentacion
                    }).ToList();

               foreach (var item in lM.Where(q=>q.lote_fecha_vcto != null))
               {
                   item.pr_descripcion_combo += " - " + item.lote_num_lote + " - " + Convert.ToDateTime(item.lote_fecha_vcto).Date.ToShortDateString();
               }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_x_modulo_mantenimiento(int IdEmpresa)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_Producto_x_man_tipo_horas_facturacion
                                        where C.IdEmpresa == IdEmpresa
                                        && C.Aparece_modu_Ventas == true
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = item.pr_descripcion_2 == null ? "[" + item.pr_codigo + "] - " + item.pr_descripcion : item.pr_descripcion_2;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.IdUnidadMedida = item.IdUnidadMedida;

                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.IdProductoTipo = item.IdProductoTipo;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_ventas(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        && C.IdBodega == IdBodega
                                        && C.Aparece_modu_Ventas == true
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_stock = item.pr_stock;


                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdUnidadMedida = item.IdUnidadMedida;


                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.pr_descripcion_combo = item.pr_descripcion + " - " + item.nom_presentacion;
                    lM.Add(info);
                }

                foreach (var item in lM.Where(q => q.lote_fecha_vcto != null))
                {
                    item.pr_descripcion_combo += " - " + item.nom_Categoria + " - " + item.lote_num_lote + " - " + Convert.ToDateTime(item.lote_fecha_vcto).Date.ToShortDateString();
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_inventario(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa
                                        && C.IdSucursal == IdSucursal
                                        && IdBodega_ini <= C.IdBodega && C.IdBodega <= IdBodega_fin
                                        && C.Aparece_modu_Inventario == true
                                        orderby C.IdEmpresa, C.IdSucursal, C.IdBodega, C.nom_Categoria, C.nom_linea
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;

                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_disponible = item.pr_Disponible;
                    info.pr_Disponible = item.pr_Disponible;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.nom_Linea = item.nom_linea;
                    info.nom_Categoria = item.nom_Categoria;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_UnidadMedida_Consumo = item.Descripcion_TipoConsumo;

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;


                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.pr_codigo_barra = item.pr_codigo_barra;
                    info.lote_fecha_fab = item.lote_fecha_fab;
                    info.lote_fecha_vcto = item.lote_fecha_vcto;
                    info.lote_num_lote = item.lote_num_lote;
                    info.nom_Presentacion = item.nom_presentacion;

                    info.pr_descripcion_combo = item.pr_descripcion + " - " + item.nom_presentacion + " - " + item.lote_num_lote + " - " + (item.lote_fecha_vcto == null ? "" : Convert.ToDateTime(item.lote_fecha_vcto).Date.ToString());
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_inventario(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                lM = (from C in OEInventario.in_Producto
                      join pr in OEInventario.in_presentacion
                             on new { C.IdEmpresa, C.IdPresentacion } equals new { pr.IdEmpresa, pr.IdPresentacion }
                      where C.IdEmpresa == IdEmpresa
                      && C.Aparece_modu_Inventario == true
                      select new in_Producto_Info
                      {
                          IdEmpresa = C.IdEmpresa,
                          IdProducto = C.IdProducto,
                          pr_codigo = C.pr_codigo,
                          pr_descripcion = C.pr_descripcion,                          
                          precio_1 = C.precio_1,
                          precio_2 = C.precio_2,
                          precio_3 = C.precio_3,
                          precio_4 = C.precio_4,
                          precio_5 = C.precio_5,
                          IdUnidadMedida = C.IdUnidadMedida,
                          IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                          IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                          Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                          Aparece_modu_Compras = C.Aparece_modu_Compras,
                          Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                          Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,
                          pr_codigo_barra = C.pr_codigo_barra,
                          lote_num_lote = C.lote_num_lote,
                          lote_fecha_vcto = C.lote_fecha_vcto,
                          nom_Presentacion = pr.nom_presentacion
                      }).ToList();

                lM.ForEach(q => { q.pr_descripcion_2 = "[" + q.pr_codigo + "] - " + q.pr_descripcion; q.pr_descripcion_combo = q.pr_descripcion + " - " + q.nom_Presentacion + " - " + q.lote_num_lote + " - " + (q.lote_fecha_vcto == null ? "" : Convert.ToDateTime(q.lote_fecha_vcto).Date.ToString()); });
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal, int IdBodega, List<in_Producto_Info> listProducto)
        {
            try
            {
                var QIdProductosAfind = from P in listProducto
                                        select P.IdProducto;

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdBodega == IdBodega && C.IdSucursal == IdSucursal
                                        && QIdProductosAfind.Contains(C.IdProducto)
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.IdBodega = item.IdBodega;
                    info.nom_Bodega = item.bo_Descripcion.Trim();

                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_Disponible = item.pr_Disponible;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.IdSucursal = item.IdSucursal;
                    info.pr_costo_promedio = item.pr_costo_promedio;

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;


                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;


                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(in_Producto_Info prI, ref decimal IdProducto, ref string mensaje)
        {
            try
            {
                try
                {
                    using (EntitiesInventario context = new EntitiesInventario())
                    {
                        EntitiesInventario EDB = new EntitiesInventario();
                        /*
                        if (prI.pr_codigo != "")
                        {
                            var existe = (from per in EDB.in_Producto
                                          where per.IdEmpresa == prI.IdEmpresa
                                          && per.pr_codigo == prI.pr_codigo
                                          select per).ToList().Count();
                            if (existe != 0)
                            {
                                mensaje = "El Código ingresado ya existe por favor ingresar uno distinto";
                                return false;
                            }
                        }*/
                        /*
                        if (!string.IsNullOrEmpty(prI.lote_num_lote))
                        {
                            var l = from q in EDB.in_Producto
                                    where q.IdEmpresa == prI.IdEmpresa
                                    && q.IdProducto_padre == prI.IdProducto_padre
                                    && q.lote_num_lote == prI.lote_num_lote
                                    select q;

                            if (l.Count() > 0)
                            {
                                mensaje = "No se puede crear un producto que tenga el mismo código de lote y el producto padre";
                                return false;
                            }
                        }
                        */
                        var Q = from per in EDB.in_Producto
                                where per.IdEmpresa == prI.IdEmpresa
                                && per.IdProducto == prI.IdProducto
                                select per;

                        if (Q.ToList().Count == 0)
                        {
                            var address = new in_Producto();

                            address.IdEmpresa = prI.IdEmpresa;
                            IdProducto = GetIdProducto(prI.IdEmpresa);
                            prI.IdProducto = IdProducto;
                            address.IdProducto = IdProducto;

                            if (string.IsNullOrWhiteSpace(prI.pr_codigo))
                            {
                                address.pr_codigo = prI.pr_codigo = Convert.ToString(IdProducto);
                            }
                            else
                            {
                                address.pr_codigo = prI.pr_codigo.Trim();
                            }
                            address.se_distribuye = prI.se_distribuye == null ? false : Convert.ToBoolean(prI.se_distribuye);
                            address.pr_descripcion = prI.pr_descripcion.Trim();
                            address.pr_descripcion_2 = string.IsNullOrEmpty(prI.pr_descripcion_2) == true ? prI.pr_descripcion : prI.pr_descripcion_2;
                            address.IdProductoTipo = prI.IdProductoTipo;
                            address.IdMarca = prI.IdMarca;
                            address.IdPresentacion = Convert.ToString(prI.IdPresentacion);
                            address.IdCategoria = prI.IdCategoria;
                            address.IdLinea = prI.IdLinea;
                            address.IdGrupo = prI.IdGrupo;
                            address.IdSubGrupo = prI.IdSubGrupo;
                            address.IdUnidadMedida = prI.IdUnidadMedida;
                            address.IdUnidadMedida_Consumo = prI.IdUnidadMedida_Consumo;
                            //Naturaleza
                            address.pr_codigo_barra = prI.pr_codigo_barra == null ? "" : prI.pr_codigo_barra;//27
                            address.pr_observacion = prI.pr_observacion == null ? "" : prI.pr_observacion;//39
                            address.precio_1 = prI.precio_1;
                            address.precio_2 = prI.precio_2;
                            address.precio_3 = prI.precio_3;
                            address.precio_4 = prI.precio_4;
                            address.precio_5 = prI.precio_5;

                            address.signo_2 = prI.signo_2;
                            address.signo_3 = prI.signo_3;
                            address.signo_4 = prI.signo_4;
                            address.signo_5 = prI.signo_5;

                            address.signo_2 = prI.signo_2;
                            address.signo_3 = prI.signo_3;
                            address.signo_4 = prI.signo_4;
                            address.signo_5 = prI.signo_5;

                            address.IdUsuario = (prI.IdUsuario == null) ? "" : prI.IdUsuario.Trim();//20
                            address.Fecha_Transac = DateTime.Now;//5
                            address.IdUsuarioUltMod = (prI.IdUsuarioUltMod == null) ? "" : prI.IdUsuarioUltMod.Trim();//22
                            address.Fecha_UltMod = DateTime.Now;//7

                            //address.IdUsuarioUltAnu = (prI.IdUsuarioUltAnu == null) ? "" : prI.IdUsuarioUltAnu.Trim();//21
                            //address.Fecha_UltAnu = DateTime.Now;//6
                            //pr_motivoAnulacion

                            address.ip = (prI.ip == null) ? "" : prI.ip;//23
                            address.nom_pc = (prI.nom_pc == null) ? "" : prI.nom_pc;//24
                            address.Estado = prI.Estado;//4

                            address.IdCod_Impuesto_Iva = (prI.IdCod_Impuesto_Iva == null) ? "IVA0" : prI.IdCod_Impuesto_Iva;


                            address.Aparece_modu_Ventas = prI.Aparece_modu_Ventas;
                            address.Aparece_modu_Compras = prI.Aparece_modu_Compras;
                            address.Aparece_modu_Inventario = prI.Aparece_modu_Inventario;
                            address.Aparece_modu_Activo_F = prI.Aparece_modu_Activo_F;
                            
                            address.IdProducto_padre = prI.IdProducto_padre;
                            address.lote_fecha_fab = prI.lote_fecha_fab;
                            address.lote_fecha_vcto = prI.lote_fecha_vcto;
                            address.lote_num_lote = prI.lote_num_lote;
                            address.pr_codigo2 = prI.pr_codigo2;
                            context.in_Producto.Add(address);
                            context.SaveChanges();

                            mensaje = "Grabacion ok..";

                        }
                        else
                            return false;
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarNombreItem(int IdEmpresa, string NombreItem)
        {
            try
            {
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = (from q in listado.in_Producto
                                  where q.IdEmpresa == IdEmpresa
                                  && q.pr_descripcion.Trim() == NombreItem.Trim()
                                  select q).Count();

                    if (select == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarNombreItem_x_TipoProducto(int IdEmpresa, string NombreItem, int IdTipoProducto)
        {
            try
            {
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = (from q in listado.in_Producto
                                  where q.IdEmpresa == IdEmpresa
                                  && q.pr_descripcion.Trim() == NombreItem.Trim()
                                  && q.IdProductoTipo == IdTipoProducto
                                  select q).Count();

                    if (select == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> get_list_Producto_stock_X_lote(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto_padre)
        {
            try
            {
                List<in_Producto_Info> Lista;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Lista = (from q in Context.vwin_producto_x_tb_bodega_stock_x_lote
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega
                              && q.IdProducto_padre == IdProducto_padre
                              select new in_Producto_Info
                              {
                                  IdEmpresa = q.IdEmpresa,
                                  IdSucursal = q.IdSucursal,
                                  IdBodega = q.IdBodega,
                                  IdProducto = q.IdProducto,
                                  pr_codigo = q.pr_codigo,
                                  pr_descripcion = q.pr_descripcion,
                                  IdProducto_padre = q.IdProducto_padre,
                                  lote_fecha_fab = q.lote_fecha_fab,
                                  lote_fecha_vcto = q.lote_fecha_vcto,
                                  lote_num_lote = q.lote_num_lote,
                                  pr_stock = q.stock,                                  
                              }).ToList();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(in_Producto_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdProducto == prI.IdProducto);
                    if (contact != null)
                    {
                        contact.pr_descripcion_2 = prI.pr_descripcion_2;//1
                        contact.Estado = prI.Estado;//4
                        contact.Fecha_UltMod = DateTime.Now;//7
                        contact.IdCategoria = prI.IdCategoria;//8
                        contact.pr_descripcion = prI.pr_descripcion;//9
                        contact.pr_descripcion_2 = string.IsNullOrEmpty(prI.pr_descripcion_2) == true ? prI.pr_descripcion : prI.pr_descripcion_2;
                        contact.IdUnidadMedida_Consumo = prI.IdUnidadMedida_Consumo;//12
                        contact.IdEmpresa = prI.IdEmpresa;//13
                        contact.IdMarca = prI.IdMarca;//14
                        contact.IdPresentacion = Convert.ToString(prI.IdPresentacion);//15
                        contact.IdProductoTipo = prI.IdProductoTipo;//18
                        contact.IdUnidadMedida = prI.IdUnidadMedida;//19
                        contact.IdUsuarioUltMod = (prI.IdUsuarioUltMod == null) ? "" : prI.IdUsuarioUltMod.Trim();//22
                        contact.pr_codigo = (prI.pr_codigo == null) ? Convert.ToString(contact.IdProducto) : prI.pr_codigo;//26
                        contact.pr_codigo_barra = prI.pr_codigo_barra == null ? "" : prI.pr_codigo_barra;//27
                        contact.pr_descripcion = prI.pr_descripcion;//31
                        contact.pr_observacion = prI.pr_observacion == null ? "" : prI.pr_observacion;//39
                        contact.precio_1 = prI.precio_1;
                        contact.precio_2 = prI.precio_2;
                        contact.precio_3 = prI.precio_3;
                        contact.precio_4 = prI.precio_4;
                        contact.precio_5 = prI.precio_5;

                        contact.signo_2 = prI.signo_2;
                        contact.signo_3 = prI.signo_3;
                        contact.signo_4 = prI.signo_4;
                        contact.signo_5 = prI.signo_5;

                        contact.porcentaje_2 = prI.porcentaje_2;
                        contact.porcentaje_3 = prI.porcentaje_3;
                        contact.porcentaje_4 = prI.porcentaje_4;
                        contact.porcentaje_5 = prI.porcentaje_5;

                        contact.IdLinea = prI.IdLinea;//53
                        contact.IdGrupo = prI.IdGrupo;//54
                        contact.IdSubGrupo = prI.IdSubGrupo;//55
                        contact.IdCod_Impuesto_Iva = prI.IdCod_Impuesto_Iva;

                        contact.Aparece_modu_Ventas = prI.Aparece_modu_Ventas;
                        contact.Aparece_modu_Compras = prI.Aparece_modu_Compras;
                        contact.Aparece_modu_Inventario = prI.Aparece_modu_Inventario;
                        contact.Aparece_modu_Activo_F = prI.Aparece_modu_Activo_F;

                        contact.Fecha_UltMod = DateTime.Now;

                        contact.IdProducto_padre = prI.IdProducto_padre;
                        contact.lote_fecha_fab = prI.lote_fecha_fab;
                        contact.lote_fecha_vcto = prI.lote_fecha_vcto;
                        contact.lote_num_lote = prI.lote_num_lote;
                        contact.se_distribuye = prI.se_distribuye;
                        contact.pr_codigo2 = prI.pr_codigo2;


                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
                        int row = context.Database.ExecuteSqlCommand("UPDATE in_Producto SET pr_descripcion = '" + prI.pr_descripcion + "', precio_1 = " + prI.precio_1 + ", precio_2 = " + prI.precio_2 + ", precio_3 = " + prI.precio_3 + ", precio_4 = " + prI.precio_4 + ", precio_5 = " + prI.precio_5 + ", signo_2 = '" + prI.signo_2 + "', signo_3 = '" + prI.signo_3 + "', signo_4 = '" + prI.signo_4 + "', signo_5 = '" + prI.signo_5 + "', porcentaje_2 = " + prI.porcentaje_2 + ", porcentaje_3 = " + prI.porcentaje_3 + ", porcentaje_4 = " + prI.porcentaje_4 + ", porcentaje_5 = " + prI.porcentaje_5 + ", IdCod_Impuesto_Iva = '" + prI.IdCod_Impuesto_Iva + "', pr_codigo = '" + prI.pr_codigo + "', pr_codigo_barra = '" + prI.pr_codigo_barra + "', pr_codigo2 = '" + prI.pr_codigo2 + "' where in_Producto.IdEmpresa = " + prI.IdEmpresa + " AND in_Producto.IdProducto_padre = " + prI.IdProducto);
                    }
                }
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public decimal GetIdProducto(int IdEmpresa)
        {
            try
            {
                decimal IdcbteCble;
                EntitiesInventario OECbtecble = new EntitiesInventario();
                var q = from A in OECbtecble.in_Producto
                        where A.IdEmpresa == IdEmpresa
                        select A;

                if (q.ToList().Count < 1)
                {
                    IdcbteCble = 1;
                }
                else
                {
                    OECbtecble = new EntitiesInventario();
                    var selectCbtecble = (from CbtCble in OECbtecble.in_Producto
                                          where CbtCble.IdEmpresa == IdEmpresa
                                          select CbtCble.IdProducto).Max();

                    IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdcbteCble;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetIdProducto_x_Categoria(int IdEmpresa, string IdCategoria)
        {
            try
            {
                decimal IdcbteCble;
                EntitiesInventario OEPrd = new EntitiesInventario();
                var q = from A in OEPrd.in_Producto
                        where A.IdEmpresa == IdEmpresa
                        select A;

                if (q.ToList().Count < 1)
                {
                    IdcbteCble = 1;
                }
                else
                {
                    OEPrd = new EntitiesInventario();
                    var selectCbtecble = (from PrdxCat in OEPrd.in_Producto
                                          where PrdxCat.IdEmpresa == IdEmpresa && PrdxCat.IdCategoria == IdCategoria
                                          select PrdxCat.IdProducto).Max();

                    IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdcbteCble;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string GetCodProducto_x_Categoria(int IdEmpresa, string IdCategoria)
        {
            try
            {
                string CodPrdxCat;
                decimal iIdProducto_x_Categoria;

                EntitiesInventario OEPrd = new EntitiesInventario();
                var q = from A in OEPrd.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdCategoria == IdCategoria
                        select A;

                if (q.ToList().Count < 1)
                {
                    CodPrdxCat = "1";
                }
                else
                {

                    iIdProducto_x_Categoria = this.GetIdProducto_x_Categoria(IdEmpresa, IdCategoria) - 1;

                    OEPrd = new EntitiesInventario();
                    var selectPrdxCat = (from PrdxCat in OEPrd.in_Producto
                                         where PrdxCat.IdEmpresa == IdEmpresa && PrdxCat.IdProducto == iIdProducto_x_Categoria
                                         select PrdxCat.pr_codigo).ToArray();

                    CodPrdxCat = selectPrdxCat[0];
                }
                return CodPrdxCat;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(in_Producto_Info ProductoInfo, ref  string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(prod1 => prod1.IdEmpresa == ProductoInfo.IdEmpresa && prod1.IdProducto == ProductoInfo.IdProducto);
                    if (contact != null)
                    {
                        //no elimino el registro solo cambia el estado de activo a inactivo

                        contact.Estado = "I"; //cambio el estado de activo por inactivo
                        contact.pr_observacion = " ***ANULADO***" + contact.pr_observacion;
                        contact.IdUsuarioUltAnu = ProductoInfo.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltMod = ProductoInfo.IdUsuarioUltMod;
                        contact.pr_motivoAnulacion = ProductoInfo.pr_motivoAnulacion;
                        context.SaveChanges();
                        int row = context.Database.ExecuteSqlCommand("UPDATE in_Producto SET Estado = 'I' where in_Producto.IdEmpresa = " + ProductoInfo.IdEmpresa + " AND in_Producto.IdProducto_padre = " + ProductoInfo.IdProducto);
                        mensaje = "Anulacion Exitosa..";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Anular:  " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Get_Info_BuscarProducto(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_Producto
                                     where C.IdEmpresa == IdEmpresa && C.IdProducto == IdProducto
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.Fecha_UltMod = item.Fecha_UltMod;
                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.pr_descripcion_2 = item.pr_descripcion_2;


                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                    prd.IdUsuario = item.IdUsuario;
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.ip = item.ip;
                    prd.nom_pc = item.nom_pc;
                    prd.pr_codigo = item.pr_codigo.Trim();
                    prd.pr_codigo_barra = item.pr_codigo_barra;
                    prd.pr_descripcion = item.pr_descripcion.Trim();
                    prd.pr_observacion = item.pr_observacion;
                    prd.precio_1 = item.precio_1;
                    prd.precio_2 = item.precio_2;
                    prd.precio_3 = item.precio_3;
                    prd.precio_4 = item.precio_4;
                    prd.precio_5 = item.precio_5;
                    prd.IdLinea = Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                }
                return (prd);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info get_info_x_codigo(int IdEmpresa, string pr_codigo)
        {
            try
            {
                in_Producto_Info info;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var Entity = Context.in_Producto.Where(q => q.IdEmpresa == IdEmpresa && q.pr_codigo == pr_codigo).FirstOrDefault();
                    if (Entity == null) return null;
                    info = new in_Producto_Info
                    {
                        IdEmpresa = Entity.IdEmpresa,
                        IdProducto = Entity.IdProducto,
                        pr_codigo = Entity.pr_codigo,
                        pr_codigo2 = Entity.pr_codigo2,
                        pr_descripcion = Entity.pr_descripcion,
                        pr_descripcion_2 = Entity.pr_descripcion_2,
                        IdProductoTipo = Entity.IdProductoTipo,
                        IdMarca = Entity.IdMarca,
                        IdPresentacion = Entity.IdPresentacion,
                        IdCategoria = Entity.IdCategoria,
                        IdLinea = Entity.IdLinea,
                        IdGrupo = Entity.IdGrupo,
                        IdSubGrupo = Entity.IdSubGrupo,
                        IdUnidadMedida = Entity.IdUnidadMedida,
                        IdUnidadMedida_Consumo = Entity.IdUnidadMedida_Consumo,
                        pr_codigo_barra = Entity.pr_codigo_barra,
                        pr_observacion = Entity.pr_observacion,
                        Estado = Entity.Estado,
                        IdCod_Impuesto_Iva = Entity.IdCod_Impuesto_Iva,
                        Aparece_modu_Ventas = Entity.Aparece_modu_Ventas,
                        Aparece_modu_Activo_F = Entity.Aparece_modu_Activo_F,
                        Aparece_modu_Compras = Entity.Aparece_modu_Compras,
                        Aparece_modu_Inventario = Entity.Aparece_modu_Inventario,
                        IdProducto_padre = Entity.IdProducto,
                        lote_num_lote = Entity.lote_num_lote,
                        lote_fecha_fab = Entity.lote_fecha_fab,
                        lote_fecha_vcto = Entity.lote_fecha_vcto,
                        precio_1 = Entity.precio_1,
                        precio_2 = Entity.precio_2,
                        precio_3 = Entity.precio_3,
                        precio_4 = Entity.precio_4,
                        precio_5 = Entity.precio_5,
                        porcentaje_2 = Entity.porcentaje_2,
                        porcentaje_3 = Entity.porcentaje_3,
                        porcentaje_4 = Entity.porcentaje_4,
                        porcentaje_5 = Entity.porcentaje_5,
                        signo_2 = Entity.signo_2,
                        signo_3 = Entity.signo_3,
                        signo_4 = Entity.signo_4,
                        signo_5 = Entity.signo_5,
                        se_distribuye = Entity.se_distribuye
                    };
                }

                return info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public in_Producto_Info Get_info_Producto_para_combo(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_Info info;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    info = (from p in Context.in_Producto
                                          join c in Context.in_categorias
                                              on new { p.IdEmpresa, p.IdCategoria } equals new { c.IdEmpresa, c.IdCategoria }
                                          join pr in Context.in_presentacion
                                          on new { p.IdEmpresa, p.IdPresentacion } equals new { pr.IdEmpresa, pr.IdPresentacion }
                                          where p.IdEmpresa == IdEmpresa && p.IdProducto == IdProducto
                                          select new in_Producto_Info
                                          {
                                              IdEmpresa = p.IdEmpresa,
                                              IdProducto = p.IdProducto,
                                              IdProducto_padre = p.IdProducto_padre,
                                              pr_descripcion = p.pr_descripcion,
                                              pr_codigo = p.pr_codigo,
                                              pr_codigo_barra = p.pr_codigo_barra,
                                              lote_fecha_fab = p.lote_fecha_fab,
                                              lote_fecha_vcto = p.lote_fecha_vcto,
                                              lote_num_lote = p.lote_num_lote,
                                              precio_1 = p.precio_1,
                                              precio_2 = p.precio_2,
                                              precio_3 = p.precio_3,
                                              precio_4 = p.precio_4,
                                              precio_5 = p.precio_5,
                                              IdCod_Impuesto_Iva = p.IdCod_Impuesto_Iva,
                                              IdUnidadMedida = p.IdUnidadMedida,
                                              IdUnidadMedida_Consumo = p.IdUnidadMedida_Consumo,
                                              nom_Categoria = c.ca_Categoria,
                                              nom_Presentacion = pr.nom_presentacion                                              
                                          }).FirstOrDefault();
                    if (info == null)
                        return null;
                    
                    info.pr_descripcion_2 = "[" + info.pr_codigo + "] - " + info.pr_descripcion;
                    info.pr_descripcion_combo = info.pr_descripcion + " - " + info.nom_Presentacion + " - " + info.lote_num_lote + " - " + (info.lote_fecha_vcto == null ? "" : Convert.ToDateTime(info.lote_fecha_vcto).Date.ToString());
                }
                
                return info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public in_Producto_Info Get_info_Producto(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_Producto
                                     where C.IdEmpresa == IdEmpresa && C.IdProducto == IdProducto
                                     select C;

                foreach (var item in selectCbtecble)
                {

                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();

                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.IdUnidadMedida = item.IdUnidadMedida;
                    prd.precio_1 = item.precio_1;
                    prd.precio_2 = item.precio_2;
                    prd.precio_3 = item.precio_3;
                    prd.precio_4 = item.precio_4;
                    prd.precio_5 = item.precio_5;
                    prd.IdMarca = item.IdMarca;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.pr_descripcion_2 = item.pr_descripcion_2;

                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.IdLinea = Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;



                }
                return (prd);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_MateriaPrima(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {

                    string Query = "select * from in_producto where IdEmpresa =" + IdEmpresa + " and IdProductoTipo =" +
                                                "(select IdProductoTipo from in_productotipo where IdEmpresa =" + IdEmpresa + " and EsMateriaPrima = 'S' )";
                    var Producto = Oentities.Database.SqlQuery<in_Producto_Info>(Query);

                    return Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_ProductosTerminados(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {



                    var selectCbtecble = from C in Oentities.in_Producto
                                         join t in Oentities.in_ProductoTipo
                                         on new { C.IdEmpresa, C.IdProductoTipo } equals new { t.IdEmpresa, t.IdProductoTipo }
                                         where C.IdEmpresa == IdEmpresa
                                         //&& t.EsProductoTerminado=="S"
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.precio_1 = item.precio_1;
                        prd.precio_2 = item.precio_2;
                        prd.precio_3 = item.precio_3;
                        prd.precio_4 = item.precio_4;
                        prd.precio_5 = item.precio_5;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                        prd.IdProductoTipo = item.IdProductoTipo;
                        //prd.IdNaturaleza = item.IdNaturaleza;

                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;




                        lista.Add(prd);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
  
        public Boolean ValidarProductExiste(string Nombre)
        {
            try
            {
                EntitiesInventario oen = new EntitiesInventario();
                var Prod = from q in oen.in_Producto
                           where q.pr_descripcion == Nombre
                           select q;
                if (Prod.ToList().Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public in_Producto_Info Get_Info_ProductoXNombre(int IdEmpresa, string Descripcion)
        {
            try
            {
                using (EntitiesInventario Oenti = new EntitiesInventario())
                {

                    in_Producto_Info Info = new in_Producto_Info();
                    string query = "select * from in_Producto where IdEmpresa = " + IdEmpresa + " and pr_descripcion like'" + Descripcion + "'";
                    var Consulta = Oenti.Database.SqlQuery<in_Producto_Info>(query);
                    Info = Consulta.First();

                    return Info;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_ProductosXModeloProduccion(int IdEmpresa, int IdModeloProduccion)
        {
            try
            {
                EntitiesInventario Oen = new EntitiesInventario();
                string Querty = "select * from in_Producto where IdProducto in"
                                + " (select  IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa = " + IdEmpresa + " and IdModeloProd =" + IdModeloProduccion + ") "
                                + " and IdEmpresa = " + IdEmpresa;
                return Oen.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_MateriaPrimaModulosdeProduccion(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                EntitiesInventario oent = new EntitiesInventario();
                string Querty = "select * from in_Producto where IdProductoTipo = "
                               + " (select  IdProductoTipo from in_ProductoTipo where IdEmpresa = " + IdEmpresa + " and EsMateriaPrima = 'S' ) and IdEmpresa =  " + IdEmpresa +
                                "    and IdProducto in(select IdProducto from in_producto_x_tb_bodega  where IdEmpresa = " + IdEmpresa + ")";

                return oent.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public List<in_Producto_Info> Get_list_ProductosMateriaPrima(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {



                    var selectCbtecble = from C in Oentities.in_Producto
                                         join t in Oentities.in_ProductoTipo
                                         on new { C.IdEmpresa, C.IdProductoTipo } equals new { t.IdEmpresa, t.IdProductoTipo }
                                         where C.IdEmpresa == IdEmpresa
                                         //&& t.EsMateriaPrima == "S"
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.precio_1 = item.precio_1;
                        prd.precio_2 = item.precio_2;
                        prd.precio_3 = item.precio_3;
                        prd.precio_4 = item.precio_4;
                        prd.precio_5 = item.precio_5;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                        prd.IdProductoTipo = item.IdProductoTipo;

                        //prd.IdNaturaleza = item.IdNaturaleza;

                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;




                        lista.Add(prd);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
      
        public List<in_Producto_Info> Get_list_Productos_X_Proveedor(int IdEmpresa, decimal IdProveedor, int IdEmpresa_x_Proveedor, string Esta = "")
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                EntitiesInventario Oen = new EntitiesInventario();
                string NomPro = "";
                string Descrip = "";
                if (Esta == "")
                {

                    NomPro = "  inner join in_producto_x_cp_proveedor D on A.IdProducto = D.IdProducto and A.IdEmpresa = D.IdEmpresa_prod" +
                                 "   and d.IdEmpresa_prov =" + IdEmpresa + " and d.IdProveedor =" + IdProveedor + " ";

                    Descrip = ", D.NomProducto_en_Proveedor as Producto ";
                }

                string Query = "   SELECT A.*, B.ca_Categoria, C.Descripcion as Marca " + Descrip +
                                   " FROM in_Producto AS A INNER JOIN " +
                                   " in_categorias AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdCategoria = B.IdCategoria INNER JOIN " +
                                   " in_Marca AS C ON A.IdEmpresa = C.IdEmpresa AND A.IdMarca = C.IdMarca " + NomPro +

                                   " where ( cast(A.IdEmpresa as varchar(10)) + cast(A.IdProducto as varchar(20)) ) " + Esta + " in  " +
                                   " ( " +
                                   " select cast(A.IdEmpresa_prod as varchar(10)) + cast(A.IdProducto as varchar(20)) " +
                                   " from in_producto_x_cp_proveedor A " +
                                   " where A.IdEmpresa_prov = " + IdEmpresa_x_Proveedor +
                                   " and A.IdProveedor = " + IdProveedor +
                                   " ) and A.IdEmpresa = " + IdEmpresa;

                lista = Oen.Database.SqlQuery<in_Producto_Info>(Query).ToList();

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Productos_x_Empresa(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                EntitiesInventario Oen = new EntitiesInventario();

                var select = from q in Oen.vwin_in_Producto_x_tb_bodega_x_UnidadMedida
                             where q.IdEmpresa == IdEmpresa
                             select q;

                foreach (var item in select)
                {
                    in_Producto_Info Info = new in_Producto_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProducto = item.IdProducto;
                    Info.pr_codigo = item.pr_codigo;
                    Info.pr_descripcion = item.pr_descripcion;
                    Info.pr_codigo_barra = item.pr_codigo_barra;
                    Info.IdProductoTipo = item.IdProductoTipo;
                    Info.IdPresentacion = item.IdPresentacion;
                    Info.IdCategoria = item.IdCategoria;
                    Info.pr_observacion = item.pr_observacion;
                    Info.IdUnidadMedida = item.IdUnidadMedida;
                    Info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    Info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;
                    Info.pr_costo_promedio = item.pr_costo_promedio_bodega;
                    Info.pr_stock_Bodega = item.pr_stock_Bodega;
                    Info.IdCtaCble_Inventario = item.IdCtaCble_Inven;
                    Info.pr_stock = item.pr_stock;
                    Info.pr_pedidos = item.pr_pedidos;
                    Info.pr_precio_publico = item.pr_precio_publico;
                    Info.IdLinea = Convert.ToInt32(item.IdLinea);
                    Info.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    Info.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);
                    Info.IdBodega = item.IdBodega;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMarca = item.IdMarca;
                    Info.nom_pc = item.nom_pc;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuario = item.IdUsuario;


                    Info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    Info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    Info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    Info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    Info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    Info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    Info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    Info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    Info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;




                    Info.ip = item.ip;
                    Info.Estado = item.Estado;
                    Info.CodBarra = item.pr_codigo_barra;

                    Info.IdPresentacion = item.IdPresentacion;

                    Info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    Info.pr_stock_minimo = item.pr_stock_minimo;
                    Info.pr_descripcion_2 = item.pr_descripcion_2;
                    Info.pr_motivoAnulacion = item.pr_motivoAnulacion;

                    Info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;


                    Info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    Info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    Info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    Info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lista.Add(Info);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_ProductoTerminado_X_ModeloDeProduccion(int IdEmpresa, int IdTipoModelo)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                using (EntitiesInventario Oen = new EntitiesInventario())
                {


                    string Query = "select * from in_Producto where IdProducto in (select IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa =" + IdEmpresa + " and IdModeloProd=" + IdTipoModelo + "and Tipo='PRODTERMI') and IdEmpresa =" + IdEmpresa;

                    var Consulta = Oen.Database.SqlQuery<in_Producto_Info>(Query);
                    lista = Consulta.ToList();
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool Delete_Todos_Producto(int IdEmpresa, ref string MensajeError)
        {

            try
            {
                using (EntitiesCompras Entity = new EntitiesCompras())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete in_producto where IdEmpresa = " + IdEmpresa);
                }
                MensajeError = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }


        }

        public in_Producto_Info GetProducto(int IdEmpresa, string CodBarra)
        {
            try
            {
                //prueba    
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.in_Producto
                                        where C.IdEmpresa == IdEmpresa && C.pr_codigo_barra == CodBarra

                                        select C;
                in_Producto_Info info = new in_Producto_Info();
                foreach (var item in select_Inventario)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.pr_descripcion_2 = "[" + item.pr_codigo.Trim() + "]" + item.pr_descripcion.Trim();
                    info.precio_1 = item.precio_1;
                    info.precio_2 = item.precio_2;
                    info.precio_3 = item.precio_3;
                    info.precio_4 = item.precio_4;
                    info.precio_5 = item.precio_5;


                    info.IdCategoria = item.IdCategoria;
                    info.IdLinea = Convert.ToInt32(item.IdLinea);
                    info.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    info.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);


                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;





                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Productos_not_exist_in_producto_x_bodega(int IdEmpresa, int Idsucursal, int idbodega)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {

                    string Query = " SELECT        Prod.IdEmpresa, Prod.IdProducto, Prod.pr_codigo, Prod.pr_descripcion, Prod.pr_descripcion_2, Prod.IdProductoTipo, Prod.IdMarca, Prod.IdPresentacion, Prod.IdCategoria, Prod.IdLinea, Prod.IdGrupo,  ";
                    Query = Query + " Prod.IdSubGrupo, Prod.IdUnidadMedida, Prod.IdUnidadMedida_Consumo, Prod.IdCod_Impuesto_Iva, Prod.Aparece_modu_Ventas, ";
                    Query = Query + " Prod.Aparece_modu_Compras, Prod.Aparece_modu_Inventario, Prod.Aparece_modu_Activo_F, Prod.Estado, prodT.tp_descripcion AS nom_Tipo_Producto, cat.ca_Categoria AS nom_Categoria, ";
                    Query = Query + " L.nom_linea AS nom_Linea";
                    Query = Query + " FROM            in_linea AS L INNER JOIN ";
                    Query = Query + " in_categorias AS cat ON L.IdEmpresa = cat.IdEmpresa AND L.IdCategoria = cat.IdCategoria INNER JOIN ";
                    Query = Query + " in_Producto AS Prod INNER JOIN ";
                    Query = Query + " in_ProductoTipo AS prodT ON Prod.IdEmpresa = prodT.IdEmpresa AND Prod.IdProductoTipo = prodT.IdProductoTipo ON L.IdEmpresa = Prod.IdEmpresa AND L.IdCategoria = Prod.IdCategoria AND  ";
                    Query = Query + " L.IdLinea = Prod.IdLinea ";
                    Query = Query + " where  ";
                    Query = Query + " not exists( ";
                    Query = Query + " select A.IdProducto from  in_producto_x_tb_bodega A  ";
                    Query = Query + " where A.IdEmpresa = " + IdEmpresa;
                    Query = Query + " and A.IdBodega =  " + idbodega;
                    Query = Query + " and A.IdSucursal =  " + Idsucursal;
                    Query = Query + " and A.IdProducto = Prod.IdProducto ";
                    Query = Query + " and A.IdEmpresa=Prod.IdEmpresa ";
                    Query = Query + " )";
                    Query = Query + " and Prod.IdEmpresa=" + IdEmpresa;


                    var Producto = Oentities.Database.SqlQuery<in_Producto_Info>(Query);

                    return Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_codigo_barra(in_Producto_Info prI, ref string mensaje)
        {
            try
            {
                bool res = false;
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdProducto == prI.IdProducto);
                    if (contact != null)
                    {
                        contact.pr_codigo_barra = prI.pr_codigo_barra == null ? "" : prI.pr_codigo_barra;//27
                        contact.IdUsuarioUltMod = prI.IdUsuarioUltMod;
                        contact.Fecha_UltMod = DateTime.Now;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (DbEntityValidationException ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }

        }
    }
}

