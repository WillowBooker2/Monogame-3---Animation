using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_3___Animation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D tribbleGreyTexture, tribbleBrownTexture, tribbleCreamTexture, tribbleOrangeTexture;
        Rectangle tribbleGreyRect, tribbleBrownRect, tribbleCreamRect, tribbleOrangeRect;
        Vector2 tribbleGreySpeed, tribbleBrownSpeed, tribbleCreamSpeed, tribbleOrangeSpeed;
        Color backGroundColor = Color.White;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 1000;
            _graphics.PreferredBackBufferHeight = 700;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            tribbleGreyRect = new Rectangle(300, 10, 100, 100);
            tribbleGreySpeed = new Vector2(6, 3);
            tribbleBrownRect = new Rectangle(200, 100, 100, 100);
            tribbleBrownSpeed = new Vector2(4, 4);
            tribbleCreamRect = new Rectangle(650, 500, 100, 100);
            tribbleCreamSpeed = new Vector2(4, 8);
            tribbleOrangeRect = new Rectangle(230, 400, 100, 100);
            tribbleOrangeSpeed = new Vector2(3, 5);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            tribbleGreyRect.X += (int)tribbleGreySpeed.X;
            tribbleGreyRect.Y += (int)tribbleGreySpeed.Y;
            tribbleCreamRect.X += (int)tribbleCreamSpeed.X;
            tribbleCreamRect.Y += (int)tribbleCreamSpeed.Y;
            tribbleBrownRect.X += (int)tribbleBrownSpeed.X;
            tribbleBrownRect.Y += (int)tribbleBrownSpeed.Y;
            tribbleOrangeRect.X += (int)tribbleOrangeSpeed.X;
            tribbleOrangeRect.Y += (int)tribbleOrangeSpeed.Y;

            if (tribbleGreyRect.Right > _graphics.PreferredBackBufferWidth || tribbleGreyRect.Left < 0)
            {
                tribbleGreySpeed.X *= -1;
                backGroundColor = Color.Gray;
            }
            if (tribbleGreyRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleGreyRect.Top < 0)
            {
                tribbleGreySpeed.Y *= -1;
                backGroundColor = Color.Gray;
            }


            if (tribbleBrownRect.Right > _graphics.PreferredBackBufferWidth || tribbleBrownRect.Left < 0)
            {
                tribbleBrownSpeed.X *= -1;
                backGroundColor = Color.Brown;
            }
            if (tribbleBrownRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleBrownRect.Top < 0)
            {
                tribbleBrownSpeed.Y *= -1;
                backGroundColor = Color.Brown;
            }


            if (tribbleCreamRect.Right > _graphics.PreferredBackBufferWidth || tribbleCreamRect.Left < 0)
            {
                tribbleCreamSpeed.X *= -1;
                backGroundColor = Color.PeachPuff;
            }
            if (tribbleCreamRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleCreamRect.Top < 0)
            {
                tribbleCreamSpeed.Y *= -1;
                backGroundColor = Color.PeachPuff;
            }
            


                if (tribbleOrangeRect.Right > _graphics.PreferredBackBufferWidth || tribbleOrangeRect.Left < 0)
            {
                tribbleOrangeSpeed.X *= -1;
                backGroundColor = Color.Orange;
            }
            if (tribbleOrangeRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleOrangeRect.Top < 0)
            {
                tribbleOrangeSpeed.Y *= -1;
                backGroundColor = Color.Orange;
            }


            // TODO: Add your update logic here

            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            GraphicsDevice.Clear(backGroundColor);
            _spriteBatch.Begin();
            _spriteBatch.Draw(tribbleBrownTexture, tribbleBrownRect, Color.White);
            _spriteBatch.Draw(tribbleGreyTexture,tribbleGreyRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, tribbleCreamRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture, tribbleOrangeRect, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}