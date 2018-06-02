namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmfa_pre_facturacion_servisndustria_Mant
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
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_estado_cierre = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl_gastos = new DevExpress.XtraGrid.GridControl();
            this.gridView_gastos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_pe_apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_cedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_salario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_HorasExtras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_TotalIngresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_total_mas_beneficios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_TotalMo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subcentro = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_imprimir_grilla = new System.Windows.Forms.ToolStripButton();
            this.Col_Af_DescripcionCorta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado_cierre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdPreFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1103, 30);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
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
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_estado_cierre);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.cmb_centro_costo);
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
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 100);
            this.panel1.TabIndex = 3;
            // 
            // chk_estado_cierre
            // 
            this.chk_estado_cierre.Location = new System.Drawing.Point(481, 9);
            this.chk_estado_cierre.Name = "chk_estado_cierre";
            this.chk_estado_cierre.Properties.Caption = "Cerrado";
            this.chk_estado_cierre.Size = new System.Drawing.Size(150, 19);
            this.chk_estado_cierre.TabIndex = 26;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(395, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 13);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Centro de costo:";
            // 
            // cmb_centro_costo
            // 
            this.cmb_centro_costo.Location = new System.Drawing.Point(483, 33);
            this.cmb_centro_costo.Name = "cmb_centro_costo";
            this.cmb_centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo.Properties.DisplayMember = "nom_Cliente";
            this.cmb_centro_costo.Properties.ReadOnly = true;
            this.cmb_centro_costo.Properties.ValueMember = "IdCentroCosto_cc";
            this.cmb_centro_costo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_centro_costo.Size = new System.Drawing.Size(522, 20);
            this.cmb_centro_costo.TabIndex = 23;
            this.cmb_centro_costo.EditValueChanged += new System.EventHandler(this.cmb_centro_costo_EditValueChanged);
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
            // lblAnulado
            // 
            this.lblAnulado.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(284, 7);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(141, 19);
            this.lblAnulado.TabIndex = 18;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(26, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Desde:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Periodo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(831, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Fecha:";
            // 
            // de_Fecha
            // 
            this.de_Fecha.EditValue = new System.DateTime(2016, 4, 22, 12, 36, 16, 861);
            this.de_Fecha.Location = new System.Drawing.Point(896, 6);
            this.de_Fecha.Name = "de_Fecha";
            this.de_Fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Fecha.Size = new System.Drawing.Size(109, 20);
            this.de_Fecha.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(396, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Observación:";
            // 
            // txt_IdPreFacturacion
            // 
            this.txt_IdPreFacturacion.Location = new System.Drawing.Point(124, 7);
            this.txt_IdPreFacturacion.Name = "txt_IdPreFacturacion";
            this.txt_IdPreFacturacion.Properties.ReadOnly = true;
            this.txt_IdPreFacturacion.Size = new System.Drawing.Size(90, 20);
            this.txt_IdPreFacturacion.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "# Pre-facturación:";
            // 
            // ucCon_Periodo1
            // 
            this.ucCon_Periodo1.Enabled_cmb_Periodo = true;
            this.ucCon_Periodo1.Enabled_de_Desde = true;
            this.ucCon_Periodo1.Enabled_de_Hasta = true;
            this.ucCon_Periodo1.Location = new System.Drawing.Point(47, 30);
            this.ucCon_Periodo1.Margin = new System.Windows.Forms.Padding(4);
            this.ucCon_Periodo1.Name = "ucCon_Periodo1";
            this.ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
            this.ucCon_Periodo1.ReadOnly_de_Desde = true;
            this.ucCon_Periodo1.ReadOnly_de_Hasta = true;
            this.ucCon_Periodo1.Size = new System.Drawing.Size(342, 56);
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
            this.txt_Observacion.Location = new System.Drawing.Point(483, 63);
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(522, 33);
            this.txt_Observacion.TabIndex = 12;
            // 
            // gridControl_gastos
            // 
            this.gridControl_gastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_gastos.Location = new System.Drawing.Point(0, 155);
            this.gridControl_gastos.MainView = this.gridView_gastos;
            this.gridControl_gastos.Name = "gridControl_gastos";
            this.gridControl_gastos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_subcentro});
            this.gridControl_gastos.Size = new System.Drawing.Size(1103, 234);
            this.gridControl_gastos.TabIndex = 4;
            this.gridControl_gastos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_gastos});
            // 
            // gridView_gastos
            // 
            this.gridView_gastos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_pe_apellido,
            this.Col_cedula,
            this.Col_cargo,
            this.Col_salario,
            this.Col_HorasExtras,
            this.Col_TotalIngresos,
            this.Col_total_mas_beneficios,
            this.Col_TotalMo,
            this.Col_Af_DescripcionCorta});
            this.gridView_gastos.GridControl = this.gridControl_gastos;
            this.gridView_gastos.GroupFormat = "[#image]{1} {2}";
            this.gridView_gastos.Name = "gridView_gastos";
            this.gridView_gastos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView_gastos.OptionsView.ShowAutoFilterRow = true;
            this.gridView_gastos.OptionsView.ShowFooter = true;
            this.gridView_gastos.OptionsView.ShowGroupPanel = false;
            // 
            // Col_pe_apellido
            // 
            this.Col_pe_apellido.Caption = "NOMBRES";
            this.Col_pe_apellido.FieldName = "pe_apellido";
            this.Col_pe_apellido.Name = "Col_pe_apellido";
            this.Col_pe_apellido.Visible = true;
            this.Col_pe_apellido.VisibleIndex = 1;
            this.Col_pe_apellido.Width = 256;
            // 
            // Col_cedula
            // 
            this.Col_cedula.Caption = "CEDULA";
            this.Col_cedula.FieldName = "pe_cedulaRuc";
            this.Col_cedula.Name = "Col_cedula";
            this.Col_cedula.Visible = true;
            this.Col_cedula.VisibleIndex = 2;
            this.Col_cedula.Width = 90;
            // 
            // Col_cargo
            // 
            this.Col_cargo.Caption = "CARGO";
            this.Col_cargo.FieldName = "ca_descripcion";
            this.Col_cargo.Name = "Col_cargo";
            this.Col_cargo.Visible = true;
            this.Col_cargo.VisibleIndex = 3;
            this.Col_cargo.Width = 224;
            // 
            // Col_salario
            // 
            this.Col_salario.Caption = "SALARIO";
            this.Col_salario.FieldName = "Salario";
            this.Col_salario.Name = "Col_salario";
            this.Col_salario.Visible = true;
            this.Col_salario.VisibleIndex = 4;
            this.Col_salario.Width = 48;
            // 
            // Col_HorasExtras
            // 
            this.Col_HorasExtras.Caption = "H.EXTRAS";
            this.Col_HorasExtras.FieldName = "HorasExtras";
            this.Col_HorasExtras.Name = "Col_HorasExtras";
            this.Col_HorasExtras.Visible = true;
            this.Col_HorasExtras.VisibleIndex = 5;
            this.Col_HorasExtras.Width = 53;
            // 
            // Col_TotalIngresos
            // 
            this.Col_TotalIngresos.Caption = "TOTAL INGRESOS";
            this.Col_TotalIngresos.DisplayFormat.FormatString = "n2";
            this.Col_TotalIngresos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_TotalIngresos.FieldName = "TotalIngresos";
            this.Col_TotalIngresos.Name = "Col_TotalIngresos";
            this.Col_TotalIngresos.Visible = true;
            this.Col_TotalIngresos.VisibleIndex = 6;
            this.Col_TotalIngresos.Width = 84;
            // 
            // Col_total_mas_beneficios
            // 
            this.Col_total_mas_beneficios.Caption = "T+BENEFICIOS";
            this.Col_total_mas_beneficios.DisplayFormat.FormatString = "n2";
            this.Col_total_mas_beneficios.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_total_mas_beneficios.FieldName = "Total_mas_Beneficios";
            this.Col_total_mas_beneficios.Name = "Col_total_mas_beneficios";
            this.Col_total_mas_beneficios.Visible = true;
            this.Col_total_mas_beneficios.VisibleIndex = 7;
            this.Col_total_mas_beneficios.Width = 69;
            // 
            // Col_TotalMo
            // 
            this.Col_TotalMo.Caption = "TOTAL M/O";
            this.Col_TotalMo.DisplayFormat.FormatString = "n2";
            this.Col_TotalMo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_TotalMo.FieldName = "TotalManoObra";
            this.Col_TotalMo.Name = "Col_TotalMo";
            this.Col_TotalMo.Visible = true;
            this.Col_TotalMo.VisibleIndex = 8;
            this.Col_TotalMo.Width = 81;
            // 
            // cmb_subcentro
            // 
            this.cmb_subcentro.AutoHeight = false;
            this.cmb_subcentro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_subcentro.DisplayMember = "Centro_costo2";
            this.cmb_subcentro.Name = "cmb_subcentro";
            this.cmb_subcentro.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmb_subcentro.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "ID";
            this.gridColumn12.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Subcentro";
            this.gridColumn13.FieldName = "Centro_costo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_imprimir_grilla});
            this.toolStrip1.Location = new System.Drawing.Point(0, 130);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1103, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_imprimir_grilla
            // 
            this.btn_imprimir_grilla.Image = global::Core.Erp.Winform.Properties.Resources.imprimir_32x32;
            this.btn_imprimir_grilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir_grilla.Name = "btn_imprimir_grilla";
            this.btn_imprimir_grilla.Size = new System.Drawing.Size(102, 22);
            this.btn_imprimir_grilla.Text = "Imprimir grilla";
            this.btn_imprimir_grilla.Click += new System.EventHandler(this.btn_imprimir_grilla_Click);
            // 
            // Col_Af_DescripcionCorta
            // 
            this.Col_Af_DescripcionCorta.Caption = "AF RELACIONADO";
            this.Col_Af_DescripcionCorta.FieldName = "Af_DescripcionCorta";
            this.Col_Af_DescripcionCorta.Name = "Col_Af_DescripcionCorta";
            this.Col_Af_DescripcionCorta.Visible = true;
            this.Col_Af_DescripcionCorta.VisibleIndex = 0;
            this.Col_Af_DescripcionCorta.Width = 99;
            // 
            // frmfa_pre_facturacion_servisndustria_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 389);
            this.Controls.Add(this.gridControl_gastos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "frmfa_pre_facturacion_servisndustria_Mant";
            this.Text = "Mantenimiento de mano obra servindustrias";
            this.Load += new System.EventHandler(this.frmfa_pre_facturacion_servisndustria_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado_cierre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdPreFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Panel panel1;
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
        private DevExpress.XtraGrid.GridControl gridControl_gastos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_gastos;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_subcentro;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_imprimir_grilla;
        private DevExpress.XtraEditors.CheckEdit chk_estado_cierre;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_apellido;
        private DevExpress.XtraGrid.Columns.GridColumn Col_cedula;
        private DevExpress.XtraGrid.Columns.GridColumn Col_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_salario;
        private DevExpress.XtraGrid.Columns.GridColumn Col_HorasExtras;
        private DevExpress.XtraGrid.Columns.GridColumn Col_TotalIngresos;
        private DevExpress.XtraGrid.Columns.GridColumn Col_total_mas_beneficios;
        private DevExpress.XtraGrid.Columns.GridColumn Col_TotalMo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Af_DescripcionCorta;
    }
}