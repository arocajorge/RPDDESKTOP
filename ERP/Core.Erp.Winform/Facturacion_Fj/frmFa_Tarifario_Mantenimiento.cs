
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Winform.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.ActivoFijo_FJ;
using Core.Erp.Info.ActivoFijo_FJ;
namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_Tarifario_Mantenimiento : Form
    {
        #region variables

        // infos
        BindingList<fa_tarifario_facturacion_x_cliente_det_Info> Lista = new BindingList<fa_tarifario_facturacion_x_cliente_det_Info>();
        List<fa_tarifario_facturacion_x_cliente_det_Info> Lista_grabar = new List<fa_tarifario_facturacion_x_cliente_det_Info>();
        List<Af_Activo_fijo_Categoria_Info> Lista_Categoria = new List<Af_Activo_fijo_Categoria_Info>();
        Af_Activo_fijo_Categoria_Bus bus_Categoria = new Af_Activo_fijo_Categoria_Bus();
        fa_tarifario_facturacion_x_cliente_Info info_Tarifario = new fa_tarifario_facturacion_x_cliente_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        fa_tarifario_facturacion_x_cliente_Por_comision_Info porcenhaje_comision_info = new fa_tarifario_facturacion_x_cliente_Por_comision_Info();
        // bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_tarifario_facturacion_x_cliente_Bus tarifario_bus = new fa_tarifario_facturacion_x_cliente_Bus();
        fa_tarifario_facturacion_x_cliente_det_Bus tarifario_detalle_bus = new fa_tarifario_facturacion_x_cliente_det_Bus();
        fa_tarifario_facturacion_x_cliente_Por_comision_Bus porcenta_comision_bus = new fa_tarifario_facturacion_x_cliente_Por_comision_Bus();

        Af_Activo_fijo_Bus bus_Activos = new Af_Activo_fijo_Bus();
        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Bus bus_A_x_F = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Bus();
        BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> list_Det_x_ActivoFijo = new BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info>();
        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info info_det_x_Af = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info();
        ct_punto_cargo_Info info_Punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus bus_Punto_cargo = new ct_punto_cargo_Bus();

        Af_Activo_fijo_x_ct_punto_cargo_Info info_af_x_pc = new Af_Activo_fijo_x_ct_punto_cargo_Info();
        Af_Activo_fijo_x_ct_punto_cargo_Bus bus_af_x_pc = new Af_Activo_fijo_x_ct_punto_cargo_Bus();

        Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info info_af_x_cc = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info();
        Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Bus bus_af_x_cc = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Bus();

        Af_CambioUbicacion_Activo_Info info_Cambio_ubicacion = new Af_CambioUbicacion_Activo_Info();
        Af_CambioUbicacion_Activo_Bus bus_Cambio_ubicacion = new Af_CambioUbicacion_Activo_Bus();

        BindingList<fa_tarifario_facturacion_x_cliente_Por_comision_Info> list_porcentaje_comision = new BindingList<fa_tarifario_facturacion_x_cliente_Por_comision_Info>();
        BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info> lista_parametro_x_a_depreciar = new BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info>();
        List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info> lista_tabla_depreciacion_x_mes_activo = new List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info>();
        List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info> lista_tabla_depreciacion_x_mes = new List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info>();
        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Bus Parametros_depreciacion_bus = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Bus();
        fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Bus Depreciacion_Detalle_Bus = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Bus();
        fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Bus Depreciacion_Bus = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> lst_subcentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus bus_subcentro = new ct_centro_costo_sub_centro_costo_Bus();
        bool bolResult = false;
        string MensajeError = "";

        int Anios_Inicio = 0;
        int Anios_Fin = 0;
        int Anio_Servicios = 0;
        DateTime fecha_inicio, fecha_fin;
        int Meses_a_Depreciar = 0;
        int idDepreciacion = 0;
        double Depreciacion_Acumulada = 0;
        int meses = 0;
        #endregion

        #region Delegados
        public delegate void delegate_frmFa_Tarifario_Mantenimiento_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmFa_Tarifario_Mantenimiento_FormClosed event_delegate_frmFa_Tarifario_Mantenimiento_FormClosed;
        #endregion

        public frmFa_Tarifario_Mantenimiento()
        {
            InitializeComponent();
            event_delegate_frmFa_Tarifario_Mantenimiento_FormClosed += frmFa_Tarifario_Mantenimiento_event_delegate_frmFa_Tarifario_Mantenimiento_FormClosed;
        }        

        void frmFa_Tarifario_Mantenimiento_event_delegate_frmFa_Tarifario_Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Tarifario()
        {
            try
            {
                info_Tarifario.lst_det = tarifario_detalle_bus.Get_List_Tarifarios(info_Tarifario.IdEmpresa, info_Tarifario.IdTarifario);
                info_Tarifario.lst_Act_x_tarifario = bus_A_x_F.Get_List_Activo_x_tarifario(info_Tarifario.IdEmpresa, info_Tarifario.IdTarifario);
                Lista = new BindingList<fa_tarifario_facturacion_x_cliente_det_Info>(info_Tarifario.lst_det);
                cargar_Grid_Activos_x_Categoria();
                txtid.Text = info_Tarifario.IdTarifario.ToString();
                txtcodigo.Text = info_Tarifario.codTarifario;
                txtnombre.Text = info_Tarifario.nom_tarifario;
                txtobservacion.Text = info_Tarifario.observacion;
                txt_movilizacion.Text = info_Tarifario.valor_minimo_movilizacion.ToString();
                txt_porcentaje_ganancia.Text = info_Tarifario.por_ganancia_inicial.ToString();
                cmb_centro_costo.EditValue = info_Tarifario.IdCentroCosto;
                deFechaInicio.EditValue = info_Tarifario.fecha_inicio;
                deFechaFin.EditValue = info_Tarifario.fecha_fin;
                gridControlDetalle.DataSource = Lista;
                gridControlActivos.DataSource = list_Det_x_ActivoFijo;

                list_porcentaje_comision =new BindingList<fa_tarifario_facturacion_x_cliente_Por_comision_Info>( porcenta_comision_bus.Get_List_Tarifarios_Porcentaje_Ganancia(info_Tarifario.IdEmpresa,Convert.ToInt32( info_Tarifario.IdTarifario)));
                if (list_porcentaje_comision.Count() > 0)
                {
                    txt_porcentaje_ganancia.Text =Convert.ToString( list_porcentaje_comision.Select(v => v.porcentaje).Max());
                }
                gridControl_Margenes_Ganancia.DataSource = list_porcentaje_comision;

                // setea las grid de depreciacion
                lista_parametro_x_a_depreciar=new BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info>( Parametros_depreciacion_bus.Get_List_Param_depreciacion_AF(info_Tarifario.IdEmpresa, info_Tarifario.IdTarifario));
               lista_tabla_depreciacion_x_mes_activo= Depreciacion_Detalle_Bus.Get_List_tabla_depreciacion_x_activo(info_Tarifario.IdEmpresa, info_Tarifario.IdTarifario);

                gridControl_activos_depreciar.DataSource = lista_parametro_x_a_depreciar;
                gridControl_tabla_Depreciacion.DataSource = lista_tabla_depreciacion_x_mes_activo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Get_Tarifario()
        {
            try
            {
                info_Tarifario.IdEmpresa = param.IdEmpresa;
                info_Tarifario.IdTarifario = txtid.Text == "" ? 0 : Convert.ToDecimal(txtid.Text);
                info_Tarifario.codTarifario = txtcodigo.Text;
                info_Tarifario.fecha_inicio = Convert.ToDateTime(deFechaInicio.EditValue);
                info_Tarifario.fecha_fin = Convert.ToDateTime(deFechaFin.EditValue);
                info_Tarifario.observacion = txtobservacion.Text;
                info_Tarifario.nom_tarifario = txtnombre.Text;
                info_Tarifario.IdCentroCosto = cmb_centro_costo.EditValue.ToString();
                info_Tarifario.valor_minimo_movilizacion = Convert.ToDouble(txt_movilizacion.Text);
                info_Tarifario.por_ganancia_inicial = Convert.ToDouble(txt_porcentaje_ganancia.Text);

                info_Tarifario.lst_det = new List<fa_tarifario_facturacion_x_cliente_det_Info>(Lista);
                
                info_Tarifario.lst_Act_x_tarifario = new List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info>(list_Det_x_ActivoFijo.Where(q=>q.Seleccionado==true).ToList());
                foreach (var item in info_Tarifario.lst_Act_x_tarifario)
                {
                    item.IdCentroCosto = cmb_centro_costo.EditValue.ToString();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info(fa_tarifario_facturacion_x_cliente_Info _info)
        {
            try
            {
                info_Tarifario = _info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private bool Grabar()
        {
            try
            {
                bool res = false;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        res = Anular();
                        break;
                    default:
                        break;
                }
                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                Get_Tarifario();
                bolResult = tarifario_bus.Guardar(info_Tarifario);
                if (bolResult)
                {
                    foreach (var item in info_Tarifario.lst_det)
                    {
                        item.IdEmpresa = param.IdEmpresa;
                        item.IdTarifario = info_Tarifario.IdTarifario;
                    }
                    bolResult = tarifario_detalle_bus.Guardar(info_Tarifario.lst_det);
                    if (info_Tarifario.lst_Act_x_tarifario.Count > 0)
                    {
                        foreach (var A in info_Tarifario.lst_Act_x_tarifario)
                        {
                            A.IdEmpresa = param.IdEmpresa;
                            A.IdTarifario = info_Tarifario.IdTarifario;
                        }
                        bolResult = bus_A_x_F.GuardarDB(info_Tarifario.lst_Act_x_tarifario);
                        //bolResult = ReUbicar_Activos();
                        if (bolResult == true)
                        {
                            foreach (var item in list_porcentaje_comision)
                            {
                                item.IdEmpresa = info_Tarifario.IdEmpresa;
                                item.IdTarifario = info_Tarifario.IdTarifario;
                            }
                            bolResult = porcenta_comision_bus.Guardar(list_porcentaje_comision.ToList());
                        }


                        //  guardar datos de depreciacion
                        foreach (var item in lista_parametro_x_a_depreciar)
                        {
                            item.IdEmpresa = info_Tarifario.IdEmpresa;
                            item.IdTarifario = info_Tarifario.IdTarifario;
                        }
                        // guarda los parametros
                        if (bolResult = Parametros_depreciacion_bus.Guardar(lista_parametro_x_a_depreciar.ToList()))
                        {
                            foreach (var item in lista_tabla_depreciacion_x_mes)
                            {
                                item.IdEmpresa = info_Tarifario.IdEmpresa;
                                item.IdTarifario = info_Tarifario.IdTarifario;
                                if (Depreciacion_Bus.Guardar(item, ref idDepreciacion))
                                {
                                    foreach (var item_detalle in item.list_depreciacion_mes_x_activo)
                                    {
                                        item_detalle.IdEmpresa = param.IdEmpresa;
                                        item_detalle.IdDepreciacion = idDepreciacion;
                                        item_detalle.IdTarifario = item.IdTarifario;
                                    }

                                    bolResult = Depreciacion_Detalle_Bus.Guardar(item.list_depreciacion_mes_x_activo);
                                }
                            }
                        }
                    }
                    if (bolResult)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool Actualizar()
        {
            try
            {
                Generar_tabla_depreciacion();

                Get_Tarifario();
                string MensajeError = "";
                if (!bus_A_x_F.Validar_Activos_x_tarifario(param.IdEmpresa, info_Tarifario.lst_Act_x_tarifario, ref MensajeError))
                {
                    MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                bolResult = true;
                bolResult = tarifario_bus.Modificar(info_Tarifario);

                bolResult = tarifario_detalle_bus.Eliminar(info_Tarifario);

                foreach (var item in info_Tarifario.lst_det)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdTarifario = info_Tarifario.IdTarifario;
                }
                bolResult = tarifario_detalle_bus.Guardar(info_Tarifario.lst_det);

                foreach (var item in info_Tarifario.lst_Act_x_tarifario)
                {
                    item.IdEmpresa = info_Tarifario.IdEmpresa;
                    item.IdTarifario = info_Tarifario.IdTarifario;
                }
                bolResult = bus_A_x_F.EliminarDB(param.IdEmpresa, info_Tarifario.IdTarifario);

                if (info_Tarifario.lst_Act_x_tarifario.Count > 0)
                {                    
                    bolResult = bus_A_x_F.GuardarDB(info_Tarifario.lst_Act_x_tarifario);
                   // bolResult = ReUbicar_Activos();


                    foreach (var item in list_porcentaje_comision)
                    {
                        item.IdTarifario = info_Tarifario.IdTarifario;
                    }
                    if (porcenta_comision_bus.Eliminar(info_Tarifario.IdEmpresa, Convert.ToInt32(info_Tarifario.IdTarifario)))
                    {
                        bolResult = porcenta_comision_bus.Guardar(list_porcentaje_comision.ToList());
                    }


                    // elimino las datos de las tablas de depreciacion

                    if(Parametros_depreciacion_bus.Eliminar(info_Tarifario.IdEmpresa,Convert.ToInt32( info_Tarifario.IdTarifario)))
                    {


                    //  guardar datos de depreciacion
                    foreach (var item in lista_parametro_x_a_depreciar)
                    {
                        item.IdTarifario = info_Tarifario.IdTarifario;
                    }
                    // guarda los parametros
                    if (bolResult = Parametros_depreciacion_bus.Guardar(lista_parametro_x_a_depreciar.ToList()))
                    {
                        foreach (var item in lista_tabla_depreciacion_x_mes)
                        {
                            item.IdTarifario = info_Tarifario.IdTarifario;
                            if (Depreciacion_Bus.Guardar(item, ref idDepreciacion))
                            {
                                foreach (var item_detalle in item.list_depreciacion_mes_x_activo)
                                {
                                    item_detalle.IdDepreciacion = idDepreciacion;
                                    item_detalle.IdTarifario = item.IdTarifario;
                                }

                                bolResult = Depreciacion_Detalle_Bus.Guardar(item.list_depreciacion_mes_x_activo);
                            }
                        }

                    }


                    }




                }
                if (bolResult)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool Anular()
        {
            try
            {
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    oFrm.ShowDialog();
                    info_Tarifario.MotiAnula = oFrm.motivoAnulacion;
                    if (tarifario_bus.Anular(info_Tarifario))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ucGe_Menu.Visible_bntAnular = false;
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void Cargar_Combos()
        {
            try
            {
                Lista_Categoria = bus_Categoria.Get_List_Activo_fijo_Categoria(param.IdEmpresa, ref MensajeError);
                cmb_categoria_af.DataSource = Lista_Categoria;
                cmb_categoria_af.DisplayMember = "Descripcion";
                cmb_categoria_af.ValueMember = "IdCategoriaAF";

                gridControlActivos.DataSource = list_Det_x_ActivoFijo;
                gridControlDetalle.DataSource = Lista;

                List<ct_Centro_costo_Info> lst_centro_costo = new List<ct_Centro_costo_Info>();
                ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();
                lst_centro_costo = bus_centro_costo.Get_list_Centro_Costo_x_cliente(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo.Properties.DataSource = lst_centro_costo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmFa_Tarifario_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
                Set_Controles();
                gridControl_Margenes_Ganancia.DataSource = list_porcentaje_comision;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                    if (Grabar())
                        Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if (Grabar())
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private bool validar()
        {
            try
            {
                txtid.Focus();
                txtcodigo.Focus();

                if (cmb_centro_costo.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Debe_escojer) + " un centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (deFechaInicio.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Debe_escojer) + " una fecha de inicio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (deFechaFin.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Debe_escojer) + " una fecha de fin", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (Lista.Count==0)
                {
                    MessageBox.Show("Debe ingresar al menos una categoría", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in Lista)
                {   
                    if (item.IdCategoriaAF == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Debe_escojer) + " una categoría.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (item.cantidad==0)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " cantidad de equipos para este tarifario.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }                    
                }

                if (!ValidarSeleccion()) return false;

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void Set_Controles()
        {
            try
            {
                deFechaInicio.EditValue = DateTime.Now;
                deFechaFin.EditValue = DateTime.Now.AddYears(3);
                check_factura_Valor_Salvamento.Checked = true;
                check_iva.Checked = true;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;                        
                        ucGe_Menu.Visible_bntLimpiar = true;
                        cmb_centro_costo.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;                        
                        ucGe_Menu.Visible_bntLimpiar = true;
                        cmb_centro_costo.Properties.ReadOnly = true;
                        Set_Tarifario();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;                        
                        ucGe_Menu.Visible_bntLimpiar = false;
                        cmb_centro_costo.Properties.ReadOnly = true;
                        Set_Tarifario();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;                        
                        ucGe_Menu.Visible_bntLimpiar = false;
                        cmb_centro_costo.Properties.ReadOnly = true;
                        Set_Tarifario();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == (char)Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewDetalle.DeleteRow(gridViewDetalle.FocusedRowHandle);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colIdCategoriaAf)
                {
                    int idCategoria = Convert.ToInt32(gridViewDetalle.GetRowCellValue(e.RowHandle, colIdCategoriaAf));
                    if (idCategoria != 0)
                    {
                        if (Lista.Where(q => q.IdCategoriaAF == idCategoria).Count() > 1)
                        {
                            MessageBox.Show("Ya existe un registro con esta categoria, se procederá a eliminar la fila", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridViewDetalle.DeleteRow(gridViewDetalle.FocusedRowHandle);
                        }                        
                    }
                    else
                        gridViewDetalle.DeleteRow(gridViewDetalle.FocusedRowHandle);
                }
                cargar_Grid_Activos_x_Categoria();  
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargar_Grid_Activos_x_Categoria()
        {
            try
            {
                list_Det_x_ActivoFijo = new BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info>();
                
                foreach (var item in Lista)
                {
                    if (item.IdCategoriaAF!=null)
                    {
                        int IdCategoriaAF = (int)item.IdCategoriaAF;
                        if (IdCategoriaAF != 0)
                        {
                            if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                            {
                                item.lst_Activos = bus_Activos.Get_List_Vista_Af_x_Categoria(param.IdEmpresa, IdCategoriaAF);

                                foreach (var Activo in item.lst_Activos)
                                {
                                    fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info info = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info();
                                    info.Af_Nombre = Activo.Af_Nombre;
                                    info.IdActivoFijo = Activo.IdActivoFijo;
                                    info.IdEmpresa = Activo.IdEmpresa;
                                    info.IdTarifario = info_Tarifario.IdTarifario;
                                    info.nom_Categoria = Activo.nom_Categoria;
                                    info.Seleccionado = Activo.Seleccionado;
                                    list_Det_x_ActivoFijo.Add(info);
                                }
                            }
                            else
                            {
                                info_Tarifario.lst_Act_x_tarifario = bus_A_x_F.Get_List_Activo_x_tarifario(param.IdEmpresa, info_Tarifario.IdTarifario);

                                list_Det_x_ActivoFijo = new BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info>();

                                item.lst_Activos = bus_Activos.Get_List_Vista_Af_x_Categoria(param.IdEmpresa, IdCategoriaAF);

                                foreach (var Activo in item.lst_Activos)
                                {
                                    if (info_Tarifario.lst_Act_x_tarifario.Where(q=>q.IdActivoFijo == Activo.IdActivoFijo).Count() == 0)
                                    {
                                        fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info info = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info();
                                        info.Af_Nombre = Activo.Af_Nombre;
                                        info.IdActivoFijo = Activo.IdActivoFijo;
                                        info.IdEmpresa = Activo.IdEmpresa;
                                        info.IdTarifario = info_Tarifario.IdTarifario;
                                        info.IdCategoriaAF = Activo.IdCategoriaAF;
                                        info.nom_Categoria = Activo.nom_Categoria;
                                        info.nom_UnidadFact = Activo.nom_UnidadFact;
                                        info.Seleccionado = Activo.Seleccionado;
                                        list_Det_x_ActivoFijo.Add(info);
                                    }                                    
                                }

                                foreach (var detalle in info_Tarifario.lst_Act_x_tarifario)
                                {
                                    list_Det_x_ActivoFijo.Add(detalle);
                                }
                            }
                        }    
                    }
                }
                gridControlActivos.DataSource = list_Det_x_ActivoFijo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDetalle_LostFocus(object sender, EventArgs e)
        {
            try
            {
                cargar_Grid_Activos_x_Categoria();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Limpiar()
        {
            try
            {
                Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                Set_Controles();
                info_Tarifario = new fa_tarifario_facturacion_x_cliente_Info();
                txtid.ResetText();
                txtcodigo.ResetText();
                txtnombre.ResetText();
                txtobservacion.ResetText();
                cmb_centro_costo.EditValue = null;                
                deFechaFin.EditValue = DateTime.Now;
                deFechaInicio.EditValue = DateTime.Now;
                Lista_grabar = new List<fa_tarifario_facturacion_x_cliente_det_Info>();
                Lista = new BindingList<fa_tarifario_facturacion_x_cliente_det_Info>();
                list_Det_x_ActivoFijo = new BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info>();
                gridControlActivos.DataSource = list_Det_x_ActivoFijo;
                gridControlDetalle.DataSource = Lista;
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        /*
        private Boolean ReUbicar_Activos()
        {
            try
            {
                
                bus_af_x_cc.Anular_Activos_x_centro_costo(param.IdEmpresa, ucFa_Cliente.Get_Info_Cliente_x_Centro_costo_x_Cliente().IdCentroCosto_cc,ucFa_Cliente.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo);

                
                    foreach (var Activo in info_Tarifario.lst_Act_x_tarifario)
                    {
                        if (Activo.Seleccionado)
                        {
                            info_af_x_pc = bus_af_x_pc.Get_Info_x_Activo_fijo(Activo.IdEmpresa, Activo.IdActivoFijo);
                            if (info_af_x_pc.IdPunto_cargo_PC == 0)
                            {
                                //--Creo punto de cargo
                                info_Punto_cargo.IdEmpresa = param.IdEmpresa;
                                info_Punto_cargo.nom_punto_cargo = Activo.Af_Nombre;
                                info_Punto_cargo.Estado = "A";

                                bus_Punto_cargo.GuardarDB(info_Punto_cargo, param.IdEmpresa);
                            }
                            else
                            {
                                info_Punto_cargo = bus_Punto_cargo.Get_Info_Punto_cargo(param.IdEmpresa, info_af_x_pc.IdPunto_cargo_PC);
                            }
                            //Relaciono activo fijo con punto de cargo
                            info_af_x_pc.IdEmpresa_AF = Activo.IdEmpresa;
                            info_af_x_pc.IdActivoFijo_AF = Activo.IdActivoFijo;
                            info_af_x_pc.IdEmpresa_PC = info_Punto_cargo.IdEmpresa;
                            info_af_x_pc.IdPunto_cargo_PC = info_Punto_cargo.IdPunto_cargo;

                            if (bus_af_x_pc.MergeDB(info_af_x_pc))
                            {
                                //Relaciono activo fijo con sub centro de costo
                                info_af_x_cc.IdEmpresa_AF = Activo.IdEmpresa;
                                info_af_x_cc.IdActivoFijo_AF = Activo.IdActivoFijo;
                                info_af_x_cc.IdCentroCosto_Scc = ucFa_Cliente.Get_Info_Cliente_x_Centro_costo_x_Cliente().IdCentroCosto_cc;
                                info_af_x_cc.IdEmpresa_Scc = ucFa_Cliente.Get_Info_Cliente_x_Centro_costo_x_Cliente().IdEmpresa_cc;
                                info_af_x_cc.IdCentroCosto_sub_centro_costo_Scc = ucFa_Cliente.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;

                                if (bus_af_x_cc.MergeDB(info_af_x_cc))
                                {
                                    //Creo un movimiento de activo fijo
                                    int idCambio = 0;
                                    string mensaje = "";
                                    info_Cambio_ubicacion.IdEmpresa = param.IdEmpresa;
                                    info_Cambio_ubicacion.IdActivoFijo = info_af_x_cc.IdActivoFijo_AF;
                                    info_Cambio_ubicacion.FechaCambio = info_Tarifario.fecha_inicio;
                                    info_Cambio_ubicacion.IdUnidadFact_cat = Activo.IdUnidadFact_cat;
                                    info_Cambio_ubicacion.Af_ValorUnidad_Actu = Activo.Af_ValorUnidad_Actu;
                                    info_Cambio_ubicacion.MotivoCambio = "CAMBIO POR TARIFARIO #" + info_Tarifario.IdTarifario + ": " + info_Tarifario.nom_tarifario;
                                    info_Cambio_ubicacion.IdCentroCosto_Ant = Activo.IdCentroCosto;
                                    info_Cambio_ubicacion.IdCentroCosto_Actu = ucFa_Cliente.Get_Info_Cliente_x_Centro_costo_x_Cliente().IdCentroCosto_cc;
                                    info_Cambio_ubicacion.IdCentroCosto_sub_centro_costo_Ant = Activo.IdCentroCosto_sub_centro_costo;
                                    info_Cambio_ubicacion.IdCentroCosto_sub_centro_costo_Actu = ucFa_Cliente.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;

                                    if (info_Cambio_ubicacion.IdCentroCosto_Ant != info_Cambio_ubicacion.IdCentroCosto_Actu)
                                        bus_Cambio_ubicacion.GuardarDB(info_Cambio_ubicacion, ref idCambio, ref mensaje);
                                }
                            }
                        }
                    }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }*/

        private bool ValidarSeleccion()
        {
            try
            {
                int contador = 0;
                int cantidad = 0;
                foreach (var Categoria in Lista)
                {
                    contador = 0;
                    cantidad = Categoria.cantidad;
                    foreach (var Activo in list_Det_x_ActivoFijo)
                    {
                        if (Activo.IdCategoriaAF == Categoria.IdCategoriaAF)
                        {
                            if (Activo.Seleccionado)
                            {
                                contador++;
                                if (contador > cantidad)
                                {
                                    MessageBox.Show("Ha seleccionado mas activos que los señalados por categoría ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                            }    
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void frmFa_Tarifario_Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_frmFa_Tarifario_Mantenimiento_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewActivos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info row = gridViewActivos.GetRow(e.RowHandle) as fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info;

                if (e.Column != colSeleccionado)
                {
                    if (!row.Seleccionado)
                    {
                        gridViewActivos.SetRowCellValue(e.RowHandle, colSeleccionado, true);
                    }
                }

                if (e.Column == col_IdCentroCosto_sub_centro_costo)
                {
                    
                }
                
                Activos_a_Depreciar();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       
        private void deFechaInicio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Porcentaje_Comision_x_Anio();
                Total_meses();
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            
            }
        }

        private void deFechaFin_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Total_meses();
                Porcentaje_Comision_x_Anio();
                Activos_a_Depreciar();
                Generar_tabla_depreciacion();

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_porcentaje_ganancia_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Porcentaje_Comision_x_Anio(); 
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Porcentaje_Comision_x_Anio()
        {
            try
            {
                if (txt_porcentaje_ganancia.Text == "")
                {
                    txt_porcentaje_ganancia.Text = "0.00";
                }

                 Anios_Inicio = 0;
                 Anios_Fin = 0;
                 Anio_Servicios = 0;
                int contador = 0;
                double porcentaje_inicial = 0;
                fecha_inicio = Convert.ToDateTime(deFechaInicio.EditValue);
                fecha_fin = Convert.ToDateTime(deFechaFin.EditValue);
                Anios_Inicio = fecha_inicio.Year;
                Anios_Fin = fecha_fin.Year;

                Anio_Servicios = Anios_Fin - Anios_Inicio;
                list_porcentaje_comision = new BindingList<fa_tarifario_facturacion_x_cliente_Por_comision_Info>();
                while (contador < Anio_Servicios)
                {
                    contador++;
                    fa_tarifario_facturacion_x_cliente_Por_comision_Info info = new fa_tarifario_facturacion_x_cliente_Por_comision_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdTarifario = info_Tarifario.IdTarifario;
                    info.IdAnio = Anios_Inicio;
                    Anios_Inicio = Anios_Inicio + 1;
                    if (contador == 1)
                    {
                        fecha_fin = fecha_inicio.AddYears(1);

                        info.Fecha_inicio = fecha_inicio;
                        info.Fecha_Fin = fecha_fin;
                        info.porcentaje = Convert.ToDouble(txt_porcentaje_ganancia.Text);
                        porcentaje_inicial = info.porcentaje;
                    }
                    else
                    {
                        fecha_inicio = fecha_fin;
                        fecha_fin = fecha_fin.AddYears(1);

                        info.Fecha_inicio = fecha_inicio;
                        info.Fecha_Fin = fecha_fin;

                        porcentaje_inicial = porcentaje_inicial - 1;
                        info.porcentaje = porcentaje_inicial;

                    }
                    list_porcentaje_comision.Add(info);
                }

                gridControl_Margenes_Ganancia.DataSource = list_porcentaje_comision;




              

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }

        }

        public void Activos_a_Depreciar()
        {
            try
            {
                lista_parametro_x_a_depreciar = new BindingList<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info>();
                List<Af_Activo_fijo_Info> lista_activos = new List<Af_Activo_fijo_Info>();
                foreach (var item_ in Lista)
                {
                    lista_activos = item_.lst_Activos;
                    break;
                }

                foreach (var item in list_Det_x_ActivoFijo.Where(v=>v.Seleccionado==true))
                {
                    fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info parametro_depreciacion_x_activo = new fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Param_depre_Info();
                    Af_Activo_fijo_Info info_activo = new Af_Activo_fijo_Info();
                    info_activo = lista_activos.Where(v => v.IdEmpresa == item.IdEmpresa && v.IdActivoFijo == item.IdActivoFijo).FirstOrDefault();
                    if (info_activo != null)
                    {
                        parametro_depreciacion_x_activo.IdEmpresa = info_activo.IdEmpresa;
                        parametro_depreciacion_x_activo.IdActivoFijo = item.IdActivoFijo;
                        parametro_depreciacion_x_activo.Af_porcentaje_deprec = 100 / Meses_a_Depreciar;
                        parametro_depreciacion_x_activo.Af_anios_vida_util = Anio_Servicios;
                        parametro_depreciacion_x_activo.Af_costo_historico = info_activo.Af_Costo_historico;
                        parametro_depreciacion_x_activo.Af_costo_compra = info_activo.Af_costo_compra;
                        parametro_depreciacion_x_activo.Af_Meses_depreciar = Meses_a_Depreciar;
                        parametro_depreciacion_x_activo.Af_fecha_ini_depre = Convert.ToDateTime(deFechaInicio.EditValue);
                        parametro_depreciacion_x_activo.Af_fecha_fin_depre = Convert.ToDateTime(deFechaFin.EditValue);
                        parametro_depreciacion_x_activo.Af_ValorSalvamento = info_activo.Af_ValorSalvamento;
                        parametro_depreciacion_x_activo.Af_ValorResidual = info_activo.Af_ValorResidual;
                        parametro_depreciacion_x_activo.se_factura_valorSalvamento = check_factura_Valor_Salvamento.Checked;
                        parametro_depreciacion_x_activo.se_factura_Iva = check_iva.Checked;
                        parametro_depreciacion_x_activo.Af_Nombre = info_activo.Af_Nombre;
                        parametro_depreciacion_x_activo.Af_costo_compra_carroceria = info_activo.costo_compra_carroceria;
                        parametro_depreciacion_x_activo.Af_ValorSalvamento_carroceria = info_activo.valor_salvamento_carroceria;
                        if (parametro_depreciacion_x_activo.se_factura_Iva == true)
                        {
                            parametro_depreciacion_x_activo.Af_costo_compra = parametro_depreciacion_x_activo.Af_costo_compra + ((parametro_depreciacion_x_activo.Af_costo_compra * param.iva.porcentaje) / 100);
                            parametro_depreciacion_x_activo.Af_ValorSalvamento = parametro_depreciacion_x_activo.Af_ValorSalvamento + ((parametro_depreciacion_x_activo.Af_ValorSalvamento * param.iva.porcentaje) / 100);

                            parametro_depreciacion_x_activo.Af_costo_compra_carroceria = parametro_depreciacion_x_activo.Af_costo_compra_carroceria + ((parametro_depreciacion_x_activo.Af_costo_compra_carroceria * param.iva.porcentaje) / 100);
                            parametro_depreciacion_x_activo.Af_ValorSalvamento_carroceria = parametro_depreciacion_x_activo.Af_ValorSalvamento_carroceria + ((parametro_depreciacion_x_activo.Af_ValorSalvamento_carroceria * param.iva.porcentaje) / 100);
                        }

                        lista_parametro_x_a_depreciar.Add(parametro_depreciacion_x_activo);
                    }
                }

                gridControl_activos_depreciar.DataSource = lista_parametro_x_a_depreciar;




                Generar_tabla_depreciacion();

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void Generar_tabla_depreciacion()
        {
            try
            {

                lista_tabla_depreciacion_x_mes = new List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info>();
                lista_tabla_depreciacion_x_mes_activo = new List<fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info>();


                DateTime fecha_incrementa =Convert.ToDateTime( deFechaInicio.EditValue);
                fecha_fin = Convert.ToDateTime(deFechaFin.EditValue);
                while (fecha_incrementa <= fecha_fin)
                {    
                                   
                        fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info info_Deprecion_x_mes = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Info();
                        info_Deprecion_x_mes.IdEmpresa = param.IdEmpresa;
                        info_Deprecion_x_mes.IdDepreciacion = 0;
                        info_Deprecion_x_mes.IdPeriodo = Convert.ToInt32(fecha_incrementa.Year.ToString() + fecha_incrementa.Month.ToString("00"));
                        info_Deprecion_x_mes.IdTipoDepreciacion = 1;
                        info_Deprecion_x_mes.Descripcion = "Depreciacion Activo del Periodo " + info_Deprecion_x_mes.IdPeriodo;
                        info_Deprecion_x_mes.Fecha_Depreciacion =fecha_incrementa;
                        info_Deprecion_x_mes.Num_Act_Depre = lista_parametro_x_a_depreciar.Select(v => v.IdActivoFijo).Count();
                        info_Deprecion_x_mes.Valor_Tot_Depre = (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_costo_compra) + (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_costo_compra_carroceria) - (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_ValorSalvamento) - (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_ValorSalvamento_carroceria);
                        info_Deprecion_x_mes.Valor_Tot_DepreAcum = (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_costo_compra) + (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_costo_compra_carroceria) - (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_ValorSalvamento) - (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_ValorSalvamento_carroceria);
                        info_Deprecion_x_mes.Valot_Tot_Importe = (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_costo_compra) + (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_costo_compra_carroceria) - (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_ValorSalvamento) - (double)lista_parametro_x_a_depreciar.Sum(v => v.Af_ValorSalvamento_carroceria);
                        fecha_incrementa = fecha_incrementa.AddMonths(1);
                        lista_tabla_depreciacion_x_mes.Add(info_Deprecion_x_mes);

                     }
                // se procedera a realizar la depreciacion en proceso.....................
                meses = 0;
                       foreach (var item_meses_depre in lista_tabla_depreciacion_x_mes)
                        {
                            meses = meses + 1;
                            foreach (var item_activos_x_parametros in lista_parametro_x_a_depreciar)
                            {
                                fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info item = new fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info();                               
                                item.IdEmpresa = param.IdEmpresa;
                                item.IdDepreciacion = 0;
                                item.IdTarifario = 0;
                                item.Secuencia = 0;
                                item.IdTipoDepreciacion = 1;
                                item.IdActivoFijo = item_activos_x_parametros.IdActivoFijo;
                                item.Af_Nombre = item_activos_x_parametros.Af_Nombre;
                                item.Concepto = "Depreciacion del periodo "+item_meses_depre.IdPeriodo+" del activo "+item_activos_x_parametros.Af_Nombre;
                                item.Valor_Compra = (double)item_activos_x_parametros.Af_costo_compra + (double)item_activos_x_parametros.Af_costo_compra_carroceria;
                                item.Valor_Salvamento =(double) item_activos_x_parametros.Af_ValorSalvamento + (double)item_activos_x_parametros.Af_ValorSalvamento_carroceria;
                                item.Vida_Util = Anio_Servicios;
                                item.Porc_Depreciacion =(double) item_activos_x_parametros.Af_porcentaje_deprec;
                                item.IdPeriodo = item_meses_depre.IdPeriodo;
                               

                                if (item_activos_x_parametros.se_factura_valorSalvamento == false)
                                {
                                    item.Valor_Depreciacion = (item.Valor_Compra - item.Valor_Salvamento) / Meses_a_Depreciar;
                                }
                                else
                                {
                                    item.Valor_Depreciacion = (item.Valor_Compra) / Meses_a_Depreciar;
                                }
                               
                                item.Valor_Depreciacion  =Convert.ToDouble( string.Format("{0:0.00}", item.Valor_Depreciacion));
                                item.Valor_Depre_Acum = item.Valor_Depreciacion*meses;
                                item.Valor_Importe = 0;
                                item_meses_depre.list_depreciacion_mes_x_activo.Add(item);
                                lista_tabla_depreciacion_x_mes_activo.Add(item);//para mostrar grilla

                            }

                        }
                       gridControl_tabla_Depreciacion.DataSource = lista_tabla_depreciacion_x_mes_activo;

            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }        

        private void Total_meses()
        {
            try
            {
                Meses_a_Depreciar=0;
                DateTime fecha_inceremnta =Convert.ToDateTime( deFechaInicio.EditValue);
                fecha_fin = Convert.ToDateTime(deFechaFin.EditValue);
                while (fecha_inceremnta<=fecha_fin)
                {
                    fecha_inceremnta = fecha_inceremnta.AddMonths(1);
                    if (fecha_inceremnta.Year != fecha_fin.Year || fecha_inceremnta.Month != fecha_fin.Month)
                    {
                        Meses_a_Depreciar = Meses_a_Depreciar + 1;
                    }
                }

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void check_factura_Valor_Salvamento_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Activos_a_Depreciar();
                Generar_tabla_depreciacion();
            }
            catch (Exception ex)
            {                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void check_iva_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Activos_a_Depreciar();
                Generar_tabla_depreciacion();                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                else
                    lst_subcentro = new List<ct_centro_costo_sub_centro_costo_Info>();
                cmb_subcentro.DataSource = lst_subcentro;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
    }
}
