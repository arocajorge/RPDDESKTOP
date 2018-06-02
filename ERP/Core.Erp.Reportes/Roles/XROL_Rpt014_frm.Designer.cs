namespace Core.Erp.Reportes.Roles
{
    partial class XROL_Rpt014_frm
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
            this.ucRo_Menu_Reportes1 = new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes();
            this.SuspendLayout();
            // 
            // ucRo_Menu_Reportes1
            // 
            this.ucRo_Menu_Reportes1.caption_bei_check1 = "Check";
            this.ucRo_Menu_Reportes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucRo_Menu_Reportes1.EnableBotonImprimir = true;
            this.ucRo_Menu_Reportes1.Location = new System.Drawing.Point(0, 0);
            this.ucRo_Menu_Reportes1.Name = "ucRo_Menu_Reportes1";
            this.ucRo_Menu_Reportes1.Size = new System.Drawing.Size(1010, 97);
            this.ucRo_Menu_Reportes1.TabIndex = 0;
            this.ucRo_Menu_Reportes1.Visible_bei_check1 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu_Reportes1.VisibleCmbCentroCosto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu_Reportes1.VisibleCmbDivision = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes1.VisibleCmbEmpleado = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu_Reportes1.VisibleCmbNominaTipo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes1.VisibleCmbNominaTipoLiqui = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu_Reportes1.VisibleCmbPeriodo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu_Reportes1.VisibleCmbRubro = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu_Reportes1.VisibleDepartamento = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu_Reportes1.VisibleEstado = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu_Reportes1.VisibleGrupoFecha = false;
            this.ucRo_Menu_Reportes1.VisibleGrupoFiltro1 = true;
            this.ucRo_Menu_Reportes1.VisibleGrupoFiltro2 = true;
            this.ucRo_Menu_Reportes1.VisubleArea = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu_Reportes1.event_cmdCargar_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_cmdCargar_ItemClick(this.ucRo_Menu_Reportes1_event_cmdCargar_ItemClick);
            this.ucRo_Menu_Reportes1.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucRo_Menu_Reportes1_event_btnsalir_ItemClick);
            // 
            // XROL_Rpt014_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 511);
            this.Controls.Add(this.ucRo_Menu_Reportes1);
            this.Name = "XROL_Rpt014_frm";
            this.Text = "XROL_Rpt014_frm";
            this.Load += new System.EventHandler(this.XROL_Rpt014_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCRo_Menu_Reportes ucRo_Menu_Reportes1;

    }
}