using System;

namespace chapter0_OO.OOBasicLibrary
{
    public class MachineCat : Cat, IChange
    {
        public MachineCat() : base()
        {

        }
        public MachineCat(string name) : base(name)
        {

        }
        public void ChangeThing(string thing)
        {
            base.Shout();
            Console.WriteLine("I has a magic pocket to change: " + thing);
        }
    }
}