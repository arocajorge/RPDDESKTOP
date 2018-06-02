

namespace Cus.Erp.Reports.FJ.Roles
{
    partial class XROL_Rpt023_rpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.IdEmpresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdNomina = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdEmpleado = new DevExpress.XtraReports.Parameters.Parameter();
            this.anio = new DevExpress.XtraReports.Parameters.Parameter();
            this.mes = new DevExpress.XtraReports.Parameters.Parameter();
            this.bindingSourceEmpleado = new System.Windows.Forms.BindingSource();
            this.xrSubreportRol = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 39.62501F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportRol});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("NomCompleto", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 158.3333F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Description = "PIdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Type = typeof(int);
            this.IdEmpresa.Value = 0;
            // 
            // IdNomina
            // 
            this.IdNomina.Description = "PIdNomina_Tipo";
            this.IdNomina.Name = "IdNomina";
            this.IdNomina.Type = typeof(int);
            this.IdNomina.Value = 0;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.Description = "Id_Empleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Type = typeof(int);
            this.IdEmpleado.Value = 0;
            // 
            // anio
            // 
            this.anio.Name = "anio";
            this.anio.Type = typeof(int);
            this.anio.Visible = false;
            // 
            // mes
            // 
            this.mes.Name = "mes";
            this.mes.Type = typeof(int);
            this.mes.Visible = false;
            // 
            // bindingSourceEmpleado
            // 
            this.bindingSourceEmpleado.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Info);
            // 
            // xrSubreportRol
            // 
            this.xrSubreportRol.LocationFloat = new DevExpress.Utils.PointFloat(55.83334F, 10.00001F);
            this.xrSubreportRol.Name = "xrSubreportRol";
            this.xrSubreportRol.ReportSource = new Cus.Erp.Reports.FJ.Roles.XROL_Rpt022_rpt();
            this.xrSubreportRol.SizeF = new System.Drawing.SizeF(196.875F, 132.375F);
            this.xrSubreportRol.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreportRol_BeforePrint);
            // 
            // XROL_Rpt023_rpt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.DataSource = this.bindingSourceEmpleado;
            this.Margins = new System.Drawing.Printing.Margins(10, 10, 40, 0);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IdEmpresa,
            this.IdNomina,
            this.IdEmpleado,
            this.anio,
            this.mes});
            this.Version = "12.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XROL_Rpt012_rpt_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSourceEmpleado;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        public DevExpress.XtraReports.UI.XRSubreport xrSubreportRol;
        private DevExpress.XtraReports.Parameters.Parameter IdEmpresa;
        private DevExpress.XtraReports.Parameters.Parameter IdEmpleado;
        public DevExpress.XtraReports.Parameters.Parameter IdNomina;
        public DevExpress.XtraReports.Parameters.Parameter anio;
        public DevExpress.XtraReports.Parameters.Parameter mes;
    }
}
