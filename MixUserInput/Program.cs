using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixUserInput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first word.");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter the second word.");
            string secondWord = Console.ReadLine();           
            
            Console.WriteLine(MixWords(firstWord,secondWord));
            Console.ReadKey();

        }

        private static string MixWords(string a, string b)
        {
            char[] aCharArray = a.ToCharArray();
            char[] bCharArray = b.ToCharArray();

            char[] aAndbArray = new char[aCharArray.Length + bCharArray.Length];
            aAndbArray = a.Concat(b).ToArray();            

            char[] newWordArray = new char[aAndbArray.Length];


            Random rnd = new Random();

            List<int> numbers = new List<int>();
            for (int i = 0; i < newWordArray.Length; i++)
            {
                
                int index = rnd.Next(0, aAndbArray.Length);
                while (numbers.Contains(index))
                {
                    index = rnd.Next(0, aAndbArray.Length);                   
                }
                if (!numbers.Contains(index))
                {
                    numbers.Add(index);
                    newWordArray[i] = aAndbArray[index];
                }

            }
            
            return String.Concat(newWordArray);

        }
    }
}
