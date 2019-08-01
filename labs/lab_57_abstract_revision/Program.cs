using System;

namespace lab_57_abstract_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var trip = new HolidayPlanned();
            trip.Plan();
            trip.Attractions();
        }
    }

    abstract class HaveAHolidayInParis
    {
        public abstract void Plan();
        public void Attractions()
        {
            Console.WriteLine("We're going to Louvre, Champs-Elysee and finally Galleries Lafayette.");
        }
    }

    class HolidayPlanned : HaveAHolidayInParis
    {
        public override void Plan() { Console.WriteLine("Paris trip planned"); }
    }
}
