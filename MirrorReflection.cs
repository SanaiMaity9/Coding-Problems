using System;

namespace CodingProblems
{
    public class MirrorReflection{
        public static void Main(string[] arg ){
            Console.WriteLine("Enter the number of values");
            int size = Convert.ToInt32(Console.ReadLine());    
            string[] value = new string[size];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = Console.ReadLine();
            }
            Console.WriteLine("Output");
            for (int i = 0; i < value.Length; i++)
            {
                 string result = value[i];
                // char[] stringToArray = value[i].ToCharArray();
                 Console.WriteLine(Reverse(result));
            }
         }
       public static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
   }
}