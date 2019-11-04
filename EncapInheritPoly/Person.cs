using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncapInheritPoly
{
    class Person
    {
        //3.1.1
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }

            set
            {
                lName = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        
    }

    //3.1.2
    class PersonHandler
    {
        List<Person> personList = new List<Person>();

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        //3.1.3
        public void CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person();
            p.Age = age;
            p.FName = fname;
            p.LName = lname;
            p.Height = height;
            p.Weight = weight;

            personList.Add(p);
        }

        //3.1.4
        public string IsPensioner()
        {
            // p.Age > 65 ? true : false;
            var result = "";
            foreach(var p in personList)
            {
                result = p.Age > 65 ? 
                    $"{p.FName} {p.LName} is a pensioner." : 
                    $"{p.FName} {p.LName} is to young for that!";
                //if (p.Age > 65)
                //{
                //    return ($"{p.FName} {p.LName} is a pensioner.");
                //}
                //else
                //{
                //   return ($"{p.FName} {p.LName} is to young for that!");
                //}
            }
            return result;
        }

        public IEnumerable<Person> OverVikt => personList.Where(p => p.Weight > 70);
        
        

        public void isOverweight()
        {
            foreach(var p in personList)
            {
                if (p.Weight > 70)
                {
                    Console.WriteLine($"{p.FName} {p.LName} is overweight.");
                }
                else
                {
                    Console.WriteLine($"{p.FName} {p.LName} is to thin!");
                }
            }
        }


    }
}
