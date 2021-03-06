﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Reportes.Controles
{
public partial class UCCxp_MenuReportes : UserControl
    {
        #region Data
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus busSucursal = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> lstSucuInfo = new List<tb_Sucursal_Info>();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();
        List<tb_Bodega_Info> lstBodegaInfo = new List<tb_Bodega_Info>();
        in_producto_Bus busProducto = new in_producto_Bus();
        List<in_Producto_Info> lstProductoInfo = new List<in_Producto_Info>();
        in_movi_inven_tipo_Bus busMoviTip = new in_movi_inven_tipo_Bus();
        List<in_movi_inven_tipo_Info> lstMoviTipiInfo = new List<in_movi_inven_tipo_Info>();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        ct_Centro_costo_Bus busCentro_costo = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> lstCentro_costo = new List<ct_Centro_costo_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> lstSubcentro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus busSubcentro_costo = new ct_centro_costo_sub_centro_costo_Bus();
        List<cp_proveedor_clase_Info> lst_clase_prov = new List<cp_proveedor_clase_Info>();
        cp_proveedor_clase_Bus bus_clase_prov = new cp_proveedor_clase_Bus();
        
        #endregion

        #region Event
        public delegate void delegate_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnConsultar_ItemClick event_tnConsultar_ItemClick;
        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;
        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;
        #endregion

        #region Visible_Enable
        public DevExpress.XtraBars.BarItemVisibility VisibleDesde { get { return this.dtpDesde.Visibility; } set { this.dtpDesde.Visibility = value; } }

        public Boolean VisibleGrupoSucursal
        {
            get { return this.GrupoSucu_bod.Visible; }
            set { this.GrupoSucu_bod.Visible = value; }
        }

        public Boolean VisibleGrupoProveedor
        {
            get { return this.GrupoProveedor.Visible; }
            set { this.GrupoProveedor.Visible = value; }
        }

        public Boolean VisibleGrupoCheck
        {
            get { return this.GrupoCheck.Visible; }
            set { this.GrupoCheck.Visible = value; }
        }

        public Boolean VisibleGrupoMovimiento
        {
            get { return this.GrupoMovimiento.Visible; }
            set { this.GrupoMovimiento.Visible = value; }
        }
        public Boolean VisibleGrupoFecha
        {
            get { return this.GrupoFecha.Visible; }
            set { this.GrupoFecha.Visible = value; }
        }
        public Boolean VisibleGrupoBotones
        {
            get { return this.GrupoBotones.Visible; }
            set { this.GrupoBotones.Visible = value; }
        }
        public Boolean VisibleGrupoCentro_Subcentro_costo
        {
            get { return this.ribbonPageGroupCentroCosto.Visible; }
            set { this.ribbonPageGroupCentroCosto.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbProveedor
        {
            get { return this.cmbProveedor.Visibility; }
            set { this.cmbProveedor.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisiblebeiCheck1
        {
            get { return this.beiCheck1.Visibility; }
            set { this.beiCheck1.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblebeiCheck2
        {
            get { return this.beiCheck2.Visibility; }
            set { this.beiCheck2.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisiblebeiCheck3
        {
            get { return this.beiCheck3.Visibility; }
            set { this.beiCheck3.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visiblebei_clase_prov
        {
            get { return this.bei_clase_prov.Visibility; }
            set { this.bei_clase_prov.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbSucursal
        {
            get { return this.cmbSucursal.Visibility; }
            set { this.cmbSucursal.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbBodega
        {
            get { return this.cmbBodega.Visibility; }
            set { this.cmbBodega.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbProducto
        {
            get { return this.cmbProducto.Visibility; }
            set { this.cmbProducto.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbTipoMovInve
        {
            get { return this.cmbTipoMovInve.Visibility; }
            set { this.cmbTipoMovInve.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleDtpDesde
        {
            get { return this.dtpDesde.Visibility; }
            set { this.dtpDesde.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleDtpHasta
        {
            get { return this.dtpHasta.Visibility; }
            set { this.dtpHasta.Visibility = value; }
        }
        
        
        public DevExpress.XtraBars.BarItemVisibility VisiblebtnImprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblebtnSalir
        {
            get { return this.btnSalir.Visibility; }
            set { this.btnSalir.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmb_CentroCosto
        {
            get { return this.barEditItemCentroCosto.Visibility; }
            set { this.barEditItemCentroCosto.Visibility = value; }
        }


        public string beiCheck1Caption
        {
            get
            { return this.beiCheck1.Caption; }
            set { this.beiCheck1.Caption = value; }
        }

        public string beiCheck2Caption
        {
            get
            { return this.beiCheck2.Caption; }
            set { this.beiCheck2.Caption = value; }
        }

        public string beiCheck3Caption
        {
            get
            { return this.beiCheck3.Caption; }
            set { this.beiCheck3.Caption = value; }
        }

        public Boolean EnableBotonImprimir
        {
            get { return this.btnImprimir.Enabled; }
            set { this.btnImprimir.Enabled = value; }
        }

        public Boolean EnableBotonConsultar
        {
            get { return this.btnConsultar.Enabled; }
            set { this.btnConsultar.Enabled = value; }
        }

        public Boolean EnableBotonSalir
        {
            get { return this.btnSalir.Enabled; }
            set { this.btnSalir.Enabled = value; }
        }

        #endregion

        public UCCxp_MenuReportes()
        {
            InitializeComponent();
            event_btnImprimir_ItemClick += UCCxp_MenuReportes_event_btnImprimir_ItemClick;
            event_btnSalir_ItemClick += UCCxp_MenuReportes_event_btnSalir_ItemClick;
            event_tnConsultar_ItemClick += UCCxp_MenuReportes_event_tnConsultar_ItemClick;

            
        }
    
        void UCCxp_MenuReportes_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCCxp_MenuReportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCCxp_MenuReportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCCxp_MenuReportes_Load(object sender, EventArgs e)
        {
            try
            {
                in_Producto_Info infoProducto = new in_Producto_Info();
                in_movi_inven_tipo_Info infoMoviTipi = new in_movi_inven_tipo_Info();
                cp_proveedor_Info infoProvee = new cp_proveedor_Info();
                ct_Centro_costo_Info infoCentro_costo = new ct_Centro_costo_Info();
                ct_centro_costo_sub_centro_costo_Info infoSubcentro_costo = new ct_centro_costo_sub_centro_costo_Info();
                in_movi_inven_tipo_Info info_movimiento = new in_movi_inven_tipo_Info();

                string msg="";

                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now.Date;

                lstSucuInfo = busSucursal.Get_List_Sucursal_Todos(param.IdEmpresa);
                cmbSucursal_Grid.DataSource = lstSucuInfo;

                lstBodegaInfo = busBodega.Get_List_Bodega(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.todos);
                cmbBodega_Grid.DataSource = lstBodegaInfo;

                infoProducto.IdProducto = 0;
                infoProducto.pr_descripcion = "Todos";

                infoProvee.IdProveedor = 0;
                infoProvee.pr_nombre = "Todos";

                infoMoviTipi.IdMovi_inven_tipo = 0;
                infoMoviTipi.tm_descripcion = "Todos";

                infoCentro_costo.IdCentroCosto = "Todos";
                infoCentro_costo.Centro_costo = "Todos";

                infoSubcentro_costo.IdCentroCosto_sub_centro_costo = "Todos";
                infoSubcentro_costo.Centro_costo = "Todos";

                lstProductoInfo = busProducto.Get_list_Producto(param.IdEmpresa);
                lstProductoInfo.Add(infoProducto);
                cmbProducto_Grid.DataSource = lstProductoInfo.OrderBy(q => q.IdProducto).ToList();

                lstMoviTipiInfo = busMoviTip.Get_List_movi_inven_tipo(param.IdEmpresa);
                lstMoviTipiInfo.Add(infoMoviTipi);
                CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();

                listProveedor = busProveedor.Get_List_proveedor(param.IdEmpresa);
                listProveedor.Add(infoProvee);
                cmbProveedor_Grid.DataSource = listProveedor;

                lstCentro_costo = busCentro_costo.Get_list_Centro_Costo(param.IdEmpresa,ref msg);
                lstCentro_costo.Add(infoCentro_costo);
                cmb_centroCosto.DataSource = lstCentro_costo;

                lstSubcentro_costo = busSubcentro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                lstSubcentro_costo.Add(infoSubcentro_costo);
                cmb_subCentro_costo.DataSource = lstSubcentro_costo;

                lst_clase_prov = bus_clase_prov.Get_List_proveedor_clase(param.IdEmpresa);
                cmb_clase_prov_grid.DataSource = lst_clase_prov;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_tnConsultar_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnImprimir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnSalir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbSucursal_Grid_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBodega_Grid_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbBodega_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Convert.ToInt32(cmbBodega.EditValue) != 5000)
            //    {
            //        cmbProducto_Grid.DataSource = new List<tb_Bodega_Info>();
            //        cmbProducto_Grid.DataSource = lstProductoInfo.Where(q => q.IdBodega == Convert.ToInt32(cmbBodega.EditValue) || q.IdProducto == 0);
            //    }
            //}
            //catch (Exception ex)
            //{
                
            //    throw;
            //}
        }

        private void barEditItemTipoMovimiento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    in_movi_inven_tipo_Info infoMoviTipi = new in_movi_inven_tipo_Info();
                    infoMoviTipi.IdMovi_inven_tipo = 0;
                    infoMoviTipi.tm_descripcion = "Todos";

                    if ((string)barEditItemTipoMovimiento.EditValue == "(+)Ingresos")
                    {
                        lstMoviTipiInfo = busMoviTip.Get_list_movi_inven_tipo(param.IdEmpresa, "+");
                        lstMoviTipiInfo.Add(infoMoviTipi);
                        CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();

                    }
                    if ((string)barEditItemTipoMovimiento.EditValue == "Todos" || barEditItemTipoMovimiento.EditValue==null)
                    {
                        lstMoviTipiInfo = busMoviTip.Get_List_movi_inven_tipo(param.IdEmpresa);
                        lstMoviTipiInfo.Add(infoMoviTipi);
                        CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();
                    }
                    if ((string)barEditItemTipoMovimiento.EditValue == "(-)Egresos")
                    {
                        lstMoviTipiInfo = busMoviTip.Get_list_movi_inven_tipo(param.IdEmpresa, "-");
                        lstMoviTipiInfo.Add(infoMoviTipi);
                        CmbTipoMov_Grid.DataSource = lstMoviTipiInfo.OrderBy(q => q.IdMovi_inven_tipo).ToList();
                    }

                    
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void barEditItemCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ct_Centro_costo_Info Info = new ct_Centro_costo_Info();
                ct_centro_costo_sub_centro_costo_Info InfoSubcentro_costo = new ct_centro_costo_sub_centro_costo_Info();
                string centro_costo = (string)barEditItemCentroCosto.EditValue;

                InfoSubcentro_costo.IdCentroCosto_sub_centro_costo = "Todos";
                InfoSubcentro_costo.Centro_costo = "Todos";

                if (centro_costo == "Todos" || centro_costo == null)
                {

                    lstSubcentro_costo = busSubcentro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);

                    cmb_subCentro_costo.DataSource = lstSubcentro_costo;
                    lstSubcentro_costo.Add(InfoSubcentro_costo);
                    barEditItemCentroCosto.EditValue = centro_costo;
                    barEditItemSubCentroCosto.EditValue = "Todos";
                }
                else
                {
                    lstSubcentro_costo = busSubcentro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, centro_costo);
                    lstSubcentro_costo.Add(InfoSubcentro_costo);
                    cmb_subCentro_costo.DataSource = lstSubcentro_costo;
                    barEditItemSubCentroCosto.EditValue = "Todos";

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmbSucursal.EditValue) != 0)
                {
                    int idSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                    List<tb_Bodega_Info> Lista_bodega_temp = new List<tb_Bodega_Info>();
                    Lista_bodega_temp = lstBodegaInfo.Where(q => q.IdSucursal == idSucursal || q.IdBodega == 0).ToList();
                    cmbBodega_Grid.DataSource = null;
                    cmbBodega_Grid.DataSource = Lista_bodega_temp;
                }
                else
                    cmbBodega_Grid.DataSource = lstBodegaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void bei_clase_prov_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_clase_prov.EditValue == null)
                {
                    listProveedor = busProveedor.Get_List_proveedor(param.IdEmpresa);
                }
                else
                {
                    listProveedor = busProveedor.Get_List_proveedor_x_clase(param.IdEmpresa,Convert.ToInt32(bei_clase_prov.EditValue));
                }
                cmbProveedor_Grid.DataSource = listProveedor;   
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    

        
    }
}
