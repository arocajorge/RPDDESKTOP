﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Nodes;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Controles;
using System.IO;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Winform.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Reportes.Inventario;
namespace Core.Erp.Winform.Inventario
{
    
    public partial class FrmIn_Producto_Mant : Form
    {
        #region Declaración de Variables


        FrmGe_MotivoAnulacion ofrmAnulacion = new FrmGe_MotivoAnulacion();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;
        in_Parametro_Info info_param = new in_Parametro_Info();
        in_Parametro_Bus bus_param = new in_Parametro_Bus();
        List<in_Producto_Info> lst_producto_padre = new List<in_Producto_Info>();
                vwtb_Bodega_x_Sucursal_TreeList_Info info_Bodega_x_Sucursal = new vwtb_Bodega_x_Sucursal_TreeList_Info();
                

                ct_Plancta_Bus plnCta_B = new ct_Plancta_Bus();                

                BindingList<in_producto_x_cp_proveedor_Info> LBinProxProve ;
                BindingList<in_Producto_Composicion_Info> LBinProComposi;
                List<in_producto_x_cp_proveedor_Info> listaProd_x_prove;
                

                in_producto_Bus Bus_Producto = new in_producto_Bus();
                in_Producto_Info Info_Producto = new in_Producto_Info();
        
                List<ct_Plancta_Info> listPlanCta = new List<ct_Plancta_Info>();
                ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();

                List<ct_Centro_costo_Info> listCentroCosto_Info = new List<ct_Centro_costo_Info>();
                ct_Centro_costo_Bus BusCentroCosto = new ct_Centro_costo_Bus();
                List<ct_centro_costo_sub_centro_costo_Info> list_SubCentroCosto_Info = new List<ct_centro_costo_sub_centro_costo_Info>();
                ct_centro_costo_sub_centro_costo_Bus BusSubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();

               

                string MensajeError = "";
                
               
                ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
                List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
                //lista producto x proveedor
                List<in_producto_x_cp_proveedor_Info> lm_prod_x_prove = new List<in_producto_x_cp_proveedor_Info>();
                List<in_producto_x_cp_proveedor_Info> _lm_prod_x_prove = new List<in_producto_x_cp_proveedor_Info>();
                in_producto_x_cp_proveedor_Bus pxp_bus = new in_producto_x_cp_proveedor_Bus();

                //lista producto composicion
                List<in_Producto_Composicion_Info> lsComposicionProducto = new List<in_Producto_Composicion_Info>();
                List<in_Producto_Composicion_Info> _lsComposicionProducto = new List<in_Producto_Composicion_Info>();
                //lista producto x bodega
                List<in_producto_x_tb_bodega_Info> lsProductoBodega_Insert = new List<in_producto_x_tb_bodega_Info>();
                List<in_producto_x_tb_bodega_Info> lsProductoBodega_Update = new List<in_producto_x_tb_bodega_Info>();
                List<in_producto_x_tb_bodega_Info> _lsProductoBodega_Anterior = new List<in_producto_x_tb_bodega_Info>();
                in_producto_x_tb_bodega_Bus busProductoBodega = new in_producto_x_tb_bodega_Bus();
                vwtb_Bodega_x_Sucursal_TreeList_Bus busBod_x_Suc = new vwtb_Bodega_x_Sucursal_TreeList_Bus();
                List<vwtb_Bodega_x_Sucursal_TreeList_Info> lst_Bod_x_Suc = new List<vwtb_Bodega_x_Sucursal_TreeList_Info>();

                fa_catalogo_Bus busFactCata = new fa_catalogo_Bus();
                List<fa_catalogo_Info> lstFactCata = new List<fa_catalogo_Info>();
                

