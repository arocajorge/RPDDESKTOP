﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
   public  class ro_Area_X_Departamento_Data
    {
        string mensaje = "";

       public List<ro_Area_X_Departamento_Info> Get_List_Area_X_Departamento(int IdEmpresa, ref string msg)
        {
            List<ro_Area_X_Departamento_Info> listado = new List<ro_Area_X_Departamento_Info>();
            try
            {

                EntitiesRoles db = new EntitiesRoles();

                var datos = from A in db.ro_area_x_departamento
                                where A.IdEmpresa == IdEmpresa
                                select A;

                foreach (var item in datos)
                {
                    ro_Area_X_Departamento_Info info = new ro_Area_X_Departamento_Info();


                    info.IdEmpresa = item.IdEmpresa;
                    info.IdDivision = item.IdDivision;
                    info.IdArea = item.IdArea;
                    info.IdDepartamento = item.IdDepartamento;
                    info.IdEmpresa = item.Secuencia;
                    
                    listado.Add(info);
                }
                return (listado);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

       public Boolean GrabarBD(ro_Area_X_Departamento_Info info, ref string msg){
           try{

               using(EntitiesRoles db=new EntitiesRoles()){
                   ro_area_x_departamento item = new ro_area_x_departamento();

                   item.IdEmpresa = info.IdEmpresa;
                   item.Secuencia = getId(info.IdEmpresa);
                   item.IdDivision = info.IdDivision;
                   item.IdArea = info.IdArea;
                   item.IdDepartamento = info.IdDepartamento;
                   db.ro_area_x_departamento.Add(item);
                   db.SaveChanges();
               
               }
               return true;
           }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

       public Boolean EliminarBD(int IdEmpresa,ref string msg)
       {
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   db.Database.ExecuteSqlCommand("delete from dbo.ro_area_x_departamento where IdEmpresa =" + IdEmpresa.ToString());
               }

               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.InnerException.ToString());
           }

       }

       public int getId(int IdEmpresa)
       {
           int Id = 0;
           try
           {

               EntitiesRoles contex = new EntitiesRoles();
               var selecte = contex.ro_area_x_departamento.Count(q => q.IdEmpresa == IdEmpresa);

               if (selecte == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_em = (from q in contex.ro_area_x_departamento
                                    where q.IdEmpresa == IdEmpresa
                                    select q.Secuencia).Max();
                   Id = Convert.ToInt32(select_em.ToString()) + 1;
               }

               return Id;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.InnerException.ToString());
           }
       }

    }
}
