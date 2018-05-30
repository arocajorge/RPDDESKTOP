using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System.Data;
using Core.Erp.Data.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Facturacion
{
    public class fa_Cliente_Data
    {
     
        string mensaje = "";
        tb_persona_data dataPerson = new tb_persona_data();

        public bool Eliminar_Clientes(int idEmpresa, ref string mensaje)
        {
            try
            {
                EntitiesFacturacion OEFa_Cliente = new EntitiesFacturacion();
                OEFa_Cliente.Database.ExecuteSqlCommand("delete fa_cliente where IdEmpresa = " + idEmpresa );
              
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_Cliente_Info> Get_List_Cliente(int IdEmpresa)
        {
            try
            {
                List<fa_Cliente_Info> Lista_Clientes = new List<fa_Cliente_Info>();
                EntitiesFacturacion OEPCliente = new EntitiesFacturacion();
                Lista_Clientes = (from A in OEPCliente.vwfa_cliente
                                  where A.IdEmpresa == IdEmpresa
                                  select new fa_Cliente_Info
                                  {
                                        IdEmpresa = A.IdEmpresa,
                                        IdCliente = A.IdCliente,
                                        Codigo = A.Codigo,
                                        IdPersona = A.IdPersona,
                                        nomSucursal = A.Su_Descripcion,
                                        Idtipo_cliente = A.Idtipo_cliente,
                                        IdTipoCredito = (A.IdTipoCredito != null) ? A.IdTipoCredito : "",
                                        cl_plazo = A.cl_plazo,
                                        cl_observacion = (A.cl_observacion != null) ? A.cl_observacion : "",
                                        IdCiudad = (A.IdCiudad != null) ? A.IdCiudad : "",
                                        cl_Cupo = A.cl_Cupo,
                                        Estado = A.Estado,
                                        Ubicacion = (A.Descripcion_Ciudad != null) ? A.Descripcion_Ciudad : "",
                                        //informacion contable
                                        IdCtaCble_cxc = (A.IdCtaCble_cxc != null) ? A.IdCtaCble_cxc : "",
                                        IdCtaCble_Anti = A.IdCtaCble_Anti,
                                        IdCtaCble_cxc_Credito = A.IdCtaCble_cxc_Credito,

                                        //informacion de provincia y pais
                                        IdProvincia = A.IdProvincia,
                                        IdPais = A.IdPais,
                                        IdParroquia = A.IdParroquia,

                                        //emails
                                        Mail_Principal = A.Mail_Principal,
                                        es_empresa_relacionada = A.es_empresa_relacionada ,

                                        //informacion de la persona
                                        Persona_Info = new tb_persona_Info{
                                        CodPersona = A.CodPersona,
                                        IdPersona = A.IdPersona,
                                        pe_Naturaleza = A.pe_Naturaleza,
                                        pe_nombre =  (A.pe_nombre != null) ? A.pe_nombre : "",
                                        pe_apellido = (A.pe_apellido != null) ? A.pe_apellido : "",
                                        pe_nombreCompleto = A.pe_nombreCompleto,
                                        pe_razonSocial = A.pe_razonSocial,
                                        IdTipoDocumento = A.IdTipoDocumento,
                                        pe_cedulaRuc = A.pe_cedulaRuc,
                                        pe_direccion = A.pe_direccion,
                                        pe_correo = A.pe_correo,
                                        pe_sexo = A.pe_sexo, 
                                        IdEstadoCivil = A.IdEstadoCivil,
                                        pe_fechaNacimiento = A.pe_fechaNacimiento,
                                        pe_estado = A.pe_estado,
                                        IdTipoPersona = A.IdTipoPersona,
                                        pe_telfono_Contacto = A.pe_telfono_Contacto,
                                        pe_celular = A.pe_celular,
                                        },                                        
                                        NivelPrecio = A.NivelPrecio,
                                        FormaPago = A.FormaPago,
                                        Celular = A.Celular,
                                        Direccion = A.Direccion,
                                        Telefono = A.Telefono,
                                        pe_razonSocial = A.pe_razonSocial,
                                  }).ToList();
                Lista_Clientes.ForEach(q => q.Nombre_Cliente = "[" + q.IdCliente + "] " + q.Persona_Info.pe_apellido + " " + q.Persona_Info.pe_nombre);
                return (Lista_Clientes);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_Cliente_Info info, ref string msg)
        {
            try
            {
                try
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_cliente.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa
                            && obj.IdCliente == info.IdCliente);
                        if (contact != null)
                        {
                            contact.IdEmpresa = info.IdEmpresa;
                            contact.IdCliente = info.IdCliente;
                            contact.Codigo = (info.Codigo == "" || info.Codigo == null) ? info.IdCliente.ToString() : info.Codigo;
                            contact.IdPersona = info.IdPersona;
                            contact.Idtipo_cliente = info.Idtipo_cliente;
                            contact.IdTipoCredito = (info.IdTipoCredito != null) ? info.IdTipoCredito : "CRE";
                            contact.cl_plazo = info.cl_plazo;
                            contact.IdCtaCble_cxc = info.IdCtaCble_cxc;
                            contact.IdCtaCble_Anti = info.IdCtaCble_Anti;
                            contact.cl_Cupo = info.cl_Cupo;

                            contact.es_empresa_relacionada = info.es_empresa_relacionada;

                            contact.Estado = (info.Estado != null) ? info.Estado : "A";
                            contact.IdUsuario = (info.IdUsuario != null) ? info.IdUsuario : "";
                            contact.IdUsuarioUltMod = (info.IdUsuario != null) ? info.IdUsuario : "";
                            contact.Fecha_Transac = DateTime.Now;
                            contact.Fecha_UltMod = (info.Fecha_UltMod != null) ? info.Fecha_UltMod : DateTime.Now;

                            contact.IdCtaCble_cxc_Credito = info.IdCtaCble_cxc_Credito;

                            contact.FormaPago = info.FormaPago;
                            contact.NivelPrecio = info.NivelPrecio;

                            context.SaveChanges();
                            msg = "Se ha procedido actualizar el registro del Cliente #: " + info.IdCliente.ToString() + " exitosamente";
                        }
                        else { msg = "No se encuentra el cliente registrado."; }
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_Cuentas_cbles(int IdEmpresa, string cxc_Contado, string cxc_Anticipo, string cxc_Credito, ref string msg)
        {
            try
            {
               
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesFacturacion OEPCliente = new EntitiesFacturacion();
                var select = from q in OEPCliente.fa_cliente
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_cliente = (from q in OEPCliente.fa_cliente
                                          where q.IdEmpresa == IdEmpresa
                                          select q.IdCliente).Max();
                    Id = Convert.ToInt32(select_cliente.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(fa_Cliente_Info info, ref decimal id,ref string msg)
        {
            //try
            //{
                try
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        fa_cliente contact = new fa_cliente();
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdCliente = info.IdCliente = id = GetId(info.IdEmpresa);
                        contact.IdPersona = info.IdPersona;
                        contact.Codigo = (info.Codigo == "" || info.Codigo == null) ? contact.IdCliente.ToString() : info.Codigo.Trim();
                        contact.Idtipo_cliente = info.Idtipo_cliente;
                        contact.IdTipoCredito = (info.IdTipoCredito != null) ? info.IdTipoCredito : "CRE";
                        contact.cl_plazo = (info.cl_plazo != null) ? info.cl_plazo : 0;

                        contact.cl_Cupo = (info.cl_Cupo != null) ? info.cl_Cupo : 0;

                        contact.Estado = (info.Estado != null) ? info.Estado : "A";
                        contact.IdUsuario = (info.IdUsuario != null) ? info.IdUsuario : "";
                        contact.IdUsuarioUltMod = (info.IdUsuario != null) ? info.IdUsuario : "";
                        contact.Fecha_Transac = DateTime.Now;
                        contact.Fecha_UltMod = DateTime.Now;
                                                
                        contact.IdCtaCble_cxc = info.IdCtaCble_cxc;
                        contact.IdCtaCble_cxc_Credito = info.IdCtaCble_cxc_Credito;
                        contact.IdCtaCble_Anti = info.IdCtaCble_Anti;

                        contact.es_empresa_relacionada = info.es_empresa_relacionada;
                        contact.FormaPago = info.FormaPago;
                        contact.NivelPrecio = info.NivelPrecio;
                        context.fa_cliente.Add(contact);
                        context.SaveChanges();
                        msg = "Se ha procedido a grabar el registro del Cliente #: " + id.ToString() + " exitosamente.";
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
                }
            //}
            //catch (Exception ex)
            //{
            //    string arreglo = ToString();
            //    string strMensaje = "";
            //    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            //    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            //    strMensaje = ex.ToString() + " " + ex.Message;
            //    oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
            //    throw new Exception(ex.ToString());
            //}
        }

        public Boolean EliminarDB(fa_Cliente_Info info, ref  string msg)
        {
            try
            {
                EntitiesFacturacion OEPTipoNota = new EntitiesFacturacion();
                var select = from q in OEPTipoNota.fa_cliente
                             where q.IdEmpresa == info.IdEmpresa && q.IdCliente==info.IdCliente
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_cliente.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdCliente == info.IdCliente);
                        if (contact != null)
                        {
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            contact.Fecha_UltAnu = info.Fecha_UltAnu;
                            contact.Estado = "I";
                            context.SaveChanges();
                            msg = "Se ha procedido anular el registro del Cliente #: " + info.IdCliente.ToString() + " exitosamente";
                        }
                    }
                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Cliente #: " + info.IdCliente.ToString() + " debido a que ya se encuentra anulado.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ConsultarClienteVendedor(int IdEmpresa,ref fa_Cliente_Info InfoCliente,ref fa_Vendedor_Info InfoVendedor) {
            try
            {
                EntitiesFacturacion OEPCliente = new EntitiesFacturacion();
                decimal idCliente=InfoCliente.IdCliente;
                decimal idVendedor = InfoVendedor.IdVendedor;


                var select_tipo_nota = from A in OEPCliente.vwfa_cliente
                                       where A.IdEmpresa == IdEmpresa
                                       && A.IdCliente == idCliente
                                       select A;

                foreach (var item in select_tipo_nota)
                {
                    InfoCliente.IdEmpresa = item.IdEmpresa;
                    InfoCliente.IdCliente = item.IdCliente;
                    InfoCliente.IdPersona = item.IdPersona;
                    InfoCliente.Codigo = item.Codigo;
                    InfoCliente.nomSucursal = item.Su_Descripcion;
                    InfoCliente.Idtipo_cliente = item.Idtipo_cliente;
                    InfoCliente.IdTipoCredito = (item.IdTipoCredito != null) ? item.IdTipoCredito.Trim() : "";
                    InfoCliente.cl_plazo = item.cl_plazo;
                    InfoCliente.IdCtaCble_cxc = (item.IdCtaCble_cxc != null) ? item.IdCtaCble_cxc.Trim() : "";
                     InfoCliente.cl_observacion = (item.cl_observacion != null) ? item.cl_observacion.Trim() : "";
                    InfoCliente.IdCiudad = (item.IdCiudad != null) ? item.IdCiudad.Trim() : "";
                    InfoCliente.cl_Cupo = item.cl_Cupo;
                    InfoCliente.Estado = item.Estado;
                    InfoCliente.Ubicacion = (item.Descripcion_Ciudad != null) ? item.Descripcion_Ciudad.Trim() : "";

                    InfoCliente.IdCtaCble_Anti = item.IdCtaCble_Anti;
                    InfoCliente.IdCtaCble_cxc_Credito = item.IdCtaCble_cxc_Credito;

                    InfoCliente.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);

                    InfoCliente.IdProvincia = item.IdProvincia;
                    InfoCliente.IdPais = item.IdPais;

                    InfoCliente.Mail_Principal = item.Mail_Principal;
                    InfoCliente.IdParroquia = item.IdParroquia;


                    InfoCliente.Persona_Info = new tb_persona_Info();
                    InfoCliente.Persona_Info.CodPersona = item.CodPersona;
                    InfoCliente.Persona_Info.IdPersona = item.IdPersona;
                    InfoCliente.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    InfoCliente.Persona_Info.pe_nombre = (item.pe_nombre != null) ? item.pe_nombre.Trim() : "";
                    InfoCliente.Persona_Info.pe_apellido = (item.pe_apellido != null) ? item.pe_apellido.Trim() : "";
                    InfoCliente.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    InfoCliente.Persona_Info.pe_razonSocial = item.pe_razonSocial;

                    InfoCliente.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    InfoCliente.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    InfoCliente.Persona_Info.pe_direccion = item.pe_direccion;
                                        
                    InfoCliente.Persona_Info.pe_sexo = item.pe_sexo; ;
                    InfoCliente.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                    InfoCliente.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    InfoCliente.Persona_Info.pe_estado = item.pe_estado;

                    InfoCliente.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                    InfoCliente.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                    InfoCliente.Persona_Info.pe_celular = item.pe_celular;

                    InfoCliente.Persona_Info.pe_correo = item.pe_correo;

                    InfoCliente.Nombre_Cliente = "[" + item.IdCliente + "] " + item.pe_apellido.Trim() + " " + item.pe_nombre.Trim();
                }
                    EntitiesFacturacion OEPVendedor = new EntitiesFacturacion();

                    var select_pv = from A in OEPVendedor.fa_Vendedor
                                    where A.IdEmpresa == IdEmpresa &&A.IdVendedor==idVendedor
                                    select A;

                    foreach (var item in select_pv)
                    {
                        InfoVendedor.IdEmpresa = item.IdEmpresa;
                        InfoVendedor.IdVendedor = item.IdVendedor;
                        InfoVendedor.Ve_Vendedor = item.Ve_Vendedor.Trim();
                        InfoVendedor.Estado = item.Estado;
                    }
                    return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }            
        }

        public fa_Cliente_Info Get_Info_Cliente_x_IdPersona(int IdEmpresa, decimal IdPersona)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var select_tipo_nota = from A in entity.vwfa_cliente
                                           where A.IdEmpresa == IdEmpresa
                                           && A.IdPersona == IdPersona
                                           select A;

                    foreach (var item in select_tipo_nota)
                    {

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.IdPersona = item.IdPersona;
                        info.Codigo = item.Codigo;
                        info.nomSucursal = item.Su_Descripcion;
                        info.Idtipo_cliente = item.Idtipo_cliente;
                        info.IdTipoCredito = (item.IdTipoCredito != null) ? item.IdTipoCredito.Trim() : "";
                        info.cl_plazo = item.cl_plazo;
                        info.IdCtaCble_cxc = (item.IdCtaCble_cxc != null) ? item.IdCtaCble_cxc.Trim() : "";
                        info.cl_observacion = (item.cl_observacion != null) ? item.cl_observacion.Trim() : "";
                        info.IdCiudad = (item.IdCiudad != null) ? item.IdCiudad.Trim() : "";
                        info.cl_Cupo = item.cl_Cupo;
                        info.Estado = item.Estado;
                        info.Ubicacion = (item.Descripcion_Ciudad != null) ? item.Descripcion_Ciudad.Trim() : "";

                        info.IdCtaCble_Anti = item.IdCtaCble_Anti;
                        info.IdCtaCble_cxc_Credito = item.IdCtaCble_cxc_Credito;

                        info.IdProvincia = item.IdProvincia;
                        info.IdPais = item.IdPais;

                        info.Mail_Principal = item.Mail_Principal;
                        info.IdParroquia = item.IdParroquia;

                        info.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);

                        info.Persona_Info = new tb_persona_Info();
                        info.Persona_Info.CodPersona = item.CodPersona;
                        info.Persona_Info.IdPersona = item.IdPersona;
                        info.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                        info.Persona_Info.pe_nombre = (item.pe_nombre != null) ? item.pe_nombre.Trim() : "";
                        info.Persona_Info.pe_apellido = (item.pe_apellido != null) ? item.pe_apellido.Trim() : "";
                        info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.Persona_Info.pe_razonSocial = item.pe_razonSocial;

                        info.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                        info.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Persona_Info.pe_direccion = item.pe_direccion;

                        info.Persona_Info.pe_correo = item.pe_correo;
                        info.Persona_Info.pe_sexo = item.pe_sexo; ;
                        info.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                        info.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.Persona_Info.pe_estado = item.pe_estado;

                        info.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                        info.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.Persona_Info.pe_celular = item.pe_celular;

                        info.Nombre_Cliente = "[" + item.IdCliente + "] " + item.pe_apellido.Trim() + " " + item.pe_nombre.Trim();
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }        
        }

        public fa_Cliente_Info Get_Info_Cliente(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();

                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var select_tipo_nota = from A in entity.vwfa_cliente
                                           where A.IdEmpresa == IdEmpresa
                                           && A.IdCliente == IdCliente
                                           select A;

                    foreach (var item in select_tipo_nota)
                    {
                        
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.IdPersona = item.IdPersona;
                        info.Codigo = item.Codigo;
                        info.nomSucursal = item.Su_Descripcion;
                        info.Idtipo_cliente = item.Idtipo_cliente;
                        info.IdTipoCredito = (item.IdTipoCredito != null) ? item.IdTipoCredito.Trim() : "";
                        info.cl_plazo = item.cl_plazo;
                        info.IdCtaCble_cxc = (item.IdCtaCble_cxc != null) ? item.IdCtaCble_cxc.Trim() : "";
                         info.cl_observacion = (item.cl_observacion != null) ? item.cl_observacion.Trim() : "";
                        info.IdCiudad = (item.IdCiudad != null) ? item.IdCiudad.Trim() : "";
                        info.cl_Cupo = item.cl_Cupo;
                        info.Estado = item.Estado;
                        info.Ubicacion = (item.Descripcion_Ciudad != null) ? item.Descripcion_Ciudad.Trim() : "";

                        info.IdCtaCble_Anti = item.IdCtaCble_Anti;
                        info.IdCtaCble_cxc_Credito = item.IdCtaCble_cxc_Credito;

                        info.IdProvincia = item.IdProvincia;
                        info.IdPais = item.IdPais;

                        info.Mail_Principal = item.Mail_Principal;
                         info.IdParroquia = item.IdParroquia;
                        info.es_empresa_relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);

                        info.Persona_Info = new tb_persona_Info();
                        info.Persona_Info.CodPersona = item.CodPersona;
                        info.Persona_Info.IdPersona = item.IdPersona;
                        info.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                        info.Persona_Info.pe_nombre = (item.pe_nombre != null) ? item.pe_nombre.Trim() : "";
                        info.Persona_Info.pe_apellido = (item.pe_apellido != null) ? item.pe_apellido.Trim() : "";
                        info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.Persona_Info.pe_razonSocial = item.pe_razonSocial;

                        info.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                        info.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Persona_Info.pe_direccion = item.pe_direccion;

                        info.Persona_Info.pe_correo = item.pe_correo;
                        info.Persona_Info.pe_sexo = item.pe_sexo; ;
                        info.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                        info.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.Persona_Info.pe_estado = item.pe_estado;

                        info.Persona_Info.IdTipoPersona = item.IdTipoPersona;
                        info.Persona_Info.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        info.Persona_Info.pe_celular = item.pe_celular;

                        info.Nombre_Cliente = "[" + item.IdCliente + "] " + item.pe_apellido.Trim() + " " + item.pe_nombre.Trim();
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


        public Boolean Get_Cliente_Es_Parte_Relacionada(int IdEmpresa, string CedulaRuc)
        {
            try
            {
                Boolean Es_Parte_Relacionada = false;

                
                using (EntitiesFacturacion entity = new EntitiesFacturacion())
                {
                    var select_tipo_nota = from A in entity.vwfa_cliente
                                           where A.IdEmpresa == IdEmpresa
                                           && A.pe_cedulaRuc == CedulaRuc
                                           select new { A.es_empresa_relacionada };

                    foreach (var item in select_tipo_nota)
                    {
                        Es_Parte_Relacionada = (item.es_empresa_relacionada == null) ? false : Convert.ToBoolean(item.es_empresa_relacionada);
                    }
                }
                return Es_Parte_Relacionada;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public fa_Cliente_Info Get_info_cliente_x_codigo_para_saldo_inicial(int IdEmpresa, string cod_cliente, ref string mensajeError)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_cliente
                              where q.Codigo == cod_cliente
                              && q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.Codigo = item.Codigo;
                        info.IdCtaCble_cxc = item.IdCtaCble_cxc;
                        info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }



        public fa_Cliente_Info Get_info_cliente_x_cedula_para_saldo_inicial(int IdEmpresa, string cedula_cliente, ref string mensajeError)
        {
            try
            {
                fa_Cliente_Info info = new fa_Cliente_Info();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_cliente
                              where q.pe_cedulaRuc == cedula_cliente.Trim()
                              && q.IdEmpresa == IdEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCliente = item.IdCliente;
                        info.Codigo = item.Codigo;
                        info.IdCtaCble_cxc = item.IdCtaCble_cxc;
                        info.Persona_Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        info.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                        info.Persona_Info.pe_nombre = item.pe_nombre;
                        info.Persona_Info.pe_apellido = item.pe_apellido;
                        info.Persona_Info.pe_razonSocial = item.pe_razonSocial;
                        info.Persona_Info.pe_direccion = item.pe_direccion;
                        info.Persona_Info.IdPersona = item.IdPersona;
                        info.IdPersona = item.IdPersona;
                       
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public fa_Cliente_Data() { }
    }
}

