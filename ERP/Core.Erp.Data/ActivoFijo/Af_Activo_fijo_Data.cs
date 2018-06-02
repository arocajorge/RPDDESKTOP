using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Info.Facturacion_FJ;
using System.Data.Entity.Validation;


namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Activo_fijo_Data
    {
        string mensaje = "";

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo(int IdEmpresa, string EstadoProceso)
        {
                List<Af_Activo_fijo_Info> lM = new List<Af_Activo_fijo_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             select A;

                if (EstadoProceso != "")
                {
                    select = select.Where(q => q.Estado_Proceso == EstadoProceso);
                }

                foreach (var item in select)
                {
                    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = item.Af_NumSerie;
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = item.Af_observacion;
                    info.Af_NumPlaca = item.Af_NumPlaca;
                    info.Af_Anio_fabrica =  item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.Af_foto = item.Af_foto;
                    info.Af_Depreciacion_acum = item.Af_Depreciacion_acum;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;

                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;

                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;
                    
                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo(int IdEmpresa)
        {
            List<Af_Activo_fijo_Info> lM = new List<Af_Activo_fijo_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre.Trim();
                    info.IdActivoFijoTipo = item.IdActivoFijoTipo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = item.Af_NumSerie;
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;

                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = item.Af_observacion;

                    info.Af_NumPlaca =( item.Af_NumPlaca==null)?"": item.Af_NumPlaca.Trim();
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;


                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;
                    
                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;


                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo_x_categoria(int IdEmpresa, int idCategoria)
        {
            List<Af_Activo_fijo_Info> lM = new List<Af_Activo_fijo_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             && idCategoria== A.IdCategoriaAF
                             select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre.Trim();
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = item.Af_NumSerie.Trim();
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = item.Af_observacion.Trim();
                    info.Af_NumPlaca = item.Af_NumPlaca.Trim();
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;

                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;


                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;

                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;


                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Af_Activo_fijo_Info Get_Info_ActivoFijo(int IdEmpresa, int IdActivoFijo)
        {
            Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             && A.IdActivoFijo == IdActivoFijo
                             
                             select A;

                foreach (var item in select)
                {
                    info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre;
                    info.IdActivoFijoTipo = item.IdActivoFijoTipo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = item.Af_NumSerie;
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = item.Af_observacion;
                    info.Af_NumPlaca = item.Af_NumPlaca;
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;


                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;


                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;

                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }        

        public Af_Activo_fijo_Info Get_ActivoFijo(int IdEmpresa, string codigo)
        {
            Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             && A.CodActivoFijo.Equals(codigo)

                             select A;

                foreach (var item in select)
                {

                    info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = item.Af_Nombre.Trim();
                    info.IdActivoFijoTipo = item.IdActivoFijoTipo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = (item.Af_NumSerie == null) ? null : item.Af_NumSerie.Trim();
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = (item.Af_observacion == null) ? null : item.Af_observacion.Trim();
                    info.Af_NumPlaca = (item.Af_NumPlaca == null) ? null : item.Af_NumPlaca.Trim();
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;


                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;

                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;

                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(Af_Activo_fijo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdActivoFijo == info.IdActivoFijo );
                    if (contact != null)
                    {
                        contact.CodActivoFijo = info.CodActivoFijo;
                        contact.Af_Nombre = info.Af_Nombre;
                        contact.IdActivoFijoTipo = info.IdActivoFijoTipo;
                        contact.IdCatalogo_Marca = info.IdCatalogo_Marca;
                        contact.IdCatalogo_Modelo = info.IdCatalogo_Modelo;
                        contact.Af_NumSerie = info.Af_NumSerie;
                        contact.IdCatalogo_Color = info.IdCatalogo_Color;
                        contact.Af_fecha_compra = info.Af_fecha_compra;
                        contact.Af_fecha_ini_depre = info.Af_fecha_ini_depre;
                        contact.Af_fecha_fin_depre = info.Af_fecha_fin_depre;
                        contact.Af_Costo_historico = info.Af_Costo_historico;
                        contact.Af_costo_compra = info.Af_costo_compra;
                        contact.Af_Vida_Util = info.Af_Vida_Util;
                        contact.Af_Meses_depreciar = info.Af_Meses_depreciar;
                        contact.Af_porcentaje_deprec = info.Af_porcentaje_deprec;
                        contact.Af_observacion = info.Af_observacion;
                        contact.Af_NumPlaca = info.Af_NumPlaca;
                        contact.Af_Anio_fabrica =info.Af_Anio_fabrica;
                        contact.Estado = info.Estado;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.Af_foto = info.Af_foto;
                        contact.Af_DescripcionCorta = info.Af_DescripcionCorta;
                        contact.Af_Codigo_Barra = info.Af_Codigo_Barra;
                        contact.Af_DescripcionTecnica = info.Af_DescripcionTecnica;
                        contact.Estado_Proceso = info.Estado_Proceso;
                        contact.Af_ValorSalvamento = info.Af_ValorSalvamento;
                        contact.Af_ValorResidual = info.Af_ValorResidual;
                        contact.Af_NumSerie_Motor = info.Af_NumSerie_Motor;
                        contact.Af_NumSerie_Chasis = info.Af_NumSerie_Chasis;
                        contact.IdCategoriaAF = info.IdCategoriaAF;
                        contact.IdSucursal = info.IdSucursal;
                        contact.IdTipoCatalogo_Ubicacion = info.IdTipoCatalogo_Ubicacion;


                        //contact.IdCtaCble_Activo = info.IdCtaCble_Activo;
                        //contact.IdCtaCble_Dep_Acum = info.IdCtaCble_Dep_Acum;
                        //contact.IdCtaCble_Gastos_Depre = info.IdCtaCble_Gastos_Depre;


                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro del Activo Fijo #: " + info.IdActivoFijo.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarUbicacion(Af_CambioUbicacion_Activo_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa && obj.IdActivoFijo == Info.IdActivoFijo );
                    if (contact != null)
                    {
                        contact.IdSucursal = Info.IdSucursal_Actu==null ? contact.IdSucursal : (int)Info.IdSucursal_Actu;
                        contact.IdTipoCatalogo_Ubicacion = Info.IdTipoCatalogo_Ubicacion_Actu == null ? contact.IdTipoCatalogo_Ubicacion : Info.IdTipoCatalogo_Ubicacion_Actu;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(Af_Activo_fijo_Info info, ref int IdActivoFijo, ref string CodActivo, ref string msg)
        {
            try
            {
                try
                {
                    using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                    {
                        Af_Activo_fijo address = new Af_Activo_fijo();
                        int idpv = GetId(info.IdEmpresa);
                        IdActivoFijo = idpv;
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdActivoFijo = info.IdActivoFijo = idpv;
                        address.IdActivoFijoTipo = info.IdActivoFijoTipo;
                        address.IdSucursal = info.IdSucursal;
                        address.CodActivoFijo = CodActivo = info.CodActivoFijo == "" || info.CodActivoFijo == null ? info.IdActivoFijo.ToString() : info.CodActivoFijo.Trim();
                        address.Af_Nombre = info.Af_Nombre;
                        address.IdCatalogo_Marca = info.IdCatalogo_Marca;
                        address.IdCatalogo_Modelo = info.IdCatalogo_Modelo;
                        address.Af_NumSerie = info.Af_NumSerie;
                        address.IdCatalogo_Color = info.IdCatalogo_Color;
                        address.IdTipoCatalogo_Ubicacion = info.IdTipoCatalogo_Ubicacion;
                        address.Af_fecha_compra = info.Af_fecha_compra.Date;
                        address.Af_fecha_ini_depre = info.Af_fecha_ini_depre.Date;
                        address.Af_fecha_fin_depre = info.Af_fecha_fin_depre.Date;
                        address.Af_Costo_historico = info.Af_Costo_historico;
                        address.Af_costo_compra = info.Af_costo_compra;
                        address.Af_Vida_Util = info.Af_Vida_Util;
                        address.Af_Meses_depreciar = info.Af_Meses_depreciar;
                        address.Af_porcentaje_deprec = info.Af_porcentaje_deprec;
                        address.Af_observacion = (info.Af_observacion == null) ? "" : info.Af_observacion;
                        
                        address.Af_NumPlaca = info.Af_NumPlaca;
                        address.Af_Anio_fabrica = info.Af_Anio_fabrica;
                        address.IdUsuario = info.IdUsuario;
                        address.Fecha_Transac = DateTime.Now;
                        address.Estado = "A";
                        address.Af_foto = info.Af_foto;
                        address.Af_DescripcionCorta = info.Af_DescripcionCorta;
                        address.Af_Codigo_Barra = (info.Af_Codigo_Barra == "" || info.Af_Codigo_Barra == null) ? CodActivo : info.Af_Codigo_Barra;

                        address.Af_DescripcionTecnica = info.Af_DescripcionTecnica;
                        address.Estado_Proceso = info.Estado_Proceso;
                        address.Af_ValorSalvamento = info.Af_ValorSalvamento;
                        address.Af_ValorResidual = info.Af_ValorResidual;
                        address.Af_NumSerie_Motor = info.Af_NumSerie_Motor;
                        address.Af_NumSerie_Chasis = info.Af_NumSerie_Chasis;
                        address.IdCategoriaAF = info.IdCategoriaAF;

                        //address.IdCtaCble_Activo = info.IdCtaCble_Activo;
                        //address.IdCtaCble_Dep_Acum = info.IdCtaCble_Dep_Acum;
                        //address.IdCtaCble_Gastos_Depre = info.IdCtaCble_Gastos_Depre;


                        context.Af_Activo_fijo.Add(address);

                        context.SaveChanges();
                        msg = "Se ha procedido a grabar el registro del Activo Fijo #: " + IdActivoFijo.ToString() + " Exitosamente.";
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                 

                    

                    
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = mensaje +" Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                            
                        }
                    }


                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", "Af_Activo_fijo_Data", "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        private string GetCodigoActivo(int IdEmpresa, int IdSucursal, int IdActijoFijoTipo )
        {
            try
            {
                String Codigo = "";
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Activo_fijo
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                             && q.IdActivoFijoTipo == IdActijoFijoTipo
                             select q;

                if (select.ToList().Count == 0)
                {
                    Codigo = "00001";
                }
                else
                {
                    var select_pv = (from q in OEPActivoFijo.Af_Activo_fijo
                                     where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                     && q.IdActivoFijoTipo == IdActijoFijoTipo
                                     select q.CodActivoFijo.Substring(q.CodActivoFijo.Length - 5,5)).Max();

                    Codigo = select_pv.ToString();                       
                    Codigo = (Convert.ToInt32(Codigo.Substring(Codigo.Length - 5,5)) + 1).ToString().PadLeft(5, '0');                 
                }
                return Codigo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(Af_Activo_fijo_Info info, ref  string msg)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdActivoFijo == info.IdActivoFijo && obj.IdActivoFijoTipo == info.IdActivoFijoTipo);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.Estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro del Activo Fijo #: " + info.IdActivoFijo.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarEstadoProceso(int IdEmpresa, int IdActivoFijo ,string EstadoProceso)
        {
            try
            {
                using (EntitiesActivoFijo context = new EntitiesActivoFijo())
                {
                    var contact = context.Af_Activo_fijo.FirstOrDefault(obj => obj.IdEmpresa == IdEmpresa && obj.IdActivoFijo == IdActivoFijo);
                    if (contact != null)
                    {
                        contact.Estado_Proceso = EstadoProceso;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int GetId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
                var select = from q in OEPActivoFijo.Af_Activo_fijo
                             where q.IdEmpresa == IdEmpresa
                             select q;

                if (select.ToList().Count == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEPActivoFijo.Af_Activo_fijo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdActivoFijo).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Af_Activo_fijo_Data()
        {
          
        }

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af(int idEmpresa)
        {
            try
            {
                List<Af_Activo_fijo_Info> Lista = new List<Af_Activo_fijo_Info>();

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var lst = from q in Context.vwAf_Activo_fijo
                              where q.IdEmpresa == idEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                        info.IdEmpresa = item.IdEmpresa;                        
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.nom_encargado = item.nom_encargado;
                        info.CodActivoFijo = item.CodActivoFijo;
                        info.nom_Color = item.nom_Color;
                        info.Marca = item.Marca;
                        info.Modelo = item.Modelo;
                        info.nom_Categoria = item.nom_Categoria;
                        info.valor_salvamento_carroceria = item.valor_salvamento_carroceria;
                        info.costo_compra_carroceria = item.costo_compra_carroceria;
                        //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                        //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                        //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af_x_Categoria(int idEmpresa,int idCategoria)
        {
            try
            {
                List<Af_Activo_fijo_Info> Lista = new List<Af_Activo_fijo_Info>();

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var lst = from q in Context.vwAf_Activo_fijo
                              where q.IdEmpresa == idEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.nom_encargado = item.nom_encargado;
                        info.nom_Color = item.nom_Color;
                        info.Marca = item.Marca;
                        info.Modelo = item.Modelo;
                        info.nom_Categoria = item.nom_Categoria;
                        info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                        info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                        info.Af_Costo_historico = item.Af_Costo_historico;
                        info.Af_costo_compra = item.Af_costo_compra;
                        info.Af_Vida_Util = item.Af_Vida_Util;
                        info.Af_Meses_depreciar = item.Af_Meses_depreciar;                        
                        info.IdEmpresa = item.IdEmpresa;
                        info.valor_salvamento_carroceria = item.valor_salvamento_carroceria;
                        info.costo_compra_carroceria = item.costo_compra_carroceria;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Af_Activo_fijo_Info> Get_List_Vista_Af_x_Categoria(int idEmpresa, int idCategoria, string IdCentroCosto)
        {
            try
            {
                List<Af_Activo_fijo_Info> Lista = new List<Af_Activo_fijo_Info>();

                using (EntitiesActivoFijo Context = new EntitiesActivoFijo())
                {
                    var lst = from q in Context.vwAf_Activo_fijo
                              where q.IdEmpresa == idEmpresa
                              select q;

                    foreach (var item in lst)
                    {
                        Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.Af_Nombre = item.Af_Nombre;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.nom_encargado = item.nom_encargado;
                        info.nom_Color = item.nom_Color;
                        info.Marca = item.Marca;
                        info.Modelo = item.Modelo;
                        info.nom_Categoria = item.nom_Categoria;
                        info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                        info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                        info.Af_Costo_historico = item.Af_Costo_historico;
                        info.Af_costo_compra = item.Af_costo_compra;
                        info.Af_Vida_Util = item.Af_Vida_Util;
                        info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                        info.IdEmpresa = item.IdEmpresa;
                        info.valor_salvamento_carroceria = item.valor_salvamento_carroceria;
                        info.costo_compra_carroceria = item.costo_compra_carroceria;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

     
                
        public List<Af_Activo_fijo_Info> Get_List_ActivoFijo_x_Tipo(int IdEmpresa, int IdTipo)
        {
            List<Af_Activo_fijo_Info> lM = new List<Af_Activo_fijo_Info>();

            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = from A in OEPActivoFijo.Af_Activo_fijo
                             where A.IdEmpresa == IdEmpresa
                             && IdTipo == A.IdActivoFijoTipo

                             select A;

                foreach (var item in select)
                {
                    Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdActivoFijo = item.IdActivoFijo;
                    info.CodActivoFijo = item.CodActivoFijo;
                    info.Af_Nombre = (item.Af_Nombre == null) ? "" : item.Af_Nombre.Trim();
                    info.IdActivoFijoTipo = item.IdActivoFijoTipo;
                    info.IdSucursal = item.IdSucursal;
                    info.IdCatalogo_Marca = item.IdCatalogo_Marca;
                    info.IdCatalogo_Modelo = item.IdCatalogo_Modelo;
                    info.Af_NumSerie = (item.Af_NumSerie == null) ? "" : item.Af_NumSerie.Trim();
                    info.IdCatalogo_Color = item.IdCatalogo_Color;
                    info.IdTipoCatalogo_Ubicacion = item.IdTipoCatalogo_Ubicacion;
                    info.Af_fecha_compra = item.Af_fecha_compra;
                    info.Af_fecha_ini_depre = item.Af_fecha_ini_depre;
                    info.Af_fecha_fin_depre = item.Af_fecha_fin_depre;
                    info.Af_Costo_historico = item.Af_Costo_historico;
                    info.Af_costo_compra = item.Af_costo_compra;
                    info.Af_Vida_Util = item.Af_Vida_Util;
                    info.Af_Meses_depreciar = item.Af_Meses_depreciar;
                    info.Af_porcentaje_deprec = item.Af_porcentaje_deprec;
                    info.Af_observacion = (item.Af_observacion == null) ? "" : item.Af_observacion.Trim();
                    info.Af_NumPlaca = (item.Af_NumPlaca == null) ? "" : item.Af_NumPlaca.Trim();
                    info.Af_Anio_fabrica = item.Af_Anio_fabrica;
                    info.Estado = item.Estado;
                    info.Af_foto = item.Af_foto;
                    info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                    info.Af_Codigo_Barra = item.Af_Codigo_Barra;
                    info.Af_DescripcionTecnica = item.Af_DescripcionTecnica;
                    info.Estado_Proceso = item.Estado_Proceso;
                    info.Af_ValorSalvamento = item.Af_ValorSalvamento;
                    info.Af_ValorResidual = item.Af_ValorResidual;


                    info.Af_NumSerie_Motor = item.Af_NumSerie_Motor;
                    info.Af_NumSerie_Chasis = item.Af_NumSerie_Chasis;
                    info.IdCategoriaAF = item.IdCategoriaAF;
                    
                    //info.IdCtaCble_Activo = item.IdCtaCble_Activo;
                    //info.IdCtaCble_Dep_Acum = item.IdCtaCble_Dep_Acum;
                    //info.IdCtaCble_Gastos_Depre = item.IdCtaCble_Gastos_Depre;


                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public bool EliminarDB_Todos(int idEmpresa, ref string mensaje)
        {
            try
            {
                EntitiesActivoFijo OEAf_ActivoFijo = new EntitiesActivoFijo();
                OEAf_ActivoFijo.Database.ExecuteSqlCommand("delete Af_Activo_fijo where IdEmpresa = " + idEmpresa);

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

       

    }
}
