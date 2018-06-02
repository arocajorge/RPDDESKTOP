using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraBars;
using Core.Erp.Info.Roles;
using System.IO;
using System.Diagnostics;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.Roles;
using Cus.Erp.Reports.FJ;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_ManoObra : Form
    {

        #region varibales
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<ro_ManoObra_Info> lista = new BindingList<ro_ManoObra_Info>();
        ro_ManoObra_Bus bus = new ro_ManoObra_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_perio = new Core.Erp.Info.Roles.ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        ro_Rol_Bus bus_rol = new ro_Rol_Bus();
        ro_Rol_Info inforolEventuales = new ro_Rol_Info();
        fa_pre_facturacion_Bus bus_prefacturacion = new fa_pre_facturacion_Bus();
        fa_pre_facturacion_proyeccion_mano_obra_Info info_proye = new fa_pre_facturacion_proyeccion_mano_obra_Info();

        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_Perioso_x_nominaMensual = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo_mensual_eventuales = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();


        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();



        Cl_Enumeradores.eTipo_action _Accion;

        BindingList<ro_presupuesto_x_fuerza_x_cargo_Info> listPresupuesto = new BindingList<ro_presupuesto_x_fuerza_x_cargo_Info>();
        List<ro_presupuesto_x_fuerza_x_cargo_Info> listatmp = new List<ro_presupuesto_x_fuerza_x_cargo_Info>();

        ro_presupuesto_x_fuerza_x_cargo_Bus bus_presupuesto = new ro_presupuesto_x_fuerza_x_cargo_Bus();



        List<ro_Cargo_Info> listaCargo = new List<ro_Cargo_Info>();
        ro_Cargo_Bus bus_cargo = new ro_Cargo_Bus();
        ro_Empleado_Bus bus_empleado = new ro_Empleado_Bus();

        ro_Empleado_Info InfoEmpleado = new ro_Empleado_Info();


        List<ro_fuerza_Info> listaFuerza = new List<ro_fuerza_Info>();
        ro_fuerza_Bus bus_fuerza = new ro_fuerza_Bus();



        ro_disco_Bus bus_Disco = new ro_disco_Bus();


        ro_empleado_x_cargo_fuerza_grupo_Bus bus_planificacionEventual = new ro_empleado_x_cargo_fuerza_grupo_Bus();


        fa_pre_facturacion_proyeccion_mano_obra_Bus bus_proyecionmo = new fa_pre_facturacion_proyeccion_mano_obra_Bus();
        List<fa_pre_facturacion_proyeccion_mano_obra_Info> lista_proyecion = new List<fa_pre_facturacion_proyeccion_mano_obra_Info>();



        #endregion




        public frmRo_ManoObra()
        {
            InitializeComponent();
        }

        void ucRo_Menu_event_cmdImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        
        private void frmRo_ManoObra_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
            }
               
           
            
        }

       

        private void ucRo_Menu_event_cmdCargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Generar_Excell();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucRo_Menu_event_btnsalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }






        private void Generar_Excell()
        {
            try
            {



                listPresupuesto = new BindingList<ro_presupuesto_x_fuerza_x_cargo_Info>(bus_presupuesto.GetPresupuesto(param.IdEmpresa, Convert.ToInt32(info_Perioso_x_nominaMensual.pe_FechaIni.Year), Convert.ToInt32(info_Perioso_x_nominaMensual.pe_FechaIni.Month)));
                gridControlPresupuesto.DataSource = listPresupuesto;                                 
                lista =new BindingList<ro_ManoObra_Info>( bus.Get_Mano_Obra(info_Perioso_x_nominaMensual));
                grid_control.DataSource = lista;


                // actualizando prsupuesto
                foreach (var item in listPresupuesto)
                {
                    item.costoRealMO = lista.Where(v => v.IdFuerza == item.IdFuerza && v.IdCargo == item.IdCargo).Sum(v => v.TOTAL_MO);
                    item.diferencia = Convert.ToDouble( item.costoRealMO)-item.Presupuesto;

                }

               gridViewPresupuesto.RefreshData();

               





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void grid_control_Click(object sender, EventArgs e)
        {

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

                cmb_cargo.DataSource = listaCargo;
                cmb_fuerza.DataSource = listaFuerza;
                
                cmbnomina.Properties.DataSource = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucRo_Menu_event_cmbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {      
            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.ToString());
            }
        }

        private void grid_view_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = grid_view.GetRow(e.RowHandle) as ro_ManoObra_Info;
                if (data == null)
                    return;

                if (data.fu_descripcion == "AMARILLA")
                    e.Appearance.ForeColor = Color.Orange;

                if (data.fu_descripcion == "AZUL")
                    e.Appearance.ForeColor = Color.Blue;

            }
            catch (Exception ex)
            {

               
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
              

            }
            catch (Exception ex)
            {


            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

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
                cmbPeriodos.Properties.DataSource = listadoPeriodo;
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

                splashScreenManagereEspera.ShowWaitForm();
                string msg = "";
                 info_Perioso_x_nominaMensual = ( ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
                 Generar_Excell();


                // busco Period nomina

            info_periodo_mensual_eventuales = periodo_nomina_bus.GetInfo_Periodo(param.IdEmpresa, 2, 5, info_Perioso_x_nominaMensual.IdPeriodo);
            inforolEventuales = bus_rol.GetInfoConsultaPorRol(param.IdEmpresa, 2, 5, info_Perioso_x_nominaMensual.IdPeriodo, ref msg);
            splashScreenManagereEspera.CloseWaitForm();
            }
            catch (Exception ex)
            {
                
              MessageBox.Show(ex.ToString());
              splashScreenManagereEspera.CloseWaitForm();

            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_view_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == "Col_Cargo" || e.Column.Name == "Col_fu_descripcion")
                {
                    foreach (var item in listPresupuesto)
                    {
                        item.costoRealMO = lista.Where(v => v.IdFuerza == item.IdFuerza && v.IdCargo == item.IdCargo).Sum(v => v.TOTAL_MO);
                        item.diferencia = Convert.ToDouble(item.costoRealMO) - item.Presupuesto;

                    }

                    gridControlPresupuesto.RefreshDataSource();
                }

            }
            catch (Exception ex)
            {
                
             MessageBox.Show(ex.ToString());

            }
        }

        private void grid_view_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                  var item = (ro_ManoObra_Info) grid_view.GetRow(e.FocusedRowHandle);

                  if (item.zo_descripcion != "Eventuales")
                  {
                      Col_Cargo.OptionsColumn.AllowEdit = false;
                      Col_fu_descripcion.OptionsColumn.AllowEdit = false;
                      Col_check.OptionsColumn.AllowEdit = false;

                  }
                  else
                  {
                      Col_Cargo.OptionsColumn.AllowEdit = true;
                      Col_check.OptionsColumn.AllowEdit = true;
                      Col_fu_descripcion.OptionsColumn.AllowEdit = true;
                  }
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void cmb_procesarSeleccionados_Click(object sender, EventArgs e)
        {
            Procesar();

        }


        private void Procesar()
        {
            cmbnomina.Focus();
            splashScreenManagereEspera.ShowWaitForm();
            try{
            

                cmbnomina.Focus();
               string msg="";
                bus_rol = new ro_Rol_Bus(inforolEventuales, info_periodo_mensual_eventuales);
                foreach (var item in lista.Where(v=>v.check==true))
                {
                    // Actualizando planificacion de ventuales
                    ro_empleado_x_cargo_fuerza_grupo_Info info_ev = new ro_empleado_x_cargo_fuerza_grupo_Info();
                    info_ev.IdEmpresa = param.IdEmpresa;
                    info_ev.IdNomina = 2;
                    info_ev.IdEmpleado = item.idempleado;
                    info_ev.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    info_ev.IdCargo =Convert.ToInt32( item.IdCargo);
                    if (item.IdCargo == 41)
                        info_ev.IdGrupo = 5;
                    else
                        info_ev.IdGrupo = 2;
                    if(item.IdFuerza!=null)
                    info_ev.IdFuerza =Convert.ToInt32( item.IdFuerza);
                    bus_planificacionEventual.GrabarBD(info_ev, ref msg);


                    // Proesando la nomina
                    InfoEmpleado=   bus_empleado.Get_List_Empleado_x_Nomina_Liquidar_Eventuales_Ajuste_MO_Cliente(param.IdEmpresa, info_ev.IdNomina, info_ev.IdPeriodo, info_periodo_mensual_eventuales.pe_FechaIni, info_periodo_mensual_eventuales.pe_FechaFin,Convert.ToInt32( info_ev.IdEmpleado));

                   bus_rol.pu_ProcesarRol(InfoEmpleado);


                }

                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente),param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Generar_Excell();

                splashScreenManagereEspera.CloseWaitForm();
                     
            }
            catch (Exception ex)
            {
                
             MessageBox.Show(ex.ToString());
             splashScreenManagereEspera.CloseWaitForm();

            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                 OpenFileDialog ofdDoc;//txt
                SaveFileDialog sfdDoc;//txt
                ofdDoc = new OpenFileDialog();
                sfdDoc = new SaveFileDialog();
                string Nombrefile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (sfdDoc.ShowDialog() == DialogResult.OK)
                {

                    if (File.Exists(sfdDoc.FileName))
                    {
                        File.Delete(sfdDoc.FileName);
                    }
                    sfdDoc.FileName = sfdDoc.FileName + ".csv";
                    grid_view.ExportToCsv(sfdDoc.FileName);
                    


                    if (MessageBox.Show("Desea ver el Archivo...?", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Process.Start(sfdDoc.FileName);
                }

            }
            catch (Exception ex)
            {
                
            MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                bool ba_sigrabo = false;
                Get();

              ba_sigrabo = bus_proyecionmo.GuardarDB(lista_proyecion);
             
                   if (ba_sigrabo)
                   MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                   MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }



        private void Get()
        {
            try
            {
                decimal idpref = 0;
                lista_proyecion = new List<fa_pre_facturacion_proyeccion_mano_obra_Info>();
                // si existe prefacturacionPeriodo
                fa_pre_facturacion_Info info_pref=new fa_pre_facturacion_Info();
                info_pref=  bus_prefacturacion.Get_Info_x_periodo(param.IdEmpresa, info_Perioso_x_nominaMensual.IdPeriodo);

                if (info_pref.IdPeriodo == 0)
                {
                    info_pref.IdEmpresa = param.IdEmpresa;
                    info_pref.IdPeriodo = info_Perioso_x_nominaMensual.IdPeriodo;
                    info_pref.Observacion = "Prefacturacion del periodo "+info_pref.IdPeriodo;
                    info_pref.estado_cierre = false;
                    info_pref.fecha = info_Perioso_x_nominaMensual.pe_FechaFin;
                    info_pref.estado = "A";
                    info_pref.IdCentroCosto = "001";
                   
                    bus_prefacturacion.GuardarDB(info_pref);
                    info_pref.IdPreFacturacion = idpref;
                }


                //foreach (var item in lista)
                //{
                //    if (item.idempleado > 1)
                //    {
                //        fa_pre_facturacion_det_gasto_mano_obra_Info info = new fa_pre_facturacion_det_gasto_mano_obra_Info();
                //        info.Idempresa = param.IdEmpresa;
                //        if (item.IdNomina_Tipo!=null)
                //        info.IdNomina_Tipo =Convert.ToInt32( item.IdNomina_Tipo);
                //        info.IdPreFacturacion = info_pref.IdPreFacturacion;
                //        info.IdPeriodo = info_Perioso_x_nominaMensual.IdPeriodo;
                //        info.IdCentro_costo = item.IdCentroCosto;
                //        info.IdSubCentroCosoto = item.IdCentroCosto_sub_centro_costo;
                //        info.Valor_mnoObra = item.TOTAL_MO;
                //        info.Valor_mnoObra_mas_comision = item.TOTAL_MO;
                //        info.IdEmpleado = item.idempleado;
                //        info.IdPreFacturacion = info_pref.IdPreFacturacion;
                //        listaPrefacturacion.Add(info);
                //    }
                //}


                foreach (var item in listPresupuesto)
                {
                    info_proye = new fa_pre_facturacion_proyeccion_mano_obra_Info();
                    info_proye.IdEmpresa = param.IdEmpresa;
                    info_proye.IdCargo = item.IdCargo;
                    info_proye.IdPeriodo = info_Perioso_x_nominaMensual.IdPeriodo;
                    info_proye.IdPrefacturacion =Convert.ToInt32( info_pref.IdPreFacturacion);
                    info_proye.IdCentroCosto = item.IdCentroCosto;
                    info_proye.IdSubcentroCosto = item.IdSuccentroCosto;
                    info_proye.ValorModificadoManoObra = item.costoRealMO;
                    info_proye.ValorRealManoObra = item.costoRealMO;
                    lista_proyecion.Add(info_proye);
                }


                ro_ManoObra_Info info_mano_obra_adm ;

                info_mano_obra_adm = lista.Where(v => v.fu_descripcion == "AMARILLA" && v.Cargo != "APP" && v.Cargo != "VPP").FirstOrDefault();

                if (info_mano_obra_adm!=null)
                {
                    info_proye = new fa_pre_facturacion_proyeccion_mano_obra_Info();
                    double Tota_FuerzaAmaAdm = lista.Where(v => v.fu_descripcion == "AMARILLA" && v.Cargo != "APP" && v.Cargo != "VPP").Sum(v => v.TOTAL_MO);

                    info_proye.IdEmpresa = param.IdEmpresa;
                    info_proye.IdCargo = 34;
                    info_proye.IdPeriodo = info_Perioso_x_nominaMensual.IdPeriodo;
                    info_proye.IdPrefacturacion = Convert.ToInt32(info_pref.IdPreFacturacion);
                    info_proye.IdCentroCosto = info_mano_obra_adm.IdCentroCosto;
                    info_proye.IdSubcentroCosto = info_mano_obra_adm.IdCentroCosto_sub_centro_costo;
                    info_proye.ValorModificadoManoObra = Tota_FuerzaAmaAdm;
                    info_proye.ValorRealManoObra = Tota_FuerzaAmaAdm;
                    lista_proyecion.Add(info_proye);
                }

                info_mano_obra_adm = null;
                info_mano_obra_adm = lista.Where(v => v.fu_descripcion == "AZUL" && v.Cargo != "APP" && v.Cargo != "VPP").FirstOrDefault();
                if (info_mano_obra_adm != null)
                {
                    info_proye = new fa_pre_facturacion_proyeccion_mano_obra_Info();
                    double Tota_FuerzaAzulAdm = lista.Where(v => v.fu_descripcion == "AZUL" && v.Cargo != "APP" && v.Cargo != "VPP").Sum(v => v.TOTAL_MO);
                    info_proye.IdEmpresa = param.IdEmpresa;
                    info_proye.IdCargo = 34;
                    info_proye.IdPeriodo = info_Perioso_x_nominaMensual.IdPeriodo;
                    info_proye.IdPrefacturacion = Convert.ToInt32(info_pref.IdPreFacturacion);
                    info_proye.IdCentroCosto = info_mano_obra_adm.IdCentroCosto;
                    info_proye.IdSubcentroCosto = info_mano_obra_adm.IdCentroCosto_sub_centro_costo;
                    info_proye.ValorModificadoManoObra = Tota_FuerzaAzulAdm;
                    info_proye.ValorRealManoObra = Tota_FuerzaAzulAdm;
                    lista_proyecion.Add(info_proye);
                }


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_presupuesto_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbPeriodos.EditValue == null)
                {
                    MessageBox.Show("Seleccione un periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }

                frmRo_presupuesto_x_fuerza_cargo frm = new frmRo_presupuesto_x_fuerza_cargo();
                frm.set(Convert.ToInt32(cmbPeriodos.EditValue), Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                frm.ShowDialog();
                Generar_Excell();
             
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
