using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LerpExample
{
    public class Box : Sprite
    {
        private Point _endPoint;
        private MouseState _previousMouseState;

        public Box(Texture2D texture, Point position, Color color, Point size) : base(texture, position, color, size)
        {
        }

        public void Update(GameTime gameTime, MouseState mouseState)
        {
            if (IsLeftMouseClicked(mouseState))
            {
                _endPoint = mouseState.Position;
            }

            Vector2 currentPos = Position.ToVector2();
            Vector2 endPoint = _endPoint.ToVector2();
            currentPos = Vector2.Lerp(currentPos, endPoint, 0.1f);

            Position = currentPos.ToPoint();
            _endPoint = endPoint.ToPoint();
            
            _previousMouseState = mouseState;
        }

        private bool IsLeftMouseClicked(MouseState mouseState)
        {
            return (mouseState != _previousMouseState && mouseState.LeftButton == ButtonState.Pressed);
        }
    }
}