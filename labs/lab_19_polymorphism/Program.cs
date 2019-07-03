using System;

namespace lab_19_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.ThrowAParty();
            var c01 = new Child01();
            c01.ThrowAParty();
            var c02 = new Child02();
            c02.ThrowAParty();
        }
    }

    class Parent
    {
        public virtual void ThrowAParty()
        {
            Console.WriteLine("Parent is throwing a posh dinner party only for Base Classes");
        }
    }

    class Child01 : Parent
    {
        public override void ThrowAParty()
        {
            Console.WriteLine("HAve funn with kids in the pool.");
        }
    }

    class Child02 : Parent
    {
        public override void ThrowAParty()
        {
            Console.WriteLine("Evening out.");
        }
    }
}
