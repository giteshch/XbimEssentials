﻿#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcIrregularTimeSeries.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System;
using Xbim.XbimExtensions;
using Xbim.XbimExtensions.Interfaces;

#endregion

namespace Xbim.Ifc2x3.TimeSeriesResource
{
    [IfcPersistedEntityAttribute]
    public class IfcIrregularTimeSeries : IfcTimeSeries
    {
        public IfcIrregularTimeSeries()
        {
            _values = new XbimList<IfcIrregularTimeSeriesValue>(this);
        }

        #region Fields

        private XbimList<IfcIrregularTimeSeriesValue> _values;

        #endregion

        [IfcAttribute(9, IfcAttributeState.Mandatory, IfcAttributeType.List, IfcAttributeType.Class, 1)]
        private XbimList<IfcIrregularTimeSeriesValue> Values
        {
            get
            {
                ((IPersistIfcEntity) this).Activate(false);
                return _values;
            }
            set { this.SetModelValue(this, ref _values, value, v => Values = v, "Values"); }
        }

        public override void IfcParse(int propIndex, IPropertyValue value)
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
                case 7:
                    base.IfcParse(propIndex, value);
                    break;
                case 8:
                    _values.Add((IfcIrregularTimeSeriesValue) value.EntityVal);
                    break;
                default:
                    this.HandleUnexpectedAttribute(propIndex, value); break;
            }
        }
    }
}