using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Part_2_scaling_using_rectangles_and_text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circleTexture;
        Texture2D rectangleTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
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
            _spriteBatch.Draw(circleTexture, new Rectangle(125, 30, 120, 120), Color.Pink);
            _spriteBatch.Draw(circleTexture, new Rectangle(550, 30, 120, 120), Color.Pink);
            _spriteBatch.Draw(circleTexture, new Rectangle(145, 50, 90, 90), Color.HotPink);
            _spriteBatch.Draw(circleTexture, new Rectangle(565, 50, 90, 90), Color.HotPink);
            _spriteBatch.Draw(circleTexture, new Rectangle(100, 50, 600, 400), Color.Pink);
            _spriteBatch.Draw(circleTexture, new Rectangle(460, 140, 125, 75), Color.White);
            _spriteBatch.Draw(circleTexture, new Rectangle(220, 140, 125, 75), Color.White);
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}