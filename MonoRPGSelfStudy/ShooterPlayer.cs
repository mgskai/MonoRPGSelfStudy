using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoRPGSelfStudy
{
    public class ShooterPlayer : Sprite
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
                //return this.spriteTexture.Width;
                return spriteAnimation.FrameWidth;
            }
        }

        //player ship height
        public int Height
        {
            get
            {
                //return this.spriteTexture.Height;
                return spriteAnimation.FrameHeight;
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

            spriteAnimation.Initialize(spriteTexture, Vector2.Zero, 115, 69, 8, 30, 
                Color.White, 1f, true);
        }

        public override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            spriteAnimation.Position = Position;
            spriteAnimation.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(spriteTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            spriteAnimation.Draw(spriteBatch);
            base.Draw(gameTime, spriteBatch);
        }



    }
}
