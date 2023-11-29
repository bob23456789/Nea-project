
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Input;

namespace Nea_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using var game = new Nea_project.Game1();
            game.Run();
        }
    }

   class tank
   {
        private int _x; // cords
        public int x { get { return _x; } }
        private int _y;// y postion 
        public int Y { get { return _y; } }
        private int _armour;// armour value of tank  
        public int armour { get { return _armour; } }
        private int _acc;// accuracy of tank 
        public int acc { get { return _acc; } }
        private int _speed;// accuracy of tank 
        public int speed { get { return _speed; } }
        private int _attackpower;// accuracy of tank 
        public int attackpower { get { return _attackpower; } }
        private int _range;// hwo far the gun can shoot
        public int range { get { return _range; } }
        private int _movementactionpoints;// how many movement action it can do 
        public int movactpoints { get { return _movementactionpoints; } }
        private bool _havefired;// how many movement action it can do 
        public bool havefired { get { return _havefired; } }
    }
    
    
    class tile //basic class for the tiles 
    {
        Texture2D grassTexture;
        private int _x;// x position
        public int X {get { return _x;}}
        private int _y;// y postion 
        public int Y { get { return _y; } }
        private int _type;// what type as in grass foret moutain road
        public int Type { get { return _type; } }

        private int _movemod;// how ti modifies the movemnt of tanks like -1 or +"
        public int Movemod { get { return _movemod;} }

        private int _defmod;// if the teraain adds defense 
       public int Defmod { get { return _defmod; } }
        private int _accmod;//if it deacrease or increase attack 
        public int Accmod { get { return _accmod; } }
        public tile (int  type, int movemod, int defmod,int ACCmod,int x , int y)//constructure
        {
            _type = type;
            _movemod = movemod;
            _defmod = defmod;
            _accmod = ACCmod;
            _x = x;
            _y = y;
        }
       
        
    }
    
}

