using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Wobble.Screens;

namespace Quaver.Screens.Splash
{
    public class SplashScreen : Screen
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public sealed override ScreenView View { get; protected set; }

        /// <summary>
        ///     The amount of time the screen has been active.
        /// </summary>
        public double TimeActive { get; private set; }

        /// <summary>
        /// </summary>
        public SplashScreen() => View = new SplashScreenView(this);

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            TimeActive += gameTime.ElapsedGameTime.TotalMilliseconds;
            base.Update(gameTime);
        }
    }
}