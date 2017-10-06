using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;

namespace CommentingProject {
    public class Game1 : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Form1 form;
        LinkedList oP;
        Rectangle postWindowSize, deleteButtonSize, respondButtonSize;
        SpriteFont authorWriting;
        Texture2D texture;

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            oP = null;
        }

        protected override void Initialize() {
            this.IsMouseVisible = true;
            form = new Form1();
            form.Show();
            graphics.PreferredBackBufferWidth = 1900;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 1000;   // set this value to the desired height of your window
            graphics.ApplyChanges();
            postWindowSize = new Rectangle(100, 100, 400, 400);
            deleteButtonSize = new Rectangle(180, 385, 80, 57);
            respondButtonSize = new Rectangle(340, 385, 80, 57);
            base.Initialize();
        }

        protected override void LoadContent() {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            authorWriting = Content.Load<SpriteFont>("Author");
            texture = Content.Load<Texture2D>("why");
        }

        protected override void UnloadContent() { }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
            if (form.getPressed() && oP == null) {
                oP = new LinkedList(form.getAuthor(), form.getValue());
                form.Hide();
            } else if (form.getPressed() && oP != null) {

            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            if(oP != null) {
                spriteBatch.Draw(texture, postWindowSize, Color.White);
                spriteBatch.Draw(texture, deleteButtonSize, Color.White);
                spriteBatch.Draw(texture, respondButtonSize, Color.White);
                spriteBatch.DrawString(authorWriting, "Author: " + form.getAuthor(), new Vector2(180, 157), Color.Black);
                spriteBatch.DrawString(authorWriting, "Post: " + form.getValue(), new Vector2(180, 271), Color.Black);
                spriteBatch.DrawString(authorWriting, "Delete", new Vector2(280, 257), Color.Black);
                spriteBatch.DrawString(authorWriting, "Respond", new Vector2(280, 371), Color.Black);
            }
            
            spriteBatch.End();
            base.Draw(gameTime);
        } 
    }
}