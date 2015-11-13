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
using Xbim.Ifc4.MeasureResource;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcRelConnectsPathElements : IIfcRelConnectsPathElements
	{
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcInteger> IIfcRelConnectsPathElements.RelatingPriorities 
		{ 
			get
			{
			    //## Handle return of RelatingPriorities for which no match was found
			    return RelatingPriorities.Select(priority => (IfcInteger) priority);
			    //##
			}
		}
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcInteger> IIfcRelConnectsPathElements.RelatedPriorities 
		{ 
			get
			{
			    //## Handle return of RelatedPriorities for which no match was found
			    return RelatedPriorities.Select(priority => (IfcInteger) priority);
			    //##
			}
		}
		Ifc4.SharedBldgElements.IfcConnectionTypeEnum IIfcRelConnectsPathElements.RelatedConnectionType 
		{ 
			get
			{
				switch (RelatedConnectionType)
				{
					case IfcConnectionTypeEnum.ATPATH:
						return Ifc4.SharedBldgElements.IfcConnectionTypeEnum.ATPATH;
					
					case IfcConnectionTypeEnum.ATSTART:
						return Ifc4.SharedBldgElements.IfcConnectionTypeEnum.ATSTART;
					
					case IfcConnectionTypeEnum.ATEND:
						return Ifc4.SharedBldgElements.IfcConnectionTypeEnum.ATEND;
					
					case IfcConnectionTypeEnum.NOTDEFINED:
						return Ifc4.SharedBldgElements.IfcConnectionTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.SharedBldgElements.IfcConnectionTypeEnum IIfcRelConnectsPathElements.RelatingConnectionType 
		{ 
			get
			{
				switch (RelatingConnectionType)
				{
					case IfcConnectionTypeEnum.ATPATH:
						return Ifc4.SharedBldgElements.IfcConnectionTypeEnum.ATPATH;
					
					case IfcConnectionTypeEnum.ATSTART:
						return Ifc4.SharedBldgElements.IfcConnectionTypeEnum.ATSTART;
					
					case IfcConnectionTypeEnum.ATEND:
						return Ifc4.SharedBldgElements.IfcConnectionTypeEnum.ATEND;
					
					case IfcConnectionTypeEnum.NOTDEFINED:
						return Ifc4.SharedBldgElements.IfcConnectionTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}