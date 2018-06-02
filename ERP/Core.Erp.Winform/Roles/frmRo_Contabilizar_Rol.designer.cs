namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Contabilizar_Rol
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
            this.dteFechaContabilidad = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucRo_Periodo = new Core.Erp.Winform.Controles.UCRo_PeriodoXNomina();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cmdContabilizar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdReversoContabilidad = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ucCon_GridDiarioContable2 = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.ucCon_GridDiarioContable1 = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.roperiodoxroNominaTipoLiquiInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roperiodoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.Roles.frmRo_WaitForm_Espera), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaContabilidad.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaContabilidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoxroNominaTipoLiquiInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dteFechaContabilidad
            // 
            this.dteFechaContabilidad.EditValue = null;
            this.dteFechaContabilidad.Location = new System.Drawing.Point(383, 25);
            this.dteFechaContabilidad.Name = "dteFechaContabilidad";
            this.dteFechaContabilidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFechaContabilidad.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteFechaContabilidad.Size = new System.Drawing.Size(95, 20);
            this.dteFechaContabilidad.TabIndex = 124;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(383, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 126;
            this.labelControl1.Text = "Fecha Contabilidad:";
            // 
            // ucRo_Periodo
            // 
            this.ucRo_Periodo.Location = new System.Drawing.Point(12, 5);
            this.ucRo_Periodo.Name = "ucRo_Periodo";
            this.ucRo_Periodo.Size = new System.Drawing.Size(365, 70);
            this.ucRo_Periodo.TabIndex = 125;
            this.ucRo_Periodo.event_cmbPeriodo_EditValueChanged += new Core.Erp.Winform.Controles.UCRo_PeriodoXNomina.delegate_cmbPeriodo_EditValueChanged(this.ucRo_Periodo_event_cmbPeriodo_EditValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 182);
            this.dataGridView1.TabIndex = 0;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(879, 29);
            this.ucGe_Menu.TabIndex = 128;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ucRo_Periodo);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdContabilizar);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdReversoContabilidad);
            this.splitContainerControl1.Panel1.Controls.Add(this.dteFechaContabilidad);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(879, 437);
            this.splitContainerControl1.SplitterPosition = 77;
            this.splitContainerControl1.TabIndex = 129;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // cmdContabilizar
            // 
            this.cmdContabilizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmdContabilizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdContabilizar.Image = global::Core.Erp.Winform.Properties.Resources.Dinero_16x161;
            this.cmdContabilizar.Location = new System.Drawing.Point(500, 14);
            this.cmdContabilizar.Name = "cmdContabilizar";
            this.cmdContabilizar.Size = new System.Drawing.Size(148, 24);
            this.cmdContabilizar.TabIndex = 2;
            this.cmdContabilizar.Text = "Contabilizar";
            this.cmdContabilizar.Click += new System.EventHandler(this.cmdContabilizar_Click);
            // 
            // cmdReversoContabilidad
            // 
            this.cmdReversoContabilidad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmdReversoContabilidad.Image = global::Core.Erp.Winform.Properties.Resources.re_hacer_16x162;
            this.cmdReversoContabilidad.Location = new System.Drawing.Point(500, 44);
            this.cmdReversoContabilidad.Name = "cmdReversoContabilidad";
            this.cmdReversoContabilidad.Size = new System.Drawing.Size(148, 24);
            this.cmdReversoContabilidad.TabIndex = 3;
            this.cmdReversoContabilidad.Text = "Reverso Contabilizacion";
            this.cmdReversoContabilidad.Click += new System.EventHandler(this.cmdReversoContabilidad_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(879, 355);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ucCon_GridDiarioContable2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(873, 327);
            this.xtraTabPage2.Text = "Asiento de provisiones";
            // 
            // ucCon_GridDiarioContable2
            // 
            this.ucCon_GridDiarioContable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCon_GridDiarioContable2.IdCtaCble_x_Banco = null;
            this.ucCon_GridDiarioContable2.Location = new System.Drawing.Point(0, 0);
            this.ucCon_GridDiarioContable2.Name = "ucCon_GridDiarioContable2";
            this.ucCon_GridDiarioContable2.Size = new System.Drawing.Size(873, 327);
            this.ucCon_GridDiarioContable2.TabIndex = 3;
            this.ucCon_GridDiarioContable2.Visible_Botones = true;
            this.ucCon_GridDiarioContable2.Visible_Cabecera = true;

            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.ucCon_GridDiarioContable1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(873, 327);
            this.xtraTabPage1.Text = "Asiento sueldo por pagar";
            // 
            // ucCon_GridDiarioContable1
            // 
            this.ucCon_GridDiarioContable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCon_GridDiarioContable1.IdCtaCble_x_Banco = null;
            this.ucCon_GridDiarioContable1.Location = new System.Drawing.Point(0, 0);
            this.ucCon_GridDiarioContable1.Name = "ucCon_GridDiarioContable1";
            this.ucCon_GridDiarioContable1.Size = new System.Drawing.Size(873, 327);
            this.ucCon_GridDiarioContable1.TabIndex = 0;
            this.ucCon_GridDiarioContable1.Visible_Botones = false;
            this.ucCon_GridDiarioContable1.Visible_Cabecera = false;

            // 
            // roperiodoxroNominaTipoLiquiInfoBindingSource
            // 
            this.roperiodoxroNominaTipoLiquiInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_periodo_x_ro_Nomina_TipoLiqui_Info);
            // 
            // roperiodoInfoBindingSource
            // 
            this.roperiodoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_periodo_Info);
            // 
            // frmRo_Contabilizar_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 466);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Contabilizar_Rol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contabilizar Rol";
            this.Load += new System.EventHandler(this.frmRo_Contabilizar_Rol_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Contabilizar_Rol_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaContabilidad.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFechaContabilidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoxroNominaTipoLiquiInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roperiodoInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dteFechaContabilidad;
        private DevExpress.XtraEditors.SimpleButton cmdReversoContabilidad;
        private DevExpress.XtraEditors.SimpleButton cmdContabilizar;
        private System.Windows.Forms.BindingSource roperiodoxroNominaTipoLiquiInfoBindingSource;
        private System.Windows.Forms.BindingSource roperiodoInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controles.UCRo_PeriodoXNomina ucRo_Periodo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Controles.UCCon_GridDiarioContable ucCon_GridDiarioContable2;
        private Controles.UCCon_GridDiarioContable ucCon_GridDiarioContable1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}