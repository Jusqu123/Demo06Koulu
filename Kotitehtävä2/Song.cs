using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä2
{
    class CDs
    {

        private List<CD> cDs;


        public CDs()
        {
            cDs = new List<CD>();
        }

        /// <param name="cD"
        public void AddCd(CD song)
        {
            cDs.Add(song);
        }
        public void PrintCollection()
        {
            Console.WriteLine("Songs in collection:");
            foreach (CD cD in cDs)
            {
                Console.WriteLine(cD.ToString());
            }
        }
    }
}

