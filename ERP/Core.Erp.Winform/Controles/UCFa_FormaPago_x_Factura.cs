using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_FormaPago_x_Factura : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        BindingList<fa_formaPago_Info> listaFormaPago = new BindingList<fa_formaPago_Info>();
        fa_formaPago_Bus BusFP = new fa_formaPago_Bus();
        fa_factura_x_formaPago_Bus BusFac_x_for = new fa_factura_x_formaPago_Bus();
        List<fa_factura_x_formaPago_Info> list_fact_x_for = new List<fa_factura_x_formaPago_Info>();

        int IdEmpresa=0;
        int IdSucursal=0;
        int IdBodega=0;
        decimal IdCbteVta = 0;

        public UCFa_FormaPago_x_Factura()
        {
            InitializeComponent();
        }


      public void Cargar_grid()
        {
            try
            {
                listaFormaPago = new BindingList<fa_formaPago_Info>(BusFP.Get_List_fa_formaPago());
                gridControlFormaPago.DataSource = listaFormaPago;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


       public List<fa_factura_x_formaPago_Info> Get_List_factura_x_formaPago()
       {
           try
           {
               list_fact_x_for = new List<fa_factura_x_formaPago_Info>();
               foreach (var item2 in listaFormaPago.Where(q => q.Cheked == true).ToList())
               {
                   fa_factura_x_formaPago_Info info = new fa_factura_x_formaPago_Info();

                   info.IdFormaPago = item2.IdFormaPago;
                   info.IdEmpresa = IdEmpresa;
                   info.IdSucursal = IdSucursal;
                   info.IdBodega = IdBodega;
                   info.IdCbteVta = IdCbteVta;
                   info.observacion = "";

                   list_fact_x_for.Add(info);
               }


               return list_fact_x_for;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               return list_fact_x_for;
           }
       }

       public void set_forma_pago(string IdFormaPago)
       {
           try
           {
               foreach (var item in listaFormaPago)
               {
                   item.Cheked = false;
               }

               if (!string.IsNullOrEmpty(IdFormaPago))
                   if (listaFormaPago.FirstOrDefault(q=>q.IdFormaPago == IdFormaPago) != null)
                   {
                       listaFormaPago.FirstOrDefault(q => q.IdFormaPago == IdFormaPago).Cheked = true;
                   }

               gridControlFormaPago.DataSource = null;
               gridControlFormaPago.DataSource = listaFormaPago;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           }
       }

      public void Cargar_grid_x_Factura(int _IdEmpresa,int _IdSucursal,int _IdBodega,decimal _IdCbteVta )
      {
          try
          {

              IdEmpresa = _IdEmpresa;
              IdSucursal = _IdSucursal;
              IdBodega = _IdBodega;
              IdCbteVta = _IdCbteVta;

              list_fact_x_for = BusFac_x_for.Get_List_fa_factura_x_formaPago(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
              if (listaFormaPago.Count() == 0) { Cargar_grid(); }

              foreach (var item in list_fact_x_for)
              {
                  foreach (var item2 in listaFormaPago)
                  {
                      if (item.IdFormaPago == item2.IdFormaPago)
                      { item2.Cheked = true; }
                  }
              }
              gridControlFormaPago.DataSource = null;
              gridControlFormaPago.DataSource = listaFormaPago;
              gridControlFormaPago.RefreshDataSource();
          }
          catch (Exception ex)
          {
              string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
              MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
          }
      }

      private void UCFa_FormaPago_x_Factura_Load(object sender, EventArgs e)
      {
        
      }

      private void gridViewFormaPago_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
      {
          try
          {

          }
          catch (Exception ex)
          {
              string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
              MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
          }
      }

      private void gridViewFormaPago_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
      {
          try
          {
              if (e.Column == colCheck)
              {
                  if ((e.Value == null ? false : Convert.ToBoolean(e.Value)) == true)
                  {
                      foreach (var item in listaFormaPago)
                      {
                          item.Cheked = false;
                      }
                      gridControlFormaPago.DataSource = null;
                      gridControlFormaPago.DataSource = listaFormaPago;
                      gridControlFormaPago.RefreshDataSource();

                      gridViewFormaPago.SetRowCellValue(e.RowHandle, colCheck, true);
                  }
              }
          }
          catch (Exception ex)
          {
              string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
              MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
          }
      }


    }
}
