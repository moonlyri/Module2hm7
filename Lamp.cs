using System;
namespace Module2hm7
{
    public class Lamp : EAppliances, CountService
    {
        public Lamp()
        {
            Lamp lamp = new Lamp();
            lamp.Plug();
        }
        public void Plug()
        {

        }
        private int _power { get; set; }
        public int Power { get; set; }
        public int LampPower()
        {
            return _power;
            Power = 7;
        }
        
    }
}

