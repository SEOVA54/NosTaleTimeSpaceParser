﻿using System;
using System.Xml.Serialization;

namespace ScriptedInstanceModel.Events.Quest
{
    [Serializable]
    public class TeleportTo
    {
        #region Properties

        [XmlAttribute]
        public bool AskTeleport { get; set; }

        [XmlAttribute]
        public short MapId { get; set; }

        [XmlAttribute]
        public short MapX { get; set; }

        [XmlAttribute]
        public short MapY { get; set; }

        #endregion Properties
    }
}