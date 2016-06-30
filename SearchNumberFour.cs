using System;

namespace CodingProblems
{
    public class SearchNumberFour{
         public static void Main(string[] arg ){
             int size = 0, j = 0;
             Console.WriteLine("Enter the Size of array");
             size = Convert.ToInt32(Console.ReadLine());
             int[] Numbers = new int[size];
             Console.WriteLine("Enter the Numbers for Checking for number four");
             for (int i = 0; i < size; i++)
             {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());  
             }
                for(int i = 0; i < size; i++) {
                    int count = 0;
                    int number = Numbers[i];
                    while(number>0){
                    int remainder = number  % 10;
                    int quotient = number / 10;
                    if(remainder == 4){
                        count++;
                    }
                    number = quotient;
                    }
                Console.WriteLine(count);     
            }
       }
    }
}