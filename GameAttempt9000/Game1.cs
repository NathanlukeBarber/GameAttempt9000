using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//use swtich case for the number 
//number will have what room im 
//depending what room in load correct twxt before drawing
namespace GameAttempt9000
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D background;
        Texture2D textbox1;
        int mapid = 1;
        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            if (mapid == 1) 
            textbox1 = Content.Load<Texture2D>("textbox1.png");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // if at image 1, you can press L or R
           
            if (mapid == 1)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.L))
                {
                    mapid = 2;
                }
                else if (Keyboard.GetState().IsKeyDown(Keys.R))
                {
                    mapid = 3;
                }
            }

             if (mapid == 2)
               {
                    textbox1 = Content.Load<Texture2D>("textbox2.png");

                    if (Keyboard.GetState().IsKeyDown(Keys.F))
                    {
                        mapid = 5;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.R))
                    {
                        mapid = 3;
                    }
                }

            //gap

                if (mapid == 3)
                {
                    textbox1 = Content.Load<Texture2D>("textbox3.png");

                    if (Keyboard.GetState().IsKeyDown(Keys.R))
                    {
                        mapid = 4;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.F))
                    {
                        mapid = 5;
                    }
                }

                if (mapid == 4)
                {
                    textbox1 = Content.Load<Texture2D>("textbox4.png");

                    if (Keyboard.GetState().IsKeyDown(Keys.R))
                    {
                        mapid = 6;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.F))
                    {
                        mapid = 7;
                    }
                }

                if (mapid == 5)
                {
                    textbox1 = Content.Load<Texture2D>("textbox5.png");

                    if (Keyboard.GetState().IsKeyDown(Keys.F))
                    {
                        mapid = 7;
                    }
                    else if (Keyboard.GetState().IsKeyDown(Keys.R))
                    {
                        mapid = 4;
                    }
                }

               /* if (mapid == 6)//win
                {
                    textbox1 = Content.Load<Texture2D>("272132-header.jpg");

                    
                }
                if (mapid == 7)
                {
                    textbox1 = Content.Load<Texture2D>("BlackBG.png");

                   
                }*/
                    // TODO: Add your update logic here

                    base.Update(gameTime);
            }

        
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(textbox1, new Rectangle(0, 0, 800, 500), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
