using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercises {
    class rogue : character {
        public rogue (string name) : base (name) {
        }

        public rogue (string name, int hp) : base (name, hp) {
        }

        public rogue (string name, int hp, stats stats) : base (name, hp, stats) {
        }
    }
}
