﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EF6Recipes3Model", "LinkTable", "Album", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(chapter_2._3.Album), "Artist", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(chapter_2._3.Artist))]

#endregion

namespace chapter_2._3
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EF6Recipes3Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EF6Recipes3Entities object using the connection string found in the 'EF6Recipes3Entities' section of the application configuration file.
        /// </summary>
        public EF6Recipes3Entities() : base("name=EF6Recipes3Entities", "EF6Recipes3Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EF6Recipes3Entities object.
        /// </summary>
        public EF6Recipes3Entities(string connectionString) : base(connectionString, "EF6Recipes3Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EF6Recipes3Entities object.
        /// </summary>
        public EF6Recipes3Entities(EntityConnection connection) : base(connection, "EF6Recipes3Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Album> Albums
        {
            get
            {
                if ((_Albums == null))
                {
                    _Albums = base.CreateObjectSet<Album>("Albums");
                }
                return _Albums;
            }
        }
        private ObjectSet<Album> _Albums;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Artist> Artists
        {
            get
            {
                if ((_Artists == null))
                {
                    _Artists = base.CreateObjectSet<Artist>("Artists");
                }
                return _Artists;
            }
        }
        private ObjectSet<Artist> _Artists;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Albums EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAlbums(Album album)
        {
            base.AddObject("Albums", album);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Artists EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToArtists(Artist artist)
        {
            base.AddObject("Artists", artist);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF6Recipes3Model", Name="Album")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Album : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Album object.
        /// </summary>
        /// <param name="albumId">Initial value of the AlbumId property.</param>
        /// <param name="albumName">Initial value of the AlbumName property.</param>
        public static Album CreateAlbum(global::System.Int32 albumId, global::System.String albumName)
        {
            Album album = new Album();
            album.AlbumId = albumId;
            album.AlbumName = albumName;
            return album;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AlbumId
        {
            get
            {
                return _AlbumId;
            }
            set
            {
                if (_AlbumId != value)
                {
                    OnAlbumIdChanging(value);
                    ReportPropertyChanging("AlbumId");
                    _AlbumId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AlbumId");
                    OnAlbumIdChanged();
                }
            }
        }
        private global::System.Int32 _AlbumId;
        partial void OnAlbumIdChanging(global::System.Int32 value);
        partial void OnAlbumIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AlbumName
        {
            get
            {
                return _AlbumName;
            }
            set
            {
                OnAlbumNameChanging(value);
                ReportPropertyChanging("AlbumName");
                _AlbumName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AlbumName");
                OnAlbumNameChanged();
            }
        }
        private global::System.String _AlbumName;
        partial void OnAlbumNameChanging(global::System.String value);
        partial void OnAlbumNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EF6Recipes3Model", "LinkTable", "Artist")]
        public EntityCollection<Artist> Artists
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Artist>("EF6Recipes3Model.LinkTable", "Artist");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Artist>("EF6Recipes3Model.LinkTable", "Artist", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF6Recipes3Model", Name="Artist")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Artist : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Artist object.
        /// </summary>
        /// <param name="artistId">Initial value of the ArtistId property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        public static Artist CreateArtist(global::System.Int32 artistId, global::System.String firstName, global::System.String lastName)
        {
            Artist artist = new Artist();
            artist.ArtistId = artistId;
            artist.FirstName = firstName;
            artist.LastName = lastName;
            return artist;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ArtistId
        {
            get
            {
                return _ArtistId;
            }
            set
            {
                if (_ArtistId != value)
                {
                    OnArtistIdChanging(value);
                    ReportPropertyChanging("ArtistId");
                    _ArtistId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ArtistId");
                    OnArtistIdChanged();
                }
            }
        }
        private global::System.Int32 _ArtistId;
        partial void OnArtistIdChanging(global::System.Int32 value);
        partial void OnArtistIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EF6Recipes3Model", "LinkTable", "Album")]
        public EntityCollection<Album> Albums
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Album>("EF6Recipes3Model.LinkTable", "Album");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Album>("EF6Recipes3Model.LinkTable", "Album", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}