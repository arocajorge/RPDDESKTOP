namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Generacion_Utilidades_Mant
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
            this.ucGe_Menu_Superior_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPeriodos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbnominaTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbnomina = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbRuta = new DevExpress.XtraEditors.ButtonEdit();
            this.lbRuta = new System.Windows.Forms.Label();
            this.CmbGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtUtilidadRepartir = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.txtUtilidadPorCargaFamiliar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUtilidadPorDerechoIndividual = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCargarEmpleado = new System.Windows.Forms.Button();
            this.gridEmpleados = new DevExpress.XtraGrid.GridControl();
            this.viewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasTrab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlicuotaIndividual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotalIndividual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactorA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlicuotaCarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotalCarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExedenteIESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRecibir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_em_fechaIngaRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_em_fechaSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_em_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUtilidadRepartir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorCargaFamiliar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorDerechoIndividual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior_Mant
            // 
            this.ucGe_Menu_Superior_Mant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant.Name = "ucGe_Menu_Superior_Mant";
            this.ucGe_Menu_Superior_Mant.Size = new System.Drawing.Size(1159, 29);
            this.ucGe_Menu_Superior_Mant.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant.event_btnImprimir_guia_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_guia_Click(this.ucGe_Menu_Superior_Mant_event_btnImprimir_guia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.cmbPeriodos);
            this.groupBox1.Controls.Add(this.cmbnominaTipo);
            this.groupBox1.Controls.Add(this.cmbnomina);
            this.groupBox1.Controls.Add(this.cmbRuta);
            this.groupBox1.Controls.Add(this.lbRuta);
            this.groupBox1.Controls.Add(this.CmbGenerar);
            this.groupBox1.Controls.Add(this.groupControl1);
            this.groupBox1.Controls.Add(this.TxtUtilidadRepartir);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.cmdCalcular);
            this.groupBox1.Controls.Add(this.txtUtilidadPorCargaFamiliar);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtUtilidadPorDerechoIndividual);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.cmdCargarEmpleado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(690, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 166;
            this.labelControl1.Text = "Período:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(688, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 165;
            this.labelControl6.Text = "Proceso:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(691, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 13);
            this.labelControl7.TabIndex = 164;
            this.labelControl7.Text = "Nómina:";
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.Location = new System.Drawing.Point(747, 59);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodos.Properties.DisplayMember = "pe_Descripcion";
            this.cmbPeriodos.Properties.ValueMember = "IdPeriodo";
            this.cmbPeriodos.Properties.View = this.gridView2;
            this.cmbPeriodos.Size = new System.Drawing.Size(281, 20);
            this.cmbPeriodos.TabIndex = 163;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdPeriodo,
            this.Colpe_Descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdPeriodo
            // 
            this.ColIdPeriodo.Caption = "Id Periodo";
            this.ColIdPeriodo.FieldName = "IdPeriodo";
            this.ColIdPeriodo.Name = "ColIdPeriodo";
            this.ColIdPeriodo.Visible = true;
            this.ColIdPeriodo.VisibleIndex = 0;
            this.ColIdPeriodo.Width = 168;
            // 
            // Colpe_Descripcion
            // 
            this.Colpe_Descripcion.Caption = "Descripcion";
            this.Colpe_Descripcion.FieldName = "pe_Descripcion";
            this.Colpe_Descripcion.Name = "Colpe_Descripcion";
            this.Colpe_Descripcion.Visible = true;
            this.Colpe_Descripcion.VisibleIndex = 1;
            this.Colpe_Descripcion.Width = 984;
            // 
            // cmbnominaTipo
            // 
            this.cmbnominaTipo.Location = new System.Drawing.Point(747, 34);
            this.cmbnominaTipo.Name = "cmbnominaTipo";
            this.cmbnominaTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnominaTipo.Properties.DisplayMember = "DescripcionProcesoNomina";
            this.cmbnominaTipo.Properties.ValueMember = "IdNomina_TipoLiqui";
            this.cmbnominaTipo.Properties.View = this.gridView1;
            this.cmbnominaTipo.Size = new System.Drawing.Size(281, 20);
            this.cmbnominaTipo.TabIndex = 162;
            this.cmbnominaTipo.EditValueChanged += new System.EventHandler(this.cmbnominaTipo_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDescripcionProcesoNomina});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ColDescripcionProcesoNomina
            // 
            this.ColDescripcionProcesoNomina.Caption = "Proceso";
            this.ColDescripcionProcesoNomina.FieldName = "DescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Name = "ColDescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Visible = true;
            this.ColDescripcionProcesoNomina.VisibleIndex = 0;
            // 
            // cmbnomina
            // 
            this.cmbnomina.Location = new System.Drawing.Point(747, 8);
            this.cmbnomina.Name = "cmbnomina";
            this.cmbnomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnomina.Properties.DisplayMember = "Descripcion";
            this.cmbnomina.Properties.ValueMember = "IdNomina_Tipo";
            this.cmbnomina.Properties.View = this.searchLookUpEdit1View;
            this.cmbnomina.Size = new System.Drawing.Size(281, 20);
            this.cmbnomina.TabIndex = 161;
            this.cmbnomina.EditValueChanged += new System.EventHandler(this.cmbnomina_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Caption = "Nomina";
            this.ColDescripcion.FieldName = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Visible = true;
            this.ColDescripcion.VisibleIndex = 0;
            // 
            // cmbRuta
            // 
            this.cmbRuta.Location = new System.Drawing.Point(102, 8);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRuta.Properties.ReadOnly = true;
            this.cmbRuta.Size = new System.Drawing.Size(319, 20);
            this.cmbRuta.TabIndex = 160;
            this.cmbRuta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRuta_ButtonClick);
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Location = new System.Drawing.Point(4, 10);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(92, 13);
            this.lbRuta.TabIndex = 159;
            this.lbRuta.Text = "Ruta Plantilla .csv";
            // 
            // CmbGenerar
            // 
            this.CmbGenerar.Location = new System.Drawing.Point(1044, 63);
            this.CmbGenerar.Name = "CmbGenerar";
            this.CmbGenerar.Size = new System.Drawing.Size(115, 25);
            this.CmbGenerar.TabIndex = 158;
            this.CmbGenerar.Text = "Generar Archivo";
            this.CmbGenerar.Click += new System.EventHandler(this.CmbGenerar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Location = new System.Drawing.Point(6, 36);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(415, 52);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Observación";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(2, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 29);
            this.textBox1.TabIndex = 0;
            // 
            // TxtUtilidadRepartir
            // 
            this.TxtUtilidadRepartir.EditValue = "0";
            this.TxtUtilidadRepartir.Location = new System.Drawing.Point(581, 10);
            this.TxtUtilidadRepartir.Name = "TxtUtilidadRepartir";
            this.TxtUtilidadRepartir.Properties.DisplayFormat.FormatString = "N2";
            this.TxtUtilidadRepartir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtUtilidadRepartir.Properties.EditFormat.FormatString = "N2";
            this.TxtUtilidadRepartir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtUtilidadRepartir.Properties.Mask.EditMask = "n2";
            this.TxtUtilidadRepartir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtUtilidadRepartir.Properties.MaxLength = 15;
            this.TxtUtilidadRepartir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUtilidadRepartir.Size = new System.Drawing.Size(100, 20);
            this.TxtUtilidadRepartir.TabIndex = 17;
            this.TxtUtilidadRepartir.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.TxtUtilidadRepartir_EditValueChanging);
            this.TxtUtilidadRepartir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUtilidadRepartir_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(468, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Valor Total de Utilidad";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(1044, 37);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(115, 23);
            this.cmdCalcular.TabIndex = 13;
            this.cmdCalcular.Text = "C&alcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // txtUtilidadPorCargaFamiliar
            // 
            this.txtUtilidadPorCargaFamiliar.EditValue = "0";
            this.txtUtilidadPorCargaFamiliar.Enabled = false;
            this.txtUtilidadPorCargaFamiliar.Location = new System.Drawing.Point(582, 60);
            this.txtUtilidadPorCargaFamiliar.Name = "txtUtilidadPorCargaFamiliar";
            this.txtUtilidadPorCargaFamiliar.Properties.DisplayFormat.FormatString = "N2";
            this.txtUtilidadPorCargaFamiliar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUtilidadPorCargaFamiliar.Properties.EditFormat.FormatString = "N2";
            this.txtUtilidadPorCargaFamiliar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUtilidadPorCargaFamiliar.Properties.MaxLength = 15;
            this.txtUtilidadPorCargaFamiliar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUtilidadPorCargaFamiliar.Size = new System.Drawing.Size(100, 20);
            this.txtUtilidadPorCargaFamiliar.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(444, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(129, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Utilidad por Carga Familiar:";
            // 
            // txtUtilidadPorDerechoIndividual
            // 
            this.txtUtilidadPorDerechoIndividual.EditValue = "0";
            this.txtUtilidadPorDerechoIndividual.Enabled = false;
            this.txtUtilidadPorDerechoIndividual.Location = new System.Drawing.Point(582, 34);
            this.txtUtilidadPorDerechoIndividual.Name = "txtUtilidadPorDerechoIndividual";
            this.txtUtilidadPorDerechoIndividual.Properties.DisplayFormat.FormatString = "N2";
            this.txtUtilidadPorDerechoIndividual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUtilidadPorDerechoIndividual.Properties.EditFormat.FormatString = "N2";
            this.txtUtilidadPorDerechoIndividual.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUtilidadPorDerechoIndividual.Properties.MaxLength = 15;
            this.txtUtilidadPorDerechoIndividual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUtilidadPorDerechoIndividual.Size = new System.Drawing.Size(100, 20);
            this.txtUtilidadPorDerechoIndividual.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(426, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Utilidad por Derecho Individual:";
            // 
            // cmdCargarEmpleado
            // 
            this.cmdCargarEmpleado.Location = new System.Drawing.Point(1044, 11);
            this.cmdCargarEmpleado.Name = "cmdCargarEmpleado";
            this.cmdCargarEmpleado.Size = new System.Drawing.Size(115, 23);
            this.cmdCargarEmpleado.TabIndex = 4;
            this.cmdCargarEmpleado.Text = "&Cargar Empleados";
            this.cmdCargarEmpleado.UseVisualStyleBackColor = true;
            this.cmdCargarEmpleado.Click += new System.EventHandler(this.cmdCargarEmpleado_Click);
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmpleados.Location = new System.Drawing.Point(0, 117);
            this.gridEmpleados.MainView = this.viewEmpleados;
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.Size = new System.Drawing.Size(1159, 366);
            this.gridEmpleados.TabIndex = 2;
            this.gridEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewEmpleados});
            // 
            // viewEmpleados
            // 
            this.viewEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colCedula,
            this.colNombreCompleto,
            this.colCargo,
            this.colDiasTrab,
            this.colAlicuotaIndividual,
            this.colSubTotalIndividual,
            this.colCargas,
            this.colFactorA,
            this.colAlicuotaCarga,
            this.colSubTotalCarga,
            this.colExedenteIESS,
            this.colTotalRecibir,
            this.Col_em_fechaIngaRol,
            this.Col_em_fechaSalida,
            this.Col_em_status});
            this.viewEmpleados.GridControl = this.gridEmpleados;
            this.viewEmpleados.Name = "viewEmpleados";
            this.viewEmpleados.OptionsView.ShowAutoFilterRow = true;
            this.viewEmpleados.OptionsView.ShowFooter = true;
            this.viewEmpleados.OptionsView.ShowGroupPanel = false;
            this.viewEmpleados.OptionsView.ShowIndicator = false;
            this.viewEmpleados.OptionsView.ShowViewCaption = true;
            this.viewEmpleados.ViewCaption = "Listado de Empleados";
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "ID";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
            this.colIdEmpleado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdEmpleado", "{0} Registros")});
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            this.colIdEmpleado.Width = 36;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "Cédula";
            this.colCedula.FieldName = "pe_cedulaRuc";
            this.colCedula.Name = "colCedula";
            this.colCedula.OptionsColumn.AllowEdit = false;
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 1;
            this.colCedula.Width = 73;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.Caption = "Nombre del Empleado";
            this.colNombreCompleto.FieldName = "NomCompleto";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.OptionsColumn.AllowEdit = false;
            this.colNombreCompleto.Visible = true;
            this.colNombreCompleto.VisibleIndex = 2;
            this.colNombreCompleto.Width = 207;
            // 
            // colCargo
            // 
            this.colCargo.Caption = "Cargo";
            this.colCargo.FieldName = "cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.OptionsColumn.AllowEdit = false;
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 3;
            this.colCargo.Width = 119;
            // 
            // colDiasTrab
            // 
            this.colDiasTrab.Caption = "Días Trabajados";
            this.colDiasTrab.FieldName = "DiasTrabajados";
            this.colDiasTrab.Name = "colDiasTrab";
            this.colDiasTrab.OptionsColumn.AllowEdit = false;
            this.colDiasTrab.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colDiasTrab.Visible = true;
            this.colDiasTrab.VisibleIndex = 6;
            this.colDiasTrab.Width = 55;
            // 
            // colAlicuotaIndividual
            // 
            this.colAlicuotaIndividual.Caption = "AlicuotaIndividual";
            this.colAlicuotaIndividual.DisplayFormat.FormatString = "N4";
            this.colAlicuotaIndividual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlicuotaIndividual.FieldName = "alicuotaIndividual";
            this.colAlicuotaIndividual.Name = "colAlicuotaIndividual";
            this.colAlicuotaIndividual.OptionsColumn.AllowEdit = false;
            this.colAlicuotaIndividual.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "alicuotaIndividual", "{0:N2}")});
            this.colAlicuotaIndividual.Visible = true;
            this.colAlicuotaIndividual.VisibleIndex = 7;
            this.colAlicuotaIndividual.Width = 43;
            // 
            // colSubTotalIndividual
            // 
            this.colSubTotalIndividual.Caption = "SubTotalIndividual";
            this.colSubTotalIndividual.DisplayFormat.FormatString = "N2";
            this.colSubTotalIndividual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotalIndividual.FieldName = "subTotalIndividual";
            this.colSubTotalIndividual.Name = "colSubTotalIndividual";
            this.colSubTotalIndividual.OptionsColumn.AllowEdit = false;
            this.colSubTotalIndividual.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subTotalIndividual", "{0:N2}")});
            this.colSubTotalIndividual.Visible = true;
            this.colSubTotalIndividual.VisibleIndex = 8;
            this.colSubTotalIndividual.Width = 59;
            // 
            // colCargas
            // 
            this.colCargas.Caption = "Cargas";
            this.colCargas.FieldName = "cargas";
            this.colCargas.Name = "colCargas";
            this.colCargas.OptionsColumn.AllowEdit = false;
            this.colCargas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colCargas.Visible = true;
            this.colCargas.VisibleIndex = 9;
            this.colCargas.Width = 58;
            // 
            // colFactorA
            // 
            this.colFactorA.Caption = "Factor A";
            this.colFactorA.DisplayFormat.FormatString = "N2";
            this.colFactorA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFactorA.FieldName = "factorA";
            this.colFactorA.Name = "colFactorA";
            this.colFactorA.OptionsColumn.AllowEdit = false;
            this.colFactorA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "factorA", "{0:N2}")});
            this.colFactorA.Visible = true;
            this.colFactorA.VisibleIndex = 10;
            this.colFactorA.Width = 51;
            // 
            // colAlicuotaCarga
            // 
            this.colAlicuotaCarga.Caption = "AlicuotaCarga";
            this.colAlicuotaCarga.DisplayFormat.FormatString = "N4";
            this.colAlicuotaCarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlicuotaCarga.FieldName = "alicuotaCarga";
            this.colAlicuotaCarga.Name = "colAlicuotaCarga";
            this.colAlicuotaCarga.OptionsColumn.AllowEdit = false;
            this.colAlicuotaCarga.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "alicuotaCarga", "{0:N2}")});
            this.colAlicuotaCarga.Visible = true;
            this.colAlicuotaCarga.VisibleIndex = 11;
            this.colAlicuotaCarga.Width = 54;
            // 
            // colSubTotalCarga
            // 
            this.colSubTotalCarga.Caption = "SubTotalCarga";
            this.colSubTotalCarga.DisplayFormat.FormatString = "N2";
            this.colSubTotalCarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotalCarga.FieldName = "subTotalCarga";
            this.colSubTotalCarga.Name = "colSubTotalCarga";
            this.colSubTotalCarga.OptionsColumn.AllowEdit = false;
            this.colSubTotalCarga.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subTotalCarga", "{0:N2}")});
            this.colSubTotalCarga.Visible = true;
            this.colSubTotalCarga.VisibleIndex = 12;
            this.colSubTotalCarga.Width = 79;
            // 
            // colExedenteIESS
            // 
            this.colExedenteIESS.Caption = "Exedente IESS";
            this.colExedenteIESS.DisplayFormat.FormatString = "N2";
            this.colExedenteIESS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExedenteIESS.FieldName = "exedenteIESS";
            this.colExedenteIESS.Name = "colExedenteIESS";
            this.colExedenteIESS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "exedenteIESS", "{0:N2}")});
            this.colExedenteIESS.Visible = true;
            this.colExedenteIESS.VisibleIndex = 13;
            // 
            // colTotalRecibir
            // 
            this.colTotalRecibir.Caption = "Total a Recibir";
            this.colTotalRecibir.DisplayFormat.FormatString = "N2";
            this.colTotalRecibir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalRecibir.FieldName = "ValorTotal";
            this.colTotalRecibir.Name = "colTotalRecibir";
            this.colTotalRecibir.OptionsColumn.AllowEdit = false;
            this.colTotalRecibir.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valorEntregar", "{0:N2}")});
            this.colTotalRecibir.Visible = true;
            this.colTotalRecibir.VisibleIndex = 14;
            this.colTotalRecibir.Width = 74;
            // 
            // Col_em_fechaIngaRol
            // 
            this.Col_em_fechaIngaRol.Caption = "Ingreso";
            this.Col_em_fechaIngaRol.DisplayFormat.FormatString = "d";
            this.Col_em_fechaIngaRol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Col_em_fechaIngaRol.FieldName = "em_fechaIngaRol";
            this.Col_em_fechaIngaRol.Name = "Col_em_fechaIngaRol";
            this.Col_em_fechaIngaRol.Visible = true;
            this.Col_em_fechaIngaRol.VisibleIndex = 4;
            this.Col_em_fechaIngaRol.Width = 51;
            // 
            // Col_em_fechaSalida
            // 
            this.Col_em_fechaSalida.Caption = "Salida";
            this.Col_em_fechaSalida.DisplayFormat.FormatString = "d";
            this.Col_em_fechaSalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Col_em_fechaSalida.FieldName = "em_fechaSalida";
            this.Col_em_fechaSalida.Name = "Col_em_fechaSalida";
            this.Col_em_fechaSalida.Visible = true;
            this.Col_em_fechaSalida.VisibleIndex = 5;
            this.Col_em_fechaSalida.Width = 47;
            // 
            // Col_em_status
            // 
            this.Col_em_status.Caption = "Estado";
            this.Col_em_status.FieldName = "em_status";
            this.Col_em_status.Name = "Col_em_status";
            this.Col_em_status.Visible = true;
            this.Col_em_status.VisibleIndex = 15;
            this.Col_em_status.Width = 76;
            // 
            // frmRo_Generacion_Utilidades_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 483);
            this.Controls.Add(this.gridEmpleados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant);
            this.Name = "frmRo_Generacion_Utilidades_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso - Generación de Utilidades";
            this.Load += new System.EventHandler(this.frmRo_Generacion_Utilidades_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUtilidadRepartir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorCargaFamiliar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorDerechoIndividual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCargarEmpleado;
        private DevExpress.XtraGrid.GridControl gridEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView viewEmpleados;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasTrab;
        private DevExpress.XtraGrid.Columns.GridColumn colAlicuotaIndividual;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotalIndividual;
        private DevExpress.XtraGrid.Columns.GridColumn colCargas;
        private DevExpress.XtraEditors.TextEdit txtUtilidadPorCargaFamiliar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUtilidadPorDerechoIndividual;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button cmdCalcular;
        private DevExpress.XtraGrid.Columns.GridColumn colFactorA;
        private DevExpress.XtraGrid.Columns.GridColumn colAlicuotaCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotalCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRecibir;
        private DevExpress.XtraGrid.Columns.GridColumn colExedenteIESS;
        private DevExpress.XtraEditors.TextEdit TxtUtilidadRepartir;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.ButtonEdit cmbRuta;
        private System.Windows.Forms.Label lbRuta;
        private DevExpress.XtraEditors.SimpleButton CmbGenerar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_Descripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnominaTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcionProcesoNomina;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnomina;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_em_fechaIngaRol;
        private DevExpress.XtraGrid.Columns.GridColumn Col_em_fechaSalida;
        private DevExpress.XtraGrid.Columns.GridColumn Col_em_status;
    }
}