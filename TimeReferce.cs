using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class TimeReference
    {

        private int timer;

        private Team team;

        public TimeReference(int timer, Team team)
        {
            this.timer = timer;
            this.team = team;
        }

        public int Timer{ get { return timer; } }
        public Team Command{ get { return team; } }



    }
}
