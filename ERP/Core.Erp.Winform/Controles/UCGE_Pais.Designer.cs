namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Pais
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPais = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNacionalidad = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPais
            // 
            this.cmbPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPais.Location = new System.Drawing.Point(0, 0);
            this.cmbPais.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPais.Properties.View = this.searchLookUpEdit1View;
            this.cmbPais.Size = new System.Drawing.Size(217, 22);
            this.cmbPais.TabIndex = 1;
            this.cmbPais.EditValueChanged += new System.EventHandler(this.cmbPais_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPais,
            this.colIdPais,
            this.ColNacionalidad});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPais
            // 
            this.colPais.Caption = "Pais";
            this.colPais.FieldName = "Nombre";
            this.colPais.Name = "colPais";
            this.colPais.Visible = true;
            this.colPais.VisibleIndex = 1;
            this.colPais.Width = 656;
            // 
            // colIdPais
            // 
            this.colIdPais.Caption = "ID";
            this.colIdPais.FieldName = "IdPais";
            this.colIdPais.Name = "colIdPais";
            this.colIdPais.Visible = true;
            this.colIdPais.VisibleIndex = 0;
            this.colIdPais.Width = 149;
            // 
            // ColNacionalidad
            // 
            this.ColNacionalidad.Caption = "Nacionalidad";
            this.ColNacionalidad.FieldName = "Nacionalidad";
            this.ColNacionalidad.Name = "ColNacionalidad";
            this.ColNacionalidad.Visible = true;
            this.ColNacionalidad.VisibleIndex = 2;
            this.ColNacionalidad.Width = 911;
            // 
            // UCGe_Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPais);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCGe_Pais";
            this.Size = new System.Drawing.Size(217, 25);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPais;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPais;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbPais;
        private DevExpress.XtraGrid.Columns.GridColumn ColNacionalidad;
    }
}
