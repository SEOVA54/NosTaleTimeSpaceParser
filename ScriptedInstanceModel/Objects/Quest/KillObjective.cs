﻿using System;

namespace ScriptedInstanceModel.Objects.Quest
{
    [Serializable]
    public class KillObjective
    {
        #region Properties

        public int CurrentAmount { get; set; }

        public int GoalAmount { get; set; }

        public short MonsterVNum { get; set; }

        #endregion Properties
    }
}