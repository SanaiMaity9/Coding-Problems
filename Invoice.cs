using System;

namespace CodingProblems
{
    public class Invoice{
        public static void Main(string[] arg ){
            Console.WriteLine("Enter the number of items bought");
            int size = Convert.ToInt32(Console.ReadLine());    
            float[] value = new float[size];
            float sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = Convert.ToInt32(Console.ReadLine());
                sum += value[i];
            }
            if(sum <= 1000 )
            {
                Console.WriteLine(sum);
            }
            else
            {
               float result =  Discount(sum);
               Console.WriteLine("Total " + result);
            }
        }
        public static float Discount( float sum )
        {
            float result = sum - (sum / 10) ;
            return result;
        }
    }
}