﻿using System;
using System.Xml.Serialization;

namespace ScriptedInstanceModel.Events
{
    [Serializable]
    public class End
    {
        #region Properties

        [XmlAttribute]
        public byte Type { get; set; }

        #endregion Properties
    }
}