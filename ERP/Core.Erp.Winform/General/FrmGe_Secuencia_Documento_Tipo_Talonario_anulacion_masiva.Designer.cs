namespace Core.Erp.Winform.General
{
    partial class FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva
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
            this.label1 = new System.Windows.Forms.Label();
            this.ultraCmbE_TipoDoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_doc_inicial = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_doc_final = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstablecimiento = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpuntoEmision = new DevExpress.XtraEditors.TextEdit();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chk_doc_electronico = new DevExpress.XtraEditors.CheckEdit();
            this.btn_buscar_egresos = new DevExpress.XtraEditors.SimpleButton();
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodDocumentoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Establecimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PuntoEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Usado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_TipoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablecimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpuntoEmision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_doc_electronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Documento:";
            // 
            // ultraCmbE_TipoDoc
            // 
            this.ultraCmbE_TipoDoc.Location = new System.Drawing.Point(181, 11);
            this.ultraCmbE_TipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.ultraCmbE_TipoDoc.Name = "ultraCmbE_TipoDoc";
            this.ultraCmbE_TipoDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbE_TipoDoc.Properties.DisplayMember = "descripcion";
            this.ultraCmbE_TipoDoc.Properties.NullText = "";
            this.ultraCmbE_TipoDoc.Properties.ValueMember = "codDocumentoTipo";
            this.ultraCmbE_TipoDoc.Properties.View = this.gridView4;
            this.ultraCmbE_TipoDoc.Size = new System.Drawing.Size(255, 22);
            this.ultraCmbE_TipoDoc.TabIndex = 5;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.col_descripcion});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "codDocumentoTipo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            this.Codigo.Width = 221;
            // 
            // col_descripcion
            // 
            this.col_descripcion.Caption = "Descripcion";
            this.col_descripcion.FieldName = "descripcion";
            this.col_descripcion.Name = "col_descripcion";
            this.col_descripcion.Visible = true;
            this.col_descripcion.VisibleIndex = 0;
            this.col_descripcion.Width = 920;
            // 
            // txt_doc_inicial
            // 
            this.txt_doc_inicial.Location = new System.Drawing.Point(181, 106);
            this.txt_doc_inicial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doc_inicial.Name = "txt_doc_inicial";
            this.txt_doc_inicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_doc_inicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_doc_inicial.Properties.Mask.BeepOnError = true;
            this.txt_doc_inicial.Properties.Mask.EditMask = "n0";
            this.txt_doc_inicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_doc_inicial.Properties.Mask.SaveLiteral = false;
            this.txt_doc_inicial.Size = new System.Drawing.Size(255, 22);
            this.txt_doc_inicial.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Documento Inicial:";
            // 
            // txt_doc_final
            // 
            this.txt_doc_final.Location = new System.Drawing.Point(181, 139);
            this.txt_doc_final.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doc_final.Name = "txt_doc_final";
            this.txt_doc_final.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_doc_final.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_doc_final.Properties.Mask.BeepOnError = true;
            this.txt_doc_final.Properties.Mask.EditMask = "n0";
            this.txt_doc_final.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_doc_final.Properties.Mask.SaveLiteral = false;
            this.txt_doc_final.Size = new System.Drawing.Size(255, 22);
            this.txt_doc_final.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Documento Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Punto Emision:";
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(181, 41);
            this.txtEstablecimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEstablecimiento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEstablecimiento.Properties.Mask.BeepOnError = true;
            this.txtEstablecimiento.Properties.Mask.SaveLiteral = false;
            this.txtEstablecimiento.Size = new System.Drawing.Size(131, 22);
            this.txtEstablecimiento.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Establecimiento:";
            // 
            // txtpuntoEmision
            // 
            this.txtpuntoEmision.Location = new System.Drawing.Point(181, 73);
            this.txtpuntoEmision.Margin = new System.Windows.Forms.Padding(4);
            this.txtpuntoEmision.Name = "txtpuntoEmision";
            this.txtpuntoEmision.Properties.Appearance.Options.UseTextOptions = true;
            this.txtpuntoEmision.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtpuntoEmision.Properties.Mask.BeepOnError = true;
            this.txtpuntoEmision.Properties.Mask.SaveLiteral = false;
            this.txtpuntoEmision.Size = new System.Drawing.Size(131, 22);
            this.txtpuntoEmision.TabIndex = 2;
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
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(956, 36);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 15;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant1_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chk_doc_electronico);
            this.panelControl1.Controls.Add(this.btn_buscar_egresos);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.ultraCmbE_TipoDoc);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtEstablecimiento);
            this.panelControl1.Controls.Add(this.txt_doc_inicial);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtpuntoEmision);
            this.panelControl1.Controls.Add(this.txt_doc_final);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 36);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(956, 171);
            this.panelControl1.TabIndex = 16;
            // 
            // chk_doc_electronico
            // 
            this.chk_doc_electronico.Location = new System.Drawing.Point(443, 13);
            this.chk_doc_electronico.Name = "chk_doc_electronico";
            this.chk_doc_electronico.Properties.Caption = "Es documento electronico";
            this.chk_doc_electronico.Size = new System.Drawing.Size(223, 21);
            this.chk_doc_electronico.TabIndex = 15;
            // 
            // btn_buscar_egresos
            // 
            this.btn_buscar_egresos.Image = global::Core.Erp.Winform.Properties.Resources.Buscar_16x16;
            this.btn_buscar_egresos.Location = new System.Drawing.Point(462, 138);
            this.btn_buscar_egresos.Name = "btn_buscar_egresos";
            this.btn_buscar_egresos.Size = new System.Drawing.Size(92, 23);
            this.btn_buscar_egresos.TabIndex = 5;
            this.btn_buscar_egresos.Text = "Buscar";
            this.btn_buscar_egresos.Click += new System.EventHandler(this.btn_buscar_egresos_Click);
            // 
            // gridConsulta
            // 
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridConsulta.Location = new System.Drawing.Point(0, 207);
            this.gridConsulta.MainView = this.gridViewConsulta;
            this.gridConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Check});
            this.gridConsulta.Size = new System.Drawing.Size(956, 391);
            this.gridConsulta.TabIndex = 17;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodDocumentoTipo,
            this.Establecimiento,
            this.PuntoEmision,
            this.NumDocumento,
            this.Usado,
            this.Estado,
            this.col_check});
            this.gridViewConsulta.GridControl = this.gridConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsBehavior.Editable = false;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowFooter = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            // 
            // CodDocumentoTipo
            // 
            this.CodDocumentoTipo.Caption = "CodDocumentoTipo";
            this.CodDocumentoTipo.FieldName = "CodDocumentoTipo";
            this.CodDocumentoTipo.Name = "CodDocumentoTipo";
            this.CodDocumentoTipo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodDocumentoTipo", "{0:n2}")});
            this.CodDocumentoTipo.Visible = true;
            this.CodDocumentoTipo.VisibleIndex = 1;
            this.CodDocumentoTipo.Width = 127;
            // 
            // Establecimiento
            // 
            this.Establecimiento.Caption = "Establecimiento";
            this.Establecimiento.FieldName = "Establecimiento";
            this.Establecimiento.Name = "Establecimiento";
            this.Establecimiento.Visible = true;
            this.Establecimiento.VisibleIndex = 2;
            this.Establecimiento.Width = 127;
            // 
            // PuntoEmision
            // 
            this.PuntoEmision.Caption = "Punto Emision";
            this.PuntoEmision.FieldName = "PuntoEmision";
            this.PuntoEmision.Name = "PuntoEmision";
            this.PuntoEmision.Visible = true;
            this.PuntoEmision.VisibleIndex = 3;
            this.PuntoEmision.Width = 127;
            // 
            // NumDocumento
            // 
            this.NumDocumento.Caption = "Numero Documento";
            this.NumDocumento.FieldName = "NumDocumento";
            this.NumDocumento.Name = "NumDocumento";
            this.NumDocumento.Visible = true;
            this.NumDocumento.VisibleIndex = 4;
            this.NumDocumento.Width = 127;
            // 
            // Usado
            // 
            this.Usado.Caption = "Usado";
            this.Usado.FieldName = "Usado";
            this.Usado.Name = "Usado";
            this.Usado.Visible = true;
            this.Usado.VisibleIndex = 5;
            this.Usado.Width = 127;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 6;
            this.Estado.Width = 139;
            // 
            // col_check
            // 
            this.col_check.Caption = "*";
            this.col_check.FieldName = "seleccionado";
            this.col_check.Name = "col_check";
            this.col_check.Visible = true;
            this.col_check.VisibleIndex = 0;
            this.col_check.Width = 37;
            // 
            // Check
            // 
            this.Check.AutoHeight = false;
            this.Check.Name = "Check";
            // 
            // FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 598);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Name = "FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anulación masiva";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed);
            this.Load += new System.EventHandler(this.FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_TipoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doc_final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablecimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpuntoEmision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_doc_electronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbE_TipoDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_descripcion;
        private DevExpress.XtraEditors.TextEdit txt_doc_inicial;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_doc_final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtEstablecimiento;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtpuntoEmision;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn CodDocumentoTipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit Check;
        private DevExpress.XtraGrid.Columns.GridColumn Establecimiento;
        private DevExpress.XtraGrid.Columns.GridColumn PuntoEmision;
        private DevExpress.XtraGrid.Columns.GridColumn NumDocumento;
        public DevExpress.XtraGrid.Columns.GridColumn Usado;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraEditors.SimpleButton btn_buscar_egresos;
        private DevExpress.XtraGrid.Columns.GridColumn col_check;
        private DevExpress.XtraEditors.CheckEdit chk_doc_electronico;
    }
}