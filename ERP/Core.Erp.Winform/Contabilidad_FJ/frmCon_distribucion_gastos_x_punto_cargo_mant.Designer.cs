namespace Core.Erp.Winform.Contabilidad_FJ
{
    partial class frmCon_distribucion_gastos_x_punto_cargo_mant
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
            this.gridControl_punto_cargo = new DevExpress.XtraGrid.GridControl();
            this.gridView_punto_cargo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_check_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.de_fecha = new DevExpress.XtraEditors.DateEdit();
            this.txt_IdDistribucion = new DevExpress.XtraEditors.TextEdit();
            this.btn_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.ucCon_Periodo1 = new Core.Erp.Winform.Controles.UCCon_Periodo();
            this.txt_observacion = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl_saldo_cuentas = new DevExpress.XtraGrid.GridControl();
            this.gridView_saldo_cuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_check_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_distribuir = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir_saldo_cuentas = new System.Windows.Forms.ToolStripButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp_datos = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.chk_seleccionar_visibles_cuenta = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.chk_seleccionar_visibles_punto_cargo = new DevExpress.XtraEditors.CheckEdit();
            this.tp_distribucion = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_distribucion = new DevExpress.XtraGrid.GridControl();
            this.gridView_distribucion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.Contabilidad.frmCon_WaitForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_punto_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_punto_cargo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdDistribucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_saldo_cuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_saldo_cuentas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tp_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_seleccionar_visibles_cuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_seleccionar_visibles_punto_cargo.Properties)).BeginInit();
            this.tp_distribucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_distribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_distribucion)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_punto_cargo
            // 
            this.gridControl_punto_cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_punto_cargo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl_punto_cargo.Location = new System.Drawing.Point(2, 39);
            this.gridControl_punto_cargo.MainView = this.gridView_punto_cargo;
            this.gridControl_punto_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl_punto_cargo.Name = "gridControl_punto_cargo";
            this.gridControl_punto_cargo.Size = new System.Drawing.Size(611, 389);
            this.gridControl_punto_cargo.TabIndex = 0;
            this.gridControl_punto_cargo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_punto_cargo});
            // 
            // gridView_punto_cargo
            // 
            this.gridView_punto_cargo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.col_check_pc});
            this.gridView_punto_cargo.GridControl = this.gridControl_punto_cargo;
            this.gridView_punto_cargo.Name = "gridView_punto_cargo";
            this.gridView_punto_cargo.OptionsView.ShowAutoFilterRow = true;
            this.gridView_punto_cargo.OptionsView.ShowFooter = true;
            this.gridView_punto_cargo.OptionsView.ShowGroupPanel = false;
            this.gridView_punto_cargo.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_punto_cargo_CellValueChanged);
            this.gridView_punto_cargo.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_punto_cargo_CellValueChanging);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdPunto_cargo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 40;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Punto de cargo";
            this.gridColumn2.FieldName = "nom_punto_cargo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 343;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "%";
            this.gridColumn3.DisplayFormat.FormatString = "n2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "porcentaje";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "porcentaje", "{0:n2}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 60;
            // 
            // col_check_pc
            // 
            this.col_check_pc.Caption = "*";
            this.col_check_pc.FieldName = "Checked";
            this.col_check_pc.Name = "col_check_pc";
            this.col_check_pc.Visible = true;
            this.col_check_pc.VisibleIndex = 0;
            this.col_check_pc.Width = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.de_fecha);
            this.panel1.Controls.Add(this.txt_IdDistribucion);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.ucCon_Periodo1);
            this.panel1.Controls.Add(this.txt_observacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 105);
            this.panel1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 49);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Observación";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 16);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "# Distribución";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(471, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Fecha";
            // 
            // de_fecha
            // 
            this.de_fecha.EditValue = null;
            this.de_fecha.Location = new System.Drawing.Point(517, 12);
            this.de_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.de_fecha.Name = "de_fecha";
            this.de_fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_fecha.Size = new System.Drawing.Size(133, 22);
            this.de_fecha.TabIndex = 4;
            // 
            // txt_IdDistribucion
            // 
            this.txt_IdDistribucion.Location = new System.Drawing.Point(128, 12);
            this.txt_IdDistribucion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdDistribucion.Name = "txt_IdDistribucion";
            this.txt_IdDistribucion.Properties.ReadOnly = true;
            this.txt_IdDistribucion.Size = new System.Drawing.Size(133, 22);
            this.txt_IdDistribucion.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(1123, 16);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(116, 44);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // ucCon_Periodo1
            // 
            this.ucCon_Periodo1.Enabled_cmb_Periodo = true;
            this.ucCon_Periodo1.Enabled_de_Desde = true;
            this.ucCon_Periodo1.Enabled_de_Hasta = true;
            this.ucCon_Periodo1.Location = new System.Drawing.Point(659, 7);
            this.ucCon_Periodo1.Margin = new System.Windows.Forms.Padding(5);
            this.ucCon_Periodo1.Name = "ucCon_Periodo1";
            this.ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
            this.ucCon_Periodo1.ReadOnly_de_Desde = true;
            this.ucCon_Periodo1.ReadOnly_de_Hasta = true;
            this.ucCon_Periodo1.Size = new System.Drawing.Size(456, 69);
            this.ucCon_Periodo1.TabIndex = 0;
            this.ucCon_Periodo1.Visible_cmb_Periodo = true;
            this.ucCon_Periodo1.Visible_de_Desde = true;
            this.ucCon_Periodo1.Visible_de_Hasta = true;
            this.ucCon_Periodo1.Visible_lblDesde = true;
            this.ucCon_Periodo1.Visible_lblHasta = true;
            this.ucCon_Periodo1.Visible_lblPeriodo = true;
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(128, 46);
            this.txt_observacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(523, 44);
            this.txt_observacion.TabIndex = 3;
            // 
            // gridControl_saldo_cuentas
            // 
            this.gridControl_saldo_cuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_saldo_cuentas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl_saldo_cuentas.Location = new System.Drawing.Point(2, 39);
            this.gridControl_saldo_cuentas.MainView = this.gridView_saldo_cuentas;
            this.gridControl_saldo_cuentas.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl_saldo_cuentas.Name = "gridControl_saldo_cuentas";
            this.gridControl_saldo_cuentas.Size = new System.Drawing.Size(700, 389);
            this.gridControl_saldo_cuentas.TabIndex = 2;
            this.gridControl_saldo_cuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_saldo_cuentas});
            // 
            // gridView_saldo_cuentas
            // 
            this.gridView_saldo_cuentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.col_check_cuenta});
            this.gridView_saldo_cuentas.GridControl = this.gridControl_saldo_cuentas;
            this.gridView_saldo_cuentas.Name = "gridView_saldo_cuentas";
            this.gridView_saldo_cuentas.OptionsView.ShowAutoFilterRow = true;
            this.gridView_saldo_cuentas.OptionsView.ShowFooter = true;
            this.gridView_saldo_cuentas.OptionsView.ShowGroupPanel = false;
            this.gridView_saldo_cuentas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Código";
            this.gridColumn5.FieldName = "IdCtaCble";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 95;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cuenta";
            this.gridColumn6.FieldName = "pc_Cuenta";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 290;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Saldo";
            this.gridColumn7.DisplayFormat.FormatString = "n2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "valor";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor", "{0:n2}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 74;
            // 
            // col_check_cuenta
            // 
            this.col_check_cuenta.Caption = "*";
            this.col_check_cuenta.FieldName = "Checked";
            this.col_check_cuenta.Name = "col_check_cuenta";
            this.col_check_cuenta.Visible = true;
            this.col_check_cuenta.VisibleIndex = 0;
            this.col_check_cuenta.Width = 31;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1325, 36);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 3;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant1_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_distribuir,
            this.btn_imprimir_saldo_cuentas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 141);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1325, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_distribuir
            // 
            this.btn_distribuir.Image = global::Core.Erp.Winform.Properties.Resources.if_controls_chapter_next_103453;
            this.btn_distribuir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_distribuir.Name = "btn_distribuir";
            this.btn_distribuir.Size = new System.Drawing.Size(90, 24);
            this.btn_distribuir.Text = "Distribuir";
            this.btn_distribuir.Click += new System.EventHandler(this.btn_distribuir_Click);
            // 
            // btn_imprimir_saldo_cuentas
            // 
            this.btn_imprimir_saldo_cuentas.Image = global::Core.Erp.Winform.Properties.Resources.imprimir_32x32;
            this.btn_imprimir_saldo_cuentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir_saldo_cuentas.Name = "btn_imprimir_saldo_cuentas";
            this.btn_imprimir_saldo_cuentas.Size = new System.Drawing.Size(180, 24);
            this.btn_imprimir_saldo_cuentas.Text = "Imprimir saldo cuentas";
            this.btn_imprimir_saldo_cuentas.Click += new System.EventHandler(this.btn_imprimir_saldo_cuentas_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 168);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tp_datos;
            this.xtraTabControl1.Size = new System.Drawing.Size(1325, 461);
            this.xtraTabControl1.TabIndex = 5;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_datos,
            this.tp_distribucion});
            // 
            // tp_datos
            // 
            this.tp_datos.Controls.Add(this.panelControl2);
            this.tp_datos.Controls.Add(this.panelControl1);
            this.tp_datos.Margin = new System.Windows.Forms.Padding(4);
            this.tp_datos.Name = "tp_datos";
            this.tp_datos.Size = new System.Drawing.Size(1319, 430);
            this.tp_datos.Text = "Datos";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl_saldo_cuentas);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(704, 430);
            this.panelControl2.TabIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.chk_seleccionar_visibles_cuenta);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(700, 37);
            this.panelControl3.TabIndex = 3;
            // 
            // chk_seleccionar_visibles_cuenta
            // 
            this.chk_seleccionar_visibles_cuenta.Location = new System.Drawing.Point(11, 11);
            this.chk_seleccionar_visibles_cuenta.Name = "chk_seleccionar_visibles_cuenta";
            this.chk_seleccionar_visibles_cuenta.Properties.Caption = "Seleccionar visibles";
            this.chk_seleccionar_visibles_cuenta.Size = new System.Drawing.Size(151, 21);
            this.chk_seleccionar_visibles_cuenta.TabIndex = 0;
            this.chk_seleccionar_visibles_cuenta.CheckedChanged += new System.EventHandler(this.chk_seleccionar_visibles_cuenta_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl_punto_cargo);
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(704, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(615, 430);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.chk_seleccionar_visibles_punto_cargo);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(611, 37);
            this.panelControl4.TabIndex = 4;
            // 
            // chk_seleccionar_visibles_punto_cargo
            // 
            this.chk_seleccionar_visibles_punto_cargo.Location = new System.Drawing.Point(11, 11);
            this.chk_seleccionar_visibles_punto_cargo.Name = "chk_seleccionar_visibles_punto_cargo";
            this.chk_seleccionar_visibles_punto_cargo.Properties.Caption = "Seleccionar visibles";
            this.chk_seleccionar_visibles_punto_cargo.Size = new System.Drawing.Size(151, 21);
            this.chk_seleccionar_visibles_punto_cargo.TabIndex = 0;
            this.chk_seleccionar_visibles_punto_cargo.CheckedChanged += new System.EventHandler(this.chk_seleccionar_visibles_punto_cargo_CheckedChanged);
            // 
            // tp_distribucion
            // 
            this.tp_distribucion.Controls.Add(this.gridControl_distribucion);
            this.tp_distribucion.Margin = new System.Windows.Forms.Padding(4);
            this.tp_distribucion.Name = "tp_distribucion";
            this.tp_distribucion.Size = new System.Drawing.Size(1319, 430);
            this.tp_distribucion.Text = "Distribución";
            // 
            // gridControl_distribucion
            // 
            this.gridControl_distribucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_distribucion.Location = new System.Drawing.Point(0, 0);
            this.gridControl_distribucion.MainView = this.gridView_distribucion;
            this.gridControl_distribucion.Name = "gridControl_distribucion";
            this.gridControl_distribucion.Size = new System.Drawing.Size(1319, 430);
            this.gridControl_distribucion.TabIndex = 0;
            this.gridControl_distribucion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_distribucion});
            // 
            // gridView_distribucion
            // 
            this.gridView_distribucion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView_distribucion.GridControl = this.gridControl_distribucion;
            this.gridView_distribucion.Name = "gridView_distribucion";
            this.gridView_distribucion.OptionsBehavior.ReadOnly = true;
            this.gridView_distribucion.OptionsView.ShowAutoFilterRow = true;
            this.gridView_distribucion.OptionsView.ShowFooter = true;
            this.gridView_distribucion.OptionsView.ShowGroupPanel = false;
            this.gridView_distribucion.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_distribucion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_distribucion_KeyDown);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cuenta";
            this.gridColumn4.FieldName = "pc_Cuenta";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 477;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "IdCtaCble";
            this.gridColumn9.FieldName = "IdCtaCble";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 248;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Valor";
            this.gridColumn10.DisplayFormat.FormatString = "n2";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "valor";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 149;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Punto de cargo";
            this.gridColumn11.FieldName = "nom_punto_cargo";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 427;
            // 
            // frmCon_distribucion_gastos_x_punto_cargo_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 629);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCon_distribucion_gastos_x_punto_cargo_mant";
            this.Text = "frmCon_distribucion_gastos_x_punto_cargo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCon_distribucion_gastos_x_punto_cargo_mant_FormClosed);
            this.Load += new System.EventHandler(this.frmCon_distribucion_gastos_x_punto_cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_punto_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_punto_cargo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdDistribucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_saldo_cuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_saldo_cuentas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tp_datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk_seleccionar_visibles_cuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk_seleccionar_visibles_punto_cargo.Properties)).EndInit();
            this.tp_distribucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_distribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_distribucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_punto_cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_punto_cargo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_saldo_cuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_saldo_cuentas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn col_check_pc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn col_check_cuenta;
        private Controles.UCCon_Periodo ucCon_Periodo1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraEditors.SimpleButton btn_buscar;
        private DevExpress.XtraEditors.TextEdit txt_IdDistribucion;
        private DevExpress.XtraEditors.MemoEdit txt_observacion;
        private DevExpress.XtraEditors.DateEdit de_fecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_imprimir_saldo_cuentas;
        private System.Windows.Forms.ToolStripButton btn_distribuir;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tp_datos;
        private DevExpress.XtraTab.XtraTabPage tp_distribucion;
        private DevExpress.XtraGrid.GridControl gridControl_distribucion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_distribucion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.CheckEdit chk_seleccionar_visibles_cuenta;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.CheckEdit chk_seleccionar_visibles_punto_cargo;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}