using System;
using PS4MacroAPI;

namespace Steamroller
{
    public class Steamroller : ScriptBase
    {
        /* Constructor */
        public Steamroller()
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
            Press(new DualShockState() { R2 = 255 });
            Press(new DualShockState() { R2 = 0 });
        }
    }
}
