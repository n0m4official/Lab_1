using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat_Lab1
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Class \n");

            Person p1 = new Person(1,
                "Ian",
                "Brooks",
                "Red",
                30,
                true);

            Person p2 = new Person(2,
                "Gina",
                "James",
                "Blue",
                18,
                false);

            Person p3 = new Person(3,
                "Mike",
                "Briscoe",
                "Blue",
                45,
                true);

            Person p4 = new Person(4,
                "Mary",
                "Beals",
                "Yellow",
                28,
                true);

            p2.displaypersoninfo();
            Console.WriteLine(p3.ToString());
            p1.changefavcolour();
            p1.displaypersoninfo();
            p4.getageplusten();

            Relation r1 = new Relation(Relation.ERelationship.Brother);
            r1.ShowRelationShip(p1, p3);

            Relation r2 = new Relation(Relation.ERelationship.Sister);
            r2.ShowRelationShip(p2, p4);

            List<Person> list = new List<Person>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);

            foreach (Person pi in list)
            {
                if (pi.firstname.Contains("M"))
                {
                    Console.WriteLine($"{pi.ToString()}");
                }
            }

            foreach (Person pi in list)
            {
                if (pi.favcolour.Contains("Blue"))
                {
                    Console.WriteLine($"{pi.ToString()}");
                }
            }

            p4.age = 28;

            List<float> list1 = new List<float>();
            list1.Add(p1.age);
            list1.Add(p2.age);
            list1.Add(p3.age);
            list1.Add(p4.age);

            Console.WriteLine($"The average age is: {Convert.ToDecimal(String.Format("{0:.00}", (list1.Sum() / list1.Count())))}");

            foreach (Person pi in list)
            {
                if (pi.age == 18)
                {
                    Console.WriteLine($"The youngest is: {pi.firstname}");
                }

                if (pi.age == 45)
                {
                    Console.WriteLine($"The oldest is: {pi.firstname}");
                }
            }

            
        }
    }
}