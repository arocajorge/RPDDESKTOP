using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        List<tb_sis_Documento_Tipo_Info> list_Docu_Tipo = new List<tb_sis_Documento_Tipo_Info>();
        tb_sis_Documento_Tipo_Bus Bus_Doc_Tipo = new tb_sis_Documento_Tipo_Bus();
        tb_sis_Documento_Tipo_Talonario_Bus busTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
        BindingList<tb_sis_Documento_Tipo_Talonario_Info> blst = new BindingList<tb_sis_Documento_Tipo_Talonario_Info>();

        public delegate void delegate_FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed event_delegate_FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed;
        #endregion

        public void cargar_combo_tipo_docu()
        {
            try
            {

                list_Docu_Tipo = Bus_Doc_Tipo.Get_List_Documento_Tipo_ApareceTalonario(param.IdEmpresa);
                this.ultraCmbE_TipoDoc.Properties.DataSource = list_Docu_Tipo;
                this.ultraCmbE_TipoDoc.Properties.DisplayMember = "descripcion";
                this.ultraCmbE_TipoDoc.Properties.ValueMember = "codDocumentoTipo";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva()
        {
            InitializeComponent();
            event_delegate_FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed += FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_event_delegate_FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed;
        }

        void FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_event_delegate_FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                List<tb_sis_Documento_Tipo_Talonario_Info> lst = new List<tb_sis_Documento_Tipo_Talonario_Info>(blst.Where(q=>q.seleccionado == true).ToList());
                if (lst.Count == 0)
                {
                    MessageBox.Show("Seleccione los documentos a anular", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (busTalonario.Anular(lst))
                {
                    MessageBox.Show("Anulación exitosa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo_tipo_docu();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargar_grid()
        {
            try
            {
                blst = new BindingList<tb_sis_Documento_Tipo_Talonario_Info>();
                if (validar())
                {
                    string Establecimiento = txtEstablecimiento.Text;
                    string Punto_emision = txtpuntoEmision.Text;
                    decimal doc_inicial = Convert.ToDecimal(txt_doc_inicial.Text);
                    decimal doc_final = Convert.ToDecimal(txt_doc_final.Text);
                    blst = new BindingList<tb_sis_Documento_Tipo_Talonario_Info>(busTalonario.Get_List_Docu_Tipo_Talonario(param.IdEmpresa, ultraCmbE_TipoDoc.EditValue.ToString(), chk_doc_electronico.Checked, Establecimiento, Punto_emision, doc_inicial, doc_final));                    
                }
                gridConsulta.DataSource = blst;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_egresos_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {
                if (ultraCmbE_TipoDoc.EditValue == null)
                {
                    MessageBox.Show("Seleccione el tipo de documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (txtEstablecimiento.Text == "")
                {
                    MessageBox.Show("Ingrese el establecimiento",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                if (txtpuntoEmision.Text == "")
                {
                    MessageBox.Show("Ingrese el punto de emision", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (txt_doc_inicial.Text == "")
                {
                    MessageBox.Show("Ingrese el documento inicial", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txt_doc_final.Text == "")
                {
                    MessageBox.Show("Ingrese el documento final", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }               

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_FrmGe_Secuencia_Documento_Tipo_Talonario_anulacion_masiva_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
