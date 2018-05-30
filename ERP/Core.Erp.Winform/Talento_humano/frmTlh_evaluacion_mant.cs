using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Info.Talento_humano;
using Core.Erp.Business.General;
using Core.Erp.Business.Talento_humano;
using Core.Erp.Info.General;
using System.Linq;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Reportes.TalentoHumano;
namespace Core.Erp.Winform.Talento_humano
{
    public partial class frmTlh_evaluacion_mant : DevExpress.XtraEditors.XtraForm
    { 
        #region variables
        bool ba_si_inicioevaluacion = false;
        int contador = 0;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tlh_evaluacion_opciones_preguntas_respuesta_info info_respuesta = new tlh_evaluacion_opciones_preguntas_respuesta_info();
        tlh_evaluacion_opciones_preguntas_respuesta_bus bus_respuesta = new tlh_evaluacion_opciones_preguntas_respuesta_bus();
        List<tlh_evaluacion_opciones_preguntas_info> listaPreguntas = new List<tlh_evaluacion_opciones_preguntas_info>();
        BindingList<tlh_evaluacion_opciones_preguntas_info> listaPreguntas_a_evaluar = new BindingList<tlh_evaluacion_opciones_preguntas_info>();
        tlh_evaluacion_opciones_preguntas_info info_pregunta_seleccionada = new tlh_evaluacion_opciones_preguntas_info();
        tlh_evaluacion_opciones_preguntas_bus bus_preguntas = new tlh_evaluacion_opciones_preguntas_bus();
        BindingList<tlh_evaluacion_opciones_preguntas_respuesta_det_info> lista_empleado = new BindingList<tlh_evaluacion_opciones_preguntas_respuesta_det_info>();
        tlh_evaluacion_opciones_preguntas_respuesta_det_bus bus_empleados = new tlh_evaluacion_opciones_preguntas_respuesta_det_bus();
        List<ro_Nomina_Tipo_Info> lista_nomina = new List<ro_Nomina_Tipo_Info>();
        List<ro_Departamento_Info> lista_departamento = new List<ro_Departamento_Info>();
        List<ro_Cargo_Info> lista_cargo = new List<ro_Cargo_Info>();
        ro_Nomina_Tipo_Bus bus_nomina = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus bus_deoartamento = new ro_Departamento_Bus();
        ro_Cargo_Bus bus_cargo = new ro_Cargo_Bus();
        tlh_evaluacion_opciones_preguntas_respuesta_det_info info_respuesta_det ;

