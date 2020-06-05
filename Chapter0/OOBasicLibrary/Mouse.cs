using System;

namespace chapter0_OO.OOBasicLibrary
{
    public class Mouse
    {
        private string name;
        public Mouse(string name)
        {
            this.name = name;
        }
        public void Run()
        {
            Console.WriteLine("Tom Cat is coming, run {0}.", name);
        }
    }
}