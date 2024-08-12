﻿/* ================================================================
   ----------------------------------------------------------------
   Project   :   Aurora FPS Engine
   Publisher :   Renowned Games
   Developer :   Tamerlan Shakirov
   ----------------------------------------------------------------
   Copyright 2022 Renowned Games All rights reserved.
   ================================================================ */

namespace AuroraFPSRuntime.UIModules.IMGUI.Crosshair
{
    public interface ICrosshairPreset
    {
        /// <summary>
        /// Draw crosshair elements GUI layout taking into account hide state.
        /// </summary>
        /// <param name="spread"></param>
        void DrawElementsLayout(float spread);
    }
}