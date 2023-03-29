using DoubleGameEngine.GameObjects;
using DoubleGameEngine.GameScreens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DoubleGameEngine
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        protected GraphicsDeviceManager _graphics;
        public SpriteBatch SpriteBatch;
        public ScreenManager ScreenManager { get; }
        public Dictionary<string, Keys> Input { get; private set; }

        public Game()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            ScreenManager = new ScreenManager();
            Components.Add(ScreenManager);
        }

        protected override void Initialize()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            try
            {
            Input = new Dictionary<string, Keys>();
            Dictionary<string, string> input = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText("Input.json"));
            foreach (var inputPair in input)
                Input.Add(inputPair.Key, Enum.Parse<Keys>(inputPair.Value));

            base.Initialize();
            }
            catch{}
            
        }


        protected override void Update(GameTime gameTime)
        {
            Managers.Keyboard.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            SpriteBatch.Begin();

            SpriteBatch.End();
                
            base.Draw(gameTime);
        }
    }
}