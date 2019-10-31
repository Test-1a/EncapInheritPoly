using System;
using System.Collections.Generic;
using System.Text;

namespace EncapInheritPoly
{
    //3.2.1
    class Animal
    {
        //private string name;
        //private double weight;
        //private int age;

        public string Name { get; set; }
        public double  Weight { get; set; }
        public int Age { get; set; }

        //3.2.3
        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        //3.2.2
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        name = value;
        //    }
        //}

        //public double Weight
        //{
        //    get
        //    {
        //        return weight;
        //    }

        //    set
        //    {
        //        weight = value;
        //    }
        //}

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }

        //    set
        //    {
        //        age = value;
        //    }
        //}
    }

    //3.2.4, 3.2.5
    class Horse : Animal
    {
        //private double pullWeight;

        public double PullWeight { get; set; }

        public Horse(string name, double weight, int age, double pull) : base(name, weight, age)
        {
            PullWeight = pull;
        }

        //public double PullWeight
        //{
        //    get
        //    {
        //        return pullWeight;
        //    }

        //    set
        //    {
        //        pullWeight = value;
        //    }
        //}
    }

    //3.2.4, 3.2.5
    class Dog : Animal
    {
        //private bool isGuardDog;

        public bool IsGuardDog { get; set; }

        public Dog(string name, double weight, int age, bool isGuardDog) : base(name, weight, age)
        {
            IsGuardDog = isGuardDog;
        }

        //public bool IsGuardDog
        //{
        //    get
        //    {
        //        return isGuardDog;
        //    }

        //    set
        //    {
        //        isGuardDog = value;
        //    }
        //}
    }

    //3.2.4, 3.2.5
    class Hedgehog : Animal
    {
        //private int numberOfSpikes;

        public int NumberOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int num) : base(name, weight, age)
        {
            NumberOfSpikes = num;
        }

        //public int NumberOfSpikes
        //{
        //    get
        //    {
        //        return numberOfSpikes;
        //    }

        //    set
        //    {
        //        numberOfSpikes = value;
        //    }
        //}
    }

    //3.2.4, 3.2.5
    class Bird : Animal
    {
        //private double wingSpan;

        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingspan) : base(name, weight, age)
        {
            WingSpan = wingspan;
        }

        //public double WingSpan
        //{
        //    get
        //    {
        //        return wingSpan;
        //    }

        //    set
        //    {
        //        wingSpan = value;
        //    }
        //}
    }

    //3.2.6
    class Pelican : Bird
    {
        //private double mouthVolume;
        public double MouthVolume { get; set; } //automatically get a "private int mouthVolume"
                                                //and getters/setters according to code below

        public Pelican(string name, double weight, int age, double wingspan, double mouthVol) : base(name, weight, age, wingspan)
        {
            MouthVolume = mouthVol;
        }

        //public double MouthVolume
        //{
        //    get
        //    {
        //        return mouthVolume;
        //    }

        //    set
        //    {
        //        mouthVolume = value;
        //    }
        //}
    }

    //3.2.6
    class Flamingo : Bird
    {
        public string ColorOfPink { get; set; }

        public Flamingo(string name, double weight, int age, double wingspan, string color) : base(name, weight, age, wingspan)
        {
            ColorOfPink = color;
        }
    }

    //3.2.6
    class Swan : Bird
    {
        public double NeckLength { get; set; }

        public Swan(string name, double weight, int age, double wingspan, double neckl) : base(name, weight, age, wingspan)
        {
            NeckLength = neckl;
        }
    }
}



