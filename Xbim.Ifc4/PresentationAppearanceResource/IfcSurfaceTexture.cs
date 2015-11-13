// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceTexture
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceTexture : IIfcPresentationItem
	{
		IfcBoolean @RepeatS { get; }
		IfcBoolean @RepeatT { get; }
		IfcIdentifier? @Mode { get; }
		IIfcCartesianTransformationOperator2D @TextureTransform { get; }
		IEnumerable<IfcIdentifier> @Parameter { get; }
		IEnumerable<IIfcTextureCoordinate> @IsMappedBy {  get; }
		IEnumerable<IIfcSurfaceStyleWithTextures> @UsedInStyles {  get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCSURFACETEXTURE", 1073)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSurfaceTexture : IfcPresentationItem, IIfcSurfaceTexture, IEqualityComparer<@IfcSurfaceTexture>, IEquatable<@IfcSurfaceTexture>
	{
		#region IIfcSurfaceTexture explicit implementation
		IfcBoolean IIfcSurfaceTexture.RepeatS { get { return @RepeatS; } }	
		IfcBoolean IIfcSurfaceTexture.RepeatT { get { return @RepeatT; } }	
		IfcIdentifier? IIfcSurfaceTexture.Mode { get { return @Mode; } }	
		IIfcCartesianTransformationOperator2D IIfcSurfaceTexture.TextureTransform { get { return @TextureTransform; } }	
		IEnumerable<IfcIdentifier> IIfcSurfaceTexture.Parameter { get { return @Parameter; } }	
		 
		IEnumerable<IIfcTextureCoordinate> IIfcSurfaceTexture.IsMappedBy {  get { return @IsMappedBy; } }
		IEnumerable<IIfcSurfaceStyleWithTextures> IIfcSurfaceTexture.UsedInStyles {  get { return @UsedInStyles; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceTexture(IModel model) : base(model) 		{ 
			Model = model; 
			_parameter = new OptionalItemSet<IfcIdentifier>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcBoolean _repeatS;
		private IfcBoolean _repeatT;
		private IfcIdentifier? _mode;
		private IfcCartesianTransformationOperator2D _textureTransform;
		private OptionalItemSet<IfcIdentifier> _parameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcBoolean @RepeatS 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _repeatS;
				((IPersistEntity)this).Activate(false);
				return _repeatS;
			} 
			set
			{
				SetValue( v =>  _repeatS = v, _repeatS, value,  "RepeatS");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcBoolean @RepeatT 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _repeatT;
				((IPersistEntity)this).Activate(false);
				return _repeatT;
			} 
			set
			{
				SetValue( v =>  _repeatT = v, _repeatT, value,  "RepeatT");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Mode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mode;
				((IPersistEntity)this).Activate(false);
				return _mode;
			} 
			set
			{
				SetValue( v =>  _mode = v, _mode, value,  "Mode");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianTransformationOperator2D @TextureTransform 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textureTransform;
				((IPersistEntity)this).Activate(false);
				return _textureTransform;
			} 
			set
			{
				SetValue( v =>  _textureTransform = v, _textureTransform, value,  "TextureTransform");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcIdentifier> @Parameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parameter;
				((IPersistEntity)this).Activate(false);
				return _parameter;
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcTextureCoordinate> @IsMappedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTextureCoordinate>(e => e.Maps != null &&  e.Maps.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcSurfaceStyleWithTextures> @UsedInStyles 
		{ 
			get 
			{
				return Model.Instances.Where<IfcSurfaceStyleWithTextures>(e => e.Textures != null &&  e.Textures.Contains(this));
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_repeatS = value.BooleanVal;
					return;
				case 1: 
					_repeatT = value.BooleanVal;
					return;
				case 2: 
					_mode = value.StringVal;
					return;
				case 3: 
					_textureTransform = (IfcCartesianTransformationOperator2D)(value.EntityVal);
					return;
				case 4: 
					if (_parameter == null) _parameter = new OptionalItemSet<IfcIdentifier>( this );
					_parameter.InternalAdd(value.StringVal);
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
        public bool Equals(@IfcSurfaceTexture other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceTexture
            var root = (@IfcSurfaceTexture)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceTexture left, @IfcSurfaceTexture right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceTexture left, @IfcSurfaceTexture right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceTexture x, @IfcSurfaceTexture y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceTexture obj)
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