﻿using System;
using System.Xml.Serialization;

namespace ScriptedInstanceModel.Events
{
    [Serializable]
    public class SetMonsterLockers
    {
        #region Properties

        [XmlAttribute]
        public byte Value { get; set; }

        #endregion Properties
    }
}