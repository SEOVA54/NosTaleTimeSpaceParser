﻿using System;
using System.Xml.Serialization;

namespace ScriptedInstanceModel.Events
{
    [Serializable]
    public class OnTimeout
    {
        [XmlElement]
        public End End { get; set; }

        [XmlElement]
        public ChangePortalType[] ChangePortalType { get; set; }

        [XmlElement]
        public object ClearMapMonsters { get; set; }

        [XmlElement]
        public object RefreshMapItems { get; set; }

        [XmlElement]
        public SendMessage[] SendMessage { get; set; }

        [XmlElement]
        public SendPacket[] SendPacket { get; set; }

        [XmlElement]
        public NpcDialog[] NpcDialog { get; set; }

        [XmlElement]
        public object StopMapWaves { get; set; }
    }
}