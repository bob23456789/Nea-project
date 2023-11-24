using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Nea_project
{
    public class Game1 : Game
    {
        Texture2D squareTexture;
        double gamestate = 1.5;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        List<tile> tiles = new List<tile>();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            
            int row = 0;
            int col = 0;    
            // TODO: Add your initialization logic here
            for (int i = -1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    row = i*55; col = j*55;
                    tile newtile = new tile(0, 0, 0, 0, row, col);// creates new tile object
                    tiles.Add(newtile);// adds it to list 
                }
            }
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            squareTexture = Content.Load<Texture2D>("grass");//loads grass 

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

           

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {


            if(gamestate == 1.5 )
            {
                int col = -55;
                int row = 0;
                GraphicsDevice.Clear(Color.CornflowerBlue);//sets abck gorund to vue
                _spriteBatch.Begin();// begins draws  in the srpites 
                for (int i = 0; i < 10; i++)//gennnerates grass tiles in grid
                {
                    col += 55;
                    row = 0;
                    for (int j = 0; j < 15; j++)
                    {

                        _spriteBatch.Draw(squareTexture, new Vector2(row, col), Color.White);
                        row += 55;

                    }

                }

                _spriteBatch.End();
            }
            


            base.Draw(gameTime);
        }
    }
}