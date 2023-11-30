using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1;
using System;

namespace Monogame_Part_2_scaling_using_rectangles_and_text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private Microsoft.Xna.Framework.Graphics.SpriteBatch _spriteBatch;
        Texture2D circleTexture;
        Texture2D rectangleTexture;
        private SpriteFont titleFont;

        Rectangle earsO1Rect;
        Rectangle earsO2Rect;
        Rectangle earsI1Rect;
        Rectangle earsI2Rect;
        Rectangle headRect;
        Rectangle eyesO1Rect;
        Rectangle eyesO2Rect;
        Rectangle eyesI1Rect;
        Rectangle eyesI2Rect;
        Rectangle noseO1Rect;
        Rectangle noseO2Rect;
        Rectangle noseI1Rect;
        Rectangle noseI2Rect;
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            this.Window.Title = "Piggy face";
            // TODO: Add your initialization logic here
            earsO1Rect = new Rectangle(125, 30, 120, 120);
            earsO2Rect = new Rectangle(550, 30, 120, 120);
            earsI1Rect = new Rectangle(145, 50, 90, 90);
            earsI2Rect = new Rectangle(565, 50, 90, 90);
            headRect = new Rectangle(100, 50, 600, 400);
            eyesO1Rect = new Rectangle(460, 140, 120, 90);
            eyesO2Rect = new Rectangle(220, 140, 120, 90);
            eyesI1Rect = new Rectangle(245, 150, 70, 70);
            eyesI2Rect = new Rectangle(485, 150, 70, 70);
            noseO1Rect = new Rectangle(310, 210, 175, 125);
            noseO2Rect = new Rectangle(313, 212, 170, 120);
            noseI1Rect = new Rectangle(330, 235, 50, 70);
            noseI2Rect = new Rectangle(410, 235, 50, 70);
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new Microsoft.Xna.Framework.Graphics.SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            titleFont = Content.Load<SpriteFont>("Source");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Peru);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            //Red background
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 0, 1000, 10), Color.Red);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 20, 1000, 10), Color.Red);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 40, 1000, 10), Color.Red);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 60, 1000, 10), Color.Red);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 80, 1000, 10), Color.Red);
            //Green background
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 100, 1000, 10), Color.Green);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 120, 1000, 10), Color.Green);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 140, 1000, 10), Color.Green);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 160, 1000, 10), Color.Green);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 180, 1000, 10), Color.Green);
            //Indigo background
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 200, 1000, 10), Color.Indigo);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 220, 1000, 10), Color.Indigo);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 240, 1000, 10), Color.Indigo);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 260, 1000, 10), Color.Indigo);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 280, 1000, 10), Color.Indigo);
            //Yellow background
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 300, 1000, 10), Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 320, 1000, 10), Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 340, 1000, 10), Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 360, 1000, 10), Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 380, 1000, 10), Color.Yellow);
            //Brown background
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 400, 1000, 10), Color.Brown);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 420, 1000, 10), Color.Brown);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 440, 1000, 10), Color.Brown);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 460, 1000, 10), Color.Brown);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(0, 480, 1000, 10), Color.Brown);
            //Ears
            _spriteBatch.Draw(circleTexture, earsO1Rect, Color.Pink);
            _spriteBatch.Draw(circleTexture, earsO2Rect, Color.Pink);
            _spriteBatch.Draw(circleTexture, earsI1Rect, Color.HotPink);
            _spriteBatch.Draw(circleTexture, earsI2Rect, Color.HotPink);
            //Head
            _spriteBatch.Draw(circleTexture, headRect, Color.Pink);
            //Eyes
            _spriteBatch.Draw(circleTexture, eyesO1Rect, Color.White);
            _spriteBatch.Draw(circleTexture, eyesO2Rect, Color.White);
            _spriteBatch.Draw(circleTexture, eyesI1Rect, Color.Black);
            _spriteBatch.Draw(circleTexture, eyesI2Rect, Color.Black);
            //Nose
            _spriteBatch.Draw(circleTexture, noseO1Rect, Color.DeepPink);
            _spriteBatch.Draw(circleTexture, noseO2Rect, Color.Pink);
            _spriteBatch.Draw(circleTexture, noseI1Rect, Color.DeepPink);
            _spriteBatch.Draw(circleTexture, noseI2Rect, Color.DeepPink);
            //Text
            _spriteBatch.DrawString(titleFont, "Happy Birthday!", new Vector2(225, 320), Color.Cyan);
            Console.Beep(700, 200);
            Console.Beep(900, 200);
            Console.Beep(600, 500);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}