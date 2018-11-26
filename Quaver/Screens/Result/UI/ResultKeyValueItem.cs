﻿using System;
using Microsoft.Xna.Framework;
using Quaver.Assets;
using Quaver.Graphics;
using Wobble.Graphics;
using Wobble.Graphics.Sprites;
using YamlDotNet.Core.Tokens;

namespace Quaver.Screens.Result.UI
{
    public class ResultKeyValueItem : Sprite
    {
        /// <summary>
        ///     The key or "Heading"
        /// </summary>
        public SpriteText TextKey { get; private set; }

        /// <summary>
        ///     The value this text represents
        /// </summary>
        public SpriteText TextValue { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public ResultKeyValueItem(string key, string value)
        {
            Alpha = 0;
            Tint = Color.CornflowerBlue;

            CreateTextKey(key);
            CreateTextValue(value);

            var width = Math.Max(TextKey.Width, TextValue.Width);
            var height = TextKey.Height + TextValue.Height + 5;

            Size = new ScalableVector2(width, height);
        }

        /// <summary>
        /// </summary>
        private void CreateTextKey(string key) => TextKey = new SpriteText(BitmapFonts.Exo2Medium, key, 13)
        {
            Parent = this,
            Alignment = Alignment.TopCenter,
            Tint = Colors.SecondaryAccent
        };

        private void CreateTextValue(string value) => TextValue = new SpriteText(BitmapFonts.Exo2Medium, value, 13)
        {
            Parent = this,
            Alignment = Alignment.TopCenter,
            Y = TextKey.Height + 5
        };
    }
}