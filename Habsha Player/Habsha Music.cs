using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habsha_Player
{
    class Habsha_Music
    {
        public string Artist { get; set; }
        public string Albums { get; set; }
        public string Song { get; set; }

        public static Habsha_Music GetHabsha_Music { get; set; }
    }
}
