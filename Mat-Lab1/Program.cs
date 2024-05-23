using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Mat_Lab1
{
    internal class Person
    {
        private int _id;
        private string _firstname;
        private string _lastname;
        private string _favcolour;
        private int _age;
        private bool _working;

        public int id {
            get { return _id; }
            set { _id = value; }
        }

        public string firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string favcolour
        {
            get { return _favcolour; }
            set { _favcolour = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool working
        {
            get { return _working; }
            set { _working = value; }
        }

        public Person(int id, string firstname, string lastname, string colour, int age, bool isworking)
        {
            _id = id;
            _firstname = firstname;
            _lastname = lastname;
            _favcolour = colour;
            _age = age;
            _working = isworking;
        }

        public void displaypersoninfo ()
        {
            Console.WriteLine($"{id}:  {firstname} {lastname}'s favourite colour is {favcolour}.");
        }

        public void changefavcolour ()
        {
            favcolour = "white";
        }

        public void getageplusten ()
        {
            age = age + 10;
            Console.WriteLine($"{firstname} {lastname}'s age in 10 years is {age}.");
        }

        public override string ToString()
        {
            return $"Person ID: {id}\nFirst Name: {firstname}\nLast Name: {lastname}\nFavourite colour: {favcolour}\nAge: {age}\nWorking: {working}";
        }
    }
}