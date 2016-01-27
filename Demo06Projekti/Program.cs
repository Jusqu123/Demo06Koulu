using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object from persons
            //myfriends voi olla ihan mikä vaan
            Persons myFriends = new Persons();
            // create a frieands...
            Person person1 = new Person {Firstname ="Juuso", Lastname="hattunen",SocialSecurityNumber="010101-234H" };
            Person person2 = new Person { Firstname = "veli", Lastname = "viljami", SocialSecurityNumber = "675935-976B" };
            Person person3 = new Person { Firstname = "Matias", Lastname = "jokinen", SocialSecurityNumber = "836504-231P" };
            //add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);


            //print collection
            myFriends.PrintCollection();


            //get one person
            Console.WriteLine("get on person from collection: ");
         Person person4 =  myFriends.GetPerson(0);
            if(person4 != null)
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



//https://github.com/Jusqu123/Demo06Koulu.git