        Cl_Enumeradores.eTipo_action Accion;
        #endregion        
        #region delegados
        public delegate void delegate_frmTlh_evaluacion_mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmTlh_evaluacion_mant_FormClosing Event_frmTlh_evaluacion_mant_FormClosing;
        #endregion
        public frmTlh_evaluacion_mant()
        {
            InitializeComponent();
        }       
        private void set_accion_in_controls()
        {
            try
            {
                dtpFecha.EditValue = DateTime.Now;
                cargar_combos();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_info_in_controls();
                     
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        set_info_in_controls();                      
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        set_info_in_controls();
                       
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public  void set_accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public  void set_info(tlh_evaluacion_opciones_preguntas_respuesta_info _info)
        {
            try
            {
                info_respuesta = _info;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void set_info_in_controls()
        {
            try
            {
                dtpFecha.EditValue = info_respuesta.Fecha_evaluacion;
                listaPreguntas_a_evaluar =new BindingList<tlh_evaluacion_opciones_preguntas_info>( bus_preguntas.get_list_pregunta_con_detalle(param.IdEmpresa, info_respuesta.IdCalendario));
                gridControl_variables_a_evaluar.DataSource = listaPreguntas_a_evaluar;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void get_info()
        {
            try
            {
                info_respuesta.IdEmpresa = param.IdEmpresa;
                info_respuesta.IdCalendario =Convert.ToInt32( dtpFecha.DateTime.Year.ToString() + dtpFecha.DateTime.Month.ToString().PadLeft(2, '0') + dtpFecha.DateTime.Day.ToString().PadLeft(2, '0'));
                info_respuesta.detalle = lista_empleado.ToList();
                info_respuesta.info_pregunta = info_pregunta_seleccionada;
                info_respuesta.Fecha_evaluacion =Convert.ToDateTime( dtpFecha.EditValue);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiar()
        {
            try
            {
               
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion_in_controls();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validar()
        {
            try
            {


               

               

               

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool guardarDB()
        {
            try
            {
                string mensaje = "";
                if (bus_respuesta.Guardar_DB(info_respuesta))
                {
                   
                        MessageBox.Show("Registro guardado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;

                }
                else
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool modificarDB()
        {
            try
            {
                if (bus_respuesta.Modificar_DB(info_respuesta))
                {
                   
                        MessageBox.Show("Registro modificado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;
                   
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool anularDB()
        {
            try
            {
                if (bus_respuesta.Anular_DB(info_respuesta))
                {
                   
                    MessageBox.Show("Registro anulado exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void ucge_menu_event_delegate_btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucge_menu_event_delegate_btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucge_menu_event_delegate_btn_guardar_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (accion_grabar())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucge_menu_event_delegate_btn_limpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            limpiar();
        }
        private void ucge_menu_event_delegate_btn_salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }    
        private void cargar_combos()
        {
            try
            {
                Dictionary<int, string> impuesto = Enum.GetValues(typeof(Cl_Enumeradores.eOpcionesPreguntas))
                 .Cast<Cl_Enumeradores.eOpcionesPreguntas>().ToDictionary(x => (int)x, x => x.ToString());

                listaPreguntas = bus_preguntas.get_list_pregunta_con_detalle(param.IdEmpresa);
                cmb_preguntas.Properties.DataSource = listaPreguntas;

                lista_nomina = bus_nomina.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = lista_nomina;
                cmbnomina.EditValue = 2;
                lista_cargo = bus_cargo.ObtenerLstCargo(param.IdEmpresa);
                lista_departamento = bus_deoartamento.Get_List_Departamento(param.IdEmpresa);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmTlh_evaluacion_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void frmTlh_evaluacion_mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_accion_in_controls();
                btn_siguiente.Text = "Iniciar";
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_nueva_pregunta_Click(object sender, EventArgs e)
        {
            try
            {
                frmTlh_preguntas_mant frm = new frmTlh_preguntas_mant();
                frm.set_accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btb_agregar_preguntas_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_seleccionar.Checked)
                {
                    tlh_evaluacion_opciones_preguntas_info info_p = new tlh_evaluacion_opciones_preguntas_info();
                    info_p = (tlh_evaluacion_opciones_preguntas_info)cmb_preguntas.Properties.View.GetFocusedRow();
                    if (info_p != null)
                    {
                        if (listaPreguntas_a_evaluar.Where(v => v.IdPregunta == info_p.IdPregunta).Count() == 0)
                        {
                            info_p.eliminar = true;
                            listaPreguntas_a_evaluar.Add(info_p);
                            gridControl_variables_a_evaluar.DataSource = listaPreguntas_a_evaluar;
                        }
                    }
                }
                else
                {
                    foreach (var item in listaPreguntas)
                    {
                        if (listaPreguntas_a_evaluar.Where(v => v.IdPregunta == item.IdPregunta).Count() == 0)
                        {
                            item.eliminar = true;
                            listaPreguntas_a_evaluar.Add(item);
                        }
                    }
                    gridControl_variables_a_evaluar.DataSource = listaPreguntas_a_evaluar;

                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarEmpleados()
        {
            try
            {
                lista_empleado =new BindingList<tlh_evaluacion_opciones_preguntas_respuesta_det_info>( bus_empleados.get_list_empleado_x_nomina(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue)));
                gridControl_empleados_evaluar.DataSource=lista_empleado;

            }
            catch (Exception)
            {              
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
        private void AgregarNombre_cab_Grid()
        {

            try
            {
                int sec = 0;
                if (info_pregunta_seleccionada.detalle.Count() > 5 )
                {
                    MessageBox.Show("Las preguntas solo deben tner maximo cinco opciones, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (info_pregunta_seleccionada.detalle.Count() < 2)
                {
                    MessageBox.Show("Las preguntas deben tener minimo dos opciones, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                string[] Opciones;
                Boolean[] visibles;

                visibles = new Boolean[5];
                for (int i = 0; i < 5; i++)
                {
                    visibles[i] = false;
                }
                
                Opciones = new string[5];
                gridControl_empleados_evaluar.RefreshDataSource();
                gridControl_empleados_evaluar.Refresh();

                funcioncaptionvisiblecolumnas(Opciones, visibles);

         
                for (int i = 0; i < info_pregunta_seleccionada.detalle.Count(); i++)
                {
                    sec = i + 1;
                    string opcion = info_pregunta_seleccionada.detalle.Where(v => v.secuencia == sec).FirstOrDefault().Descripcion_opcion;
                    Opciones[i] = opcion;
                    visibles[i] = true;
                }
                funcioncaptionvisiblecolumnas(Opciones, visibles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void funcioncaptionvisiblecolumnas(string[] opciones, Boolean[] visibles)
        {
            try
            {
                Col_op1.Caption = opciones[0];
                Col_op2.Caption = opciones[1];
                Col_op3.Caption = opciones[2];
                Col_op4.Caption = opciones[3];
                Col_op5.Caption = opciones[4];


                Col_op1.Visible = visibles[0]; Col_op1.VisibleIndex = (visibles[0] == true) ? 10 : -1;
                Col_op2.Visible = visibles[1]; Col_op2.VisibleIndex = (visibles[1] == true) ? 11 : -1;
                Col_op3.Visible = visibles[2]; Col_op3.VisibleIndex = (visibles[2] == true) ? 12 : -1;
                Col_op4.Visible = visibles[3]; Col_op4.VisibleIndex = (visibles[3] == true) ? 13 : -1;
                Col_op5.Visible = visibles[4]; Col_op5.VisibleIndex = (visibles[4] == true) ? 14 : -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }
        private void cmb_preguntas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_pregunta_seleccionada = (tlh_evaluacion_opciones_preguntas_info)cmb_preguntas.Properties.View.GetFocusedRow();
                gridView_empleados_evaluar.ViewCaption = "VARIABLE A EVALUAR ES: "+info_pregunta_seleccionada.Descripcion;
                AgregarNombre_cab_Grid();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridView_empleados_evaluar_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name != "Col_pe_cedulaRuc" 
                    && e.Column.Name != "Col_apellido" 
                    && e.Column.Name!="Col_chek_e")
                {
                    tlh_evaluacion_opciones_preguntas_respuesta_det_info info = (tlh_evaluacion_opciones_preguntas_respuesta_det_info)gridView_empleados_evaluar.GetFocusedRow();

                    if (info.check1==true
                        || info.check2 == true
                        || info.check3 == true
                        || info.check4 == true
                        || info.check5 == true)
                    {
                        gridView_empleados_evaluar.SetFocusedRowCellValue(Col_chek_e, true);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridView_empleados_evaluar_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name != "Col_pe_cedulaRuc" && e.Column.Name != "Col_apellido")
                {
                    info_respuesta_det = (tlh_evaluacion_opciones_preguntas_respuesta_det_info)gridView_empleados_evaluar.GetFocusedRow();
                    foreach (var item in lista_empleado.Where(v => v.IdEmpleado == info_respuesta_det.IdEmpleado))
                    {
                        item.check1 = false;
                        item.check2 = false;
                        item.check3 = false;
                        item.check4 = false;
                        item.check5 = false;
                    }

                    gridControl_empleados_evaluar.RefreshDataSource();
                    gridControl_empleados_evaluar.Refresh();

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }      
        private void gridView_variables_a_evaluar_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == "Col_eliminar")
                {
                    if (MessageBox.Show("Se eliminara todos los registro de esta pregunta... ¿Esta seguro de eliminar la pregunta se eliminara?", "INFORMACIÓN" + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        info_pregunta_seleccionada = (tlh_evaluacion_opciones_preguntas_info)gridView_variables_a_evaluar.GetFocusedRow();
                       if( EliminarPregunta())
                        gridView_variables_a_evaluar.DeleteSelectedRows();
                    }

                }
                else
                {
                    info_pregunta_seleccionada = (tlh_evaluacion_opciones_preguntas_info)gridView_variables_a_evaluar.GetFocusedRow();
                    gridView_empleados_evaluar.ViewCaption = "VARIABLE A EVALUAR ES: " + info_pregunta_seleccionada.Descripcion;
                    AgregarNombre_cab_Grid();
                    if (info_pregunta_seleccionada.check == false)
                    {
                        foreach (var item in lista_empleado)
                        {
                            if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                            {
                                item.check1 = false;
                                item.check2 = false;
                                item.check3 = false;
                                item.check4 = false;
                                item.check5 = false;
                            }
                            else
                                break;

                        }
                    }
                    if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        ConsultarEvaluacion_x_pregunta();
                    gridControl_empleados_evaluar.RefreshDataSource();
                    gridControl_empleados_evaluar.Refresh();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridView_empleados_evaluar_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                 var data =  gridView_empleados_evaluar.GetRow(e.RowHandle) as tlh_evaluacion_opciones_preguntas_respuesta_det_info;
                if (data == null)
                    return;

                if (data.check1 == true
                    || data.check2 == true
                    || data.check3 == true
                    || data.check4 == true
                    || data.check5 == true)
                    e.Appearance.ForeColor = Color.Blue;
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if(!ba_si_inicioevaluacion)
                {
                    if (MessageBox.Show("Dara inicio a la evaluación ¿Desea continuar?", "INFORMACIÓN" + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (var item in listaPreguntas_a_evaluar)
                        {
                            item.check = false;
                        }
                        gridControl_variables_a_evaluar.RefreshDataSource();
                        gridControl_variables_a_evaluar.Refresh();
                     contador = 1;
                     ba_si_inicioevaluacion = true;
                     gridControl_variables_a_evaluar.Enabled = false;
                     cmb_preguntas.Properties.ReadOnly = true;
                     check_seleccionar.Properties.ReadOnly = true;

                     gridView_variables_a_evaluar.SetFocusedRowCellValue(Col_check, true);
                     btn_siguiente.Text = "Siguiente";
                     info_pregunta_seleccionada = (tlh_evaluacion_opciones_preguntas_info)gridView_variables_a_evaluar.GetFocusedRow();
                     gridView_empleados_evaluar.ViewCaption = "VARIABLE A EVALUAR ES: " + info_pregunta_seleccionada.Descripcion;
                     AgregarNombre_cab_Grid();
                    }
                 }
                else 
                if(ba_si_inicioevaluacion&& contador==1)
                {
                    if (!Valiar_si_estan_evaluados_todos())
                    {
                        MessageBox.Show("Existen registro sin calificar no puede continuar  revise por fvor!!");
                        return;
                    }
                    // grabar y limpiar
                    if (MessageBox.Show(" se procedara a guardar la evaluacion de la pregunta seleccionada ¿Desea continuar?", "INFORMACIÓN" + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        get_info();
                        guardarDB();
                        if(Cl_Enumeradores.eTipo_action.grabar==Accion )
                        Deseleccionar();
                        if (Cl_Enumeradores.eTipo_action.actualizar == Accion && ba_si_inicioevaluacion)
                            Deseleccionar();
                        gridView_variables_a_evaluar.MoveNext();
                        gridView_variables_a_evaluar.SetFocusedRowCellValue(Col_check, true);
                        info_pregunta_seleccionada = (tlh_evaluacion_opciones_preguntas_info)gridView_variables_a_evaluar.GetFocusedRow();
                        gridView_empleados_evaluar.ViewCaption = "VARIABLE A EVALUAR ES: " + info_pregunta_seleccionada.Descripcion;
                        AgregarNombre_cab_Grid();
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                info_pregunta_seleccionada = (tlh_evaluacion_opciones_preguntas_info)gridView_variables_a_evaluar.GetFocusedRow();
                gridView_empleados_evaluar.ViewCaption = "VARIABLE A EVALUAR ES: " + info_pregunta_seleccionada.Descripcion;
                AgregarNombre_cab_Grid();
                gridView_variables_a_evaluar.MovePrev();

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridView_variables_a_evaluar_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_empleados_evaluar.GetRow(e.RowHandle) as tlh_evaluacion_opciones_preguntas_info;
                if (data == null)
                    return;
                if (data.check == true
                    )
                    e.Appearance.ForeColor = Color.Blue;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Valiar_si_estan_evaluados_todos()
        {
            try
            {
                if (lista_empleado.Where(v => v.check == false).Count() == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void Deseleccionar()
        {
            try
            {
                foreach (var item in lista_empleado)
                {
                    item.check = false;
                    item.check1 = false;
                    item.check2 = false;
                    item.check3 = false;
                    item.check4 = false;
                    item.check5 = false;
                }

                gridControl_empleados_evaluar.RefreshDataSource();
                gridControl_empleados_evaluar.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ConsultarEvaluacion_x_pregunta()
        {
            try
            {
                lista_empleado = new BindingList<tlh_evaluacion_opciones_preguntas_respuesta_det_info>(bus_empleados.get_list_empleado_x_nomina(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue),info_respuesta.IdCalendario,info_pregunta_seleccionada.IdPregunta));
                gridControl_empleados_evaluar.DataSource = lista_empleado;
                if (lista_empleado.Count() == 0)
                    CargarEmpleados();

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gridView_empleados_evaluar_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                 if (e.Column.Name == "Col_eliminar_e")
                {
                    if (MessageBox.Show("Se eliminara el colaborador de la pregunta seleccionada... ¿Esta seguro de eliminar el registro?", "INFORMACIÓN" + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        info_respuesta_det = (tlh_evaluacion_opciones_preguntas_respuesta_det_info)gridView_empleados_evaluar.GetFocusedRow();
                        if (bus_empleados.EliminarDB_DB(info_pregunta_seleccionada.IdEmpresa, GetIdCalendario(), info_pregunta_seleccionada.IdPregunta, info_respuesta_det.IdEmpleado))
                            gridView_empleados_evaluar.DeleteSelectedRows();
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EliminarPregunta()
        {
            try
            {
                return bus_empleados.EliminarDB_DB(info_pregunta_seleccionada.IdEmpresa, GetIdCalendario(), info_pregunta_seleccionada.IdPregunta);
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private int GetIdCalendario()
        {
            try
            {
              return info_respuesta.IdCalendario =Convert.ToInt32( dtpFecha.DateTime.Year.ToString() + dtpFecha.DateTime.Month.ToString().PadLeft(2, '0') + dtpFecha.DateTime.Day.ToString().PadLeft(2, '0'));

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                XTLH_Rpt001_Rpt rpt = new XTLH_Rpt001_Rpt();
                rpt.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                rpt.Parameters["IdCalendario"].Value = GetIdCalendario();

                rpt.ShowPreview();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmTlh_evaluacion_mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmTlh_evaluacion_mant_FormClosing(sender, e);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
       

    }
}