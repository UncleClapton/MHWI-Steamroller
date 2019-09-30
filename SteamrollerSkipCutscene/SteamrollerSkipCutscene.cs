﻿using System;
using PS4MacroAPI;

namespace SteamrollerSkipCutscene
{
    public class SteamrollerSkipCutscene : ScriptBase
    {
        /* Constructor */
        public SteamrollerSkipCutscene()
        {
            Config.Name = "Steamroller v1.0";
            Config.LoopDelay = 0;
        }

        // Called when the user pressed play
        public override void Start()
        {
            base.Start();
        }

        // Called every interval set by LoopDelay
        public override void Update()
        {
            Press(new DualShockState() { R2 = 255, Options = true });
            Press(new DualShockState() { R2 = 0 });
        }
    }
}
