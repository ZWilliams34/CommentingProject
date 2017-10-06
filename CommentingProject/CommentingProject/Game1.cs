﻿using Microsoft.Xna.Framework;
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
            oP = null;
        }

        protected override void Initialize() {
            this.IsMouseVisible = true;
            form = new Form1();
            form.Show();
            base.Initialize();
        }

        protected override void LoadContent() { spriteBatch = new SpriteBatch(GraphicsDevice); }

        protected override void UnloadContent() { }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
            if (form.getPressed() && oP == null)
            {
                oP = new LinkedList(form.getAuthor(), form.getValue());
                form.Hide();
            } else if (form.getPressed() && oP != null)
            {

            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        } 
    }
}