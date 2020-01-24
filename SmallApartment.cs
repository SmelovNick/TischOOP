namespace TischOOP
{
    class SmallApartment : House
    {

        public SmallApartment() : base()
        {
            _area = 50;
        }
        public SmallApartment(string doorColor)
        {
            _area = 50;
            _door.Color = doorColor;
        }
    }
}
