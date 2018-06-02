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
    public partial class frmRo_Planificacion_x_Ruta_entrega_Mant : Form
    {
        public frmRo_Planificacion_x_Ruta_entrega_Mant()
        {
            InitializeComponent();
            cargar_dato();
        }

        #region variable
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        List<ro_Empleado_Info> listaempleado=new List<ro_Empleado_Info>();
        ro_Empleado_Bus bus_empleado=new ro_Empleado_Bus();
        List<ro_placa_Info> lista_placa = new List<ro_placa_Info>();
        List<ro_fuerza_Info> lista_fuerza = new List<ro_fuerza_Info>();
        List<ro_disco_Info> lista_disco = new List<ro_disco_Info>();
        List<ro_zona_Info> lista_zona = new List<ro_zona_Info>();
        List<ro_ruta_Info> lista_ruta = new List<ro_ruta_Info>();

         ro_placa_Bus bus_placa = new ro_placa_Bus();
        ro_fuerza_Bus bus_fuerza = new ro_fuerza_Bus();
        ro_disco_Bus bus_disco = new ro_disco_Bus();
        ro_zona_Bus bus_zona = new ro_zona_Bus();
        ro_ruta_Bus bus_ruta = new ro_ruta_Bus();




        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();




        ro_planificacion_x_ruta_x_empleado_Info info_planificacion = new ro_planificacion_x_ruta_x_empleado_Info();
        ro_planificacion_x_ruta_x_empleado_Bus bus_planificacion = new ro_planificacion_x_ruta_x_empleado_Bus();
        BindingList<ro_planificacion_x_ruta_x_empleado_det_Info> lista_planificada = new BindingList<ro_planificacion_x_ruta_x_empleado_det_Info>();
        BindingList<ro_planificacion_x_ruta_x_empleado_det_Info> lista_planificada_error = new BindingList<ro_planificacion_x_ruta_x_empleado_det_Info>();

        ro_planificacion_x_ruta_x_empleado_det_Bus bus_planificacion_detalle = new ro_planificacion_x_ruta_x_empleado_det_Bus();
        #endregion
        private void frmRo_Planificacion_x_Ruta_entrega_Mant_Load(object sender, EventArgs e)
        {
            try
            {
            gridControl_planificacion.DataSource = lista_planificada;
            listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
            cmbnomina.Properties.DataSource = listadoNomina;

            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    cmbnomina.Enabled = false;
                    cmbnominaTipo.Enabled = false;
                    cmbPeriodos.Enabled = false;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
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


        public void cargar_dato()
        {
            try
            {
            cmb_disco.ValueMember = "IdDisco";
            cmb_disco.DisplayMember = "Disco";

            cmb_fuerza.ValueMember = "IdFuerza";
            cmb_fuerza.DisplayMember = "fu_descripcion";

            cmb_placa.ValueMember = "IdPlaca";
            cmb_placa.DisplayMember = "Placa";

            cmb_ruta.ValueMember = "IdRuta";
            cmb_ruta.DisplayMember = "ru_descripcion";

            cmb_zona.ValueMember = "IdZona";
            cmb_zona.DisplayMember = "zo_descripcion";
// lista de disco
            lista_disco = bus_disco.Get_List_Disco(param.IdEmpresa);           
            cmb_disco.DataSource = lista_disco;


// lista de fuerza
            lista_fuerza = bus_fuerza.Get_List_Fuerza(param.IdEmpresa);          
            cmb_fuerza.DataSource = lista_fuerza;
// lista de placa
            lista_placa = bus_placa.Get_List_Placa(param.IdEmpresa);           
            cmb_placa.DataSource = lista_placa;            
// lista de rutas 
            lista_ruta = bus_ruta.Get_List_Ruta(param.IdEmpresa);           
            cmb_ruta.DataSource = lista_ruta;

// lista de zonas
            lista_zona = bus_zona.Get_List_Zona(param.IdEmpresa);            
            cmb_zona.DataSource = lista_zona;

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




                listaempleado=bus_empleado.Get_List_Empleado_x_Empresa(param.IdEmpresa);
                cmb_empleado.ValueMember="IdEmpleado";
                cmb_empleado.DisplayMember = "NomCompleto";
                cmb_empleado.DataSource = listaempleado;

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

               // lista_planificada = new BindingList<ro_planificacion_x_ruta_x_empleado_det_Info>(bus_planificacion_detalle.get_lista_planificacion(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue),Convert.ToInt32( cmbPeriodos.EditValue)));
              //  gridControl_planificacion.DataSource = lista_planificada;
           

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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                if (Grabar())
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
                if(Validar())
                Grabar();
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
                info_planificacion = new ro_planificacion_x_ruta_x_empleado_Info();
                info_planificacion.lista = new List<ro_planificacion_x_ruta_x_empleado_det_Info>();
                info_planificacion.IdEmpresa = param.IdEmpresa;
                info_planificacion.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                info_planificacion.IdNomina_tipo_Liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                info_planificacion.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                info_planificacion.Observacion = txtobservacion.Text;
                info_planificacion.IdUsuario = param.IdUsuario;
                info_planificacion.Fecha_Transaccion = DateTime.Now;
                info_planificacion.IdUsuarioUltModi = param.IdUsuario;
                info_planificacion.Fecha_UltMod = DateTime.Now;

                foreach (var item in lista_planificada)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    item.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                    item.IdNomina_Tipo_Liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                }

                info_planificacion.lista = lista_planificada.ToList();
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
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " nomina",param.Nombre_sistema,  MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (lista_planificada_error.Count() > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Existen empleados que no coinciden la cedula?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                      
                    }
                    else
                    {
                        return false;
                    }
                }


                if (bus_planificacion.Guardar_DB(info_planificacion))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public void Set(ro_planificacion_x_ruta_x_empleado_Info info)
        {
            try
            {
                txtobservacion.Text = info.Observacion;
                cmbnomina.EditValue = info.IdNomina_Tipo;
                cmbnominaTipo.EditValue = info.IdNomina_tipo_Liq;
                cmbPeriodos.EditValue = info.IdPeriodo;

                lista_planificada = new BindingList<ro_planificacion_x_ruta_x_empleado_det_Info>( bus_planificacion_detalle.lista_planificacion(param.IdEmpresa, info.IdNomina_Tipo, info.IdPeriodo));
                gridControl_planificacion.DataSource = lista_planificada;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void cmb_fuerza_EditValueChanged(object sender, EventArgs e)
        {
           
                try
                {

                    if (cmb_fuerza.ValueMember == "0")
                    {
                        frmRo_fuerza_mant frm = new frmRo_fuerza_mant();
                        frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                        frm.ShowDialog();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
        }

        private void nuevaFuerzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_fuerza_mant frm = new frmRo_fuerza_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_fuerza = bus_fuerza.Get_List_Fuerza(param.IdEmpresa);
                cmb_fuerza.DataSource = lista_fuerza;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void nuevaZonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_zona_mant frm = new frmRo_zona_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_zona = bus_zona.Get_List_Zona(param.IdEmpresa);
                cmb_zona.DataSource = lista_zona;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void nuevoDiscoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_disco_mant frm = new frmRo_disco_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_disco = bus_disco.Get_List_Disco(param.IdEmpresa);
                cmb_disco.DataSource = lista_disco;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void nuevaPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_placa_mant frm = new frmRo_placa_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_placa = bus_placa.Get_List_Placa(param.IdEmpresa);
                cmb_placa.DataSource = lista_placa;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                        ro_planificacion_x_ruta_x_empleado_det_Info info = (ro_planificacion_x_ruta_x_empleado_det_Info)gridView_planificacion.GetFocusedRow();
                        if (info!=null)
                        if( bus_planificacion_detalle.EliminarDB(info))
                        gridView_planificacion.DeleteSelectedRows();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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


                    string cedula = Convert.ToString(rowData[0]);
                    string Nombres = Convert.ToString(rowData[1]);
                    string Fuerza = Convert.ToString(rowData[2]);
                    string Zona = Convert.ToString(rowData[3]);
                    string Disco = Convert.ToString(rowData[4]);
                    string Placa = Convert.ToString(rowData[5]);
                    string Ruta = Convert.ToString(rowData[6]);

                         ro_fectividad_Entrega_x_Periodo_Empleado_Info emp = new ro_fectividad_Entrega_x_Periodo_Empleado_Info();
                    if (!string.IsNullOrWhiteSpace(cedula.ToString()))
                    {
                        if (fx_Verificar_Reg_Repetidos(emp, false, 0))
                        {


                            bool si_existe_cedula = false;
                            foreach (var item in listaempleado)
                            {
                                ro_planificacion_x_ruta_x_empleado_det_Info info = new ro_planificacion_x_ruta_x_empleado_det_Info();

                                if (item.InfoPersona.pe_cedulaRuc == cedula)
                                {
                                    si_existe_cedula = true;
                                    info.IdEmpresa = param.IdEmpresa;
                                    info.IdEmpleado = item.IdEmpleado;

                                    // FUERZA
                                    List<ro_fuerza_Info> fuerzatmp = new List<ro_fuerza_Info>();
                                    fuerzatmp = lista_fuerza.Where(v => v.fu_descripcion == Fuerza).ToList();
                                    if (fuerzatmp.Count() > 0)
                                    {
                                        info.IdFuerza = fuerzatmp.FirstOrDefault().IdFuerza;
                                    }



                                    // ZONA
                                    List<ro_zona_Info> zonatmp = new List<ro_zona_Info>();
                                    zonatmp = lista_zona.Where(v => v.zo_descripcion == Zona).ToList();
                                    if (zonatmp.Count() > 0)
                                    {
                                        info.IdZona = zonatmp.FirstOrDefault().IdZona;
                                    }



                                    // DISO
                                    List<ro_disco_Info> discotmp = new List<ro_disco_Info>();
                                    discotmp = lista_disco.Where(v => v.Disco == Disco).ToList();
                                    if (discotmp.Count() > 0)
                                    {
                                        info.IdDisco = discotmp.FirstOrDefault().IdDisco;
                                    }



                                    // PLACA
                                    List<ro_placa_Info> placatmp = new List<ro_placa_Info>();
                                    placatmp = lista_placa.Where(v => v.Placa == Placa).ToList();
                                    if (placatmp.Count() > 0)
                                    {
                                        info.IdPlaca = placatmp.FirstOrDefault().IdPlaca;
                                    }



                                    // RUTA
                                    List<ro_ruta_Info> rutatmp = new List<ro_ruta_Info>();
                                    rutatmp = lista_ruta.Where(v => v.ru_descripcion == Ruta).ToList();
                                    if (rutatmp.Count() > 0)
                                    {
                                        info.IdRuta = rutatmp.FirstOrDefault().IdRuta;
                                    }




                                    lista_planificada.Add(info);
                                }
                               

                               
                               
                            }

                            if (!si_existe_cedula)
                            {
                                ro_planificacion_x_ruta_x_empleado_det_Info info = new ro_planificacion_x_ruta_x_empleado_det_Info();
                                info.pe_nombreCompleto = Nombres;
                                info.cedula = cedula;
                                lista_planificada_error.Add(info);
                                gridControl_error.DataSource = lista_planificada_error;
                            }

                            return true;
                        }
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

        private void gridView_planificacion_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                 var data = gridView_planificacion.GetRow(e.RowHandle) as ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info;
                if (data == null)
                    return;
                if (data.Error == null || data.Error =="")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_planificacion_KeyDown_1(object sender, KeyEventArgs e)
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
   


    }
}
