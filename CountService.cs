using System;
namespace Module2hm7
{
    public interface CountService 
    {
        public void Count()
        {
            int LampPower = new EAppliances().Power;
            int CfPower = new CoffeeMachine().Power;
            int TPower = new Toaster().Power;
            int CompPower = new Computer().Power;
            int FPower = new Fridge().Power;
            int Count = LampPower + CfPower + TPower + CompPower + FPower;
        }
    }
}

