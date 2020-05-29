namespace chapter0_OO.OOBasicLibrary
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            
        }
        public Cat() : base()
        {
            
        }
        protected override string getShoutSound()
        {
            return "miao";
        }
    }
}