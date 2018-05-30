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
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using System.IO;
using System.Data.OleDb;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Nomina_horas_extras_mant : Form
    { 
        #region variable
        string msg = "";

        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }

        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

        ro_nomina_x_horas_extras_det_Info info_nomina_x_he = new ro_nomina_x_horas_extras_det_Info();
        BindingList<ro_nomina_x_horas_extras_det_Info> lista_nomina_he = new BindingList<ro_nomina_x_horas_extras_det_Info>();
        ro_nomina_x_horas_extras_det_Bus bus_nomina_he = new ro_nomina_x_horas_extras_det_Bus();

        ro_Empleado_Bus bus_empleado = new ro_Empleado_Bus();
        List<ro_Empleado_Info> lista_empleado = new System.Collections.Generic.List<ro_Empleado_Info>();
        #endregion
        public frmRo_Nomina_horas_extras_mant()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                    if (Guardar_Datos())
                        limpiar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                if (Guardar_Datos())
                    this.Close();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void cargar_dato()
        {
            try
            {

                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmRo_Efectividad_entrega_x_periodo_xempleado_mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_dato();
            

            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Visible_bntAnular = false;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    cmbnomina.Enabled = false;
                    cmbnominaTipo.Enabled = false;
                    cmbPeriodos.Enabled = false;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                      ucGe_Menu.Visible_btnGuardar = false;
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                       ucGe_Menu.Visible_bntAnular = true;

                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    break;
                case Cl_Enumeradores.eTipo_action.duplicar:
                    break;
                
                default:
                    break;
            }

            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        void Get()
        {
            try
            {
              
                foreach (var item in lista_nomina_he)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    //item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    //item.IdNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                    //item.IdNominaTipo =Convert.ToInt32(cmbnomina.EditValue);
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void set(ro_nomina_x_horas_extras_det_Info info)
        {
            try
            {
                //cmbnomina.EditValue = info.IdNominaTipo;
                //cmbnominaTipo.EditValue = info.IdNominaTipoLiqui;
                //cmbPeriodos.EditValue = info.IdPeriodo;
                lista_nomina_he =new BindingList<ro_nomina_x_horas_extras_det_Info>( bus_nomina_he.Get_Info_Nomina_X_Horas_Extras(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue), Convert.ToInt32(cmbPeriodos.EditValue), ref msg));
                gridControl_nominahe.DataSource = lista_nomina_he;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Validar()
        {
            try
            {
                if (cmbnomina.EditValue == null || cmbnomina.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbnominaTipo.EditValue == null || cmbnominaTipo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodos.EditValue == null || cmbPeriodos.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + "  el periodo ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        bool Grabar()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                Get();

                foreach (var item in lista_nomina_he)
                {
                   if(item.IdEmpleado>0)
                    bus_nomina_he.GuardarBD(item, ref msg);

                }
                splashScreenManager1.CloseWaitForm();
                return true;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
         bool Anular()
        {
            try
            {
                bool ba_asi_anulo = false;
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer anular el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Get();
                    ba_asi_anulo = bus_nomina_he.EliminarBD(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue), Convert.ToInt32(cmbPeriodos.EditValue));
                }
                return ba_asi_anulo;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        bool Guardar_Datos()
        {
            try
            {
                bool bandera_si_grabo = false;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                      bandera_si_grabo = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        bandera_si_grabo = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                     bandera_si_grabo = Anular();
                     break;                  
                    default:
                     bandera_si_grabo= false;
                     break;
                }

                if (bandera_si_grabo)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);


                return bandera_si_grabo;


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void gridView_planificacion_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           if (e.Column.Name == "Col_imagen")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_nominahe.DeleteSelectedRows();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void nuevaRutaToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void gvw_ro_Calculo_Pago_Variable_Porcentaje_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
           
        }
        private void gridView_Efectividad_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_nominahe.GetRow(e.RowHandle) as ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info;
                if (data == null)
                    return;
                if (data.ruta_excel != data.ru_descripcion)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void gridView_Efectividad_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void Pegar_Data()
        {
            try
            {
                if (!Validar())
                    return;
                if (lista_empleado.Count() == 0)
                    return;
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!Agregar_fila_copiada(row))
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }
        private Boolean Agregar_fila_copiada(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });
                decimal IdEmpleado = 0;
                ro_nomina_x_horas_extras_det_Info newRow = new ro_nomina_x_horas_extras_det_Info();
                if (rowData.Count() >= 3) //return false;          
                {

                   
                    int hora=0;
                    int minuto=0;
                    string es_hora="";
                    string cedula = Convert.ToString(rowData[0]);
                    string empleado = Convert.ToString(rowData[1]);
                    DateTime fecha = Convert.ToDateTime(rowData[2]);
                    double horas25 = Convert.ToDouble(rowData[7]);
                    double horas50 = Convert.ToDouble(rowData[8]);
                    double horas100 = Convert.ToDouble(rowData[9]);
                    double TotaHoras = Convert.ToDouble(rowData[10]);
                    es_hora= Convert.ToString(rowData[3]);// primera entrada
                    try
                    {
                           IdEmpleado = lista_empleado.Where(v => v.pe_cedulaRuc == cedula).FirstOrDefault().IdEmpleado;
                    }
                    catch (Exception)
                    {
                        
                    }
                    if(es_hora!="")
                    {
                        if (es_hora.Length > 0)
                        {
                            hora =Convert.ToInt32( es_hora.Substring(0, 2));
                            minuto = Convert.ToInt32(es_hora.Substring(3, 2));
                            newRow.time_entrada1 =new TimeSpan(hora,minuto,0);
                        }
                    }

                    es_hora = Convert.ToString(rowData[4]);// primera salia
                    if (es_hora != "")
                    {
                        if (es_hora.Length > 0)
                        {
                            hora = Convert.ToInt32(es_hora.Substring(0, 2));
                            minuto = Convert.ToInt32(es_hora.Substring(3, 2));
                            newRow.time_salida1 = new TimeSpan(hora, minuto, 0);
                        }
                    }

                    es_hora = Convert.ToString(rowData[5]);// segunda entrada
                    if (es_hora != "")
                    {
                        if (es_hora.Length > 0)
                        {
                            hora = Convert.ToInt32(es_hora.Substring(0, 2));
                            minuto = Convert.ToInt32(es_hora.Substring(3, 2));
                            newRow.time_entrada2 = new TimeSpan(hora, minuto, 0);
                        }
                    }

                    es_hora = Convert.ToString(rowData[6]);// segunda salida
                    if (es_hora != "")
                    {
                        if (es_hora.Length > 0)
                        {
                            hora = Convert.ToInt32(es_hora.Substring(0, 2));
                            minuto = Convert.ToInt32(es_hora.Substring(3, 2));
                            newRow.time_salida2 = new TimeSpan(hora, minuto, 0);
                        }
                    }

                    newRow.pe_cedulaRuc = cedula;
                    newRow.pe_nombreCompleto = empleado;

                    newRow.hora_extra25 = horas25;
                    newRow.hora_extra50 = horas50;
                    newRow.hora_extra100 = horas100;
                    newRow.hora_trabajada = TotaHoras;
                    newRow.FechaRegistro = fecha;
                    newRow.IdEmpleado = IdEmpleado;
                    newRow.IdEmpresa = param.IdEmpresa;
                    newRow.IdTurno = 1;
                    newRow.IdCalendario = Convert.ToInt32(fecha.Year.ToString() + fecha.Month.ToString().PadLeft(2, '0') + fecha.Day.ToString().PadLeft(2, '0'));
                    if(lista_nomina_he.Where(v => v.IdEmpleado==newRow.IdEmpleado && v.IdCalendario==newRow.IdCalendario).Count()==0)
                    lista_nomina_he.Add(newRow);

                    gridControl_nominahe.DataSource = lista_nomina_he;
                }
               
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
      
        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    this.Close();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

                lista_empleado=bus_empleado.get_list_empleado_cargar_combo(param.IdEmpresa,Convert.ToInt32(cmbnomina.EditValue));
                cmb_empleado.DataSource = lista_empleado;
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
                //cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
                cmbPeriodos.Properties.DataSource = listadoPeriodo.ToList();


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
                cmbPeriodos.EditValue = null;
                lista_nomina_he = new BindingList<ro_nomina_x_horas_extras_det_Info>();
                gridControl_nominahe.DataSource=lista_nomina_he;
               
            }
            catch (Exception)
            {
                
               
            }
        }
       
   
    }
}
