namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Turno_Mant
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
            this.components = new System.ComponentModel.Container();
            this.roturnoxtbdiaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_descTurno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.checklunes = new DevExpress.XtraEditors.CheckEdit();
            this.checkmartes = new DevExpress.XtraEditors.CheckEdit();
            this.checkmiercoles = new DevExpress.XtraEditors.CheckEdit();
            this.checkjueves = new DevExpress.XtraEditors.CheckEdit();
            this.checkviernes = new DevExpress.XtraEditors.CheckEdit();
            this.checksabado = new DevExpress.XtraEditors.CheckEdit();
            this.checkdomingo = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.roturnoxtbdiaInfoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checklunes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkmartes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkmiercoles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkjueves.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkviernes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksabado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkdomingo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_descTurno
            // 
            this.txt_descTurno.Location = new System.Drawing.Point(98, 46);
            this.txt_descTurno.Multiline = true;
            this.txt_descTurno.Name = "txt_descTurno";
            this.txt_descTurno.Size = new System.Drawing.Size(272, 20);
            this.txt_descTurno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkdomingo);
            this.groupBox1.Controls.Add(this.checksabado);
            this.groupBox1.Controls.Add(this.checkviernes);
            this.groupBox1.Controls.Add(this.checkjueves);
            this.groupBox1.Controls.Add(this.checkmiercoles);
            this.groupBox1.Controls.Add(this.checkmartes);
            this.groupBox1.Controls.Add(this.checklunes);
            this.groupBox1.Controls.Add(this.checkEstado);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txt_descTurno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(314, 23);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(56, 17);
            this.checkEstado.TabIndex = 15;
            this.checkEstado.Text = "Activo";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDia
            // 
            this.txtDia.Enabled = false;
            this.txtDia.Location = new System.Drawing.Point(100, 21);
            this.txtDia.MaxLength = 5;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(65, 20);
            this.txtDia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turno:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(417, 29);
            this.ucGe_Menu.TabIndex = 5;
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
            // checklunes
            // 
            this.checklunes.Location = new System.Drawing.Point(96, 72);
            this.checklunes.Name = "checklunes";
            this.checklunes.Properties.Caption = "Lunes";
            this.checklunes.Size = new System.Drawing.Size(75, 19);
            this.checklunes.TabIndex = 16;
            // 
            // checkmartes
            // 
            this.checkmartes.Location = new System.Drawing.Point(97, 96);
            this.checkmartes.Name = "checkmartes";
            this.checkmartes.Properties.Caption = "Martes";
            this.checkmartes.Size = new System.Drawing.Size(75, 19);
            this.checkmartes.TabIndex = 17;
            // 
            // checkmiercoles
            // 
            this.checkmiercoles.Location = new System.Drawing.Point(190, 72);
            this.checkmiercoles.Name = "checkmiercoles";
            this.checkmiercoles.Properties.Caption = "Miércoles";
            this.checkmiercoles.Size = new System.Drawing.Size(75, 19);
            this.checkmiercoles.TabIndex = 18;
            // 
            // checkjueves
            // 
            this.checkjueves.Location = new System.Drawing.Point(190, 96);
            this.checkjueves.Name = "checkjueves";
            this.checkjueves.Properties.Caption = "Jueves";
            this.checkjueves.Size = new System.Drawing.Size(75, 19);
            this.checkjueves.TabIndex = 19;
            // 
            // checkviernes
            // 
            this.checkviernes.Location = new System.Drawing.Point(285, 72);
            this.checkviernes.Name = "checkviernes";
            this.checkviernes.Properties.Caption = "Viernes";
            this.checkviernes.Size = new System.Drawing.Size(75, 19);
            this.checkviernes.TabIndex = 20;
            // 
            // checksabado
            // 
            this.checksabado.Location = new System.Drawing.Point(285, 96);
            this.checksabado.Name = "checksabado";
            this.checksabado.Properties.Caption = "Sábado";
            this.checksabado.Size = new System.Drawing.Size(75, 19);
            this.checksabado.TabIndex = 21;
            // 
            // checkdomingo
            // 
            this.checkdomingo.Location = new System.Drawing.Point(98, 121);
            this.checkdomingo.Name = "checkdomingo";
            this.checkdomingo.Properties.Caption = "Domingo";
            this.checkdomingo.Size = new System.Drawing.Size(75, 19);
            this.checkdomingo.TabIndex = 22;
            // 
            // frmRo_Turno_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 212);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Turno_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Turno ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Turno_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Turno_Mant_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Turno_Mant_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.roturnoxtbdiaInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checklunes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkmartes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkmiercoles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkjueves.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkviernes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksabado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkdomingo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_descTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource roturnoxtbdiaInfoBindingSource;
        private System.Windows.Forms.Label label2;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.CheckBox checkEstado;
        private DevExpress.XtraEditors.CheckEdit checkdomingo;
        private DevExpress.XtraEditors.CheckEdit checksabado;
        private DevExpress.XtraEditors.CheckEdit checkviernes;
        private DevExpress.XtraEditors.CheckEdit checkjueves;
        private DevExpress.XtraEditors.CheckEdit checkmiercoles;
        private DevExpress.XtraEditors.CheckEdit checkmartes;
        private DevExpress.XtraEditors.CheckEdit checklunes;
    }
}