// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFillAreaStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFillAreaStyle : IIfcPresentationStyle, IfcPresentationStyleSelect
	{
		IEnumerable<IIfcFillStyleSelect> @FillStyles { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IFCFILLAREASTYLE", 33)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFillAreaStyle : IfcPresentationStyle, IInstantiableEntity, IIfcFillAreaStyle, IEqualityComparer<@IfcFillAreaStyle>, IEquatable<@IfcFillAreaStyle>
	{
		#region IIfcFillAreaStyle explicit implementation
		IEnumerable<IIfcFillStyleSelect> IIfcFillAreaStyle.FillStyles { get { return @FillStyles; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyle(IModel model) : base(model) 		{ 
			Model = model; 
			_fillStyles = new ItemSet<IfcFillStyleSelect>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcFillStyleSelect> _fillStyles;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcFillStyleSelect> @FillStyles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _fillStyles;
				((IPersistEntity)this).Activate(false);
				return _fillStyles;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					if (_fillStyles == null) _fillStyles = new ItemSet<IfcFillStyleSelect>( this );
					_fillStyles.InternalAdd((IfcFillStyleSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:               )) <= 1;*/
		/*WR12:               )) <= 1;*/
		/*WR13:	WR13 : IfcCorrectFillAreaStyle(SELF.FillStyles);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFillAreaStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFillAreaStyle
            var root = (@IfcFillAreaStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFillAreaStyle left, @IfcFillAreaStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFillAreaStyle left, @IfcFillAreaStyle right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFillAreaStyle x, @IfcFillAreaStyle y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFillAreaStyle obj)
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