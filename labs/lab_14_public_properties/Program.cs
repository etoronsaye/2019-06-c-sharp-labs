using System;

namespace lab_14_public_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bob = new Person();
            Bob.Name = "Bob";
            Bob.SetNINO("ABC123","");
            
            //Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        private string NINO;
        private string password;

        public string Name { get; set; }

        //getter/setter
        public void SetNINO(string newNINO, string password)
        {
            if (this.password == password)
            {
                this.NINO = newNINO;
            }
        }

        public void GetNINO()
        {

        }
    }
}
