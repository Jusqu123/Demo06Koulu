using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä2
{
    class CD
    {
        public string Artist { get; set; }
        public string CDName { get; set; }
        public string SongName { get; set; }

        public override string ToString()
        {
            return Artist + " " + CDName + " " + SongName;
        }
    }
}
