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
using Xbim.Ifc4.RepresentationResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMapConversion
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMapConversion : IIfcCoordinateOperation
	{
		IfcLengthMeasure @Eastings { get; }
		IfcLengthMeasure @Northings { get; }
		IfcLengthMeasure @OrthogonalHeight { get; }
		IfcReal? @XAxisAbscissa { get; }
		IfcReal? @XAxisOrdinate { get; }
		IfcReal? @Scale { get; }
	
	}
}

namespace Xbim.Ifc4.RepresentationResource
{
	[ExpressType("IFCMAPCONVERSION", 747)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMapConversion : IfcCoordinateOperation, IInstantiableEntity, IIfcMapConversion, IEqualityComparer<@IfcMapConversion>, IEquatable<@IfcMapConversion>
	{
		#region IIfcMapConversion explicit implementation
		IfcLengthMeasure IIfcMapConversion.Eastings { get { return @Eastings; } }	
		IfcLengthMeasure IIfcMapConversion.Northings { get { return @Northings; } }	
		IfcLengthMeasure IIfcMapConversion.OrthogonalHeight { get { return @OrthogonalHeight; } }	
		IfcReal? IIfcMapConversion.XAxisAbscissa { get { return @XAxisAbscissa; } }	
		IfcReal? IIfcMapConversion.XAxisOrdinate { get { return @XAxisOrdinate; } }	
		IfcReal? IIfcMapConversion.Scale { get { return @Scale; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMapConversion(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _eastings;
		private IfcLengthMeasure _northings;
		private IfcLengthMeasure _orthogonalHeight;
		private IfcReal? _xAxisAbscissa;
		private IfcReal? _xAxisOrdinate;
		private IfcReal? _scale;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @Eastings 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _eastings;
				((IPersistEntity)this).Activate(false);
				return _eastings;
			} 
			set
			{
				SetValue( v =>  _eastings = v, _eastings, value,  "Eastings");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @Northings 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _northings;
				((IPersistEntity)this).Activate(false);
				return _northings;
			} 
			set
			{
				SetValue( v =>  _northings = v, _northings, value,  "Northings");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @OrthogonalHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _orthogonalHeight;
				((IPersistEntity)this).Activate(false);
				return _orthogonalHeight;
			} 
			set
			{
				SetValue( v =>  _orthogonalHeight = v, _orthogonalHeight, value,  "OrthogonalHeight");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @XAxisAbscissa 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _xAxisAbscissa;
				((IPersistEntity)this).Activate(false);
				return _xAxisAbscissa;
			} 
			set
			{
				SetValue( v =>  _xAxisAbscissa = v, _xAxisAbscissa, value,  "XAxisAbscissa");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @XAxisOrdinate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _xAxisOrdinate;
				((IPersistEntity)this).Activate(false);
				return _xAxisOrdinate;
			} 
			set
			{
				SetValue( v =>  _xAxisOrdinate = v, _xAxisOrdinate, value,  "XAxisOrdinate");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcReal? @Scale 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scale;
				((IPersistEntity)this).Activate(false);
				return _scale;
			} 
			set
			{
				SetValue( v =>  _scale = v, _scale, value,  "Scale");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_eastings = value.RealVal;
					return;
				case 3: 
					_northings = value.RealVal;
					return;
				case 4: 
					_orthogonalHeight = value.RealVal;
					return;
				case 5: 
					_xAxisAbscissa = value.RealVal;
					return;
				case 6: 
					_xAxisOrdinate = value.RealVal;
					return;
				case 7: 
					_scale = value.RealVal;
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
        public bool Equals(@IfcMapConversion other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMapConversion
            var root = (@IfcMapConversion)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMapConversion left, @IfcMapConversion right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMapConversion left, @IfcMapConversion right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMapConversion x, @IfcMapConversion y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMapConversion obj)
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