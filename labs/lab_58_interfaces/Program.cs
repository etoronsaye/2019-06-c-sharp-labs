using System;

namespace lab_58_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();
            c.Name = "Sanru Tyson";
            c.Property01 = 100;
            c.UseTool01();

            Console.WriteLine($"{c.DoThat()}");
        }
    }

    interface IToolShedItem01
    {
        // no fields
        // public int Field01;
        // yes properties
        int Property01 { get; set; }
        // yes Methods
        void UseTool01();  // ABSTRACT (ALSO PUBLIC) - AGAIN< PRESENT BUT NOT STATED
    }
    interface IToolShedItem02
    {
        string Property02 { get; set; }
        string DoThat();
    }
    abstract class Parent
    {
        public string Name { get; set; }
        public abstract void DoThis();
    }
    class Child : Parent, IToolShedItem01, IToolShedItem02
    {
        public int Property01 { get; set; }
        public string Property02 { get; set; }
        public override void DoThis()
        {
            // implement abstract override
        }
        public void UseTool01() { Console.WriteLine("Using Tool 01"); }
        public string DoThat() => "Shovel";
    }
}
