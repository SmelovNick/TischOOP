using System;
using System.Collections.Generic;
using System.Text;

namespace TischOOP
{
    class Person
    {
        string name;
        House house;

        public Person(string name, House house) 
        {
            this.name = name;
            this.house = house;
        }
        public void ShowData() 
        {
            Console.WriteLine("Name: {0} \nArea: {1}\nDoor Color: {2}", name, house.Area, house.GetDoor().Color);
        }
    }
}
