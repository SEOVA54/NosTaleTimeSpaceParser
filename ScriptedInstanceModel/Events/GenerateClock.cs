﻿using System;
using System.Xml.Serialization;

namespace ScriptedInstanceModel.Events
{
    [Serializable]
    public class GenerateClock
    {
        #region Properties

        [XmlAttribute]
        public int Value { get; set; }

        #endregion Properties
    }
}