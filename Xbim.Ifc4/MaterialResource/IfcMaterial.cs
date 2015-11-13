// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterial
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterial : IIfcMaterialDefinition
	{
		IfcLabel @Name { get; }
		IfcText? @Description { get; }
		IfcLabel? @Category { get; }
		IEnumerable<IIfcMaterialDefinitionRepresentation> @HasRepresentation {  get; }
		IEnumerable<IIfcMaterialRelationship> @IsRelatedWith {  get; }
		IEnumerable<IIfcMaterialRelationship> @RelatesTo {  get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[IndexedClass]
	[ExpressType("IFCMATERIAL", 749)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterial : IfcMaterialDefinition, IInstantiableEntity, IIfcMaterial, IEqualityComparer<@IfcMaterial>, IEquatable<@IfcMaterial>
	{
		#region IIfcMaterial explicit implementation
		IfcLabel IIfcMaterial.Name { get { return @Name; } }	
		IfcText? IIfcMaterial.Description { get { return @Description; } }	
		IfcLabel? IIfcMaterial.Category { get { return @Category; } }	
		 
		IEnumerable<IIfcMaterialDefinitionRepresentation> IIfcMaterial.HasRepresentation {  get { return @HasRepresentation; } }
		IEnumerable<IIfcMaterialRelationship> IIfcMaterial.IsRelatedWith {  get { return @IsRelatedWith; } }
		IEnumerable<IIfcMaterialRelationship> IIfcMaterial.RelatesTo {  get { return @RelatesTo; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterial(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcLabel? _category;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _category;
				((IPersistEntity)this).Activate(false);
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category");
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcMaterialDefinitionRepresentation> @HasRepresentation 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialDefinitionRepresentation>(e => (e.RepresentedMaterial as IfcMaterial) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcMaterialRelationship> @IsRelatedWith 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialRelationship>(e => e.RelatedMaterials != null &&  e.RelatedMaterials.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcMaterialRelationship> @RelatesTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialRelationship>(e => (e.RelatingMaterial as IfcMaterial) == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_category = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterial other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterial
            var root = (@IfcMaterial)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterial left, @IfcMaterial right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterial left, @IfcMaterial right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterial x, @IfcMaterial y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterial obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}