﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Bash
{
    class Projectile
    {
        //fields

        //float to hold the speed of the object
        private int speed;

        //float to hold the distance the projectile travels
        private float distance;

        //int to hold the damage of the projectile
        private int damage;

        //timer variable
        private GameTime timer;

        //rectangle for the hit box of the projectile
        private Rectangle hitBox;

        //variable to keep track of elapsed time
        private float currentTime = 0f;

        //int to keep track of what direction it travels in, 0 is up, 1 is right, 2 is down, 3 is left
        private int direction;
        

        //int to keep track of distance traveled
        private int traveled;

        //bool to keep track if the projectile is still active
        private bool active;


        //properties with get fucntions for some fields
        public int Speed
        {
            get { return speed; }
        }

        
        public Rectangle HitBox
        {
            get { return hitBox;}
            set { hitBox = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public int Direction
        {
            get { return direction; }
        }







        public Projectile(int speed, int direction)
        {
            this.speed = speed;

            this.direction = direction;
            active = true;
            
            traveled = 0;

            timer = new GameTime();
        }

        public void Move()
        {
            Rectangle temp = hitBox;
            //currentTime += (float)timer.ElapsedGameTime.TotalSeconds; //Time passed since last Update()
            //if(currentTime > distance/speed)
            {
                //currentTime -= distance/speed;
                
                
                if (direction == 0)
                {
                    temp.Y -= speed;
                    traveled++;
                }
                else if (direction == 1)
                {
                    temp.X += speed;
                    traveled++;
                }
                else if (direction == 2)
                {
                    temp.Y += speed;
                    traveled++;
                }
                else if (direction == 3)
                {
                    temp.X -= speed;
                    traveled++;
                }

               hitBox = temp;

                   
            }
        }
    }
}
