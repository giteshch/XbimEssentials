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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcTextStyle : IIfcTextStyle
	{
		IIfcTextStyleForDefinedFont IIfcTextStyle.TextCharacterAppearance 
		{ 
			get
			{
				//## Handle return of TextCharacterAppearance for which no match was found
                if (TextCharacterAppearance is IfcTextStyleForDefinedFont)
                    return (IIfcTextStyleForDefinedFont)TextCharacterAppearance;
                else
                    return null;
				//##
			} 
		}
		IIfcTextStyleTextModel IIfcTextStyle.TextStyle 
		{ 
			get
			{
				//## Handle return of TextStyle for which no match was found
                if (this.TextStyle is Xbim.Ifc2x3.PresentationAppearanceResource.IfcTextStyleTextModel)
                    return (IIfcTextStyleTextModel)TextCharacterAppearance;
                else
                    return null;
				//##
			} 
		}
		IIfcTextFontSelect IIfcTextStyle.TextFontStyle 
		{ 
			get
			{
				if (TextFontStyle == null) return null;
				var ifcpredefinedtextfont = TextFontStyle as PresentationResource.IfcPreDefinedTextFont;
				if (ifcpredefinedtextfont != null) 
					return ifcpredefinedtextfont;
				var ifcexternallydefinedtextfont = TextFontStyle as PresentationResource.IfcExternallyDefinedTextFont;
				if (ifcexternallydefinedtextfont != null) 
					return ifcexternallydefinedtextfont;
				return null;
			} 
		}
		Ifc4.MeasureResource.IfcBoolean? IIfcTextStyle.ModelOrDraughting 
		{ 
			get
			{
				//## Handle return of ModelOrDraughting for which no match was found
                return null;
				//##
			} 
		}
	//## Custom code
	//##
	}
}