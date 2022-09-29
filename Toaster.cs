using System;
namespace Module2hm7
{
    public class Toaster : EAppliances, CountService
    {
        public Toaster()
        {
            Toaster toast = new Toaster();
            toast.Plug();
        }
        public void Plug()
        {

        }
        private int _power { get; set; }
        public int Power { get; set; }
        public int ToasterPower(int Power)
        {
            return _power;
            Power = 13;
        }
        
    }
}

