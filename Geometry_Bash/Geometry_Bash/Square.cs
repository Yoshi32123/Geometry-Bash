﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Geometry_Bash
{
    class Square : Player
    {
        
        public Square()
        {
            keyUp = Keyboard.GetState().IsKeyDown(Keys.W);
            keyDown = Keyboard.GetState().IsKeyDown(Keys.S);
            keyLeft = Keyboard.GetState().IsKeyDown(Keys.A);
            keyRight = Keyboard.GetState().IsKeyDown(Keys.D);

        }


    }
}