using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoRPGSelfStudy
{
    public class Animation
    {
        private Texture2D spriteStrip;

        private float scale;

        private int elapsedTime;
        private int frameTime;
        private int frameCount;
        private int currentFrame;

        private Color color;

        private Rectangle sourceRect;
        private Rectangle destinationRect;

        public int FrameWidth;
        public int FrameHeight;

        public bool Active;
        public bool Looping;

        public Vector2 Position;

        public void Initialize(Texture2D texture, Vector2 position, int frameWidth, 
            int frameHeight, int frameCount, int frameTime, Color color, 
            float scale, bool looping)
        {
            sourceRect = new Rectangle();
            destinationRect = new Rectangle();

            this.color = color;
            this.FrameWidth = frameWidth;
            this.FrameHeight = frameHeight;
            this.frameCount = frameCount;
            this.frameTime = frameTime;
            this.scale = scale;

            Looping = looping;
            Position = position;
            spriteStrip = texture;

            elapsedTime = 0;
            currentFrame = 0;

            Active = true;
        }

        public void Update(GameTime gameTime)
        {
            if (Active == false)
            {
                return;
            }

            elapsedTime += (int)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (elapsedTime > frameTime)
            {
                currentFrame++;

                if (currentFrame == frameCount)
                {
                    currentFrame = 0;

                    if(Looping == false)
                    {
                        Active = false;
                    }
                }
                elapsedTime = 0;
            }

            sourceRect = new Rectangle(currentFrame * FrameWidth, 0, FrameWidth, FrameHeight);

            destinationRect = new Rectangle((int)Position.X - (int)(FrameWidth * scale) / 2,
                (int)Position.Y - (int)(FrameHeight * scale) / 2,
                (int)(FrameWidth * scale),
                (int)(FrameHeight * scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Active)
            {
                spriteBatch.Draw(spriteStrip, destinationRect, sourceRect, color);
            }
        }
    }
}
