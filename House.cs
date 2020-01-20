using System;
using System.Collections.Generic;
using System.Text;

namespace TischOOP
{
    class House
    {
        private protected int area;
        private protected Door door;
        public int Area 
        { 
            set 
            {
                if (value > 0) area = value;
            } 
            get 
            {
                return area;
            } 
        }
        public House() { }
        public House(string doorColor) { door.Color = doorColor; }
        public House(int area, string doorColor)
        {
            this.area = area;
            door.Color = doorColor;
        }
        public void ShowData() 
        {
            Console.WriteLine("I am a house, my area is {0} m2", area);
        }

        public Door GetDoor() 
        {
            return door;
        }
    }
    public struct Door
    {
        private String color;
        public string Color
        {
            get
            {
                return color;
            }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}", color);
        }
    }
}