                public delegate void delegate_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info);
                public event delegate_FrmIn_Producto_Mant_FormClosing event_FrmIn_Producto_Mant_FormClosing;


                
        #endregion

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            _Accion = iAccion;
        }

        private void set_Accion_in_controls()
        {
            
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    ucGe_Menu.Visible_btnGuardar = true;
                    chkActivo.Checked = true;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    ucGe_Menu.Visible_btnGuardar = true;
                    set_producto_in_controls();
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Enabled_bntAnular = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    set_producto_in_controls();
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    set_producto_in_controls();
                    break;
                default:
                    break;
            }


        }

        public void set_Info_producto(in_Producto_Info iProdu)
        {
            Info_Producto = iProdu;
        }

        private void set_producto_in_controls()
        {
            try
            {
                lblIdProducto.Text = Info_Producto.IdProducto.ToString();             
                txtDescripcion2.Text = Info_Producto.pr_descripcion_2;           
                //txtCodigo.Enabled = false;

                
                cmbMarca.set_MarcaInfo(Info_Producto.IdMarca);
                cmbUnidadMedida_Consumo.set_IdUnidadMedida(Info_Producto.IdUnidadMedida_Consumo);
                cmbUnidadMedida.set_IdUnidadMedida(Info_Producto.IdUnidadMedida);
                ucIn_Presentacion.set_PresentacionInfo(Info_Producto.IdPresentacion);
                cmb_tipoProducto.set_TipoProductoInfo(Info_Producto.IdProductoTipo);                
                
                txtCodigo.Text = Info_Producto.pr_codigo;

                txtCodigoBarra.Text = Info_Producto.pr_codigo_barra;             
                txtNombre.Text = Info_Producto.pr_descripcion;
                chkActivo.Checked = (Info_Producto.Estado == "A") ? true : false;

                cmbCodImp_IVA.EditValue = Info_Producto.IdCod_Impuesto_Iva;

                txtObservacion.Text = Info_Producto.pr_observacion;


                txt_precio_1.Text = Info_Producto.precio_1 == null ? "0.00" : Convert.ToDouble(Info_Producto.precio_1).ToString();
                txt_precio_2.Text = Info_Producto.precio_2 == null ? "0.00" : Convert.ToDouble(Info_Producto.precio_2).ToString();
                txt_precio_3.Text = Info_Producto.precio_3 == null ? "0.00" : Convert.ToDouble(Info_Producto.precio_3).ToString();
                txt_precio_4.Text = Info_Producto.precio_4 == null ? "0.00" : Convert.ToDouble(Info_Producto.precio_4).ToString();
                txt_precio_5.Text = Info_Producto.precio_5 == null ? "0.00" : Convert.ToDouble(Info_Producto.precio_5).ToString();

                txt_porcentaje_2.Text = Info_Producto.porcentaje_2 == null  ? "0.00" : Convert.ToDouble(Info_Producto.porcentaje_2).ToString();
                txt_porcentaje_3.Text = Info_Producto.porcentaje_3 == null ? "0.00" : Convert.ToDouble(Info_Producto.porcentaje_3).ToString();
                txt_porcentaje_4.Text = Info_Producto.porcentaje_4 == null ? "0.00" : Convert.ToDouble(Info_Producto.porcentaje_4).ToString();
                txt_porcentaje_5.Text = Info_Producto.porcentaje_5 == null ? "0.00" : Convert.ToDouble(Info_Producto.porcentaje_5).ToString();

                cmb_signo_2.SelectedIndex = Info_Producto.signo_2 == null ? 1 : cmb_signo_2.Items.IndexOf(Info_Producto.signo_2);
                cmb_signo_3.SelectedIndex = Info_Producto.signo_3 == null ? 1 : cmb_signo_3.Items.IndexOf(Info_Producto.signo_3);
                cmb_signo_4.SelectedIndex = Info_Producto.signo_4 == null ? 1 : cmb_signo_4.Items.IndexOf(Info_Producto.signo_4);
                cmb_signo_5.SelectedIndex = Info_Producto.signo_5 == null ? 1 : cmb_signo_5.Items.IndexOf(Info_Producto.signo_5);

                chk_se_distribuye.Checked = Info_Producto.se_distribuye == null ? false : Convert.ToBoolean(Info_Producto.se_distribuye);
                ucIn_Linea_Grup_SubGr.set_item_Catgoria(Info_Producto.IdCategoria);
                ucIn_Linea_Grup_SubGr.set_item_Linea(Convert.ToInt32(Info_Producto.IdLinea));
                ucIn_Linea_Grup_SubGr.set_item_Grupo(Convert.ToInt32(Info_Producto.IdGrupo));
                ucIn_Linea_Grup_SubGr.set_item_SubGrupo(Convert.ToInt32(Info_Producto.IdSubGrupo));

                carga_dgvProductoBodega();               

                if (Info_Producto.Estado=="I")
                {lblAnulado.Visible=true;}
                else { lblAnulado.Visible = false; }
                chkModulo_AF.Checked = Info_Producto.Aparece_modu_Activo_F;
                chkModulo_Compras.Checked = Info_Producto.Aparece_modu_Compras;
                chkModulo_Inven.Checked = Info_Producto.Aparece_modu_Inventario;
                chkModulo_Venta.Checked = Info_Producto.Aparece_modu_Ventas;

                cmb_producto_padre.EditValue = Info_Producto.IdProducto_padre;
                de_fecha_fab_lote.EditValue = Info_Producto.lote_fecha_fab;
                de_fecha_vcto_lote.EditValue = Info_Producto.lote_fecha_vcto;
                txt_codigo_lote.EditValue = Info_Producto.lote_num_lote;

                in_Producto_imagenes_Bus bus_imagen = new in_Producto_imagenes_Bus();
                Info_Producto.info_imagen = bus_imagen.get_info(param.IdEmpresa, Info_Producto.IdProducto);
                if (Info_Producto.info_imagen != null)
                {
                    MemoryStream ms = new MemoryStream(Info_Producto.info_imagen.Imagen);
                    pic_imagen.Image = System.Drawing.Bitmap.FromStream(ms);
                }

                txtCodigo_prov.Text = Info_Producto.pr_codigo2;
                carga_ultragrid_composicion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }
        }
        
        public in_Producto_Info Get_producto()
        {
            try
            {
                Info_Producto = new in_Producto_Info();
                Info_Producto.IdEmpresa = param.IdEmpresa;
                Info_Producto.Estado = (chkActivo.Checked == true) ? "A" : "I";
                Info_Producto.pr_descripcion = txtNombre.Text.Trim();
                Info_Producto.IdPresentacion = null;
                Info_Producto.pr_descripcion_2 = txtDescripcion2.Text;
                Info_Producto.se_distribuye = chk_se_distribuye.Checked;
                Info_Producto.IdPresentacion = ucIn_Presentacion.Get_PresentacionInfo().IdPresentacion;


                Info_Producto.IdUnidadMedida_Consumo = cmbUnidadMedida_Consumo.Get_Info_UnidadMedida().IdUnidadMedida;



                Info_Producto.IdCategoria = ucIn_Linea_Grup_SubGr.get_item_Categria();
                Info_Producto.IdLinea = ucIn_Linea_Grup_SubGr.get_item_Linea();
                Info_Producto.IdGrupo = ucIn_Linea_Grup_SubGr.get_item_Grupo();
                Info_Producto.IdSubGrupo = ucIn_Linea_Grup_SubGr.get_item_SubGrupo();

                Info_Producto.IdCtaCble_Inventario = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null) ? null : ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Inve;
                Info_Producto.IdCtaCble_Costo = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null) ? null : ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Costo;
                Info_Producto.IdCtaCble_Gasto_x_cxp = (ucIn_Linea_Grup_SubGr.SubGrupoInfo == null) ? null : ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Gasto_x_cxp;



                //haac 01/08/2014

                Info_Producto.IdProducto = lblIdProducto.Text == "" ? 0 : Convert.ToDecimal(lblIdProducto.Text);
                Info_Producto.IdProductoTipo = cmb_tipoProducto.get_TipoProductoInfo().IdProductoTipo;
                Info_Producto.IdUnidadMedida = (cmbUnidadMedida.Get_Info_UnidadMedida().IdUnidadMedida == null) ? "UNI" : cmbUnidadMedida.Get_Info_UnidadMedida().IdUnidadMedida;
                Info_Producto.pr_codigo = txtCodigo.Text.Trim();
                Info_Producto.pr_codigo_barra = txtCodigoBarra.Text.Trim();


                Info_Producto.IdCod_Impuesto_Iva = Convert.ToString(cmbCodImp_IVA.EditValue);
                


                Info_Producto.pr_observacion = txtObservacion.Text.Trim();
                Info_Producto.pr_pedidos = 0;
                
                Info_Producto.precio_1 = txt_precio_1.Text == "" ? 0 : Convert.ToDouble(txt_precio_1.Text);
                Info_Producto.precio_2 = txt_precio_2.Text == "" ? 0 : Convert.ToDouble(txt_precio_2.Text);
                Info_Producto.precio_3 = txt_precio_3.Text == "" ? 0 : Convert.ToDouble(txt_precio_3.Text);
                Info_Producto.precio_4 = txt_precio_4.Text == "" ? 0 : Convert.ToDouble(txt_precio_4.Text);
                Info_Producto.precio_5 = txt_precio_5.Text == "" ? 0 : Convert.ToDouble(txt_precio_5.Text);

                Info_Producto.porcentaje_2 = txt_porcentaje_2.Text == "" ? 0 : Convert.ToDouble(txt_porcentaje_2.Text);
                Info_Producto.porcentaje_3 = txt_porcentaje_3.Text == "" ? 0 : Convert.ToDouble(txt_porcentaje_3.Text);
                Info_Producto.porcentaje_4 = txt_porcentaje_4.Text == "" ? 0 : Convert.ToDouble(txt_porcentaje_4.Text);
                Info_Producto.porcentaje_5 = txt_porcentaje_5.Text == "" ? 0 : Convert.ToDouble(txt_porcentaje_5.Text);

                Info_Producto.signo_2 = cmb_signo_2.SelectedIndex == null ? "-" : (cmb_signo_2.SelectedIndex == 1 ? "-" : "+");
                Info_Producto.signo_3 = cmb_signo_3.SelectedIndex == null ? "-" : (cmb_signo_3.SelectedIndex == 1 ? "-" : "+");
                Info_Producto.signo_4 = cmb_signo_4.SelectedIndex == null ? "-" : (cmb_signo_4.SelectedIndex == 1 ? "-" : "+");
                Info_Producto.signo_5 = cmb_signo_5.SelectedIndex == null ? "-" : (cmb_signo_5.SelectedIndex == 1 ? "-" : "+");

                Info_Producto.pr_stock = 0;
                Info_Producto.IdUsuarioUltMod = param.IdUsuario;

                Info_Producto.IdMarca = cmbMarca.get_MarcaInfo().IdMarca;
                
                Info_Producto.Aparece_modu_Activo_F = chkModulo_AF.Checked;
                Info_Producto.Aparece_modu_Compras = chkModulo_Compras.Checked;
                Info_Producto.Aparece_modu_Inventario = chkModulo_Inven.Checked;
                Info_Producto.Aparece_modu_Ventas = chkModulo_Venta.Checked;

                if (cmb_producto_padre.EditValue == null)
                {
                    Info_Producto.IdProducto_padre = null;
                    Info_Producto.lote_fecha_fab = null;
                    Info_Producto.lote_fecha_vcto = null;
                    Info_Producto.lote_num_lote = null;
                }
                else
                {
                    Info_Producto.IdProducto_padre = Convert.ToDecimal(cmb_producto_padre.EditValue);
                    if (de_fecha_fab_lote.EditValue == null)
                    {
                        Info_Producto.lote_fecha_fab = null;    
                    }
                    else
                        Info_Producto.lote_fecha_fab = Convert.ToDateTime(de_fecha_fab_lote.EditValue);
                    Info_Producto.lote_fecha_vcto = Convert.ToDateTime(de_fecha_vcto_lote.EditValue);
                    Info_Producto.lote_num_lote = txt_codigo_lote.Text;
                }

                if (pic_imagen.Image != null)
                {
                    MemoryStream memimagen = new MemoryStream();
                    pic_imagen.Image.Save(memimagen, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] byfoto = new byte[memimagen.Length];
                    memimagen.Position = 0;
                    memimagen.Read(byfoto, 0, Convert.ToInt32(memimagen.Length));
                    Info_Producto.info_imagen = new in_Producto_imagenes_Info();
                    Info_Producto.info_imagen.IdEmpresa = param.IdEmpresa;
                    Info_Producto.info_imagen.IdProducto = Info_Producto.IdProducto;
                    Info_Producto.info_imagen.Imagen= byfoto;
                }
                Info_Producto.pr_codigo2 = txtCodigo_prov.Text;
                return Info_Producto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_Producto_Info();
            }                                                        
        }

        public Boolean Validaciones()
        {
            try
            {
                Boolean Valido = true;

                if (cmbUnidadMedida.Get_Info_UnidadMedida() == null) 
                {
                    MessageBox.Show("Seleccione unidad de medida ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbUnidadMedida.Focus();
                    return false;
                }                

                if (ucIn_Presentacion.Get_PresentacionInfo() == null)
                {
                    MessageBox.Show("Por Favor seleccione presentacion de producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tipoProducto.Focus();
                    return false;
                }

                
                if (cmb_tipoProducto.get_TipoProductoInfo() == null) 
                {
                    MessageBox.Show("Por Favor seleccione el tipo de producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tipoProducto.Focus();
                    return false;
                }                

                if (cmbMarca.get_MarcaInfo() == null)
                {
                    MessageBox.Show("Seleccione una marca válida", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbMarca.Focus();
                    return false;
                }

                if (cmbUnidadMedida_Consumo.Get_Info_UnidadMedida() == null)
                {
                    MessageBox.Show("Seleccione un Tipo de Consumo válido", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbUnidadMedida_Consumo.Focus();
                    return false;
                }

                if (txtNombre.Text == "")
                {
                    MessageBox.Show("debe Ingresar el nombre del producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                    return false;
                }


                if (String.IsNullOrEmpty(ucIn_Linea_Grup_SubGr.get_item_Categria()))
                {

                    MessageBox.Show("Seleccione una categoria ....", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      return false;
                }

                if (ucIn_Linea_Grup_SubGr.get_item_Categria()=="000")
                {

                    MessageBox.Show("La Categoria no puede ser Todos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
               
                /*
                in_producto_Bus prob = new in_producto_Bus();
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (!prob.ValidarNombreItem(param.IdEmpresa, txtNombre.Text.Trim()))
                    {
                        MessageBox.Show("El Nombre del Propducto " + txtNombre.Text.Trim() + " Ya se Encuentra Ingresado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                 * */

                if (cmb_producto_padre.EditValue != null)
                {
                    if (txt_codigo_lote.EditValue == null)
                    {
                        MessageBox.Show("Por favor ingrese el codigo del lote", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_codigo_lote.Focus();
                        return false;
                    }
                    if (de_fecha_vcto_lote.EditValue == null)
                    {
                        MessageBox.Show("Por favor ingrese la fecha de vencimiento del lote", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        de_fecha_vcto_lote.Focus();
                        return false;
                    }
                }

                return Valido;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public Boolean Anular()
        {
            try
            {
                if (!(Info_Producto == null))
                {
                    Get_producto();
                    in_producto_Bus perBu = new in_producto_Bus();

                    ofrmAnulacion.ShowDialog();

                    Info_Producto.pr_motivoAnulacion = ofrmAnulacion.motivoAnulacion;
                    return perBu.AnularDB(Info_Producto, ref MensajeError);
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public Boolean Actualizar()
        {
            try
            {
                if (Validaciones() == false)
                {
                    return false;
                }

                if (!(Info_Producto == null))
                {
                    Get_producto();
                    get_Producto_x_composicion_del_grid();
                    get_ProductoxBodega_del_grid();

                    in_producto_Bus perBu = new in_producto_Bus();
                    in_producto_x_cp_proveedor_Bus pxpbus = new in_producto_x_cp_proveedor_Bus();
                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();
                    in_producto_x_tb_bodega_Bus busProductoBodega = new in_producto_x_tb_bodega_Bus();
                    


                    perBu.ModificarDB(Info_Producto, ref MensajeError);

                    
                    pxpbus.eliminarRegistro_x_producto(param.IdEmpresa, Convert.ToInt32(this.lblIdProducto.Text), ref MensajeError);                        
                    pxpbus.Grabar_Producto_Proveedor_lista(lm_prod_x_prove, param.IdEmpresa, Convert.ToInt32(this.lblIdProducto.Text), ref MensajeError);
                  
                    busComposicion.eliminarRegistro_x_producto(param.IdEmpresa, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);
                    busComposicion.GrabarDB(lsComposicionProducto, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);
            


                    foreach (var item in lsProductoBodega_Insert)
                    {
                        item.IdEmpresa = param.IdEmpresa;
                        if (busProductoBodega.VerificarExisteProductoXSucursalXBodega(param.IdEmpresa,item.IdSucursal,item.IdBodega,item.IdProducto))
                        {
                            
                                busProductoBodega.ModificarDB(item,ref MensajeError);
                        }
                        else
                        {
                            busProductoBodega.GrabaDB(item, param.IdEmpresa, ref MensajeError);
                        }

                        
                    }

                   

                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El producto ", Info_Producto.IdProducto);
                    MessageBox.Show(smensaje, param.Nombre_sistema);

                    LimpiarDatos();
                    return true;

                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);      
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }        
        
        public Boolean grabar()
        {
            try
            {
                Boolean resultB;
                
                if (Validaciones() == false)
                {
                    return false;
                }
                Info_Producto = Get_producto();
                if (!(Info_Producto == null))
                {
                    decimal idProducto;
                    idProducto = 0;

                    get_Producto_x_composicion_del_grid();
                    get_ProductoxBodega_del_grid();
                    
                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();

                    if (Bus_Producto.GrabarDB(Info_Producto, ref  idProducto, ref MensajeError))
                    {                                              
                        lblIdProducto.Text = idProducto.ToString();
                        Info_Producto.IdProducto = idProducto;
                        
                        busComposicion.GrabarDB(lsComposicionProducto, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);

                        foreach (var item in lsProductoBodega_Insert)
                        {
                            item.IdProducto = idProducto;
                        }
                        if (busProductoBodega.GrabaDB(lsProductoBodega_Insert, param.IdEmpresa, ref MensajeError))
                        {
                            
                        }
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El producto ", idProducto);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (cmb_tipoProducto.get_TipoProductoInfo().tp_ManejaLote == true)
                        {
                            info_param = bus_param.Get_Info_Parametro(param.IdEmpresa);
                            if ((info_param.P_se_crea_lote_0_al_crear_producto_matriz == null ? false : Convert.ToBoolean(info_param.P_se_crea_lote_0_al_crear_producto_matriz)) == true)
                            {
                                grabar_lote_0(idProducto);
                            }
                        }

                        LimpiarDatos();
                            
                          
                        resultB = true;
                    }
                    else
                    {
                        //string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                        MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);      
                        resultB = false;
                    }

                    return resultB;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool grabar_lote_0(decimal IdProducto_padre)
        {
            try
            {
                Boolean resultB;
                
                Info_Producto = Get_producto();
                if (!(Info_Producto == null))
                {
                    if (info_param.P_IdProductoTipo_para_lote_0 == null)
                    {
                        MessageBox.Show("No se pudo crear el lote 0 debido a falta de parametros",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return false;
                    }
                    Info_Producto.se_distribuye = true;
                    Info_Producto.IdProducto_padre = IdProducto_padre;
                    Info_Producto.lote_num_lote = "0000000000";
                    Info_Producto.IdProductoTipo = Convert.ToInt32(info_param.P_IdProductoTipo_para_lote_0);
                    Info_Producto.lote_fecha_fab = DateTime.Now.Date;
                    Info_Producto.lote_fecha_vcto = DateTime.Now.Date;
                    Info_Producto.IdProducto = 0;

                    Info_Producto.pr_descripcion = Info_Producto.pr_descripcion.Trim() + " - LOTE 0";

                    decimal idProducto;
                    idProducto = 0;

                     get_Producto_x_composicion_del_grid();
                    get_ProductoxBodega_del_grid();

                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();

                    if (Bus_Producto.GrabarDB(Info_Producto, ref  idProducto, ref MensajeError))
                    {
                        lblIdProducto.Text = idProducto.ToString();
                        Info_Producto.IdProducto = idProducto;
                        busComposicion.GrabarDB(lsComposicionProducto, Convert.ToInt32(lblIdProducto.Text), ref MensajeError);

                        foreach (var item in lsProductoBodega_Insert)
                        {
                            item.IdProducto = idProducto;
                        }

                        if (busProductoBodega.GrabaDB(lsProductoBodega_Insert, param.IdEmpresa, ref MensajeError))
                        {

                        }
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El producto para lote 0: ", idProducto);
                        MessageBox.Show(smensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        resultB = true;
                    }
                    else
                    {
                        //string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                        MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultB = false;
                    }

                    return resultB;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public FrmIn_Producto_Mant()
        {
            try
            {
                InitializeComponent(); 
                System.GC.Collect();// junto al disposed 

                
                event_FrmIn_Producto_Mant_FormClosing += FrmIn_Producto_Mant_event_FrmIn_Producto_Mant_FormClosing;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucIn_Linea_Grup_SubGr.event_cmb_subgrupo_EditValueChanged += ucIn_Linea_Grup_SubGr_event_cmb_subgrupo_EditValueChanged;
                ucGe_Menu.btnImprimir.Text = "Impr. cod. barra";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void ucIn_Linea_Grup_SubGr_event_cmb_subgrupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucIn_Linea_Grup_SubGr.SubGrupoInfo !=null)
                {
                    if (lst_Bod_x_Suc != null)
                   {
                       foreach (var item in lst_Bod_x_Suc)
                       {
                           item.IdCtaCble_Inven = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Inve;
                           item.IdCtaCble_Costo = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Costo;
                           item.IdCtaCble_Gasto_x_cxp = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCtble_Gasto_x_cxp;

                           item.IdCentroCosto_x_Gasto_x_cxp = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentro_Costo_x_Gasto_x_cxp;

                           item.IdCentroCosto_sub_centro_costo_inv = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentroCosto_sub_centro_costo_inv;
                           item.IdCentroCosto_sub_centro_costo_cost = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentroCosto_sub_centro_costo_cost;
                           item.IdCentroCosto_sub_centro_costo_cxp = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCentroCosto_sub_centro_costo_cxp;

                           item.IdCtaCble_Vta = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_Vta;
                           item.IdCtaCble_CosBaseIva = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_CosBaseIva;
                           item.IdCtaCble_CosBase0 = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_CosBase0;
                           item.IdCtaCble_VenIva = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_VenIva;
                           item.IdCtaCble_Ven0 = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_Ven0;
                           item.IdCtaCble_DesIva = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_DesIva;
                           item.IdCtaCble_Des0 = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_Des0;
                           item.IdCtaCble_DevIva = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_DevIva;
                           item.IdCtaCble_Dev0 = ucIn_Linea_Grup_SubGr.SubGrupoInfo.IdCtaCble_Dev0;
                       }
                       info_Bodega_x_Sucursal = lst_Bod_x_Suc.Where(q => q.Nivel == 2).FirstOrDefault();
                   }              
                }
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Focus();

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (grabar() == true)
                    { this.Close(); }
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (Actualizar() == true)
                    { this.Close(); }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Focus();
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    grabar();
                    return;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    Actualizar();
                    return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        
        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Esta seguro que desea eliminar el Item",param.Nombre_sistema, MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
                {
                    
                    if (Anular()) 
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        MessageBox.Show("Anulacion Exitosa"); 
                    } else { MessageBox.Show("Error al anular "); }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Producto_Mant_event_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            
        }
        
        void UCCategoria_Event_treeListCategoria_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            var info = (in_categorias_Info)sender;
            switch (_Accion)
            {              
                case Cl_Enumeradores.eTipo_action.grabar:
                  
                    foreach (var item in lst_Bod_x_Suc)
                        {
                            item.IdCtaCble_Inven = info.IdCtaCtble_Inve;
                            item.IdCtaCble_Costo = info.IdCtaCtble_Costo;
                        }
                        
                break;
                case Cl_Enumeradores.eTipo_action.actualizar:

                foreach (var item in lst_Bod_x_Suc)
                {
                    item.IdCtaCble_Inven = info.IdCtaCtble_Inve;
                    item.IdCtaCble_Costo = info.IdCtaCtble_Costo;

                }
                break;
            }
        }
        
        private void CargarCombo()
        {
            try
            {

                tb_sis_impuesto_Bus busSriCod = new tb_sis_impuesto_Bus();
                List<tb_sis_impuesto_Info> lstInfoCodSri_Iva = new List<tb_sis_impuesto_Info>();
                List<tb_sis_impuesto_Info> lstInfoCodSri_Ice = new List<tb_sis_impuesto_Info>();

                lst_producto_padre = Bus_Producto.Get_list_Producto_maneja_lote(param.IdEmpresa);
                cmb_producto_padre.Properties.DataSource = lst_producto_padre;

                lstInfoCodSri_Iva = busSriCod.Get_List_impuesto("IVA");

                cmbCodImp_IVA.Properties.DataSource = lstInfoCodSri_Iva;
                cmbCodImp_IVA.EditValue = param.Get_Parametro_Info(tb_parametro_enum.P_IVA).Valor;
                
                lstFactCata = busFactCata.Get_List_catalogo(7);
                in_UnidadMedida_Bus bus_uni_medida = new in_UnidadMedida_Bus();
                List<in_UnidadMedida_Info> lst_uni_medida = bus_uni_medida.Get_list_UnidadMedida();
                cmb_unidad_medida_comp.DataSource = lst_uni_medida;

                chkModulo_Inven.Checked = true;
                chkModulo_Compras.Checked = true;
                chkModulo_Venta.Checked = true;

                cmb_signo_2.SelectedIndex = cmb_signo_2.Items.IndexOf("-");
                cmb_signo_3.SelectedIndex = cmb_signo_3.Items.IndexOf("-");
                cmb_signo_4.SelectedIndex = cmb_signo_4.Items.IndexOf("-");
                cmb_signo_5.SelectedIndex = cmb_signo_5.Items.IndexOf("-");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_ProductoMantenimiento_Load(object sender, EventArgs e)
        {

            try
            {
                CargarCombo();
                            
            carga_ultragrid_composicion();

            if (_Accion == null || _Accion == 0)
            { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
            carga_dgvProductoBodega();
            set_Accion_in_controls();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            }
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            codigoBarraProducto.Text = txtCodigoBarra.Text;
            codigoBarraProducto.Refresh();
        }
        
        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            codigoBarraProducto.Text = txtCodigoBarra.Text;
            codigoBarraProducto.Refresh();

        }
                
        private void carga_ultragrid_composicion()
        {
            try
            {
                    in_Producto_Composicion_Bus bus = new in_Producto_Composicion_Bus();
             
                    carga_cmb_ProductoHijo();
                    _lsComposicionProducto = bus.ObtenerListProductoComposicion(param.IdEmpresa, Convert.ToInt32(lblIdProducto.Text));
                 

                    LBinProComposi = new BindingList<in_Producto_Composicion_Info>(_lsComposicionProducto);
                    gridControlComposicion.DataSource = LBinProComposi;
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }
        }
        
        private void carga_cmb_ProductoHijo()
        { 
            try
            {
                 
                List<in_Producto_Info> ls = new List<in_Producto_Info>();
                in_producto_Bus bus = new in_producto_Bus();
                ls = bus.Get_list_Producto(param.IdEmpresa);
                List<in_Producto_Info> itemComp = ls.FindAll(q => q.IdProducto != Convert.ToDecimal(lblIdProducto.Text));
                cmbProductoHijo_grid.DisplayMember = "pr_descripcion_combo";
                cmbProductoHijo_grid.ValueMember = "IdProducto";
                cmbProductoHijo_grid.DataSource = itemComp;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }

        }
        
        public List<in_Producto_Composicion_Info> get_Producto_x_composicion_del_grid()
        {
            try
            {
                List<in_Producto_Composicion_Info> lss = new List<in_Producto_Composicion_Info>();


                int focus = this.gridViewComposicion.FocusedRowHandle;
                gridViewComposicion.FocusedRowHandle = focus + 1;

                foreach (var item in LBinProComposi)
                {
                    if (item.Cantidad!= 0)
                    {
                        in_Producto_Composicion_Info info = new in_Producto_Composicion_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdProductoPadre = Convert.ToDecimal(lblIdProducto.Text);
                        info.Cantidad = item.Cantidad;
                        info.IdProductoHijo =item.IdProductoHijo;
                        info.IdUnidadMedida = item.IdUnidadMedida;
                        lss.Add(info);
                    }
                }
            
                lsComposicionProducto = lss;
                return lsComposicionProducto;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                return new List<in_Producto_Composicion_Info>();
            }
        }

        private void carga_TodasBodegas(List<vwtb_Bodega_x_Sucursal_TreeList_Info> lstBod_x_Suc)
        {
            try
            {   
                treeList_Bodega_x_Sucursal.DataSource = lstBod_x_Suc;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            }
        
        
        }
        
        private void carga_dgvProductoBodega()
        {
            try
            {
                List<vwtb_Bodega_x_Sucursal_TreeList_Info> lstProd_x_bod = new List<vwtb_Bodega_x_Sucursal_TreeList_Info>();                
               tb_Bodega_Bus bus = new tb_Bodega_Bus();

               lst_Bod_x_Suc = busBod_x_Suc.Get_List_Bodega_x_Sucursal(param.IdEmpresa);
               
                if(Convert.ToDecimal(lblIdProducto.Text)==0)
                {
                    carga_TodasBodegas(lst_Bod_x_Suc);                               
                }
                else                
                {
                    carga_TodasBodegas(lst_Bod_x_Suc);                     

                    List<in_producto_x_tb_bodega_Info> lsProdBodega = new List<in_producto_x_tb_bodega_Info>();
                    lsProdBodega = busProductoBodega.Get_list_Productos_x_Bodega(param.IdEmpresa, Convert.ToDecimal(lblIdProducto.Text));
                    
                        foreach (var item1 in lst_Bod_x_Suc)
                        {
                            vwtb_Bodega_x_Sucursal_TreeList_Info Info = new vwtb_Bodega_x_Sucursal_TreeList_Info();
                            Info.IdEmpresa = item1.IdEmpresa;
                            Info.ID = item1.ID;
                            Info.IdPadre = item1.IdPadre;
                            Info.Nombre = item1.Nombre;
                            Info.Estado = item1.Estado;
                            Info.Nivel = item1.Nivel;
                            Info.IdSucursal = item1.IdSucursal;
                            Info.IdBodega = item1.IdBodega;
                            item1.Checked = Info.Checked = false;
                            item1.EstaEnBase = Info.EstaEnBase = false;
                            foreach (var item in lsProdBodega)
                            {
                                if (item.IdBodega == item1.IdBodega && item.IdSucursal == item1.IdSucursal)
                                {
                                    item1.Checked = Info.Checked = true;
                                    item1.EstaEnBase = Info.EstaEnBase = true;
                                    item1.IdCtaCble_Vta = Info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                                    item1.IdCtaCble_CosBaseIva = Info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                                    item1.IdCtaCble_CosBase0 = Info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                                    item1.IdCtaCble_VenIva = Info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                                    item1.IdCtaCble_Ven0 = Info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                                    item1.IdCtaCble_DesIva = Info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                                    item1.IdCtaCble_Des0 = Info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                                    item1.IdCtaCble_DevIva = Info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                                    item1.IdCtaCble_Dev0 = Info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                                    item1.IdCtaCble_Inven = Info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                                    item1.IdCtaCble_Costo = Info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                                    item1.IdCtaCble_Gasto_x_cxp = Info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;
                                    item1.IdCentroCosto_x_Gasto_x_cxp = Info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;
                                    item1.IdCentroCosto_sub_centro_costo_inv = Info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                                    item1.IdCentroCosto_sub_centro_costo_cost = Info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                                    item1.IdCentroCosto_sub_centro_costo_cxp = Info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                                    item1.pr_precio_publico = Info.pr_precio_publico = Convert.ToDouble(item.pr_precio_publico);                                    
                                }                          
                            }
                            lstProd_x_bod.Add(Info);
                        }
                    
                    treeList_Bodega_x_Sucursal.DataSource = lst_Bod_x_Suc;   
                }
                treeList_Bodega_x_Sucursal.ExpandAll();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
            }
            
        }

        public void get_ProductoxBodega_del_grid()
        {
            try
            {
                lsProductoBodega_Insert  = new List<in_producto_x_tb_bodega_Info>();
                lsProductoBodega_Update = new List<in_producto_x_tb_bodega_Info>();

                foreach (var item in lst_Bod_x_Suc)
                {
                    if (item.Nivel == 2)
                    {
                        in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                        info.IdEmpresa = param.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdProducto = lblIdProducto.Text=="" ? 0 : Convert.ToInt32(lblIdProducto.Text);

                        info.pr_precio_publico = item.pr_precio_publico;

                        info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                        info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                        info.IdCtaCble_Gasto_x_cxp = item.IdCtaCble_Gasto_x_cxp;

                        info.IdCentroCosto_x_Gasto_x_cxp = item.IdCentroCosto_x_Gasto_x_cxp;

                        info.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                        info.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                        info.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                        info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                        info.IdCtaCble_CosBaseIva =item.IdCtaCble_CosBaseIva=="" ? null : item.IdCtaCble_CosBaseIva;
                        info.IdCtaCble_CosBase0 =item.IdCtaCble_CosBase0=="" ? null : item.IdCtaCble_CosBase0;
                        info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                        info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                        info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                        info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                        info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                        info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;

                        info.Estado = "A";

                        //  if (item.EstaEnBase == true)
                        if (item.Checked == true)
                        {
                            // lsProductoBodega_Update.Add(info);
                            lsProductoBodega_Insert.Add(info);

                        }
                        else
                        {
                            lsProductoBodega_Update.Add(info);
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }
        }

        private void FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmIn_Producto_Mant_FormClosing(sender, e, Info_Producto);
        }

        private void treeList_Bodega_x_Sucursal_BeforeFocusNode(object sender, DevExpress.XtraTreeList.BeforeFocusNodeEventArgs e)
        {
            try
            {
                TreeListNode nodeSeleccionado = (TreeListNode)e.Node;
                info_Bodega_x_Sucursal = new vwtb_Bodega_x_Sucursal_TreeList_Info();
                info_Bodega_x_Sucursal = (vwtb_Bodega_x_Sucursal_TreeList_Info)this.treeList_Bodega_x_Sucursal.GetDataRecordByNode(nodeSeleccionado);
                if (info_Bodega_x_Sucursal.Nivel == 1)
                {
                    info_Bodega_x_Sucursal = (vwtb_Bodega_x_Sucursal_TreeList_Info)this.treeList_Bodega_x_Sucursal.GetDataRecordByNode(nodeSeleccionado.LastNode);
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCodImp_IVA_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }              

        private void cmbUnidadMedida_event_cmbUnidadMedida_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string IdUnidadMedida = "";
                IdUnidadMedida = cmbUnidadMedida.Get_Info_UnidadMedida().IdUnidadMedida;
                cmbUnidadMedida_Consumo.CargarUnidadMedida_Equiv(IdUnidadMedida);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Info_Producto = new in_Producto_Info();                
                
                chkActivo.Checked = true;
                txtNombre.Text = "";
                txtDescripcion2.Text = "";
                lblIdProducto.Text = "";
                txtCodigo.Text = "";
                txtCodigoBarra.Text = "";
                txtObservacion.Text = "";
                txt_precio_1.Text = "0.00";
                txt_precio_2.Text = "0.00";
                txt_precio_3.Text = "0.00";
                txt_precio_4.Text = "0.00";
                txt_precio_5.Text = "0.00";

                cmb_signo_2.SelectedIndex = 1;
                cmb_signo_3.SelectedIndex = 1;
                cmb_signo_4.SelectedIndex = 1;
                cmb_signo_5.SelectedIndex = 1;

                txt_porcentaje_2.Text = "0.00";
                txt_porcentaje_3.Text = "0.00";
                txt_porcentaje_4.Text = "0.00";
                txt_porcentaje_5.Text = "0.00";

               cmb_producto_padre.EditValue = null;
               chk_se_distribuye.Checked = false;

                CargarCombo();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Producto_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                disposed();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        ///  metodo para liberar memoria
        ///  se lo llama en el formclosed, pero es mas efectivo en el formclosing
        /// </summary>
        public void disposed()
        {
             try
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void cmb_producto_padre_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_producto_padre.EditValue == null)
                {
                    de_fecha_fab_lote.EditValue = null;
                    de_fecha_vcto_lote.EditValue = null;
                    txt_codigo_lote.EditValue = null;
                }
                else
                {
                    in_Producto_Info info_prod = lst_producto_padre.FirstOrDefault(q => q.IdProducto == Convert.ToDecimal(cmb_producto_padre.EditValue));
                    if (info_prod != null)
                    {
                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            txtDescripcion2.Text = info_prod.pr_descripcion_2;
                            txtNombre.Text = info_prod.pr_descripcion;
                            ucIn_Linea_Grup_SubGr.set_item_Catgoria(info_prod.IdCategoria);
                            ucIn_Linea_Grup_SubGr.set_item_Linea(info_prod.IdLinea);
                            ucIn_Linea_Grup_SubGr.set_item_Grupo(info_prod.IdGrupo);
                            ucIn_Linea_Grup_SubGr.set_item_SubGrupo(info_prod.IdSubGrupo);
                            txtCodigo.Text = info_prod.pr_codigo;
                            cmbMarca.set_MarcaInfo(info_prod.IdMarca);
                            cmbUnidadMedida.set_IdUnidadMedida(info_prod.IdUnidadMedida);
                            cmbUnidadMedida_Consumo.set_IdUnidadMedida(info_prod.IdUnidadMedida_Consumo);
                            ucIn_Presentacion.set_PresentacionInfo(info_prod.IdPresentacion);

                            txt_precio_1.Text = info_prod.precio_1 == null ? "0.00" : Convert.ToDouble(info_prod.precio_1).ToString();
                            txt_precio_2.Text = info_prod.precio_2 == null ? "0.00" : Convert.ToDouble(info_prod.precio_2).ToString();
                            txt_precio_3.Text = info_prod.precio_3 == null ? "0.00" : Convert.ToDouble(info_prod.precio_3).ToString();
                            txt_precio_4.Text = info_prod.precio_4 == null ? "0.00" : Convert.ToDouble(info_prod.precio_4).ToString();
                            txt_precio_5.Text = info_prod.precio_5 == null ? "0.00" : Convert.ToDouble(info_prod.precio_5).ToString();

                            txt_porcentaje_2.Text = info_prod.porcentaje_2 == null ? "0.00" : Convert.ToDouble(info_prod.porcentaje_2).ToString();
                            txt_porcentaje_3.Text = info_prod.porcentaje_3 == null ? "0.00" : Convert.ToDouble(info_prod.porcentaje_3).ToString();
                            txt_porcentaje_4.Text = info_prod.porcentaje_4 == null ? "0.00" : Convert.ToDouble(info_prod.porcentaje_4).ToString();
                            txt_porcentaje_5.Text = info_prod.porcentaje_5 == null ? "0.00" : Convert.ToDouble(info_prod.porcentaje_5).ToString();

                            cmb_signo_2.SelectedIndex = info_prod.signo_2 == null ? 1 : cmb_signo_2.Items.IndexOf(info_prod.signo_2);
                            cmb_signo_3.SelectedIndex = info_prod.signo_3 == null ? 1 : cmb_signo_3.Items.IndexOf(info_prod.signo_3);
                            cmb_signo_4.SelectedIndex = info_prod.signo_4 == null ? 1 : cmb_signo_4.Items.IndexOf(info_prod.signo_4);
                            cmb_signo_5.SelectedIndex = info_prod.signo_5 == null ? 1 : cmb_signo_5.Items.IndexOf(info_prod.signo_5);
                        }                        
                    }
                    
                    de_fecha_fab_lote.EditValue = DateTime.Now.Date;
                    de_fecha_vcto_lote.EditValue = DateTime.Now.Date;
                    txt_codigo_lote.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imagen = new OpenFileDialog();
                imagen.Filter = "Archivos de Imagen|*.JPG;*.PNG;*.JEPG";
                imagen.FileName = "SELECCIONE UNA IMAGEN";
                imagen.InitialDirectory = "C:\\";


                switch (imagen.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        string direc = imagen.FileName;
                        pic_imagen.ImageLocation = direc;
                        break;

                    case System.Windows.Forms.DialogResult.Cancel:
                        pic_imagen.ImageLocation = "";
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                XINV_RptCodigo_Barra rpt = new XINV_RptCodigo_Barra();

                List<in_Producto_Info> lista_producto = new List<in_Producto_Info>();
                lista_producto.Add(Info_Producto);
                rpt.lst_producto = lista_producto;
                rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool detener_calculos = false;

        private void calcular_precio_2(eTriggerCambio Tipo)
        {
            detener_calculos = true;
            double precio_1 = txt_precio_1.Text == "" ? 0 : Convert.ToDouble(txt_precio_1.Text);
            double precio_2 = txt_precio_2.Text == "" ? 0 : Convert.ToDouble(txt_precio_2.Text);
            string signo = cmb_signo_2.SelectedIndex == null ? "-" : (cmb_signo_2.SelectedIndex == 1 ? "-" : "+");
            double porcentaje_2 = txt_porcentaje_2.Text == "" ? 0 : Convert.ToDouble(txt_porcentaje_2.Text);

             switch (Tipo)
            {
                case eTriggerCambio.POR_SIGNO:
                    if (signo == "-")
                        txt_precio_2.Text =  Math.Abs(Math.Round(precio_1 - (precio_1 * (porcentaje_2 / 100)),2,MidpointRounding.AwayFromZero)).ToString();
                    else
                        txt_precio_2.Text = Math.Abs(Math.Round((precio_1 * (porcentaje_2 / 100)) + precio_1,2,MidpointRounding.AwayFromZero)).ToString();
                    break;
                case eTriggerCambio.POR_PORCENTAJE:
                    if (signo == "-")
                        txt_precio_2.Text = Math.Abs(Math.Round(precio_1 - (precio_1 * (porcentaje_2 / 100)),2,MidpointRounding.AwayFromZero)).ToString();
                    else
                        txt_precio_2.Text = Math.Abs(Math.Round((precio_1 * (porcentaje_2 / 100)) + precio_1,2,MidpointRounding.AwayFromZero)).ToString();
                    break;
                case eTriggerCambio.POR_VALOR:
                    if (precio_2 > precio_1)
                    {
                        cmb_signo_2.SelectedIndex = 0;
                        txt_porcentaje_2.Text = Math.Abs(Math.Round(100 - Convert.ToDouble((precio_2 / precio_1) * 100), 2, MidpointRounding.AwayFromZero)).ToString();
                    }
                    else
                        if (precio_1 > precio_2)
                        {
                            cmb_signo_2.SelectedIndex = 1;
                            txt_porcentaje_2.Text = Math.Abs(Math.Round(100 - Convert.ToDouble((precio_2 / precio_1) * 100), 2, MidpointRounding.AwayFromZero)).ToString();
                        }
                        else
                            if (precio_2 == precio_1)
                            {
                                cmb_signo_2.SelectedIndex = 1;
                                txt_porcentaje_2.Text = "0";
                            }
                    
                    break;
            }
             detener_calculos = false;
        }

        private void calcular_precio_3(eTriggerCambio Tipo)
        {
            detener_calculos = true;
            double precio_1 = txt_precio_1.Text == "" ? 0 : Convert.ToDouble(txt_precio_1.Text);
            double precio_3 = txt_precio_3.Text == "" ? 0 : Convert.ToDouble(txt_precio_3.Text);
            string signo = cmb_signo_3.SelectedIndex == null ? "-" : (cmb_signo_3.SelectedIndex == 1 ? "-" : "+");
            double porcentaje_3 = txt_porcentaje_3.Text == "" ? 0 : Convert.ToDouble(txt_porcentaje_3.Text);

            switch (Tipo)
            {
                case eTriggerCambio.POR_SIGNO:
                    if (signo == "-")
                        txt_precio_3.Text = Math.Abs(Math.Round(precio_1 - (precio_1 * (porcentaje_3 / 100)), 2, MidpointRounding.AwayFromZero)).ToString();
                    else
                        txt_precio_3.Text = Math.Abs(Math.Round((precio_1 * (porcentaje_3 / 100)) + precio_1, 2, MidpointRounding.AwayFromZero)).ToString();
                    break;
                case eTriggerCambio.POR_PORCENTAJE:
                    if (signo == "-")
                        txt_precio_3.Text = Math.Abs(Math.Round(precio_1 - (precio_1 * (porcentaje_3 / 100)), 2, MidpointRounding.AwayFromZero)).ToString();
                    else
                        txt_precio_3.Text = Math.Abs(Math.Round((precio_1 * (porcentaje_3 / 100)) + precio_1, 2, MidpointRounding.AwayFromZero)).ToString();
                    break;
                case eTriggerCambio.POR_VALOR:
                    if (precio_3 > precio_1)
                    {
                        cmb_signo_3.SelectedIndex = 0;
                        txt_porcentaje_3.Text = Math.Abs(Math.Round(100 - Convert.ToDouble((precio_3 / precio_1) * 100), 2, MidpointRounding.AwayFromZero)).ToString();
                    }
                    else
                        if (precio_1 > precio_3)
                        {
                            cmb_signo_3.SelectedIndex = 1;
                            txt_porcentaje_3.Text = Math.Abs(Math.Round(100 - Convert.ToDouble((precio_3 / precio_1) * 100), 2, MidpointRounding.AwayFromZero)).ToString();
                        }
                        else
                            if (precio_3 == precio_1)
                            {
                                cmb_signo_3.SelectedIndex = 1;
                                txt_porcentaje_3.Text = "0";
                            }

                    break;
            }
            detener_calculos = false;
        }

        private void calcular_precio_4(eTriggerCambio Tipo)
        {
            detener_calculos = true;
            double precio_1 = txt_precio_1.Text == "" ? 0 : Convert.ToDouble(txt_precio_1.Text);
            double precio_4 = txt_precio_4.Text == "" ? 0 : Convert.ToDouble(txt_precio_4.Text);
            string signo = cmb_signo_4.SelectedIndex == null ? "-" : (cmb_signo_4.SelectedIndex == 1 ? "-" : "+");
            double porcentaje_4 = txt_porcentaje_4.Text == "" ? 0 : Convert.ToDouble(txt_porcentaje_4.Text);

            switch (Tipo)
            {
                case eTriggerCambio.POR_SIGNO:
                    if (signo == "-")
                        txt_precio_4.Text = Math.Abs(Math.Round(precio_1 - (precio_1 * (porcentaje_4 / 100)), 2, MidpointRounding.AwayFromZero)).ToString();
                    else
                        txt_precio_4.Text = Math.Abs(Math.Round((precio_1 * (porcentaje_4 / 100)) + precio_1, 2, MidpointRounding.AwayFromZero)).ToString();
                    break;
                case eTriggerCambio.POR_PORCENTAJE:
                    if (signo == "-")
                        txt_precio_4.Text = Math.Abs(Math.Round(precio_1 - (precio_1 * (porcentaje_4 / 100)), 2, MidpointRounding.AwayFromZero)).ToString();
                    else
                        txt_precio_4.Text = Math.Abs(Math.Round((precio_1 * (porcentaje_4 / 100)) + precio_1, 2, MidpointRounding.AwayFromZero)).ToString();
                    break;
                case eTriggerCambio.POR_VALOR:
                    if (precio_4 > precio_1)
                    {
                        cmb_signo_4.SelectedIndex = 0;
                        txt_porcentaje_4.Text = Math.Abs(Math.Round(100 - Convert.ToDouble((precio_4 / precio_1) * 100), 2, MidpointRounding.AwayFromZero)).ToString();
                    }
                    else
                        if (precio_1 > precio_4)
                        {
                            cmb_signo_4.SelectedIndex = 1;
                            txt_porcentaje_4.Text = Math.Abs(Math.Round(100 - Convert.ToDouble((precio_4 / precio_1) * 100), 2, MidpointRounding.AwayFromZero)).ToString();
                        }
                        else
                            if (precio_4 == precio_1)
                            {
                                cmb_signo_4.SelectedIndex = 1;
                                txt_porcentaje_4.Text = "0";
                            }

                    break;
            }
            detener_calculos = false;
        }

        private void calcular_precio_5(eTriggerCambio Tipo)
        {
            detener_calculos = true;
            double precio_1 = txt_precio_1.Text == "" ? 0 : Convert.ToDouble(txt_precio_1.Text);
            double precio_5 = txt_precio_5.Text == "" ? 0 : Convert.ToDouble(txt_precio_5.Text);
            string signo = cmb_signo_5.SelectedIndex == null ? "-" : (cmb_signo_5.SelectedIndex == 1 ? "-" : "+");
            double porcentaje_5 = txt_porcentaje_5.Text == "" ? 0 : Convert.ToDouble(txt_porcentaje_5.Text);

            switch (Tipo)
            {
                case eTriggerCambio.POR_SIGNO:
                    if (signo == "-")
                        txt_precio_5.Text = Math.Abs(Math.Round(precio_1 - (precio_1 * (porcentaje_5 / 100)), 2, MidpointRounding.AwayFromZero)).ToString();
                    else
                        txt_precio_5.Text = Math.Abs(Math.Round((precio_1 * (porcentaje_5 / 100)) + precio_1, 2, MidpointRounding.AwayFromZero)).ToString();
                    break;
                case eTriggerCambio.POR_PORCENTAJE:
                    if (signo == "-")
                        txt_precio_5.Text = Math.Abs(Math.Round(precio_1 - (precio_1 * (porcentaje_5 / 100)), 2, MidpointRounding.AwayFromZero)).ToString();
                    else
                        txt_precio_5.Text = Math.Abs(Math.Round((precio_1 * (porcentaje_5 / 100)) + precio_1, 2, MidpointRounding.AwayFromZero)).ToString();
                    break;
                case eTriggerCambio.POR_VALOR:
                    if (precio_5 > precio_1)
                    {
                        cmb_signo_5.SelectedIndex = 0;
                        txt_porcentaje_5.Text = Math.Abs(Math.Round(100 - Convert.ToDouble((precio_5 / precio_1) * 100), 2, MidpointRounding.AwayFromZero)).ToString();
                    }
                    else
                        if (precio_1 > precio_5)
                        {
                            cmb_signo_5.SelectedIndex = 1;
                            txt_porcentaje_5.Text = Math.Abs(Math.Round(100 - Convert.ToDouble((precio_5 / precio_1) * 100), 2, MidpointRounding.AwayFromZero)).ToString();
                        }
                        else
                            if (precio_5 == precio_1)
                            {
                                cmb_signo_5.SelectedIndex = 1;
                                txt_porcentaje_5.Text = "0";
                            }

                    break;
            }
            detener_calculos = false;
        }

        private enum eTriggerCambio
        {
            POR_SIGNO,
            POR_PORCENTAJE,
            POR_VALOR
        }

        private void txt_precio_2_EditValueChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_2(eTriggerCambio.POR_VALOR);
        }

        private void cmb_signo_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_2(eTriggerCambio.POR_SIGNO);
        }

        private void txt_porcentaje_2_EditValueChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_2(eTriggerCambio.POR_PORCENTAJE);
        }

        private void txt_precio_3_EditValueChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_3(eTriggerCambio.POR_VALOR);
        }

        private void cmb_signo_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_3(eTriggerCambio.POR_SIGNO);
        }

        private void txt_porcentaje_3_EditValueChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_3(eTriggerCambio.POR_PORCENTAJE);
        }

        private void txt_precio_4_EditValueChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_4(eTriggerCambio.POR_VALOR);
        }

        private void cmb_signo_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_4(eTriggerCambio.POR_SIGNO);
        }

        private void txt_porcentaje_4_EditValueChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_4(eTriggerCambio.POR_PORCENTAJE);
        }

        private void txt_precio_5_EditValueChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_5(eTriggerCambio.POR_VALOR);
        }

        private void cmb_signo_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_5(eTriggerCambio.POR_SIGNO);
        }

        private void txt_porcentaje_5_EditValueChanged(object sender, EventArgs e)
        {
            if (!detener_calculos)
                calcular_precio_5(eTriggerCambio.POR_PORCENTAJE);
        }
    }
}
