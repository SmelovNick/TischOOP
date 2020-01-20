using System;

namespace TischOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            House flat = new SmallApartment("green");
            Person peter = new Person("peter", flat);
            peter.ShowData();
            House flat2 = new House(200, "black");
            Person ivan = new Person("ivan", flat2);
            ivan.ShowData();
            House flat3 = new SmallApartment();
        }
    }
}
