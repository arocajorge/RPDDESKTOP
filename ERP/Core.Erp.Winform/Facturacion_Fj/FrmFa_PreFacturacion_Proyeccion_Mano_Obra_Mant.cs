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
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Cus.Erp.Reports.FJ.Facturacion;
using Core.Erp.Info.Mantenimiento;
using Core.Erp.Business.Mantenimiento;
namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class FrmFa_PreFacturacion_Proyeccion_Mano_Obra_Mant : Form
    {
        #region Varible
        Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<fa_pre_facturacion_proyeccion_mano_obra_Info> lista = new BindingList<fa_pre_facturacion_proyeccion_mano_obra_Info>();
        fa_pre_facturacion_proyeccion_mano_obra_Bus bus_manoobra = new fa_pre_facturacion_proyeccion_mano_obra_Bus();
        fa_pre_facturacion_Info info_prefacturacion = new fa_pre_facturacion_Info();
        List<fa_cliente_x_ct_centro_costo_Info> lst_Cliente_x_Centro_costo = new List<fa_cliente_x_ct_centro_costo_Info>();
        fa_cliente_x_ct_centro_costo_Bus bus_Cliente_x_Centro_costo = new fa_cliente_x_ct_centro_costo_Bus();

        #endregion
        public FrmFa_PreFacturacion_Proyeccion_Mano_Obra_Mant()
        {
            InitializeComponent();
            ucCon_Periodo1.Cargar_combos();
            ucFa_CatalogosCmb1.cargar_Catalogos(10);
            
               
        }

        private void FrmFa_PreFacturacion_Proyeccion_Mano_Obra_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                lst_Cliente_x_Centro_costo = bus_Cliente_x_Centro_costo.Get_Vista_Clientes_x_Centro_costo(param.IdEmpresa);
                cmb_centro_costo.Properties.DataSource = lst_Cliente_x_Centro_costo;

                ucCon_Periodo1.Cargar_combos();
                ucFa_CatalogosCmb1.cargar_Catalogos(10);
                ucFa_CatalogosCmb1.Perfil_Lectura();
                set_accion_in_controls();
               

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
                foreach (var item in lista)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPeriodo = info_prefacturacion.IdPeriodo;
                    item.IdPrefacturacion = info_prefacturacion.IdPreFacturacion;
                    if (item.DiferenciaManoObra == null)
                        item.DiferenciaManoObra = 0;
                    if (item.ValorRealManoObra == null)
                        item.ValorRealManoObra = 0;

                }


                if (bus_manoobra.GuardarDB(lista.ToList()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
         
            }
        }
        public void set_info(fa_pre_facturacion_Info _info)
        {
            try
            {
                info_prefacturacion = _info;

                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action  Acc)
        {
            try
            {
                Accion = Acc;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_ProyeccionManoObra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "Col_ValorModificadoManoObra" || e.Column.Name == "Col_valor_proyectado")
                {

                    double valorReal = 0;
                    double ValorPresupuesto = 0;
                    double Diferencia = 0;

                    fa_pre_facturacion_proyeccion_mano_obra_Info info_pr = new fa_pre_facturacion_proyeccion_mano_obra_Info();
                    info_pr = (fa_pre_facturacion_proyeccion_mano_obra_Info)gridView_ProyeccionManoObra.GetFocusedRow();
                    if (info_pr != null)
                    {
                        
                            valorReal =Convert.ToDouble( info_pr.ValorModificadoManoObra);
                            ValorPresupuesto = Convert.ToDouble(info_pr.valor_proyectado);
                            Diferencia = valorReal - ValorPresupuesto;

                            gridView_ProyeccionManoObra.SetFocusedRowCellValue(Col_iferenciaManoObra,  Diferencia );

                    }

                }

            }
            catch (Exception )
            {
                
                
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void set_accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_info_in_controls();
                        ucGe_Menu.btnGuardar.Visible =false;
                        ucGe_Menu.btnGuardar_y_Salir.Visible = true;
                         txt_Observacion.Enabled = false;
                        ucCon_Periodo1.Enabled = false;
                        ucFa_CatalogosCmb1.Enabled = false;
                        de_Fecha.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.btnGuardar.Visible = false;
                        ucGe_Menu.btnGuardar_y_Salir.Visible = false;
                        txt_Observacion.Enabled = false;
                        ucCon_Periodo1.Enabled = false;
                        ucFa_CatalogosCmb1.Enabled = false;
                        de_Fecha.Enabled = false;
                        set_info_in_controls();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        private void set_info_in_controls()
        {
            try
            {
                txt_IdPreFacturacion.Text = info_prefacturacion.IdPreFacturacion.ToString();
                txt_Observacion.Text = info_prefacturacion.Observacion;
                ucCon_Periodo1.Set_Periodo(info_prefacturacion.IdPeriodo);
                de_Fecha.EditValue = info_prefacturacion.fecha;
             //   ucFa_CatalogosCmb1.set_CatalogosInfo(info_prefacturacion.estado_cierre);
                cmb_centro_costo.EditValue = info_prefacturacion.IdCentroCosto;
                if (info_prefacturacion.estado == "I")
                    lblAnulado.Visible = true;

                lista = new BindingList<fa_pre_facturacion_proyeccion_mano_obra_Info>(bus_manoobra.GetList(param.IdEmpresa, Convert.ToInt32(info_prefacturacion.IdPeriodo)));
                gridControl_ProyeccionManoObra.DataSource = lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

    }
}
