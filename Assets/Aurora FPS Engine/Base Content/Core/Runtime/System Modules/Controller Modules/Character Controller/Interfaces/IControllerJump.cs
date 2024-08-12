/* ================================================================
   ----------------------------------------------------------------
   Project   :   Aurora FPS Engine
   Publisher :   Renowned Games
   Developer :   Tamerlan Shakirov
   ----------------------------------------------------------------
   Copyright 2022 Renowned Games All rights reserved.
   ================================================================ */

namespace AuroraFPSRuntime
{
    public interface IControllerJump
    {
        void MakeJump(float force);

        bool IsJumped();
    }
}