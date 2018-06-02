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
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;

namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Empleado_x_Grupo_x_fuerza_cargo_Mant : Form
    {
        #region



        BindingList<ro_empleado_x_cargo_fuerza_grupo_Info> lista_planificacion = new BindingList<ro_empleado_x_cargo_fuerza_grupo_Info>();
        ro_empleado_x_cargo_fuerza_grupo_Bus Bus_planificacion = new ro_empleado_x_cargo_fuerza_grupo_Bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<ro_fuerza_Info> lista_fuerza = new List<ro_fuerza_Info>();
        ro_fuerza_Bus bus_fuerza = new ro_fuerza_Bus();

        List<ro_Cargo_Info> listaCargo = new List<ro_Cargo_Info>();
        ro_Cargo_Bus bus_cargo = new ro_Cargo_Bus();

        List<ro_Grupo_empleado_Info> lista_grupo = new List<ro_Grupo_empleado_Info>();
        ro_Grupo_empleado_Bus bus_grupo = new ro_Grupo_empleado_Bus();

        List<ro_Nomina_Tipo_Info> lista_nomina = new List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus bus_nomina = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> listaempleado = new List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info>();
        ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Bus bus_empleado = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Bus();

        #endregion

        public frmRo_Empleado_x_Grupo_x_fuerza_cargo_Mant()
        {
            InitializeComponent();
            cargar_dato();
        }

        private void frmRo_Empleado_x_Grupo_x_fuerza_cargo_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                gridControl_planificacion.DataSource = lista_planificacion;
            }
            catch (Exception ex)
            {
                
               
            }
        }


        public void cargar_dato()
        {
            try
            {
               
                cmb_fuerza.ValueMember = "IdFuerza";
                cmb_fuerza.DisplayMember = "fu_descripcion";

                cmb_cargo.ValueMember = "IdCargo";
                cmb_cargo.DisplayMember = "ca_descripcion";

                cmb_grupo.ValueMember = "IdGrupo";
                cmb_grupo.DisplayMember = "Nombre_Grupo";


                cmb_nomina.ValueMember = "IdNomina_Tipo";
                cmb_nomina.DisplayMember = "Descripcion";


                // lista de fuerza
                lista_fuerza = bus_fuerza.Get_List_Fuerza(param.IdEmpresa);
                cmb_fuerza.DataSource = lista_fuerza;

                // lista grupos
                lista_grupo = bus_grupo.listado_Grupos(param.IdEmpresa);
                cmb_grupo.DataSource = lista_grupo;
                // lista cargo
                listaCargo = bus_cargo.ObtenerLstCargo(param.IdEmpresa);

                cmb_cargo.DataSource = listaCargo;

                // nominas

                lista_nomina = bus_nomina.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = lista_nomina;
                cmb_nomina.DataSource = lista_nomina;
                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

               

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                int sec = 0;

                ro_periodo_x_ro_Nomina_TipoLiqui_Info info_pe = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

                info_pe = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
                listaempleado = bus_empleado.Get_listaEventuales_con_marcaciones(param.IdEmpresa,Convert.ToInt32( cmbnomina.EditValue), info_pe.pe_FechaIni, info_pe.pe_FechaFin);


               // lista_planificacion =new BindingList<ro_empleado_x_cargo_fuerza_grupo_Info>( Bus_planificacion.get_lista_planificacion(param.IdEmpresa,Convert.ToInt32( cmbnomina.EditValue),Convert.ToInt32( cmbPeriodos.EditValue)));
                if (lista_planificacion.Count() == 0)
                {
                    foreach (var item in listaempleado)
                    {
                        sec++;
                        ro_empleado_x_cargo_fuerza_grupo_Info info = new ro_empleado_x_cargo_fuerza_grupo_Info();
                        info.IdEmpleado = param.IdEmpresa;
                        info.IdNomina = Convert.ToInt32(cmbnomina.EditValue);
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdCargo = item.IdCargo;
                        if (item.IdGrupo != null)
                            info.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        if (sec % 2 == 0)
                            info.IdFuerza = 1;
                        else
                            info.IdFuerza = 2;
                        lista_planificacion.Add(info);
                    }
                }
                else
                {
                    lista_planificacion =new BindingList<ro_empleado_x_cargo_fuerza_grupo_Info>( Bus_planificacion.get_lista_planificacion(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbPeriodos.EditValue)));
                }

                gridControl_planificacion.DataSource = lista_planificacion;
                cmb_empleado.ValueMember = "IdEmpleado";
                cmb_empleado.DisplayMember = "NombreCompleto";
                cmb_empleado.DataSource = listaempleado;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cmbnomina.Focus();
                string msg = "";
                foreach (var item in lista_planificacion)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdNomina = Convert.ToInt32(cmbnomina.EditValue);
                    item.IdNomina = Convert.ToInt32(cmbnomina.EditValue);
                    item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    Bus_planificacion.GrabarBD(item, ref msg);
                }

                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
