using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Turno_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_turno_Bus busTurno = new ro_turno_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; List<string> DiasDeLaSeman = new List<string>();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        string mensaje = "";
        ro_turno_Info ItemGrabar = new ro_turno_Info();
        public delegate void delegate_frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Turno_Mant_FormClosing event_frmRo_Turno_Mant_FormClosing;
        #endregion

        public frmRo_Turno_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            try
            {
                System.Globalization.CultureInfo Cultura = new System.Globalization.CultureInfo("es-EC");
                DiasDeLaSeman = Cultura.DateTimeFormat.DayNames.ToList(); 
                this.event_frmRo_Turno_Mant_FormClosing += frmRo_Turno_Mant_event_frmRo_Turno_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está Seguro que desea Anular el turno?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    oFrm.ShowDialog();
                    ItemGrabar.MotiAnula = oFrm.motivoAnulacion;
                    ItemGrabar.IdUsuarioUltAnu = param.IdUsuario;
                    ItemGrabar.Fecha_UltAnu = DateTime.Now;
                    if (busTurno.AnularTurno(ItemGrabar, ref mensaje))
                    {
                        ItemGrabar.Estado = "I";
//                        MessageBox.Show("Anulado Exitosamente");
                        MessageBox.Show("El registro ha sido anulado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frmRo_Turno_Mant_event_frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
              Accion = iAccion;
                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txtDia.Text = "0";
                        checkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
          
        }
        
        public void SetInfo(ro_turno_Info info)
        {
            try
            {
                ItemGrabar = info;
                txtDia.Text = info.IdTurno.ToString();
                txt_descTurno.Text = info.tu_descripcion;
                checklunes.Checked = info.Lunes;
                checkmartes.Checked = info.Martes;
                checkmiercoles.Checked = info.Miercoles;
                checkjueves.Checked = info.Jueves;
                checkjueves.Checked = info.Viernes;
                checksabado.Checked = info.Sabado;
                checkdomingo.Checked = info.Domingo;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }       
        }

        private Boolean getInfo()
        {
            Boolean resul = false;
            txt_descTurno.Focus();
            try
            {
               
               
                ItemGrabar.IdEmpresa = param.IdEmpresa;
                ItemGrabar.tu_descripcion = txt_descTurno.Text;
                if (checkEstado.Checked == true)
                {
                    ItemGrabar.Estado = "A";
                }
                else
                {
                    ItemGrabar.Estado = "I";

                }
                ItemGrabar.Lunes = checklunes.Checked;
                ItemGrabar.Martes = checkmartes.Checked;
                ItemGrabar.Miercoles = checkmiercoles.Checked;
                ItemGrabar.Jueves = checkjueves.Checked;
                ItemGrabar.Viernes = checkviernes.Checked;
                ItemGrabar.Sabado = checksabado.Checked;
                ItemGrabar.Domingo = checkdomingo.Checked;
                resul = true;
                return resul;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public Boolean grabar()
        {
            Boolean resul = false;
            decimal Id=0;
            string mensaje ="";
            try
            {
                if (getInfo())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            ItemGrabar.IdUsuario = param.IdUsuario;
                            ItemGrabar.Fecha_Transac = DateTime.Now;
                            if (busTurno.GuardarTurno(ItemGrabar, ref Id, ref mensaje))
                            { MessageBox.Show("Grabado exitosamente el Turno #" + Id, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information); resul = true;
                          //  set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                            //    ItemGrabar.IdTurno = Id; SetInfo(ItemGrabar);
                            limpiar();
                            }
                    
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                             ItemGrabar.IdUsuarioUltMod = param.IdUsuario;
                            ItemGrabar.Fecha_UltMod = DateTime.Now;
                            if (busTurno.ModificarTurno(ItemGrabar, mensaje))
                            { MessageBox.Show("Actualizado exitosamente el Turno #" + txtDia.Text, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information); resul = true;
                            //set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                //SetInfo(ItemGrabar);
                            limpiar();
                            }
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            if (MessageBox.Show("¿Está seguro que desea anular el reg #: " + ItemGrabar.IdTurno + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                                oFrm.ShowDialog();
                                ItemGrabar.MotiAnula = oFrm.motivoAnulacion;
                                ItemGrabar.IdUsuarioUltAnu = param.IdUsuario;
                                ItemGrabar.Fecha_UltAnu = DateTime.Now;
                                if (busTurno.AnularTurno(ItemGrabar, ref mensaje))
                                {
                                    MessageBox.Show("Anulado exitosamente el Turno #" + txtDia.Text, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information); resul = true;
                                    set_Accion(Cl_Enumeradores.eTipo_action.consultar); SetInfo(ItemGrabar);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                   
                }
                return resul;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public void limpiar()
        {
            txt_descTurno.Text="";
        }
        private void frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmRo_Turno_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }
        
        private void toolStripButtonAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está Seguro que desea Anular el turno?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (busTurno.AnularTurno(ItemGrabar, ref mensaje))
                    {
                        ItemGrabar.Estado = "I";
                        MessageBox.Show("El registro ha sido anulado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Turno_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Turno_Mant_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
