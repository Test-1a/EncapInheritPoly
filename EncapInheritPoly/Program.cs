﻿using System;
using System.Collections.Generic;

namespace EncapInheritPoly
{
    //Answers to Questions
    //3.1
    //Q.1 Can you directly access the variables?
    //A.1 No, they are private. I must use the get/set methods

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            //3.1.1
            Console.WriteLine("Hello World!");
            Person per = new Person();
            //per.Age = 35;
            //int t = per.Age;
            //Console.WriteLine(t);

            //3.1.2
            PersonHandler ph = new PersonHandler();
            ph.SetAge(per, 99);
            Console.WriteLine(per.Age);

            //3.1.4
            PersonHandler ph2 = new PersonHandler();
            personList.Add(ph2.CreatePerson(44, "Calle", "Persson", 1.65, 80));
            personList.Add(ph2.CreatePerson(66, "Olle", "Ohlsson", 1.80, 105));
            personList.Add(ph2.CreatePerson(19, "Ulla", "Nilsson", 1.50, 55));

            
        }
    }
}