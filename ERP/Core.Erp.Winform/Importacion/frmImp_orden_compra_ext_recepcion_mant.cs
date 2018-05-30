using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_orden_compra_ext_recepcion_mant : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        BindingList<imp_orden_compra_ext_det_Info> blst_det;
        imp_orden_compra_ext_det_Bus bus_det;
        imp_orden_compra_ext_recepcion_Info info_recepcion;
        imp_orden_compra_ext_recepcion_Bus bus_recepcion;
        cl_parametrosGenerales_Bus param;
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        List<imp_orden_compra_ext_Info> lst_oc_ex;
        imp_orden_compra_ext_Bus bus_oc_ex;
        List<in_UnidadMedida_Info> lst_unidad_medida;
        in_UnidadMedida_Bus bus_unidad_medida;
        List<in_Producto_Info> lst_producto;
        in_producto_Bus bus_producto;
        #endregion

        #region delegado
        public delegate void delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed event_delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed;

        void frmImp_orden_compra_ext_recepcion_mant_event_delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmImp_orden_compra_ext_recepcion_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public frmImp_orden_compra_ext_recepcion_mant()
        {
            InitializeComponent();
            param = cl_parametrosGenerales_Bus.Instance;
            blst_det = new BindingList<imp_orden_compra_ext_det_Info>();
            bus_det = new imp_orden_compra_ext_det_Bus();
            info_recepcion = new imp_orden_compra_ext_recepcion_Info();
            bus_recepcion = new imp_orden_compra_ext_recepcion_Bus();
            event_delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed += frmImp_orden_compra_ext_recepcion_mant_event_delegate_frmImp_orden_compra_ext_recepcion_mant_FormClosed;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            lst_oc_ex = new List<imp_orden_compra_ext_Info>();
            bus_oc_ex = new imp_orden_compra_ext_Bus();
            lst_producto = new List<in_Producto_Info>();
            bus_producto = new in_producto_Bus();
            lst_unidad_medida = new List<in_UnidadMedida_Info>();
            bus_unidad_medida = new in_UnidadMedida_Bus();
        }        

        public void set_info(imp_orden_compra_ext_recepcion_Info _info)
        {
            try
            {
                info_recepcion = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _accion)
        {
            try
            {
                Accion = _accion;
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
                lst_oc_ex = bus_oc_ex.get_list(param.IdEmpresa);
                cmb_orden_compra_externa.Properties.DataSource = lst_oc_ex;

                de_fecha.DateTime = DateTime.Now;

                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa);
                cmb_producto.DataSource = lst_producto;

                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = lst_unidad_medida;

                blst_det = new BindingList<imp_orden_compra_ext_det_Info>();
                gridControl_det.DataSource = blst_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImp_orden_compra_ext_recepcion_mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_orden_compra_externa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_orden_compra_externa.EditValue != null)
                    blst_det = new BindingList<imp_orden_compra_ext_det_Info>(bus_det.get_list(param.IdEmpresa, Convert.ToDecimal(cmb_orden_compra_externa.EditValue)));
                else
                    blst_det = new BindingList<imp_orden_compra_ext_det_Info>();
                gridControl_det.DataSource = blst_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private bool validar()
        {
            try
            {
                cmb_orden_compra_externa.Focus();

                if (cmb_orden_compra_externa.EditValue == null)
                {
                    MessageBox.Show("Seleccione la orden de compra externa ha ser recibida",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

        private void get_info()
        {
            try
            {
                info_recepcion.IdEmpresa = param.IdEmpresa;
                info_recepcion.IdOrdenCompra_ext = Convert.ToDecimal(cmb_orden_compra_externa.EditValue);
                info_recepcion.or_fecha = de_fecha.DateTime.Date;
                info_recepcion.or_observacion = txt_observacion.Text.Trim();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool guardarDB()
        {
            try
            {
                bool res = false;

                if (!validar()) return false;
                get_info();
                if (bus_recepcion.guardarDB(info_recepcion))
                {
                    bus_det.eliminarDB(info_recepcion.IdEmpresa, info_recepcion.IdOrdenCompra_ext);
                    if (bus_det.guardarDB(new List<imp_orden_compra_ext_det_Info>(blst_det)))
                    {
                        MessageBox.Show("Registro actualizado correctamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        res = true;
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void limpiar()
        {
            try
            {
                txt_observacion.Text = "";
                cmb_orden_compra_externa.EditValue = null;
                de_fecha.DateTime = DateTime.Now.Date;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = true;
                        menu.Visible_bntLimpiar = true;
                        menu.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = true;
                        menu.Visible_bntLimpiar = true;
                        menu.Visible_btnGuardar = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        menu.Visible_bntAnular = true;
                        menu.Visible_bntGuardar_y_Salir = false;
                        menu.Visible_bntLimpiar = true;
                        menu.Visible_btnGuardar = false;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        menu.Visible_bntAnular = false;
                        menu.Visible_bntGuardar_y_Salir = false;
                        menu.Visible_bntLimpiar = true;
                        menu.Visible_btnGuardar = false;
                        set_info_in_controls();
                        break;
                }
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
                txt_observacion.Text = info_recepcion.or_observacion;
                cmb_orden_compra_externa.EditValue = info_recepcion.IdOrdenCompra_ext;
                de_fecha.DateTime = info_recepcion.or_fecha;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDB())
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDB())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_det_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                imp_orden_compra_ext_det_Info row = (imp_orden_compra_ext_det_Info)gridView_det.GetRow(e.RowHandle);
                if (row == null) return;
                if (e.Column == col_cantidad_recibida)
                    row.od_total_fob = Math.Round(row.od_costo_final * row.od_cantidad_recepcion, 2, MidpointRounding.AwayFromZero);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}