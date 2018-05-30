using Core.Erp.Business.Facturacion;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Cus.Erp.Reports.FJ.Facturacion;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmfa_pre_facturacion_det_gastos_Mant : Form
    {
        #region Delegados
        public delegate void delegate_frmfa_pre_facturacion_det_gastos_Mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmfa_pre_facturacion_det_gastos_Mant_FormClosed event_delegate_frmfa_pre_facturacion_det_gastos_Mant_FormClosed;
        #endregion

        #region Variables
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_pre_facturacion_Bus bus_prefacturacion = new fa_pre_facturacion_Bus();
        fa_pre_facturacion_Info info_prefacturacion = new fa_pre_facturacion_Info();
        List<fa_pre_facturacion_Info> lst_prefacturacion = new List<fa_pre_facturacion_Info>();
        fa_pre_facturacion_det_Fact_x_Gastos_Bus bus_gastos = new fa_pre_facturacion_det_Fact_x_Gastos_Bus();
        BindingList<fa_pre_facturacion_det_Fact_x_Gastos_Info> blst_gastos = new BindingList<fa_pre_facturacion_det_Fact_x_Gastos_Info>();

        List<fa_cliente_x_ct_centro_costo_Info> lst_Cliente_x_Centro_costo = new List<fa_cliente_x_ct_centro_costo_Info>();
        fa_cliente_x_ct_centro_costo_Info info_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Info();
        fa_cliente_x_ct_centro_costo_Bus bus_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> lst_subcentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus bus_subcentro = new ct_centro_costo_sub_centro_costo_Bus();
        #endregion

        public void set_info(fa_pre_facturacion_Info _info)
        {
            try
            {
                info_prefacturacion = _info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                txt_IdPreFacturacion.Text = info_prefacturacion.IdPreFacturacion.ToString();
                txt_Observacion.Text = info_prefacturacion.Observacion;
                ucCon_Periodo1.Set_Periodo(info_prefacturacion.IdPeriodo);
                de_Fecha.EditValue = info_prefacturacion.fecha;
                chk_estado_cierre.Checked = info_prefacturacion.estado_cierre;
                cmb_centro_costo.EditValue = info_prefacturacion.IdCentroCosto;
                if (info_prefacturacion.estado == "I")
                    lblAnulado.Visible = true;

                info_prefacturacion.lst_det_fact = bus_gastos.Get_List(info_prefacturacion.IdEmpresa, info_prefacturacion.IdPreFacturacion);
                blst_gastos = new BindingList<fa_pre_facturacion_det_Fact_x_Gastos_Info>(info_prefacturacion.lst_det_fact);
                gridControl_gastos.DataSource = blst_gastos;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        

        public frmfa_pre_facturacion_det_gastos_Mant()
        {
            InitializeComponent();
            event_delegate_frmfa_pre_facturacion_det_gastos_Mant_FormClosed += frmfa_pre_facturacion_det_gastos_Mant_event_delegate_frmfa_pre_facturacion_det_gastos_Mant_FormClosed;
        }

        void frmfa_pre_facturacion_det_gastos_Mant_event_delegate_frmfa_pre_facturacion_det_gastos_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmfa_pre_facturacion_det_gastos_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmfa_pre_facturacion_det_gastos_Mant_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            try
            {
                get_info();

                blst_gastos = new BindingList<fa_pre_facturacion_det_Fact_x_Gastos_Info>(bus_gastos.Get_List(param.IdEmpresa, de_fecha_ini.DateTime.Date, de_fecha_fin.DateTime.Date,cmb_centro_costo.EditValue.ToString()));

                foreach (var item in info_prefacturacion.lst_det_fact)
                {
                    fa_pre_facturacion_det_Fact_x_Gastos_Info row = blst_gastos.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdTipoCbte_ct == item.IdTipoCbte_ct && q.IdCbteCble_ct== item.IdCbteCble_ct && q.IdPunto_cargo == item.IdPunto_cargo && q.secuencia_ct == item.secuencia_ct && q.IdCuota == item.IdCuota && q.secuencia_cuota == item.secuencia_cuota);
                    if (row != null)
                    {
                        foreach (var item2 in blst_gastos.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdTipoCbte_ct == item.IdTipoCbte_ct && q.IdCbteCble_ct == item.IdCbteCble_ct && q.IdPunto_cargo == item.IdPunto_cargo && q.secuencia_ct == item.secuencia_ct && q.IdCuota == item.IdCuota && q.secuencia_cuota == item.secuencia_cuota))
                        {
                            item2.Checked = true;
                            item2.Valor_a_cobrar = item.Valor_a_cobrar;
                        }
                    }
                }
                gridControl_gastos.DataSource = blst_gastos;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_info_in_controls();
                        ucGe_Menu_Superior_Mant1.btnGuardar.Visible = true;
                        ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.btnGuardar.Visible = false;
                        ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Visible = false;
                        set_info_in_controls();
                        break;
                   default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmfa_pre_facturacion_det_gastos_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                ucCon_Periodo1.Cargar_combos();
                set_accion_in_controls();
                lst_Cliente_x_Centro_costo = bus_Cliente_x_Centro_costo.Get_Vista_Clientes_x_Centro_costo(param.IdEmpresa);
                cmb_centro_costo.Properties.DataSource = lst_Cliente_x_Centro_costo;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private bool Guardar()
        {
            try
            {
                get_info();

                if (bus_gastos.EliminarDB(info_prefacturacion))
                {
                    if (bus_gastos.GuardarDB(info_prefacturacion.lst_det_fact))
                    {
                        MessageBox.Show("Registros actualizados correctamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                        if (MessageBox.Show("Desea imprimir el registro?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            imprimir();
                        }

                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void get_info()
        {
            try
            {
                txt_IdPreFacturacion.Focus();
                info_prefacturacion.lst_det_fact = new List<fa_pre_facturacion_det_Fact_x_Gastos_Info>(blst_gastos.Where(q=>q.Checked == true).ToList());

                foreach (var item in info_prefacturacion.lst_det_fact)
                {
                    item.IdPreFacturacion = Convert.ToDecimal(txt_IdPreFacturacion.Text);
                    item.IdCentro_Costo = cmb_centro_costo.EditValue.ToString();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView_gastos.RowCount; i++)
                {
                    gridView_gastos.SetRowCellValue(i, col_check, chk_seleccionar_visibles.Checked);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_centro_costo.EditValue != null)
                {
                    lst_subcentro = bus_subcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, cmb_centro_costo.EditValue.ToString());
                    cmb_subcentro.DataSource = lst_subcentro;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_imprimir_grilla_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void imprimir()
        {
            try
            {
                XFAC_FJ_Rpt002_Rpt rpt = new XFAC_FJ_Rpt002_Rpt();
                rpt.P_IdPrefacturacion.Value = info_prefacturacion.IdPreFacturacion;
                rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucCon_Periodo1_event_delegate_cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucCon_Periodo1.Get_Periodo_Info() != null)
                {
                    de_fecha_ini.DateTime = ucCon_Periodo1.Get_Periodo_Info().pe_FechaIni.Date;
                    de_fecha_fin.DateTime = ucCon_Periodo1.Get_Periodo_Info().pe_FechaFin.Date;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
