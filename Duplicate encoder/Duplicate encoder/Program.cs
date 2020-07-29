using System;
using System.Linq;


namespace Duplicate_encoder
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputStr = Console.ReadLine().ToLower();
            string outputStr = inputStr;

            char[] inputCharArray = inputStr.ToCharArray();
            char[] outputCharArray = new char[inputCharArray.Length];


           

            for (int i = 0; i < inputCharArray.Length; i++)
            {


                int count = inputCharArray.Count(ch => ch == inputCharArray[i]);

                if (count == 1)
                {
                    outputStr = outputStr.Replace(inputCharArray[i], '(');
                }
                if (count > 1)
                {
                    outputStr = outputStr.Replace(inputCharArray[i], ')');
                }
            }


            Console.WriteLine(outputStr);
            
        }
    }
}
