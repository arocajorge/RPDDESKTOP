using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_Compensacion_Mant : Form
    {
        public frmFa_Compensacion_Mant()
        {
            InitializeComponent();
            
        }

        #region variable
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        List<ct_Periodo_Info> lst_periodo = new List<ct_Periodo_Info>();
        ct_Periodo_Bus bus_periodo = new ct_Periodo_Bus();
        fa_compensacion_x_ct_centro_costo_Info info_compensacion = new fa_compensacion_x_ct_centro_costo_Info();


        fa_compensacion_x_ct_centro_costo_Bus bus_compensacion = new fa_compensacion_x_ct_centro_costo_Bus();
        BindingList<fa_compensacion_x_ct_centro_costo_det_Info> lista_compensacion = new BindingList<fa_compensacion_x_ct_centro_costo_det_Info>();
        fa_compensacion_x_ct_centro_costo_det_det_Bus bus_compensacion_det = new fa_compensacion_x_ct_centro_costo_det_det_Bus();
        #endregion
        private void frmFa_Compensacion_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_dato();
                gridControl_compensacion.DataSource = lista_compensacion;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
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
                string mensaje = "";
                ucFa_Cliente_x_centro_costo.Cargar_combos();
                lst_periodo = bus_periodo.Get_List_Periodo(param.IdEmpresa, ref mensaje);
                cmb_periodo.DataSource = lst_periodo;
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
                if (Grabardb())
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
                Grabardb();
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
                info_compensacion = new fa_compensacion_x_ct_centro_costo_Info();
                info_compensacion.lista = new List<fa_compensacion_x_ct_centro_costo_det_Info>();
                info_compensacion.IdEmpresa = param.IdEmpresa;
                info_compensacion.IdCompensacion =Convert.ToInt32( txtid.EditValue);
                info_compensacion.IdCentroCosto = ucFa_Cliente_x_centro_costo.Get_Info_Centro_costo().IdCentroCosto;
                info_compensacion.IdCentroCosto_sub_centro_costo = ucFa_Cliente_x_centro_costo.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;
                info_compensacion.observacion = txtobservacion.EditValue.ToString();
                info_compensacion.tasa_interes_anual_x_banco = Convert.ToDouble(txttasainteresbanco.EditValue);
                info_compensacion.tasa_interes_anual_x_centro_costo = Convert.ToDouble(txttasaiCC.EditValue);
                info_compensacion.num_cuotas_meses_x_banco = Convert.ToDouble(txtnumcuotabanco.EditValue);
                info_compensacion.num_cuotas_meses_x_centro_costo = Convert.ToDouble(txtnumcuotacc.EditValue);
                info_compensacion.valor_a_financiar =Convert.ToDouble( txtvalorafinanciar.EditValue);

               
                info_compensacion.lista = lista_compensacion.ToList();
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
                txtid.Focus();

                if (ucFa_Cliente_x_centro_costo.Get_Info_Centro_costo() == null ) 
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Centro de costo",param.Nombre_sistema,  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (ucFa_Cliente_x_centro_costo.Get_Info_Centro_costo_sub_centro_costo() ==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Subcentro costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                if (txtobservacion.EditValue==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " Observacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                if (txttasaiCC.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " tasa de interes Centro costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txttasainteresbanco.EditValue==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " tasa de interes banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                if (txtnumcuotabanco.EditValue==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " numero cuota banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }



                if (txtnumcuotacc.EditValue==null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " numero cuota centro costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        bool Grabardb()
        {
            try
            {
                Get();


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       Guardar ();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Anular();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado:
                        break;
                    default:
                        break;
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


        public void Set(fa_compensacion_x_ct_centro_costo_Info info)
        {
            try
            {
                info_compensacion = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                txtid.EditValue = info_compensacion.IdCompensacion;
                ucFa_Cliente_x_centro_costo.Set_Info_Centro_costo(info_compensacion.IdCentroCosto);
                ucFa_Cliente_x_centro_costo.Set_Info_Centro_costo_sub_centro_costo(info_compensacion.IdCentroCosto_sub_centro_costo);
                txtnumcuotabanco.EditValue = info_compensacion.num_cuotas_meses_x_banco;
                txtnumcuotacc.EditValue = info_compensacion.num_cuotas_meses_x_centro_costo;
                txttasaiCC.EditValue = info_compensacion.tasa_interes_anual_x_centro_costo;
                txttasainteresbanco.EditValue = info_compensacion.tasa_interes_anual_x_banco;
                txtobservacion.EditValue = info_compensacion.observacion;
                txtvalorafinanciar.EditValue = info_compensacion.valor_a_financiar;
                lista_compensacion = new BindingList<fa_compensacion_x_ct_centro_costo_det_Info>(bus_compensacion_det.GetList(param.IdEmpresa, info_compensacion.IdCompensacion));
                gridControl_compensacion.DataSource = lista_compensacion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

      
     
        private void gridView_planificacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    gridView_compensacion.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_planificacion_KeyDown(object sender, KeyEventArgs e)
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

                fa_compensacion_x_ct_centro_costo_det_Info newRow = new fa_compensacion_x_ct_centro_costo_det_Info();
                if (rowData.Count() >= 3) //return false;          
                {


                    string num_mes = Convert.ToString(rowData[0]);
                    string capital_reducido = Convert.ToString(rowData[1]);
                    string valor_amortizacion = Convert.ToString(rowData[2]);
                    string valor_interes_banco = Convert.ToString(rowData[3]);
                    string valor_interes_centro_costo = Convert.ToString(rowData[4]);
                    string valor_interes_diferencia = Convert.ToString(rowData[5]);
                    string dividendo = Convert.ToString(rowData[6]);




                    if (!string.IsNullOrWhiteSpace(num_mes.ToString()))
                    {

                        //
                            newRow.num_mes = num_mes == "0.00" ? 0 : Convert.ToInt32(num_mes.Replace(".00",""));
                            newRow.capital_reducido = capital_reducido == "" ? 0 : Convert.ToDouble(capital_reducido.Replace(".00", ""));
                            newRow.valor_amortizacion = valor_amortizacion == "" ? 0 : Convert.ToDouble(valor_amortizacion);
                            newRow.valor_interes_banco = valor_interes_banco == "" ? 0 : Convert.ToDouble(valor_amortizacion);
                            newRow.valor_interes_centro_costo = valor_interes_centro_costo == "" ? 0 : Convert.ToDouble(valor_interes_centro_costo);
                            newRow.valor_interes_diferencia = valor_interes_diferencia == "" ? 0 : Convert.ToDouble(valor_interes_diferencia);
                             newRow.dividendo = dividendo == "" ? 0 : Convert.ToDouble(dividendo);
                            if (fx_Verificar_Reg_Repetidos(newRow))
                            {
                            lista_compensacion.Add(newRow);
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
        private Boolean fx_Verificar_Reg_Repetidos(fa_compensacion_x_ct_centro_costo_det_Info Info_det)
        {
            try
            {
                int cont = 0;
                


                
                    cont = (from C in lista_compensacion
                            where C.num_mes == Info_det.num_mes
                            select C).Count();
                    if (cont > 0)
                        return false;

                else
                    return true;

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool Guardar()
        {
            try
            {
                 if (bus_compensacion.Guardar_DB(info_compensacion))
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
            catch (Exception)
            {

                return false;
            }
        }
        private bool Modificar()
        {
            try
            {
                if (bus_compensacion.Modificar_DB(info_compensacion))
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
            catch (Exception)
            {

                return false;
            }
        }
        private bool Anular()
        {
            try
            {
                if (bus_compensacion.Anular_DB(info_compensacion))
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
            catch (Exception)
            {

                return false;
            }
        }


    }
}
