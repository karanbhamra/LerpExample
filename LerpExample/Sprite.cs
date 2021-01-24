using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LerpExample
{
    public abstract class Sprite
    {
        protected Texture2D Texture { get; set; }
        protected Point Position { get; set; }

        protected Color Color { get; set; }

        protected Point Size { get; set; }

        public Rectangle Hitbox => new Rectangle(Position, Size);

        public Sprite(Texture2D texture, Point position, Color color, Point size)
        {
            Texture = texture;
            Position = position;
            Color = color;
            Size = size;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Hitbox, Color);
        }
    }
}