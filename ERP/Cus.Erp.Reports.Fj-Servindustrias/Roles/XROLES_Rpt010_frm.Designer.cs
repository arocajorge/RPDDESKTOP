namespace Cus.Erp.Reports.FJ.Roles
{
    partial class XROLES_Rpt010_frm
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.Col_pe_cedulaRuc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_pe_nombre = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_Cargo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_SueldoActual = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_Valor_bono = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_es_fechaRegistro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_dias_trabajados = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_sueldo_x_dias_trabajados = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_HorasExtras = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_variable = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_alimentacio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_transporte = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_Iess = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_TipoAsistencia = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_FechaInicio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_FechaFin = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_TotalPagar = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ucRo_Menu = new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes();
            this.Col_fu_descripcion = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.ColumnHeaderArea.ForeColor = System.Drawing.Color.Yellow;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.Col_pe_cedulaRuc,
            this.Col_pe_nombre,
            this.Col_Cargo,
            this.Col_SueldoActual,
            this.Col_Valor_bono,
            this.Col_es_fechaRegistro,
            this.Col_dias_trabajados,
            this.Col_sueldo_x_dias_trabajados,
            this.Col_HorasExtras,
            this.Col_variable,
            this.Col_alimentacio,
            this.Col_transporte,
            this.Col_Iess,
            this.Col_TipoAsistencia,
            this.Col_FechaInicio,
            this.Col_FechaFin,
            this.Col_TotalPagar,
            this.Col_fu_descripcion});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 74);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control;
            this.pivotGridControl1.OptionsPrint.MergeColumnFieldValues = false;
            this.pivotGridControl1.OptionsPrint.MergeRowFieldValues = false;
            this.pivotGridControl1.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivotGridControl1.OptionsPrint.UsePrintAppearance = true;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1332, 357);
            this.pivotGridControl1.TabIndex = 147;
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_pe_cedulaRuc.AreaIndex = 0;
            this.Col_pe_cedulaRuc.Caption = "Cedula";
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Options.ReadOnly = true;
            this.Col_pe_cedulaRuc.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.Col_pe_cedulaRuc.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            // 
            // Col_pe_nombre
            // 
            this.Col_pe_nombre.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_pe_nombre.AreaIndex = 1;
            this.Col_pe_nombre.Caption = "Empleado";
            this.Col_pe_nombre.FieldName = "Empleado";
            this.Col_pe_nombre.Name = "Col_pe_nombre";
            this.Col_pe_nombre.Options.ReadOnly = true;
            // 
            // Col_Cargo
            // 
            this.Col_Cargo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_Cargo.AreaIndex = 2;
            this.Col_Cargo.Caption = "Cargo";
            this.Col_Cargo.FieldName = "ca_descripcion";
            this.Col_Cargo.Name = "Col_Cargo";
            this.Col_Cargo.Options.ReadOnly = true;
            // 
            // Col_SueldoActual
            // 
            this.Col_SueldoActual.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_SueldoActual.AreaIndex = 4;
            this.Col_SueldoActual.Caption = "Sueldo Actual";
            this.Col_SueldoActual.FieldName = "SueldoActual";
            this.Col_SueldoActual.Name = "Col_SueldoActual";
            // 
            // Col_Valor_bono
            // 
            this.Col_Valor_bono.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_Valor_bono.AreaIndex = 5;
            this.Col_Valor_bono.Caption = "Bono";
            this.Col_Valor_bono.FieldName = "Valor_bono";
            this.Col_Valor_bono.Name = "Col_Valor_bono";
            // 
            // Col_es_fechaRegistro
            // 
            this.Col_es_fechaRegistro.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Col_es_fechaRegistro.AreaIndex = 0;
            this.Col_es_fechaRegistro.Caption = "Fecha";
            this.Col_es_fechaRegistro.FieldName = "es_fechaRegistro";
            this.Col_es_fechaRegistro.GrandTotalCellFormat.FormatString = "d";
            this.Col_es_fechaRegistro.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Col_es_fechaRegistro.Name = "Col_es_fechaRegistro";
            // 
            // Col_dias_trabajados
            // 
            this.Col_dias_trabajados.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_dias_trabajados.AreaIndex = 6;
            this.Col_dias_trabajados.Caption = "Dias Trabajados";
            this.Col_dias_trabajados.FieldName = "dias_trabajados";
            this.Col_dias_trabajados.Name = "Col_dias_trabajados";
            // 
            // Col_sueldo_x_dias_trabajados
            // 
            this.Col_sueldo_x_dias_trabajados.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_sueldo_x_dias_trabajados.AreaIndex = 7;
            this.Col_sueldo_x_dias_trabajados.Caption = "Sueldo x dias trabajados";
            this.Col_sueldo_x_dias_trabajados.FieldName = "sueldo_x_dias_trabajados";
            this.Col_sueldo_x_dias_trabajados.Name = "Col_sueldo_x_dias_trabajados";
            // 
            // Col_HorasExtras
            // 
            this.Col_HorasExtras.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_HorasExtras.AreaIndex = 8;
            this.Col_HorasExtras.Caption = "Horas extras";
            this.Col_HorasExtras.FieldName = "HorasExtras";
            this.Col_HorasExtras.Name = "Col_HorasExtras";
            // 
            // Col_variable
            // 
            this.Col_variable.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_variable.AreaIndex = 9;
            this.Col_variable.Caption = "Variable";
            this.Col_variable.FieldName = "variable";
            this.Col_variable.Name = "Col_variable";
            // 
            // Col_alimentacio
            // 
            this.Col_alimentacio.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_alimentacio.AreaIndex = 10;
            this.Col_alimentacio.Caption = "alimentacio";
            this.Col_alimentacio.FieldName = "alimentacio";
            this.Col_alimentacio.Name = "Col_alimentacio";
            // 
            // Col_transporte
            // 
            this.Col_transporte.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_transporte.AreaIndex = 11;
            this.Col_transporte.Caption = "Transporte";
            this.Col_transporte.FieldName = "transporte";
            this.Col_transporte.Name = "Col_transporte";
            // 
            // Col_Iess
            // 
            this.Col_Iess.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_Iess.AreaIndex = 12;
            this.Col_Iess.Caption = "Iess";
            this.Col_Iess.FieldName = "Iess";
            this.Col_Iess.Name = "Col_Iess";
            // 
            // Col_TipoAsistencia
            // 
            this.Col_TipoAsistencia.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.Col_TipoAsistencia.AreaIndex = 0;
            this.Col_TipoAsistencia.Caption = "Asistencia";
            this.Col_TipoAsistencia.FieldName = "TipoAsistencia";
            this.Col_TipoAsistencia.Name = "Col_TipoAsistencia";
            this.Col_TipoAsistencia.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            // 
            // Col_FechaInicio
            // 
            this.Col_FechaInicio.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_FechaInicio.AreaIndex = 13;
            this.Col_FechaInicio.Caption = "Fecha Ingreso";
            this.Col_FechaInicio.FieldName = "FechaInicio";
            this.Col_FechaInicio.GrandTotalCellFormat.FormatString = "d";
            this.Col_FechaInicio.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Col_FechaInicio.Name = "Col_FechaInicio";
            // 
            // Col_FechaFin
            // 
            this.Col_FechaFin.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_FechaFin.AreaIndex = 14;
            this.Col_FechaFin.Caption = "Fecha Salida";
            this.Col_FechaFin.FieldName = "FechaFin";
            this.Col_FechaFin.GrandTotalCellFormat.FormatString = "d";
            this.Col_FechaFin.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Col_FechaFin.Name = "Col_FechaFin";
            // 
            // Col_TotalPagar
            // 
            this.Col_TotalPagar.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_TotalPagar.AreaIndex = 15;
            this.Col_TotalPagar.Caption = "Valor a recibir";
            this.Col_TotalPagar.FieldName = "TotalPagar";
            this.Col_TotalPagar.Name = "Col_TotalPagar";
            // 
            // ucRo_Menu
            // 
            this.ucRo_Menu.caption_bei_check1 = "Check";
            this.ucRo_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucRo_Menu.EnableBotonImprimir = true;
            this.ucRo_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucRo_Menu.Name = "ucRo_Menu";
            this.ucRo_Menu.Size = new System.Drawing.Size(1332, 74);
            this.ucRo_Menu.TabIndex = 146;
            this.ucRo_Menu.Visible_bei_check1 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbCentroCosto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbDivision = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbEmpleado = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbNominaTipo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbNominaTipoLiqui = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbPeriodo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbRubro = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleDepartamento = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleEstado = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleGrupoFecha = false;
            this.ucRo_Menu.VisibleGrupoFiltro1 = true;
            this.ucRo_Menu.VisibleGrupoFiltro2 = false;
            this.ucRo_Menu.VisubleArea = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.event_cmbPeriodo_EditValueChanged += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_cmbPeriodo_EditValueChanged(this.ucRo_Menu_event_cmbPeriodo_EditValueChanged_1);
            this.ucRo_Menu.event_cmdCargar_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_cmdCargar_ItemClick(this.ucRo_Menu_event_cmdCargar_ItemClick);
            this.ucRo_Menu.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucRo_Menu_event_btnsalir_ItemClick);
            // 
            // Col_fu_descripcion
            // 
            this.Col_fu_descripcion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_fu_descripcion.AreaIndex = 3;
            this.Col_fu_descripcion.Caption = "Fuerza";
            this.Col_fu_descripcion.FieldName = "fu_descripcion";
            this.Col_fu_descripcion.Name = "Col_fu_descripcion";
            // 
            // XROLES_Rpt010_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 431);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.ucRo_Menu);
            this.Name = "XROLES_Rpt010_frm";
            this.Text = "CONTROL DE ASISTENCIA TRANSGANDIA FJ FIJOS";
            this.Load += new System.EventHandler(this.XROLES_Rpt010_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Erp.Reportes.Controles.UCRo_Menu_Reportes ucRo_Menu;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField Col_pe_cedulaRuc;
        private DevExpress.XtraPivotGrid.PivotGridField Col_pe_nombre;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Cargo;
        private DevExpress.XtraPivotGrid.PivotGridField Col_SueldoActual;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Valor_bono;
        private DevExpress.XtraPivotGrid.PivotGridField Col_es_fechaRegistro;
        private DevExpress.XtraPivotGrid.PivotGridField Col_dias_trabajados;
        private DevExpress.XtraPivotGrid.PivotGridField Col_sueldo_x_dias_trabajados;
        private DevExpress.XtraPivotGrid.PivotGridField Col_HorasExtras;
        private DevExpress.XtraPivotGrid.PivotGridField Col_variable;
        private DevExpress.XtraPivotGrid.PivotGridField Col_alimentacio;
        private DevExpress.XtraPivotGrid.PivotGridField Col_transporte;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Iess;
        private DevExpress.XtraPivotGrid.PivotGridField Col_TipoAsistencia;
        private DevExpress.XtraPivotGrid.PivotGridField Col_FechaInicio;
        private DevExpress.XtraPivotGrid.PivotGridField Col_FechaFin;
        private DevExpress.XtraPivotGrid.PivotGridField Col_TotalPagar;
        private DevExpress.XtraPivotGrid.PivotGridField Col_fu_descripcion;



    }
}