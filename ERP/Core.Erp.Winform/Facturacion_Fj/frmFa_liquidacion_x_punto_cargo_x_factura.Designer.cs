namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmFa_liquidacion_x_punto_cargo_x_factura
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.gridControl_facturas = new DevExpress.XtraGrid.GridControl();
            this.gridView_facturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_facturas = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_cod_liquidacion = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_cod_liquidacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1167, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Core.Erp.Winform.Properties.Resources.guardar_32x32;
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(82, 24);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.Salir_16x16;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(58, 24);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // gridControl_facturas
            // 
            this.gridControl_facturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_facturas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl_facturas.Location = new System.Drawing.Point(0, 92);
            this.gridControl_facturas.MainView = this.gridView_facturas;
            this.gridControl_facturas.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl_facturas.Name = "gridControl_facturas";
            this.gridControl_facturas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_facturas});
            this.gridControl_facturas.Size = new System.Drawing.Size(1167, 490);
            this.gridControl_facturas.TabIndex = 1;
            this.gridControl_facturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_facturas});
            // 
            // gridView_facturas
            // 
            this.gridView_facturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_factura,
            this.col_subtotal,
            this.col_iva,
            this.col_total});
            this.gridView_facturas.GridControl = this.gridControl_facturas;
            this.gridView_facturas.Name = "gridView_facturas";
            this.gridView_facturas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_facturas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_facturas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_facturas.OptionsView.ShowFooter = true;
            this.gridView_facturas.OptionsView.ShowGroupPanel = false;
            this.gridView_facturas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_facturas_CellValueChanged);
            this.gridView_facturas.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_facturas_CellValueChanging);
            this.gridView_facturas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_facturas_KeyDown);
            // 
            // col_factura
            // 
            this.col_factura.Caption = "Factura";
            this.col_factura.ColumnEdit = this.cmb_facturas;
            this.col_factura.FieldName = "ID";
            this.col_factura.Name = "col_factura";
            this.col_factura.Visible = true;
            this.col_factura.VisibleIndex = 0;
            this.col_factura.Width = 278;
            // 
            // cmb_facturas
            // 
            this.cmb_facturas.AutoHeight = false;
            this.cmb_facturas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_facturas.DisplayMember = "vt_NumFactura";
            this.cmb_facturas.Name = "cmb_facturas";
            this.cmb_facturas.ValueMember = "ID";
            this.cmb_facturas.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Factura";
            this.gridColumn5.FieldName = "vt_NumFactura";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 625;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Subtotal";
            this.gridColumn6.FieldName = "vta_subtotal";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 206;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Iva";
            this.gridColumn7.FieldName = "vta_iva";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 188;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Total";
            this.gridColumn8.FieldName = "vta_total";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 203;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Referencia";
            this.gridColumn9.FieldName = "descripcion_fact";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Width = 754;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "OC";
            this.gridColumn10.FieldName = "num_oc";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 512;
            // 
            // col_subtotal
            // 
            this.col_subtotal.Caption = "Subtotal";
            this.col_subtotal.DisplayFormat.FormatString = "n2";
            this.col_subtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_subtotal.FieldName = "vta_subtotal";
            this.col_subtotal.Name = "col_subtotal";
            this.col_subtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vt_subtotal", "{0:n2}")});
            this.col_subtotal.Visible = true;
            this.col_subtotal.VisibleIndex = 1;
            this.col_subtotal.Width = 192;
            // 
            // col_iva
            // 
            this.col_iva.Caption = "Iva";
            this.col_iva.DisplayFormat.FormatString = "n2";
            this.col_iva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_iva.FieldName = "vta_iva";
            this.col_iva.Name = "col_iva";
            this.col_iva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vt_iva", "{0:n2}")});
            this.col_iva.Visible = true;
            this.col_iva.VisibleIndex = 2;
            this.col_iva.Width = 192;
            // 
            // col_total
            // 
            this.col_total.Caption = "Total";
            this.col_total.DisplayFormat.FormatString = "n2";
            this.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_total.FieldName = "vta_total";
            this.col_total.Name = "col_total";
            this.col_total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vt_total", "{0:n2}")});
            this.col_total.Visible = true;
            this.col_total.VisibleIndex = 3;
            this.col_total.Width = 195;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_cod_liquidacion);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 27);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1167, 65);
            this.panelControl1.TabIndex = 2;
            // 
            // lbl_cod_liquidacion
            // 
            this.lbl_cod_liquidacion.Location = new System.Drawing.Point(19, 14);
            this.lbl_cod_liquidacion.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_cod_liquidacion.Name = "lbl_cod_liquidacion";
            this.lbl_cod_liquidacion.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_liquidacion.Properties.Appearance.Options.UseFont = true;
            this.lbl_cod_liquidacion.Properties.ReadOnly = true;
            this.lbl_cod_liquidacion.Size = new System.Drawing.Size(335, 38);
            this.lbl_cod_liquidacion.TabIndex = 2;
            // 
            // frmFa_liquidacion_x_punto_cargo_x_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 582);
            this.Controls.Add(this.gridControl_facturas);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFa_liquidacion_x_punto_cargo_x_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas por liquidacion";
            this.Load += new System.EventHandler(this.frmFa_liquidacion_x_punto_cargo_x_factura_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_cod_liquidacion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private DevExpress.XtraGrid.GridControl gridControl_facturas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_facturas;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_factura;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_facturas;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn col_subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn col_iva;
        private DevExpress.XtraGrid.Columns.GridColumn col_total;
        private DevExpress.XtraEditors.TextEdit lbl_cod_liquidacion;
    }
}