using System;

namespace TischOOP
{
    class Person
    {
        private string _name;
        private House _house;

        public Person(string name, House house) 
        {
            this._name = name;
            this._house = house;
        }
        public void ShowData() 
        {
            Console.WriteLine("Name: {0} \nArea: {1}\nDoor Color: {2}", _name, _house.Area, _house.Door.Color);
            _house.ShowData();
            _house.Door.ShowData();
        }
    }
}
