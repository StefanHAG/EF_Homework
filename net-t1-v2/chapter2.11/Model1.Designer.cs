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

[assembly: EdmRelationshipAttribute("EF6Recipes11Model", "FK_Park_Location1", "Location", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(chapter2._11.Location), "Park", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(chapter2._11.Park), true)]

#endregion

namespace chapter2._11
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EF6Recipes11 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EF6Recipes11 object using the connection string found in the 'EF6Recipes11' section of the application configuration file.
        /// </summary>
        public EF6Recipes11() : base("name=EF6Recipes11", "EF6Recipes11")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EF6Recipes11 object.
        /// </summary>
        public EF6Recipes11(string connectionString) : base(connectionString, "EF6Recipes11")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EF6Recipes11 object.
        /// </summary>
        public EF6Recipes11(EntityConnection connection) : base(connection, "EF6Recipes11")
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
        public ObjectSet<Location> Locations
        {
            get
            {
                if ((_Locations == null))
                {
                    _Locations = base.CreateObjectSet<Location>("Locations");
                }
                return _Locations;
            }
        }
        private ObjectSet<Location> _Locations;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Locations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLocations(Location location)
        {
            base.AddObject("Locations", location);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF6Recipes11Model", Name="Location")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    [KnownTypeAttribute(typeof(Park))]
    public partial class Location : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Location object.
        /// </summary>
        /// <param name="locationID">Initial value of the LocationID property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="state">Initial value of the State property.</param>
        /// <param name="zIPCode">Initial value of the ZIPCode property.</param>
        public static Location CreateLocation(global::System.Int32 locationID, global::System.String address, global::System.String city, global::System.String state, global::System.String zIPCode)
        {
            Location location = new Location();
            location.LocationID = locationID;
            location.Address = address;
            location.City = city;
            location.State = state;
            location.ZIPCode = zIPCode;
            return location;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 LocationID
        {
            get
            {
                return _LocationID;
            }
            set
            {
                if (_LocationID != value)
                {
                    OnLocationIDChanging(value);
                    ReportPropertyChanging("LocationID");
                    _LocationID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("LocationID");
                    OnLocationIDChanged();
                }
            }
        }
        private global::System.Int32 _LocationID;
        partial void OnLocationIDChanging(global::System.Int32 value);
        partial void OnLocationIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ZIPCode
        {
            get
            {
                return _ZIPCode;
            }
            set
            {
                OnZIPCodeChanging(value);
                ReportPropertyChanging("ZIPCode");
                _ZIPCode = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ZIPCode");
                OnZIPCodeChanged();
            }
        }
        private global::System.String _ZIPCode;
        partial void OnZIPCodeChanging(global::System.String value);
        partial void OnZIPCodeChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EF6Recipes11Model", "FK_Park_Location1", "Park")]
        public EntityCollection<Park> Parks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Park>("EF6Recipes11Model.FK_Park_Location1", "Park");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Park>("EF6Recipes11Model.FK_Park_Location1", "Park", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF6Recipes11Model", Name="Park")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Park : Location
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Park object.
        /// </summary>
        /// <param name="locationID">Initial value of the LocationID property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="state">Initial value of the State property.</param>
        /// <param name="zIPCode">Initial value of the ZIPCode property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Park CreatePark(global::System.Int32 locationID, global::System.String address, global::System.String city, global::System.String state, global::System.String zIPCode, global::System.String name)
        {
            Park park = new Park();
            park.LocationID = locationID;
            park.Address = address;
            park.City = city;
            park.State = state;
            park.ZIPCode = zIPCode;
            park.Name = name;
            return park;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> OfficeLocationID
        {
            get
            {
                return _OfficeLocationID;
            }
            set
            {
                OnOfficeLocationIDChanging(value);
                ReportPropertyChanging("OfficeLocationID");
                _OfficeLocationID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OfficeLocationID");
                OnOfficeLocationIDChanged();
            }
        }
        private Nullable<global::System.Int32> _OfficeLocationID;
        partial void OnOfficeLocationIDChanging(Nullable<global::System.Int32> value);
        partial void OnOfficeLocationIDChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EF6Recipes11Model", "FK_Park_Location1", "Location")]
        public Location Office
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Location>("EF6Recipes11Model.FK_Park_Location1", "Location").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Location>("EF6Recipes11Model.FK_Park_Location1", "Location").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Location> OfficeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Location>("EF6Recipes11Model.FK_Park_Location1", "Location");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Location>("EF6Recipes11Model.FK_Park_Location1", "Location", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
