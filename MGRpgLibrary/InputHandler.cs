using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGRpgLibrary
{
    public enum MouseButton { Left, Middle, Right }

    public class InputHandler : Microsoft.Xna.Framework.GameComponent
    {
        #region Keyboard Field Region

        static KeyboardState keyboardState;
        static KeyboardState lastKeyboardState;

        #endregion

        #region Mouse Region

        static MouseState mouseState;
        static MouseState lastMouseState;

        #endregion

        #region Keyboard Property Region

        public static KeyboardState KeyboardState
        {
            get { return keyboardState; }
        }
        public static KeyboardState LastKeyboardState
        {
            get { return lastKeyboardState; }
        }
        #endregion

        #region Mouse Property Region

        public static MouseState MouseState
        {
            get { return mouseState; }
        }

        public static MouseState LastMouseState
        {
            get { return lastMouseState; }
        }

        #endregion

        #region Constructor Region

        public InputHandler(Game game) : base(game)
        {
            keyboardState = Keyboard.GetState();
            mouseState = Mouse.GetState();
        }

        #endregion

        #region MonoGame methods

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            lastKeyboardState = keyboardState;
            keyboardState = Keyboard.GetState();

            lastMouseState = mouseState;
            mouseState = Mouse.GetState();

            base.Update(gameTime);
        }

        #endregion

        #region General Method Region

        public static void Flush()
        {
            lastKeyboardState = keyboardState;
            lastMouseState = mouseState;
        }

        #endregion

        #region Keyboard Region

        public static bool KeyReleased(Keys key)
        {
            return keyboardState.IsKeyUp(key) &&
            lastKeyboardState.IsKeyDown(key);
        }

        public static bool KeyPressed(Keys key)
        {
            return keyboardState.IsKeyDown(key) &&
            lastKeyboardState.IsKeyUp(key);
        }

        public static bool KeyDown(Keys key)
        {
            return keyboardState.IsKeyDown(key);
        }

        #endregion

        #region Mouse Region

        public static Point MouseAsPoint
        {
            get { return new Point(mouseState.X, mouseState.Y); }
        }

        public static Vector2 MouseAsVector2
        {
            get { return new Vector2(mouseState.X, mouseState.Y); }
        }

        public static Point LastMouseAsPoint
        {
            get { return new Point(lastMouseState.X, lastMouseState.Y); }
        }

        public static Vector2 LastMouseAsVector2
        {
            get { return new Vector2(lastMouseState.X, lastMouseState.Y); }
        }

        public static bool CheckMousePress(MouseButton button)
        {
            bool result = false;
            switch (button)
            {
                case MouseButton.Left:
                    result = mouseState.LeftButton == ButtonState.Pressed &&
                    lastMouseState.LeftButton == ButtonState.Released;
                    break;
                case MouseButton.Right:
                    result = mouseState.RightButton == ButtonState.Pressed &&
                    lastMouseState.RightButton == ButtonState.Released;
                    break;
                case MouseButton.Middle:
                    result = mouseState.MiddleButton == ButtonState.Pressed &&
                    lastMouseState.MiddleButton == ButtonState.Released;
                    break;
            }
            return result;
        }
        public static bool CheckMouseReleased(MouseButton button)
        {
            bool result = false;
            switch (button)
            {
                case MouseButton.Left:
                    result = mouseState.LeftButton == ButtonState.Released &&
                    lastMouseState.LeftButton == ButtonState.Pressed;
                    break;
                case MouseButton.Right:
                    result = mouseState.RightButton == ButtonState.Released &&
                    lastMouseState.RightButton == ButtonState.Pressed;
                    break;
                case MouseButton.Middle:
                    result = mouseState.MiddleButton == ButtonState.Released &&
                    lastMouseState.MiddleButton == ButtonState.Pressed;
                    break;
            }
            return result;
        }

        public static bool IsMouseDown(MouseButton button)
        {
            bool result = false;
            switch (button)
            {
                case MouseButton.Left:
                    result = mouseState.LeftButton == ButtonState.Pressed;
                    break;

                case MouseButton.Right:
                    result = mouseState.RightButton == ButtonState.Pressed;
                    break;
                case MouseButton.Middle:
                    result = mouseState.MiddleButton == ButtonState.Pressed;
                    break;
            }
            return result;
        }

        public static bool IsMouseUp(MouseButton button)
        {
            bool result = false;
            switch (button)
            {
                case MouseButton.Left:
                    result = mouseState.LeftButton == ButtonState.Released;
                    break;
                case MouseButton.Right:
                    result = mouseState.RightButton == ButtonState.Released;
                    break;
                case MouseButton.Middle:
                    result = mouseState.MiddleButton == ButtonState.Released;
                    break;
            }
            return result;
        }

        #endregion
        
    }
}
