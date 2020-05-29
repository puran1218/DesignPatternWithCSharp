using System;

namespace chapter0_OO.OOBasicLibrary
{
    abstract public class Animal
    {
        protected string name = "";
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal()
        {
            this.name = "noName";
        }

        protected int shoutNum = 3;
        public int ShoutNum
        {
            get
            {
                return shoutNum;
            }
            set
            {
                if (value <= 10)
                    shoutNum = value;
                else
                    shoutNum = 10;
            }
        }

        public void Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += getShoutSound() + ", ";
            }

            Console.WriteLine("My name is " + name + ", " + result);
        }
        protected abstract string getShoutSound();
    }
}