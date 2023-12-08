
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
        public int X { get { return _x; } }
        private int _y;// y postion 
        public int Y { get { return _y; } }
        private int _armour;// armour value of tank  
        public int Armour { get { return _armour; } }
        private int _acc;// accuracy of tank 
        public int Acc { get { return _acc; } }
        private int _speed;// accuracy of tank 
        public int Speed { get { return _speed; } }
        private int _penpower;
        public int Penpower { get { return _penpower; } }
        private bool _apshell;
        public bool Apshell { get { return apshell; } }
        private int _range;// hwo far the gun can shoot
        public int Range { get { return _range; } }
        private int _movementactionpoints;// how many movement action it can do 
        public int Movactpoints { get { return _movementactionpoints; } }
        private bool _havefired;// how many movement action it can do 
        public bool Havefired { get { return _havefired; } }
        public bool[] Components = new bool[5]  // components 1= engine  2= tracks 3=gun 4=turret ring if all destroyed tank is destroyed  tracks can be repaired 
        public bool[] Crewmembers = new bool[5] // crew 1= driver 2= gunner 3= loader 4= commander commander can switch wiht any loader can switch with gunner
        public tank (int x, int y,int armour , int acc ,int speed,int penpower,bool apshell,int range,int movepoints,bool havefired ,bool crewmembers[5],bool components[5])
        {
            Crewmembers[5] = crewmembers[5];
            Components[5] = components[5];
            _x = x;
            _y = y;
            _armour = armour;
            _acc = acc;
            _speed = speed;
            _penpower = penpower;
            _apshell = apshell;
            _range = range;
            _movementactionpoints = movepoints;
            _havefired = havefired;
        }
            
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
        private bool[] components  = new bool[]  // components 1= engine  2= 
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

