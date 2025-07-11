// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Graphics.Sprites;
using osu.Game.Beatmaps;
using osu.Game.Graphics;

namespace osu.Game.Rulesets.Mods
{
    public abstract class ModEasy : Mod, IApplicableToDifficulty
    {
        public override string Name => "Easy";
        public override string Acronym => "EZ";
        public override IconUsage? Icon => OsuIcon.ModEasy;
        public override ModType Type => ModType.DifficultyReduction;
        public override double ScoreMultiplier => 0.5;
        public override Type[] IncompatibleMods => new[] { typeof(ModHardRock), typeof(ModDifficultyAdjust) };
        public override bool Ranked => UsesDefaultConfiguration;
        public override bool ValidForFreestyleAsRequiredMod => true;

        protected const float ADJUST_RATIO = 0.5f;

        public virtual void ApplyToDifficulty(BeatmapDifficulty difficulty)
        {
            difficulty.CircleSize *= ADJUST_RATIO;
            difficulty.ApproachRate *= ADJUST_RATIO;
            difficulty.DrainRate *= ADJUST_RATIO;
        }
    }
}
