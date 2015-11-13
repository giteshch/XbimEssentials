// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfileResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTrapeziumProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTrapeziumProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @BottomXDim { get; }
		IfcPositiveLengthMeasure @TopXDim { get; }
		IfcPositiveLengthMeasure @YDim { get; }
		IfcLengthMeasure @TopXOffset { get; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IFCTRAPEZIUMPROFILEDEF", 561)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTrapeziumProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcTrapeziumProfileDef, IEqualityComparer<@IfcTrapeziumProfileDef>, IEquatable<@IfcTrapeziumProfileDef>
	{
		#region IIfcTrapeziumProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.BottomXDim { get { return @BottomXDim; } }	
		IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.TopXDim { get { return @TopXDim; } }	
		IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.YDim { get { return @YDim; } }	
		IfcLengthMeasure IIfcTrapeziumProfileDef.TopXOffset { get { return @TopXOffset; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTrapeziumProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _bottomXDim;
		private IfcPositiveLengthMeasure _topXDim;
		private IfcPositiveLengthMeasure _yDim;
		private IfcLengthMeasure _topXOffset;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BottomXDim 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _bottomXDim;
				((IPersistEntity)this).Activate(false);
				return _bottomXDim;
			} 
			set
			{
				SetValue( v =>  _bottomXDim = v, _bottomXDim, value,  "BottomXDim");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @TopXDim 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _topXDim;
				((IPersistEntity)this).Activate(false);
				return _topXDim;
			} 
			set
			{
				SetValue( v =>  _topXDim = v, _topXDim, value,  "TopXDim");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @YDim 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _yDim;
				((IPersistEntity)this).Activate(false);
				return _yDim;
			} 
			set
			{
				SetValue( v =>  _yDim = v, _yDim, value,  "YDim");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @TopXOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _topXOffset;
				((IPersistEntity)this).Activate(false);
				return _topXOffset;
			} 
			set
			{
				SetValue( v =>  _topXOffset = v, _topXOffset, value,  "TopXOffset");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_bottomXDim = value.RealVal;
					return;
				case 4: 
					_topXDim = value.RealVal;
					return;
				case 5: 
					_yDim = value.RealVal;
					return;
				case 6: 
					_topXOffset = value.RealVal;
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
        public bool Equals(@IfcTrapeziumProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTrapeziumProfileDef
            var root = (@IfcTrapeziumProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTrapeziumProfileDef left, @IfcTrapeziumProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTrapeziumProfileDef left, @IfcTrapeziumProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTrapeziumProfileDef x, @IfcTrapeziumProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTrapeziumProfileDef obj)
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