﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
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
namespace GestionDeStock
{
    #region Contextes
    
    /// <summary>
    /// Aucune documentation sur les métadonnées n'est disponible.
    /// </summary>
    public partial class DbStockContainer : ObjectContext
    {
        #region Constructeurs
    
        /// <summary>
        /// Initialise un nouvel objet DbStockContainer à l'aide de la chaîne de connexion trouvée dans la section 'DbStockContainer' du fichier de configuration d'application.
        /// </summary>
        public DbStockContainer() : base("name=DbStockContainer", "DbStockContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialisez un nouvel objet DbStockContainer.
        /// </summary>
        public DbStockContainer(string connectionString) : base(connectionString, "DbStockContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialisez un nouvel objet DbStockContainer.
        /// </summary>
        public DbStockContainer(EntityConnection connection) : base(connection, "DbStockContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Méthodes partielles
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}