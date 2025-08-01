﻿using System;
using System.Xml.Serialization;

namespace ScriptedInstanceModel.Events
{
    [Serializable]
    public class SummonMonsters
    {
        #region Properties

        [XmlAttribute]
        public short Amount { get; set; }

        [XmlAttribute]
        public bool IsBonus { get; set; }

        [XmlAttribute]
        public bool IsBoss { get; set; }

        [XmlAttribute]
        public bool IsHostile { get; set; }

        [XmlAttribute]
        public bool Move { get; set; }

        [XmlAttribute]
        public short VNum { get; set; }

        #endregion Properties
    }
}