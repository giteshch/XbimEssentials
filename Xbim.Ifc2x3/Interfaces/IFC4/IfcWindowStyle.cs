// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcWindowStyle : IIfcWindowStyle
	{
		Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum IIfcWindowStyle.ConstructionType 
		{ 
			get
			{
				switch (ConstructionType)
				{
					case IfcWindowStyleConstructionEnum.ALUMINIUM:
						return Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum.ALUMINIUM;
					
					case IfcWindowStyleConstructionEnum.HIGH_GRADE_STEEL:
						return Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum.HIGH_GRADE_STEEL;
					
					case IfcWindowStyleConstructionEnum.STEEL:
						return Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum.STEEL;
					
					case IfcWindowStyleConstructionEnum.WOOD:
						return Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum.WOOD;
					
					case IfcWindowStyleConstructionEnum.ALUMINIUM_WOOD:
						return Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum.ALUMINIUM_WOOD;
					
					case IfcWindowStyleConstructionEnum.PLASTIC:
						return Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum.PLASTIC;
					
					case IfcWindowStyleConstructionEnum.OTHER_CONSTRUCTION:
						return Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum.OTHER_CONSTRUCTION;
					
					case IfcWindowStyleConstructionEnum.NOTDEFINED:
						return Ifc4.ArchitectureDomain.IfcWindowStyleConstructionEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum IIfcWindowStyle.OperationType 
		{ 
			get
			{
				switch (OperationType)
				{
					case IfcWindowStyleOperationEnum.SINGLE_PANEL:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.SINGLE_PANEL;
					
					case IfcWindowStyleOperationEnum.DOUBLE_PANEL_VERTICAL:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.DOUBLE_PANEL_VERTICAL;
					
					case IfcWindowStyleOperationEnum.DOUBLE_PANEL_HORIZONTAL:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.DOUBLE_PANEL_HORIZONTAL;
					
					case IfcWindowStyleOperationEnum.TRIPLE_PANEL_VERTICAL:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.TRIPLE_PANEL_VERTICAL;
					
					case IfcWindowStyleOperationEnum.TRIPLE_PANEL_BOTTOM:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.TRIPLE_PANEL_BOTTOM;
					
					case IfcWindowStyleOperationEnum.TRIPLE_PANEL_TOP:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.TRIPLE_PANEL_TOP;
					
					case IfcWindowStyleOperationEnum.TRIPLE_PANEL_LEFT:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.TRIPLE_PANEL_LEFT;
					
					case IfcWindowStyleOperationEnum.TRIPLE_PANEL_RIGHT:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.TRIPLE_PANEL_RIGHT;
					
					case IfcWindowStyleOperationEnum.TRIPLE_PANEL_HORIZONTAL:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.TRIPLE_PANEL_HORIZONTAL;
					
					case IfcWindowStyleOperationEnum.USERDEFINED:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.USERDEFINED;
					
					case IfcWindowStyleOperationEnum.NOTDEFINED:
						return Ifc4.ArchitectureDomain.IfcWindowStyleOperationEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcBoolean IIfcWindowStyle.ParameterTakesPrecedence 
		{ 
			get
			{
				//## Handle return of ParameterTakesPrecedence for which no match was found
				//TODO: Handle return of ParameterTakesPrecedence for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.MeasureResource.IfcBoolean IIfcWindowStyle.Sizeable 
		{ 
			get
			{
				//## Handle return of Sizeable for which no match was found
				//TODO: Handle return of Sizeable for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	//## Custom code
	//##
	}
}