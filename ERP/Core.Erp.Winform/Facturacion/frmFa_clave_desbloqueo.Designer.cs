namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_clave_desbloqueo
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
            this.txt_clave_desbloqueo = new DevExpress.XtraEditors.TextEdit();
            this.btn_validar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_clave_desbloqueo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_clave_desbloqueo
            // 
            this.txt_clave_desbloqueo.Location = new System.Drawing.Point(28, 35);
            this.txt_clave_desbloqueo.Name = "txt_clave_desbloqueo";
            this.txt_clave_desbloqueo.Properties.PasswordChar = '*';
            this.txt_clave_desbloqueo.Size = new System.Drawing.Size(243, 22);
            this.txt_clave_desbloqueo.TabIndex = 0;
            this.txt_clave_desbloqueo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_desbloqueo_KeyPress);
            // 
            // btn_validar
            // 
            this.btn_validar.Location = new System.Drawing.Point(28, 69);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(112, 23);
            this.btn_validar.TabIndex = 1;
            this.btn_validar.Text = "Validar";
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(159, 69);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(112, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(211, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ingrese la contraseña de desbloqueo";
            // 
            // frmFa_clave_desbloqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 114);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.txt_clave_desbloqueo);
            this.Name = "frmFa_clave_desbloqueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desbloqueo";
            ((System.ComponentModel.ISupportInitialize)(this.txt_clave_desbloqueo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_clave_desbloqueo;
        private DevExpress.XtraEditors.SimpleButton btn_validar;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}