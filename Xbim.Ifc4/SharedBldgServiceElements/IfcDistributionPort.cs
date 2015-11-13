// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedBldgServiceElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDistributionPort
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDistributionPort : IIfcPort
	{
		IfcFlowDirectionEnum? @FlowDirection { get; }
		IfcDistributionPortTypeEnum? @PredefinedType { get; }
		IfcDistributionSystemEnum? @SystemType { get; }
	
	}
}

namespace Xbim.Ifc4.SharedBldgServiceElements
{
	[ExpressType("IFCDISTRIBUTIONPORT", 583)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDistributionPort : IfcPort, IInstantiableEntity, IIfcDistributionPort, IEqualityComparer<@IfcDistributionPort>, IEquatable<@IfcDistributionPort>
	{
		#region IIfcDistributionPort explicit implementation
		IfcFlowDirectionEnum? IIfcDistributionPort.FlowDirection { get { return @FlowDirection; } }	
		IfcDistributionPortTypeEnum? IIfcDistributionPort.PredefinedType { get { return @PredefinedType; } }	
		IfcDistributionSystemEnum? IIfcDistributionPort.SystemType { get { return @SystemType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDistributionPort(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcFlowDirectionEnum? _flowDirection;
		private IfcDistributionPortTypeEnum? _predefinedType;
		private IfcDistributionSystemEnum? _systemType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcFlowDirectionEnum? @FlowDirection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flowDirection;
				((IPersistEntity)this).Activate(false);
				return _flowDirection;
			} 
			set
			{
				SetValue( v =>  _flowDirection = v, _flowDirection, value,  "FlowDirection");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDistributionPortTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDistributionSystemEnum? @SystemType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _systemType;
				((IPersistEntity)this).Activate(false);
				return _systemType;
			} 
			set
			{
				SetValue( v =>  _systemType = v, _systemType, value,  "SystemType");
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
                    _flowDirection = (IfcFlowDirectionEnum) System.Enum.Parse(typeof (IfcFlowDirectionEnum), value.EnumVal, true);
					return;
				case 8: 
                    _predefinedType = (IfcDistributionPortTypeEnum) System.Enum.Parse(typeof (IfcDistributionPortTypeEnum), value.EnumVal, true);
					return;
				case 9: 
                    _systemType = (IfcDistributionSystemEnum) System.Enum.Parse(typeof (IfcDistributionSystemEnum), value.EnumVal, true);
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
        public bool Equals(@IfcDistributionPort other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDistributionPort
            var root = (@IfcDistributionPort)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDistributionPort left, @IfcDistributionPort right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDistributionPort left, @IfcDistributionPort right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDistributionPort x, @IfcDistributionPort y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDistributionPort obj)
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