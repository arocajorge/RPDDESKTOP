using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Inventario;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_RptCodigo_Barra : DevExpress.XtraReports.UI.XtraReport
    {
       

        public List<in_Producto_Info> lst_producto { get; set; }
        public XINV_RptCodigo_Barra()
        {
            InitializeComponent();
        }

        private void XINV_RptCodigo_Barra_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.DataSource = lst_producto;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
