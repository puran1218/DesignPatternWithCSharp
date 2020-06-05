using System;
using chapter0_OO.OOBasicLibrary;

namespace OOBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n封装、继承、多态");
            Cat cat = new Cat("cat_name");
            cat.ShoutNum = 6;
            cat.Shout();

            Console.WriteLine("\n接口");
            MachineCat machineCat = new MachineCat("Ding dang");
            machineCat.ShoutNum = 5;
            machineCat.ChangeThing("Time.");

            Console.WriteLine("\n集合与泛型");
            Register register = new Register();
            register.register();
            register.competition();
            
            Console.WriteLine("\n委托与事件");
            TomCat tomCat = new TomCat("Tom");
            Mouse mouse1 = new Mouse("Jerry");
            Mouse mouse2 = new Mouse("Jack");

            // 将Mouse的Run方法通过实例化委托TomCat.TomCatShouEventHandler登记到tomCat的TomCatShout当中
            tomCat.TomCatShout += new TomCat.TomCatShouEventHandler(mouse1.Run);
            tomCat.TomCatShout += new TomCat.TomCatShouEventHandler(mouse2.Run);

            tomCat.Shout();
        }
    }
}
