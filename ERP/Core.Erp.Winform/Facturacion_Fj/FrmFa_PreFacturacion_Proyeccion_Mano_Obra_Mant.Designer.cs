namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class FrmFa_PreFacturacion_Proyeccion_Mano_Obra_Mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ucFa_CatalogosCmb1 = new Core.Erp.Winform.Controles.UCFa_CatalogosCmb();
            this.lblAnulado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.de_Fecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_IdPreFacturacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucCon_Periodo1 = new Core.Erp.Winform.Controles.UCCon_Periodo();
            this.txt_Observacion = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl_ProyeccionManoObra = new DevExpress.XtraGrid.GridControl();
            this.gridView_ProyeccionManoObra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_fu_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_valor_proyectado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ValorRealManoObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_iferenciaManoObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ValorModificadoManoObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdPreFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProyeccionManoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ProyeccionManoObra)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1224, 36);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.cmb_centro_costo);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.ucFa_CatalogosCmb1);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.de_Fecha);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txt_IdPreFacturacion);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.ucCon_Periodo1);
            this.panel1.Controls.Add(this.txt_Observacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 123);
            this.panel1.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(527, 44);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 16);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Centro de costo:";
            // 
            // cmb_centro_costo
            // 
            this.cmb_centro_costo.Location = new System.Drawing.Point(644, 44);
            this.cmb_centro_costo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_centro_costo.Name = "cmb_centro_costo";
            this.cmb_centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo.Properties.DisplayMember = "nom_Cliente";
            this.cmb_centro_costo.Properties.ReadOnly = true;
            this.cmb_centro_costo.Properties.ValueMember = "IdCentroCosto_cc";
            this.cmb_centro_costo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_centro_costo.Size = new System.Drawing.Size(561, 22);
            this.cmb_centro_costo.TabIndex = 23;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn32,
            this.gridColumn42});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "ID";
            this.gridColumn32.FieldName = "IdCentroCosto_cc";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 1;
            this.gridColumn32.Width = 102;
            // 
            // gridColumn42
            // 
            this.gridColumn42.Caption = "Cliente";
            this.gridColumn42.FieldName = "nom_Cliente";
            this.gridColumn42.Name = "gridColumn42";
            this.gridColumn42.Visible = true;
            this.gridColumn42.VisibleIndex = 0;
            this.gridColumn42.Width = 396;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(527, 12);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 16);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Estado:";
            // 
            // ucFa_CatalogosCmb1
            // 
            this.ucFa_CatalogosCmb1.Location = new System.Drawing.Point(644, 4);
            this.ucFa_CatalogosCmb1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucFa_CatalogosCmb1.Name = "ucFa_CatalogosCmb1";
            this.ucFa_CatalogosCmb1.Size = new System.Drawing.Size(279, 37);
            this.ucFa_CatalogosCmb1.TabIndex = 19;
            this.ucFa_CatalogosCmb1.Visible_cmb_Accion = false;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(331, 7);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(177, 24);
            this.lblAnulado.TabIndex = 18;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(35, 78);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 16);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Desde:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(35, 44);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 16);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Periodo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(973, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Fecha:";
            // 
            // de_Fecha
            // 
            this.de_Fecha.EditValue = new System.DateTime(2016, 4, 22, 12, 36, 16, 861);
            this.de_Fecha.Location = new System.Drawing.Point(1060, 9);
            this.de_Fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.de_Fecha.Name = "de_Fecha";
            this.de_Fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Fecha.Size = new System.Drawing.Size(145, 22);
            this.de_Fecha.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(535, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Observación:";
            // 
            // txt_IdPreFacturacion
            // 
            this.txt_IdPreFacturacion.Location = new System.Drawing.Point(165, 9);
            this.txt_IdPreFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_IdPreFacturacion.Name = "txt_IdPreFacturacion";
            this.txt_IdPreFacturacion.Properties.ReadOnly = true;
            this.txt_IdPreFacturacion.Size = new System.Drawing.Size(120, 22);
            this.txt_IdPreFacturacion.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "# Pre-facturación:";
            // 
            // ucCon_Periodo1
            // 
            this.ucCon_Periodo1.Enabled_cmb_Periodo = true;
            this.ucCon_Periodo1.Enabled_de_Desde = true;
            this.ucCon_Periodo1.Enabled_de_Hasta = true;
            this.ucCon_Periodo1.Location = new System.Drawing.Point(63, 37);
            this.ucCon_Periodo1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucCon_Periodo1.Name = "ucCon_Periodo1";
            this.ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
            this.ucCon_Periodo1.ReadOnly_de_Desde = true;
            this.ucCon_Periodo1.ReadOnly_de_Hasta = true;
            this.ucCon_Periodo1.Size = new System.Drawing.Size(456, 69);
            this.ucCon_Periodo1.TabIndex = 9;
            this.ucCon_Periodo1.Visible_cmb_Periodo = true;
            this.ucCon_Periodo1.Visible_de_Desde = true;
            this.ucCon_Periodo1.Visible_de_Hasta = true;
            this.ucCon_Periodo1.Visible_lblDesde = false;
            this.ucCon_Periodo1.Visible_lblHasta = true;
            this.ucCon_Periodo1.Visible_lblPeriodo = false;
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(644, 73);
            this.txt_Observacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(561, 46);
            this.txt_Observacion.TabIndex = 12;
            // 
            // gridControl_ProyeccionManoObra
            // 
            this.gridControl_ProyeccionManoObra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ProyeccionManoObra.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_ProyeccionManoObra.Location = new System.Drawing.Point(0, 159);
            this.gridControl_ProyeccionManoObra.MainView = this.gridView_ProyeccionManoObra;
            this.gridControl_ProyeccionManoObra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_ProyeccionManoObra.Name = "gridControl_ProyeccionManoObra";
            this.gridControl_ProyeccionManoObra.Size = new System.Drawing.Size(1224, 403);
            this.gridControl_ProyeccionManoObra.TabIndex = 5;
            this.gridControl_ProyeccionManoObra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ProyeccionManoObra});
            // 
            // gridView_ProyeccionManoObra
            // 
            this.gridView_ProyeccionManoObra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_fu_descripcion,
            this.col_ca_descripcion,
            this.Col_valor_proyectado,
            this.Col_ValorRealManoObra,
            this.Col_iferenciaManoObra,
            this.Col_ValorModificadoManoObra});
            this.gridView_ProyeccionManoObra.GridControl = this.gridControl_ProyeccionManoObra;
            this.gridView_ProyeccionManoObra.GroupCount = 1;
            this.gridView_ProyeccionManoObra.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_proyectado", this.Col_valor_proyectado, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorRealManoObra", this.Col_ValorRealManoObra, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiferenciaManoObra", this.Col_iferenciaManoObra, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorModificadoManoObra", this.Col_ValorModificadoManoObra, "{0:n2}")});
            this.gridView_ProyeccionManoObra.Name = "gridView_ProyeccionManoObra";
            this.gridView_ProyeccionManoObra.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView_ProyeccionManoObra.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_ProyeccionManoObra.OptionsView.ShowFooter = true;
            this.gridView_ProyeccionManoObra.OptionsView.ShowGroupedColumns = true;
            this.gridView_ProyeccionManoObra.OptionsView.ShowGroupPanel = false;
            this.gridView_ProyeccionManoObra.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Col_fu_descripcion, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_ProyeccionManoObra.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_ProyeccionManoObra_CellValueChanged);
            // 
            // Col_fu_descripcion
            // 
            this.Col_fu_descripcion.Caption = "Fuerza";
            this.Col_fu_descripcion.FieldName = "fu_descripcion";
            this.Col_fu_descripcion.Name = "Col_fu_descripcion";
            this.Col_fu_descripcion.OptionsFilter.AllowAutoFilter = false;
            this.Col_fu_descripcion.Visible = true;
            this.Col_fu_descripcion.VisibleIndex = 0;
            this.Col_fu_descripcion.Width = 149;
            // 
            // col_ca_descripcion
            // 
            this.col_ca_descripcion.Caption = "Cargo";
            this.col_ca_descripcion.FieldName = "ca_descripcion";
            this.col_ca_descripcion.Name = "col_ca_descripcion";
            this.col_ca_descripcion.OptionsFilter.AllowAutoFilter = false;
            this.col_ca_descripcion.Visible = true;
            this.col_ca_descripcion.VisibleIndex = 1;
            this.col_ca_descripcion.Width = 202;
            // 
            // Col_valor_proyectado
            // 
            this.Col_valor_proyectado.Caption = "Proyeción mano obra";
            this.Col_valor_proyectado.DisplayFormat.FormatString = "n2";
            this.Col_valor_proyectado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_valor_proyectado.FieldName = "valor_proyectado";
            this.Col_valor_proyectado.Name = "Col_valor_proyectado";
            this.Col_valor_proyectado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_proyectado", "{0:n2}")});
            this.Col_valor_proyectado.Visible = true;
            this.Col_valor_proyectado.VisibleIndex = 4;
            this.Col_valor_proyectado.Width = 115;
            // 
            // Col_ValorRealManoObra
            // 
            this.Col_ValorRealManoObra.Caption = "Valor real mano obra";
            this.Col_ValorRealManoObra.DisplayFormat.FormatString = "n2";
            this.Col_ValorRealManoObra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_ValorRealManoObra.FieldName = "ValorRealManoObra";
            this.Col_ValorRealManoObra.Name = "Col_ValorRealManoObra";
            this.Col_ValorRealManoObra.OptionsFilter.AllowAutoFilter = false;
            this.Col_ValorRealManoObra.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorRealManoObra", "{0:n2}")});
            this.Col_ValorRealManoObra.Visible = true;
            this.Col_ValorRealManoObra.VisibleIndex = 2;
            this.Col_ValorRealManoObra.Width = 113;
            // 
            // Col_iferenciaManoObra
            // 
            this.Col_iferenciaManoObra.Caption = "Diferencia";
            this.Col_iferenciaManoObra.DisplayFormat.FormatString = "n2";
            this.Col_iferenciaManoObra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_iferenciaManoObra.FieldName = "DiferenciaManoObra";
            this.Col_iferenciaManoObra.Name = "Col_iferenciaManoObra";
            this.Col_iferenciaManoObra.OptionsFilter.AllowAutoFilter = false;
            this.Col_iferenciaManoObra.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiferenciaManoObra", "{0:n2}")});
            this.Col_iferenciaManoObra.Visible = true;
            this.Col_iferenciaManoObra.VisibleIndex = 5;
            this.Col_iferenciaManoObra.Width = 168;
            // 
            // Col_ValorModificadoManoObra
            // 
            this.Col_ValorModificadoManoObra.Caption = "Valor mano obra (Modificado)";
            this.Col_ValorModificadoManoObra.DisplayFormat.FormatString = "n2";
            this.Col_ValorModificadoManoObra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_ValorModificadoManoObra.FieldName = "ValorModificadoManoObra";
            this.Col_ValorModificadoManoObra.Name = "Col_ValorModificadoManoObra";
            this.Col_ValorModificadoManoObra.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorModificadoManoObra", "{0:n2}")});
            this.Col_ValorModificadoManoObra.Visible = true;
            this.Col_ValorModificadoManoObra.VisibleIndex = 3;
            this.Col_ValorModificadoManoObra.Width = 153;
            // 
            // FrmFa_PreFacturacion_Proyeccion_Mano_Obra_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 562);
            this.Controls.Add(this.gridControl_ProyeccionManoObra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFa_PreFacturacion_Proyeccion_Mano_Obra_Mant";
            this.Text = "FrmFa_PreFacturacion_Proyeccion_Mano_Obra_Mant";
            this.Load += new System.EventHandler(this.FrmFa_PreFacturacion_Proyeccion_Mano_Obra_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdPreFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ProyeccionManoObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ProyeccionManoObra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Controles.UCFa_CatalogosCmb ucFa_CatalogosCmb1;
        private DevExpress.XtraEditors.LabelControl lblAnulado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit de_Fecha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_IdPreFacturacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Controles.UCCon_Periodo ucCon_Periodo1;
        private DevExpress.XtraEditors.MemoEdit txt_Observacion;
        private DevExpress.XtraGrid.GridControl gridControl_ProyeccionManoObra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ProyeccionManoObra;
        private DevExpress.XtraGrid.Columns.GridColumn Col_fu_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_ca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_valor_proyectado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ValorRealManoObra;
        private DevExpress.XtraGrid.Columns.GridColumn Col_iferenciaManoObra;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ValorModificadoManoObra;
    }
}