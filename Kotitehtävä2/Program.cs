using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //cDs voi olla ihan mikä vaan
            CD cD = new CD();
        
            CD cd1 = new CD { Artist = "artisti", CDName = "cd name", SongName = "song" };
            CD cd2 = new CD { Artist = "artisti", CDName = "cd name", SongName = "song" };
            CD cd3 = new CD { Artist = "artisti", CDName = "cd name", SongName = "song" };
            CD cd4 = new CD { Artist = "artisti", CDName = "cd name", SongName = "song" };
            CD cd5 = new CD { Artist = "artisti", CDName = "cd name", SongName = "song" };

            
























            //get one person
            Console.WriteLine("get on person from collection: ");
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in that position...");
            }
            //find person with sotu

            string socialSecurityNumber = "01001-234H";
            Console.WriteLine("find person with sotu :" + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("not found...");
            }
        }
    }
}

