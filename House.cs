using System;

namespace TischOOP
{
    class House
    {
        private protected int _area;
        private protected Door _door;
        public int Area 
        { 
            set 
            {
                if (value > 0) _area = value;
            } 
            get 
            {
                return _area;
            } 
        }
        public House() { }
        public House(string doorColor) { _door.Color = doorColor; }
        public House(int area, string doorColor)
        {
            this._area = area;
            _door.Color = doorColor;
        }
        public void ShowData() 
        {
            Console.WriteLine("I am a house, my area is {0} m2", _area);
        }

        public Door Door
        {
            set { _door = value; }
            get { return _door; }
        }
    }
    public struct Door
    {
        private String _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set { _color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}", _color);
        }
    }
}
