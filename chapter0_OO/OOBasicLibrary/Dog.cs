using System;

namespace chapter0_OO.OOBasicLibrary
{
    public class Dog : Animal
    {
        public Dog() : base()
        {

        }
        public Dog(string name) : base(name)
        {

        }
        protected override string getShoutSound()
        {
            return "wang";
        }
    }
}
