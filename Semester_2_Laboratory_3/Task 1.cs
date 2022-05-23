using System;
using System.Collections.Generic;

namespace Semester_2_Laboratory_3
{
    class Clothes
    {
        public virtual void WearClothes()
        {
            Console.WriteLine("Class Clothes: WearClothes()");
        }

        public virtual void ChooseDifferentClothes()
        {
            Console.WriteLine("Class Clothes: ChooseDifferentClothes()");
        }
    }

    class Jacket : Clothes
    {
        public override void WearClothes() 
        {
            Console.WriteLine("Class Jacket: WearClothes()");
        }

        public override void ChooseDifferentClothes()
        {
            Console.WriteLine("Class Jacket: ChooseDifferentClothes()");
        }
    }

    class Shirt : Clothes
    {
        public override void WearClothes()
        {
            Console.WriteLine("Class Shirt: WearClothes()");
        }

        public override void ChooseDifferentClothes()
        {
            Console.WriteLine("Class Shirt: ChooseDifferentClothes()");
        }
    }

    class Pants : Clothes
    {
        public override void WearClothes()
        {
            Console.WriteLine("Class Pants: WearClothes()");
        }

        public override void ChooseDifferentClothes()
        {
            Console.WriteLine("Class Pants: ChooseDifferentClothes()");
        }
    }

    class Shoes : Clothes
    {
        public override void WearClothes()
        {
            Console.WriteLine("Class Shoes: WearClothes()");
        }

        public override void ChooseDifferentClothes()
        {
            Console.WriteLine("Class Shoes: ChooseDifferentClothes()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Clothes> clothes = new List<Clothes>
            {
                new Shoes(),
                new Pants(),
                new Shoes(),
                new Shirt(),
                new Jacket(),
            };
            foreach (var item in clothes)
            {
                item.WearClothes();
            }
        }
    }
}
