using System;
using System.Collections.Generic;
using System.Text;

namespace EncapInheritPoly
{
    //3.2.1
    abstract class Animal
    {
        //3.2.2
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

        //3.3.1
        public abstract string Stats();
        
    }

    //3.2.4, 3.2.5
    class Horse : Animal
    {
        public double PullWeight { get; set; }

        public Horse(string name, double weight, int age, double pull) : base(name, weight, age)
        {
            PullWeight = pull;
        }

        //3.3.2
        public override string Stats()
        {
            return $"Name: {Name.ToString()}, \tWeight: {Weight.ToString()} kg, Age: {Age.ToString()} years,  PullWeight: {PullWeight.ToString()} kg";
        }
    }

    //3.2.4, 3.2.5
    class Dog : Animal
    {
        public bool IsGuardDog { get; set; }

        public Dog(string name, double weight, int age, bool isGuardDog) : base(name, weight, age)
        {
            IsGuardDog = isGuardDog;
        }

        //3.3.2
        public override string Stats()
        {
            return $"Name: {Name.ToString()}, \tWeight: {Weight.ToString()} kg, \tAge: {Age.ToString()} years, \tIs a Guard Dog: {IsGuardDog.ToString()}";
        }

        //3.3.12
        public string Speak()
        {
            return "Woff!";
        }
    }

    //3.2.4, 3.2.5
    class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int num) : base(name, weight, age)
        {
            NumberOfSpikes = num;
        }

        //3.3.2
        public override string Stats()
        {
            return $"Name: {Name.ToString()}, \tWeight: {Weight.ToString()}, \tAge: {Age.ToString()}, \tNumberOfSpikes: {NumberOfSpikes.ToString()}";
        }
    }

    //3.2.4, 3.2.5
    class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingspan) : base(name, weight, age)
        {
            WingSpan = wingspan;
        }

        //3.3.2
        public override string Stats()
        {
            return $"Name: {Name.ToString()}, \tWeight {Weight.ToString()} kg, \tAge: {Age.ToString()} years, \tWingspan: {WingSpan.ToString()} m";
        }
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

        //3.3.2
        public override string Stats()
        {
            return $"Name: {Name.ToString()}, \tWeight {Weight.ToString()} kg, \tAge: {Age.ToString()} years, \tWingspan: {WingSpan.ToString()} m, \tMouthVolume: { MouthVolume.ToString()} l";
        }
    }

    //3.2.6
    class Flamingo : Bird
    {
        public string ColorOfPink { get; set; }

        public Flamingo(string name, double weight, int age, double wingspan, string color) : base(name, weight, age, wingspan)
        {
            ColorOfPink = color;
        }

        //3.3.2
        public override string Stats()
        {
            return $"Name: {Name.ToString()}, \tWeight {Weight.ToString()} kg, \tAge: {Age.ToString()} years, \tWingspan: {WingSpan.ToString()} m, \tColorOfPink: { ColorOfPink.ToString()}";
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

        //3.3.2
        public override string Stats()
        {
            return $"Name: {Name.ToString()}, \tWeight {Weight.ToString()} kg, \tAge: {Age.ToString()} years, \tWingspan: {WingSpan.ToString()} m, \tNeckLength: { NeckLength.ToString()} m";
        }
    }
}



