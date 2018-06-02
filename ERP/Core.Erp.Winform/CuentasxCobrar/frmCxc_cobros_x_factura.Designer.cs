namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_cobros_x_factura
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_saldo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_total = new DevExpress.XtraEditors.TextEdit();
            this.txt_valor_iva = new DevExpress.XtraEditors.TextEdit();
            this.txt_subtotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_num_factura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gridControl_cobros = new DevExpress.XtraGrid.GridControl();
            this.gridView_cobros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_tipo_cobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_cobro_tipo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_banco = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_saldo_anterior = new DevExpress.XtraEditors.TextEdit();
            this.de_fecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_saldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_iva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_factura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cobro_tipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_saldo_anterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.de_fecha);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txt_saldo_anterior);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_saldo);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txt_total);
            this.panelControl1.Controls.Add(this.txt_valor_iva);
            this.panelControl1.Controls.Add(this.txt_subtotal);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txt_num_factura);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(940, 108);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(649, 73);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Saldo";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(747, 70);
            this.txt_saldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Properties.DisplayFormat.FormatString = "n2";
            this.txt_saldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_saldo.Properties.ReadOnly = true;
            this.txt_saldo.Size = new System.Drawing.Size(181, 22);
            this.txt_saldo.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(352, 73);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Total";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(352, 45);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "I.V.A.";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(441, 70);
            this.txt_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Properties.DisplayFormat.FormatString = "n2";
            this.txt_total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_total.Properties.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(181, 22);
            this.txt_total.TabIndex = 5;
            // 
            // txt_valor_iva
            // 
            this.txt_valor_iva.Location = new System.Drawing.Point(441, 43);
            this.txt_valor_iva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valor_iva.Name = "txt_valor_iva";
            this.txt_valor_iva.Properties.DisplayFormat.FormatString = "n2";
            this.txt_valor_iva.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_valor_iva.Properties.ReadOnly = true;
            this.txt_valor_iva.Size = new System.Drawing.Size(181, 22);
            this.txt_valor_iva.TabIndex = 4;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(112, 70);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Properties.DisplayFormat.FormatString = "n2";
            this.txt_subtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_subtotal.Properties.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(181, 22);
            this.txt_subtotal.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 73);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Subtotal";
            // 
            // txt_num_factura
            // 
            this.txt_num_factura.Location = new System.Drawing.Point(112, 43);
            this.txt_num_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num_factura.Name = "txt_num_factura";
            this.txt_num_factura.Properties.ReadOnly = true;
            this.txt_num_factura.Size = new System.Drawing.Size(181, 22);
            this.txt_num_factura.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 45);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "# Factura";
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(940, 30);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 1;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // gridControl_cobros
            // 
            this.gridControl_cobros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_cobros.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_cobros.Location = new System.Drawing.Point(0, 138);
            this.gridControl_cobros.MainView = this.gridView_cobros;
            this.gridControl_cobros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_cobros.Name = "gridControl_cobros";
            this.gridControl_cobros.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_banco,
            this.cmb_cobro_tipo});
            this.gridControl_cobros.Size = new System.Drawing.Size(940, 466);
            this.gridControl_cobros.TabIndex = 2;
            this.gridControl_cobros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_cobros});
            // 
            // gridView_cobros
            // 
            this.gridView_cobros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_tipo_cobro,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.col_valor});
            this.gridView_cobros.GridControl = this.gridControl_cobros;
            this.gridView_cobros.Name = "gridView_cobros";
            this.gridView_cobros.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_cobros.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_cobros.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_cobros.OptionsView.ShowDetailButtons = false;
            this.gridView_cobros.OptionsView.ShowFooter = true;
            this.gridView_cobros.OptionsView.ShowGroupPanel = false;
            this.gridView_cobros.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_cobros_CellValueChanged);
            this.gridView_cobros.RowCountChanged += new System.EventHandler(this.gridView_cobros_RowCountChanged);
            // 
            // col_tipo_cobro
            // 
            this.col_tipo_cobro.Caption = "Cobro";
            this.col_tipo_cobro.ColumnEdit = this.cmb_cobro_tipo;
            this.col_tipo_cobro.FieldName = "IdCobro_tipo";
            this.col_tipo_cobro.Name = "col_tipo_cobro";
            this.col_tipo_cobro.Visible = true;
            this.col_tipo_cobro.VisibleIndex = 0;
            // 
            // cmb_cobro_tipo
            // 
            this.cmb_cobro_tipo.AutoHeight = false;
            this.cmb_cobro_tipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cobro_tipo.DisplayMember = "tc_descripcion";
            this.cmb_cobro_tipo.Name = "cmb_cobro_tipo";
            this.cmb_cobro_tipo.ValueMember = "IdCobro_tipo";
            this.cmb_cobro_tipo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tipo de cobro";
            this.gridColumn6.FieldName = "tc_descripcion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 691;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ID";
            this.gridColumn7.FieldName = "IdCobro_tipo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 213;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Banco";
            this.gridColumn2.ColumnEdit = this.cmb_banco;
            this.gridColumn2.FieldName = "IdBanco";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // cmb_banco
            // 
            this.cmb_banco.AutoHeight = false;
            this.cmb_banco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_banco.DisplayMember = "ba_descripcion";
            this.cmb_banco.Name = "cmb_banco";
            this.cmb_banco.ValueMember = "IdBanco";
            this.cmb_banco.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Banco";
            this.gridColumn8.FieldName = "ba_descripcion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 748;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "ID";
            this.gridColumn9.FieldName = "IdBanco";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 156;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cuenta";
            this.gridColumn3.FieldName = "cr_cuenta";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "# Documento";
            this.gridColumn4.FieldName = "cr_NumDocumento";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // col_valor
            // 
            this.col_valor.Caption = "Valor";
            this.col_valor.FieldName = "dc_ValorPago";
            this.col_valor.Name = "col_valor";
            this.col_valor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dc_ValorPago", "{0:n2}")});
            this.col_valor.Visible = true;
            this.col_valor.VisibleIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(649, 45);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Saldo anterior";
            // 
            // txt_saldo_anterior
            // 
            this.txt_saldo_anterior.Location = new System.Drawing.Point(747, 42);
            this.txt_saldo_anterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_saldo_anterior.Name = "txt_saldo_anterior";
            this.txt_saldo_anterior.Properties.DisplayFormat.FormatString = "n2";
            this.txt_saldo_anterior.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_saldo_anterior.Properties.ReadOnly = true;
            this.txt_saldo_anterior.Size = new System.Drawing.Size(181, 22);
            this.txt_saldo_anterior.TabIndex = 10;
            // 
            // de_fecha
            // 
            this.de_fecha.EditValue = null;
            this.de_fecha.Location = new System.Drawing.Point(747, 8);
            this.de_fecha.Name = "de_fecha";
            this.de_fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_fecha.Size = new System.Drawing.Size(181, 22);
            this.de_fecha.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(649, 11);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 16);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Fecha";
            // 
            // frmCxc_cobros_x_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 604);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl_cobros);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCxc_cobros_x_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros por factura";
            this.Load += new System.EventHandler(this.frmCxc_cobros_x_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_saldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_iva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_factura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_cobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cobro_tipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_saldo_anterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraGrid.GridControl gridControl_cobros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_cobros;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_total;
        private DevExpress.XtraEditors.TextEdit txt_valor_iva;
        private DevExpress.XtraEditors.TextEdit txt_subtotal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_num_factura;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo_cobro;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_cobro_tipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_banco;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn col_valor;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_saldo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_saldo_anterior;
        private DevExpress.XtraEditors.DateEdit de_fecha;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}