using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercises {
    class warrior : character
    {
        public int stamina;

        public warrior (string name) : base (name) {
        }

        public warrior (string name, int hp) : base (name, hp) {
        }

        public warrior (string name, int hp, stats stats) : base (name, hp, stats) {
        }
    }
}
