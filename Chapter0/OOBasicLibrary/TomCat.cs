using System;

namespace chapter0_OO.OOBasicLibrary
{
    public class TomCat
    {
        private string name;
        public TomCat(string name)
        {
            this.name = name;
        }

        public delegate void TomCatShouEventHandler();
        public event TomCatShouEventHandler TomCatShout;
        public void Shout()
        {
            Console.WriteLine("Miao, I am {0}.", name);
            if (TomCatShout != null)
            {
                TomCatShout();
            }
        }
    }
}