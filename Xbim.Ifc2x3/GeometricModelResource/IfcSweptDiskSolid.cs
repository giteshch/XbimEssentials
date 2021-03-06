﻿#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcSweptDiskSolid.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.XbimExtensions;
using Xbim.XbimExtensions.Interfaces;

#endregion

namespace Xbim.Ifc2x3.GeometricModelResource
{
    /// <summary>
    ///   A swept disk solid is the solid produced by sweeping a circular disk along a three dimensional curve. 
    ///   During the sweeping operation the normal to the plane of the circular disk is in the direction of the tangent to the 
    ///   directrix curve and the center of the disk lies on the directrix. 
    ///   The circular disk may, optionally, have a central hole, in this case the resulting solid has a through hole, 
    ///   or, an internal void when the directrix forms a close curve.
    /// </summary>
    [IfcPersistedEntityAttribute]
    public class IfcSweptDiskSolid : IfcSolidModel
    {
        #region Fields

        private IfcCurve _directrix;
        private IfcPositiveLengthMeasure _radius;
        private IfcPositiveLengthMeasure? _innerRadius;
        private IfcParameterValue _startParam;
        private IfcParameterValue _endParam;

        #endregion

        #region Properties

        /// <summary>
        ///   The curve used to define the sweeping operation. The solid is generated by sweeping a circular disk along the directrix.
        /// </summary>
        [IfcAttribute(1, IfcAttributeState.Mandatory)]
        public IfcCurve Directrix
        {
            get
            {
                ((IPersistIfcEntity) this).Activate(false);
                return _directrix;
            }
            set { this.SetModelValue(this, ref _directrix, value, v => Directrix = v, "Directrix"); }
        }

        /// <summary>
        ///   The radius of the circular disk to be swept along the directrix.
        /// </summary>
        [IfcAttribute(2, IfcAttributeState.Mandatory)]
        public IfcPositiveLengthMeasure Radius
        {
            get
            {
                ((IPersistIfcEntity) this).Activate(false);
                return _radius;
            }
            set { this.SetModelValue(this, ref _radius, value, v => Radius = v, "Radius"); }
        }

        /// <summary>
        ///   This attribute is optional, if present it defines the radius of a circular hole in the centre of the disk.
        /// </summary>
        [IfcAttribute(3, IfcAttributeState.Optional)]
        public IfcPositiveLengthMeasure? InnerRadius
        {
            get
            {
                ((IPersistIfcEntity) this).Activate(false);
                return _innerRadius;
            }
            set { this.SetModelValue(this, ref _innerRadius, value, v => InnerRadius = v, "InnerRadius"); }
        }

        /// <summary>
        ///   The parameter value on the directrix at which the sweeping operation commences.
        /// </summary>
        [IfcAttribute(4, IfcAttributeState.Mandatory)]
        public IfcParameterValue StartParam
        {
            get
            {
                ((IPersistIfcEntity) this).Activate(false);
                return _startParam;
            }
            set { this.SetModelValue(this, ref _startParam, value, v => StartParam = v, "StartParam"); }
        }

        /// <summary>
        ///   The parameter value on the directrix at which the sweeping operation ends.
        /// </summary>
        [IfcAttribute(5, IfcAttributeState.Mandatory)]
        public IfcParameterValue EndParam
        {
            get
            {
                ((IPersistIfcEntity) this).Activate(false);
                return _endParam;
            }
            set { this.SetModelValue(this, ref _endParam, value, v => EndParam = v, "EndParam"); }
        }

        #endregion

        #region Part 21 Step file Parse routines

        public override void IfcParse(int propIndex, IPropertyValue value)
        {
            switch (propIndex)
            {
                case 0:
                    _directrix = (IfcCurve) value.EntityVal;
                    break;
                case 1:
                    _radius = value.RealVal;
                    break;
                case 2:
                    _innerRadius = value.RealVal;
                    break;
                case 3:
                    _startParam = new IfcParameterValue(value.RealVal);
                    break;
                case 4:
                    _endParam = new IfcParameterValue(value.RealVal);
                    break;

                default:
                    this.HandleUnexpectedAttribute(propIndex, value); break;
            }
        }

        #endregion

        public override string WhereRule()
        {
            string err = "";
            if (_directrix.Dim != 3)
                err += "WR1 SweptDiskSolid : The directrix shall be a curve in three dimensional space.\n";
            if (_innerRadius.HasValue && _radius <= _innerRadius.Value)
                err += "WR2 SweptDiskSolid : If inner_radius exists then radius shall be greater than inner_radius.\n";
            return err;
        }
    }
}
