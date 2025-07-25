﻿using System;
using System.Xml.Serialization;

namespace ScriptedInstanceModel.Events
{
    [Serializable]
    public class OnStop
    {
        #region Properties

        [XmlElement]
        public ChangePortalType[] ChangePortalType { get; set; }

        [XmlElement]
        public object RefreshMapItems { get; set; }

        [XmlElement]
        public SendMessage[] SendMessage { get; set; }

        [XmlElement]
        public SendPacket[] SendPacket { get; set; }

        #endregion Properties
    }
}