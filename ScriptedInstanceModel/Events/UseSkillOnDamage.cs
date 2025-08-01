﻿using System;
using System.Xml.Serialization;

namespace ScriptedInstanceModel.Events
{
    [Serializable]
    public class UseSkillOnDamage
    {
        #region Properties

        [XmlAttribute]
        public short SkillVNum { get; set; }

        [XmlAttribute]
        public byte HpPercent { get; set; }

        #endregion Properties
    }
}