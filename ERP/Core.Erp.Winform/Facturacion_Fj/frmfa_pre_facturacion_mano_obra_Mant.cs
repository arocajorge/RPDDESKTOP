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
    public partial class frmfa_pre_facturacion_mano_obra_Mant : Form
    {
       

        #region Variables
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_pre_facturacion_Info info_prefacturacion = new fa_pre_facturacion_Info();
        fa_pre_facturacion_mano_obra_servindustria_Bus bus_mano_obra = new fa_pre_facturacion_mano_obra_servindustria_Bus();
        BindingList<fa_pre_facturacion_mano_obra_servindustria_Info> lista_mano_obra = new BindingList<fa_pre_facturacion_mano_obra_servindustria_Info>();

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

                lista_mano_obra =new BindingList<fa_pre_facturacion_mano_obra_servindustria_Info>( bus_mano_obra.GetList(info_prefacturacion.IdEmpresa,Convert.ToInt32( info_prefacturacion.IdPeriodo)));
                gridControl_gastos.DataSource = lista_mano_obra;
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

        public frmfa_pre_facturacion_mano_obra_Mant()
        {
            InitializeComponent();
        }

        void frmfa_pre_facturacion_servisndustria_Mant_event_delegate_frmfa_pre_facturacion_servisndustria_Mant_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frmfa_pre_facturacion_servisndustria_Mant_Load(object sender, EventArgs e)
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

                if (bus_mano_obra.EliminarDB(info_prefacturacion.IdEmpresa,info_prefacturacion.IdPeriodo, info_prefacturacion.IdPreFacturacion))
                {
                    if (bus_mano_obra.GuardarDB(lista_mano_obra.ToList()))
                    {
                        MessageBox.Show("Registros actualizados correctamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
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

                foreach (var item in lista_mano_obra)
                {
                    item.IdPrefacturacion = Convert.ToDecimal(txt_IdPreFacturacion.Text);
                    //item.IdCentroCosto = cmb_centro_costo.EditValue.ToString();
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
                gridControl_gastos.ShowPrintPreview();
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

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XFAC_FJ_Rpt016_Rpt Reporte = new XFAC_FJ_Rpt016_Rpt();
                Reporte.Parameters["IdPeriodo"].Value = info_prefacturacion.IdPeriodo;
                Reporte.Parameters["FechaInicio"].Value =info_prefacturacion.pe_FechaIni;
                Reporte.Parameters["FechaFin"].Value = info_prefacturacion.pe_FechaFin;

                Reporte.ShowPreview();
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

        private void gridView_gastos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    gridView_gastos.DeleteSelectedRows();
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
