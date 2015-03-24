using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoRPGSelfStudy
{
    public class Sprite
    {
        public string SpriteAssetPath
        {
            get;
            set;
        }
        
        protected Texture2D spriteTexture;
        protected Animation spriteAnimation;
        protected ContentManager spriteContent;
        
        public Sprite(string path)
        {
            SpriteAssetPath = path;
        }

        public virtual void LoadContent()
        {
            this.spriteContent = new ContentManager(
                SpriteManager.Instance.SpriteManagerContent.ServiceProvider, 
                SpriteManager.Instance.SpriteManagerContent.RootDirectory);
            spriteAnimation = new Animation();
            spriteTexture = spriteContent.Load<Texture2D>(SpriteAssetPath);
        }

        public virtual void UnloadContent()
        {
            this.spriteContent.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
        }
    }
}
