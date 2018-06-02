namespace Core.Erp.Winform.Alerta
{
    partial class FrmGe_Alerta_Mant
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
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_class_rpt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_class_data = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_class_bus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_asembly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tabla = new System.Windows.Forms.TextBox();
            this.txt_obser = new System.Windows.Forms.TextBox();
            this.txt_frm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_class_info = new System.Windows.Forms.TextBox();
            this.cmb_modulo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_modulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
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
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(825, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = true;
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
            this.ucGe_Menu.Visible_btnImpFrm = true;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = true;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_event_btnlimpiar_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            this.ucGe_Menu.event_btnImpRep_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImpRep_Click(this.ucGe_Menu_event_btnImpRep_Click);
            this.ucGe_Menu.event_btnImpFrm_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImpFrm_Click(this.ucGe_Menu_event_btnImpFrm_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(174, 346);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "Estado";
            this.chkEstado.Size = new System.Drawing.Size(75, 19);
            this.chkEstado.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 132;
            this.label7.Text = "Formulario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 131;
            this.label16.Text = "Clase Reporte";
            // 
            // txt_class_rpt
            // 
            this.txt_class_rpt.ForeColor = System.Drawing.Color.Black;
            this.txt_class_rpt.Location = new System.Drawing.Point(176, 256);
            this.txt_class_rpt.Name = "txt_class_rpt";
            this.txt_class_rpt.Size = new System.Drawing.Size(452, 20);
            this.txt_class_rpt.TabIndex = 118;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "Clase Data";
            // 
            // txt_class_data
            // 
            this.txt_class_data.ForeColor = System.Drawing.Color.Black;
            this.txt_class_data.Location = new System.Drawing.Point(176, 230);
            this.txt_class_data.Name = "txt_class_data";
            this.txt_class_data.Size = new System.Drawing.Size(452, 20);
            this.txt_class_data.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 129;
            this.label5.Text = "Clase Business";
            // 
            // txt_class_bus
            // 
            this.txt_class_bus.ForeColor = System.Drawing.Color.Black;
            this.txt_class_bus.Location = new System.Drawing.Point(176, 204);
            this.txt_class_bus.Name = "txt_class_bus";
            this.txt_class_bus.Size = new System.Drawing.Size(452, 20);
            this.txt_class_bus.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 125;
            this.label8.Text = "Clase Info";
            // 
            // txt_asembly
            // 
            this.txt_asembly.ForeColor = System.Drawing.Color.Black;
            this.txt_asembly.Location = new System.Drawing.Point(176, 152);
            this.txt_asembly.Name = "txt_asembly";
            this.txt_asembly.Size = new System.Drawing.Size(452, 20);
            this.txt_asembly.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Código";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 127;
            this.label14.Text = "Asembly / DLL";
            // 
            // txt_Id
            // 
            this.txt_Id.ForeColor = System.Drawing.Color.Black;
            this.txt_Id.Location = new System.Drawing.Point(502, 48);
            this.txt_Id.MaxLength = 50;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(126, 20);
            this.txt_Id.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(175, 74);
            this.txt_nombre.MaxLength = 150;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(452, 20);
            this.txt_nombre.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Modulo al que pertenece";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "Vista Relacionada";
            // 
            // txt_tabla
            // 
            this.txt_tabla.ForeColor = System.Drawing.Color.Black;
            this.txt_tabla.Location = new System.Drawing.Point(176, 100);
            this.txt_tabla.Name = "txt_tabla";
            this.txt_tabla.Size = new System.Drawing.Size(452, 20);
            this.txt_tabla.TabIndex = 112;
            // 
            // txt_obser
            // 
            this.txt_obser.ForeColor = System.Drawing.Color.Black;
            this.txt_obser.Location = new System.Drawing.Point(176, 282);
            this.txt_obser.Multiline = true;
            this.txt_obser.Name = "txt_obser";
            this.txt_obser.Size = new System.Drawing.Size(452, 47);
            this.txt_obser.TabIndex = 120;
            // 
            // txt_frm
            // 
            this.txt_frm.ForeColor = System.Drawing.Color.Black;
            this.txt_frm.Location = new System.Drawing.Point(176, 126);
            this.txt_frm.Name = "txt_frm";
            this.txt_frm.Size = new System.Drawing.Size(452, 20);
            this.txt_frm.TabIndex = 113;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 126;
            this.label9.Text = "Observación";
            // 
            // txt_class_info
            // 
            this.txt_class_info.ForeColor = System.Drawing.Color.Black;
            this.txt_class_info.Location = new System.Drawing.Point(176, 178);
            this.txt_class_info.Name = "txt_class_info";
            this.txt_class_info.Size = new System.Drawing.Size(452, 20);
            this.txt_class_info.TabIndex = 115;
            // 
            // cmb_modulo
            // 
            this.cmb_modulo.Location = new System.Drawing.Point(176, 48);
            this.cmb_modulo.Name = "cmb_modulo";
            this.cmb_modulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_modulo.Properties.DisplayMember = "Descripcion";
            this.cmb_modulo.Properties.ValueMember = "CodModulo";
            this.cmb_modulo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_modulo.Size = new System.Drawing.Size(219, 20);
            this.cmb_modulo.TabIndex = 134;
            this.cmb_modulo.EditValueChanged += new System.EventHandler(this.cmb_modulo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "CodModulo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 155;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Módulo";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 272;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Carpeta";
            this.gridColumn3.FieldName = "Nom_Carpeta";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 338;
            // 
            // FrmGe_Alerta_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 391);
            this.Controls.Add(this.cmb_modulo);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_class_rpt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_class_data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_class_bus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_asembly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tabla);
            this.Controls.Add(this.txt_obser);
            this.Controls.Add(this.txt_frm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_class_info);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmGe_Alerta_Mant";
            this.Text = "FrmGe_Alerta_Mant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGe_Alerta_Mant_FormClosed);
            this.Load += new System.EventHandler(this.FrmGe_Alerta_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_modulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_class_rpt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_class_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_class_bus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_asembly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tabla;
        private System.Windows.Forms.TextBox txt_obser;
        private System.Windows.Forms.TextBox txt_frm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_class_info;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_modulo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;

    }
}