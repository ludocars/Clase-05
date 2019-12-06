using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercises 
{
    abstract class character
    {
        public string name;
        public int HP;
        public stats stats;

        //constructor
        public character (string name)
        {
            this.name = name;
            this.HP = 20;
            this.stats = new stats ();
        }
        public character (string name, int hp)
        {
            this.name = name;
            this.HP = 20;
            this.stats = new stats ();
        }
        public character (string name, int hp, stats stats)
        {
            this.name = name;
            this.HP = 20;
            this.stats = new stats ();
        }
    }
}
