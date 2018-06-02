namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_factura_det_x_fa_descuento
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
            this.btn_aceptar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.gridControl_descuento = new DevExpress.XtraGrid.GridControl();
            this.gridView_descuento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_descuento = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_de_valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_de_porcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_iva = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descuento = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_subtotal = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_producto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_aceptar,
            this.btn_cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Image = global::Core.Erp.Winform.Properties.Resources.check_16x16;
            this.btn_aceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(68, 22);
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::Core.Erp.Winform.Properties.Resources.Salir_16_x_16;
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(73, 22);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // gridControl_descuento
            // 
            this.gridControl_descuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_descuento.Location = new System.Drawing.Point(0, 102);
            this.gridControl_descuento.MainView = this.gridView_descuento;
            this.gridControl_descuento.Name = "gridControl_descuento";
            this.gridControl_descuento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_descuento});
            this.gridControl_descuento.Size = new System.Drawing.Size(851, 320);
            this.gridControl_descuento.TabIndex = 1;
            this.gridControl_descuento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_descuento});
            // 
            // gridView_descuento
            // 
            this.gridView_descuento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdDescuento,
            this.col_de_valor,
            this.col_de_porcentaje});
            this.gridView_descuento.GridControl = this.gridControl_descuento;
            this.gridView_descuento.Name = "gridView_descuento";
            this.gridView_descuento.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_descuento.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_descuento.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_descuento.OptionsView.ShowGroupPanel = false;
            this.gridView_descuento.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_descuento_CellValueChanged);
            this.gridView_descuento.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_descuento_CellValueChanging);
            this.gridView_descuento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_descuento_KeyDown);
            // 
            // col_IdDescuento
            // 
            this.col_IdDescuento.Caption = "Descuento";
            this.col_IdDescuento.ColumnEdit = this.cmb_descuento;
            this.col_IdDescuento.FieldName = "IdDescuento";
            this.col_IdDescuento.Name = "col_IdDescuento";
            this.col_IdDescuento.Visible = true;
            this.col_IdDescuento.VisibleIndex = 0;
            this.col_IdDescuento.Width = 525;
            // 
            // cmb_descuento
            // 
            this.cmb_descuento.AutoHeight = false;
            this.cmb_descuento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_descuento.DisplayMember = "de_nombre";
            this.cmb_descuento.Name = "cmb_descuento";
            this.cmb_descuento.ValueMember = "IdDescuento";
            this.cmb_descuento.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "IdDescuento";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 136;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Descuento";
            this.gridColumn5.FieldName = "de_nombre";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 910;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "%";
            this.gridColumn6.FieldName = "de_porcentaje";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 134;
            // 
            // col_de_valor
            // 
            this.col_de_valor.Caption = "Valor";
            this.col_de_valor.FieldName = "de_valor";
            this.col_de_valor.Name = "col_de_valor";
            this.col_de_valor.Visible = true;
            this.col_de_valor.VisibleIndex = 1;
            this.col_de_valor.Width = 151;
            // 
            // col_de_porcentaje
            // 
            this.col_de_porcentaje.Caption = "%";
            this.col_de_porcentaje.FieldName = "de_porcentaje";
            this.col_de_porcentaje.Name = "col_de_porcentaje";
            this.col_de_porcentaje.Visible = true;
            this.col_de_porcentaje.VisibleIndex = 2;
            this.col_de_porcentaje.Width = 152;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_iva);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_descuento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_subtotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Cantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_producto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 77);
            this.panel1.TabIndex = 2;
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(616, 43);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Properties.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(79, 20);
            this.txt_iva.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "I.V.A.";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(738, 43);
            this.txt_total.Name = "txt_total";
            this.txt_total.Properties.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(79, 20);
            this.txt_total.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(355, 43);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Properties.ReadOnly = true;
            this.txt_descuento.Size = new System.Drawing.Size(79, 20);
            this.txt_descuento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descuento";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(492, 43);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Properties.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(79, 20);
            this.txt_subtotal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subtotal";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(205, 43);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Properties.ReadOnly = true;
            this.txt_precio.Size = new System.Drawing.Size(79, 20);
            this.txt_precio.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(77, 43);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Properties.ReadOnly = true;
            this.txt_Cantidad.Size = new System.Drawing.Size(79, 20);
            this.txt_Cantidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // cmb_producto
            // 
            this.cmb_producto.Location = new System.Drawing.Point(77, 14);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_producto.Properties.DisplayMember = "pr_descripcion_2";
            this.cmb_producto.Properties.ReadOnly = true;
            this.cmb_producto.Properties.ValueMember = "IdProducto";
            this.cmb_producto.Properties.View = this.searchLookUpEdit1View;
            this.cmb_producto.Size = new System.Drawing.Size(357, 20);
            this.cmb_producto.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ID";
            this.gridColumn7.FieldName = "IdProducto";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 144;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Producto";
            this.gridColumn8.FieldName = "pr_descripcion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 466;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Código";
            this.gridColumn9.FieldName = "pr_codigo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 130;
            // 
            // frmFa_factura_det_x_fa_descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 422);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl_descuento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFa_factura_det_x_fa_descuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuento por detalle de factura";
            this.Load += new System.EventHandler(this.frmFa_factura_det_x_fa_descuento_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private DevExpress.XtraGrid.GridControl gridControl_descuento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_descuento;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdDescuento;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_descuento;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn col_de_valor;
        private DevExpress.XtraGrid.Columns.GridColumn col_de_porcentaje;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_producto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_Cantidad;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btn_aceptar;
        private DevExpress.XtraEditors.TextEdit txt_subtotal;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_descuento;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txt_total;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_iva;
        private System.Windows.Forms.Label label7;
    }
}