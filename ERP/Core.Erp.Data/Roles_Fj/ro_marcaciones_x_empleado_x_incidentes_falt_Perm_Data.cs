using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Roles_Fj
{
    public class ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Data
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        public bool Grabar_DB( ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info info)
        {
            try
            {
                using (EntityRoles_FJ db= new EntityRoles_FJ())
                {
                    ro_marcaciones_x_empleado_x_incidentes_falt_Perm add = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm();

                    add.IdEmpresa = info.IdEmpresa;
                    add.IdNomina_Tipo = info.IdNomina_Tipo;
                    add.IdEmpleado = info.IdEmpleado;
                    add.IdRegistro = info.IdRegistro;
                    if(info.IdTurno==0 ||info.IdTurno==null)
                    add.IdTurno =1;
                    else
                        add.IdTurno = info.IdTurno;

                    add.es_fecha_registro = info.es_fecha_registro;
                    add.Id_catalogo_Cat = info.Id_catalogo_Cat;
                    add.es_jornada_desfasada = info.es_jornada_desfasada;
                    if (info.IdSala == 0)
                        add.IdSala = null;
                    else
                        add.IdSala = info.IdSala;
                    if (info.IdRuta == 0)
                        add.IdRuta = null;
                    else
                        add.IdRuta = info.IdRuta;
                    if (info.IdDisco == 0)
                        add.IdDisco = null;
                    else
                        add.IdDisco = info.IdDisco;
                    add.Observacion = "";

                    db.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.Add(add);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }



        public List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista_atrasos_faltas_x_empleado(int IdEmpresa,int IdNominaTipo, DateTime Fecha_Inicio, DateTime FechaFin)
        {
            try
            {

                Fecha_Inicio = Convert.ToDateTime(Fecha_Inicio.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista = new List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info>();

                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var query = from q in db.vwro_marcaciones_x_empleado_x_incidentes_falt_Perm
                                where q.IdEmpresa == IdEmpresa
                                && q.es_fecha_registro >= Fecha_Inicio
                                && q.es_fecha_registro <= FechaFin
                                && q.IdNomina_Tipo==IdNominaTipo
                                select q;
                    foreach (var item in query)
                    {
                    ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info add = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info();
                    add.IdEmpresa = item.IdEmpresa;
                    add.IdEmpleado = item.IdEmpleado;
                    add.IdRegistro = item.IdRegistro;
                    add.es_fecha_registro =Convert.ToDateTime(item.es_fecha_registro);
                    add.Id_catalogo_Cat = item.Id_catalogo_Cat;
                    add.Observacion = "";
                    add.de_descripcion = item.de_descripcion;
                    add.ca_descripcion = item.ca_descripcion;
                    add.pe_nombre = item.pe_nombre;
                    add.pe_apellido = item.pe_apellido;
                    add.pe_cedulaRuc = item.pe_cedulaRuc;
                   // add.es_Hora = item.es_Hora;
                    if (item.Id_catalogo_Cat == "ATRA")
                    {
                        add.imagen = 1;
                    }
                    if (item.Id_catalogo_Cat == "PER")
                    {
                        add.imagen = 2;
                    }
                    add.check = false;
                    lista.Add(add);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public int Get_DiasFaltados(int IdEmpresa,decimal IdEmpleado, DateTime Fecha_Inicio, DateTime FechaFin)
        {
            try
            {
                int valor1 = 0;
                int valor2 = 0;
                int valorTot = 0;
                List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista = new List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info>();
                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var query = from q in db.ro_marcaciones_x_empleado_x_incidentes_falt_Perm
                                where q.IdEmpresa == IdEmpresa
                                 && q.IdEmpleado == IdEmpleado
                                && q.es_fecha_registro >= Fecha_Inicio
                                && q.es_fecha_registro <= FechaFin
                                && (q.Id_catalogo_Cat == "FAL"                              
                                )
                                
                               
                                select q;
                    if (query.Count() > 0)
                        valor1 = query.Count();
                    else
                        valor1 = 0;
                }




                 using (EntityRoles_FJ db1 = new EntityRoles_FJ())
                {
                    var query1 = from q in db1.ro_marcaciones_x_empleado_x_incidentes_falt_Perm
                                where q.IdEmpresa == IdEmpresa
                                 && q.IdEmpleado == IdEmpleado
                                && q.es_fecha_registro >= Fecha_Inicio
                                && q.es_fecha_registro <= FechaFin
                                && (q.Id_catalogo_Cat == "SUSP"                              
                                )
                                
                               
                                select q;
                    if (query1.Count() > 0)
                     valor2=    query1.Count() ;
                    else
                        valor2 = 0;
                }















                return valorTot=valor1+valor2;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info item, ref  string msg)
        {

            try
            {
                using (EntityRoles_FJ context = new EntityRoles_FJ())
                {
                    var contact = context.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.First(obj => obj.IdEmpresa == item.IdEmpresa &&
                         obj.IdEmpleado == item.IdEmpleado
                         && obj.IdRegistro==item.IdRegistro);

                    contact.Id_catalogo_Cat = item.Id_catalogo_Cat;

                    context.SaveChanges();
                   

                }

                return true;


            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int Get_Dias_Falta_Atraso(int IdEmpresa, decimal IdEmpleado, DateTime Fecha_Inicio, DateTime FechaFin)
        {
            try
            {
                int valor = 0;
                int faltas = 0;
                int atrasos = 0;
                List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista = new List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info>();
               


                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var query2 = from q in db.ro_marcaciones_x_empleado_x_incidentes_falt_Perm
                                where q.IdEmpresa == IdEmpresa
                                 && q.IdEmpleado == IdEmpleado
                                && q.es_fecha_registro >= Fecha_Inicio
                                && q.es_fecha_registro <= FechaFin
                                && q.Id_catalogo_Cat == "ATRA"

                                select q;
                    if (query2.Count() > 0)
                    {

                        atrasos =Convert.ToInt32( Math.Floor(Convert.ToDouble( query2.Count() / 3)));
                    }
                    else
                        atrasos = 0;
                }


                valor = faltas + atrasos;
                return valor;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }




        public int Get_DiasRestaDiasEfect(int IdEmpresa, decimal IdEmpleado, DateTime Fecha_Inicio, DateTime FechaFin)
        {
            try
            {
                int valor = 0;
                List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista = new List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info>();
                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var query = from q in db.ro_marcaciones_x_empleado_x_incidentes_falt_Perm
                                where q.IdEmpresa == IdEmpresa
                                 && q.IdEmpleado == IdEmpleado
                                && q.es_fecha_registro >= Fecha_Inicio
                                && q.es_fecha_registro <= FechaFin
                                && (q.Id_catalogo_Cat == "FAL"
                                || q.Id_catalogo_Cat == "PER"
                                 || q.Id_catalogo_Cat == "SUSP"
                                 || q.Id_catalogo_Cat == "VACA"
                                 ||q.Id_catalogo_Cat=="SINLABORAR"
                               
                                )


                                select q;
                    if (query.Count() > 0)
                        valor = query.Count();
                    else
                        valor = 0;
                }

                return valor;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public Boolean EliminarDB(ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info item, ref  string msg)
        {

            try
            {
                using (EntityRoles_FJ context = new EntityRoles_FJ())
                {
                    string sql1 = "delete Fj_servindustrias.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar where IdEmpresa='" + item.IdEmpresa + "' and IdEmpleado='" + item.IdEmpleado + "' and IdRegistro='" + item.IdRegistro + "'";
                    context.Database.ExecuteSqlCommand(sql1);


                    string sql = "delete Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm where IdEmpresa='" + item.IdEmpresa + "' and IdEmpleado='" + item.IdEmpleado + "' and IdRegistro='" + item.IdRegistro + "'";
                    context.Database.ExecuteSqlCommand(sql);
                   


                }

                return true;


            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);

                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean ModificrEstado(int IdEmpresa, decimal IdEmpleado, DateTime FechaDesde, DateTime FechaHasta, ref  string msg)
        {

            try
            {
                using (EntityRoles_FJ context = new EntityRoles_FJ())
                {

                    string sql = "update Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm set Id_catalogo_Cat='PER'  where IdEmpresa='" + IdEmpresa + "' and IdEmpleado='" + IdEmpleado + "' and es_fecha_registro between '" + FechaDesde + "'  and '" + FechaHasta + "'";
                    context.Database.ExecuteSqlCommand(sql);



                }

                return true;


            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);

                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> Get_listaEventuales_con_marcaciones(int IdEmpresa, int idnomina, DateTime Fecha_Inicio, DateTime FechaFin)
        {
            try
            {

                Fecha_Inicio = Fecha_Inicio.Date;
                FechaFin = FechaFin.Date;
                List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista = new List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info>();

                using (EntityRoles_FJ db = new EntityRoles_FJ())
                {
                    var query = from q in db.spro_Eventuales_con_marcaciones(IdEmpresa,idnomina,Fecha_Inicio,FechaFin)
                                //where q.IdEmpresa == IdEmpresa
                                //&& q.es_fecha_registro >= Fecha_Inicio
                                //&& q.es_fecha_registro <= FechaFin
                                select q;
                    foreach (var item in query)
                    {
                        ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info add = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info();
                        add.IdEmpresa = item.IdEmpresa;
                        add.IdEmpleado = item.IdEmpleado;
                        add.IdNomina_Tipo = item.IdNomina_Tipo;
                        add.ca_descripcion = item.ca_descripcion;
                        add.NombreCompleto = item.NombreCompleto;
                        add.IdCargo = item.IdCargo;
                        add.IdGrupo = item.IdGrupo;
                        lista.Add(add);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


     
    }
}
