using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;


namespace Core.Erp.Winform
{
    public partial class Form2 : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();

        List<fa_factura_Info> lst_factura = new List<fa_factura_Info>();
        fa_factura_Bus bus_factura = new fa_factura_Bus();
        fa_factura_det_Bus bus_factura_det = new fa_factura_det_Bus();
        BindingList<fa_factura_det_info> Detail = new BindingList<fa_factura_det_info>();

        BindingList<in_Producto_Info> lst_producto = new BindingList<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();
                            
        public Form2()
        {
            InitializeComponent();

        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void load_data()
        {
            try
            {
                lst_producto = new BindingList<in_Producto_Info>(bus_producto.Get_list_Producto(param.IdEmpresa));
                cmb_producto.DataSource = lst_producto;

                lst_factura = bus_factura.Get_List_factura(1, 0, 0, DateTime.Now.Date.AddMonths(-1), DateTime.Now.Date);
                gridControl_fac.DataSource = lst_factura;
                string msg = "";
                foreach (var item in lst_factura)
                {
                    item.DetFactura_List = bus_factura_det.Get_List_factura_det(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdCbteVta, ref msg);
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void gridView_fac_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            try
            {
                fa_factura_Info row = (fa_factura_Info)gridView_fac.GetRow(e.RowHandle);
                if (row != null)
                   e.ChildList = lst_factura.FirstOrDefault(q => q.IdEmpresa == row.IdEmpresa && q.IdSucursal == row.IdSucursal && q.IdBodega == row.IdBodega && q.IdCbteVta == row.IdCbteVta).DetFactura_List;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {            
            fa_factura_Info row = (fa_factura_Info)gridView_fac.GetFocusedRow();
            if (row!= null)
            {
                double suma = 0;

                foreach (var item in row.DetFactura_List)
                {
                    suma += item.vt_cantidad;
                }
                row.vt_NumFactura = suma.ToString("0000");
            }
            gridControl_fac.RefreshDataSource();
        }

        private void gridView_fac_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }

        private void gridView_fac_det_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            fa_factura_Info row = (fa_factura_Info)gridView_fac.GetFocusedRow();
            if (row != null)
            {
                double suma = 0;

                foreach (var item in row.DetFactura_List)
                {
                    suma += item.vt_cantidad;
                }
                row.vt_NumFactura = suma.ToString("0000");
            }
            gridControl_fac.RefreshDataSource();
        }

        private void gridView_fac_det_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void gridView_fac_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

    }
}

       

       

       
    

