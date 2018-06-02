using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_presupuesto_x_fuerza_cargo : Form
    {
        public frmRo_presupuesto_x_fuerza_cargo()
        {
            InitializeComponent();
            CargarDatos();
        }

        
        #region varibales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action _Accion;

        BindingList<ro_presupuesto_x_fuerza_x_cargo_Info> listPresupuesto=new BindingList<ro_presupuesto_x_fuerza_x_cargo_Info>();
        List<ro_presupuesto_x_fuerza_x_cargo_Info> listatmp = new List<ro_presupuesto_x_fuerza_x_cargo_Info>();

        ro_presupuesto_x_fuerza_x_cargo_Bus bus_presupuesto = new ro_presupuesto_x_fuerza_x_cargo_Bus();

        ro_Empleado_Bus bus_empleado = new ro_Empleado_Bus();

        List<ro_Cargo_Info> listaCargo = new List<ro_Cargo_Info>();
        ro_Cargo_Bus bus_cargo = new ro_Cargo_Bus();



        List<ro_fuerza_Info> listaFuerza = new List<ro_fuerza_Info>();
        ro_fuerza_Bus bus_fuerza = new ro_fuerza_Bus();



        ro_disco_Bus bus_Disco = new ro_disco_Bus();

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

      
        #endregion
       
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu.Focus();
                string mes = "";
               
            foreach (var item in listPresupuesto)
            {
                item.IdEmpresa = param.IdEmpresa;
                item.IdNomina = Convert.ToInt32(cmbnomina.EditValue);
                bus_presupuesto.GrabarBD(item, ref mes);
            }

            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
            }

            
        }

        private void frmRo_presupuesto_x_fuerza_cargo_Load(object sender, EventArgs e)
        {
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
                cmbnomina.EditValue = 1;


              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void CargarDatos()
        {
            try
            {


                listaCargo = bus_cargo.ObtenerLstCargo(param.IdEmpresa);
                cmbCargo.DataSource = listaCargo;
                cmbCargo.ValueMember = "IdCargo";
                cmbCargo.DisplayMember = "ca_descripcion";


                listaFuerza = bus_fuerza.Get_List_Fuerza(param.IdEmpresa);

                cmbFuerza.DataSource = listaFuerza;
                cmbFuerza.ValueMember = "IdFuerza";
                cmbFuerza.DisplayMember = "fu_descripcion";
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewPresupuesto_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double sueldo = 0;
                double valorHora = 0;
                double costo = 0;
                double variable = 0;
                double beneficio = 0;
                double mov_masTra = 0;
                double total = 0;

                if (e.Column.Name == "Col_CantidadVpp" || e.Column.Name == "Col_Dias_SyD_y_Feriado" || e.Column.Name == "Col_diasEfectivos" || e.Column.Name == "Col_BaseVariable")
                {
                    ro_Empleado_Info info_empleado = new ro_Empleado_Info();
                    ro_presupuesto_x_fuerza_x_cargo_Info info_pr = new ro_presupuesto_x_fuerza_x_cargo_Info();
                    info_pr = (ro_presupuesto_x_fuerza_x_cargo_Info)gridViewPresupuesto.GetFocusedRow();
                    if (info_pr != null)
                    {
                        info_empleado = bus_empleado.Get_info_datosPresupuesto(param.IdEmpresa, info_pr.IdCargo);
                        if (info_empleado != null)
                        {
                            sueldo = info_empleado.SueldoActual;
                            valorHora =( sueldo / info_empleado.grupo.Calculo_Horas_extras_Sobre)*2;
                            costo = valorHora * info_empleado.grupo.Max_num_horas_sab_dom * info_pr.Dias_SyD_y_Feriado;
                            variable =Convert.ToDouble( info_pr.BaseVariable);
                            beneficio = (sueldo + costo + variable) * 1.4214;
                            mov_masTra = (info_empleado.grupo.Valor_Alimen + info_empleado.grupo.Valor_Transp) * info_pr.diasEfectivos;
                            total =( beneficio + mov_masTra)*Convert.ToDouble(  info_pr.CantidadEmpleados);
                            gridViewPresupuesto.SetFocusedRowCellValue(Col_Presupuesto,total );

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;
                cmbnominaTipo.EditValue = 2;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ro_periodo_x_ro_Nomina_TipoLiqui_Info info_per = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                 info_per=(ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
                if (cmbPeriodos.EditValue != null && cmbnomina.EditValue != null && cmbnominaTipo.EditValue != null)
                {

                    if (info_per == null)
                        info_per = listadoPeriodo.Where(v=>v.IdPeriodo==Convert.ToInt32(cmbPeriodos.EditValue)).FirstOrDefault();
                    listPresupuesto = new BindingList<ro_presupuesto_x_fuerza_x_cargo_Info>(bus_presupuesto.GetPresupuesto(param.IdEmpresa, info_per.IdNomina_Tipo, info_per.pe_FechaIni.Year, info_per.pe_FechaIni.Month));
                    gridControlPresupuesto.DataSource = listPresupuesto;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewPresupuesto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.KeyCode.ToString() == "Delete")
                {
                    gridViewPresupuesto.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.ToString());
            }
        }

        public void set( int IdPeriodo, int idnomina, int idnominatipo)
        {
            try
            {
                cmbnomina.EditValue = Convert.ToInt32(idnomina);
                cmbnominaTipo.EditValue = Convert.ToInt32(cmbnominaTipo.EditValue);
                cmbPeriodos.EditValue = IdPeriodo;
            }
            catch (Exception ex)
            {
                
             MessageBox.Show(ex.ToString());

            }
        }
    }
}
