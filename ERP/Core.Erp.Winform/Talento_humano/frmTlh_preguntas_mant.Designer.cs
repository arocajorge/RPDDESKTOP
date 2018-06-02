namespace Core.Erp.Winform.Talento_humano
{
    partial class frmTlh_preguntas_mant
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
            this.txtpregunta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_anulado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_num_preguntas = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_opciones = new DevExpress.XtraGrid.GridControl();
            this.gridView_opciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_opcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpregunta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_num_preguntas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_opciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_opciones)).BeginInit();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(463, 29);
            this.ucGe_Menu.TabIndex = 11;
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtpregunta);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.lbl_anulado);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.cmb_num_preguntas);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 113);
            this.panel1.TabIndex = 12;
            // 
            // txtpregunta
            // 
            this.txtpregunta.Location = new System.Drawing.Point(111, 85);
            this.txtpregunta.Name = "txtpregunta";
            this.txtpregunta.Size = new System.Drawing.Size(340, 20);
            this.txtpregunta.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Pregunta: *";
            // 
            // lbl_anulado
            // 
            this.lbl_anulado.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_anulado.Location = new System.Drawing.Point(157, 2);
            this.lbl_anulado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_anulado.Name = "lbl_anulado";
            this.lbl_anulado.Size = new System.Drawing.Size(110, 27);
            this.lbl_anulado.TabIndex = 17;
            this.lbl_anulado.Text = "ANULADO";
            this.lbl_anulado.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "ID";
            // 
            // cmb_num_preguntas
            // 
            this.cmb_num_preguntas.Location = new System.Drawing.Point(111, 59);
            this.cmb_num_preguntas.Name = "cmb_num_preguntas";
            this.cmb_num_preguntas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_num_preguntas.Properties.DisplayMember = "Value";
            this.cmb_num_preguntas.Properties.NullText = "-- Seleccione un registro --";
            this.cmb_num_preguntas.Properties.ValueMember = "Key";
            this.cmb_num_preguntas.Properties.View = this.searchLookUpEdit1View;
            this.cmb_num_preguntas.Size = new System.Drawing.Size(116, 20);
            this.cmb_num_preguntas.TabIndex = 15;
            this.cmb_num_preguntas.EditValueChanged += new System.EventHandler(this.cmb_num_preguntas_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Value});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Value
            // 
            this.Col_Value.Caption = "Opciones";
            this.Col_Value.FieldName = "Value";
            this.Col_Value.Name = "Col_Value";
            this.Col_Value.Visible = true;
            this.Col_Value.VisibleIndex = 0;
            this.Col_Value.Width = 1055;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Nº opciones : *";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(111, 37);
            this.txtid.Name = "txtid";
            this.txtid.Properties.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(116, 20);
            this.txtid.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl_opciones);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 142);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(463, 178);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "OPCIONES DE LA PREGUNTA";
            // 
            // gridControl_opciones
            // 
            this.gridControl_opciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_opciones.Location = new System.Drawing.Point(2, 21);
            this.gridControl_opciones.MainView = this.gridView_opciones;
            this.gridControl_opciones.Name = "gridControl_opciones";
            this.gridControl_opciones.Size = new System.Drawing.Size(459, 155);
            this.gridControl_opciones.TabIndex = 0;
            this.gridControl_opciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_opciones});
            // 
            // gridView_opciones
            // 
            this.gridView_opciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_opcion,
            this.Col_descripcion});
            this.gridView_opciones.GridControl = this.gridControl_opciones;
            this.gridView_opciones.Name = "gridView_opciones";
            this.gridView_opciones.OptionsView.ShowGroupPanel = false;
            this.gridView_opciones.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_opciones.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // Col_opcion
            // 
            this.Col_opcion.Caption = "Nº";
            this.Col_opcion.FieldName = "secuencia";
            this.Col_opcion.Name = "Col_opcion";
            this.Col_opcion.Visible = true;
            this.Col_opcion.VisibleIndex = 0;
            this.Col_opcion.Width = 73;
            // 
            // Col_descripcion
            // 
            this.Col_descripcion.Caption = "Opcion";
            this.Col_descripcion.FieldName = "Descripcion_opcion";
            this.Col_descripcion.Name = "Col_descripcion";
            this.Col_descripcion.Visible = true;
            this.Col_descripcion.VisibleIndex = 1;
            this.Col_descripcion.Width = 370;
            // 
            // frmTlh_preguntas_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 320);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmTlh_preguntas_mant";
            this.Text = "Preguntas  Mantenimiento";
            this.Load += new System.EventHandler(this.frmTlh_preguntas_mant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpregunta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_num_preguntas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_opciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_opciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbl_anulado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_num_preguntas;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Value;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtpregunta;
        private DevExpress.XtraGrid.GridControl gridControl_opciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_opciones;
        private DevExpress.XtraGrid.Columns.GridColumn Col_opcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_descripcion;
    }
}