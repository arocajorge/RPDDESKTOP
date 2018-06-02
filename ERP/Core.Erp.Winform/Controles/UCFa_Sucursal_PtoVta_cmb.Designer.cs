namespace Core.Erp.Winform.Controles
{
    partial class UCFa_Sucursal_PtoVta_cmb
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colestado_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_PtoVta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_PuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_PuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_sucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PtoVta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // colestado_
            // 
            this.colestado_.Caption = "Estado";
            this.colestado_.FieldName = "estado";
            this.colestado_.Name = "colestado_";
            this.colestado_.Visible = true;
            this.colestado_.VisibleIndex = 3;
            this.colestado_.Width = 108;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 93;
            // 
            // cmb_PtoVta
            // 
            this.cmb_PtoVta.Location = new System.Drawing.Point(3, 26);
            this.cmb_PtoVta.Name = "cmb_PtoVta";
            this.cmb_PtoVta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_PtoVta.Properties.DisplayMember = "nom_PuntoVta2";
            this.cmb_PtoVta.Properties.ValueMember = "IdPuntoVta";
            this.cmb_PtoVta.Properties.View = this.searchLookUpEdit2View;
            this.cmb_PtoVta.Size = new System.Drawing.Size(300, 20);
            this.cmb_PtoVta.TabIndex = 10;
            this.cmb_PtoVta.EditValueChanged += new System.EventHandler(this.UCIn_Sucursal_Bodega_Event_cmb_PtoVta_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPuntoVta,
            this.colcod_PuntoVta,
            this.colnom_PuntoVta,
            this.colestado_});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colestado_;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = false;
            this.searchLookUpEdit2View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3});
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPuntoVta
            // 
            this.colIdPuntoVta.Caption = "IdPuntoVta";
            this.colIdPuntoVta.FieldName = "IdPuntoVta";
            this.colIdPuntoVta.Name = "colIdPuntoVta";
            this.colIdPuntoVta.Visible = true;
            this.colIdPuntoVta.VisibleIndex = 2;
            // 
            // colcod_PuntoVta
            // 
            this.colcod_PuntoVta.Caption = "Codigo";
            this.colcod_PuntoVta.FieldName = "cod_PuntoVta";
            this.colcod_PuntoVta.Name = "colcod_PuntoVta";
            this.colcod_PuntoVta.Visible = true;
            this.colcod_PuntoVta.VisibleIndex = 0;
            this.colcod_PuntoVta.Width = 98;
            // 
            // colnom_PuntoVta
            // 
            this.colnom_PuntoVta.Caption = "PuntoVta";
            this.colnom_PuntoVta.FieldName = "nom_PuntoVta";
            this.colnom_PuntoVta.Name = "colnom_PuntoVta";
            this.colnom_PuntoVta.Visible = true;
            this.colnom_PuntoVta.VisibleIndex = 1;
            this.colnom_PuntoVta.Width = 875;
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Location = new System.Drawing.Point(3, 3);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmb_sucursal.Properties.ValueMember = "IdSucursal";
            this.cmb_sucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmb_sucursal.Size = new System.Drawing.Size(300, 20);
            this.cmb_sucursal.TabIndex = 9;
            this.cmb_sucursal.EditValueChanged += new System.EventHandler(this.UCIn_Sucursal_Bodega_Event_cmb_sucursal_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSucursal,
            this.colSu_Descripcion,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.colEstado;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = false;
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition4});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "IdSucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Visible = true;
            this.colIdSucursal.VisibleIndex = 0;
            this.colIdSucursal.Width = 219;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Descripción";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 1;
            this.colSu_Descripcion.Width = 868;
            // 
            // UCFa_Sucursal_PtoVta_cmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_PtoVta);
            this.Controls.Add(this.cmb_sucursal);
            this.Name = "UCFa_Sucursal_PtoVta_cmb";
            this.Size = new System.Drawing.Size(308, 48);
            this.Load += new System.EventHandler(this.UCFa_Sucursal_PtoCargo_cmb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PtoVta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SearchLookUpEdit cmb_PtoVta;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_PuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_PuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_sucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}
