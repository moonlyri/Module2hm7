using System;
namespace Module2hm7
{
    public class CoffeeMachine : EAppliances, CountService
    {
        public CoffeeMachine()
        {
            CoffeeMachine machine = new CoffeeMachine();
            machine.Plug();
        }

        public void Plug()
        {
            
        }
        private int _power { get; set; }
        public int Power { get; set; }
        public int CfMachinePower(int Power)
        {
            return _power;
            Power = 23;
        }

    }
}

