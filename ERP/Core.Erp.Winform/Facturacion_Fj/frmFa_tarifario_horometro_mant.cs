using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using System.Linq;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_tarifario_horometro_mant : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_tarifario_horometro_Info info_tarifario = new fa_tarifario_horometro_Info();
        fa_tarifario_horometro_Bus bus_tarifario = new fa_tarifario_horometro_Bus();
        BindingList<fa_tarifario_horometro_det_Info> blst_det = new BindingList<fa_tarifario_horometro_det_Info>();
        fa_tarifario_horometro_det_Bus bus_det = new fa_tarifario_horometro_det_Bus();
        Cl_Enumeradores.eTipo_action Accion;

        List<ct_Centro_costo_Info> lst_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();
        List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();
        List<Af_Activo_fijo_Info> lst_activo = new List<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Bus bus_activo = new Af_Activo_fijo_Bus();
        List<tb_sis_impuesto_Info> lst_impuesto = new List<tb_sis_impuesto_Info>();
        tb_sis_impuesto_Bus bus_impuesto = new tb_sis_impuesto_Bus();
        tb_sis_impuesto_Info info_impuesto = new tb_sis_impuesto_Info();
        #endregion

        #region Delegados
        public delegate void delegate_frmFa_tarifario_horometro_mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmFa_tarifario_horometro_mant_FormClosed event_delegate_frmFa_tarifario_horometro_mant_FormClosed;
        #endregion

        public frmFa_tarifario_horometro_mant()
        {
            InitializeComponent();
            event_delegate_frmFa_tarifario_horometro_mant_FormClosed += frmFa_tarifario_horometro_mant_event_delegate_frmFa_tarifario_horometro_mant_FormClosed;
        }

        void frmFa_tarifario_horometro_mant_event_delegate_frmFa_tarifario_horometro_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmFa_tarifario_horometro_mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_info(fa_tarifario_horometro_Info _info)
        {
            try
            {
                info_tarifario = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFa_tarifario_horometro_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmFa_tarifario_horometro_mant_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                string mensaje="";
                lst_centro_costo = bus_centro_costo.Get_list_Centro_Costo_x_cliente(param.IdEmpresa, ref mensaje);
                cmb_centro_costo.Properties.DataSource = lst_centro_costo;

                lst_activo = bus_activo.Get_List_ActivoFijo(param.IdEmpresa);
                cmb_activo.DataSource = lst_activo;

                lst_producto = bus_producto.Get_list_Producto_modulo_x_Ventas(param.IdEmpresa);
                cmb_producto_horas_extra.Properties.DataSource = lst_producto;
                cmb_producto_horas_normales.Properties.DataSource = lst_producto;

                lst_impuesto = bus_impuesto.Get_List_impuesto("IVA");
                cmb_impuesto.Properties.DataSource = lst_impuesto;

                ucCon_Periodo_ini.Cargar_combos();
                ucCon_Periodo_fin.Cargar_combos();

                blst_det = new BindingList<fa_tarifario_horometro_det_Info>();
                gridControl_tarifario.DataSource = blst_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            try
            {
                txt_IdTarifario.Text = "";
                ucCon_Periodo_fin.Inicializar_Combos();
                ucCon_Periodo_ini.Inicializar_Combos();
                cmb_centro_costo.EditValue = null;
                cmb_producto_horas_extra.EditValue = null;
                cmb_producto_horas_normales.EditValue = null;
                txt_observacion.Text = "";
                blst_det = new BindingList<fa_tarifario_horometro_det_Info>();
                gridControl_tarifario.DataSource = blst_det;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                cargar_combos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        cmb_centro_costo.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        set_info_in_controls();
                        cmb_centro_costo.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        cmb_centro_costo.Properties.ReadOnly = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        cmb_centro_costo.Properties.ReadOnly = true;
                        set_info_in_controls();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                txt_IdTarifario.Text = info_tarifario.IdTarifario.ToString();
                ucCon_Periodo_ini.Set_Periodo(info_tarifario.IdPeriodo_ini);
                ucCon_Periodo_fin.Set_Periodo(info_tarifario.IdPeriodo_fin);
                cmb_centro_costo.EditValue = info_tarifario.IdCentroCosto;
                cmb_producto_horas_extra.EditValue = info_tarifario.IdProducto_hora_extra;
                cmb_producto_horas_normales.EditValue = info_tarifario.IdProducto_hora_regular;
                txt_observacion.Text = info_tarifario.Observacion;
                cmb_impuesto.EditValue = info_tarifario.IdCod_Impuesto;
                txt_porcentaje.Text = info_tarifario.porcentaje.ToString();

                info_tarifario.lst_det = bus_det.get_list(info_tarifario.IdEmpresa, info_tarifario.IdTarifario);
                blst_det = new BindingList<fa_tarifario_horometro_det_Info>(info_tarifario.lst_det);
                gridControl_tarifario.DataSource = blst_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_info()
        {
            try
            {
                info_tarifario.IdEmpresa = param.IdEmpresa;
                info_tarifario.IdTarifario = txt_IdTarifario.Text == "" ? 0 : Convert.ToInt32(txt_IdTarifario.Text);
                info_tarifario.IdPeriodo_ini = ucCon_Periodo_ini.Get_Periodo_Info().IdPeriodo;
                info_tarifario.IdPeriodo_fin = ucCon_Periodo_fin.Get_Periodo_Info().IdPeriodo;
                info_tarifario.IdCentroCosto = cmb_centro_costo.EditValue.ToString();
                info_tarifario.IdProducto_hora_extra = Convert.ToDecimal(cmb_producto_horas_extra.EditValue);
                info_tarifario.IdProducto_hora_regular = Convert.ToDecimal(cmb_producto_horas_normales.EditValue);
                info_tarifario.Observacion = txt_observacion.Text;
                info_tarifario.porcentaje = Convert.ToDouble(txt_porcentaje.Text);
                info_tarifario.IdCod_Impuesto = cmb_impuesto.EditValue.ToString();

                info_tarifario.lst_det = new List<fa_tarifario_horometro_det_Info>(blst_det);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {
                if (ucCon_Periodo_ini.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Seleccione el periodo inicial",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                if (ucCon_Periodo_fin.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Seleccione el periodo final", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmb_centro_costo.EditValue == null)
                {
                    MessageBox.Show("Ingrese el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmb_producto_horas_extra.EditValue == null)
                {
                    MessageBox.Show("Ingrese el producto para la facturación de las horas extra", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmb_producto_horas_normales.EditValue == null)
                {
                    MessageBox.Show("Ingrese el producto para la facturación de las horas normales", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (cmb_impuesto.EditValue == null)
                {
                    MessageBox.Show("Seleccione el porcentaje de iva", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool accion_grabar()
        {
            try
            {
                bool res = false;

                if (!validar()) return false;

                get_info();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = guardarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = modificarDB();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        res = anularDB();
                        break;
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool guardarDB()
        {
            try
            {
                if (bus_tarifario.guardarDB(info_tarifario))
                {
                    MessageBox.Show("Registro guardado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool modificarDB()
        {
            try
            {
                if (bus_tarifario.modificarDB(info_tarifario))
                {
                    MessageBox.Show("Registro modificado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool anularDB()
        {
            try
            {
                if (bus_tarifario.anularDB(info_tarifario))
                {
                    MessageBox.Show("Registro anulado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridView_tarifario_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_IdActivoFijo)
                {
                    if (blst_det.Where(q=>q.IdActivoFijo == Convert.ToDecimal(e.Value)).Count() > 0)
                    {
                        MessageBox.Show("El activo ya existe en el tarifario",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        gridView_tarifario.DeleteRow(e.RowHandle);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_tarifario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_tarifario.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_tarifario_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_tarifario_horometro_det_Info row = (fa_tarifario_horometro_det_Info)gridView_tarifario.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == col_unidades_minimas || e.Column == col_valor_unidad)
                {
                    row.total_valor_x_unidades_minimas = row.unidades_minimas * row.valor_unidad;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_impuesto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_impuesto.EditValue == null)
                    txt_porcentaje.Text = "0";
                else
                {
                    info_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == cmb_impuesto.EditValue.ToString());
                    if (info_impuesto!= null)
                        txt_porcentaje.Text = info_impuesto.porcentaje.ToString();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}