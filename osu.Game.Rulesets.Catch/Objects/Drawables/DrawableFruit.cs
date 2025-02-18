﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using JetBrains.Annotations;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Rulesets.Catch.Skinning.Default;
using osu.Game.Skinning;

namespace osu.Game.Rulesets.Catch.Objects.Drawables
{
    public class DrawableFruit : DrawablePalpableCatchHitObject
    {
        public DrawableFruit()
            : this(null)
        {
        }

        public DrawableFruit([CanBeNull] Fruit h)
            : base(h)
        {
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            ScalingContainer.Child = new SkinnableDrawable(
                new CatchSkinComponent(CatchSkinComponents.Fruit),
                _ => new FruitPiece());
        }

        protected override void UpdateInitialTransforms()
        {
            base.UpdateInitialTransforms();

            ScalingContainer.RotateTo((RandomSingle(1) - 0.5f) * 40);
        }
    }
}
