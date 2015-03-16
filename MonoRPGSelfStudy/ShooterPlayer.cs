using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoRPGSelfStudy
{
    class ShooterPlayer : Sprite
    {
        //player position
        public Vector2 Position;

        //player status
        public bool Active;

        //player HP
        public int Health;

        //player ship width
        public int Width
        {
            get
            {
                return this.spriteTexture.Width;
            }
        }

        //player ship height
        public int Height
        {
            get
            {
                return this.spriteTexture.Height;
            }
        }

        public ShooterPlayer(string path) : base(path)
        {

        }

        public void Initialize(Vector2 position)
        {
            Position = position;

            Active = true;

            Health = 100;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(spriteTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            base.Draw(gameTime, spriteBatch);
        }



    }
}
