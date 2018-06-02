using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Recursos.Properties;
using Core.Erp.Reportes.Roles;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Relacion_Activo_Fijo_x_Empleado_Mant : Form
    {
        #region variable
        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Bus bus_Activos_en_tarifarios = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<ro_Empleado_Info> listados_Empleados_actuales = new List<ro_Empleado_Info>();
        ro_Empleado_Bus bus_empleado = new Business.Roles.ro_Empleado_Bus();
        List<Af_Activo_fijo_Info> listado_activo_fijo = new List<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Bus bus_activo_Fijo = new Af_Activo_fijo_Bus();
        BindingList<ro_empleado_x_Activo_Fijo_Info> lista_empleados_actual_x_AF = new BindingList<ro_empleado_x_Activo_Fijo_Info>();
        ro_empleado_x_Activo_Fijo_Bus bus_empleado_actuales_AF = new ro_empleado_x_Activo_Fijo_Bus();
        List<ro_empleado_x_Activo_Fijo_Historico_Info> lista_a_grabar_empleados_x_activos_hist = new List<ro_empleado_x_Activo_Fijo_Historico_Info>();
        Af_Activo_fijo_Info info_activoFijo = new Af_Activo_fijo_Info();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

        List<ct_Centro_costo_Info> lista_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();

        List<ct_centro_costo_sub_centro_costo_Info> lista_sub_centro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus bus_subcentro = new ct_centro_costo_sub_centro_costo_Bus();


        int IdEmpleado = 0;
        int Empleados_max_x_activo = 0;
        #endregion
        public frmRo_Relacion_Activo_Fijo_x_Empleado_Mant()
        {
            InitializeComponent();
            cargar_combos();
        }

        private void frmRo_Relacion_Activo_Fijo_x_Empleado_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                lista_empleados_actual_x_AF =new BindingList<ro_empleado_x_Activo_Fijo_Info>( bus_empleado_actuales_AF.listado_emp_x_af(param.IdEmpresa));
                gridControl_empleados_Actuales.DataSource = lista_empleados_actual_x_AF;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void cargar_combos()
        {
            try
            {
                string MensajeError="";
                listados_Empleados_actuales = bus_empleado.Get_List_Empleado_(param.IdEmpresa);
                cmb_empleado.DataSource = listados_Empleados_actuales;
                cmb_empleado.DisplayMember = "pe_NomCompleto";
                cmb_empleado.ValueMember = "IdEmpleado";

                listado_activo_fijo= bus_activo_Fijo.Get_List_ActivoFijo(param.IdEmpresa);
                cmb_activo_Fijo.DataSource = listado_activo_fijo;

                lista_centro_costo=bus_centro_costo.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo.DataSource = lista_centro_costo;

                lista_sub_centro = bus_subcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_subcentro.DataSource = lista_sub_centro;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                    if (Grabar())
                    {
                       
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            { 
                if(Grabar())
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


     
        public bool Grabar()
        {
            try
            {
                bool bandera = false;
                bus_empleado_actuales_AF.Eliminar(param.IdEmpresa);
                ucGe_Menu.Focus();
                foreach (var item in lista_empleados_actual_x_AF)
                {
                    if (item.IdEmpleado == 28)
                    {
                        
                    }

                    if(item.IdActivo_fijo>0)
                    info_activoFijo = listado_activo_fijo.Where(v=>v.IdActivoFijo==item.IdActivo_fijo).FirstOrDefault();
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdNomina_tipo = 1;
                    item.Fecha_Asignacion = DateTime.Now.Date;
                    item.Fecha_Hasta = DateTime.Now.Date;
                    // Actualizo el centro de costo por empleado
                    item.Info_Centro_costo_x_empleado = new ro_empleado_x_centro_costo_Info();
                    item.Info_Centro_costo_x_empleado.IdEmpresa = param.IdEmpresa;
                    item.Info_Centro_costo_x_empleado.IdEmpleado = item.IdEmpleado;
                    item.Info_Centro_costo_x_empleado.IdCentroCosto = item.IdCentroCosto;
                    item.Info_Centro_costo_x_empleado.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    item.Info_Centro_costo_x_empleado.FechaIngresa = DateTime.Now.Date;

                    item.Info_Centro_costo_x_empleado.UsuarioIngresa = param.IdUsuario;
                    bandera = bus_empleado_actuales_AF.Guardar_DB(item);

                }

                 if (bandera)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return bandera;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }

        
        private void cmb_empleado_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {

                IdEmpleado = Convert.ToInt32(e.NewValue);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

      
        private void gridView_empleados_actuales_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == "col_cmb_activo_Fijo")
                {
                    ro_empleado_x_Activo_Fijo_Info info_af ;
                    info_af = (ro_empleado_x_Activo_Fijo_Info)gridView_empleados_actuales.GetFocusedRow();
                    if (info_af!=null)
                    {
                        info_activoFijo = listado_activo_fijo.Where(v=>v.IdActivoFijo==info_af.IdActivo_fijo).FirstOrDefault();
                        if (info_activoFijo != null)
                        {

                        }


                    }
                }

                if (e.Column.Name == "col_idEmpleado")
                {
                    ro_empleado_x_Activo_Fijo_Info info_af;
                    info_af = (ro_empleado_x_Activo_Fijo_Info)gridView_empleados_actuales.GetFocusedRow();
                    if (info_af != null)
                    {

                        int num = lista_empleados_actual_x_AF.Where(v => v.IdEmpleado == info_af.IdEmpleado).Count();
                        if (num > 1)
                        {
                            MessageBox.Show("El empleado ya esta relacionado con una maquina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gridView_empleados_actuales.DeleteSelectedRows();
                        }
                    }
                }

            } 
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridView_empleados_actuales.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                
             
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView_empleados_actuales_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                gridView_empleados_actuales.DeleteSelectedRows();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


    
     
     

    }
}
