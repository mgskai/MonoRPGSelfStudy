using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoRPGSelfStudy
{
    public class SpriteManager
    {
        private static SpriteManager _Instance;
        public static SpriteManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SpriteManager();
                }
                return _Instance;
            }
        }

        public ContentManager SpriteManagerContent
        {
            get;
            private set;
        }

        public void LoadContent(ContentManager content)
        {
            this.SpriteManagerContent =
                new ContentManager(content.ServiceProvider, content.RootDirectory);
        }

        public void UnLoadContent()
        {

        }

    }
}
