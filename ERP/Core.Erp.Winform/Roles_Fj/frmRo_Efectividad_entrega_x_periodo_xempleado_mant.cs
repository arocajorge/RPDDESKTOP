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
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Efectividad_entrega_x_periodo_xempleado_mant : Form
    { 
        #region variable

        DataTable dt;
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";


        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }

        
        List<ro_ruta_Info> lista_ruta = new List<ro_ruta_Info>();
        ro_ruta_Bus bus_ruta = new ro_ruta_Bus();




        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();



        ro_fectividad_Entrega_x_Periodo_Empleado_Info info_efectividad= new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
        ro_fectividad_Entrega_x_Periodo_Empleado_Bus bus_efectividad = new ro_fectividad_Entrega_x_Periodo_Empleado_Bus();
        BindingList<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad = new BindingList<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();
        ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus bus_efectividad_detalle = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus();



        List<ro_Calculo_Pago_Variable_Porcentaje_Info> Lista_Calculo = new List<ro_Calculo_Pago_Variable_Porcentaje_Info>();

        ro_Calculo_Pago_Variable_Porcentaje_Bus Bus_Calculo = new ro_Calculo_Pago_Variable_Porcentaje_Bus();
        
        #endregion
        public frmRo_Efectividad_entrega_x_periodo_xempleado_mant()
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
                    Guardar_Datos();
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

                cmb_ruta.ValueMember = "IdRuta";
                cmb_ruta.DisplayMember = "ru_descripcion";

                // lista de rutas 
                lista_ruta = bus_ruta.Get_List_Ruta(param.IdEmpresa);
                cmb_ruta.DataSource = lista_ruta;




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
                info_periodo = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
                if (info_periodo == null)
                    info_periodo = listadoPeriodo.Where(v => v.IdPeriodo == info_efectividad.IdPeriodo).FirstOrDefault();
                lista_efectividad = new BindingList<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>(bus_efectividad_detalle.lista_planificada(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue),Convert.ToInt32(cmbPeriodos.EditValue)));
                gridControl_Efectividad.DataSource = lista_efectividad;



                Lista_Calculo = Bus_Calculo.Get_List_Calculo_Pago_Porcentaje(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                gc_ro_Calculo_Pago_Variable_Porcentaje.DataSource = Lista_Calculo;
         

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
                info_efectividad = new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
                info_efectividad.lista = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();
                info_efectividad.IdEmpresa = param.IdEmpresa;
                info_efectividad.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                info_efectividad.IdNomina_tipo_Liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                info_efectividad.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                info_efectividad.Observacion = txtobservacion.Text;
                info_efectividad.IdUsuario = param.IdUsuario;
                info_efectividad.FechaTransac = DateTime.Now;
                info_efectividad.IdUsuarioUltModi = param.IdUsuario;
                info_efectividad.FechaUltModi = DateTime.Now;

                foreach (var item in lista_efectividad)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    item.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                    item.IdNomina_tipo_Liq = info_efectividad.IdNomina_tipo_Liq;
                    item.IdPeriodo = info_efectividad.IdPeriodo;
                    item.fecha_Pago = info_periodo.pe_FechaIni.AddDays(1);
                }

                info_efectividad.lista = lista_efectividad.ToList();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public  void set(ro_fectividad_Entrega_x_Periodo_Empleado_Info info)
        {
            try
            {
                info_efectividad = info;
                cmbnomina.EditValue = info.IdNomina_Tipo;
                cmbnominaTipo.EditValue = info.IdNomina_tipo_Liq;
                cmbPeriodos.EditValue = info.IdPeriodo;
                txtobservacion.Text = info.Observacion;
                lista_efectividad =new BindingList<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>( bus_efectividad_detalle.lista_efectividad_x_periodo_x_empleado(info.IdEmpresa, info.IdNomina_Tipo, info.IdPeriodo,info.IdEfectividad));
                gridControl_Efectividad.DataSource = lista_efectividad;
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
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Seleccione el periodo para la planificación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodos.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Ingrese una observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Get();
                return bus_efectividad.Guardar_DB(info_efectividad);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        bool Modificar()
        {
            try
            {
                Get();
                return bus_efectividad.Modificar_DB(info_efectividad);
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
                    ba_asi_anulo= bus_efectividad.Anular_DB(info_efectividad);
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
                     bandera_si_grabo  = Modificar();
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
                        gridView_Efectividad.DeleteSelectedRows();
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
                frmRo_ruta_mant frm = new frmRo_ruta_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_ruta = bus_ruta.Get_List_Ruta(param.IdEmpresa);
                cmb_ruta.DataSource = lista_ruta;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }      
        void ObterRutaExcel()
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();
                // dialogo.Filter = "All files (*.XLS*)|*.XLSX*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);
                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    ruta = path + "\\" + fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }     
        bool Validar_Carga_Archivo()
        {
            try
            {
                return Validar_datos_periodo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
        bool Validar_datos_periodo()
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
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Seleccione el periodo para la planificación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtobservacion.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Ingrese una observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (lista_efectividad.Count() == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " No existe datos de planificación para la nomina y periodo seleccionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }     
        private void gvw_ro_Calculo_Pago_Variable_Porcentaje_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
           
        }
        private void gridView_Efectividad_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Efectividad.GetRow(e.RowHandle) as ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info;
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

                ro_fectividad_Entrega_x_Periodo_Empleado_Info newRow = new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
                if (rowData.Count() >= 3) //return false;          
                {


                    string Ruta = Convert.ToString(rowData[0]);
                    decimal Entrega = Convert.ToDecimal(rowData[1]);
                    decimal Volumen = Convert.ToDecimal(rowData[2]);
                    decimal Cartera = Convert.ToDecimal(rowData[3]);
                    
                   


                    ro_fectividad_Entrega_x_Periodo_Empleado_Info emp = new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
                    if (!string.IsNullOrWhiteSpace(Ruta.ToString()))
                    {
                        if (fx_Verificar_Reg_Repetidos(emp, false, 0))
                        {



                            foreach (var item in lista_efectividad)
                            {

                                if (item.ru_descripcion == Ruta)
                                {
                                    List<ro_Calculo_Pago_Variable_Porcentaje_Info> Lista_tmp = new List<ro_Calculo_Pago_Variable_Porcentaje_Info>();
                                    item.ruta_excel = Ruta;
                                    // busco el porcentaje correspondiente de efectividad



                                    item.Efectividad_Entrega = Convert.ToDecimal(Entrega);
                                    Lista_tmp = Lista_Calculo.Where(v => v.Efec_Entrega_Rango == Entrega.ToString()).ToList();
                                    if (Lista_tmp.Count() > 0)
                                        item.Efectividad_Entrega_aplica = Convert.ToDouble(Lista_tmp.FirstOrDefault().Efec_Entrega_Aplica);
                                    else
                                        if (Entrega >= 1)
                                            item.Efectividad_Entrega_aplica = 1.3;
                                        else
                                            item.Efectividad_Entrega_aplica = 0;




                                    // busco el porcentaje correspondiente de volumen de entrega

                                    item.Efectividad_Volumen = Convert.ToDecimal(Volumen);
                                    Lista_tmp = Lista_Calculo.Where(v => v.Efec_Volumen_Rango == Volumen.ToString()).ToList();
                                    if (Lista_tmp.Count() > 0)
                                        item.Efectividad_Volumen_aplica = Convert.ToDouble(Lista_tmp.FirstOrDefault().Efec_Volumen_Aplica);
                                    else
                                        if (Volumen >= 1)
                                            item.Efectividad_Volumen_aplica = 1.3;
                                        else
                                            item.Efectividad_Volumen_aplica = 0;
                                    // busco el porcentaje correspondiente de volumen de entrega






                                    item.Recuperacion_cartera = Convert.ToDecimal(Cartera);
                                    Lista_tmp = Lista_Calculo.Where(v => v.Recup_Cartera_Rango == Cartera.ToString().Trim()).ToList();
                                    if (Lista_tmp.Count() > 0)
                                        item.Recuperacion_cartera_aplica = Convert.ToDouble(Lista_tmp.FirstOrDefault().Recup_Cartera_Aplica);
                                    else
                                        if (Cartera >= 1)
                                            item.Recuperacion_cartera_aplica = 1;
                                        else
                                            item.Recuperacion_cartera_aplica = 0;
                                    item.Error = null;


                                }
                                else
                                    item.Error = "Ruta no coincide";
                            }
                        }
                        else
                        {
                            //  MessageBox.Show("Ya se encuentra registrado el codigo del producto # :" + cod_producto);
                            return false;
                        }



                        
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                        return false;

                    }

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
        private Boolean fx_Verificar_Reg_Repetidos(ro_fectividad_Entrega_x_Periodo_Empleado_Info Info_det, Boolean eliminar, int tipo)
        {
            try
            {/*
                int cont = 0;



                if (banderaCargaBatch)
                {
                    cont = (from C in BindList_Ing_egr_inve_det
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }
                else
                {
                    cont = (from C in lista_IngEgrInv
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }


                if (cont == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
                        MessageBox.Show("El producto con la misma cantidad y costo  ya se encuentra ingresado, se procederá con su eliminación.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra ingresado.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    return false;

                }
              * */

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar_Datos();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }
   
    }
}
