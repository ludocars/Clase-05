using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercises {
    class wizard : character
    {
        public int mp;

        public wizard (string name) : base (name) {
        }

        public wizard (string name, int hp, int mp) : base (name, hp) {
            this.mp = mp;
        }

        public wizard (string name, int hp, int mp, stats stats) : base (name, hp, stats) {
        }
    }
}
