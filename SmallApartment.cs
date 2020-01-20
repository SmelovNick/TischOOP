using System;
using System.Collections.Generic;
using System.Text;

namespace TischOOP
{
    class SmallApartment : House
    {

        public SmallApartment()
        {
            area = 50;
        }
        public SmallApartment(string doorColor)
        {
            area = 50;
            door.Color = doorColor;
        }
    }
}
