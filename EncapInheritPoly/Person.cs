using System;
using System.Collections.Generic;
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
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        //3.1.3
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person();
            p.Age = age;
            p.FName = fname;
            p.LName = lname;
            p.Height = height;
            p.Weight = weight;

            return p;
        }

        //3.1.4
        public bool IsPensioner(Person p)
        {
           // p.Age > 65 ? true : false;

            if(p.Age > 65)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool isOverweight(Person p)
        {
            if(p.Weight > 70)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
