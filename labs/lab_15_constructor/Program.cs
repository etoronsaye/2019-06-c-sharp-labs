using System;

namespace lab_15_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Bob = new Person("ABC123", "donttellthis", "Peter");
            var Peter = new Person("ABC123","donttellthis","Peter");
            Peter.SetNINO("DEF456", "ihavenoidea");
            Console.WriteLine(Peter.SetNINO("DEF456", "ihavenoidea"));
            Console.WriteLine(Peter.GetNINO("donttellthis"));
        }
    }

    class Person
    {
        private string NINO;
        private string password;
        public string Name;

        //constructor : public + name of class
        public Person(string NINO, string password, string Name)
        {
            this.NINO = NINO;
            this.password = password;
            this.Name = Name;
        }

        public bool SetNINO(string newNINO, string password)
        {
            bool itWorked = false;
            if(this.password == password)
            {
                this.NINO = newNINO;
                itWorked = true;
            }
            return itWorked;
        }

        public string GetNINO(string password)
        {
            string returnNINO = "";
            if (this.password == password)
            {
                returnNINO = this.NINO;
            }
            return returnNINO;
        }
    }
}
