using System;
using System.Collections.Generic;
using System.Collections;

namespace chapter0_OO.OOBasicLibrary
{
    public class Register
    {
        // IList arrayAnimal; // 集合会动态扩容，但是存在装箱拆箱问题，需进行大量的计算
        IList<Animal> arrayAnimal; // 泛型能解决集合的问题
        public void register()
        {
            // arrayAnimal = new ArrayList(); // 集合的实例化方法
            arrayAnimal = new List<Animal>(); // 泛型的实例化方法

            arrayAnimal.Add(new Cat("cat1"));
            arrayAnimal.Add(new Dog("dog1"));
            arrayAnimal.Add(new Cat("cat2"));

            Console.WriteLine(arrayAnimal.Count.ToString());
        }

        public void competition()
        {
            foreach (Animal item in arrayAnimal)
            {
                item.Shout();
            }
        }
    }
}