using System;
using System.Collections.Generic;

namespace EncapInheritPoly
{
    //Answers to Questions
    //3.1
    //Q.1 Can you directly access the variables?
    //A.1 No, they are private. I must use the get/set methods
    //3.2
    //Q.1 If we want all birds should have an additional property, In which class should we add it?
    //A.1 In the "Bird" class
    //Q.2 If the new property should be used for all animals, in which class should we add it?
    //A.2 In the "Animal" class

    class Program
    {
        static void Main(string[] args)
        {
            

            //3.1.1
            Console.WriteLine("Hello World!");
        //    Person per = new Person();
            //per.Age = 35;
            //int t = per.Age;
            //Console.WriteLine(t);

            //3.1.2
        //    PersonHandler ph = new PersonHandler();
        //    ph.SetAge(per, 99);
         //   Console.WriteLine(per.Age);

            //3.1.4
            PersonHandler ph2 = new PersonHandler();
            ph2.CreatePerson(44, "Calle", "Persson", 1.65, 80);
            ph2.CreatePerson(66, "Olle", "Ohlsson", 1.80, 105);
            ph2.CreatePerson(19, "Ulla", "Nilsson", 1.50, 55);

            ph2.IsPensioner();
            ph2.isOverweight();

            
        }
    }
}
