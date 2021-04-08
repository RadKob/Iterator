using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Character[] characters = new Character[4];
            characters[0] = new Character { Hearts = 3, Strength = 1, Defense = 2, Speed = 4 };
            characters[1] = new Character { Hearts = 5, Strength = 1, Defense = 1, Speed = 2 };
            characters[2] = new Character { Hearts = 2, Strength = 3, Defense = 2, Speed = 1 };
            characters[3] = new Character { Hearts = 3, Strength = 2, Defense = 5, Speed = 3 };
            foreach (var item in characters)
            {
                Console.WriteLine("Siła postaci " + item.Power);
            }
            Console.WriteLine("----------");
            Console.WriteLine("Statystyki wskazanej postaci");
            characters[2].Allstats(2);
        }
    }
    public class Character : IEnumerable<int>
    {
        public int[] people = new int[4];
        IEnumerator IEnumerable.GetEnumerator()
        {
            return people.AsEnumerable().GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return people.AsEnumerable().GetEnumerator();
        }

        public int this[int index]
        {
            get => people[index];
            set => people[index] = value;
        }

        private const int hearts = 0;
        private const int strength = 1;
        private const int defense = 2;
        private const int speed = 3;
        public int Hearts { get => people[hearts]; set => people[hearts] = value; }
        public int Strength { get => people[strength]; set => people[strength] = value; }
        public int Defense { get => people[defense]; set => people[defense] = value; }
        public int Speed { get => people[speed]; set => people[speed] = value; }

        public double Power => people.Sum();
        public double AverageStat => people.Average();
        public double MaxStat => people.Max();

        public void Allstats(int x)
        {
            Console.WriteLine("Stats character of number "+ x + " is " + "Life: "+ Hearts + " Damage: " + Strength + " Armor: " + Defense + " Movement: " + Speed);
        }


    }
}
