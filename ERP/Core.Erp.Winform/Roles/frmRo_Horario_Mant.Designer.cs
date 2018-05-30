namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Horario_Mant
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoraFin = new DevExpress.XtraEditors.TextEdit();
            this.txtIdTurno = new DevExpress.XtraEditors.TextEdit();
            this.txtHoraIni = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtToleranciaEnt = new DevExpress.XtraEditors.TextEdit();
            this.txttolerancialunch = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalidaLunch = new DevExpress.XtraEditors.TextEdit();
            this.txtRegresoLunch = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CheckEstado = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdTurno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToleranciaEnt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttolerancialunch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalidaLunch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegresoLunch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción:";
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.EditValue = "00:00";
            this.txtHoraFin.Location = new System.Drawing.Point(429, 51);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Properties.Mask.EditMask = "t";
            this.txtHoraFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtHoraFin.Size = new System.Drawing.Size(100, 20);
            this.txtHoraFin.TabIndex = 2;
            this.txtHoraFin.EditValueChanged += new System.EventHandler(this.txtHoraFin_EditValueChanged);
            // 
            // txtIdTurno
            // 
            this.txtIdTurno.Location = new System.Drawing.Point(145, 29);
            this.txtIdTurno.Name = "txtIdTurno";
            this.txtIdTurno.Size = new System.Drawing.Size(100, 20);
            this.txtIdTurno.TabIndex = 0;
            // 
            // txtHoraIni
            // 
            this.txtHoraIni.EditValue = "00:00";
            this.txtHoraIni.Location = new System.Drawing.Point(145, 54);
            this.txtHoraIni.Name = "txtHoraIni";
            this.txtHoraIni.Properties.Mask.EditMask = "t";
            this.txtHoraIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtHoraIni.Size = new System.Drawing.Size(100, 20);
            this.txtHoraIni.TabIndex = 1;
            this.txtHoraIni.EditValueChanged += new System.EventHandler(this.txtHoraIni_EditValueChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(145, 132);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(383, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(2, 2);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(550, 24);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "***Anulado***";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtToleranciaEnt
            // 
            this.txtToleranciaEnt.EditValue = "0";
            this.txtToleranciaEnt.Location = new System.Drawing.Point(145, 106);
            this.txtToleranciaEnt.Name = "txtToleranciaEnt";
            this.txtToleranciaEnt.Properties.Mask.EditMask = "[+]?[0-6(7-9)]{2}";
            this.txtToleranciaEnt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtToleranciaEnt.Properties.Mask.ShowPlaceHolders = false;
            this.txtToleranciaEnt.Size = new System.Drawing.Size(100, 20);
            this.txtToleranciaEnt.TabIndex = 3;
            // 
            // txttolerancialunch
            // 
            this.txttolerancialunch.EditValue = "0";
            this.txttolerancialunch.Location = new System.Drawing.Point(429, 103);
            this.txttolerancialunch.Name = "txttolerancialunch";
            this.txttolerancialunch.Properties.Mask.EditMask = "[+]?[0-60]{2}";
            this.txttolerancialunch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txttolerancialunch.Properties.Mask.ShowPlaceHolders = false;
            this.txttolerancialunch.Size = new System.Drawing.Size(100, 20);
            this.txttolerancialunch.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tolerancia Entrada(Min):";
            // 
            // txtSalidaLunch
            // 
            this.txtSalidaLunch.EditValue = "00:00";
            this.txtSalidaLunch.Location = new System.Drawing.Point(145, 80);
            this.txtSalidaLunch.Name = "txtSalidaLunch";
            this.txtSalidaLunch.Properties.Mask.EditMask = "t";
            this.txtSalidaLunch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtSalidaLunch.Size = new System.Drawing.Size(100, 20);
            this.txtSalidaLunch.TabIndex = 9;
            this.txtSalidaLunch.EditValueChanged += new System.EventHandler(this.txtSalidaLunch_EditValueChanged);
            // 
            // txtRegresoLunch
            // 
            this.txtRegresoLunch.EditValue = "00:00";
            this.txtRegresoLunch.Location = new System.Drawing.Point(429, 77);
            this.txtRegresoLunch.Name = "txtRegresoLunch";
            this.txtRegresoLunch.Properties.Mask.EditMask = "t";
            this.txtRegresoLunch.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtRegresoLunch.Size = new System.Drawing.Size(100, 20);
            this.txtRegresoLunch.TabIndex = 10;
            this.txtRegresoLunch.EditValueChanged += new System.EventHandler(this.txtRegresoLunch_EditValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Salida Lunch:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tolerancia Reg. lunch(Min):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(285, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Regreso Lunch:";
            // 
            // CheckEstado
            // 
            this.CheckEstado.Location = new System.Drawing.Point(427, 26);
            this.CheckEstado.Name = "CheckEstado";
            this.CheckEstado.Properties.Caption = "Activo";
            this.CheckEstado.Size = new System.Drawing.Size(75, 19);
            this.CheckEstado.TabIndex = 34;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label14);
            this.panelControl1.Controls.Add(this.CheckEstado);
            this.panelControl1.Controls.Add(this.lblEstado);
            this.panelControl1.Controls.Add(this.txtIdTurno);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtRegresoLunch);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtSalidaLunch);
            this.panelControl1.Controls.Add(this.txttolerancialunch);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.txtHoraFin);
            this.panelControl1.Controls.Add(this.txtHoraIni);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label13);
            this.panelControl1.Controls.Add(this.txtDescripcion);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.txtToleranciaEnt);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(554, 176);
            this.panelControl1.TabIndex = 84;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(554, 29);
            this.ucGe_Menu.TabIndex = 82;
            this.ucGe_Menu.Visible_bntAnular = true;
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
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // frmRo_Horario_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 205);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Horario_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Horarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Turno_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Turno_Mant_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Horario_Mant_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdTurno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToleranciaEnt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttolerancialunch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalidaLunch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegresoLunch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtHoraFin;
        private DevExpress.XtraEditors.TextEdit txtIdTurno;
        private DevExpress.XtraEditors.TextEdit txtHoraIni;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private DevExpress.XtraEditors.TextEdit txtToleranciaEnt;
        private DevExpress.XtraEditors.TextEdit txttolerancialunch;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtSalidaLunch;
        private DevExpress.XtraEditors.TextEdit txtRegresoLunch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.CheckEdit CheckEstado;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}