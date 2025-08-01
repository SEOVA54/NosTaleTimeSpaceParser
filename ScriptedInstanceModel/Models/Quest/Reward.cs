﻿using ScriptedInstanceModel.Events.Quest;
using ScriptedInstanceModel.Objects;
using System;

namespace ScriptedInstanceModel.Models.Quest
{
    [Serializable]
    public class Reward
    {
        public byte ForceLevelUp { get; set; }

        public byte ForceJobUp { get; set; }

        public byte ForceHeroUp { get; set; }

        public short Buff { get; set; }

        public Item[] GiftItems { get; set; }

        public Item[] DrawOneItems { get; set; }

        public bool DisplayRewardWindow { get; set; }

        public TeleportTo TeleportPosition { get; set; }

        public long QuestId { get; set; }

        public Script Script { get; set; }
    }
}