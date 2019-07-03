using System;

namespace lab_29_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bytes
            byte b01 = 0;              // min
            byte b02 = 255;            // max
            byte b03 = 0b_1010_0101;   // binary literal
            byte b04 = 0x_FF;          // 0x hexadecimal literal
            byte b05 = 0x_0C;
            Console.WriteLine((int)b05);

            // Buffer
            // Youtube : Video spilt into tiny parts 
            // each part is size of buffer
            // 'videon is buffering'
            // but=ffer is an array of bytes
            byte[] myBuffer = new byte[4000];   // chunk size for send my video

            // char
            // ASCII : first computers maps a NUMBER to every CHARACTER
            // h is 104   H is 72
            // 00000000 
            // 01101000 104-64 = 40-32 = 8
            // 01101001 105-64 = 41-32 = 9-8 = 1
            char char01 = 'c';
            char char02 = 'd';
            Console.WriteLine((int) char01);

            // unicode is upgrade to ascii
            // utf-8 web  getbootstrap.com
            // utf-16   unicode => chinese characters

            const int num10 = 10;  // cannot change num10=100;
            const Double DISPLAY_INT_LIKE_THAT = 5.67;
            var num01 = 10;
            var num03 = "hi";

            //aliases
            string xx = "hi";     // Use this
            String yy = "there";  // String is the class : dont use
                                  // Valid use would be var s = new String();

            // readonly : use in preference of const
            // const shange value to LITERAL (not good)
            // readonly preserve as variable (better)

            // NULL-CHECK 
            string AuthorName = null;
            // int nameLength = AuthorName.Length;
            if(AuthorName != null)
            {
                Console.WriteLine( AuthorName.Length);
            }
            int? nameLength2 = AuthorName?.Length;
            // if Name is null then return null otherwise return length
            int? nullableItem = null;
            //int cannotMakeNull = null;
            int defualtNumber = default;  // 0
            int? defaultNullable = default;  //nullable
            Console.WriteLine(defaultNullable);

            // NULL_COALEASCE

            // TUPLES
                // A tuple is a collection which is ordered and unchangeable.
                // An anonymous type
            void DoThis() { }
            int DoThat() {
                return -1; }
            void DoingSomething (out int result, out string result2)
            {
                result = - 1;
                result2 = "hi";
            }

            //DECLARE
            (string x01, int y01, bool z01) DoingSomethingElse()
            {
                return ("hi", 10, false);
            }

            // CALL
            var output01 = DoingSomethingElse();
            // GET INDIVIDUAL ITEMS
            Console.WriteLine($"{output01.x01}{output01.y01}{output01.z01}");
            //Console.WriteLine($"");
        }
    }

    class x
    {
        public readonly string Y;
    }
}
