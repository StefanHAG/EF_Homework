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

[assembly: EdmRelationshipAttribute("EF6Recipes2Model", "FK_Poem_Meter", "Meter", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(chapter_2._2.Meter), "Poem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(chapter_2._2.Poem), true)]
[assembly: EdmRelationshipAttribute("EF6Recipes2Model", "FK_Poem_Poet", "Poet", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(chapter_2._2.Poet), "Poem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(chapter_2._2.Poem), true)]

#endregion

namespace chapter_2._2
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EF6Recipes2Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EF6Recipes2Entities object using the connection string found in the 'EF6Recipes2Entities' section of the application configuration file.
        /// </summary>
        public EF6Recipes2Entities() : base("name=EF6Recipes2Entities", "EF6Recipes2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EF6Recipes2Entities object.
        /// </summary>
        public EF6Recipes2Entities(string connectionString) : base(connectionString, "EF6Recipes2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EF6Recipes2Entities object.
        /// </summary>
        public EF6Recipes2Entities(EntityConnection connection) : base(connection, "EF6Recipes2Entities")
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
        public ObjectSet<Meter> Meters
        {
            get
            {
                if ((_Meters == null))
                {
                    _Meters = base.CreateObjectSet<Meter>("Meters");
                }
                return _Meters;
            }
        }
        private ObjectSet<Meter> _Meters;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Poem> Poems
        {
            get
            {
                if ((_Poems == null))
                {
                    _Poems = base.CreateObjectSet<Poem>("Poems");
                }
                return _Poems;
            }
        }
        private ObjectSet<Poem> _Poems;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Poet> Poets
        {
            get
            {
                if ((_Poets == null))
                {
                    _Poets = base.CreateObjectSet<Poet>("Poets");
                }
                return _Poets;
            }
        }
        private ObjectSet<Poet> _Poets;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<vwLibrary> vwLibraries
        {
            get
            {
                if ((_vwLibraries == null))
                {
                    _vwLibraries = base.CreateObjectSet<vwLibrary>("vwLibraries");
                }
                return _vwLibraries;
            }
        }
        private ObjectSet<vwLibrary> _vwLibraries;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Meters EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMeters(Meter meter)
        {
            base.AddObject("Meters", meter);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Poems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPoems(Poem poem)
        {
            base.AddObject("Poems", poem);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Poets EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPoets(Poet poet)
        {
            base.AddObject("Poets", poet);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the vwLibraries EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTovwLibraries(vwLibrary vwLibrary)
        {
            base.AddObject("vwLibraries", vwLibrary);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF6Recipes2Model", Name="Meter")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Meter : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Meter object.
        /// </summary>
        /// <param name="meterId">Initial value of the MeterId property.</param>
        /// <param name="meterName">Initial value of the MeterName property.</param>
        public static Meter CreateMeter(global::System.Int32 meterId, global::System.String meterName)
        {
            Meter meter = new Meter();
            meter.MeterId = meterId;
            meter.MeterName = meterName;
            return meter;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MeterId
        {
            get
            {
                return _MeterId;
            }
            set
            {
                if (_MeterId != value)
                {
                    OnMeterIdChanging(value);
                    ReportPropertyChanging("MeterId");
                    _MeterId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MeterId");
                    OnMeterIdChanged();
                }
            }
        }
        private global::System.Int32 _MeterId;
        partial void OnMeterIdChanging(global::System.Int32 value);
        partial void OnMeterIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MeterName
        {
            get
            {
                return _MeterName;
            }
            set
            {
                OnMeterNameChanging(value);
                ReportPropertyChanging("MeterName");
                _MeterName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MeterName");
                OnMeterNameChanged();
            }
        }
        private global::System.String _MeterName;
        partial void OnMeterNameChanging(global::System.String value);
        partial void OnMeterNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EF6Recipes2Model", "FK_Poem_Meter", "Poem")]
        public EntityCollection<Poem> Poems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Poem>("EF6Recipes2Model.FK_Poem_Meter", "Poem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Poem>("EF6Recipes2Model.FK_Poem_Meter", "Poem", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF6Recipes2Model", Name="Poem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Poem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Poem object.
        /// </summary>
        /// <param name="poemId">Initial value of the PoemId property.</param>
        /// <param name="poetId">Initial value of the PoetId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="meterId">Initial value of the MeterId property.</param>
        public static Poem CreatePoem(global::System.Int32 poemId, global::System.Int32 poetId, global::System.String title, global::System.Int32 meterId)
        {
            Poem poem = new Poem();
            poem.PoemId = poemId;
            poem.PoetId = poetId;
            poem.Title = title;
            poem.MeterId = meterId;
            return poem;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PoemId
        {
            get
            {
                return _PoemId;
            }
            set
            {
                if (_PoemId != value)
                {
                    OnPoemIdChanging(value);
                    ReportPropertyChanging("PoemId");
                    _PoemId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PoemId");
                    OnPoemIdChanged();
                }
            }
        }
        private global::System.Int32 _PoemId;
        partial void OnPoemIdChanging(global::System.Int32 value);
        partial void OnPoemIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PoetId
        {
            get
            {
                return _PoetId;
            }
            set
            {
                OnPoetIdChanging(value);
                ReportPropertyChanging("PoetId");
                _PoetId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PoetId");
                OnPoetIdChanged();
            }
        }
        private global::System.Int32 _PoetId;
        partial void OnPoetIdChanging(global::System.Int32 value);
        partial void OnPoetIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MeterId
        {
            get
            {
                return _MeterId;
            }
            set
            {
                OnMeterIdChanging(value);
                ReportPropertyChanging("MeterId");
                _MeterId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MeterId");
                OnMeterIdChanged();
            }
        }
        private global::System.Int32 _MeterId;
        partial void OnMeterIdChanging(global::System.Int32 value);
        partial void OnMeterIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EF6Recipes2Model", "FK_Poem_Meter", "Meter")]
        public Meter Meter
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Meter>("EF6Recipes2Model.FK_Poem_Meter", "Meter").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Meter>("EF6Recipes2Model.FK_Poem_Meter", "Meter").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Meter> MeterReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Meter>("EF6Recipes2Model.FK_Poem_Meter", "Meter");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Meter>("EF6Recipes2Model.FK_Poem_Meter", "Meter", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EF6Recipes2Model", "FK_Poem_Poet", "Poet")]
        public Poet Poet
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Poet>("EF6Recipes2Model.FK_Poem_Poet", "Poet").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Poet>("EF6Recipes2Model.FK_Poem_Poet", "Poet").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Poet> PoetReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Poet>("EF6Recipes2Model.FK_Poem_Poet", "Poet");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Poet>("EF6Recipes2Model.FK_Poem_Poet", "Poet", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF6Recipes2Model", Name="Poet")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Poet : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Poet object.
        /// </summary>
        /// <param name="poetId">Initial value of the PoetId property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        public static Poet CreatePoet(global::System.Int32 poetId, global::System.String firstName, global::System.String lastName)
        {
            Poet poet = new Poet();
            poet.PoetId = poetId;
            poet.FirstName = firstName;
            poet.LastName = lastName;
            return poet;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PoetId
        {
            get
            {
                return _PoetId;
            }
            set
            {
                if (_PoetId != value)
                {
                    OnPoetIdChanging(value);
                    ReportPropertyChanging("PoetId");
                    _PoetId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PoetId");
                    OnPoetIdChanged();
                }
            }
        }
        private global::System.Int32 _PoetId;
        partial void OnPoetIdChanging(global::System.Int32 value);
        partial void OnPoetIdChanged();
    
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
        [EdmRelationshipNavigationPropertyAttribute("EF6Recipes2Model", "FK_Poem_Poet", "Poem")]
        public EntityCollection<Poem> Poems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Poem>("EF6Recipes2Model.FK_Poem_Poet", "Poem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Poem>("EF6Recipes2Model.FK_Poem_Poet", "Poem", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF6Recipes2Model", Name="vwLibrary")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class vwLibrary : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new vwLibrary object.
        /// </summary>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="meterName">Initial value of the MeterName property.</param>
        public static vwLibrary CreatevwLibrary(global::System.String firstName, global::System.String lastName, global::System.String title, global::System.String meterName)
        {
            vwLibrary vwLibrary = new vwLibrary();
            vwLibrary.FirstName = firstName;
            vwLibrary.LastName = lastName;
            vwLibrary.Title = title;
            vwLibrary.MeterName = meterName;
            return vwLibrary;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (_FirstName != value)
                {
                    OnFirstNameChanging(value);
                    ReportPropertyChanging("FirstName");
                    _FirstName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("FirstName");
                    OnFirstNameChanged();
                }
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (_LastName != value)
                {
                    OnLastNameChanging(value);
                    ReportPropertyChanging("LastName");
                    _LastName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("LastName");
                    OnLastNameChanged();
                }
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                if (_Title != value)
                {
                    OnTitleChanging(value);
                    ReportPropertyChanging("Title");
                    _Title = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Title");
                    OnTitleChanged();
                }
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MeterName
        {
            get
            {
                return _MeterName;
            }
            set
            {
                if (_MeterName != value)
                {
                    OnMeterNameChanging(value);
                    ReportPropertyChanging("MeterName");
                    _MeterName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("MeterName");
                    OnMeterNameChanged();
                }
            }
        }
        private global::System.String _MeterName;
        partial void OnMeterNameChanging(global::System.String value);
        partial void OnMeterNameChanged();

        #endregion

    
    }

    #endregion

    
}