using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_producto_asignacion_lote : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param;
        List<in_Producto_Info> lst_producto;
        in_producto_Bus bus_producto;
        in_Producto_Info info_producto_padre;
        BindingList<in_producto_lote> blst;
        List<in_producto_lote> lst_retorno;
        in_producto_lote info_retorno;
        public DialogResult Result;
        Cl_Enumeradores.eFuncion_pantalla_lote FUNCION;
        in_Parametro_Info info_in_param;
        in_Parametro_Bus bus_in_param;
        

        public FrmIn_producto_asignacion_lote()
        {
            InitializeComponent();
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            lst_producto = new List<in_Producto_Info>();
            bus_producto = new in_producto_Bus();
            info_producto_padre = new in_Producto_Info();
            blst = new BindingList<in_producto_lote>();
            lst_retorno = new List<in_producto_lote>();
            Result = System.Windows.Forms.DialogResult.Cancel;
            info_in_param = new in_Parametro_Info();
            bus_in_param = new in_Parametro_Bus();
            info_retorno = new in_producto_lote();
        }

        public void set_info(decimal _IdProducto_padre, int IdSucursal, int IdBodega)
        {
            try
            {
                info_producto_padre = bus_producto.Get_info_Product(param.IdEmpresa, _IdProducto_padre);
                info_producto_padre.IdSucursal = IdSucursal;
                info_producto_padre.IdBodega = IdBodega;
                List<in_Producto_Info> temp = new List<in_Producto_Info>();
                temp.Add(info_producto_padre);
                cmb_producto.Properties.DataSource = temp;
                cmb_producto.EditValue = info_producto_padre.IdProducto;

                gridControl_lote.DataSource = blst;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_funcion(Cl_Enumeradores.eFuncion_pantalla_lote _funcion)
        {
            try
            {
                FUNCION = _funcion;
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
                if (FUNCION == Cl_Enumeradores.eFuncion_pantalla_lote.DISTRIBUIR)
                {
                    lst_producto = bus_producto.Get_list_Producto_x_producto_padre(param.IdEmpresa, info_producto_padre.IdProducto);
                    cmb_producto_det.DataSource = lst_producto;
                    ucGe_Menu_Superior_Mant1.Visible_bntAprobar = true;
                }
                else
                {
                    ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
                    lst_producto = bus_producto.get_list_Producto_stock_X_lote(param.IdEmpresa, info_producto_padre.IdSucursal,info_producto_padre.IdBodega, info_producto_padre.IdProducto);
                    cmb_producto_det.DataSource = lst_producto;
                    info_in_param = bus_in_param.Get_Info_Parametro(param.IdEmpresa);
                    blst = new BindingList<in_producto_lote>();
                    foreach (var item in lst_producto)
                    {
                        in_producto_lote det = new in_producto_lote
                        {
                            IdProducto = item.IdProducto,
                            lote_fecha_fab = item.lote_fecha_fab,
                            lote_fecha_vcto = item.lote_fecha_vcto,
                            lote_numero = item.lote_num_lote,
                            pr_descripcion = item.pr_descripcion,
                            cantidad = item.pr_stock == null ? 0 : Convert.ToDouble(item.pr_stock),
                            dias_vcto = get_diferencia_dias_fecha_actual(item.lote_fecha_vcto == null ? DateTime.Now.Date : Convert.ToDateTime(item.lote_fecha_vcto))
                        };
                        if (det.dias_vcto <= info_in_param.P_Dias_menores_alerta_desde_fecha_actual_amarillo && det.dias_vcto > info_in_param.P_Dias_menores_alerta_desde_fecha_actual_rojo)
                        {
                            det.color_alerta = 1;
                        }
                        else
                            if (det.dias_vcto <= info_in_param.P_Dias_menores_alerta_desde_fecha_actual_rojo)
                            {
                                det.color_alerta = 2;
                            }
                            else
                                det.color_alerta = 0;
                        blst.Add(det);
                    }
                    blst = new BindingList<in_producto_lote>(blst.OrderBy(q => q.lote_fecha_vcto).ToList());
                    gridControl_lote.DataSource = blst;
                    
                    col_IdProducto.OptionsColumn.AllowEdit = false;
                    col_pr_descripcion.OptionsColumn.AllowEdit = false;
                    col_cantidad.OptionsColumn.AllowEdit = false;
                    col_lote_codigo.OptionsColumn.AllowEdit = false;
                    col_lote_fecha_fab.OptionsColumn.AllowEdit = false;
                    col_lote_fecha_vcto.OptionsColumn.AllowEdit = false;
                    gridView_lote.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int get_diferencia_dias_fecha_actual(DateTime Fecha)
        {
            try
            {
                int dias = 0;
                TimeSpan ts = Fecha.Date - DateTime.Now.Date;
                dias = ts.Days;
                return dias;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                lst_retorno = new List<in_producto_lote>();
                if (validar())
                {
                    foreach (var item in blst)
                    {
                        if (item.IdProducto == null)
                            grabar_producto(item);
                        lst_retorno.Add(item);                        
                    }
                }
                Result = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_producto_asignacion_lote_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
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
                Result = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_lote_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_producto_lote row = (in_producto_lote)gridView_lote.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (row.IdProducto == null)
                    return;

                if (e.Column == col_IdProducto)
                {
                    in_Producto_Info row_p = lst_producto.FirstOrDefault(q => q.IdProducto == row.IdProducto);
                    if (row_p == null)
                    {
                        row.lote_numero = null;
                        row.lote_fecha_fab = null;
                        row.lote_fecha_vcto = null;
                        row.cantidad = 1;
                        row.pr_descripcion = null;
                    }
                    else
                    {
                        row.lote_numero = row_p.lote_num_lote;
                        row.lote_fecha_fab = row_p.lote_fecha_fab;
                        row.lote_fecha_vcto = row_p.lote_fecha_vcto;
                        row.pr_descripcion = row_p.pr_descripcion;
                        row.cantidad = 1;
                    }
                }

                if (e.Column == col_lote_fecha_vcto)
                {
                    asignar_color_alerta();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void asignar_color_alerta()
        {
            try
            {
                foreach (var item in blst.Where(q=>q.lote_fecha_vcto != null).ToList())
                {
                    item.dias_vcto = get_diferencia_dias_fecha_actual(Convert.ToDateTime(item.lote_fecha_vcto));
                    if (item.dias_vcto <= info_in_param.P_Dias_menores_alerta_desde_fecha_actual_amarillo && item.dias_vcto > info_in_param.P_Dias_menores_alerta_desde_fecha_actual_rojo)
                    {
                        item.color_alerta = 1;
                    }
                    else
                        if (item.dias_vcto <= info_in_param.P_Dias_menores_alerta_desde_fecha_actual_rojo)
                        {
                            item.color_alerta = 2;
                        }
                        else
                            item.color_alerta = 0;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool grabar_producto(in_producto_lote p_nuevo)
        {
            try
            {
                decimal IdProducto_nuevo = 0;
                string mensaje="";
                in_Producto_Info info_producto_nuevo = new in_Producto_Info
                {
                    IdProducto = 0,
                    IdProducto_padre = info_producto_padre.IdProducto,
                    lote_fecha_fab = p_nuevo.lote_fecha_fab,
                    lote_fecha_vcto = p_nuevo.lote_fecha_vcto,
                    lote_num_lote = p_nuevo.lote_numero,
                    pr_descripcion = p_nuevo.pr_descripcion,
                    pr_descripcion_2 = p_nuevo.pr_descripcion,
                    pr_codigo = "",
                    IdEmpresa = param.IdEmpresa,
                    se_distribuye = info_producto_padre.se_distribuye,
                    IdProductoTipo = info_producto_padre.IdProductoTipo,
                    IdMarca = info_producto_padre.IdMarca,
                    IdPresentacion = Convert.ToString(info_producto_padre.IdPresentacion),
                    IdCategoria = info_producto_padre.IdCategoria,
                    IdLinea = info_producto_padre.IdLinea,
                    IdGrupo = info_producto_padre.IdGrupo,
                    IdSubGrupo = info_producto_padre.IdSubGrupo,
                    IdUnidadMedida = info_producto_padre.IdUnidadMedida,
                    IdUnidadMedida_Consumo = info_producto_padre.IdUnidadMedida_Consumo,
                    pr_codigo_barra = info_producto_padre.pr_codigo_barra == null ? "" : info_producto_padre.pr_codigo_barra,//27
                    pr_observacion = info_producto_padre.pr_observacion == null ? "" : info_producto_padre.pr_observacion,//39
                    precio_1 = info_producto_padre.precio_1,
                    precio_2 = info_producto_padre.precio_2,
                    precio_3 = info_producto_padre.precio_3,
                    precio_4 = info_producto_padre.precio_4,
                    precio_5 = info_producto_padre.precio_5,
                    IdUsuario = (info_producto_padre.IdUsuario == null) ? "" : info_producto_padre.IdUsuario.Trim(),//20
                    Fecha_Transac = DateTime.Now,//5
                    IdUsuarioUltMod = (info_producto_padre.IdUsuarioUltMod == null) ? "" : info_producto_padre.IdUsuarioUltMod.Trim(),//22
                    Fecha_UltMod = DateTime.Now,//7
                    ip = (info_producto_padre.ip == null) ? "" : info_producto_padre.ip,//23
                    nom_pc = (info_producto_padre.nom_pc == null) ? "" : info_producto_padre.nom_pc,//24
                    Estado = "A",//4
                    IdCod_Impuesto_Iva = (info_producto_padre.IdCod_Impuesto_Iva == null) ? "IVA0" : info_producto_padre.IdCod_Impuesto_Iva,
                    
                    Aparece_modu_Ventas = info_producto_padre.Aparece_modu_Ventas,
                    Aparece_modu_Compras = info_producto_padre.Aparece_modu_Compras,
                    Aparece_modu_Inventario = info_producto_padre.Aparece_modu_Inventario,
                    Aparece_modu_Activo_F = info_producto_padre.Aparece_modu_Activo_F,
                };
                

                if (bus_producto.GrabarDB(info_producto_nuevo,ref IdProducto_nuevo,ref mensaje))
                {
                    p_nuevo.IdProducto = IdProducto_nuevo;
                    return true;    
                }
                return false;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validar()
        {
            try
            {
                foreach (var item in blst)
                {
                    if (item.IdProducto == null)
                    {
                        if (item.pr_descripcion == null)
                        {
                            MessageBox.Show("Existen productos sin descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        if (item.lote_fecha_fab == null)
                        {
                            MessageBox.Show("El producto " + item.pr_descripcion + ", no tiene fecha de fabricación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        if (item.lote_fecha_vcto == null)
                        {
                            MessageBox.Show("El producto " + item.pr_descripcion + ", no tiene fecha de vencimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        if (item.lote_numero == null)
                        {
                            MessageBox.Show("El producto " + item.pr_descripcion + ", no tiene código de lote", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        if (bus_producto.codigo_lote_existe(param.IdEmpresa,info_producto_padre.IdProducto, item.lote_numero))
                        {
                            MessageBox.Show("El producto " + item.pr_descripcion + ", ya existe con el código de lote: "+item.lote_numero, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        
                    }
                    if (item.cantidad == 0)
                    {
                        MessageBox.Show("El producto " + item.pr_descripcion + ", no tiene cantidad a ser asignada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
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

        public List<in_producto_lote> get_lista_retorno()
        {
            try
            {
                return lst_retorno;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<in_producto_lote>();
            }
        }

        public in_producto_lote get_info_retorno()
        {
            try
            {
                return info_retorno;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_producto_lote();
            }
        }

        private void gridView_lote_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_lote.DeleteRow(gridView_lote.FocusedRowHandle);
                    }
                }
                if (FUNCION == Cl_Enumeradores.eFuncion_pantalla_lote.SELECCIONAR)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        info_retorno = (in_producto_lote)gridView_lote.GetFocusedRow();
                        if (info_retorno != null)
                        {
                            Result = System.Windows.Forms.DialogResult.OK;
                            this.Close();
                        }                    
                    }    
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_lote_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (FUNCION == Cl_Enumeradores.eFuncion_pantalla_lote.SELECCIONAR)
                {
                    info_retorno = (in_producto_lote)gridView_lote.GetFocusedRow();
                    if (info_retorno != null)
                    {
                        Result = System.Windows.Forms.DialogResult.OK;
                        this.Close();    
                    }                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class in_producto_lote
    {
        public Nullable<decimal> IdProducto { get; set; }
        public string lote_numero { get; set; }
        public Nullable<DateTime> lote_fecha_fab { get; set; }
        public Nullable<DateTime> lote_fecha_vcto { get; set; }
        public double cantidad { get; set; }
        public string pr_descripcion { get; set; }
        public int color_alerta { get; set; }
        public int dias_vcto { get; set; }
    }
}
