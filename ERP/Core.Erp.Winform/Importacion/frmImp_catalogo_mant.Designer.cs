namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_catalogo_mant
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
            this.cmb_catalogo_tipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_IdCatalogo = new DevExpress.XtraEditors.TextEdit();
            this.txt_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_anulado = new DevExpress.XtraEditors.LabelControl();
            this.uc_menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_catalogo_tipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdCatalogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_catalogo_tipo
            // 
            this.cmb_catalogo_tipo.Location = new System.Drawing.Point(124, 84);
            this.cmb_catalogo_tipo.Name = "cmb_catalogo_tipo";
            this.cmb_catalogo_tipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_catalogo_tipo.Properties.DisplayMember = "ct_descripcion";
            this.cmb_catalogo_tipo.Properties.ValueMember = "IdCatalogo_tipo";
            this.cmb_catalogo_tipo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_catalogo_tipo.Size = new System.Drawing.Size(330, 22);
            this.cmb_catalogo_tipo.TabIndex = 0;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdCatalogo_tipo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 217;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descripción";
            this.gridColumn2.FieldName = "ct_descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 1517;
            // 
            // txt_IdCatalogo
            // 
            this.txt_IdCatalogo.Location = new System.Drawing.Point(124, 56);
            this.txt_IdCatalogo.Name = "txt_IdCatalogo";
            this.txt_IdCatalogo.Properties.ReadOnly = true;
            this.txt_IdCatalogo.Size = new System.Drawing.Size(100, 22);
            this.txt_IdCatalogo.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(124, 112);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(330, 22);
            this.txt_descripcion.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tipo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Descripción";
            // 
            // lbl_anulado
            // 
            this.lbl_anulado.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_anulado.Location = new System.Drawing.Point(256, 49);
            this.lbl_anulado.Name = "lbl_anulado";
            this.lbl_anulado.Size = new System.Drawing.Size(115, 28);
            this.lbl_anulado.TabIndex = 6;
            this.lbl_anulado.Text = "ANULADO";
            this.lbl_anulado.Visible = false;
            // 
            // uc_menu
            // 
            this.uc_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_menu.Enabled_bnRetImprimir = true;
            this.uc_menu.Enabled_bntAnular = true;
            this.uc_menu.Enabled_bntAprobar = true;
            this.uc_menu.Enabled_bntGuardar_y_Salir = true;
            this.uc_menu.Enabled_bntImprimir = true;
            this.uc_menu.Enabled_bntImprimir_Guia = true;
            this.uc_menu.Enabled_bntLimpiar = true;
            this.uc_menu.Enabled_bntSalir = true;
            this.uc_menu.Enabled_btn_conciliacion_Auto = true;
            this.uc_menu.Enabled_btn_DiseñoReporte = true;
            this.uc_menu.Enabled_btn_Generar_XML = true;
            this.uc_menu.Enabled_btn_Imprimir_Cbte = true;
            this.uc_menu.Enabled_btn_Imprimir_Cheq = true;
            this.uc_menu.Enabled_btn_Imprimir_Reten = true;
            this.uc_menu.Enabled_btnAceptar = true;
            this.uc_menu.Enabled_btnAprobarGuardarSalir = true;
            this.uc_menu.Enabled_btnEstadosOC = true;
            this.uc_menu.Enabled_btnGuardar = true;
            this.uc_menu.Enabled_btnImpFrm = true;
            this.uc_menu.Enabled_btnImpLote = true;
            this.uc_menu.Enabled_btnImpRep = true;
            this.uc_menu.Enabled_btnImprimirSoporte = true;
            this.uc_menu.Enabled_btnproductos = true;
            this.uc_menu.Location = new System.Drawing.Point(0, 0);
            this.uc_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uc_menu.Name = "uc_menu";
            this.uc_menu.Size = new System.Drawing.Size(516, 28);
            this.uc_menu.TabIndex = 7;
            this.uc_menu.Visible_bntAnular = true;
            this.uc_menu.Visible_bntAprobar = false;
            this.uc_menu.Visible_bntDiseñoReporte = false;
            this.uc_menu.Visible_bntGuardar_y_Salir = true;
            this.uc_menu.Visible_bntImprimir = false;
            this.uc_menu.Visible_bntImprimir_Guia = false;
            this.uc_menu.Visible_bntLimpiar = true;
            this.uc_menu.Visible_bntReImprimir = false;
            this.uc_menu.Visible_bntSalir = true;
            this.uc_menu.Visible_btn_Actualizar = false;
            this.uc_menu.Visible_btn_conciliacion_Auto = false;
            this.uc_menu.Visible_btn_Generar_XML = false;
            this.uc_menu.Visible_btn_Imprimir_Cbte = false;
            this.uc_menu.Visible_btn_Imprimir_Cheq = false;
            this.uc_menu.Visible_btn_Imprimir_Reten = false;
            this.uc_menu.Visible_btnAceptar = false;
            this.uc_menu.Visible_btnAprobarGuardarSalir = false;
            this.uc_menu.Visible_btnContabilizar = false;
            this.uc_menu.Visible_btnEstadosOC = false;
            this.uc_menu.Visible_btnGuardar = true;
            this.uc_menu.Visible_btnImpFrm = false;
            this.uc_menu.Visible_btnImpLote = false;
            this.uc_menu.Visible_btnImpRep = false;
            this.uc_menu.Visible_btnImprimirSoporte = false;
            this.uc_menu.Visible_btnModificar = false;
            this.uc_menu.Visible_btnproductos = false;
            this.uc_menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.uc_menu_event_btnGuardar_Click);
            this.uc_menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.uc_menu_event_btnGuardar_y_Salir_Click);
            this.uc_menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.uc_menu_event_btnlimpiar_Click);
            this.uc_menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.uc_menu_event_btnAnular_Click);
            this.uc_menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.uc_menu_event_btnSalir_Click);
            // 
            // frmImp_catalogo_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 169);
            this.Controls.Add(this.uc_menu);
            this.Controls.Add(this.lbl_anulado);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_IdCatalogo);
            this.Controls.Add(this.cmb_catalogo_tipo);
            this.Name = "frmImp_catalogo_mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.frmImp_catalogo_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_catalogo_tipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdCatalogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_catalogo_tipo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txt_IdCatalogo;
        private DevExpress.XtraEditors.TextEdit txt_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbl_anulado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private Controles.UCGe_Menu_Superior_Mant uc_menu;
    }
}