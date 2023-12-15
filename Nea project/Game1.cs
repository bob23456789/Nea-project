using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Nea_project
{
    public class Game1 : Game
    {
        Texture2D squareTexture;
        Texture2D menuTexture;
        private Texture2D buttonTexture;
        private Rectangle buttonRectangle; // square which teh tecture will be put in 
        double gamestate = 1.5;
        string menuTitle = "War On Perliculum\n             Prime";
        string Line = "";
        char[] stringtochar = new char[16];
        //int[,,] tilemap = new int[16, 11, 160]; // x,y,type tilemap  
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont myfontyfont; 
        List<tile> tiles = new List<tile>();
         //veotr middle point make object thignhere wiht artibute
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            if (gamestate == 1.5)//if game state i playing game state
            {

                int row = 0;
                int col = 0;
                int rcount = 0;// counts the rows for the stream reading 
                StreamReader reader = new StreamReader("tilemap.txt");// reads from basic map text file 
                string readrowe = "";
                char[,] tilemaptype = new char[16, 11];
                while (reader != null)
                {
                    for (int e = 0; e < 11; e++)
                    {

                        readrowe = reader.ReadLine();//reads text file int
                        stringtochar = readrowe.ToCharArray(); // converts read row into char array
                        for (int i = 0; i < stringtochar.Length; i++)
                        {
                            tilemaptype[0, rcount] = stringtochar[i];// put chararray into  tilemap typea array 
                        }
                        rcount++;// counts whic row the read is on 
                    }
                }
                // TODO: Add your initialization logic here
                rcount = 0;
                for (int i = -1; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        row = i * 55; col = j * 55;
                        tile newtile = new tile(tilemaptype[rcount,i], 0, 0, 0, row, col);// creates new tile object
                        tiles.Add(newtile);// adds it to list 
                        rcount++;
                    }
                }
                reader.Close();
            }
            base.Initialize();
     
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            if(gamestate == 1.5)
            {
                squareTexture = Content.Load<Texture2D>("grass");//loads grass 
            }
            if(gamestate == 1)
            {
                squareTexture = Content.Load<Texture2D>("menuscreen");
                myfontyfont = Content.Load<SpriteFont>("File");
                buttonTexture = Content.Load<Texture2D>("playbutton");
                // Set the initial position and size of the button
                Vector2 position = new Vector2(Window.ClientBounds.Width / 2 - 100, Window.ClientBounds.Height / 2 +20);

                buttonRectangle = new Rectangle((int)position.X,(int)position.Y, buttonTexture.Width, buttonTexture.Height);
            }


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // Get the current state of the mouse
            MouseState mouseState = Mouse.GetState();

            // Check if the left mouse button is pressed and the mouse is over the button
            if (mouseState.LeftButton == ButtonState.Pressed && buttonRectangle.Contains(mouseState.Position))
            {
                gamestate = 1.5;
            }

            base.Update(gameTime);



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);//creats bit where grpahics goes
            int col = -55;
            int row = 0;
            if (gamestate == 1)// menu screen  // y = 550 x = 825 area = 453750 pixles 
            {
                _spriteBatch.Begin();
                _spriteBatch.Draw(squareTexture, new Vector2(row, col), Color.White);
                Vector2 textMiddlePoint = myfontyfont.MeasureString(menuTitle) / 2;
                // Places text in center of the screen
                Vector2 position = new Vector2(Window.ClientBounds.Width / 2,Window.ClientBounds.Height / 2 - 50);
               _spriteBatch.DrawString(myfontyfont,menuTitle, position, Color.AntiqueWhite, 0, textMiddlePoint, 1.5f, SpriteEffects.None, 1.0f);
                _spriteBatch.Draw(buttonTexture, buttonRectangle, Color.White);
                _spriteBatch.End();
            }

            if(gamestate == 1.5 )
            {
               
                
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