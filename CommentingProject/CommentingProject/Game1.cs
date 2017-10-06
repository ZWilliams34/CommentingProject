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
        int comments, replies;

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            oP = null;
        }

        protected override void Initialize() {
            this.IsMouseVisible = true;
            form = new Form1();
            form.Show();
            graphics.PreferredBackBufferWidth = 1900;  
            graphics.PreferredBackBufferHeight = 1000;  
            graphics.ApplyChanges();
            postWindowSize = new Rectangle(0, 0, 380, 200);
            deleteButtonSize = new Rectangle(86, 140, 76, 28);
            respondButtonSize = new Rectangle(238, 140, 76, 28);
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
<<<<<<< HEAD
            if(oP != null) {
                spriteBatch.Draw(texture, postWindowSize, Color.White);
                spriteBatch.Draw(texture, deleteButtonSize, Color.White);
                spriteBatch.Draw(texture, respondButtonSize, Color.White);
                spriteBatch.DrawString(authorWriting, "Author: " + form.getAuthor(), new Vector2(180, 157), Color.Black);
                spriteBatch.DrawString(authorWriting, "Post: " + form.getValue(), new Vector2(180, 271), Color.Black);
                spriteBatch.DrawString(authorWriting, "Delete", new Vector2(280, 257), Color.Black);
                spriteBatch.DrawString(authorWriting, "Respond", new Vector2(280, 371), Color.Black);
=======
            spriteBatch.Draw(texture, postWindowSize, Color.White);
            spriteBatch.Draw(texture, deleteButtonSize, Color.White);
            spriteBatch.Draw(texture, respondButtonSize, Color.White);
            spriteBatch.DrawString(authorWriting, "Author: " + form.getAuthor(), new Vector2(86, 28), Color.Black);
            spriteBatch.DrawString(authorWriting, "Post: " + form.getValue(), new Vector2(86, 84), Color.Black);
            if (oP != null) {
                spriteBatch.DrawString(authorWriting, "Delete", new Vector2(86, 140), Color.Black);
                spriteBatch.DrawString(authorWriting, "Respond", new Vector2(238, 140), Color.Black);
            } else {
                spriteBatch.DrawString(authorWriting, "Post", new Vector2(86, 140), Color.Black);
                spriteBatch.DrawString(authorWriting, "Exit", new Vector2(238, 140), Color.Black);
>>>>>>> 227c6a59ae28e96fd9272a22bee8a399c5f9a238
            }
            spriteBatch.End();
            base.Draw(gameTime);
        } 
    }
}