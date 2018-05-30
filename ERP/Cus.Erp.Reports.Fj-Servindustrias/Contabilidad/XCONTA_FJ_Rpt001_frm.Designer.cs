namespace Cus.Erp.Reports.FJ.Contabilidad
{
    partial class XCONTA_FJ_Rpt001_frm
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
            this.pivot_balance = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.col_IdCtaCble = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_pc_Cuenta = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_IdPunto_cargo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_nom_punto_cargo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_pc_GrupoCble = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_bg_saldo_inicial = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_bg_debitos_mes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_bg_creditos_mes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_bg_saldo_mes = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_bg_saldo_final = new DevExpress.XtraPivotGrid.PivotGridField();
            this.uCct_Menu_Reportes1 = new Core.Erp.Reportes.Controles.UCct_Menu_Reportes();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Cus.Erp.Reports.FJ.frm_espere_fj), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.pivot_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // pivot_balance
            // 
            this.pivot_balance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivot_balance.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.col_IdCtaCble,
            this.col_pc_Cuenta,
            this.col_IdPunto_cargo,
            this.col_nom_punto_cargo,
            this.col_pc_GrupoCble,
            this.col_bg_saldo_inicial,
            this.col_bg_debitos_mes,
            this.col_bg_creditos_mes,
            this.col_bg_saldo_mes,
            this.col_bg_saldo_final});
            this.pivot_balance.Location = new System.Drawing.Point(0, 116);
            this.pivot_balance.Margin = new System.Windows.Forms.Padding(4);
            this.pivot_balance.Name = "pivot_balance";
            this.pivot_balance.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivot_balance.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivot_balance.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivot_balance.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivot_balance.OptionsView.ShowRowGrandTotals = false;
            this.pivot_balance.Size = new System.Drawing.Size(1073, 469);
            this.pivot_balance.TabIndex = 1;
            this.pivot_balance.CustomAppearance += new DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(this.pivot_balance_CustomAppearance);
            // 
            // col_IdCtaCble
            // 
            this.col_IdCtaCble.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.col_IdCtaCble.AreaIndex = 0;
            this.col_IdCtaCble.Caption = "IdCtaCble";
            this.col_IdCtaCble.FieldName = "IdCtaCble_2";
            this.col_IdCtaCble.Name = "col_IdCtaCble";
            // 
            // col_pc_Cuenta
            // 
            this.col_pc_Cuenta.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.col_pc_Cuenta.AreaIndex = 1;
            this.col_pc_Cuenta.Caption = "Cuenta";
            this.col_pc_Cuenta.FieldName = "pc_Cuenta";
            this.col_pc_Cuenta.Name = "col_pc_Cuenta";
            // 
            // col_IdPunto_cargo
            // 
            this.col_IdPunto_cargo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.col_IdPunto_cargo.AreaIndex = 0;
            this.col_IdPunto_cargo.Caption = "IdPunto_cargo";
            this.col_IdPunto_cargo.FieldName = "IdPunto_cargo";
            this.col_IdPunto_cargo.Name = "col_IdPunto_cargo";
            // 
            // col_nom_punto_cargo
            // 
            this.col_nom_punto_cargo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.col_nom_punto_cargo.AreaIndex = 1;
            this.col_nom_punto_cargo.Caption = "Punto de cargo";
            this.col_nom_punto_cargo.FieldName = "nom_punto_cargo";
            this.col_nom_punto_cargo.Name = "col_nom_punto_cargo";
            // 
            // col_pc_GrupoCble
            // 
            this.col_pc_GrupoCble.AreaIndex = 0;
            this.col_pc_GrupoCble.Caption = "Grupo contable";
            this.col_pc_GrupoCble.FieldName = "gc_GrupoCble";
            this.col_pc_GrupoCble.Name = "col_pc_GrupoCble";
            // 
            // col_bg_saldo_inicial
            // 
            this.col_bg_saldo_inicial.AreaIndex = 1;
            this.col_bg_saldo_inicial.Caption = "Saldo inicial";
            this.col_bg_saldo_inicial.CellFormat.FormatString = "n2";
            this.col_bg_saldo_inicial.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_saldo_inicial.FieldName = "bg_saldo_inicial";
            this.col_bg_saldo_inicial.Name = "col_bg_saldo_inicial";
            this.col_bg_saldo_inicial.TotalCellFormat.FormatString = "n2";
            this.col_bg_saldo_inicial.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_saldo_inicial.ValueFormat.FormatString = "n2";
            this.col_bg_saldo_inicial.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // col_bg_debitos_mes
            // 
            this.col_bg_debitos_mes.AreaIndex = 2;
            this.col_bg_debitos_mes.Caption = "Débitos";
            this.col_bg_debitos_mes.CellFormat.FormatString = "n2";
            this.col_bg_debitos_mes.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_debitos_mes.FieldName = "bg_debitos_mes";
            this.col_bg_debitos_mes.Name = "col_bg_debitos_mes";
            this.col_bg_debitos_mes.TotalCellFormat.FormatString = "n2";
            this.col_bg_debitos_mes.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_debitos_mes.UseNativeFormat = DevExpress.Utils.DefaultBoolean.True;
            this.col_bg_debitos_mes.ValueFormat.FormatString = "n2";
            this.col_bg_debitos_mes.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // col_bg_creditos_mes
            // 
            this.col_bg_creditos_mes.AreaIndex = 3;
            this.col_bg_creditos_mes.Caption = "Créditos";
            this.col_bg_creditos_mes.CellFormat.FormatString = "n2";
            this.col_bg_creditos_mes.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_creditos_mes.FieldName = "bg_creditos_mes";
            this.col_bg_creditos_mes.Name = "col_bg_creditos_mes";
            this.col_bg_creditos_mes.TotalCellFormat.FormatString = "n2";
            this.col_bg_creditos_mes.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_creditos_mes.ValueFormat.FormatString = "n2";
            this.col_bg_creditos_mes.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // col_bg_saldo_mes
            // 
            this.col_bg_saldo_mes.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.col_bg_saldo_mes.AreaIndex = 0;
            this.col_bg_saldo_mes.Caption = "Saldo intervalo";
            this.col_bg_saldo_mes.CellFormat.FormatString = "n2";
            this.col_bg_saldo_mes.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_saldo_mes.FieldName = "bg_saldo_mes";
            this.col_bg_saldo_mes.Name = "col_bg_saldo_mes";
            this.col_bg_saldo_mes.TotalCellFormat.FormatString = "n2";
            this.col_bg_saldo_mes.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_saldo_mes.ValueFormat.FormatString = "n2";
            this.col_bg_saldo_mes.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // col_bg_saldo_final
            // 
            this.col_bg_saldo_final.AreaIndex = 4;
            this.col_bg_saldo_final.Caption = "Saldo final";
            this.col_bg_saldo_final.CellFormat.FormatString = "n2";
            this.col_bg_saldo_final.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_saldo_final.FieldName = "bg_saldo_final";
            this.col_bg_saldo_final.Name = "col_bg_saldo_final";
            this.col_bg_saldo_final.TotalCellFormat.FormatString = "n2";
            this.col_bg_saldo_final.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_bg_saldo_final.ValueFormat.FormatString = "n2";
            this.col_bg_saldo_final.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // uCct_Menu_Reportes1
            // 
            this.uCct_Menu_Reportes1.caption_bei_Check = "Mostrar saldo 0";
            this.uCct_Menu_Reportes1.caption_bei_Check2 = "Check";
            this.uCct_Menu_Reportes1.caption_bei_Check3 = "Check";
            this.uCct_Menu_Reportes1.caption_bei_Check4 = "Check";
            this.uCct_Menu_Reportes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uCct_Menu_Reportes1.Location = new System.Drawing.Point(0, 0);
            this.uCct_Menu_Reportes1.Margin = new System.Windows.Forms.Padding(5);
            this.uCct_Menu_Reportes1.Name = "uCct_Menu_Reportes1";
            this.uCct_Menu_Reportes1.Size = new System.Drawing.Size(1073, 116);
            this.uCct_Menu_Reportes1.TabIndex = 0;
            this.uCct_Menu_Reportes1.Visible_bei_Check2 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Check3 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Check4 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_CtaCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Desde = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_GrupoCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_GrupoCble_chk = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes1.Visible_bei_Hasta = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_Nivel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_bei_punto_cargo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_btn_Mostrar_en_tabla = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes1.Visible_Grupo_centro_costo = false;
            this.uCct_Menu_Reportes1.Visible_Grupo_Check = true;
            this.uCct_Menu_Reportes1.Visible_Grupo_cuentas = true;
            this.uCct_Menu_Reportes1.Visible_Grupo_Punto_cargo = true;
            this.uCct_Menu_Reportes1.event_btnConsultar_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btnConsultar_ItemClick(this.uCct_Menu_Reportes1_event_btnConsultar_ItemClick);
            this.uCct_Menu_Reportes1.event_btnSalir_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btnSalir_ItemClick(this.uCct_Menu_Reportes1_event_btnSalir_ItemClick);
            this.uCct_Menu_Reportes1.event_btn_Mostrar_en_tabla_ItemClick += new Core.Erp.Reportes.Controles.UCct_Menu_Reportes.delegate_btn_Mostrar_en_tabla_ItemClick(this.uCct_Menu_Reportes1_event_btn_Mostrar_en_tabla_ItemClick);
            // 
            // XCONTA_FJ_Rpt001_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 585);
            this.Controls.Add(this.pivot_balance);
            this.Controls.Add(this.uCct_Menu_Reportes1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XCONTA_FJ_Rpt001_frm";
            this.Text = "XCONTA_FJ_Rpt001_frm";
            this.Load += new System.EventHandler(this.XCONTA_FJ_Rpt001_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivot_balance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Erp.Reportes.Controles.UCct_Menu_Reportes uCct_Menu_Reportes1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivot_balance;
        private DevExpress.XtraPivotGrid.PivotGridField col_IdCtaCble;
        private DevExpress.XtraPivotGrid.PivotGridField col_pc_Cuenta;
        private DevExpress.XtraPivotGrid.PivotGridField col_IdPunto_cargo;
        private DevExpress.XtraPivotGrid.PivotGridField col_nom_punto_cargo;
        private DevExpress.XtraPivotGrid.PivotGridField col_pc_GrupoCble;
        private DevExpress.XtraPivotGrid.PivotGridField col_bg_saldo_inicial;
        private DevExpress.XtraPivotGrid.PivotGridField col_bg_debitos_mes;
        private DevExpress.XtraPivotGrid.PivotGridField col_bg_creditos_mes;
        private DevExpress.XtraPivotGrid.PivotGridField col_bg_saldo_mes;
        private DevExpress.XtraPivotGrid.PivotGridField col_bg_saldo_final;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;

    }
}