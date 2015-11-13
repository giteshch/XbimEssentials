// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBSplineSurfaceWithKnots
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBSplineSurfaceWithKnots : IIfcBSplineSurface
	{
		IEnumerable<IfcInteger> @UMultiplicities { get; }
		IEnumerable<IfcInteger> @VMultiplicities { get; }
		IEnumerable<IfcParameterValue> @UKnots { get; }
		IEnumerable<IfcParameterValue> @VKnots { get; }
		IfcKnotType @KnotSpec { get; }
		IfcInteger @KnotVUpper  { get ; }
		IfcInteger @KnotUUpper  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCBSPLINESURFACEWITHKNOTS", 433)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBSplineSurfaceWithKnots : IfcBSplineSurface, IInstantiableEntity, IIfcBSplineSurfaceWithKnots, IEqualityComparer<@IfcBSplineSurfaceWithKnots>, IEquatable<@IfcBSplineSurfaceWithKnots>
	{
		#region IIfcBSplineSurfaceWithKnots explicit implementation
		IEnumerable<IfcInteger> IIfcBSplineSurfaceWithKnots.UMultiplicities { get { return @UMultiplicities; } }	
		IEnumerable<IfcInteger> IIfcBSplineSurfaceWithKnots.VMultiplicities { get { return @VMultiplicities; } }	
		IEnumerable<IfcParameterValue> IIfcBSplineSurfaceWithKnots.UKnots { get { return @UKnots; } }	
		IEnumerable<IfcParameterValue> IIfcBSplineSurfaceWithKnots.VKnots { get { return @VKnots; } }	
		IfcKnotType IIfcBSplineSurfaceWithKnots.KnotSpec { get { return @KnotSpec; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineSurfaceWithKnots(IModel model) : base(model) 		{ 
			Model = model; 
			_uMultiplicities = new ItemSet<IfcInteger>( this, 0 );
			_vMultiplicities = new ItemSet<IfcInteger>( this, 0 );
			_uKnots = new ItemSet<IfcParameterValue>( this, 0 );
			_vKnots = new ItemSet<IfcParameterValue>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcInteger> _uMultiplicities;
		private ItemSet<IfcInteger> _vMultiplicities;
		private ItemSet<IfcParameterValue> _uKnots;
		private ItemSet<IfcParameterValue> _vKnots;
		private IfcKnotType _knotSpec;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<IfcInteger> @UMultiplicities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _uMultiplicities;
				((IPersistEntity)this).Activate(false);
				return _uMultiplicities;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<IfcInteger> @VMultiplicities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vMultiplicities;
				((IPersistEntity)this).Activate(false);
				return _vMultiplicities;
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<IfcParameterValue> @UKnots 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _uKnots;
				((IPersistEntity)this).Activate(false);
				return _uKnots;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<IfcParameterValue> @VKnots 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vKnots;
				((IPersistEntity)this).Activate(false);
				return _vKnots;
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcKnotType @KnotSpec 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _knotSpec;
				((IPersistEntity)this).Activate(false);
				return _knotSpec;
			} 
			set
			{
				SetValue( v =>  _knotSpec = v, _knotSpec, value,  "KnotSpec");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger @KnotVUpper 
		{
			get 
			{
				//## Getter for KnotVUpper
			    return VKnots.Count;
			    //##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger @KnotUUpper 
		{
			get 
			{
				//## Getter for KnotUUpper
			    return UKnots.Count;
			    //##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					if (_uMultiplicities == null) _uMultiplicities = new ItemSet<IfcInteger>( this );
					_uMultiplicities.InternalAdd(value.IntegerVal);
					return;
				case 8: 
					if (_vMultiplicities == null) _vMultiplicities = new ItemSet<IfcInteger>( this );
					_vMultiplicities.InternalAdd(value.IntegerVal);
					return;
				case 9: 
					if (_uKnots == null) _uKnots = new ItemSet<IfcParameterValue>( this );
					_uKnots.InternalAdd(value.RealVal);
					return;
				case 10: 
					if (_vKnots == null) _vKnots = new ItemSet<IfcParameterValue>( this );
					_vKnots.InternalAdd(value.RealVal);
					return;
				case 11: 
                    _knotSpec = (IfcKnotType) System.Enum.Parse(typeof (IfcKnotType), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*UDirectionConstraints:  SELF\IfcBSplineSurface.UUpper, UMultiplicities, UKnots);*/
		/*VDirectionConstraints:  SELF\IfcBSplineSurface.VUpper, VMultiplicities, VKnots);*/
		/*CorrespondingULists:	CorrespondingULists : SIZEOF(UMultiplicities) = KnotUUpper;*/
		/*CorrespondingVLists:	CorrespondingVLists : SIZEOF(VMultiplicities) = KnotVUpper;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBSplineSurfaceWithKnots other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBSplineSurfaceWithKnots
            var root = (@IfcBSplineSurfaceWithKnots)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBSplineSurfaceWithKnots left, @IfcBSplineSurfaceWithKnots right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBSplineSurfaceWithKnots left, @IfcBSplineSurfaceWithKnots right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBSplineSurfaceWithKnots x, @IfcBSplineSurfaceWithKnots y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBSplineSurfaceWithKnots obj)
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