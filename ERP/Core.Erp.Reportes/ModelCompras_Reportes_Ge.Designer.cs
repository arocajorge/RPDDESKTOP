﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Core.Erp.Reportes
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class EntitiesCompras_Reportes_Ge : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto EntitiesCompras_Reportes_Ge usando la cadena de conexión encontrada en la sección 'EntitiesCompras_Reportes_Ge' del archivo de configuración de la aplicación.
        /// </summary>
        public EntitiesCompras_Reportes_Ge() : base("name=EntitiesCompras_Reportes_Ge", "EntitiesCompras_Reportes_Ge")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto EntitiesCompras_Reportes_Ge.
        /// </summary>
        public EntitiesCompras_Reportes_Ge(string connectionString) : base(connectionString, "EntitiesCompras_Reportes_Ge")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto EntitiesCompras_Reportes_Ge.
        /// </summary>
        public EntitiesCompras_Reportes_Ge(EntityConnection connection) : base(connection, "EntitiesCompras_Reportes_Ge")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

    
}
