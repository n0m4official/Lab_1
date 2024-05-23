using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mat_Lab1
{
    internal class Relation
    {
        private ERelationship _relationshiptype;

        public enum ERelationship
        {
            Sister,
            Brother,
            Mother,
            Father
        }

        public Relation(ERelationship r)
        {
            _relationshiptype = r;
        }

        public void ShowRelationShip(Person p1,  Person p2)
        {
            Console.WriteLine($"{p1.firstname} and {p2.firstname} are: {_relationshiptype}");
        }
    }
}
