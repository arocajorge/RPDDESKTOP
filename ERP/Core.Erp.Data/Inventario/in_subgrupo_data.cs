using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Inventario
{
   public  class in_subgrupo_data
    {

        string mensaje = "";

        public int GetIdSubGrupo(int IdEmpresa, string IdCategoria, int IdLinea,int IdGrupo)
        {
            try
            {
                int IdSubGrupo = 0;
                EntitiesInventario OESubGrupo = new EntitiesInventario();

                var selecte = OESubGrupo.in_subgrupo.Count(q => q.IdEmpresa == IdEmpresa && q.IdCategoria == IdCategoria && q.IdLinea == IdLinea && q.IdGrupo == IdGrupo);

                if (selecte == 0)
                {
                    IdSubGrupo = 1;
                }
                else
                {
                    OESubGrupo = new EntitiesInventario();
                    var selectSubGrupo = (from Subgrupo in OESubGrupo.in_subgrupo
                                          where Subgrupo.IdEmpresa == IdEmpresa
                                          && Subgrupo.IdCategoria == IdCategoria
                                          && Subgrupo.IdLinea == IdLinea
                                          && Subgrupo.IdGrupo == IdGrupo

                                          select Subgrupo.IdSubgrupo).Max();
                    IdSubGrupo = Convert.ToInt32(selectSubGrupo.ToString()) + 1;
                }
                return IdSubGrupo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean GrabarDB(in_subgrupo_info info, ref int IdSubGrupo, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var lst = from q in context.in_subgrupo
                              where q.IdEmpresa == info.IdEmpresa
                              && q.IdCategoria == info.IdCategoria
                              && q.IdLinea == info.IdLinea
                              && q.IdGrupo == info.IdGrupo
                              && q.IdSubgrupo == info.IdSubgrupo
                              select q;

                    if (lst.Count()==0)
                    {
                        in_subgrupo objSubGrupo = new in_subgrupo();

                        objSubGrupo.IdEmpresa = info.IdEmpresa;
                        objSubGrupo.IdCategoria = info.IdCategoria;
                        objSubGrupo.IdLinea = info.IdLinea;
                        objSubGrupo.IdGrupo = info.IdGrupo;

                        objSubGrupo.IdSubgrupo = IdSubGrupo = (info.IdSubgrupo == null || info.IdSubgrupo == 0) ? GetIdSubGrupo(info.IdEmpresa, info.IdCategoria, info.IdLinea, info.IdGrupo) : info.IdSubgrupo;

                        if (info.cod_subgrupo == null || info.cod_subgrupo == "")
                        {
                            info.cod_subgrupo = objSubGrupo.IdSubgrupo.ToString();
                        }

                        objSubGrupo.cod_subgrupo = info.cod_subgrupo.Trim();


                        objSubGrupo.nom_subgrupo = info.nom_subgrupo.Trim();

                        if (info.abreviatura == null || info.abreviatura == "")
                        {
                            info.abreviatura = info.cod_subgrupo.Trim();
                        }

                        objSubGrupo.Estado = "A";

                        if (info.observacion == "" || info.observacion == null)
                        {
                            info.observacion = "";
                        }

                        objSubGrupo.observacion = info.observacion;
                        objSubGrupo.IdUsuario = (info.IdUsuario == null) ? "" : info.IdUsuario;
                        objSubGrupo.Fecha_Transac = DateTime.Now;
                        objSubGrupo.nom_pc = info.nom_pc;
                        objSubGrupo.ip = info.ip;
                        
                       
                        context.in_subgrupo.Add(objSubGrupo);
                        context.SaveChanges();    
                    }
                    msg = "Grabación ok..";
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
                throw new Exception(mensaje);
            }

        }

        public Boolean ModificarDB(in_subgrupo_info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_subgrupo.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdLinea == info.IdLinea && var.IdGrupo == info.IdGrupo && var.IdCategoria == info.IdCategoria && var.IdSubgrupo==info.IdSubgrupo);
                    if (contact != null)
                    {
                        contact.cod_subgrupo = info.cod_subgrupo;
                        contact.nom_subgrupo = info.nom_subgrupo;
                        contact.observacion = info.observacion;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;


                        
                        context.SaveChanges();
                        msg = "Grabación ok..";
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
                throw new Exception(mensaje);
            }
        }

        public Boolean AnularDB(in_subgrupo_info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_subgrupo.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdLinea == info.IdLinea && var.IdGrupo == info.IdGrupo && var.IdCategoria == info.IdCategoria && var.IdSubgrupo==info.IdSubgrupo);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        context.SaveChanges();
                        msg = "Anulación ok..";
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
                throw new Exception(mensaje);
            }
        }

        public List<in_subgrupo_info> Get_List_in_subgrupo(int IdEmpresa, string IdCategoria, int IdLinea, int IdGrupo)
        {
            try
            {
                List<in_subgrupo_info> lM = new List<in_subgrupo_info>();

                EntitiesInventario OEUser = new EntitiesInventario();

                var select_ = from TI in OEUser.in_subgrupo
                              where TI.IdEmpresa == IdEmpresa
                               && TI.IdCategoria == IdCategoria
                               && TI.IdLinea == IdLinea
                               && TI.IdGrupo == IdGrupo
                              select TI;


                foreach (var item in select_)
                {
                    in_subgrupo_info dat_ = new in_subgrupo_info();
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCategoria = item.IdCategoria;
                    dat_.IdLinea = item.IdLinea;
                    dat_.IdGrupo = item.IdGrupo;
                    dat_.IdSubgrupo = item.IdSubgrupo;
                    dat_.nom_subgrupo = item.nom_subgrupo;
                    dat_.observacion = item.observacion;
                    dat_.cod_subgrupo = item.cod_subgrupo;       dat_.Estado = item.Estado;

                                        
                    lM.Add(dat_);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public in_subgrupo_info Get_Info_in_subgrupo(int IdEmpresa, string IdCategoria, int IdLinea, int IdGrupo, int IdSubGrupo)
       {
           try
           {
               in_subgrupo_info dat_ = new in_subgrupo_info();

               EntitiesInventario OEUser = new EntitiesInventario();

               var select_ = from TI in OEUser.in_subgrupo
                             where TI.IdEmpresa == IdEmpresa
                              && TI.IdCategoria == IdCategoria
                              && TI.IdLinea == IdLinea
                              && TI.IdGrupo == IdGrupo
                              && TI.IdSubgrupo == IdSubGrupo
                             select TI;

               foreach (var item in select_)
               {
                 //  in_subgrupo_info dat_ = new in_subgrupo_info();
                   dat_.IdEmpresa = item.IdEmpresa;
                   dat_.IdCategoria = item.IdCategoria;
                   dat_.IdLinea = item.IdLinea;
                   dat_.IdGrupo = item.IdGrupo;
                   dat_.IdSubgrupo = item.IdSubgrupo;
                   dat_.nom_subgrupo = item.nom_subgrupo;
                   dat_.observacion = item.observacion;
                   dat_.cod_subgrupo = item.cod_subgrupo;
                   dat_.Estado = item.Estado;

               }
               return (dat_);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

        public List<in_subgrupo_info> Get_List_in_subgrupo(int IdEmpresa)
       {
           try
           {
               List<in_subgrupo_info> lM = new List<in_subgrupo_info>();

               EntitiesInventario OEUser = new EntitiesInventario();

               var select_ = from TI in OEUser.in_subgrupo
                             where TI.IdEmpresa == IdEmpresa
                          
                             select TI;

               foreach (var item in select_)
               {
                   in_subgrupo_info dat_ = new in_subgrupo_info();
                   dat_.IdEmpresa = item.IdEmpresa;
                   dat_.IdCategoria = item.IdCategoria;
                   dat_.IdLinea = item.IdLinea;
                   dat_.IdGrupo = item.IdGrupo;
                   dat_.IdSubgrupo = item.IdSubgrupo;
                   dat_.nom_subgrupo = item.nom_subgrupo;
                   dat_.observacion = item.observacion;
                   dat_.cod_subgrupo = item.cod_subgrupo;
                   dat_.Estado = item.Estado;
                                      
                   lM.Add(dat_);
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }
    }
}
