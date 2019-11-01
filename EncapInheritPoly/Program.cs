using System;
using System.Collections.Generic;

namespace EncapInheritPoly
{
    //Answers to Questions
    //3.1
    //Q.1 Can you directly access the variables?
    //A.1 No, they are private. I must use the get/set methods

    //3.2
    //Q.8 If we want all birds should have an additional property, In which class should we add it?
    //A.8 In the "Bird" class
    //Q.9 If the new property should be used for all animals, in which class should we add it?
    //A.9 In the "Animal" class

    //3.3
    //Q.7 Why can't you add a Horse to your Dog List?
    //A.7 Because a Horse cannot be casted to a Dog
    //Q.8 Which type must the List take for all your animals to be accepted
    //A.8 Type Animal since every animal can be casted to an Animal
    //Q.10 Explain why you get the results you get fromthe Stats() printout
    //A.10 Because even though you save for example a Swan as an Animal in the List, the object that Stats() 
    //        is invoked on is still a Swan so it prints a Swan's properties
    //Q.13 Try calling the method "Speak()" in Dog from the List Animals using a foreach. Why doesn't it work?
    //A.13 Because in foreach we get a Animal to work with and an Animal does not have a "Speak" method
    //Q.14 How can you get it to work?
    //A.14 By casting the "Animal" you get from foreach to a "Dog" and then invoke the Speak-method on the casted Dog-object

    //3.4
    //Q.11 Why is polymorphism important?
    //A.11 Because we can reuse code. Members in a Base class will be inherited by the Derived class => don't have to duplicate code
    //Q.12 How can polymorphism be used to write cleaner and better code?
    //A.12 We write less code since the Derived class inherit = reuse code from the Base class
    //Q.13 What is the difference between an abstract class and an interface?
    //A.13  An abstract class can have code/implementation, an interface cannot have any implemented methods
    //      An abstract method can have fields, an interface cannot have fields
    //      A class can inherit several interfaces but only one abstract class


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

            Console.WriteLine();
            Horse h = new Horse("Johan", 200, 15, 700);
            Console.WriteLine(h.Stats());

            Dog d = new Dog("Karo", 20, 2, true);
            Console.WriteLine(d.Stats());

            Hedgehog he = new Hedgehog("Stickis", 2, 3, 1500);
            Console.WriteLine(he.Stats());

            Bird b = new Bird("Jacko", 15, 30, 2.3);
            Console.WriteLine(b.Stats());

            Pelican p = new Pelican("Pelle", 12, 5, 4.1, 13);
            Console.WriteLine(p.Stats());

            Flamingo f = new Flamingo("Kayo", 10, 4, 4.5, "Dark");
            Console.WriteLine(f.Stats());

            Swan s = new Swan("Swannie", 18, 1, 4.8, 2.8);
            Console.WriteLine(s.Stats());

            //3.3.3
            List<Animal> Animals = new List<Animal>();

            //3.3.4
            Animals.Add(h);
            Animals.Add(d);
            Animals.Add(he);
            Animals.Add(b);
            Animals.Add(p);
            Animals.Add(f);
            Animals.Add(s);

            //3.3.5
            Console.WriteLine();
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.GetType().ToString());
            }

            //3.3.6
            //List<Dog> doggies = new List<Dog>();
            //doggies.Add(h);

            //3.3.9
            Console.WriteLine();
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.Stats());
            }

            //3.3.11
            Console.WriteLine();
            foreach (var animal in Animals)
            {
                //if(animal.GetType().Name == "Dog")
                //if(animal.GetType() == Dog)   //also works
                if(animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }

            //3.3.13
            Console.WriteLine();
            foreach (var animal in Animals)
            {
                //if(animal.GetType().Name == "Dog")    //works if the name of the dog is "Dog"
                //if(animal.GetType() == Dog)   //also works
                if (animal is Dog)
                {
                    Console.WriteLine(((Dog)animal).Speak());
                }
            }

            //3.4.7
            List<UserError> Errors = new List<UserError>();
            NumericInputError error1 = new NumericInputError();
            TextInputError error2 = new TextInputError();
            NumericInputError error3 = new NumericInputError();
            TextInputError error4 = new TextInputError();
            NumericInputError error5 = new NumericInputError();
            TextInputError error6 = new TextInputError();
            Errors.Add(error1);
            Errors.Add(error2);
            Errors.Add(error3);
            Errors.Add(error4);
            Errors.Add(error5);
            Errors.Add(error6);

            //3.4.10
            NonBooleanInputError error7 = new NonBooleanInputError();
            TooBigInputError error8 = new TooBigInputError();
            NegativeInputError error9 = new NegativeInputError();
            Errors.Add(error7);
            Errors.Add(error8);
            Errors.Add(error9);


            //3.4.8
            Console.WriteLine();
            foreach (var error in Errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
