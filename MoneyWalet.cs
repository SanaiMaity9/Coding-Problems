using System;

namespace Problems
{
    public class MoneyWalet{
        public static void Main(string[] args){
            MoneyWalet person = new MoneyWalet();
            Console.WriteLine("Enter the Number Of people");
            int NumberOfpeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Total Amount");
            int TotalAmount = Convert.ToInt32(Console.ReadLine());
            int[] PaidAmount = new int[NumberOfpeople];
            for(int i = 0; i < NumberOfpeople; i++){
                Console.WriteLine("person "+(i + 1)+" had paid\n");
                PaidAmount[i] = Convert.ToInt32(Console.ReadLine());
            }
            person.Calculation(NumberOfpeople,TotalAmount,PaidAmount);
        }
        public void Calculation(int NumberOfpeople, int TotalAmount,int[] AmountPaid){
            int[] result = new int[NumberOfpeople];
           
            int dividedMoney = TotalAmount / NumberOfpeople;
            for(int i = 0; i < NumberOfpeople; i++){
                result[i] = AmountPaid[i] - dividedMoney;
            } 
            MoneyDivision(result,dividedMoney,NumberOfpeople);
        }
        public void MoneyDivision(int[] Amount, int AmountToDivide, int NumberOfpeople){
            int[] whomToPay = new int[NumberOfpeople];
            for (int i = 0; i < Amount.Length; i++)
            {
               if(Amount[i] < AmountToDivide && Amount[i] != 0){
                       Console.WriteLine("Person "+(i + 1)+" Amount = "+ Math.Abs(Amount[i]));
            }
            else{
                whomToPay[i] = Array.IndexOf(Amount, Amount[i]);
            }                  
          }  
       }
    }
 }