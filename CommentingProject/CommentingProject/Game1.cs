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

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            oP = new LinkedList("Despite the constant negative press covfefe");
        }

<<<<<<< HEAD
=======
        public void post(String author, String value) { if(postsOnPage < 5) { posts[postsOnPage] = new LinkedList(author, value); } }

>>>>>>> 154f7bffc333746d9de5075317e82f169ffa4cbd
        protected override void Initialize() {
            form = new Form1();
            form.Show();
            base.Initialize();
        }

        protected override void LoadContent() { spriteBatch = new SpriteBatch(GraphicsDevice); }

        protected override void UnloadContent() { }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        } 
    }
}