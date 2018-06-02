namespace Core.Erp.Winform.Roles_Fj
{
    partial class frmRo_fuerza_mant
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.lblanulado = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txt_nom_Fuerza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtId_fuerza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbcentrocosto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Centro_costo_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbsuccentro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtcedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtgasto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtvalor = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nom_Fuerza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId_fuerza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcentrocosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbsuccentro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgasto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 233);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(459, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 84;
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
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(459, 29);
            this.ucGe_Menu.TabIndex = 83;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
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
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // lblanulado
            // 
            this.lblanulado.AutoSize = true;
            this.lblanulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanulado.ForeColor = System.Drawing.Color.Red;
            this.lblanulado.Location = new System.Drawing.Point(137, 32);
            this.lblanulado.Name = "lblanulado";
            this.lblanulado.Size = new System.Drawing.Size(136, 20);
            this.lblanulado.TabIndex = 90;
            this.lblanulado.Text = "***ANULADO***";
            this.lblanulado.Visible = false;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(232, 61);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 89;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txt_nom_Fuerza
            // 
            this.txt_nom_Fuerza.Location = new System.Drawing.Point(141, 131);
            this.txt_nom_Fuerza.Name = "txt_nom_Fuerza";
            this.txt_nom_Fuerza.Size = new System.Drawing.Size(194, 20);
            this.txt_nom_Fuerza.TabIndex = 88;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 87;
            this.labelControl3.Text = "Nombre Fuerza";
            // 
            // txtId_fuerza
            // 
            this.txtId_fuerza.Location = new System.Drawing.Point(141, 59);
            this.txtId_fuerza.Name = "txtId_fuerza";
            this.txtId_fuerza.Properties.ReadOnly = true;
            this.txtId_fuerza.Size = new System.Drawing.Size(76, 20);
            this.txtId_fuerza.TabIndex = 86;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 85;
            this.labelControl1.Text = "Id Fuerza";
            // 
            // cmbcentrocosto
            // 
            this.cmbcentrocosto.Location = new System.Drawing.Point(141, 82);
            this.cmbcentrocosto.Name = "cmbcentrocosto";
            this.cmbcentrocosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbcentrocosto.Properties.DisplayMember = "Centro_costo";
            this.cmbcentrocosto.Properties.ValueMember = "IdCentroCosto";
            this.cmbcentrocosto.Properties.View = this.searchLookUpEdit1View;
            this.cmbcentrocosto.Size = new System.Drawing.Size(199, 20);
            this.cmbcentrocosto.TabIndex = 91;
            this.cmbcentrocosto.EditValueChanged += new System.EventHandler(this.cmbcentrocosto_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Centro_costo_});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Centro_costo_
            // 
            this.Col_Centro_costo_.Caption = "Centro costo";
            this.Col_Centro_costo_.FieldName = "Centro_costo";
            this.Col_Centro_costo_.Name = "Col_Centro_costo_";
            this.Col_Centro_costo_.Visible = true;
            this.Col_Centro_costo_.VisibleIndex = 0;
            // 
            // cmbsuccentro
            // 
            this.cmbsuccentro.Location = new System.Drawing.Point(141, 108);
            this.cmbsuccentro.Name = "cmbsuccentro";
            this.cmbsuccentro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbsuccentro.Properties.DisplayMember = "Centro_costo";
            this.cmbsuccentro.Properties.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmbsuccentro.Properties.View = this.gridView1;
            this.cmbsuccentro.Size = new System.Drawing.Size(199, 20);
            this.cmbsuccentro.TabIndex = 92;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Centro_costo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Centro_costo
            // 
            this.Col_Centro_costo.Caption = "Centro costo";
            this.Col_Centro_costo.FieldName = "Centro_costo";
            this.Col_Centro_costo.Name = "Col_Centro_costo";
            this.Col_Centro_costo.Visible = true;
            this.Col_Centro_costo.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 93;
            this.labelControl2.Text = "Centro costo";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 94;
            this.labelControl4.Text = "Centro costo";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(141, 157);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(194, 20);
            this.txtcedula.TabIndex = 95;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 160);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 96;
            this.labelControl5.Text = "Cedula";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 186);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 13);
            this.labelControl6.TabIndex = 98;
            this.labelControl6.Text = "Descripcion gasto";
            // 
            // txtgasto
            // 
            this.txtgasto.Location = new System.Drawing.Point(141, 183);
            this.txtgasto.Name = "txtgasto";
            this.txtgasto.Size = new System.Drawing.Size(194, 20);
            this.txtgasto.TabIndex = 97;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 212);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 100;
            this.labelControl7.Text = "Valor (gasto)";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(141, 209);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(194, 20);
            this.txtvalor.TabIndex = 99;
            // 
            // frmRo_fuerza_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 259);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtgasto);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbsuccentro);
            this.Controls.Add(this.cmbcentrocosto);
            this.Controls.Add(this.lblanulado);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txt_nom_Fuerza);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtId_fuerza);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_fuerza_mant";
            this.Text = "frmRo_fuerza_mant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_fuerza_mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_fuerza_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_nom_Fuerza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId_fuerza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcentrocosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbsuccentro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgasto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Label lblanulado;
        private System.Windows.Forms.CheckBox chkEstado;
        private DevExpress.XtraEditors.TextEdit txt_nom_Fuerza;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtId_fuerza;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbcentrocosto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbsuccentro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Centro_costo_;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Centro_costo;
        private DevExpress.XtraEditors.TextEdit txtcedula;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtgasto;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtvalor;
    }
}