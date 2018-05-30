using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario_CG
{
    public partial class FrmIn_Egresos_varios_CG_Cons : Form
    {

        List<in_Ing_Egr_Inven_Info> listEgresos;
        in_Ing_Egr_Inven_Bus bus_IngEgr;
        in_Ing_Egr_Inven_Info Info = new in_Ing_Egr_Inven_Info();
        FrmIn_Egresos_varios_CG_Mant frm;       
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;

        DateTime fecha_desde;
        DateTime fecha_hasta;
        int IdSucursalIni = 0;
        int IdSucursalFin = 0;
        int IdBodegaIni = 0;
        int IdBodegaFin = 0;

        public FrmIn_Egresos_varios_CG_Cons()
        {
            InitializeComponent();
            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                }


                load_Data();
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControl_Egresos_Varios.ShowPrintPreview();
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_Info)gridView_Egreso_varios.GetFocusedRow();
                if (Info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Info.Estado == "A")
                    {
                        llama_formulario(Cl_Enumeradores.eTipo_action.Anular);
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_Info)gridView_Egreso_varios.GetFocusedRow();
                if (Info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_formulario(Cl_Enumeradores.eTipo_action.consultar);
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_Info)gridView_Egreso_varios.GetFocusedRow();
                if (Info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Info.Estado != "I")
                    {
                        llama_formulario(Cl_Enumeradores.eTipo_action.actualizar);
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_modif_regis_Inac), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_formulario(Cl_Enumeradores.eTipo_action.grabar);
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

        private void FrmIn_Ingreso_varios_CG_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                }
                load_Data();
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

        private void gridView_Egreso_varios_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Egreso_varios.GetRow(e.RowHandle) as in_Ing_Egr_Inven_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
                else
                {
                    if (data.IdEstadoDespacho_cat == "EST_DES_DES")
                    {
                        e.Appearance.ForeColor = Color.DarkGreen;
                        return;
                    }

                    if (data.IdEstadoAproba == "APRO")
                        e.Appearance.ForeColor = Color.Blue;
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


        private void load_Data()
        {
            try
            {             
                fecha_desde= ucGe_Menu_Mantenimiento_x_usuario.fecha_desde;
                fecha_hasta= ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta;
                listEgresos = new List<in_Ing_Egr_Inven_Info>();
                bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                listEgresos = bus_IngEgr.Get_List_Ing_Egr_Inven(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, fecha_desde, fecha_hasta);

                var listaEgr = listEgresos.Where(q => q.signo == "-").ToList();
                gridControl_Egresos_Varios.DataSource = null;
                gridControl_Egresos_Varios.DataSource = listaEgr.ToList().OrderByDescending(x=> x.IdNumMovi);
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

        private void llama_formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                frm = new FrmIn_Egresos_varios_CG_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmIn_Egreso_varios_Mant_FormClosing += frm_event_FrmIn_Egreso_varios_Mant_FormClosing;       
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.setInfo_(Info);
                }
                frm.set_Accion(Accion);
                frm.Show();
                

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

        void frm_event_FrmIn_Egreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                }
                load_Data();
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
