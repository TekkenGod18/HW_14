using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_14
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal()
        {

        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine($"Название животного: {Name}");
            Console.Write("Звук: ");
            Say();
        }
    }

    public class Cat : Animal
    {
        private string _name;

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Cat() : base()
        {
            Name = "Кот";
        }

        public Cat(string name) : base()
        {
            Name = name;
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    public class Dog : Animal
    {
        private string _name;

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Dog() : base()
        {
            Name = "Собака";
        }

        public Dog(string name) : base()
        {
            Name = name;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
