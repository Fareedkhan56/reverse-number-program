using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_number_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to my reverse number program");
            Console.Write("do you want to reverse your number press y for yes and n for no : ");
            string yesOrNo = (Console.ReadLine());
            if (yesOrNo == "y" || yesOrNo == "Y")
            {
                Console.Write("enter your number : ");
                long userNumber = Convert.ToInt64(Console.ReadLine());
                long result = 0;
                long rem;

                while (userNumber != 0)
                {
                    rem = userNumber % 10;
                    result = result * 10 + rem;
                    userNumber = userNumber / 10;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("good bye");
            }
            Console.ReadLine();
        }
    }
}
