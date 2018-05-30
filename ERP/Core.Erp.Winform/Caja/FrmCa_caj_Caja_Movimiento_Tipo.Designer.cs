namespace Core.Erp.Winform.Caja
{
    partial class FrmCa_caj_Caja_Movimiento_Tipo
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
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSeDeposita = new System.Windows.Forms.CheckBox();
            this.ucCon_PlanCtaCmb1 = new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gBox_TipoMovimiento = new System.Windows.Forms.GroupBox();
            this.rB_Egreso = new System.Windows.Forms.RadioButton();
            this.rB_Ingreso = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Anulado = new System.Windows.Forms.Label();
            this.txt_idTipoMovi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.cmb_grupo_movi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.gBox_TipoMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_movi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(607, 28);
            this.chk_estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(68, 21);
            this.chk_estado.TabIndex = 5;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_grupo_movi);
            this.panel1.Controls.Add(this.chkSeDeposita);
            this.panel1.Controls.Add(this.ucCon_PlanCtaCmb1);
            this.panel1.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panel1.Controls.Add(this.gBox_TipoMovimiento);
            this.panel1.Controls.Add(this.chk_estado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_Anulado);
            this.panel1.Controls.Add(this.txt_idTipoMovi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 288);
            this.panel1.TabIndex = 1;
            // 
            // chkSeDeposita
            // 
            this.chkSeDeposita.AutoSize = true;
            this.chkSeDeposita.Location = new System.Drawing.Point(497, 105);
            this.chkSeDeposita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSeDeposita.Name = "chkSeDeposita";
            this.chkSeDeposita.Size = new System.Drawing.Size(182, 21);
            this.chkSeDeposita.TabIndex = 142;
            this.chkSeDeposita.Text = "Se Deposita en banco?.";
            this.chkSeDeposita.UseVisualStyleBackColor = true;
            // 
            // ucCon_PlanCtaCmb1
            // 
            this.ucCon_PlanCtaCmb1.Location = new System.Drawing.Point(151, 217);
            this.ucCon_PlanCtaCmb1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucCon_PlanCtaCmb1.Name = "ucCon_PlanCtaCmb1";
            this.ucCon_PlanCtaCmb1.Size = new System.Drawing.Size(535, 34);
            this.ucCon_PlanCtaCmb1.TabIndex = 141;
            this.ucCon_PlanCtaCmb1.event_cmbPlanCta_EditValueChanged += new Core.Erp.Winform.Controles.UCCon_PlanCtaCmb.delegate_cmbPlanCta_EditValueChanged(this.ucCon_PlanCtaCmb1_event_cmbPlanCta_EditValueChanged);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 256);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(887, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 140;
            // 
            // gBox_TipoMovimiento
            // 
            this.gBox_TipoMovimiento.Controls.Add(this.rB_Egreso);
            this.gBox_TipoMovimiento.Controls.Add(this.rB_Ingreso);
            this.gBox_TipoMovimiento.Location = new System.Drawing.Point(27, 28);
            this.gBox_TipoMovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBox_TipoMovimiento.Name = "gBox_TipoMovimiento";
            this.gBox_TipoMovimiento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBox_TipoMovimiento.Size = new System.Drawing.Size(307, 57);
            this.gBox_TipoMovimiento.TabIndex = 0;
            this.gBox_TipoMovimiento.TabStop = false;
            this.gBox_TipoMovimiento.Text = "Tipo de Movimiento";
            // 
            // rB_Egreso
            // 
            this.rB_Egreso.AutoSize = true;
            this.rB_Egreso.Location = new System.Drawing.Point(184, 23);
            this.rB_Egreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rB_Egreso.Name = "rB_Egreso";
            this.rB_Egreso.Size = new System.Drawing.Size(88, 21);
            this.rB_Egreso.TabIndex = 1;
            this.rB_Egreso.Text = "EGRESO";
            this.rB_Egreso.UseVisualStyleBackColor = true;
            // 
            // rB_Ingreso
            // 
            this.rB_Ingreso.AutoSize = true;
            this.rB_Ingreso.Checked = true;
            this.rB_Ingreso.Location = new System.Drawing.Point(32, 23);
            this.rB_Ingreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rB_Ingreso.Name = "rB_Ingreso";
            this.rB_Ingreso.Size = new System.Drawing.Size(92, 21);
            this.rB_Ingreso.TabIndex = 0;
            this.rB_Ingreso.TabStop = true;
            this.rB_Ingreso.Text = "INGRESO";
            this.rB_Ingreso.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 137;
            this.label8.Text = "Cuenta Cble.:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(159, 144);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(525, 27);
            this.txt_descripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "Tipo Movimiento:";
            // 
            // lb_Anulado
            // 
            this.lb_Anulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anulado.ForeColor = System.Drawing.Color.Red;
            this.lb_Anulado.Location = new System.Drawing.Point(375, 21);
            this.lb_Anulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Anulado.Name = "lb_Anulado";
            this.lb_Anulado.Size = new System.Drawing.Size(191, 33);
            this.lb_Anulado.TabIndex = 134;
            this.lb_Anulado.Text = "**ANULADO**";
            this.lb_Anulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Anulado.Visible = false;
            // 
            // txt_idTipoMovi
            // 
            this.txt_idTipoMovi.Location = new System.Drawing.Point(159, 106);
            this.txt_idTipoMovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idTipoMovi.Name = "txt_idTipoMovi";
            this.txt_idTipoMovi.ReadOnly = true;
            this.txt_idTipoMovi.Size = new System.Drawing.Size(131, 22);
            this.txt_idTipoMovi.TabIndex = 2;
            this.txt_idTipoMovi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Tipo Movimiento:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(887, 36);
            this.ucGe_Menu.TabIndex = 0;
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
            // 
            // cmb_grupo_movi
            // 
            this.cmb_grupo_movi.Location = new System.Drawing.Point(159, 187);
            this.cmb_grupo_movi.Name = "cmb_grupo_movi";
            this.cmb_grupo_movi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_grupo_movi.Properties.DisplayMember = "tg_descripcion";
            this.cmb_grupo_movi.Properties.ValueMember = "IdTipoMovi_grupo";
            this.cmb_grupo_movi.Properties.View = this.searchLookUpEdit1View;
            this.cmb_grupo_movi.Size = new System.Drawing.Size(525, 22);
            this.cmb_grupo_movi.TabIndex = 143;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "Grupo:";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Grupo";
            this.gridColumn1.FieldName = "tg_descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 1534;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdTipoMovi_grupo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 200;
            // 
            // FrmCa_caj_Caja_Movimiento_Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCa_caj_Caja_Movimiento_Tipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Movimiento Caja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCa_caj_Caja_Movimiento_Tipo_FormClosing);
            this.Load += new System.EventHandler(this.FrmCa_caj_Caja_Movimiento_Tipo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBox_TipoMovimiento.ResumeLayout(false);
            this.gBox_TipoMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_movi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_estado;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.GroupBox gBox_TipoMovimiento;
        private System.Windows.Forms.RadioButton rB_Egreso;
        private System.Windows.Forms.RadioButton rB_Ingreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Anulado;
        private System.Windows.Forms.TextBox txt_idTipoMovi;
        private System.Windows.Forms.Label label1;
        private Controles.UCCon_PlanCtaCmb ucCon_PlanCtaCmb1;
        private System.Windows.Forms.CheckBox chkSeDeposita;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_grupo_movi;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}