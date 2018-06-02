using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_distribucion_x_lote_man : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param;
        in_Ing_Egr_Inven_distribucion_Bus bus_distribucion;
        in_Ing_Egr_Inven_distribucion_Info info_distribucion;
        BindingList<in_Ing_Egr_Inven_distribucion_Info> blst_x_distribuir;
        BindingList<in_Ing_Egr_Inven_distribucion_Info> blst_distribuido;
        List<in_UnidadMedida_Info> lst_unidad_medida;
        in_UnidadMedida_Bus bus_unidad_medida;
        List<in_producto_lote> lst_retorno;
        in_Parametro_Info info_param_in;
        in_Parametro_Bus bus_param_in;
        List<in_Motivo_Inven_Info> lst_motivo_inve;
        in_Motivo_Inven_Bus bus_motivo_inve;
        #endregion

        public FrmIn_distribucion_x_lote_man()
        {
            InitializeComponent();
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_distribucion = new in_Ing_Egr_Inven_distribucion_Bus();
            info_distribucion = new in_Ing_Egr_Inven_distribucion_Info();
            blst_x_distribuir = new BindingList<in_Ing_Egr_Inven_distribucion_Info>();
            blst_distribuido = new BindingList<in_Ing_Egr_Inven_distribucion_Info>();
            lst_unidad_medida = new List<in_UnidadMedida_Info>();
            bus_unidad_medida = new in_UnidadMedida_Bus();
            lst_retorno = new List<in_producto_lote>();
            info_param_in = new in_Parametro_Info();
            bus_param_in = new in_Parametro_Bus();
            lst_motivo_inve = new List<in_Motivo_Inven_Info>();
            bus_motivo_inve = new in_Motivo_Inven_Bus();
        }

        public void set_info(in_Ing_Egr_Inven_distribucion_Info _info)
        {
            try
            {
                info_distribucion = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                info_distribucion.lst_x_distribuir = bus_distribucion.get_list_x_distribuir(info_distribucion.IdEmpresa, info_distribucion.IdSucursal, info_distribucion.IdMovi_inven_tipo, info_distribucion.IdNumMovi);
                info_distribucion.lst_distribuido = bus_distribucion.get_list_distribuido(info_distribucion.IdEmpresa, info_distribucion.IdSucursal, info_distribucion.IdMovi_inven_tipo, info_distribucion.IdNumMovi);
                blst_distribuido = new BindingList<in_Ing_Egr_Inven_distribucion_Info>(info_distribucion.lst_distribuido);
                blst_x_distribuir = new BindingList<in_Ing_Egr_Inven_distribucion_Info>(info_distribucion.lst_x_distribuir);
                gridControl_distribuido.DataSource = blst_distribuido;
                gridControl_x_distribuir.DataSource = blst_x_distribuir;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida_d.DataSource = lst_unidad_medida;
                cmb_unidad_medida_x.DataSource = lst_unidad_medida;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_distribucion_x_lote_man_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                set_info_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_distribuir_Click(object sender, EventArgs e)
        {
            try
            {
                in_Ing_Egr_Inven_distribucion_Info row = (in_Ing_Egr_Inven_distribucion_Info)gridView_x_distribuir.GetFocusedRow();
                if (row == null)
                    return;

                if (row.IdProducto_padre == null)
                {
                    MessageBox.Show("El producto seleccionado no tiene producto padre asignado",param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                if (row.can_x_distribuir <= 0)
                {
                    MessageBox.Show("El producto seleccionado ya ha sido distribuido en su totalidad",param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                FrmIn_producto_asignacion_lote frm = new FrmIn_producto_asignacion_lote();
                frm.set_funcion(Cl_Enumeradores.eFuncion_pantalla_lote.DISTRIBUIR);
                frm.set_info(Convert.ToDecimal(row.IdProducto_padre),0,0);
                frm.ShowDialog();
                if (frm.Result == System.Windows.Forms.DialogResult.OK)
                {
                    lst_retorno = frm.get_lista_retorno();
                    if (!validar_cantidades(lst_retorno, row.can_total == null ? 0 : Convert.ToDouble(row.can_total)))
                        return;
                    foreach (var item in lst_retorno)
                    {
                        in_Ing_Egr_Inven_distribucion_Info info_nuevo = new in_Ing_Egr_Inven_distribucion_Info{
                         IdProducto_padre = row.IdProducto_padre,
                         IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto),
                         IdEmpresa = param.IdEmpresa,
                         dm_cantidad = item.cantidad,
                         pr_descripcion = item.pr_descripcion,
                         IdUnidadMedida = row.IdUnidadMedida
                        };
                        blst_distribuido.Add(info_nuevo);
                    }
                    gridControl_distribuido.DataSource = null;
                    gridControl_distribuido.DataSource = blst_distribuido;
                }
                calcular_totales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar_cantidades(List<in_producto_lote> _lst_retorno, double total_a_distribuir)
        {
            try
            {
                double cantidad_distribuida = blst_distribuido.Sum(q=>q.dm_cantidad);
                double cantidad_x_distribuir = _lst_retorno.Sum(q => q.cantidad);
                if ((cantidad_distribuida + cantidad_x_distribuir) > total_a_distribuir)
                {
                    MessageBox.Show("La cantidad que intenta distribuir es mayor a la cantidad total a distribuir",param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void cmb_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                in_Ing_Egr_Inven_distribucion_Info row = (in_Ing_Egr_Inven_distribucion_Info)gridView_x_distribuir.GetFocusedRow();
                if (row == null)
                    return;

                if (row.IdProducto_padre == null)
                {
                    MessageBox.Show("El producto seleccionado no tiene producto padre asignado",param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("¿Está seguro que desea eliminar la distribución del producto seleccionado?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    blst_distribuido = new BindingList<in_Ing_Egr_Inven_distribucion_Info>(blst_distribuido.Where(q => q.IdProducto_padre != row.IdProducto_padre).ToList());
                    gridControl_distribuido.DataSource = null;
                    gridControl_distribuido.DataSource = blst_distribuido;
                    calcular_totales();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar_movimientos_x_distribucion())
                {
                    MessageBox.Show("Distribución guardada exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcular_totales()
        {
            try
            {
                foreach (var item_x in blst_x_distribuir)
                {
                    item_x.can_distribuida = blst_distribuido.Where(q => q.IdProducto_padre == item_x.IdProducto_padre).Sum(q => q.dm_cantidad);
                    item_x.can_x_distribuir = item_x.can_total - item_x.can_distribuida;
                }
                gridControl_x_distribuir.DataSource = null;
                gridControl_x_distribuir.DataSource = blst_x_distribuir;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_distribuido_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_distribuido.DeleteRow(gridView_distribuido.FocusedRowHandle);
                        calcular_totales();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool grabar_movimientos_x_distribucion()
        {
            try
            {
                info_param_in = bus_param_in.Get_Info_Parametro(param.IdEmpresa);
                lst_motivo_inve = bus_motivo_inve.Get_List_Motivo_Inven(param.IdEmpresa, "");
                in_Ing_Egr_Inven_distribucion_Info distribucion_sin_lote = bus_distribucion.get_info(info_distribucion.IdEmpresa,info_distribucion.IdSucursal,info_distribucion.IdMovi_inven_tipo,info_distribucion.IdNumMovi,(info_distribucion.signo == "+" ? "-" : "+"));
                in_Ing_Egr_Inven_distribucion_Info distribucion_con_lote = bus_distribucion.get_info(info_distribucion.IdEmpresa, info_distribucion.IdSucursal, info_distribucion.IdMovi_inven_tipo, info_distribucion.IdNumMovi, info_distribucion.signo);
                in_Motivo_Inven_Info info_motivo = new in_Motivo_Inven_Info();
                in_Ing_Egr_Inven_Bus bus_ing_egr = new in_Ing_Egr_Inven_Bus();
                decimal Id = 0;
                string mensaje = "";

                #region Crear movimiento sin lote
                in_Ing_Egr_Inven_Info mov_sin_lote = new in_Ing_Egr_Inven_Info();

                #region Cabecera
                if (distribucion_sin_lote != null)
                    mov_sin_lote = bus_ing_egr.Get_Info_Ing_Egr_Inven(distribucion_sin_lote.IdEmpresa_dis, distribucion_sin_lote.IdSucursal_dis, distribucion_sin_lote.IdMovi_inven_tipo_dis, distribucion_sin_lote.IdNumMovi_dis);
                else
                {
                    info_motivo = lst_motivo_inve.FirstOrDefault(q => q.Genera_Movi_Inven == "S" && q.Tipo_Ing_Egr == (info_distribucion.signo == "+" ? ein_Tipo_Ing_Egr.EGR : ein_Tipo_Ing_Egr.ING));
                    if (info_motivo == null)
                    {
                        MessageBox.Show("No existe motivo de inventario parametrizado, por favor corregir",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return false;
                    }

                    mov_sin_lote = new in_Ing_Egr_Inven_Info
                    {
                        IdEmpresa = param.IdEmpresa,
                        IdSucursal = info_distribucion.IdSucursal,
                        IdMovi_inven_tipo = info_distribucion.signo == "+" ? Convert.ToInt32(info_param_in.IdMovi_inven_tipo_x_distribucion_egr) : Convert.ToInt32(info_param_in.IdMovi_inven_tipo_x_distribucion_ing),
                        IdNumMovi = 0,
                        IdBodega = info_distribucion.IdBodega,
                        signo = (info_distribucion.signo == "+" ? "-" : "+"),
                        CodMoviInven = "Dis_" + info_distribucion.IdEmpresa.ToString("00") + "_" + info_distribucion.IdSucursal.ToString("00") + "_" + info_distribucion.IdMovi_inven_tipo.ToString("00") + "_" + info_distribucion.IdNumMovi.ToString("000000000"),
                        cm_observacion = "Dis. x lote - Sucursal: "+info_distribucion.Su_Descripcion.Trim()+" # Movi: "+info_distribucion.IdNumMovi.ToString("000000000"),
                        cm_fecha = DateTime.Now.Date,
                        IdUsuario = param.IdUsuario,
                        Estado = "A",
                        Fecha_Transac = DateTime.Now,
                        nom_pc = param.nom_pc,
                        ip = param.ip,
                        IdMotivo_Inv = info_motivo.IdMotivo_Inv
                    };
                }
                #endregion

                #region Detalle
                foreach (var item in blst_x_distribuir)
                {
                    if (item.can_distribuida > 0)
                    {
                        in_Ing_Egr_Inven_det_Info info_det = new in_Ing_Egr_Inven_det_Info
                        {
                            IdEmpresa = mov_sin_lote.IdEmpresa,
                            IdSucursal = mov_sin_lote.IdSucursal,
                            IdMovi_inven_tipo = mov_sin_lote.IdMovi_inven_tipo,
                            IdNumMovi = mov_sin_lote.IdNumMovi,
                            IdBodega = mov_sin_lote.IdBodega,
                            IdProducto = item.IdProducto,
                            dm_observacion = "",
                            dm_cantidad = item.can_distribuida == null ? 0 : Convert.ToDouble(item.can_distribuida) * (info_distribucion.signo == "+" ? -1 : 1),
                            dm_cantidad_sinConversion = item.can_distribuida == null ? 0 : Convert.ToDouble(item.can_distribuida),
                            mv_costo = item.mv_costo,
                            mv_costo_sinConversion = item.mv_costo,
                            IdUnidadMedida = item.IdUnidadMedida,
                            IdUnidadMedida_sinConversion = item.IdUnidadMedida,
                        };
                        mov_sin_lote.listIng_Egr.Add(info_det);
                    }                    
                }
                #endregion

                #endregion

                #region Crear movimiento con lote
                in_Ing_Egr_Inven_Info mov_con_lote = new in_Ing_Egr_Inven_Info();
                
                #region Cabecera
                if (distribucion_con_lote != null)
                    mov_con_lote = bus_ing_egr.Get_Info_Ing_Egr_Inven(distribucion_con_lote.IdEmpresa_dis, distribucion_con_lote.IdSucursal_dis, distribucion_con_lote.IdMovi_inven_tipo_dis, distribucion_con_lote.IdNumMovi_dis);
                else
                {
                    info_motivo = lst_motivo_inve.FirstOrDefault(q => q.Genera_Movi_Inven == "S" && q.Tipo_Ing_Egr == (info_distribucion.signo == "+" ? ein_Tipo_Ing_Egr.ING : ein_Tipo_Ing_Egr.EGR));
                    if (info_motivo == null)
                    {
                        MessageBox.Show("No existe motivo de inventario parametrizado, por favor corregir", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    mov_con_lote = new in_Ing_Egr_Inven_Info
                    {
                        IdEmpresa = param.IdEmpresa,
                        IdSucursal = info_distribucion.IdSucursal,
                        IdMovi_inven_tipo = info_distribucion.signo == "+" ? Convert.ToInt32(info_param_in.IdMovi_inven_tipo_x_distribucion_ing) : Convert.ToInt32(info_param_in.IdMovi_inven_tipo_x_distribucion_egr),
                        IdNumMovi = 0,
                        IdBodega = info_distribucion.IdBodega,
                        signo = info_distribucion.signo,
                        CodMoviInven = "Dis_" + info_distribucion.IdEmpresa.ToString("00") + "_" + info_distribucion.IdSucursal.ToString("00") + "_" + info_distribucion.IdMovi_inven_tipo.ToString("00") + "_" + info_distribucion.IdNumMovi.ToString("000000000"),
                        cm_observacion = "Dis. x lote - Sucursal: " + info_distribucion.Su_Descripcion.Trim() + " # Movi: " + info_distribucion.IdNumMovi.ToString("000000000"),
                        cm_fecha = DateTime.Now.Date,
                        IdUsuario = param.IdUsuario,
                        Estado = "A",
                        Fecha_Transac = DateTime.Now,
                        nom_pc = param.nom_pc,
                        ip = param.ip,
                        IdMotivo_Inv = info_motivo.IdMotivo_Inv
                    };
                }
                #endregion

                #region Detalle
                foreach (var item in blst_distribuido)
                {
                    in_Ing_Egr_Inven_det_Info info_det = new in_Ing_Egr_Inven_det_Info
                    {
                        IdEmpresa = mov_sin_lote.IdEmpresa,
                        IdSucursal = mov_sin_lote.IdSucursal,
                        IdMovi_inven_tipo = mov_sin_lote.IdMovi_inven_tipo,
                        IdNumMovi = mov_sin_lote.IdNumMovi,
                        IdBodega = mov_sin_lote.IdBodega,
                        IdProducto = item.IdProducto,
                        dm_observacion = "",
                        dm_cantidad = item.dm_cantidad == null ? 0 : Convert.ToDouble(item.dm_cantidad) * (info_distribucion.signo == "+" ? 1 : -1),
                        dm_cantidad_sinConversion = item.dm_cantidad == null ? 0 : Convert.ToDouble(item.dm_cantidad),
                        mv_costo = item.mv_costo,
                        mv_costo_sinConversion = item.mv_costo,
                        IdUnidadMedida = item.IdUnidadMedida,
                        IdUnidadMedida_sinConversion = item.IdUnidadMedida,
                    };
                    mov_con_lote.listIng_Egr.Add(info_det);
                }
                #endregion

                #endregion

                #region guardar movimientos y distribucion
                if (distribucion_sin_lote == null)
                {
                    if (!bus_ing_egr.GuardarDB(mov_sin_lote, ref Id, ref mensaje))
                        return false;

                    distribucion_sin_lote = new in_Ing_Egr_Inven_distribucion_Info
                    {
                        IdEmpresa = info_distribucion.IdEmpresa,
                        IdSucursal = info_distribucion.IdSucursal,
                        IdMovi_inven_tipo = info_distribucion.IdMovi_inven_tipo,
                        IdNumMovi = info_distribucion.IdNumMovi,

                        IdEmpresa_dis = mov_sin_lote.IdEmpresa,
                        IdSucursal_dis = mov_sin_lote.IdSucursal,
                        IdMovi_inven_tipo_dis = mov_sin_lote.IdMovi_inven_tipo,
                        IdNumMovi_dis = mov_sin_lote.IdNumMovi,
                        signo = mov_sin_lote.signo,
                        estado = true,
                    };

                    if (!bus_distribucion.guardarDB(distribucion_sin_lote))
                        return false;
                }
                else
                {
                    if (!bus_ing_egr.Reversar_Aprobacion(distribucion_sin_lote.IdEmpresa_dis, distribucion_sin_lote.IdSucursal_dis, distribucion_sin_lote.IdMovi_inven_tipo_dis, distribucion_sin_lote.IdNumMovi_dis, "S"))
                        return false;

                    if (!bus_ing_egr.ModificarDB(mov_sin_lote, ref mensaje))
                        return false;
                }
                
                if (distribucion_con_lote == null)
                {
                    if (!bus_ing_egr.GuardarDB(mov_con_lote, ref Id, ref mensaje))
                        return false;

                    distribucion_con_lote = new in_Ing_Egr_Inven_distribucion_Info
                    {
                        IdEmpresa = info_distribucion.IdEmpresa,
                        IdSucursal = info_distribucion.IdSucursal,
                        IdMovi_inven_tipo = info_distribucion.IdMovi_inven_tipo,
                        IdNumMovi = info_distribucion.IdNumMovi,

                        IdEmpresa_dis = mov_con_lote.IdEmpresa,
                        IdSucursal_dis = mov_con_lote.IdSucursal,
                        IdMovi_inven_tipo_dis = mov_con_lote.IdMovi_inven_tipo,
                        IdNumMovi_dis = mov_con_lote.IdNumMovi,
                        signo = mov_con_lote.signo,
                        estado = true,
                    };

                    if (!bus_distribucion.guardarDB(distribucion_con_lote))
                        return false;
                }
                else
                {
                    if (!bus_ing_egr.Reversar_Aprobacion(distribucion_con_lote.IdEmpresa_dis, distribucion_con_lote.IdSucursal_dis, distribucion_con_lote.IdMovi_inven_tipo_dis, distribucion_con_lote.IdNumMovi_dis, "S"))
                        return false;

                    if (!bus_ing_egr.ModificarDB(mov_con_lote, ref mensaje))
                        return false;
                }
                #endregion

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
