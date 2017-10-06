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
        LinkedList discussion;
        Rectangle postWindowSize, deleteButtonSize, respondButtonSize;
        SpriteFont authorWriting;
        Texture2D texture;
        int comments, replies;

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            discussion = null;
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
            if (form.getPressed() && discussion == null) {
                discussion = new LinkedList(form.getAuthor(), form.getValue());
                form.Hide();
            } else if (form.getPressed()) {
                form.Hide();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            /*spriteBatch.Draw(texture, new Rectangle(0, 0, 380, 200), Color.White);

            spriteBatch.Draw(texture, new Rectangle(0, 0, 380, 200), Color.White);
            spriteBatch.Draw(texture, new Rectangle(86, 140, 76, 28), Color.White);
            spriteBatch.Draw(texture, new Rectangle(238, 140, 76, 28), Color.White);
            spriteBatch.DrawString(authorWriting, "Author: " + form.getAuthor(), new Vector2(86, 28), Color.Black);
            spriteBatch.DrawString(authorWriting, "Post: " + form.getValue(), new Vector2(86, 84), Color.Black);
            if (discussion != null) {
                spriteBatch.DrawString(authorWriting, "Delete", new Vector2(86, 140), Color.Black);
                spriteBatch.DrawString(authorWriting, "Respond", new Vector2(238, 140), Color.Black);
            } else {
                spriteBatch.DrawString(authorWriting, "Post", new Vector2(86, 140), Color.Black);
                spriteBatch.DrawString(authorWriting, "Exit", new Vector2(238, 140), Color.Black);
            }
            for(int i = 0; i <= comments; i++) {
                spriteBatch.Draw(texture, new Rectangle(0, 0 + (comments * 200), 380, 200), Color.White);
                spriteBatch.Draw(texture, new Rectangle(86, 140 + (comments * 200), 76, 28), Color.White);
                spriteBatch.Draw(texture, new Rectangle(238, 140 + (comments * 200), 76, 28), Color.White);
                spriteBatch.DrawString(authorWriting, "Author: " + form.getAuthor(), new Vector2(86, 28 + (comments * 200)), Color.Black);
                spriteBatch.DrawString(authorWriting, "Post: " + form.getValue(), new Vector2(86, 84 + (comments * 200)), Color.Black);
                spriteBatch.DrawString(authorWriting, "Delete", new Vector2(86, 140 + (comments * 200)), Color.Black);
                spriteBatch.DrawString(authorWriting, "Respond", new Vector2(238, 140 + (comments * 200)), Color.Black);
            }*/
            spriteBatch.End();
            base.Draw(gameTime);
        } 
    }
}