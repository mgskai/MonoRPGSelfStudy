using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoRPGSelfStudy
{
    public class Actor : Sprite
    {

        public Actor(string path) : base(path)
        {
        }

        public override void LoadContent()
        {
            base.LoadContent();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
            

        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(spriteTexture, Vector2.Zero, Color.White);
            base.Draw(gameTime, spriteBatch);
            
        }
    }
}
